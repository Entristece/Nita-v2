namespace NITA_v2
{
    partial class MainFrm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Container_PN = new System.Windows.Forms.Panel();
            this.Header_PN = new System.Windows.Forms.Panel();
            this.Logo_PB = new System.Windows.Forms.PictureBox();
            this.Notification_PN = new System.Windows.Forms.Panel();
            this.Header_PN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Container_PN
            // 
            this.Container_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Container_PN.Location = new System.Drawing.Point(10, 130);
            this.Container_PN.Name = "Container_PN";
            this.Container_PN.Size = new System.Drawing.Size(1031, 624);
            this.Container_PN.TabIndex = 13;
            // 
            // Header_PN
            // 
            this.Header_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.Header_PN.Controls.Add(this.Logo_PB);
            this.Header_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_PN.Location = new System.Drawing.Point(0, 0);
            this.Header_PN.Name = "Header_PN";
            this.Header_PN.Size = new System.Drawing.Size(1053, 122);
            this.Header_PN.TabIndex = 11;
            // 
            // Logo_PB
            // 
            this.Logo_PB.Image = global::NITA_v2.Properties.Resources.Nita_Logo_Top;
            this.Logo_PB.Location = new System.Drawing.Point(13, 6);
            this.Logo_PB.Name = "Logo_PB";
            this.Logo_PB.Size = new System.Drawing.Size(290, 110);
            this.Logo_PB.TabIndex = 0;
            this.Logo_PB.TabStop = false;
            // 
            // Notification_PN
            // 
            this.Notification_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Notification_PN.Dock = System.Windows.Forms.DockStyle.Right;
            this.Notification_PN.Location = new System.Drawing.Point(1053, 0);
            this.Notification_PN.Name = "Notification_PN";
            this.Notification_PN.Size = new System.Drawing.Size(313, 768);
            this.Notification_PN.TabIndex = 12;
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.Container_PN);
            this.Controls.Add(this.Header_PN);
            this.Controls.Add(this.Notification_PN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NITA";
            this.Load += new System.EventHandler(this.MainFrm_Load);
            this.Header_PN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo_PB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel Container_PN;
        private System.Windows.Forms.Panel Header_PN;
        private System.Windows.Forms.PictureBox Logo_PB;
        public System.Windows.Forms.Panel Notification_PN;
    }
}

