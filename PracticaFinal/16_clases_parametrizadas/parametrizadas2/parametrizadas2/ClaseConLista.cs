using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;
using System.Xml;

namespace parametrizadas2
{
    public class ClaseConLista :ClaseConListaPadre
    {
        private List<Persona> list;
        private int capacidad;

        public List<Persona> List
        {
            get { return this.list; }
            set { this.list = value; }
        }

        public int Capacidad
        {
            get { return this.capacidad; }
            set { this.capacidad = value; }
        }

        public ClaseConLista(int capacidad) 
        { 
            this.list = new List<Persona>();
            this.capacidad = capacidad;

        }

        public ClaseConLista()
        {
            // this.list = new List<Persona>();
        }

        public static ClaseConLista operator +( ClaseConLista c, Persona p )
        {
            if (c.capacidad > c.list.Count)
                c.list.Add(p);
            else
                throw new Exception("no hay mas lugar.");

            return c;
        }

        public static ClaseConLista operator -(ClaseConLista c, Persona p)
        {
            for (int i = 0; i < c.list.Count; i++)
            {
                if (c.list[i].nombre == p.nombre)
                { 
                    c.list.RemoveAt(i);
                    break;
                }
            }
            return c;
        }

        public static void deserializar(string direc, out ClaseConLista objeto)
        {
            ClaseConLista objeto2 = null;
            using (XmlTextReader lector = new XmlTextReader("../../../file.xml"))
            {
                try
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(ClaseConLista));
                    objeto2 = (ClaseConLista ) serializador.Deserialize(lector);
                }
                catch (Exception e)
                {
                }

            }
            objeto = objeto2;

        }


    
    }

    public class Persona
    {
        public string nombre;
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public Persona() { }
    }

}
