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
            int valor;

            Console.WriteLine("Numero");
            valor = int.Parse(Console.ReadLine());

            int valor2;

            Console.WriteLine("Numero 2");
            valor2 = int.Parse(Console.ReadLine());


            Console.WriteLine(("suma ") + (valor + valor2));
            Console.WriteLine(("resta ") + (valor - valor2));
            Console.WriteLine(("multi ") + (valor * valor2));
            Console.WriteLine(("divis ") + (valor / valor2));
            Console.WriteLine(("resto ") + (valor % valor2));
            Console.ReadKey();
        }
    }
}
