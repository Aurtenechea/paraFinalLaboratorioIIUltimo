using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegadoFuncionPrivada
{
    public delegate void miDelegado();

    class Program
    {
        static void Main(string[] args)
        {
            miDelegado d = null;
            d = Otra.almacenaFuncionPrivada(d);
            d();
            Console.ReadKey();
        }
    }

    class Otra 
    {
        public static miDelegado almacenaFuncionPrivada(miDelegado d)
        {
            d = new miDelegado(funcionPrivada);
            return d;
        }


        private static void funcionPrivada() {
            Console.WriteLine("ejecucion funcionPrivada");
        }
    }
}
