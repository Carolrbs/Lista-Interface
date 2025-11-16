namespace Interface04
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
            this.lbl_1 = new System.Windows.Forms.Label();
            this.Lbl4 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Txb2 = new System.Windows.Forms.TextBox();
            this.Txb1 = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Location = new System.Drawing.Point(43, 84);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(218, 16);
            this.lbl_1.TabIndex = 0;
            this.lbl_1.Text = "Digite a base e a altura do triangulo";
            this.lbl_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl4
            // 
            this.Lbl4.AutoSize = true;
            this.Lbl4.Location = new System.Drawing.Point(146, 278);
            this.Lbl4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl4.Name = "Lbl4";
            this.Lbl4.Size = new System.Drawing.Size(14, 16);
            this.Lbl4.TabIndex = 13;
            this.Lbl4.Text = "0";
            this.Lbl4.Visible = false;
            this.Lbl4.TextChanged += new System.EventHandler(this.Lbl4_Click);
            this.Lbl4.Click += new System.EventHandler(this.Lbl4_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(48, 278);
            this.Lbl3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(90, 16);
            this.Lbl3.TabIndex = 12;
            this.Lbl3.Text = "O resultado é:";
            this.Lbl3.Click += new System.EventHandler(this.Lbl3_Click);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(48, 139);
            this.Lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(39, 16);
            this.Lbl2.TabIndex = 11;
            this.Lbl2.Text = "Base";
            // 
            // Txb2
            // 
            this.Txb2.Location = new System.Drawing.Point(223, 176);
            this.Txb2.Margin = new System.Windows.Forms.Padding(4);
            this.Txb2.Name = "Txb2";
            this.Txb2.Size = new System.Drawing.Size(132, 22);
            this.Txb2.TabIndex = 10;
            this.Txb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txb2.TextChanged += new System.EventHandler(this.Txb2_TextChanged);
            // 
            // Txb1
            // 
            this.Txb1.Location = new System.Drawing.Point(46, 176);
            this.Txb1.Margin = new System.Windows.Forms.Padding(4);
            this.Txb1.Name = "Txb1";
            this.Txb1.Size = new System.Drawing.Size(132, 22);
            this.Txb1.TabIndex = 9;
            this.Txb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txb1.TextChanged += new System.EventHandler(this.Txb1_TextChanged);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(220, 139);
            this.Lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(41, 16);
            this.Lbl1.TabIndex = 8;
            this.Lbl1.Text = "Altura";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(46, 230);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl4);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.Txb2);
            this.Controls.Add(this.Txb1);
            this.Controls.Add(this.Lbl1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lbl_1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label Lbl4;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.TextBox Txb2;
        private System.Windows.Forms.TextBox Txb1;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button btnCalcular;
    }
}

