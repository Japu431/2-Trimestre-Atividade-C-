namespace jurosSimples
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
            this.var1 = new System.Windows.Forms.Label();
            this.valorParcela = new System.Windows.Forms.TextBox();
            this.diasDeAtraso = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.taxaDeJuros = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.montante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calcJuros = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // var1
            // 
            this.var1.AutoSize = true;
            this.var1.Location = new System.Drawing.Point(36, 59);
            this.var1.Name = "var1";
            this.var1.Size = new System.Drawing.Size(84, 13);
            this.var1.TabIndex = 0;
            this.var1.Text = "Valor de parcela";
            // 
            // valorParcela
            // 
            this.valorParcela.Location = new System.Drawing.Point(126, 56);
            this.valorParcela.Name = "valorParcela";
            this.valorParcela.Size = new System.Drawing.Size(100, 20);
            this.valorParcela.TabIndex = 1;
            this.valorParcela.TextChanged += new System.EventHandler(this.valorParcela_TextChanged);
            // 
            // diasDeAtraso
            // 
            this.diasDeAtraso.Location = new System.Drawing.Point(126, 108);
            this.diasDeAtraso.Name = "diasDeAtraso";
            this.diasDeAtraso.Size = new System.Drawing.Size(100, 20);
            this.diasDeAtraso.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tempo de atrasado";
            // 
            // taxaDeJuros
            // 
            this.taxaDeJuros.Location = new System.Drawing.Point(126, 82);
            this.taxaDeJuros.Name = "taxaDeJuros";
            this.taxaDeJuros.Size = new System.Drawing.Size(100, 20);
            this.taxaDeJuros.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Taxa de juros";
            // 
            // montante
            // 
            this.montante.Location = new System.Drawing.Point(126, 134);
            this.montante.Name = "montante";
            this.montante.Size = new System.Drawing.Size(100, 20);
            this.montante.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Montante";
            // 
            // calcJuros
            // 
            this.calcJuros.Location = new System.Drawing.Point(151, 169);
            this.calcJuros.Name = "calcJuros";
            this.calcJuros.Size = new System.Drawing.Size(75, 23);
            this.calcJuros.TabIndex = 8;
            this.calcJuros.Text = "Calcular";
            this.calcJuros.UseVisualStyleBackColor = true;
            this.calcJuros.Click += new System.EventHandler(this.calcJuros_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 260);
            this.Controls.Add(this.calcJuros);
            this.Controls.Add(this.montante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.taxaDeJuros);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.diasDeAtraso);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.valorParcela);
            this.Controls.Add(this.var1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label var1;
        private System.Windows.Forms.TextBox valorParcela;
        private System.Windows.Forms.TextBox diasDeAtraso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox taxaDeJuros;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox montante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button calcJuros;
    }
}

