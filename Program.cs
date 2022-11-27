using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma0Subconjunto2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Green;
            
            Stopwatch stopwatch = Stopwatch.StartNew();

            int[] subconjunto = { -7, -3, -2, 5, 8 };
            int[] subconjunto2 =  { -7, -3, -2, 5, 8};

            int[,] matrizCombinaciones = GenerarMatrizCombinaciones.GenerarMatrizBinaria(subconjunto);

            //Impresiones.ImprimirMatriz(matrizCombinaciones);
            //Console.WriteLine();

            SumaConjuntos.SumaSub(subconjunto2, matrizCombinaciones);

            TimeSpan ts = stopwatch.Elapsed;
            Console.WriteLine("Tiempo ejecución: "+ ts);

            Console.ReadLine();
        }
    }
}