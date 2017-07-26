using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
           // v1  y v2
            //Puerto p = new Puerto("CABA");
            //Importador1 i1 = new Importador1();

            //p.LLegoUnBarco += new Puerto.informarDelegate(i1.OnArribaUnBarco);
            //// Se registra el importador para que le avisen. No pasa nada mientras no llegue un barco.

            //p.OnArribaUnBarco("El barco contiente bicicletas.");

            //Console.ReadKey();

            /*
             * 1- crear el delegado. (es como definir un tipo, o una clase. Puede estar en cualquier lado.)
             * 2- crear el evento dentro de una clase. (quien va a ser disparado en cierta ocasion, es una variable).
             * 3- invocar (disparar el evento) en cierto caso. (desde la clase que contiene ese evento)
             * 4- crear un "manejador de eventos" es decir una funcion con la misma firma que el delegado. (generalmente en otra clase).
             * 5- registrar el evento (en el program por ej.) es decir a partir de una instancia (o no si es estatico) guardar en la 
             *    variable evento, la direccion del manejador del evento.
             */


            // uso de metodo de extension.
            string miNombre = "nacho";
            miNombre.MiMetodo();
            Console.ReadKey();

        }
    }
}
