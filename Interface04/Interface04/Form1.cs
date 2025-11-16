using System;
using System.Windows.Forms;


namespace Interface04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Txb2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl4_Click(object sender, EventArgs e)
        {

        }

        private void Lbl3_Click(object sender, EventArgs e)
        { 

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int Base;
            int Altura;

            // Tenta converter o texto da Base. Se falhar, exibe erro e para.
            if (!int.TryParse(Txb1.Text, out Base))
            {
                MessageBox.Show("Por favor, insira um número inteiro válido para a Base.", "Erro de Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lbl4.Text = "Aguardando entrada...";
                return;
            }

            // Tenta converter o texto da Altura. Se falhar, exibe erro e para.
            if (!int.TryParse(Txb2.Text, out Altura))
            {
                MessageBox.Show("Por favor, insira um número inteiro válido para a Altura.", "Erro de Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Lbl4.Text = "Aguardando entrada...";
                return;
            }

            // Garante que os valores não são negativos (opcional, mas recomendado para áreas)
            if (Base <= 0 || Altura <= 0)
            {
                MessageBox.Show("A Base e a Altura devem ser valores positivos.", "Erro de Valores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Lbl4.Text = "Valores inválidos";
                return;
            }

            // Instancia a classe e calcula a área
            Triangulo meuTriangulo = new Triangulo();
            int Resul = meuTriangulo.CalcularArea(Base, Altura);

            // Exibe o resultado na Label (Lbl4)
            Lbl4.Text = "O resultado é: " + Resul.ToString();
        }
        private void Txb1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
