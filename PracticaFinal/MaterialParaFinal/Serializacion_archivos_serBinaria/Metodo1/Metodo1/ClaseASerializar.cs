using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;


/*  El metodo uno es sin clase intermedia, es decir al objeto que se quiera guardar, 
    se le implementan los metodos de la interfaz. */

/*  esta linea va si hay clases que derivan de esta, hay que notificarlas
    en la clase base. */
//1: [XmlInclude(typeof(ChildA))]
namespace Metodo1
{
    public class ClaseASerializar : ISerializacion
    {

        private int uno;
        private int dos;


        public ClaseASerializar(int n1, int n2)
        {
            this.uno = n1;
            this.dos = n2; 
        }





        public ClaseASerializar() { }

        public int Uno
        {
            get { return this.uno; }
            set { this.uno = value; }
        }
        public int Dos
        {
            get { return this.dos; }
            set { this.dos = value; }
        }

        public string RutaArchivo
        {
            get;
            set;
        }
        public bool guardarSerializacion()
        {
            bool result = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(ClaseASerializar));
                    serializador.Serialize(escritor, this);
                    result = true;
                }
            }
            catch (Exception e)
            {
                // nada
            }
            return result;
        }


        public bool leerSerializacion() 
        {
            bool result = false;
            try
            {
                using (XmlTextReader lector = new XmlTextReader(this.RutaArchivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(ClaseASerializar));
                    ClaseASerializar objTemporal = (ClaseASerializar)serializador.Deserialize(lector);
                    this.uno = objTemporal.uno;
                    this.dos = objTemporal.dos;
                    
                    result = true;
                }
            }
            catch
            {
                //  nada;
            }

            return result;
        }


    }
}
