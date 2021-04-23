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
    public partial class ThemeManager : UserControl
    {
        public ControlCollection AllControls = new ControlCollection();

        public enum Theme
        {
            Dark,
            Classic,
            Standard
        }

        public ThemeManager()
        {
            InitializeComponent();
            AllControls.AddRange(PageManager.ProductRegisterPage.Controls);
        }

        public void KeyboardHook(object sender, Keys e)
        {

        }
    }
}
