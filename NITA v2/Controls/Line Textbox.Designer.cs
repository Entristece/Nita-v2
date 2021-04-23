namespace NITA_v2.Controls
{
    partial class Line_Textbox
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
            this.Padding_PN2 = new System.Windows.Forms.Panel();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Padding_PN = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Padding_PN2
            // 
            this.Padding_PN2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Padding_PN2.Dock = System.Windows.Forms.DockStyle.Top;
            this.Padding_PN2.Location = new System.Drawing.Point(0, 41);
            this.Padding_PN2.Name = "Padding_PN2";
            this.Padding_PN2.Size = new System.Drawing.Size(359, 3);
            this.Padding_PN2.TabIndex = 6;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Font = new System.Drawing.Font("Swis721 LtEx BT", 24F);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.TextBox.Location = new System.Drawing.Point(0, 3);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(359, 38);
            this.TextBox.TabIndex = 5;
            this.TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Padding_PN
            // 
            this.Padding_PN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(49)))), ((int)(((byte)(54)))));
            this.Padding_PN.Dock = System.Windows.Forms.DockStyle.Top;
            this.Padding_PN.Location = new System.Drawing.Point(0, 0);
            this.Padding_PN.Name = "Padding_PN";
            this.Padding_PN.Size = new System.Drawing.Size(359, 3);
            this.Padding_PN.TabIndex = 4;
            // 
            // Line_Textbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.Controls.Add(this.Padding_PN2);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Padding_PN);
            this.Name = "Line_Textbox";
            this.Size = new System.Drawing.Size(359, 45);
            this.Load += new System.EventHandler(this.Line_Textbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Padding_PN2;
        public System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Panel Padding_PN;
    }
}
