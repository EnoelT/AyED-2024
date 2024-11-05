using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el radio ");
            circulo(int.Parse(Console.ReadLine()));

            Console.WriteLine("ingrese la altura y el radio del cilindro");
            cilindro(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));


            Console.ReadKey();
        }

        static double circulo(double radio)
        {
            double area = 0;
            area = 3.14 * (radio * radio);
            Console.WriteLine("esta es su area : " + area);
            return area;
        }
        static double cilindro(double altura, double area)
        {
            double volumen = circulo(area) * altura;

            Console.Clear();
            Console.Write(" este su volumen : " + volumen);
            return volumen;
        }
    }
}
