using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("inserte valor n y m ");
            Random randonautica = new Random();
            int n = int.Parse(Console.ReadLine());

            int[] vector = new int[n];
            int[,] MiPrimerTabla = new int[n, n];
            for (int c = 0; c < n; c++)
            {
                for (int f = 0; f < n; f++)
                {

                    MiPrimerTabla[f, c] = randonautica.Next(0, 100); ;
                    Console.Write(MiPrimerTabla[f, c] + "\t");

                }
                Console.WriteLine();



            }
            for (int i = 0; i < n; i++)
            {
                vector[i] = MiPrimerTabla[i, i];
                Console.Write(vector[i] + "\t" + "\n");

            }
            Console.ReadKey();

        }
    }
}
