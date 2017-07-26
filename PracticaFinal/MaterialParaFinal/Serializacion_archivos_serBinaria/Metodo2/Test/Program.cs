using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodo2;

namespace Test
{
    class Program
    {
        /*  Metodo2 Consta de:
            1 -  una interface generica con los metodos guardar y leer.
                para cualquier objeto. 
            2 - una clase intermedia a la cual se le implementa esa 
                interface. Esta es la clase Xml.
            3 - Una clase a guardar. Esta clase puede tener un metodo 
                de instancia o estatico, el cual creara una instancia 
                del tipo xml y a travez de ella accedera al metodo 
                guardar/leer. */
        static void Main(string[] args)
        {
            ClaseASerializar c = new ClaseASerializar(1, 2);
            
            string rutaArchivo = "../../../serializacion.xml";

            bool result = ClaseASerializar.Guardar(rutaArchivo, c);


            ClaseASerializar leidoDeArchivo = null;

            ClaseASerializar.Leer(rutaArchivo, out leidoDeArchivo);


            Console.ReadKey();
        }
    }
}
