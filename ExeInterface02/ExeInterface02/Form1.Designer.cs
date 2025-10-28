namespace ExeInterface02
{
    partial class Aresta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAresta = new TextBox();
            btnCalcularQuadrado = new Button();
            lblResultado = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtAresta
            // 
            txtAresta.Location = new Point(56, 85);
            txtAresta.Name = "txtAresta";
            txtAresta.Size = new Size(125, 27);
            txtAresta.TabIndex = 0;
            // 
            // btnCalcularQuadrado
            // 
            btnCalcularQuadrado.Location = new Point(69, 134);
            btnCalcularQuadrado.Name = "btnCalcularQuadrado";
            btnCalcularQuadrado.Size = new Size(94, 29);
            btnCalcularQuadrado.TabIndex = 1;
            btnCalcularQuadrado.Text = "Calcular";
            btnCalcularQuadrado.UseVisualStyleBackColor = true;
            btnCalcularQuadrado.Click += button1_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(208, 137);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "0";
            lblResultado.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 36);
            label1.Name = "label1";
            label1.Size = new Size(259, 20);
            label1.TabIndex = 3;
            label1.Text = "Digite o valor da aresta do quadrado.";
            label1.Click += label1_Click_1;
            // 
            // Aresta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcularQuadrado);
            Controls.Add(txtAresta);
            Name = "Aresta";
            Text = "Calular Quadrado apartir de uma aresta";
            Load += Aresta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAresta;
        private Button btnCalcularQuadrado;
        private Label lblResultado;
        private Label label1;
    }
}
