using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;

namespace delegadosLibro
{
    public delegate void miDelegado(int num);

    class Program
    {


        static void Main(string[] args)
        {
            miDelegado varDeleg;
            Type t = typeof(Program);
            MethodInfo m = t.GetMethod("uno");
            varDeleg = (miDelegado) Delegate.CreateDelegate(typeof(miDelegado), m);

            varDeleg(15);

            Console.ReadKey();
        }

        public static void uno(int n)
        {
            Console.WriteLine("metodo uno. numero: " + n);
        }

    }
}
