namespace TratandoArquivoTexto
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnescolhaorigem = new System.Windows.Forms.Button();
            this.txtescolhearquivo = new System.Windows.Forms.TextBox();
            this.ofdescolhaarquivo = new System.Windows.Forms.OpenFileDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbExcluir = new System.Windows.Forms.RadioButton();
            this.rbCopiar = new System.Windows.Forms.RadioButton();
            this.rbLer = new System.Windows.Forms.RadioButton();
            this.gbDestino = new System.Windows.Forms.GroupBox();
            this.btnescolherdestino = new System.Windows.Forms.Button();
            this.txtdestino = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnescolhaorigem);
            this.groupBox1.Controls.Add(this.txtescolhearquivo);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(458, 52);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o arquivo:";
            // 
            // btnescolhaorigem
            // 
            this.btnescolhaorigem.Location = new System.Drawing.Point(401, 20);
            this.btnescolhaorigem.Name = "btnescolhaorigem";
            this.btnescolhaorigem.Size = new System.Drawing.Size(51, 23);
            this.btnescolhaorigem.TabIndex = 1;
            this.btnescolhaorigem.Text = "...";
            this.btnescolhaorigem.UseVisualStyleBackColor = true;
            this.btnescolhaorigem.Click += new System.EventHandler(this.btnescolhaarquivo_Click);
            // 
            // txtescolhearquivo
            // 
            this.txtescolhearquivo.Location = new System.Drawing.Point(6, 21);
            this.txtescolhearquivo.Name = "txtescolhearquivo";
            this.txtescolhearquivo.Size = new System.Drawing.Size(389, 22);
            this.txtescolhearquivo.TabIndex = 0;
            // 
            // ofdescolhaarquivo
            // 
            this.ofdescolhaarquivo.FileName = "openFileDialog1";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(395, 240);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 36);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnOK
            // 
            this.btnOK.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(304, 240);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 36);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbExcluir);
            this.groupBox2.Controls.Add(this.rbCopiar);
            this.groupBox2.Controls.Add(this.rbLer);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 81);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 65);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "O que pretende fazer com o arquivo ?";
            // 
            // rbExcluir
            // 
            this.rbExcluir.AutoSize = true;
            this.rbExcluir.Location = new System.Drawing.Point(383, 30);
            this.rbExcluir.Name = "rbExcluir";
            this.rbExcluir.Size = new System.Drawing.Size(66, 20);
            this.rbExcluir.TabIndex = 2;
            this.rbExcluir.TabStop = true;
            this.rbExcluir.Text = "Excluir";
            this.rbExcluir.UseVisualStyleBackColor = true;
            // 
            // rbCopiar
            // 
            this.rbCopiar.AutoSize = true;
            this.rbCopiar.Location = new System.Drawing.Point(173, 30);
            this.rbCopiar.Name = "rbCopiar";
            this.rbCopiar.Size = new System.Drawing.Size(63, 20);
            this.rbCopiar.TabIndex = 1;
            this.rbCopiar.TabStop = true;
            this.rbCopiar.Text = "Copiar";
            this.rbCopiar.UseVisualStyleBackColor = true;
            this.rbCopiar.CheckedChanged += new System.EventHandler(this.rbCopiar_CheckedChanged);
            // 
            // rbLer
            // 
            this.rbLer.AutoSize = true;
            this.rbLer.Location = new System.Drawing.Point(6, 30);
            this.rbLer.Name = "rbLer";
            this.rbLer.Size = new System.Drawing.Size(44, 20);
            this.rbLer.TabIndex = 0;
            this.rbLer.TabStop = true;
            this.rbLer.Text = "Ler";
            this.rbLer.UseVisualStyleBackColor = true;
            // 
            // gbDestino
            // 
            this.gbDestino.Controls.Add(this.btnescolherdestino);
            this.gbDestino.Controls.Add(this.txtdestino);
            this.gbDestino.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDestino.Location = new System.Drawing.Point(12, 166);
            this.gbDestino.Name = "gbDestino";
            this.gbDestino.Size = new System.Drawing.Size(458, 58);
            this.gbDestino.TabIndex = 4;
            this.gbDestino.TabStop = false;
            this.gbDestino.Text = "Escolha o destino para o arquivo:";
            // 
            // btnescolherdestino
            // 
            this.btnescolherdestino.Location = new System.Drawing.Point(401, 22);
            this.btnescolherdestino.Name = "btnescolherdestino";
            this.btnescolherdestino.Size = new System.Drawing.Size(51, 23);
            this.btnescolherdestino.TabIndex = 2;
            this.btnescolherdestino.Text = "...";
            this.btnescolherdestino.UseVisualStyleBackColor = true;
            this.btnescolherdestino.Click += new System.EventHandler(this.btnescolherdestino_Click);
            // 
            // txtdestino
            // 
            this.txtdestino.Location = new System.Drawing.Point(6, 22);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(389, 22);
            this.txtdestino.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ver.: 1.0.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 288);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbDestino);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratando com Arquivos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbDestino.ResumeLayout(false);
            this.gbDestino.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnescolhaorigem;
        private System.Windows.Forms.TextBox txtescolhearquivo;
        private System.Windows.Forms.OpenFileDialog ofdescolhaarquivo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbExcluir;
        private System.Windows.Forms.RadioButton rbCopiar;
        private System.Windows.Forms.RadioButton rbLer;
        private System.Windows.Forms.GroupBox gbDestino;
        private System.Windows.Forms.Button btnescolherdestino;
        private System.Windows.Forms.TextBox txtdestino;
        private System.Windows.Forms.Label label1;
    }
}

