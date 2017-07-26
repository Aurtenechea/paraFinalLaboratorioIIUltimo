using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  Namespaces para serializar. */
using System.Xml.Serialization;
using System.Xml;

/*  Namespace para serializacion binaria. */
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

/*  */
using System.IO;

namespace SerPractica2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjetoDePrueba instance = new ObjetoDePrueba();
            instance.Value = 555;
            ObjetoDePrueba objLeido;

            /***********************************************************/
            /***********************************************************/
            /*  Serializacion Xml **************************************/

            /*  Escritura. */
            using(XmlTextWriter EscritorArchivosXml = new XmlTextWriter("../../../serializacion.xml", Encoding.UTF8))
            {
                XmlSerializer objetoSerializadorXml = new XmlSerializer(typeof(ObjetoDePrueba));
                objetoSerializadorXml.Serialize(EscritorArchivosXml, instance);
            }

            /*  Lectura. */
            using (XmlTextReader LectorArchivosXml = new XmlTextReader("../../../serializacion.xml"))
            {
                XmlSerializer objetoSerializador = new XmlSerializer(typeof(ObjetoDePrueba));
                objLeido = (ObjetoDePrueba) objetoSerializador.Deserialize(LectorArchivosXml);
            }

            Console.WriteLine("objeto leido, value: " + objLeido.Value);



            /***********************************************************/
            /***********************************************************/
            /*  Serializacion Binaria **********************************/

            using ( FileStream fileStreamVar = new FileStream("../../../serializacionBinaria.dat", FileMode.Create) )
            {
                BinaryFormatter serializadorBinario = new BinaryFormatter();
                serializadorBinario.Serialize(fileStreamVar, instance);
            }

            
            ObjetoDePrueba objBinarioLeido;
            using (FileStream fileStreamVar = new FileStream("../../../serializacionBinaria.dat", FileMode.Open))
            {
                BinaryFormatter serializadorBinario = new BinaryFormatter();
                objBinarioLeido = (ObjetoDePrueba) serializadorBinario.Deserialize(fileStreamVar);
            }
            Console.WriteLine("Deserializacion binaria El dato leido es : " + objBinarioLeido.Value );



            /***********************************************************/
            /***********************************************************/
            /*  archivos de texto **************************************/

            /*  Escritura. */
            using ( StreamWriter Escritor = new StreamWriter("../../../texto.txt", false) )
            { 
                Escritor.WriteLine("Objeto con Value: " + instance.Value);
                Escritor.WriteLine("Objeto con Value: " + instance.Value);
                Escritor.WriteLine("Objeto con Value: " + instance.Value);    

            }

            /*  Lectura. */
            using (StreamReader Lector = new StreamReader("../../../texto.txt"))
            {
                Console.WriteLine("lectura archivo txt: ");
                // opcion 1
                while(!Lector.EndOfStream)
                {
                    Console.WriteLine( Lector.ReadLine() );
                }
                // opcion 2
                //Console.WriteLine(Lector.ReadToEnd());
            }

            Console.ReadKey();
        }
    }
}
