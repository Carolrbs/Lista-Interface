namespace Interface
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
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Txb1 = new System.Windows.Forms.TextBox();
            this.BtnCalcular_Click = new System.Windows.Forms.Button();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Location = new System.Drawing.Point(12, 38);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(258, 16);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Digite a diagonal que você quer descobrir";
            this.Lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Txb1
            // 
            this.Txb1.Location = new System.Drawing.Point(13, 79);
            this.Txb1.Margin = new System.Windows.Forms.Padding(4);
            this.Txb1.Name = "Txb1";
            this.Txb1.Size = new System.Drawing.Size(132, 22);
            this.Txb1.TabIndex = 2;
            this.Txb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txb1.TextChanged += new System.EventHandler(this.Txb1_TextChanged);
            // 
            // BtnCalcular_Click
            // 
            this.BtnCalcular_Click.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BtnCalcular_Click.Location = new System.Drawing.Point(15, 128);
            this.BtnCalcular_Click.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCalcular_Click.Name = "BtnCalcular_Click";
            this.BtnCalcular_Click.Size = new System.Drawing.Size(100, 28);
            this.BtnCalcular_Click.TabIndex = 3;
            this.BtnCalcular_Click.Text = "Calcular";
            this.BtnCalcular_Click.UseVisualStyleBackColor = true;
            this.BtnCalcular_Click.Click += new System.EventHandler(this.btn_Calcular);
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Location = new System.Drawing.Point(12, 187);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(53, 16);
            this.Lbl2.TabIndex = 4;
            this.Lbl2.Text = "Valor é:";
            this.Lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Location = new System.Drawing.Point(92, 187);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(14, 16);
            this.Lbl3.TabIndex = 5;
            this.Lbl3.Text = "0";
            this.Lbl3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lbl3);
            this.Controls.Add(this.Lbl2);
            this.Controls.Add(this.BtnCalcular_Click);
            this.Controls.Add(this.Txb1);
            this.Controls.Add(this.Lbl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.TextBox Txb1;
        private System.Windows.Forms.Button BtnCalcular_Click;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl3;
    }
}

