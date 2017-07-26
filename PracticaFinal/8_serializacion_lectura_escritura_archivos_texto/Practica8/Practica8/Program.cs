using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Por lo que entiendo, para serializar se necesita que las clases tengan 
                acceso a los miembros. si tienen miembros privados, que estos tengan sus 
                propiedades publicas correspondientes. Y tambien tienen que tener 
                un constructor por defecto. */

            Person p = new Person("nacho");
            Person p1 = new Person("eze");
            Person p2 = new Person("marta");

            Family f = new Family();
            f.lsPerson.Add(p);
            f.lsPerson.Add(p1);
            f.lsPerson.Add(p2);

            /*  serializacion xml */
            /*  guardar */
            bool b = false;
            try
            {
                Archivos.Xml<Family> objXml = new Archivos.Xml<Family>();
                b = objXml.guardar("family.xml", f);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }

            Console.WriteLine("b vale: " + b);

            /*  leer xml */
            Console.WriteLine("\n\n");
            Console.WriteLine("LEO EL ARCHIVO.");
            Family f2;
            try
            {
                Archivos.Xml<Family> auxLeer = new Archivos.Xml<Family>();
                auxLeer.leer("Family.xml", out f2);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }



             
            /*  ARCHIVOS txt */
            /*  guardar */
            //Family f = new Family();

            bool b2 = false;
            try
            {
                Archivos.Texto objTexto = new Archivos.Texto();
                b2 = objTexto.guardar("Family.txt", f.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }


            /*  lectura */
            string datos = "";
            try
            {
                Archivos.Texto objTexto = new Archivos.Texto();
                objTexto.leer("Family.txt", out datos);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROR: " + e.Message);
            }
            Console.WriteLine("Datos Leidos: " );
            Console.WriteLine(datos);
            
          
            Console.ReadKey();


        }
    }
}
