using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nro1;
            Console.WriteLine("ancho ?");
            nro1 = int.Parse(Console.ReadLine());

            int nro2;
            Console.WriteLine("largo ?");
            nro2 = int.Parse(Console.ReadLine());

            int resultado;
            Console.WriteLine(("suma de los lados ") + (nro1 + nro2 + nro1 + nro2));
            Console.WriteLine(("area ") + (nro1 * nro2));
            Console.WriteLine(("diagonal ") + Math.Sqrt(nro1 * nro1 + nro2 * nro2));


            Console.ReadKey();
        }
    }
}
