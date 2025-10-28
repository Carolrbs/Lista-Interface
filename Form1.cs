namespace ExeInterface02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void lblResultado_Click(object sender, EventArgs e)
        {
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtLado.Text, out double aresta))
            {
                try
                {
                    Quadrado meuQuadrado = new Quadrado(aresta);
                    double area = meuQuadrado.CalcularArea();

                    lblResultado.Text = $"Área: {area:F2}";

                    MessageBox.Show($"O cálculo foi realizado pelo objeto Quadrado. Área = {area:F2}", "Sucesso (POOAleluia)", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    lblResultado.Text = "Área: Erro Interno!";
                    MessageBox.Show("Ocorreu um erro na lógica: " + ex.Message, "Erro POO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lblResultado.Text = "Área: Erro de Entrada!";
                MessageBox.Show("Por favor, insira um valor numérico válido para a aresta.", "Erro de Entrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}