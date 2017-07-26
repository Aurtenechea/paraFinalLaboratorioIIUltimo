using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public static class ExtensorDeEventos // Debe ser estatica al igual que todos sus metodos.
    {
        // metodo de extension de string que por ej esta sellada.  
        public static void MiMetodo(this string dato)
        {
            //Console.WriteLine("MiMetodo se esta ejecutando.");
            Console.WriteLine(dato);

        }
        /*
         * No se pueden sobreescribir metodos que ya esten en la clase string.
         * El intelicense reconoce este metodo como parte de la clase string.
         * Ej si se necesita un metodo que cuente las letras "a" de un string. 
         * 
         * Desventaja
         * El metodo de extension tiene mas vida que la clase misma.
         * 
         */
    }
}
