using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Modelos

{
    internal class ClasseQuadrado
    {
        public int Diagonal { get; set; }

        public int CalcularAreaPelaDiagonal()
        {
            int resultado = (Diagonal * Diagonal) / 2;
            return resultado;
        }
    }
}
