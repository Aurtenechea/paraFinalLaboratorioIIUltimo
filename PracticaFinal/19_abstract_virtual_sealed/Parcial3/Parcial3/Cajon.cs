using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;
//using System.Xml.XmlTextWriter;




namespace Parcial3
{
    public class Cajon<T> :ISerializable
    {
        private int _capacidad;
        private List<T> _frutas;
        private float _precioUnitario;

        public List<T> Frutas
        {
            get { return this._frutas; }
        }
        public float PrecioTotal 
        {
            get {
                    //float total;
                    //foreach (var item in _frutas)
                    //{
                    //    item.                        
                    //}
    
                    /*  Si es precio unitario no es por peso. */
                    return this._precioUnitario * this._frutas.Count();    
                }
        }

        public Cajon()
        {
            this._frutas = new List<T>();
        }
        public Cajon(int capacidad) 
            :this() 
        {
            this._capacidad = capacidad;
        }
        public Cajon(int capacidad, float precio)
            :this(capacidad)
        {
            this._precioUnitario = precio;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("CAJON: ***********************");
            sb.AppendLine("Capacidad: " + this._capacidad);
            sb.AppendLine("Cantidad de frutas: " + this._frutas.Count);
            sb.AppendLine("Precio total: " + this.PrecioTotal);
            sb.AppendLine("Listado de Frutas: ---->>");
            foreach (T item in this._frutas)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }


        public static Cajon<T> operator +(Cajon<T> c, T f)
        {
            if (c.Frutas.Count() < c._capacidad)
                c.Frutas.Add(f);
            else
                throw new Exception();

            return c;
        }

        public string RutaArchivo
        {
            get;
            set;
        }

        public bool SerializarXML()
        {
            bool aux = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter(this.RutaArchivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Cajon<T>));
                    serializador.Serialize(escritor, this);
                    aux = true;
                }
            }
            catch (Exception e)
            {
                // nada
            }
            return aux;
        }

        string ISerializable.RutaArchivo
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        bool ISerializable.SerealizarXML()
        {
            throw new NotImplementedException();
            return true;
        }
    }
}
