using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    class Program
    {
        // funcion generica.
        public static void PrintGenericFunction<T>(T param)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine("========="+param.ToString()+"==========");
            Console.WriteLine("=======================================");
        }
    
        static void Main(string[] args)
        {
            // Los metodos son cualquier cosa porque son de instancia y usan como parametro esa misma instancia.
            // Pero la idea era probar definir metodos que su parametro sea generico.


            Oso o = new Oso("Totoro", 250, 2.2f);
            Persona p = new Persona("Nacho", "Arabe", 80, 1.87f);
            /*
             * Para hacer uso de las funciones explicitas de la Interface el objeto tiene que 
             * estar casteado a al tipo de la interfaz IPesoAltura<Oso>
             */
            IPesoAltura<Oso> i = new Oso("Totoro", 250, 2.2f);
            
            /*
             * Para hacer uso de una funcion generica explicita hay que definir su tipo en la llamada...
             */
            PrintGenericFunction<float>(i.GetPeso((Oso)i));

            /*
             * Asi vuelvo a tener acceso a los miembros de un objeto oso...
             */
            ((Oso)i).Altura = 2.34f;

            /*
             * Para hacer uso de las funciones explicitas de la Interface el objeto tiene que 
             * estar casteado a al tipo de la interfaz IPesoAltura<Oso>
             */
            Console.WriteLine( ((IPesoAltura<Oso>)o).GetPeso(o).ToString() );

         
            Console.WriteLine(o.GetPeso(o).ToString());

            Console.ReadLine();
        }
    }
}
