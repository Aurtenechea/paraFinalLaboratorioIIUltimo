using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Rueda
    {
        public string marca;
        public float tamaño;
        // lo que distinge a los constructores es el tipo de dato, la cantidad de parametros y su orden.


        /// <summary>
        /// este es el constructor por defecto. inicializa el parametro Marca en "sin marca".
        /// </summary>
        public Rueda() {
            this.marca = "sin marca";
        }

        /// <summary>
        /// este es un constructor de sobrecarga. inicializa el parametro Marca con lo que haya en param.
        /// </summary>
        /// <param name="param">marca de la rueda</param>
        public Rueda(string param) {
            this.marca = param;
        }

        /// <summary>
        /// este es un constructor de sobrecarga. inicializa el parametro tamaño con lo que haya en tamanio.
        /// </summary>
        /// <param name="tamanio">tamanio de la rueda</param>
       
        public Rueda( int tamanio ):this()  // asi se llama al constructor por defecto cada vez que se llame a este.
        {
            this.tamaño = tamanio;
        }

        public Rueda(string marca, int tamanio):this(tamanio)  
        {
            // llama al constructor con solo int, ese a su vez llamara al const por defecto
            // luego se va a ejecutar el contenido del constructor con solo int.
            // y luego lo que hay dentro este.
           
            this.marca = marca;  
        }


        // cambio de orden 
        public Rueda( int tamanio, string marca):this(marca, tamanio)
        {
            // este esta vacio ya que llama al constructor anterior con el orden de los parametros intercambiados.
        }




        public void mostrarTamanio()
        {
            Console.WriteLine("El tamaño es: {0}", this.tamaño);
        }

    }
}
