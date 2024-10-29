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
            int nro1;
            Console.WriteLine("numero ?");
            nro1 = int.Parse(Console.ReadLine());

            int nro2;
            Console.WriteLine("numero2 ?");
            nro2 = int.Parse(Console.ReadLine());

            int nro3;
            Console.WriteLine("numero3 ?");
            nro3 = int.Parse(Console.ReadLine());

            int resultado;
            resultado = (nro1 + nro2 + nro3);
            Console.WriteLine(resultado);

            Console.ReadKey();
        }
    }
}
