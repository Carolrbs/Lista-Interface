using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface04
{
    internal class Triangulo
    {
        public int CalcularArea(int Base, int Altura)
        {
            int area = (Base * Altura) / 2;
            return area;
        }
    }
}
