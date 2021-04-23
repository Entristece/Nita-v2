using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using NITA_v2.Classes;
using System.Drawing;
using System.IO;

namespace NITA_v2
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, System.EventArgs e)
        {
            PageManager.HookKeyboard();
            PageManager.MainForm = this;

            if (!File.Exists(Path.Combine(Path.GetTempPath(), "NITA_Settings.txt")))
                File.Create(Path.Combine(Path.GetTempPath(), "NITA_Settings.txt"));

            var json = File.ReadAllText(Path.Combine(Path.GetTempPath(), "NITA_Settings.txt"));
            if (json == "") return;
            var obj = JObject.Parse(json);

            DatabaseHook.DBUSER = (string)obj["username"];
            DatabaseHook.DBPASS = (string)obj["password"];
            DatabaseHook.DBHOST = (string)obj["host"];
            DatabaseHook.DBNAME = (string)obj["name"];

            Config.LightestTone = ((string)obj["lightesttone"]).Length == 0 ? Config.Classic_LightestTone : ColorTranslator.FromHtml((string)obj["lightesttone"]);
            Config.DarkestTone = ((string)obj["darkesttone"]).Length == 0 ? Config.Classic_DarkestTone : ColorTranslator.FromHtml((string)obj["darkesttone"]);
            Config.LightTone = ((string)obj["lighttone"]).Length == 0 ? Config.Classic_LightTone : ColorTranslator.FromHtml((string)obj["lighttone"]);
            Config.DarkTone = ((string)obj["darktone"]).Length == 0 ? Config.Classic_DarkTone : ColorTranslator.FromHtml((string)obj["darktone"]);
            Config.FontTone = ((string)obj["fonttone"]).Length == 0 ? Config.Classic_FontTone : ColorTranslator.FromHtml((string)obj["fonttone"]);
            /*
            Notification_PN.BackColor = Config.LightestTone;
            Header_PN.BackColor = Config.DarkTone;
            Logo_PB.BackColor = Config.DarkTone;
            BackColor = Config.LightTone;*/



            PageManager.ChangePage(Page.Login);
        }
    }
}
