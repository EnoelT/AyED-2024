using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int clave1;
            Console.WriteLine("numero 1");
            clave1 = int.Parse(Console.ReadLine());

            int clave2;
            Console.WriteLine("numero2");
            clave2 = int.Parse(Console.ReadLine());

            if (clave2 / clave1 == 0)

            {
                Console.WriteLine("error");
            }
            else
            {
                Console.WriteLine((clave1 / clave2));
            }
            Console.ReadKey();
        }
    }
}
