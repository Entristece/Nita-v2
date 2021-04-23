using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using NITA_v2.Classes;

namespace NITA_v2.Pages
{
    public partial class ProductRegister : UserControl
    {
        public ProductRegister()
        {
            InitializeComponent();
        }

        public void UpdateProducts()
        {
            Products_LV.Items.Clear();
            var list = new List<Product>();
            var json = DatabaseHook.GetAllProducts();
            if (!json.Contains("error")) list = Product.Parse(json);
            foreach (var product in list) Products_LV.Items.Add(new Controls.Item(product.NAME, $"R${product.VALUE}"));
        }

        public void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.F2) { Name_TB.Texto = ""; EAN_TB.Texto = ""; Price_TB.Texto = ""; Name_TB.Focus(); }
            else if (e == Keys.F12) PageManager.ChangePage(Page.Menu);
            else if (e == Keys.Enter)
            {
                var json = DatabaseHook.RegisterProduct(Name_TB.Texto, EAN_TB.Texto, float.Parse(Price_TB.Texto));
                if (json.Contains("error")) { Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, (string)JObject.Parse(json)["error"]); DatabaseHook.Log($"Tentou cadastrar um produto, mas ocorreu um erro: '{JObject.Parse(json)["error"]}'"); return; }
                else Session.Log($"Cadastrou um produto: '{Name_TB.Texto}, {EAN_TB.Texto}, {Price_TB.Texto}'");
                Price_TB.Texto = "";
                Name_TB.Texto = "";
                EAN_TB.Texto = "";
                UpdateProducts();
                Name_TB.Focus();
            }
        }

        private void ProductRegister_Load(object sender, System.EventArgs e)
        {
            Name_TB.Focus();
            UpdateProducts();
        }
    }
}
