using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica9
{
    class Program
    {
        public string id;

        public Program(string id) {
            this.id = id;
        }

        /*  esto es como crear una clase! */
        delegate void myDelegate(string nombre) ;
        delegate string myDelegate2();

        static void Main(string[] args)
        {
            /* Creo una variable de mi clase delegado. */
            myDelegate varDelegate;
            varDelegate = new myDelegate(metodoUno);


            /*  Ejecucion del metodo */
            varDelegate("mi nombre es nacho");
            varDelegate("mi apellido es aurtenechea");
            varDelegate("mi dni es 35208599");

            /*  ahora varDelegate tiene 2 funciones. */
            varDelegate += metodoDos;
            varDelegate("se ejecuta dos veces?");
            Console.WriteLine("LIST");
            Delegate[]  l = varDelegate.GetInvocationList();
            /* no se como invocar a sus metodos. */
            Console.WriteLine("");

            /*  para llamar a un metodo de instancia, necesito una instancia. */
            Program p = new Program("444");

            myDelegate2 varDelegate2;
            varDelegate2 = new myDelegate2(p.getId);

            /*  imprimo 4 veces lo que retorna la funcion almacenda en delegate2 */
            Console.WriteLine(varDelegate2());
            Console.WriteLine(varDelegate2());
            Console.WriteLine(varDelegate2());
            Console.WriteLine(varDelegate2());



            Console.ReadKey();
        }

        public static void metodoUno(string s){
            Console.WriteLine("Metodo uno escribe:-->> " + s);
        }
        public static void metodoDos(string s)
        {
            Console.WriteLine("Metodo dos escribe:-->> " + s);
        }

        public string getId() {
            return this.id;
        }
    }
}
