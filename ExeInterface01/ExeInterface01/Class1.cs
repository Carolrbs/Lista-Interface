using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeInterface01
{
    internal class Retangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        // Construtor
        public Retangulo(double @base, double altura)
        {
            this.Base = @base;
            this.Altura = altura;
        }

        // Método (Funcionalidade)
        public double CalcularArea()
        {
            return Base * Altura;
        }
    }
}
