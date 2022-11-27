using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma0Subconjunto2
{
    public class SumaConjuntos
    {

        public static void SumaSub(int[] subconjunto, int[,] matrizbinaria)
        {

            for (int i = 0; i < matrizbinaria.GetLength(0); i++)
            {
            int suma = 0;

                for (int j = 0; j < matrizbinaria.GetLength(1); j++)
                {

                    if (matrizbinaria[i, j] == 1)
                    {
                        suma = subconjunto[j] + suma;
                        Console.Write("[" + subconjunto[j] + "]");
                    }

                }

                if (i == 0)
                {

                }
                else
                {
                    Console.Write("\nsuma: " + suma);
                    Console.WriteLine("\n");
                }
                
            }
        }
    }
}