using System.Windows.Forms;
using System.Drawing;
using System;
using System.Threading.Tasks;
using NITA_v2.Classes;
using System.Runtime.InteropServices;

namespace NITA_v2.Controls
{
    public partial class Notification : UserControl
    {
        public enum NotificationType { Error, Warning, Success }
        public NotificationType Type { get; set; }
        public string Message { get; set; }

        private void Notification_Load(object sender, EventArgs e)
        {
            if (Type == NotificationType.Error) { Title_LB.Text = "Erro"; Title_LB.BackColor = Color.FromArgb(220, 110, 120); Main_PN.BackColor = Config.Highlight(Color.FromArgb(220, 110, 120)); }
            else if (Type == NotificationType.Warning) { Title_LB.Text = "Aviso"; Title_LB.BackColor = Color.FromArgb(240, 120, 20); Main_PN.BackColor = Config.Highlight(Color.FromArgb(240, 120, 20)); }
            else if (Type == NotificationType.Success) { Title_LB.Text = "Sucesso"; Title_LB.BackColor = Color.FromArgb(100, 160, 90); Main_PN.BackColor = Config.Highlight(Color.FromArgb(100, 160, 90)); }

            Message_LB.Text = Message;
            Dock = DockStyle.Bottom;
        }

        public Notification(NotificationType type, string message)
        {
            InitializeComponent();
            
            Message = message;
            Type = type;
        }

        private void Main_PN_Paint(object sender, PaintEventArgs e)
        {
            if (Type == NotificationType.Error) ControlPaint.DrawBorder(e.Graphics, Main_PN.ClientRectangle, Color.FromArgb(220, 110, 120), ButtonBorderStyle.Solid);
            else if (Type == NotificationType.Warning) ControlPaint.DrawBorder(e.Graphics, Main_PN.ClientRectangle, Color.FromArgb(240, 120, 20), ButtonBorderStyle.Solid);
            else if (Type == NotificationType.Success) ControlPaint.DrawBorder(e.Graphics, Main_PN.ClientRectangle, Color.FromArgb(100, 160, 90), ButtonBorderStyle.Solid);
        }
    }
}
