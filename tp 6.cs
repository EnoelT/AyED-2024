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
            int nro1;
            Console.WriteLine("numero que quieres saber la tabla?");
            nro1 = int.Parse(Console.ReadLine());
            
            int resultado;
            Console.WriteLine(("suma de los lados ") + (nro1 * 1));
            Console.WriteLine(("suma de los lados ") + (nro1 * 2));
            Console.WriteLine(("suma de los lados ") + (nro1 * 3));
            Console.WriteLine(("suma de los lados ") + (nro1 * 4));
            Console.WriteLine(("suma de los lados ") + (nro1 * 5));
            Console.WriteLine(("suma de los lados ") + (nro1 * 6));
            Console.WriteLine(("suma de los lados ") + (nro1 * 7));
            Console.WriteLine(("suma de los lados ") + (nro1 * 8));
            Console.WriteLine(("suma de los lados ") + (nro1 * 9));
            Console.WriteLine(("suma de los lados ") + (nro1 * 10));


            Console.ReadKey();
        }
    }
}
