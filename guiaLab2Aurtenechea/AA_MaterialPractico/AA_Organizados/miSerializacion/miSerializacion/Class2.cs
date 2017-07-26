using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace miSerializacion
{
    public class Class2 : Class1
    {
        public bool Serializacion(string archivo)
        {
            bool aux = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Class2));
                    serializador.Serialize(escritor, this);
                    aux = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            return aux;
        }

    }
}
