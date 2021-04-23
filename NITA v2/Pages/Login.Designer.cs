namespace NITA_v2.Pages
{
    partial class Login
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
            this.Container_PN = new System.Windows.Forms.Panel();
            this.Password_TB = new NITA_v2.Controls.Line_Textbox();
            this.Logo_PB = new System.Windows.Forms.PictureBox();
            this.Username_TB = new NITA_v2.Controls.Line_Textbox();
            this.Password_LB = new System.Windows.Forms.Label();
            this.Username_LB = new System.Windows.Forms.Label();
            this.Shortcuts_PN1 = new System.Windows.Forms.Panel();
            this.Enter_PN = new System.Windows.Forms.Panel();
            this.Enter_LB = new System.Windows.Forms.Label();
            this.TAB_PN = new System.Windows.Forms.Panel();
            this.TAB_LB = new System.Windows.Forms.Label();
            this.F2_PN = new System.Windows.Forms.Panel();
            this.F2_LB = new System.Windows.Forms.Label();
            this.F1_PN = new System.Windows.Forms.Panel();
            this.F1_LB = new System.Windows.Forms.Label();
            this.Header_PN.SuspendLayout();
            this.Content_PN.SuspendLayout();
            this.Container_PN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).BeginInit();
            this.Shortcuts_PN1.SuspendLayout();
            this.Enter_PN.SuspendLayout();
            this.TAB_PN.SuspendLayout();
            this.F2_PN.SuspendLayout();
            this.F1_PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // Header_PN
            // 
            this.Header_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Header_PN.Controls.Add(this.Header_LB);
            this.Header_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_PN.Location = new System.Drawing.Point(0, 0);
            this.Header_PN.Name = "Header_PN";
            this.Header_PN.Size = new System.Drawing.Size(1029, 33);
            this.Header_PN.TabIndex = 11;
            // 
            // Header_LB
            // 
            this.Header_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Header_LB.Location = new System.Drawing.Point(0, 0);
            this.Header_LB.Name = "Header_LB";
            this.Header_LB.Size = new System.Drawing.Size(1029, 33);
            this.Header_LB.TabIndex = 0;
            this.Header_LB.Text = "Login";
            this.Header_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Content_PN
            // 
            this.Content_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Content_PN.Controls.Add(this.Container_PN);
            this.Content_PN.Controls.Add(this.Shortcuts_PN1);
            this.Content_PN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Content_PN.Location = new System.Drawing.Point(0, 0);
            this.Content_PN.Name = "Content_PN";
            this.Content_PN.Size = new System.Drawing.Size(1029, 622);
            this.Content_PN.TabIndex = 12;
            // 
            // Container_PN
            // 
            this.Container_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Container_PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Container_PN.Controls.Add(this.Password_TB);
            this.Container_PN.Controls.Add(this.Logo_PB);
            this.Container_PN.Controls.Add(this.Username_TB);
            this.Container_PN.Controls.Add(this.Password_LB);
            this.Container_PN.Controls.Add(this.Username_LB);
            this.Container_PN.Location = new System.Drawing.Point(368, 163);
            this.Container_PN.Name = "Container_PN";
            this.Container_PN.Size = new System.Drawing.Size(292, 286);
            this.Container_PN.TabIndex = 47;
            // 
            // Password_TB
            // 
            this.Password_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Password_TB.IsPassword = true;
            this.Password_TB.Label = null;
            this.Password_TB.Location = new System.Drawing.Point(20, 227);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(251, 45);
            this.Password_TB.TabIndex = 1;
            this.Password_TB.Texto = "";
            // 
            // Logo_PB
            // 
            this.Logo_PB.Image = global::NITA_v2.Properties.Resources.Nita_Logo_Light;
            this.Logo_PB.Location = new System.Drawing.Point(95, 6);
            this.Logo_PB.Name = "Logo_PB";
            this.Logo_PB.Size = new System.Drawing.Size(100, 100);
            this.Logo_PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo_PB.TabIndex = 0;
            this.Logo_PB.TabStop = false;
            // 
            // Username_TB
            // 
            this.Username_TB.Backcolor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Username_TB.IsPassword = false;
            this.Username_TB.Label = null;
            this.Username_TB.Location = new System.Drawing.Point(20, 146);
            this.Username_TB.Name = "Username_TB";
            this.Username_TB.Size = new System.Drawing.Size(251, 45);
            this.Username_TB.TabIndex = 0;
            this.Username_TB.Texto = "";
            // 
            // Password_LB
            // 
            this.Password_LB.AutoSize = true;
            this.Password_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Password_LB.Location = new System.Drawing.Point(113, 204);
            this.Password_LB.Name = "Password_LB";
            this.Password_LB.Size = new System.Drawing.Size(64, 18);
            this.Password_LB.TabIndex = 45;
            this.Password_LB.Text = "Senha:";
            // 
            // Username_LB
            // 
            this.Username_LB.AutoSize = true;
            this.Username_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Username_LB.Location = new System.Drawing.Point(109, 125);
            this.Username_LB.Name = "Username_LB";
            this.Username_LB.Size = new System.Drawing.Size(73, 18);
            this.Username_LB.TabIndex = 45;
            this.Username_LB.Text = "Usuário:";
            // 
            // Shortcuts_PN1
            // 
            this.Shortcuts_PN1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Shortcuts_PN1.Controls.Add(this.Enter_PN);
            this.Shortcuts_PN1.Controls.Add(this.TAB_PN);
            this.Shortcuts_PN1.Controls.Add(this.F2_PN);
            this.Shortcuts_PN1.Controls.Add(this.F1_PN);
            this.Shortcuts_PN1.Location = new System.Drawing.Point(13, 470);
            this.Shortcuts_PN1.Name = "Shortcuts_PN1";
            this.Shortcuts_PN1.Size = new System.Drawing.Size(251, 136);
            this.Shortcuts_PN1.TabIndex = 46;
            // 
            // Enter_PN
            // 
            this.Enter_PN.Controls.Add(this.Enter_LB);
            this.Enter_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Enter_PN.Location = new System.Drawing.Point(0, 102);
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
            this.Enter_LB.Text = "Enter - Fazer login";
            this.Enter_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TAB_PN
            // 
            this.TAB_PN.Controls.Add(this.TAB_LB);
            this.TAB_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TAB_PN.Location = new System.Drawing.Point(0, 68);
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
            // F2_PN
            // 
            this.F2_PN.Controls.Add(this.F2_LB);
            this.F2_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.F2_PN.Location = new System.Drawing.Point(0, 34);
            this.F2_PN.Name = "F2_PN";
            this.F2_PN.Size = new System.Drawing.Size(251, 34);
            this.F2_PN.TabIndex = 4;
            // 
            // F2_LB
            // 
            this.F2_LB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.F2_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.F2_LB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F2_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.F2_LB.Location = new System.Drawing.Point(0, 0);
            this.F2_LB.Name = "F2_LB";
            this.F2_LB.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.F2_LB.Size = new System.Drawing.Size(251, 34);
            this.F2_LB.TabIndex = 1;
            this.F2_LB.Text = "F2 - Configurações";
            this.F2_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.F1_LB.Text = "F1 - Criar nova conta";
            this.F1_LB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.Header_PN);
            this.Controls.Add(this.Content_PN);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(1029, 622);
            this.Load += new System.EventHandler(this.Login_Load);
            this.Header_PN.ResumeLayout(false);
            this.Content_PN.ResumeLayout(false);
            this.Container_PN.ResumeLayout(false);
            this.Container_PN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).EndInit();
            this.Shortcuts_PN1.ResumeLayout(false);
            this.Enter_PN.ResumeLayout(false);
            this.TAB_PN.ResumeLayout(false);
            this.F2_PN.ResumeLayout(false);
            this.F1_PN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header_PN;
        private System.Windows.Forms.Label Header_LB;
        private System.Windows.Forms.Panel Content_PN;
        private Controls.Line_Textbox Password_TB;
        private System.Windows.Forms.Panel Container_PN;
        private System.Windows.Forms.PictureBox Logo_PB;
        private System.Windows.Forms.Label Username_LB;
        private System.Windows.Forms.Label Password_LB;
        private System.Windows.Forms.Panel Shortcuts_PN1;
        private System.Windows.Forms.Panel Enter_PN;
        private System.Windows.Forms.Label Enter_LB;
        private System.Windows.Forms.Panel F1_PN;
        private System.Windows.Forms.Label F1_LB;
        private System.Windows.Forms.Panel TAB_PN;
        private System.Windows.Forms.Label TAB_LB;
        public Controls.Line_Textbox Username_TB;
        private System.Windows.Forms.Panel F2_PN;
        private System.Windows.Forms.Label F2_LB;
    }
}
