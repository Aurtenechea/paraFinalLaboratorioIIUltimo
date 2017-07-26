using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indizador
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseConLista ccl = ClaseConLista.getInstance(10);
            ccl[0] = "nacho";
            ccl[1] = "mariana";
            ccl[2] = "sofia";

            Console.WriteLine(ccl[2]);

            Console.ReadKey();
        }
    }
}
