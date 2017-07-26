using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegados
{
    class Program
    {
            /*  creo delegados */
            delegate void myDelegate1();
            delegate void myDelegate2(string param1);
            delegate void myDelegate3(string param1, string param2);

            /*  para hacer uso de los delegados ya que estos son un tipo nada mas.
                hay que crear un evento o una variable. */

            /*  creo atributos estaticos de los eventos para poder usarlos
                sin instanciar la clase. */
            static event myDelegate1 eventoMyDelegate1;
            //event myDelegate2 eventoMyDelegate2;
            //event myDelegate3 eventoMyDelegate3;
        
        
        static void Main(string[] args)
        {

            //variables dentro de la funcion del tipo del evento.
            myDelegate1 miVariableDeMyDelegate1;
            myDelegate2 miVariableDeMyDelegate2;
            myDelegate3 miVariableDeMyDelegate3;
           
            /*  asigno un metodo a un evento. */
            eventoMyDelegate1 = metodoUnParametro;
            eventoMyDelegate1 += metodoUnParametro;
            eventoMyDelegate1();

            ///*  a la variable le asigno metodos. El primero debe instanciar el objeto
            //    del tipo del delegado con una funcion por parametro. */
            //miVariableDeMyDelegate1 = new myDelegate1(metodoSinParametros);
            //miVariableDeMyDelegate1 += metodoSinParametros;
            ///*  ejecuto la funcion. */
            //miVariableDeMyDelegate1();


            Console.ReadLine();
        }


        public static void metodoSinParametros()
        { Console.WriteLine("metodoSinParametros"); }
        public static void metodoUnParametro()
        { Console.WriteLine("metodoUnParametro"); }
        public static void metodoDosParametros()
        { Console.WriteLine("metodoDosParametros"); }
        
    }
}
