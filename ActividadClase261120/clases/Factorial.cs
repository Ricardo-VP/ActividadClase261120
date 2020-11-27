using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActividadClase261120.clases
{
    class Factorial
    {
        public static int ejFact(int n)
        {
            int contador = 0;
            if (n > 1)
            {
                for (int i = 1; i <= n; i++)
                {
                    contador += (factorial(i) * -1);
                    if (i == n)
                    {
                        return contador;
                    }
                    i++;
                    contador += factorial(i);
                }
                return contador;
            }
            else
            {
                return n * -1;
            }
        }

        static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return n;
            }
        }
    }
}
