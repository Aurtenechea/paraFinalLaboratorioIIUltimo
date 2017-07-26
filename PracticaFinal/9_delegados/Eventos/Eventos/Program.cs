using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{

    class Program
    {

        static void Main(string[] args)
        {

            CualquierClase obj = new CualquierClase();

            obj.Evento += funcionUno;
            Program p = new Program();
            obj.Evento += p.funcionDos;

            obj.miEjecucionDisparaElEvento();

            Console.ReadKey();
        }

        public static void funcionUno()
        {
            Console.WriteLine("funcionUno");
        }
        
        public void funcionDos()
        {
            Console.WriteLine("funcionDos");
        }
    }
}
