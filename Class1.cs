using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeInterface02
{
    public class Quadrado
    {
        public double Aresta { get; set; }
        public Quadrado(double aresta)
        {
            Aresta = aresta;
        }
        public double CalcularArea()
        {
            return Aresta * Aresta;
        }
    }
}



