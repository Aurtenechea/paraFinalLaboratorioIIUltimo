using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Container
    {
        private int _capacidad;
        private string _empresa;
        private List<Producto> _listaProductos = new List<Producto>();


        public bool Agregar(Producto proUno)
        {
            if (!(this == proUno) && this._capacidad > this._listaProductos.Count)
            {
                this._listaProductos.Add(proUno);
                return true;
            }
            else 
            {
                return false;
            }
            
        }

        public Container(int capacidad, string empresa)
        {
            this._capacidad = capacidad;
            this._empresa = empresa;
        }

        public static void Mostrar(Container contenedor)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("empresa: "  + contenedor._empresa);
            sb.AppendLine("capacidad: " + contenedor._capacidad);

            sb.AppendLine("contine:");
            Console.Write(sb);

            foreach (var item in contenedor._listaProductos)
            {
                item.mostrar();   
            }   
        }

        public static bool operator ==(Container container, Producto proUno)
        {
            bool r = false;
            foreach(Producto item in container._listaProductos)
            {
                if (item == proUno)
                {
                    r = true;
                    break;
                }
            }
        return r;
        }

        public static bool operator !=(Container container, Producto proUno)
        {
            return !(container == proUno);
        }

        public static List<Producto> operator -(Container contenedorUno, eTipoComestible tipo)
        {
            List<Producto> ls = new List<Producto>();
            foreach (Producto item in contenedorUno._listaProductos)
            {
                if (item == tipo)
                {
                   ls.Add(item);
                }
            }

            return ls;
        }

       
        
    
    }

}
