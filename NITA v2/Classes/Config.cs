using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using NITA_v2.Controls;
using System.Drawing;
using System;

namespace NITA_v2.Classes
{
    public static class Config
    {
        public static Random GlobalRandom = new Random();
        public static bool UseListIcons { get; set; }

        #region ThemeManager
        public static Color LightestTone { get; set; }
        public static Color DarkestTone { get; set; }
        public static Color LightTone { get; set; }
        public static Color DarkTone { get; set; }
        public static Color FontTone { get; set; }

        public static Color Dark_LightestTone { get; } = Color.FromArgb(62, 64, 69);
        public static Color Dark_LightTone { get; } = Color.FromArgb(62, 64, 69);
        public static Color Dark_DarkTone { get; } = Color.FromArgb(47, 49, 54);
        public static Color Dark_DarkestTone { get; } = Color.FromArgb(32, 34, 37);
        public static Color Dark_FontTone { get; } = Color.White;
        //Criar paleta de cores para Classic e Standard
        public static Color Classic_LightestTone { get; } = Color.FromArgb(247, 207, 126);
        public static Color Classic_DarkestTone { get; } = Color.FromArgb(223, 174, 102);
        public static Color Classic_LightTone { get; } = Color.FromArgb(242, 192, 113);
        public static Color Classic_DarkTone { get; } = Color.FromArgb(233, 192, 112);
        public static Color Classic_FontTone { get; } = Color.Blue;

        public static Color Standard_LightestTone { get; } = Color.FromArgb(32, 34, 37);
        public static Color Standard_DarkestTone { get; } = Color.FromArgb(32, 34, 37);
        public static Color Standard_LightTone { get; } = Color.FromArgb(62, 64, 69);
        public static Color Standard_DarkTone { get; } = Color.FromArgb(47, 49, 54);
        public static Color Standard_FontTone { get; } = Color.Black;
        #endregion

        [DllImport("user32.dll")]
        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        public enum Effect { Roll, Slide, Center, Blend }

        private static int[] effmap = { 0, 0x40000, 0x10, 0x80000 };
        private static int[] dirmap = { 1, 5, 4, 6, 2, 10, 8, 9 };

        public static Color Highlight(Color color)
        {
            var R = color.R + 40;
            var G = color.G + 40;
            var B = color.B + 40;

            if (R > 255) R = 255;
            if (G > 255) G = 255;
            if (B > 255) B = 255;

            return Color.FromArgb(R, G, B);
        }

        public static void AnimatePanel(Control ctl, Effect effect, int msec, int angle)
        {
            int flags = effmap[(int)effect];
            if (ctl.Visible) { flags |= 0x10000; angle += 180; }
            else if (ctl.TopLevelControl == ctl) flags |= 0x20000;
            flags |= dirmap[(angle % 360) / 45];
            bool ok = AnimateWindow(ctl.Handle, msec, flags);
            if (!ok) throw new Exception("Animation failed!");
            if (!ctl.Visible) ctl.Visible = true;
        }

        public async static Task PromptNotification (Notification.NotificationType type, string message)
        {
            var notification = new Notification(type, message);
            PageManager.MainForm.Notification_PN.Controls.Add(notification);
            notification.BringToFront();
            notification.Visible = false;
            await Task.Delay(500);
            AnimatePanel(notification, Effect.Slide, 200, 180);
            await Task.Delay(5000);
            AnimatePanel(notification, Effect.Slide, 200, 180);
            await Task.Delay(250);
            PageManager.MainForm.Notification_PN.Controls.Remove(notification);
        }
    }
}
