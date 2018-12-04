namespace TratandoArquivoTexto
{
    partial class frmLeituraArquivo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLeituraArquivo));
            this.lbLeituraArquivo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbLeituraArquivo
            // 
            this.lbLeituraArquivo.FormattingEnabled = true;
            this.lbLeituraArquivo.ItemHeight = 16;
            this.lbLeituraArquivo.Location = new System.Drawing.Point(2, 2);
            this.lbLeituraArquivo.Name = "lbLeituraArquivo";
            this.lbLeituraArquivo.Size = new System.Drawing.Size(715, 404);
            this.lbLeituraArquivo.TabIndex = 0;
            // 
            // frmLeituraArquivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 409);
            this.Controls.Add(this.lbLeituraArquivo);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLeituraArquivo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conteúdo do Arquivo";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox lbLeituraArquivo;
    }
}