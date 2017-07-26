using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miSerializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Class2 var = new Class2();
            var.Serializacion("Serializacion.xml");
            Console.ReadLine();
        }
    }
}
