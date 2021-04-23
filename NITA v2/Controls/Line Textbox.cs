using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System;
using NITA_v2.Classes;

namespace NITA_v2.Controls
{
    public partial class Line_Textbox : UserControl
    {
        [Browsable(true)]
        public string Label { get; set; }
        public bool IsPassword { get; set; } = false;
        public Color Backcolor { get; set; } = Color.FromArgb(47, 49, 54);
        public string Texto { get { return TextBox.Text; } set { TextBox.Text = value; } }

        public Line_Textbox()
        {
            InitializeComponent();
            TextBox.GotFocus += GotFocus;
            TextBox.BackColor = Backcolor;
        }

        private new void GotFocus(object sender, EventArgs e)
        {
            if (Texto != Label) return;
            TextBox.ForeColor = Color.White;
            Texto = "";
        }

        private void Line_Textbox_Load(object sender, EventArgs e)
        {
            if (IsPassword) TextBox.PasswordChar = '•';
            Padding_PN2.BackColor = Config.DarkTone;
            Padding_PN.BackColor = Config.DarkTone;
            TextBox.BackColor = Config.DarkTone;
            TextBox.ForeColor = Config.FontTone;
            BackColor = Config.LightestTone;
        }

        private void Nita_TextBox_Load(object sender, EventArgs e)
        {
            if (Label == null) { TextBox.ForeColor = Color.White; return; }
            Texto = Label;
        }
    }
}
