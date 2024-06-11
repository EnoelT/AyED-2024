using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿cuantos tps tuvieron?");
            int tpsA = 0;
            int[] TPS = new int[int.Parse(Console.ReadLine())];
            for (int i = 0; i < TPS.Count(); i++)
            {
                Console.WriteLine("Tp " + (i + 1));
                Console.WriteLine("¿como les fue ?");

                int respuesta = int.Parse(Console.ReadLine());
                if (respuesta > 10)
                {
                    Console.WriteLine("se paso de la nota, ponga otro numero del 1 al 10 porfa");
                    i--;
                }
                else
                {
                    TPS[i] = respuesta;
                    if (TPS[i] >= 6)
                    {
                        tpsA = ++tpsA;
                    }
                }

            }


            Console.WriteLine("¿cuantos examenes tuvieron?");
            int[] EXAMEN = new int[int.Parse(Console.ReadLine())];
            for (int j = 0; j < EXAMEN.Count(); j++)
            {
                Console.WriteLine("examen " + (j + 1));
                Console.WriteLine("¿que nota se sacaron ?");
                int respuesta2 = int.Parse(Console.ReadLine());
                if (respuesta2 > 10)
                {
                    Console.WriteLine("se paso de la nota, ponga otro numero del 1 al 10 porfa");
                    j--;
                }
                else
                {
                    EXAMEN[j] = respuesta2;

                }
            }

            int acumulador = 0;
            for (int k = 0; k < EXAMEN.Count(); k++)
            {
                acumulador += EXAMEN[k];

            }
            int porcentaje = (tpsA * 100 / TPS.Count());
            Console.WriteLine("*el promedio de los examenes fue de " + (acumulador / EXAMEN.Count()));
            Console.WriteLine("*el porcentaje de los TPS aprobados fue de " + porcentaje);
            if (porcentaje >= 75 & acumulador >= 6)
            {
                Console.WriteLine("*bien ahi pana, aprobado*");
            }
            else
            {
                Console.WriteLine("*te van a dar chancla, baneado*");
            }


            Console.ReadKey();

        }
    }
}
