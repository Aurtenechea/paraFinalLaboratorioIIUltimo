using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml;
using System.Xml.Serialization;

namespace SerializacionBinaria
{
    public class ClaseASerializar
    {
        private int uno;
        private int dos;
       // private ClaseHija ch;

        public ClaseASerializar(int n1, int n2)
        {
            this.uno = n1;
            this.dos = n2;
         //   this.ch = new ClaseHija();
        }

        //public static bool Guardar(string archivo, ClaseASerializar c)
        //{
        //    Xml<ClaseASerializar> xml = new Xml<ClaseASerializar>();
        //    return xml.guardarSerializacion(archivo, c);
        //}

        //public static bool Leer(string archivo, out ClaseASerializar c)
        //{
        //    Xml<ClaseASerializar> xml = new Xml<ClaseASerializar>();
        //    return xml.leerSerializacion(archivo, out c);
        //}

    }
}
