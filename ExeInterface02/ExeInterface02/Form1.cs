namespace ExeInterface02
{
    public partial class Aresta : Form
    {
        public Aresta()
        {
            InitializeComponent();
        }

        private void Aresta_Load(object sender, EventArgs e)
        {
            double arestaDigitada = Double.Parse(txtAresta.Text);

            Quadrado meuQuadrado = new Quadrado(arestaDigitada);

            double areaCalculada = meuQuadrado.CalcularAresta();

            lblResultado.Text = $"Área: {areaCalculada:F2}"; // Exibe com 2 casas decimais
        }
       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
