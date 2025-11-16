using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Interface.Modelos;

namespace Interface
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Txb1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Calcular(object sender, EventArgs e)
        {
            if (int.TryParse(Txb1.Text, out int Diag))
            {
                ClasseQuadrado meuObjeto = new ClasseQuadrado();

                meuObjeto.Diagonal = Diag;

                int resultado = meuObjeto.CalcularAreaPelaDiagonal();
                Lbl3.Text = "Valor é: " + resultado.ToString();
                Lbl3.Visible = true;
            }
            else
            {
                Lbl3.Text = "ERRO: Digite um número inteiro válido.";
                Lbl3.Visible = true;
            }
        }

    }
    
}
