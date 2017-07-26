using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    class Program
    {
        static void Main(string[] args)
        {
            ImplementaInterface obj = new ImplementaInterface();
            Console.WriteLine(obj[0]);
            Console.WriteLine(obj[1]);
            obj.onImprimoXMetodEjecuted += miManejadorDeEvento;
            obj.imprimoX();
            IDos IDosVar = obj;
            IUno IUnoVar = obj;
            IDosVar.imprimoX();
            IUnoVar.imprimoX();
            obj.clave = "1234";
            Console.WriteLine(obj.clave);

            Console.ReadKey();
        }

        public static void miManejadorDeEvento(object sender, EventArgs e)
        {
            Console.WriteLine("miManejadorDeEvento");
        }
    }
}
