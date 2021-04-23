using System.Collections.Generic;
using System.Windows.Forms;
using NITA_v2.Classes;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace NITA_v2.Pages
{
    public partial class Menu : UserControl
    {
        public List<PictureBox> PictureBoxes = new List<PictureBox>();
        public List<Option> AllOptions = new List<Option>()
        {
            new Option("Ponto de venda", Color.FromArgb(51, 105, 30), Properties.Resources.PontoDeVenda_Icone, false, true),
            new Option("Abrir/fechar caixa", Color.FromArgb(130, 119, 23), Properties.Resources.Abrir_FecharCaixa_Icone, false, true),
            new Option("Cadastro de produtos", Color.FromArgb(74, 20, 140), Properties.Resources.CadastroProduto_Icone, true, false),
            new Option("Atualizar produtos", Color.FromArgb(0, 77, 64), Properties.Resources.AtualizarProduto_Icone, true, false),
            new Option("Lotes e validades", Color.FromArgb(136, 14, 79), Properties.Resources.LoteValidade_Icone, true, false),
            new Option("Gerenciar usuários", Color.FromArgb(230, 81, 0), Properties.Resources.GerenciarUsuarios_Icone, true, false),
            new Option("Fechar programa", Color.FromArgb(183, 28, 28), Properties.Resources.Fechar_Icone, false, false)
        };
        public List<Panel> Containers = new List<Panel>();
        public List<Option> Options = new List<Option>();
        public List<Label> Labels = new List<Label>();

        public int SelectedOption = 0;
        public int Slot = 0;

        public bool Closing = false;

        public Menu()
        {
            InitializeComponent();
            PictureBoxes.AddRange(new[] { OPT1_PB, OPT2_PB, OPT3_PB, OPT4_PB, OPT5_PB, OPT6_PB });
            Containers.AddRange(new[] { OPT1_PN, OPT2_PN, OPT3_PN, OPT4_PN, OPT5_PN, OPT6_PN });
            Labels.AddRange(new[] { OPT1_LB, OPT2_LB, OPT3_LB, OPT4_LB, OPT5_LB, OPT6_LB });

            foreach (var option in AllOptions)
            {
                if (option.Text == "Lotes e validades" || (option.AdminRequired && !Session.CurrentUser.IsAdmin) || (option.SellerRequired && !Session.CurrentUser.IsSeller)) continue;
                else Options.Add(option);
            }

            for (var i = 0; i < 6; i++)
            {
                if (i >= Options.Count()) continue;
                Labels[i].Text = Options[i].Text;
                PictureBoxes[i].Image = Options[i].Image;
                PictureBoxes[i].BackColor = Options[i].Color;
            }
        }

        public async void KeyboardHook(object sender, Keys e)
        {
            if (e == Keys.Up)
            {
                if (SelectedOption == 0) return;
                SelectedOption--;

                if (Slot == 0)
                {
                    for (var i = 0; i < 6; i++)
                    {
                        var index = SelectedOption + i;
                        Labels[i].Text = Options[index].Text;
                        PictureBoxes[i].Image = Options[index].Image;
                        PictureBoxes[i].BackColor = Options[index].Color;
                    }
                }

                if (Slot <= 0) return;
                Containers[Slot].BackColor = Color.FromArgb(47, 49, 54);
                Slot--;
                Containers[Slot].BackColor = Color.FromArgb(100, 100, 100);
            }
            if (e == Keys.Down)
            {
                if (SelectedOption >= Options.Count - 1) return;
                SelectedOption++;

                if (Slot == 5)
                    for (var i = 0; i < 6; i++)
                    {
                        var index = SelectedOption - 5 + i;
                        Labels[i].Text = Options[index].Text;
                        PictureBoxes[i].Image = Options[index].Image;
                        PictureBoxes[i].BackColor = Options[index].Color;
                    }

                if (Slot >= 5) return;
                Containers[Slot].BackColor = Color.FromArgb(47, 49, 54);
                Slot++;
                Containers[Slot].BackColor = Color.FromArgb(100, 100, 100);
            }
            if (e == Keys.Enter)
            {
                if (Options[SelectedOption].Text.Equals("Ponto de venda")) PageManager.ChangePage(Page.PointOfSale);//Exibe a página Ponto de venda
                else if (Options[SelectedOption].Text.Equals("Cadastro de produtos")) PageManager.ChangePage(Page.ProductRegister);
                else if (Options[SelectedOption].Text.Equals("Atualizar produtos")) PageManager.ChangePage(Page.ProductUpdate);//Exibe a página Atualizar produto
                else if (Options[SelectedOption].Text.Equals("Lotes e validades")) PageManager.ChangePage(Page.BatchManager);
                else if (Options[SelectedOption].Text.Equals("Gerenciar usuários")) PageManager.ChangePage(Page.ManageUser);
                else if (Options[SelectedOption].Text.Equals("Abrir/fechar caixa"))
                {
                    if (Session.IsCashierOpen) Session.IsCashierOpen = false;
                    else PageManager.ChangePage(Page.OpenCashier);//Se o caixa estiver fechado, exibe campo para inserção do valor contido em caixa
                }
                else if (Options[SelectedOption].Text.Equals("Fechar programa"))
                {
                    if (!Closing)
                    {
                        Config.PromptNotification(NITA_v2.Controls.Notification.NotificationType.Warning, "Para fechar o programa, pressione Enter novamente.");
                        Closing = true;
                        await Task.Delay(5000);
                        Closing = false;
                    }
                    else PageManager.MainForm.Close();
                }
            }
        }
    }

    public class Option
    {
        public string Text { get; set; }
        public Color Color { get; set; }
        public Bitmap Image { get; set; }
        public bool AdminRequired { get; set; }
        public bool SellerRequired { get; set; }

        public Option(string text, Color color, Bitmap image, bool adminRequired, bool sellerRequired)
        {
            Text = text;
            Color = color;
            Image = image;
            AdminRequired = adminRequired;
            SellerRequired = sellerRequired;
        }
    }
}
