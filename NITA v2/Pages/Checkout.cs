using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NITA_v2.Pages
{
    public partial class Checkout : UserControl
    {
        public Checkout()
        {
            InitializeComponent();
        }

        public void KeyboardHook(object sender, Keys e)
        {

        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            Payment_LV.Items.Add(new Controls.Item(Properties.Resources.Dinheiro_Icone, "Dinheiro"));
            Payment_LV.Items.Add(new Controls.Item(Properties.Resources.Mastercard_Icone, "Cartão"));
        }
    }
}
