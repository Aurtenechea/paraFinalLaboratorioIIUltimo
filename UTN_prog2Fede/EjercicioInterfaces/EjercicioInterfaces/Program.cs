using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {

        /*
         * Creo que la clave para hacer este ejercicio es que al implementar las interfaces (las cuales tienen el mismo metodo)
         * hay que implementarlas de forma explicita para poder llamar a cada una segun sea IARBA, o IAFIP el objeto..
         */
        static void Main(string[] args)
        {
            Privado avionPrivado = new Privado(100, 100); // precio, velocidad
            Comercial avionComercial = new Comercial(200, 200); // precio, velocidad
            IAFIP interfaz = (IAFIP)avionPrivado;

            // avionPrivado.MostrarPrecio();    este es el unico metodo que se ve desde una instancia de avion privado.
            /*
             * no se ve nada de las interfaces ya que estas se implementan en Avion y no en Privado. Las interfaces no se heredan.
             * Esto hace que para acceder a la implementacion de los metodos de la interface usada en Avion haya que castearlo al tipo de la interface.
            */

            Deportivo dep = new Deportivo(1000, "abc", 10);
            Console.WriteLine(Gestion.MostrarImpuestoNacional(dep)); // da 33 que es el 0.33% de 100 que es el precio del avion
            



            Console.WriteLine(interfaz.CalcularImpuesto());
            Console.WriteLine(((IAFIP)avionComercial).CalcularImpuesto());
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionPrivado)); // da 33 que es el 0.33% de 100 que es el precio del avion
            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionComercial)); // da 33 que es el 0.33% de 200 que es el precio del avion


            Console.WriteLine(Gestion.MostrarImpuestoNacional(avionPrivado)); // da 33 que es el 0.33% de 100 que es el precio del avion



            // avionPrivado.CalcularImpuesto
            /*
             * Declarando la implementacion de la interface de forma implicita (porque se puede poner public) se puede acceder a dicho metodo 
             * desde un objeto de clase hija a la clase donde se encuentra la implementacion.
             */



            Console.ReadLine();

        }
    }
}

/*
 *                      Clase Estatica                          Clase No Estatica
 *          
 *  Similitudes       * Pueden contener const estatico
 *                    * Puede tener atrib estaticos
 *                    * Puede tener propiedades y metodos estaticos
 *                    *   
 *
 * 
 * Diferencias       * Tiene palabra static                      * No static  
 *                   * No se puede instanciar                    * Se puede isntanciar
 *                   * No puede tener const                      * Puede tener const de instancia
 *                   * No puede heredar                          * Puede heredar
 *                   * No puede implementar interfaces           * Puede implementar interfaces
 *                   * No tiene prop y metodos de instancia      * Tiene metodos y prop de isntancia
 * 
*/