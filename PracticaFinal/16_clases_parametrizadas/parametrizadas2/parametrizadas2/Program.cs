using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.Xml;

using System.IO;

namespace parametrizadas2
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseParametrizada<string> p = new ClaseParametrizada<string>("nacho");

            Console.WriteLine(p.GetType() == typeof(ClaseParametrizada<string>));
            Console.WriteLine(typeof(ClaseParametrizada<string>) == typeof(ClaseParametrizada<string>));
            Console.WriteLine( p is ClaseParametrizada<string> );

            Console.WriteLine(p is ClasePadre);
            Console.WriteLine(typeof(ClaseParametrizada<string>) == typeof(ClasePadre));
            Console.WriteLine( p.GetType() == typeof(ClasePadre) );

            ClaseConLista c = new ClaseConLista(2);
            Persona p1 = new Persona("nacho1");
            Persona p2 = new Persona("nacho2");
            Persona p3 = new Persona("nacho3");
            try
            {
                c = c + p1;
                c = c + p2;
                c = c + p3;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            c = c - p1 ;
            c.value2 = 555;

            using (XmlTextWriter escritor = new XmlTextWriter("../../../file.xml", Encoding.UTF8))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(ClaseConLista));
                    serializador.Serialize(escritor, c);
                }
                catch (Exception e)
                { 
                }
            }

            ClaseConLista c2;
            ClaseConLista.deserializar("../../../file.xml", out c2);


            using (StreamWriter escritor = new StreamWriter("../../../text.txt", false))
            {
                escritor.WriteLine("jajajajdjfasjdfjasdjfasw");
            }

            using (StreamReader lector = new StreamReader("../../../text.txt"))
            {
                Console.WriteLine( lector.ReadToEnd() );
            }



            Console.ReadKey();
        }
    }
}
