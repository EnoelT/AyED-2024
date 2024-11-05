using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            string clave;
            clave = "clave1234";
            Console.WriteLine("contra?");


            string clave1;
            clave1 = Console.ReadLine();

            if (clave == clave1)
            {
                Console.WriteLine("es verdad");
            }
            else
            {
                Console.WriteLine("no");
            }
            Console.ReadKey();
        }
    }
}
