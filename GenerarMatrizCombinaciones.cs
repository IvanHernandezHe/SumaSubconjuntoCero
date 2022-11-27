using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma0Subconjunto2
{

    public class GenerarMatrizCombinaciones
    {
        public static int[] arregloCombinaciones = { };

        public static int ObtenerCant_Elementos(int[] array)
        {
            int cant_Elemetos = array.Length;

            return cant_Elemetos;
        }

        public static void GenerarCombinacionBinaria(int n, int[] array, int i)
        {

            if (i == n)
            {

                for (int j = 0; j < n; j++)
                {
                    arregloCombinaciones = arregloCombinaciones.Concat(new int[] { array[j] }).ToArray();
                }

                return;
            }

            array[i] = 0;
            GenerarCombinacionBinaria(n, array, i + 1);

            array[i] = 1;
            GenerarCombinacionBinaria(n, array, i + 1);

        }

        public static int[,] ConvertirArreglo_Matriz(int[] arr, int n)
        {
            int[,] Matriz = new int[Convert.ToInt32(Math.Pow(2, n)),n];
            int k = 0;

            for(int i = 0; i < (Convert.ToInt32(Math.Pow(2, n))); i++)
            {

                for (int j =0; j < n; j++)
                {
                    Matriz[i,j] = arr[k];
                    k++;
                }

            }

            return Matriz;
        }


        public static int[,] GenerarMatrizBinaria(int[] subconjunto)
        {
            int n = GenerarMatrizCombinaciones.ObtenerCant_Elementos(subconjunto);

            GenerarMatrizCombinaciones.GenerarCombinacionBinaria(n, subconjunto, 0);

            int[,] matriz = GenerarMatrizCombinaciones.ConvertirArreglo_Matriz(GenerarMatrizCombinaciones.arregloCombinaciones, n);

            return matriz;
        }

    }
}