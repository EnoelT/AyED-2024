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
            int edad;
            Console.WriteLine("edad?");
            edad = int.Parse(Console.ReadLine());

            int resultado;
            if (edad < 18)
            {
                Console.WriteLine("sos menor");
            }
            else if (edad >= 18)
                Console.WriteLine("sos mayor");

                Console.ReadKey();
        }
    }
}
