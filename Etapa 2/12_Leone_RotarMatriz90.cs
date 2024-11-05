using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserte valor n y m ");
            Random randonautica = new Random();
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] MiPrimerTabla = new int[n, m];
            for (int c = 0; c < m; c++)
            {
                for (int f = 0; f < n; f++)
                {

                    MiPrimerTabla[f, c] = randonautica.Next(0, 100); ;
                    Console.Write(MiPrimerTabla[f, c] + " \t");

                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int[,] miSegundaTabla = new int[n, m];
            for (int c = 0; c < n; c++)
            {
                for (int f = 0; f < m; f++)
                {

                    miSegundaTabla[c, f] = MiPrimerTabla[c, f];
                    Console.Write(miSegundaTabla[c, f] + "\t");

                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
