namespace NITA_v2.Controls
{
    partial class Notification
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
            this.Main_PN = new System.Windows.Forms.Panel();
            this.Message_LB = new System.Windows.Forms.Label();
            this.Title_LB = new System.Windows.Forms.Label();
            this.Main_PN.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main_PN
            // 
            this.Main_PN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Main_PN.Controls.Add(this.Message_LB);
            this.Main_PN.Controls.Add(this.Title_LB);
            this.Main_PN.Location = new System.Drawing.Point(12, 6);
            this.Main_PN.Name = "Main_PN";
            this.Main_PN.Size = new System.Drawing.Size(301, 104);
            this.Main_PN.TabIndex = 0;
            this.Main_PN.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_PN_Paint);
            // 
            // Message_LB
            // 
            this.Message_LB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Message_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Message_LB.Location = new System.Drawing.Point(0, 25);
            this.Message_LB.Name = "Message_LB";
            this.Message_LB.Size = new System.Drawing.Size(299, 77);
            this.Message_LB.TabIndex = 1;
            this.Message_LB.Text = "Mensagem";
            this.Message_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Title_LB
            // 
            this.Title_LB.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title_LB.Font = new System.Drawing.Font("Swis721 LtEx BT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title_LB.ForeColor = System.Drawing.SystemColors.Control;
            this.Title_LB.Location = new System.Drawing.Point(0, 0);
            this.Title_LB.Name = "Title_LB";
            this.Title_LB.Size = new System.Drawing.Size(299, 25);
            this.Title_LB.TabIndex = 0;
            this.Title_LB.Text = "Título";
            this.Title_LB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.Controls.Add(this.Main_PN);
            this.Name = "Notification";
            this.Size = new System.Drawing.Size(313, 126);
            this.Load += new System.EventHandler(this.Notification_Load);
            this.Main_PN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title_LB;
        private System.Windows.Forms.Label Message_LB;
        public System.Windows.Forms.Panel Main_PN;
    }
}
