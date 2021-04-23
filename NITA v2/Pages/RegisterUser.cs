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
using Newtonsoft.Json.Linq;

namespace NITA_v2.Pages
{
    public partial class RegisterUser : UserControl
    {
        public RegisterUser()
        {
            InitializeComponent();
        }

        public void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.F1) PageManager.ChangePage(Page.Login);
            else if (e == Keys.Enter) {
                var errors = new List<string>();
                if (Username_TB.Texto.Length < 5) errors.Add("O nome de usuário inserido é muito curto.");
                if (Password_TB.Texto.Length < 5) errors.Add("A senha inserida é muito curta.");
                if (Password_TB.Texto != Repeat_Password_TB.Texto) errors.Add("As senhas não combinam.");

                foreach (var error in errors)
                    Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Warning, error);

                if (errors.Count > 0) return;

                var json = DatabaseHook.RegisterUser(Username_TB.Texto, Password_TB.Texto);
                if (json.Contains("error")) Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Error, (string)JObject.Parse(json)["error"]);
                else { Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Success, "Conta cadastrada com sucesso, faça login para continuar!"); PageManager.ChangePage(Page.Login); }
            }
        }
    }
}
