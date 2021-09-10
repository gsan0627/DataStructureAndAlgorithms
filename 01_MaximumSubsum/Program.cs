using System;
using System.Collections;
using System.Diagnostics;

namespace _01_MaximumSubsum
{
    /*
     Tenemos una serie de numeros y hay que encontrar el subconjunto de numeros
    contiguos que al sumarlos nos den el maximo valor posible
    4, -3, 5, -2, -1, 2, 6, -2
     */
    class Program
    {
        private static ArrayList a = new ArrayList();
        private static Random randon = new Random();

        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            CrearLista(100);

            //variables
            int sumaActual = 0;
            int maximaSuma = 0;
            int n = 0;
            int m = 0;
            int o = 0;

            int cantidad = a.Count;

            //algoritmo 1, 7 lineas
            sumaActual = 0;
            maximaSuma = 0;

            sw.Start();
            for (n = 0; n < cantidad; n++)
            {
                sumaActual = 0;
                for (m = 0; m < cantidad; m++)
                {
                    sumaActual += (int)a[m];
                    if (sumaActual > maximaSuma)
                        maximaSuma = sumaActual;
                }
            }
            sw.Stop();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("algoritmo un, la suma es {0}", maximaSuma);
            Console.WriteLine("Para {0} tomo {1:N0}", cantidad, sw.ElapsedTicks);
            Console.WriteLine("---");
            sw.Reset();

        }

        private static void CrearLista(int v)
        {
            throw new NotImplementedException();
        }
    }
}
