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
            string perso;
            Console.WriteLine("nombre");
            perso = Console.ReadLine();

            string ciudad;
            Console.WriteLine("ciudad");
            ciudad = Console.ReadLine();

            Console.WriteLine(("hola ") + (perso) + ("de ") + (ciudad));

            Console.ReadKey();

        }
    }
}
