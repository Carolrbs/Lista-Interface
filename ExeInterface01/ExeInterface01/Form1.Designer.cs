namespace ExeInterface01
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
            txtBase = new TextBox();
            txtAltura = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtBase
            // 
            txtBase.Location = new Point(74, 120);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 0;
            txtBase.Tag = "";
            txtBase.TextChanged += textBox1_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(74, 205);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(125, 27);
            txtAltura.TabIndex = 1;
            txtAltura.TextChanged += txtAltura_TextChanged;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(74, 267);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 29);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Resultado:";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(204, 271);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(73, 20);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "              0";
            lblResultado.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 81);
            label1.Name = "label1";
            label1.Size = new Size(241, 20);
            label1.TabIndex = 4;
            label1.Text = "Qual valor é a base do Retangulo? ";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 173);
            label2.Name = "label2";
            label2.Size = new Size(244, 20);
            label2.TabIndex = 5;
            label2.Text = "Qual valor é a altura do Retangulo?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Name = "Form1";
            Text = "App Calcular Area do Retangulo";
            Load += Form1_Load;
            ForeColorChanged += Form1_ForeColorChanged;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBase;
        private TextBox txtAltura;
        private Button btnCalcular;
        private Label lblResultado;
        private Label label1;
        private Label label2;
    }
}
