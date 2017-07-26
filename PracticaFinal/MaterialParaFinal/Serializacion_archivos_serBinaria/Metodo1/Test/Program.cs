using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Metodo1;


namespace Test
{
    public class Program
    {
        static void Main(string[] args)
        {
            ClaseASerializar c = new ClaseASerializar(1,2);

            c.RutaArchivo = "../../../serializacion.xml";

            c.guardarSerializacion();

            /*  les pongo cualquier valor, deberian cambiarr despues de la lectura de archivo xml */
            ClaseASerializar c2 = new ClaseASerializar(55, 55);
            c2.RutaArchivo = "../../../serializacion.xml";
            c2.leerSerializacion();

            Console.ReadKey();


        }
    }
}
