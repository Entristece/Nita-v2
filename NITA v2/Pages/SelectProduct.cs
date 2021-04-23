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
    public partial class SelectProduct : UserControl
    {
        public SelectProduct()
        {
            InitializeComponent();
        }

        public void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.Escape) { Select_LV.Items.Clear(); PageManager.ChangePage(Page.PointOfSale); }
            else if (e == Keys.Enter)
            {
                var searchList = new List<Product>();
                var json = DatabaseHook.SearchProduct(Select_LV.Items[Select_LV.Slot].Text);
                if (!json.Contains("error")) searchList = Product.Parse(json);
                PageManager.PointOfSalePage.AddProduct(searchList[0]);
                PageManager.PointOfSalePage.Sale_LV.Items.Add(new Controls.Item(searchList[0].NAME, $"R${searchList[0].VALUE}"));
                PageManager.ChangePage(Page.PointOfSale);
            }
        }
    }
}
