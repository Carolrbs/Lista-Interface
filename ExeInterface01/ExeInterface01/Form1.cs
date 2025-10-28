using System.Linq.Expressions;

namespace ExeInterface01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double baseDigitada = Double.Parse(txtBase.Text);
            double alturaDigitada = Double.Parse(txtAltura.Text);

            //Quem vai calcular a area
            Retangulo retangulo = new Retangulo(baseDigitada, alturaDigitada);


            double area = retangulo.CalcularArea();
            lblResultado.Text = $"Área: {area:F2}";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
