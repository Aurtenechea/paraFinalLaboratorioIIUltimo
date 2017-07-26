using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeracion
{
    class Program
    {
        static void Main(string[] args)
        {
               //recordar que esto es el main, no una clase.

            Guitarra miGuitarra;    // creo una variable.
            miGuitarra = new Guitarra();   //instancio un objeto del tipo Guitarra.
            Console.WriteLine(miGuitarra.tipo); // imprimo el contenido de un atributo del tipo eGuitarra de ese objeto Guitarra.
            //Console.ReadKey();

            Guitarra miGuitarra2;    // creo una variable.
            miGuitarra2 = new Guitarra();   //instancio un objeto del tipo Guitarra.

            miGuitarra2.setTipo(2);

            Console.WriteLine(miGuitarra2.tipo); // imprimo el contenido de un atributo del tipo eGuitarra de ese objeto Guitarra.
           
            Console.WriteLine((int)miGuitarra2.tipo);  // casteo el tipo eGuitarra al tipo int y devuelve el valor esperado.

            Console.ReadKey();



        }
    }
}
