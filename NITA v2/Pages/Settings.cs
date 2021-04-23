using System.Collections.Generic;
using System.Windows.Forms;
using NITA_v2.Controls;
using NITA_v2.Classes;
using System;

namespace NITA_v2.Pages
{
    public partial class Settings : UserControl
    {
        private List<string> DatabaseTBs { get; set; } = new List<string>();

        public Settings()
        {
            InitializeComponent();
        }

        public void KeyboardHook(object sender, Keys e)
        {
            if (ActiveControl == null) return;

            if (e == Keys.F1) PageManager.ChangePage(Page.Login);
            else if (e == Keys.Enter)
                if (DatabaseTBs.Contains(ActiveControl.Name))
                {
                    DatabaseHook.DBUSER = Username_TB.Texto;
                    DatabaseHook.DBPASS = Password_TB.Texto;
                    DatabaseHook.DBHOST = Host_TB.Texto;
                    DatabaseHook.DBNAME = Name_TB.Texto;

                    Session.ExportJson();

                    Config.PromptNotification(Notification.NotificationType.Success, "As informações do banco de dados atualizadas.");
                }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            DatabaseTBs.AddRange(new string[] { "Host_TB", "Name_TB", "Username_TB", "Password_TB" });
            Username_TB.Texto = DatabaseHook.DBUSER;
            Password_TB.Texto = DatabaseHook.DBPASS;
            Host_TB.Texto = DatabaseHook.DBHOST;
            Name_TB.Texto = DatabaseHook.DBNAME;
        }
    }
}
