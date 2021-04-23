using System.Collections.Generic;
using System.Windows.Forms;
using NITA_v2.Classes;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace NITA_v2.Controls
{
    public partial class Dark_List : UserControl
    {
        public ObservableCollection<Item> Items = new ObservableCollection<Item>();
        public List<PictureBox> SelectedArrows = new List<PictureBox>();
        public List<PictureBox> PictureBoxes = new List<PictureBox>();
        public List<Panel> IconContainers = new List<Panel>();
        public List<Label> SecondLabels = new List<Label>();
        public List<Panel> Panels = new List<Panel>();
        public List<Label> Labels = new List<Label>();

        public bool ShowIndicator { get; set; } = true;
        public bool DoubleColumn { get; set; } = false;
        public int CellHeight { get; set; } = 40;
        public string Title { get; set; }

        public int SelectedOption = 0;
        public int CellAmount = 0;
        public int Slot = 0;

        public Dark_List()
        {
            InitializeComponent();
        }

        public string SelectedItem()
        {
            return Labels[Slot].Text;
        }

        public string[] SelectedItems()
        {
            return new string[] { Labels[Slot].Text, SecondLabels[Slot].Text };
        }

        public void SelectSlot(int slot)
        {
            if (!ShowIndicator) return;

            foreach (var item in SelectedArrows)
                item.Image = null;

            SelectedArrows[slot].Image = Properties.Resources.Left_Arrow;
        }
        
        private void TB1_Enter(object sender, EventArgs e)
        {
            if (Items.Count > 0)
                SelectedArrows[Slot].Image = Properties.Resources.Left_Arrow;
        }

        private void TB1_Leave(object sender, EventArgs e)
        {
            SelectedArrows[Slot].Image = null;
        }

        private void Dark_List_Load(object sender, EventArgs e)
        {
            Items.CollectionChanged += ItemChanged;
            CellAmount = Height / CellHeight;

            for (var i = 0; i < CellAmount; i++)
            {
                var pictureBox = new PictureBox() { Location = new Point(CellHeight / 12, CellHeight / 12), Width = CellHeight - CellHeight / 6, Height = CellHeight - CellHeight / 6, SizeMode = PictureBoxSizeMode.Zoom };
                var label = new Label() { Font = new Font("Swis721 LtEx BT", CellHeight / 3), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter };
                var selectedArrow = new PictureBox() { Dock = DockStyle.Right, Width = CellHeight / 2, SizeMode = PictureBoxSizeMode.Zoom };
                var containerPanel = new Panel() { Width = CellHeight, Dock = DockStyle.Left };
                var panel = new Panel() { Dock = DockStyle.Top, Height = CellHeight };
                var secondLabel = new Label();

                if (DoubleColumn) {
                    label = new Label() { Font = new Font("Swis721 LtEx BT", CellHeight / 3), Dock = DockStyle.Left, TextAlign = ContentAlignment.MiddleLeft, ForeColor = Color.White };
                    secondLabel = new Label() { Font = new Font("Swis721 LtEx BT", CellHeight / 3), Dock = DockStyle.Right, TextAlign = ContentAlignment.MiddleLeft, ForeColor = Color.White };
                    label.Width = (int)(Width / 3 * 2.3f);
                }

                if (i == 0 && Items.Count > 0 && ShowIndicator) selectedArrow.Image = Properties.Resources.Left_Arrow;

                IconContainers.Add(containerPanel);
                SelectedArrows.Add(selectedArrow);
                SecondLabels.Add(secondLabel);
                PictureBoxes.Add(pictureBox);
                Panels.Add(panel);
                Labels.Add(label);

                IconContainers[i].Controls.Add(PictureBoxes[i]);
                if (DoubleColumn) Panels[i].Controls.Add(SecondLabels[i]);
                Panels[i].Controls.Add(SelectedArrows[i]);
                Panels[i].Controls.Add(IconContainers[i]);
                Panels[i].Controls.Add(Labels[i]);

            }
            
            for (var i = 0; i < CellAmount; i++)
            {
                if (i >= Items.Count()) continue;
                Labels[i].Text = Items[i].Text;
                PictureBoxes[i].Image = Items[i].Icon;
                IconContainers[i].BackColor = i % 2 == 0 ? Color.FromArgb(100, 100, 100) : Color.FromArgb(125, 125, 125);
                Panels[i].BackColor = i % 2 == 0 ? Color.FromArgb(50, 50, 50) : Color.FromArgb(75, 75, 75);
                if (Items[i].Icon == null) Panels[i].Controls.Remove(IconContainers[i]);
                if (Items[i].SecondText != null) SecondLabels[i].Text = Items[i].SecondText;
            }

            Panels.Reverse();

            for (var i = 0; i < CellAmount; i++)
                Controls.Add(Panels[i]);

            if (Title != null && Title != "") Controls.Add(new Label() { Height = (int)(CellHeight * 1.15f), BackColor = Color.FromArgb(32, 34, 37), Text = Title, TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.White, Font = new Font("Swis721 LtEx BT", CellHeight / 2.3f), Dock = DockStyle.Top });

            Panels.Reverse();//Procurar um jeito melhor de fazer isso
        }
        
        private void TB1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (SelectedOption == 0) return;
                SelectedOption--;

                if (Slot == 0)
                {
                    for (var i = 0; i < CellAmount; i++)
                    {
                        var index = SelectedOption + i;
                        Labels[i].Text = Items[index].Text;
                        PictureBoxes[i].Image = Items[index].Icon;
                        IconContainers[i].BackColor = i % 2 == 0 ? Color.FromArgb(100, 100, 100) : Color.FromArgb(125, 125, 125);
                        Panels[i].BackColor = i % 2 == 0 ? Color.FromArgb(50, 50, 50) : Color.FromArgb(75, 75, 75);
                    }
                }

                if (Slot <= 0) return;
                Slot--;
                SelectSlot(Slot);
            }

            else if (e.KeyCode == Keys.Down)
            {
                if (SelectedOption >= Items.Count - 1) return;
                SelectedOption++;

                if (Slot == CellAmount - 1)
                    for (var i = 0; i < CellAmount; i++)
                    {
                        var index = SelectedOption - CellAmount + i + 1;
                        Labels[i].Text = Items[index].Text;
                        PictureBoxes[i].Image = Items[index].Icon;
                        IconContainers[i].BackColor = i % 2 == 0 ? Color.FromArgb(100, 100, 100) : Color.FromArgb(125, 125, 125);
                        Panels[i].BackColor = i % 2 == 0 ? Color.FromArgb(50, 50, 50) : Color.FromArgb(75, 75, 75);
                    }

                if (Slot >= CellAmount - 1) return;
                Slot++;
                SelectSlot(Slot);
            }
        }

        private void Dark_List_Enter(object sender, EventArgs e)
        {
            TB1.Focus();
        }

        public void ItemChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            for (var i = 0; i < CellAmount; i++)
            {
                if (i >= Items.Count()) { Panels[i].BackColor = Color.FromArgb(47, 49, 54); Labels[i].Text = ""; PictureBoxes[i].Image = null; SecondLabels[i].Text = ""; continue; }
                Labels[i].Text = Items[i].Text;
                PictureBoxes[i].Image = Items[i].Icon;
                IconContainers[i].BackColor = i % 2 == 0 ? Color.FromArgb(100, 100, 100) : Color.FromArgb(125, 125, 125);
                Panels[i].BackColor = i % 2 == 0 ? Color.FromArgb(50, 50, 50) : Color.FromArgb(75, 75, 75);
                SecondLabels[i].Text = Items[i].SecondText == null ? "" : Items[i].SecondText;
                if (Items[i].Icon == null) Panels[i].Controls.Remove(IconContainers[i]);
            }
        }
    }

    [Serializable]
    public class Item
    {
        public string SecondText { get; set; }
        public Bitmap Icon { get; set; }
        public string Text { get; set; }

        private void Shuffle<T>(IList<T> ts)
        {
            var count = ts.Count;
            var last = count - 1;
            for (var i = 0; i < last; ++i)
            {
                var r = Config.GlobalRandom.Next(i, count);
                var tmp = ts[i];
                ts[i] = ts[r];
                ts[r] = tmp;
            }
        }

        public Item(string text)
        {
            Text = text;
        }

        public Item(Bitmap icon, string text)
        {
            Icon = icon;
            Text = text;
        }

        public Item(string text, string secondText)
        {
            Text = text;
            SecondText = secondText;
        }

        public Item(Bitmap icon, string text, string secondText)
        {
            Icon = icon;
            Text = text;
            SecondText = secondText;
        }
    }
}
