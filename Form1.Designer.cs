namespace ExeInterface02
{
    partial class Form1
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
            TextBox = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // TextBox
            // 
            TextBox.AccessibleName = "TextBox";
            TextBox.Location = new Point(41, 103);
            TextBox.Name = "TextBox";
            TextBox.Size = new Size(242, 27);
            TextBox.TabIndex = 0;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(48, 159);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(116, 30);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(193, 169);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(17, 20);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "0";
            lblResultado.Click += lblResultado_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(TextBox);
            Name = "Form1";
            Text = "Calculo da area do quadrado atravéz da aresta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBox;
        private Button btnCalcular;
        private Label lblResultado;
    }
}
