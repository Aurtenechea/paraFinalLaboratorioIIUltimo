using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno c1 = new ClaseUno();
            
            /*  implicito */
            c1.miFuncion();

            /*  explicito */
            ((IUno)c1).miFuncion();


            /*  funciones, atributos y constructores estaticos no se heredan. */
            // ClaseDos.mEstatico();

            Console.ReadKey();
        }
    }
}
