using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace SerializacionBinaria
{
    class XmlBinario:ISerializacion<T> where T : class
    {
        /// <summary>
        /// Guarda como Xml en un archivo llamado como el parametro "archivo" los datos contenidos en el parametro "datos".
        /// Lanza una excepcion ArchivosException si no pudo guardar.
        /// </summary>
        /// <param name="archivo">Nombre del archivo en el que se desea guardar.</param>
        /// <param name="datos">Datos a guardar en el archivo.</param>
        /// <returns>
        /// true si se pudo guardar.
        /// false si no. 
        /// </returns>
        public bool guardarSerializacion(string archivo, T datos)
        {
            bool aux = false;
            try
            {
                using (FileStream escritor = new FileStream(archivo,FileMode.Create))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(archivo, datos);
                    aux = true;
                }
            }
            catch
            {
                // throw new Exception("No se pudo guardar el archivo como Xml.");
                // nada
            }
            return aux;
        }

        /// <summary>
        /// Lee del archivo llamado como el parametro "archivo" y los guarda en el parametro "datos".
        /// Lanza una excepcion ArchivosException si no pudo leer.
        /// </summary>
        /// <param name="archivo">Nombre del archivo del que se desea leer.</param>
        /// <param name="datos">Donde se cargaran los datos leidos del archivo.</param>
        /// <returns>
        /// true si se pudo Leer.
        /// false si no. 
        /// </returns>
        public bool leerSerializacion(string archivo, out T datos)
        {
            bool result = false;
            try
            {
                using (FileStream escritor = new FileStream(archivo,FileMode.Open))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(archivo, datos);
                    aux = true;
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    datos = (T)serializador.Deserialize(lector);
                    result = true;
                }
            }
            catch
            {
                datos = null;
                //throw new Exception("No se pudo leer del archivo.");
                //nada
            }

            return result;
        }
    }
}

