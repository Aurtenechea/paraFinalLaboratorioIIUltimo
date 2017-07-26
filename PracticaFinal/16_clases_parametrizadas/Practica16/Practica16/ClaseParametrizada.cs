using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica16
{
    class ClaseParametrizada <T> :IPrueba<T> 
         where T : class
    {
        public void describirme() {
            Console.WriteLine("Soy del tipo" + this.GetType());
            Console.WriteLine("El parametro de mi clase es " + typeof(T));
        }

        /*  Los metodos explicitos se deben llamar de manera explicita. 
            Solo funcionan de esa forma*/
        /*  Implementacion explicita. */
        void IPrueba<T>.interfaceMethod(T param)
        {
            Console.WriteLine("Metodo de interface (explicit)" + typeof(T));
            Console.WriteLine("     Parametro: " + param);
        }

        /*  Los metodos implicitos funcionan cuando se lo llaman de forma 
            implicita o explicita, en el caso de que se llame de manera explicita 
            y exista un metodo explicito se ejecuta ese. */
        /*  implementacion implicita */
        public void interfaceMethod(T param)
        {
            Console.WriteLine("Metodo de interface (implicit)" + typeof(T));
            Console.WriteLine("     Parametro: " + param);
        }
    }
}
