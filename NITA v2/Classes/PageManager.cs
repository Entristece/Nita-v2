using System.Windows.Forms;
using NITA_v2.Pages;

namespace NITA_v2.Classes
{
    public static class PageManager
    {
        public static KeyboardHook LLHook { get; } = new KeyboardHook();
        public static Page CurrentPage { get; set; }
        public static MainFrm MainForm { get; set; }

        public static ProductRegister ProductRegisterPage { get; } = new ProductRegister();
        public static ProductUpdate ProductUpdatePage { get; } = new ProductUpdate();
        public static SelectProduct SelectProductPage { get; } = new SelectProduct();
        public static BatchManager BatchManagerPage { get; } = new BatchManager();
        public static RegisterUser RegisterUserPage { get; } = new RegisterUser();
        public static ThemeManager ThemeManagerPage { get; } = new ThemeManager();
        public static PointOfSale PointOfSalePage { get; } = new PointOfSale();
        public static OpenCashier OpenCashierPage { get; } = new OpenCashier();
        public static Checkout CheckoutPage { get; } = new Checkout();
        public static Settings SettingsPage { get; } = new Settings();
        public static Login LoginPage { get; } = new Login();
        public static Pages.Menu MenuPage { get; set; }

        public static void ChangePage(Page page)
        {
            MainForm.Container_PN.Controls.Clear();
            CurrentPage = page;

            if (page == Page.Menu) MainForm.Container_PN.Controls.Add(MenuPage);
            else if (page == Page.Checkout) { MainForm.Container_PN.Controls.Add(CheckoutPage); }
            else if (page == Page.BatchManager) { MainForm.Container_PN.Controls.Add(BatchManagerPage); }
            else if (page == Page.ThemeManager) { MainForm.Container_PN.Controls.Add(ThemeManagerPage); }
            else if (page == Page.Login) { MainForm.Container_PN.Controls.Add(LoginPage); LoginPage.Username_TB.Focus(); }
            else if (page == Page.Settings) { MainForm.Container_PN.Controls.Add(SettingsPage); SettingsPage.Host_TB.Focus(); }
            else if (page == Page.PointOfSale) { MainForm.Container_PN.Controls.Add(PointOfSalePage); PointOfSalePage.Search_TB.Focus(); }
            else if (page == Page.OpenCashier) { MainForm.Container_PN.Controls.Add(OpenCashierPage); OpenCashierPage.Password_TB.Focus(); }
            else if (page == Page.RegisterUser) { MainForm.Container_PN.Controls.Add(RegisterUserPage); RegisterUserPage.Username_TB.Focus(); }
            else if (page == Page.SelectProduct) { MainForm.Container_PN.Controls.Add(SelectProductPage); SelectProductPage.Select_LV.Focus(); }
            else if (page == Page.ProductUpdate) { MainForm.Container_PN.Controls.Add(ProductUpdatePage); ProductUpdatePage.Products_LV.Focus(); }
            else if (page == Page.ProductRegister) { MainForm.Container_PN.Controls.Add(ProductRegisterPage); ProductRegisterPage.Name_TB.Focus(); }
        }

        public static void HookKeyboard()
        {
            LLHook.OnKeyUnpressed += KeyboardHook_KeyUnpressed;
            LLHook.OnKeyPressed += KeyboardHook_KeyPressed;
            LLHook.HookKeyboard();
        }

        public static void UnhookKeyboard()
        {
            LLHook.UnHookKeyboard();
        }

        private static void KeyboardHook_KeyPressed(object sender, Keys e)
        {
            if (Form.ActiveForm != MainForm) return;

            if (CurrentPage == Page.Menu) MenuPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.Login) LoginPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.Checkout) CheckoutPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.Settings) SettingsPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.OpenCashier) OpenCashierPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.PointOfSale) PointOfSalePage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.BatchManager) BatchManagerPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.ThemeManager) ThemeManagerPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.RegisterUser) RegisterUserPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.SelectProduct) SelectProductPage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.ProductUpdate) ProductUpdatePage.KeyboardHook(sender, e);
            else if (CurrentPage == Page.ProductRegister) ProductRegisterPage.KeyboardHook(sender, e);
        }

        private static void KeyboardHook_KeyUnpressed(object sender, Keys e) { }
    }

    public enum Page
    {
        None,
        Menu,
        Login,
        Settings,
        Checkout,
        ManageUser,
        OpenCashier,
        PointOfSale,
        ThemeManager,
        BatchManager,
        RegisterUser,
        SelectProduct,
        ProductUpdate,
        ProductRegister
    }
}
