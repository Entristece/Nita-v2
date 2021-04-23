using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using NITA_v2.Classes;

namespace NITA_v2.Pages
{
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        public void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.F1) PageManager.ChangePage(Page.RegisterUser);
            else if (e == Keys.F2) PageManager.ChangePage(Page.Settings);
            else if (e == Keys.Enter)
            {
                if (!DatabaseHook.HasDBData()) { Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, "Por favor, insira as informações do banco de dados."); return; }
                var json = DatabaseHook.Login(Username_TB.Texto, Password_TB.Texto);
                var obj = JObject.Parse(json);
                if (json.Contains("error")) { Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, (string)obj["error"]); return; }

                Session.CurrentUser = new User((string)obj["username"], (bool)obj["admin"], (bool)obj["seller"]);

                PageManager.MenuPage = new Menu();
                PageManager.ChangePage(Page.PointOfSale);
                Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Success, $"Bem-vind@ {Session.CurrentUser.Username}");
            }
        }

        private void Login_Load(object sender, System.EventArgs e)
        {
            var TextList = new List<Control>() { F1_LB, F2_LB, TAB_LB, Enter_LB, Username_LB, Password_LB, Header_LB };
            var LightList = new List<Control>() { Shortcuts_PN1, Container_PN };
            var DarkestList = new List<Control>() { Header_PN };
            var DarkList = new List<Control>() { Content_PN };
            /*
            foreach (var control in DarkestList) control.BackColor = Config.DarkestTone;
            foreach (var control in LightList) control.BackColor = Config.LightTone;
            foreach (var control in DarkList) control.BackColor = Config.DarkTone;
            foreach (var control in TextList) control.ForeColor = Config.FontTone;*/
        }
    }
}
