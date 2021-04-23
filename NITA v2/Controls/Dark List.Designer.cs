namespace NITA_v2.Controls
{
    partial class Dark_List
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
            this.TB1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(0, 0);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(0, 20);
            this.TB1.TabIndex = 0;
            this.TB1.Enter += new System.EventHandler(this.TB1_Enter);
            this.TB1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB1_KeyDown);
            this.TB1.Leave += new System.EventHandler(this.TB1_Leave);
            // 
            // Dark_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TB1);
            this.Name = "Dark_List";
            this.Size = new System.Drawing.Size(148, 148);
            this.Load += new System.EventHandler(this.Dark_List_Load);
            this.Enter += new System.EventHandler(this.Dark_List_Enter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TB1;
    }
}
