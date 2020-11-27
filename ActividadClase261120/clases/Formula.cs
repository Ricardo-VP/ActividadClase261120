using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadClase261120.clases
{
    class Formula
    {
        public static double ejFormula(int i, int n)
        {
            double resultado = 0;
            for (int x = i; x <= n; x++)
            {
                resultado += ((Math.Pow(2,x+1)) - (Math.Pow(2,x))) / (x + 1);
            }
            return resultado;
        }
    }
    
}
