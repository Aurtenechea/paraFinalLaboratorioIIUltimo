using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica16
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseParametrizada<string> c = new ClaseParametrizada<string>();
            c.describirme();
            ((IPrueba<string>)c).interfaceMethod("mensaje por parametro");
            c.interfaceMethod("mensaje por parametro");

            Hija h = new Hija();
            h.describirme();
            ((IPrueba<string>)h).interfaceMethod("mensaje por parametro desde hija");
            h.interfaceMethod("mensaje por parametro desde hija");

            Console.ReadKey();

        }
    }
}
