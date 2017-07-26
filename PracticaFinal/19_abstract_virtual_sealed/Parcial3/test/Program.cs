using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial3;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Manzana m = new Manzana(10, ConsoleColor.Red, "pepito");
            Manzana m2 = new Manzana(20, ConsoleColor.Green, "pepito");
            Manzana m3 = new Manzana(9, ConsoleColor.Red, "jose");
            Cajon<Manzana> c = new Cajon<Manzana>(3,15);

            c = c + m;
            c = c + m2;
            c = c + m3;
            Console.WriteLine(c.ToString());
            c.RutaArchivo = "../../../cajon.xml";
            
            Console.WriteLine("guardo " + c.SerializarXML());
            
            Console.ReadKey();
        }
    }
}
