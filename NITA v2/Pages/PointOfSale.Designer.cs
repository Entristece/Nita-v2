namespace NITA_v2.Pages
{
    partial class PointOfSale
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.Price_Header_LB = new System.Windows.Forms.Label();
            this.Price_LB = new System.Windows.Forms.Label();
            this.Price_Header_PN = new System.Windows.Forms.Panel();
            this.Price_Parent_PN = new System.Windows.Forms.Panel();
            this.F4_LB = new System.Windows.Forms.Label();
            this.F6_PN = new System.Windows.Forms.Panel();
            this.F6_LB = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.F5_PN = new System.Windows.Forms.Panel();
            this.F5_LB = new System.Windows.Forms.Label();
            this.F4_PN = new System.Windows.Forms.Panel();
            this.Shortcuts_PN1 = new System.Windows.Forms.Panel();
            this.F3_PN = new System.Windows.Forms.Panel();
            this.F2_PN = new System.Windows.Forms.Panel();
            this.F1_PN = new System.Windows.Forms.Panel();
            this.F1_LB = new System.Windows.Forms.Label();
            this.Caixa_PN = new System.Windows.Forms.Panel();
            this.Caixa_LB = new System.Windows.Forms.Label();
            this.Header_LB = new System.Windows.Forms.Label();
            this.Logo_PN = new System.Windows.Forms.Panel();
            this.Logo_PB = new System.Windows.Forms.PictureBox();
            this.Header_PN = new System.Windows.Forms.Panel();
            this.Details_DB = new NITA_v2.Controls.Details_Box();
            this.QTD_TB = new NITA_v2.Controls.Line_Textbox();
            this.Search_TB = new NITA_v2.Controls.Line_Textbox();
            this.Sale_LV = new NITA_v2.Controls.Dark_List();
            this.Price_Header_PN.SuspendLayout();
            this.Price_Parent_PN.SuspendLayout();
            this.F6_PN.SuspendLayout();
            this.F5_PN.SuspendLayout();
            this.F4_PN.SuspendLayout();
            this.Shortcuts_PN1.SuspendLayout();
            this.F1_PN.SuspendLayout();
            this.Caixa_PN.SuspendLayout();
            this.Logo_PN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).BeginInit();
            this.Header_PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(204, 524);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Quantidade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price_Header_LB
            // 
            this.Price_Header_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price_Header_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_Header_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Price_Header_LB.Location = new System.Drawing.Point(0, 0);
            this.Price_Header_LB.Name = "Price_Header_LB";
            this.Price_Header_LB.Size = new System.Drawing.Size(488, 30);
            this.Price_Header_LB.TabIndex = 0;
            this.Price_Header_LB.Text = "Total a ser pago";
            this.Price_Header_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price_LB
            // 
            this.Price_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Price_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Price_LB.Location = new System.Drawing.Point(0, 30);
            this.Price_LB.Name = "Price_LB";
            this.Price_LB.Size = new System.Drawing.Size(488, 63);
            this.Price_LB.TabIndex = 1;
            this.Price_LB.Text = "R$ 0";
            this.Price_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Price_Header_PN
            // 
            this.Price_Header_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Price_Header_PN.Controls.Add(this.Price_Header_LB);
            this.Price_Header_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Price_Header_PN.Location = new System.Drawing.Point(0, 0);
            this.Price_Header_PN.Name = "Price_Header_PN";
            this.Price_Header_PN.Size = new System.Drawing.Size(488, 30);
            this.Price_Header_PN.TabIndex = 0;
            // 
            // Price_Parent_PN
            // 
            this.Price_Parent_PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Price_Parent_PN.Controls.Add(this.Price_LB);
            this.Price_Parent_PN.Controls.Add(this.Price_Header_PN);
            this.Price_Parent_PN.Location = new System.Drawing.Point(526, 515);
            this.Price_Parent_PN.Name = "Price_Parent_PN";
            this.Price_Parent_PN.Size = new System.Drawing.Size(490, 95);
            this.Price_Parent_PN.TabIndex = 49;
            // 
            // F4_LB
            // 
            this.F4_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F4_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F4_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F4_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.F4_LB.Location = new System.Drawing.Point(0, 0);
            this.F4_LB.Name = "F4_LB";
            this.F4_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.F4_LB.Size = new System.Drawing.Size(185, 33);
            this.F4_LB.TabIndex = 1;
            this.F4_LB.Text = "TAB - Próximo campo";
            this.F4_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F6_PN
            // 
            this.F6_PN.Controls.Add(this.F6_LB);
            this.F6_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F6_PN.Location = new System.Drawing.Point(0, 165);
            this.F6_PN.Name = "F6_PN";
            this.F6_PN.Size = new System.Drawing.Size(185, 33);
            this.F6_PN.TabIndex = 6;
            // 
            // F6_LB
            // 
            this.F6_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F6_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F6_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F6_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.F6_LB.Location = new System.Drawing.Point(0, 0);
            this.F6_LB.Name = "F6_LB";
            this.F6_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.F6_LB.Size = new System.Drawing.Size(185, 33);
            this.F6_LB.TabIndex = 1;
            this.F6_LB.Text = "F12 - Menu";
            this.F6_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(204, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 50;
            this.label1.Text = "Nome/EAN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // F5_PN
            // 
            this.F5_PN.Controls.Add(this.F5_LB);
            this.F5_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F5_PN.Location = new System.Drawing.Point(0, 132);
            this.F5_PN.Name = "F5_PN";
            this.F5_PN.Size = new System.Drawing.Size(185, 33);
            this.F5_PN.TabIndex = 5;
            // 
            // F5_LB
            // 
            this.F5_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F5_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F5_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F5_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.F5_LB.Location = new System.Drawing.Point(0, 0);
            this.F5_LB.Name = "F5_LB";
            this.F5_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.F5_LB.Size = new System.Drawing.Size(185, 33);
            this.F5_LB.TabIndex = 1;
            this.F5_LB.Text = "Enter - Confirma";
            this.F5_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F4_PN
            // 
            this.F4_PN.Controls.Add(this.F4_LB);
            this.F4_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F4_PN.Location = new System.Drawing.Point(0, 99);
            this.F4_PN.Name = "F4_PN";
            this.F4_PN.Size = new System.Drawing.Size(185, 33);
            this.F4_PN.TabIndex = 4;
            // 
            // Shortcuts_PN1
            // 
            this.Shortcuts_PN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Shortcuts_PN1.Controls.Add(this.F6_PN);
            this.Shortcuts_PN1.Controls.Add(this.F5_PN);
            this.Shortcuts_PN1.Controls.Add(this.F4_PN);
            this.Shortcuts_PN1.Controls.Add(this.F3_PN);
            this.Shortcuts_PN1.Controls.Add(this.F2_PN);
            this.Shortcuts_PN1.Controls.Add(this.F1_PN);
            this.Shortcuts_PN1.Location = new System.Drawing.Point(16, 412);
            this.Shortcuts_PN1.Name = "Shortcuts_PN1";
            this.Shortcuts_PN1.Size = new System.Drawing.Size(185, 198);
            this.Shortcuts_PN1.TabIndex = 48;
            // 
            // F3_PN
            // 
            this.F3_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F3_PN.Location = new System.Drawing.Point(0, 66);
            this.F3_PN.Name = "F3_PN";
            this.F3_PN.Size = new System.Drawing.Size(185, 33);
            this.F3_PN.TabIndex = 3;
            // 
            // F2_PN
            // 
            this.F2_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F2_PN.Location = new System.Drawing.Point(0, 33);
            this.F2_PN.Name = "F2_PN";
            this.F2_PN.Size = new System.Drawing.Size(185, 33);
            this.F2_PN.TabIndex = 2;
            // 
            // F1_PN
            // 
            this.F1_PN.Controls.Add(this.F1_LB);
            this.F1_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F1_PN.Location = new System.Drawing.Point(0, 0);
            this.F1_PN.Name = "F1_PN";
            this.F1_PN.Size = new System.Drawing.Size(185, 33);
            this.F1_PN.TabIndex = 1;
            // 
            // F1_LB
            // 
            this.F1_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F1_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F1_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F1_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.F1_LB.Location = new System.Drawing.Point(0, 0);
            this.F1_LB.Name = "F1_LB";
            this.F1_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.F1_LB.Size = new System.Drawing.Size(185, 33);
            this.F1_LB.TabIndex = 1;
            this.F1_LB.Text = "F1 - Excluir produto";
            this.F1_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Caixa_PN
            // 
            this.Caixa_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Caixa_PN.Controls.Add(this.Caixa_LB);
            this.Caixa_PN.Location = new System.Drawing.Point(16, 47);
            this.Caixa_PN.Name = "Caixa_PN";
            this.Caixa_PN.Size = new System.Drawing.Size(1000, 99);
            this.Caixa_PN.TabIndex = 46;
            // 
            // Caixa_LB
            // 
            this.Caixa_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Caixa_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Caixa_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Caixa_LB.Location = new System.Drawing.Point(0, 0);
            this.Caixa_LB.Name = "Caixa_LB";
            this.Caixa_LB.Size = new System.Drawing.Size(1000, 99);
            this.Caixa_LB.TabIndex = 1;
            this.Caixa_LB.Text = "CAIXA FECHADO";
            this.Caixa_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Header_LB
            // 
            this.Header_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Header_LB.Location = new System.Drawing.Point(0, 0);
            this.Header_LB.Name = "Header_LB";
            this.Header_LB.Size = new System.Drawing.Size(1031, 33);
            this.Header_LB.TabIndex = 1;
            this.Header_LB.Text = "Ponto de venda";
            this.Header_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Logo_PN
            // 
            this.Logo_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Logo_PN.Controls.Add(this.Logo_PB);
            this.Logo_PN.Location = new System.Drawing.Point(16, 152);
            this.Logo_PN.Name = "Logo_PN";
            this.Logo_PN.Size = new System.Drawing.Size(254, 254);
            this.Logo_PN.TabIndex = 47;
            // 
            // Logo_PB
            // 
            this.Logo_PB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Logo_PB.Image = global::NITA_v2.Properties.Resources.Nita_Logo_Light;
            this.Logo_PB.Location = new System.Drawing.Point(0, 0);
            this.Logo_PB.Name = "Logo_PB";
            this.Logo_PB.Size = new System.Drawing.Size(254, 254);
            this.Logo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PB.TabIndex = 0;
            this.Logo_PB.TabStop = false;
            // 
            // Header_PN
            // 
            this.Header_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Header_PN.Controls.Add(this.Header_LB);
            this.Header_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_PN.Location = new System.Drawing.Point(0, 0);
            this.Header_PN.Name = "Header_PN";
            this.Header_PN.Size = new System.Drawing.Size(1031, 33);
            this.Header_PN.TabIndex = 45;
            // 
            // Details_DB
            // 
            this.Details_DB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Details_DB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Details_DB.Location = new System.Drawing.Point(276, 152);
            this.Details_DB.Name = "Details_DB";
            this.Details_DB.Size = new System.Drawing.Size(242, 252);
            this.Details_DB.TabIndex = 54;
            // 
            // QTD_TB
            // 
            this.QTD_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.QTD_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.QTD_TB.IsPassword = false;
            this.QTD_TB.Label = null;
            this.QTD_TB.Location = new System.Drawing.Point(207, 565);
            this.QTD_TB.Name = "QTD_TB";
            this.QTD_TB.Size = new System.Drawing.Size(313, 45);
            this.QTD_TB.TabIndex = 53;
            this.QTD_TB.Texto = "";
            // 
            // Search_TB
            // 
            this.Search_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Search_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Search_TB.IsPassword = false;
            this.Search_TB.Label = null;
            this.Search_TB.Location = new System.Drawing.Point(207, 445);
            this.Search_TB.Name = "Search_TB";
            this.Search_TB.Size = new System.Drawing.Size(313, 45);
            this.Search_TB.TabIndex = 52;
            this.Search_TB.Texto = "";
            // 
            // Sale_LV
            // 
            this.Sale_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sale_LV.CellHeight = 30;
            this.Sale_LV.DoubleColumn = true;
            this.Sale_LV.Location = new System.Drawing.Point(526, 152);
            this.Sale_LV.Name = "Sale_LV";
            this.Sale_LV.ShowIndicator = true;
            this.Sale_LV.Size = new System.Drawing.Size(489, 357);
            this.Sale_LV.TabIndex = 55;
            this.Sale_LV.Title = "Produtos";
            // 
            // PointOfSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Sale_LV);
            this.Controls.Add(this.Details_DB);
            this.Controls.Add(this.QTD_TB);
            this.Controls.Add(this.Search_TB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Price_Parent_PN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shortcuts_PN1);
            this.Controls.Add(this.Caixa_PN);
            this.Controls.Add(this.Logo_PN);
            this.Controls.Add(this.Header_PN);
            this.Name = "PointOfSale";
            this.Size = new System.Drawing.Size(1031, 624);
            this.Load += new System.EventHandler(this.PointOfSale_Load);
            this.Price_Header_PN.ResumeLayout(false);
            this.Price_Parent_PN.ResumeLayout(false);
            this.F6_PN.ResumeLayout(false);
            this.F5_PN.ResumeLayout(false);
            this.F4_PN.ResumeLayout(false);
            this.Shortcuts_PN1.ResumeLayout(false);
            this.F1_PN.ResumeLayout(false);
            this.Caixa_PN.ResumeLayout(false);
            this.Logo_PN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).EndInit();
            this.Header_PN.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Price_Header_LB;
        public System.Windows.Forms.Label Price_LB;
        private System.Windows.Forms.Panel Price_Header_PN;
        private System.Windows.Forms.Panel Price_Parent_PN;
        private System.Windows.Forms.Label F4_LB;
        private System.Windows.Forms.Panel F6_PN;
        private System.Windows.Forms.Label F6_LB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel F5_PN;
        private System.Windows.Forms.Label F5_LB;
        private System.Windows.Forms.Panel F4_PN;
        private System.Windows.Forms.Panel Shortcuts_PN1;
        private System.Windows.Forms.Panel F3_PN;
        private System.Windows.Forms.Panel Caixa_PN;
        public System.Windows.Forms.Label Caixa_LB;
        private System.Windows.Forms.Label Header_LB;
        private System.Windows.Forms.Panel Logo_PN;
        private System.Windows.Forms.PictureBox Logo_PB;
        private System.Windows.Forms.Panel Header_PN;
        private Controls.Line_Textbox QTD_TB;
        private Controls.Details_Box Details_DB;
        public Controls.Line_Textbox Search_TB;
        public Controls.Dark_List Sale_LV;
        private System.Windows.Forms.Panel F2_PN;
        private System.Windows.Forms.Panel F1_PN;
        private System.Windows.Forms.Label F1_LB;
    }
}
