using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 c2 = new Class2();
            c2.inicializar();
            Class2.stM();
            Class2.b = 0;
            Console.WriteLine(c2.a);
            Console.ReadKey();
        }
    }
}
