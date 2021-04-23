namespace NITA_v2.Pages
{
    partial class Settings
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
            this.Header_PN = new System.Windows.Forms.Panel();
            this.Header_LB = new System.Windows.Forms.Label();
            this.Content_PN = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Username_TB = new NITA_v2.Controls.Line_Textbox();
            this.Username_LB = new System.Windows.Forms.Label();
            this.Password_TB = new NITA_v2.Controls.Line_Textbox();
            this.Password_LB = new System.Windows.Forms.Label();
            this.DB_PN = new System.Windows.Forms.Panel();
            this.DB_LB = new System.Windows.Forms.Label();
            this.Host_TB = new NITA_v2.Controls.Line_Textbox();
            this.Host_LB = new System.Windows.Forms.Label();
            this.Name_TB = new NITA_v2.Controls.Line_Textbox();
            this.Name_LB = new System.Windows.Forms.Label();
            this.Shortcuts_PN1 = new System.Windows.Forms.Panel();
            this.TAB_PN = new System.Windows.Forms.Panel();
            this.TAB_LB = new System.Windows.Forms.Label();
            this.F1_PN = new System.Windows.Forms.Panel();
            this.F1_LB = new System.Windows.Forms.Label();
            this.Enter_PN = new System.Windows.Forms.Panel();
            this.Enter_LB = new System.Windows.Forms.Label();
            this.Header_PN.SuspendLayout();
            this.Content_PN.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.DB_PN.SuspendLayout();
            this.Shortcuts_PN1.SuspendLayout();
            this.TAB_PN.SuspendLayout();
            this.F1_PN.SuspendLayout();
            this.Enter_PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_PN
            // 
            this.Header_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Header_PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Header_PN.Controls.Add(this.Header_LB);
            this.Header_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_PN.Location = new System.Drawing.Point(0, 0);
            this.Header_PN.Name = "Header_PN";
            this.Header_PN.Size = new System.Drawing.Size(1029, 33);
            this.Header_PN.TabIndex = 15;
            // 
            // Header_LB
            // 
            this.Header_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Header_LB.Location = new System.Drawing.Point(0, 0);
            this.Header_LB.Name = "Header_LB";
            this.Header_LB.Size = new System.Drawing.Size(1027, 31);
            this.Header_LB.TabIndex = 0;
            this.Header_LB.Text = "Configurações";
            this.Header_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Content_PN
            // 
            this.Content_PN.Controls.Add(this.panel2);
            this.Content_PN.Controls.Add(this.panel3);
            this.Content_PN.Controls.Add(this.panel1);
            this.Content_PN.Controls.Add(this.Shortcuts_PN1);
            this.Content_PN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_PN.Location = new System.Drawing.Point(0, 0);
            this.Content_PN.Name = "Content_PN";
            this.Content_PN.Size = new System.Drawing.Size(1029, 622);
            this.Content_PN.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1019, 33);
            this.panel2.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(83, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Detalhes";
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1019, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 622);
            this.panel3.TabIndex = 61;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Username_TB);
            this.panel1.Controls.Add(this.Username_LB);
            this.panel1.Controls.Add(this.Password_TB);
            this.panel1.Controls.Add(this.Password_LB);
            this.panel1.Controls.Add(this.DB_PN);
            this.panel1.Controls.Add(this.Host_TB);
            this.panel1.Controls.Add(this.Host_LB);
            this.panel1.Controls.Add(this.Name_TB);
            this.panel1.Controls.Add(this.Name_LB);
            this.panel1.Location = new System.Drawing.Point(261, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 387);
            this.panel1.TabIndex = 51;
            // 
            // Username_TB
            // 
            this.Username_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Username_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Username_TB.IsPassword = false;
            this.Username_TB.Label = null;
            this.Username_TB.Location = new System.Drawing.Point(14, 235);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(469, 45);
            this.Username_TB.TabIndex = 51;
            this.Username_TB.Texto = "";
            // 
            // Username_LB
            // 
            this.Username_LB.AutoSize = true;
            this.Username_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Username_LB.Location = new System.Drawing.Point(213, 214);
            this.Username_LB.Name = "Username_LB";
            this.Username_LB.Size = new System.Drawing.Size(73, 18);
            this.Username_LB.TabIndex = 54;
            this.Username_LB.Text = "Usuário:";
            // 
            // Password_TB
            // 
            this.Password_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Password_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Password_TB.IsPassword = true;
            this.Password_TB.Label = null;
            this.Password_TB.Location = new System.Drawing.Point(14, 316);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(469, 45);
            this.Password_TB.TabIndex = 52;
            this.Password_TB.Texto = "";
            // 
            // Password_LB
            // 
            this.Password_LB.AutoSize = true;
            this.Password_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Password_LB.Location = new System.Drawing.Point(213, 293);
            this.Password_LB.Name = "Password_LB";
            this.Password_LB.Size = new System.Drawing.Size(64, 18);
            this.Password_LB.TabIndex = 53;
            this.Password_LB.Text = "Senha:";
            // 
            // DB_PN
            // 
            this.DB_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.DB_PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DB_PN.Controls.Add(this.DB_LB);
            this.DB_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.DB_PN.Location = new System.Drawing.Point(0, 0);
            this.DB_PN.Name = "DB_PN";
            this.DB_PN.Size = new System.Drawing.Size(498, 33);
            this.DB_PN.TabIndex = 16;
            // 
            // DB_LB
            // 
            this.DB_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DB_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DB_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.DB_LB.Location = new System.Drawing.Point(0, 0);
            this.DB_LB.Name = "DB_LB";
            this.DB_LB.Size = new System.Drawing.Size(496, 31);
            this.DB_LB.TabIndex = 0;
            this.DB_LB.Text = "Banco de dados";
            this.DB_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Host_TB
            // 
            this.Host_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Host_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Host_TB.IsPassword = false;
            this.Host_TB.Label = null;
            this.Host_TB.Location = new System.Drawing.Point(14, 73);
            this.Host_TB.Name = "Host_TB";
            this.Host_TB.Size = new System.Drawing.Size(469, 45);
            this.Host_TB.TabIndex = 47;
            this.Host_TB.Texto = "";
            // 
            // Host_LB
            // 
            this.Host_LB.AutoSize = true;
            this.Host_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Host_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Host_LB.Location = new System.Drawing.Point(225, 52);
            this.Host_LB.Name = "Host_LB";
            this.Host_LB.Size = new System.Drawing.Size(48, 18);
            this.Host_LB.TabIndex = 50;
            this.Host_LB.Text = "Host:";
            // 
            // Name_TB
            // 
            this.Name_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Name_TB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Name_TB.IsPassword = false;
            this.Name_TB.Label = null;
            this.Name_TB.Location = new System.Drawing.Point(14, 154);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(469, 45);
            this.Name_TB.TabIndex = 48;
            this.Name_TB.Texto = "";
            // 
            // Name_LB
            // 
            this.Name_LB.AutoSize = true;
            this.Name_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Name_LB.Location = new System.Drawing.Point(135, 133);
            this.Name_LB.Name = "Name_LB";
            this.Name_LB.Size = new System.Drawing.Size(220, 18);
            this.Name_LB.TabIndex = 49;
            this.Name_LB.Text = "Nome do banco de dados:";
            // 
            // Shortcuts_PN1
            // 
            this.Shortcuts_PN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Shortcuts_PN1.Controls.Add(this.Enter_PN);
            this.Shortcuts_PN1.Controls.Add(this.TAB_PN);
            this.Shortcuts_PN1.Controls.Add(this.F1_PN);
            this.Shortcuts_PN1.Location = new System.Drawing.Point(13, 504);
            this.Shortcuts_PN1.Name = "Shortcuts_PN1";
            this.Shortcuts_PN1.Size = new System.Drawing.Size(251, 102);
            this.Shortcuts_PN1.TabIndex = 46;
            // 
            // TAB_PN
            // 
            this.TAB_PN.Controls.Add(this.TAB_LB);
            this.TAB_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TAB_PN.Location = new System.Drawing.Point(0, 34);
            this.TAB_PN.Name = "TAB_PN";
            this.TAB_PN.Size = new System.Drawing.Size(251, 34);
            this.TAB_PN.TabIndex = 1;
            // 
            // TAB_LB
            // 
            this.TAB_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TAB_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TAB_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TAB_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.TAB_LB.Location = new System.Drawing.Point(0, 0);
            this.TAB_LB.Name = "TAB_LB";
            this.TAB_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.TAB_LB.Size = new System.Drawing.Size(251, 34);
            this.TAB_LB.TabIndex = 1;
            this.TAB_LB.Text = "TAB - Próximo campo";
            this.TAB_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // F1_PN
            // 
            this.F1_PN.Controls.Add(this.F1_LB);
            this.F1_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F1_PN.Location = new System.Drawing.Point(0, 0);
            this.F1_PN.Name = "F1_PN";
            this.F1_PN.Size = new System.Drawing.Size(251, 34);
            this.F1_PN.TabIndex = 2;
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
            this.F1_LB.Size = new System.Drawing.Size(251, 34);
            this.F1_LB.TabIndex = 1;
            this.F1_LB.Text = "F1 - Tela inicial";
            this.F1_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Enter_PN
            // 
            this.Enter_PN.Controls.Add(this.Enter_LB);
            this.Enter_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Enter_PN.Location = new System.Drawing.Point(0, 68);
            this.Enter_PN.Name = "Enter_PN";
            this.Enter_PN.Size = new System.Drawing.Size(251, 34);
            this.Enter_PN.TabIndex = 3;
            // 
            // Enter_LB
            // 
            this.Enter_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Enter_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enter_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Enter_LB.Location = new System.Drawing.Point(0, 0);
            this.Enter_LB.Name = "Enter_LB";
            this.Enter_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.Enter_LB.Size = new System.Drawing.Size(251, 34);
            this.Enter_LB.TabIndex = 1;
            this.Enter_LB.Text = "Enter - Atualizar dados";
            this.Enter_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Header_PN);
            this.Controls.Add(this.Content_PN);
            this.Name = "Settings";
            this.Size = new System.Drawing.Size(1029, 622);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Header_PN.ResumeLayout(false);
            this.Content_PN.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.DB_PN.ResumeLayout(false);
            this.Shortcuts_PN1.ResumeLayout(false);
            this.TAB_PN.ResumeLayout(false);
            this.F1_PN.ResumeLayout(false);
            this.Enter_PN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Header_PN;
        private System.Windows.Forms.Label Header_LB;
        private System.Windows.Forms.Panel Content_PN;
        private System.Windows.Forms.Panel Shortcuts_PN1;
        private System.Windows.Forms.Panel TAB_PN;
        private System.Windows.Forms.Label TAB_LB;
        private System.Windows.Forms.Panel F1_PN;
        private System.Windows.Forms.Label F1_LB;
        private System.Windows.Forms.Panel panel1;
        private Controls.Line_Textbox Name_TB;
        public Controls.Line_Textbox Host_TB;
        private System.Windows.Forms.Label Name_LB;
        private System.Windows.Forms.Label Host_LB;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel DB_PN;
        private System.Windows.Forms.Label DB_LB;
        private System.Windows.Forms.Label Username_LB;
        private Controls.Line_Textbox Password_TB;
        private System.Windows.Forms.Label Password_LB;
        private Controls.Line_Textbox Username_TB;
        private System.Windows.Forms.Panel Enter_PN;
        private System.Windows.Forms.Label Enter_LB;
    }
}
