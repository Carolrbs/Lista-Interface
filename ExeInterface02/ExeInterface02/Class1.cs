using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeInterface02
{
    internal class Quadrado
    {
        public double Aresta { get; set; }

        public Quadrado(double aresta)
        {
            this.Aresta = aresta;
        }

        public double CalcularAresta()
        {
            return Aresta * Aresta;
        }
    }
}


