using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NITA_v2.Classes;

namespace NITA_v2.Pages
{
    public partial class PointOfSale : UserControl
    {
        public List<Product> SearchList = new List<Product>();
        public List<Product> SalesList = new List<Product>();
        private Product currentProduct { get; set; }

        public PointOfSale()
        {
            InitializeComponent();
            if (Session.IsCashierOpen) Caixa_LB.Text = "CAIXA ABERTO";
        }

        public void UpdateSubtotal()
        {
            decimal value = 0;
            foreach (var product in SalesList) value = value + product.VALUE;
            Price_LB.Text = $"R$ {value}";
        }

        public void AddProduct(Product product)
        {
            Details_DB.VALUE_LB.Text = $"R$ {product.VALUE}";
            Details_DB.DESC_LB.Text = product.NAME;
            Details_DB.EAN_LB.Text = product.EAN;
            currentProduct = product;
            SalesList.Add(product);
            UpdateSubtotal();
        }

        public async void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.F1) Search_TB.Focus();//Foca na TextBox do EAN
            //else if (e == Keys.F3) new RemoverProduto(PontoDeVendaPage.SalesList).Show();//Abre uma janela para remover um produto da lista de compras
            else if (e == Keys.F4) PageManager.ChangePage(Page.Checkout);
            else if (e == Keys.F12) PageManager.ChangePage(Page.Menu);
            else if (e == Keys.Enter)//Caso o usuário pressione enter...
            {
                if (!Session.CurrentUser.IsSeller) { await Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Você não tem permissão para vender. Por favor, contate um administrador."); return; } //Caso o usuário não tenha cargo de vendedor, exibir esta mensagem e parar por aqui
                if (!Session.IsCashierOpen) { await Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Por favor, abra o caixa antes de continuar."); return; } //Caso o usuário esteja com o caixa fechado, parar por aqui
                switch (ActiveControl.Name)//Se a caixa de texto selecionada for a...
                {
                    case "Search_TB"://...de pesquisa...
                        if (Search_TB.Texto.Length == 0) { await Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Produto não encontrado!"); return; }
                        SearchList = new List<Product>();
                        var json = DatabaseHook.SearchProduct(Search_TB.Texto);
                        if (!json.Contains("error")) SearchList = Product.Parse(json);

                        Search_TB.Texto = "";
                        if (SearchList.Count == 1) AddProduct(SearchList[0]);
                        else if (SearchList.Count == 0) await Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Produto não encontrado!");
                        else if (SearchList.Count > 1)
                        {
                            PageManager.SelectProductPage.Select_LV.Items.Clear();
                            foreach (var item in SearchList)
                                PageManager.SelectProductPage.Select_LV.Items.Add(new Controls.Item(item.NAME, $"R${item.VALUE}"));
                            PageManager.ChangePage(Page.SelectProduct);
                        }
                        break;
                    case "QTD_TB"://...de quantidade...
                        if (SalesList.Count == 0) return;
                        if (!int.TryParse(QTD_TB.Texto, out int quantity)) { QTD_TB.Texto = ""; return; }
                        var lastProduct = SalesList[SalesList.Count - 1];

                        for (var i = 0; i < quantity - 1; i++) AddProduct(lastProduct);
                        QTD_TB.Texto = "";
                        Search_TB.Focus();
                        break;
                    case "Paid_TB"://...de pagamento
                        Search_TB.Focus();
                        UpdateSubtotal();
                        break;
                }
            }
        }

        private void PointOfSale_Load(object sender, EventArgs e)
        {
            BackColor = Config.DarkTone;
            Header_PN.BackColor = Config.DarkestTone;
            Caixa_PN.BackColor = Config.LightestTone;

        }
    }
}
