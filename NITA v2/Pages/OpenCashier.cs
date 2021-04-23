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
    public partial class OpenCashier : UserControl
    {
        public OpenCashier()
        {
            InitializeComponent();
        }

        public void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.Escape || e == Keys.F12) { PageManager.ChangePage(Page.Menu); }
            else if (e == Keys.Enter)//Tem que lidar melhor com esses dados gay
            {
                var json = DatabaseHook.Login(User_TB.Texto, Password_TB.Texto);

                if (json.Contains("error")) { Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Senha incorreta"); return; };
                if (!decimal.TryParse(Value_TB.Texto, out decimal foo)) { Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Por favor, insira um valor válido."); return; }

                Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Success, "Caixa aberto!");
                PageManager.PointOfSalePage.Caixa_LB.Text = "CAIXA ABERTO";
                Session.CashierMoney = decimal.Parse(Value_TB.Texto);
                PageManager.ChangePage(Page.PointOfSale);
                Session.IsCashierOpen = true;
            }
        }
        
        private void OpenCashier_Load(object sender, EventArgs e)
        {
            Date_TB.Texto = DateTime.Now.ToShortDateString();
            Hour_TB.Texto = DateTime.Now.ToShortTimeString();
            User_TB.Texto = Session.CurrentUser.Username;
        }
    }
}
