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
            Console.WriteLine("Hola JuanPedro que edad tenes");
            int edad;
            edad = int.Parse(Console.ReadLine());

            int ingresos;
            ingresos = int.Parse(Console.ReadLine());

            if (edad >= 19 && ingresos >= 100000)
            {
                Console.WriteLine("cumples los requisitos para cobrar la beca");
            }
            else
            {
                Console.WriteLine("no cumples con los requisitos");
            }


            Console.ReadKey();
        }
    }
}
