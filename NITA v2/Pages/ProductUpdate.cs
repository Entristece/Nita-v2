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
    public partial class ProductUpdate : UserControl
    {
        public bool Deleting { get; set; } = false;
        private int _slot { get; set; }

        public ProductUpdate()
        {
            InitializeComponent();
        }

        public async void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.F2)
            {
                if (!Deleting)
                {
                    Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Warning, $"Aperte F2 novamente para excluir \"{Products_LV.SelectedItem()}\"");
                    Deleting = true;
                    await Task.Delay(5000);
                    Deleting = false;
                }
                DatabaseHook.DeleteProduct(Products_LV.SelectedItem());
                UpdateProducts();
            }
            else if (e == Keys.F12) PageManager.ChangePage(Page.Menu);
            else if (e == Keys.Enter)
            {
                DatabaseHook.UpdateProduct(Products_LV.SelectedItem(), new string[] { EAN_TB.Texto, Name_TB.Texto, Price_TB.Texto });
                UpdateProducts();
            }
        }

        public void UpdateProducts()
        {
            Products_LV.Items.Clear();
            var list = new List<Product>();
            var json = DatabaseHook.GetAllProducts();
            if (!json.Contains("error")) list = Product.Parse(json);
            foreach (var product in list) Products_LV.Items.Add(new Controls.Item(product.NAME, $"R${product.VALUE}"));
        }

        private void ProductUpdate_Load(object sender, EventArgs e)
        {
            Products_LV.Focus();
            UpdateProducts();
        }
    }
}
