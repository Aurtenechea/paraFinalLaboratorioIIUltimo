using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progIImodeloParcial
{
    public class Estante
    {
        protected sbyte _capacidad;
        protected List<Producto> _productos ;

        public float ValorEstanteTotal 
        {
            get
            {
                return this.GetValorEstante();
            }
        }


        public Estante(sbyte capacidad) :this()
        {
            this._capacidad = capacidad;
        }

        private Estante()
        {
            this._productos = new List<Producto>();
        }

        public List<Producto> GetProductos()
        {
            return this._productos;
        }

        public static string MostrarEstante(Estante est)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Capacidad del estante: " + est._capacidad);

            foreach (var item in est._productos)
            {
                if (item is Gaseosa)
                {
                   sb.AppendLine( ((Gaseosa)item).MostrarGaseosa() );
                }
                else if (item is Galletita)
                {
                    sb.AppendLine(Galletita.MostrarGalletita((Galletita)item));
                }
                else if (item is Jugo)
                {
                    sb.AppendLine(((Jugo)item).MostrarJugo());
                }
            }

            return sb.ToString();
        }

        public static bool operator !=(Estante est, Producto prod)
        {
            return !(est == prod);
        }

        public static bool operator == (Estante est, Producto prod)
        {
            foreach (Producto item in est._productos)
            {
                if (item == prod)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator +(Estante est, Producto prod)
        {
            if (est._capacidad > est._productos.Count && (est != prod))
            {
                est._productos.Add(prod);
                return true;
            }
            return false;
        }

        public static Estante operator -(Estante est, Producto prod)
        {
            if (est != prod)
            {
                return null;
            }
            else 
            {
                est._productos.Remove(prod);
                return est;
            }
        }

        public static Estante operator - (Estante est, ETipoProducto tipo)
        {
            Estante estAux = new Estante();
            estAux._capacidad = est._capacidad;
            estAux._productos = new List<Producto>(est._productos);

            // no funciona.. no se puede modificar una lista dentro de un foreach y la copia apunta al mismo objeto lista osea tamb se modifica.
            foreach (var item in est._productos)
            {
                if (item is Galletita && tipo == ETipoProducto.Galletita)
                {
                    estAux = estAux - item;
                }
                else if (item is Gaseosa && tipo == ETipoProducto.Gaseosa)
                {
                    estAux = estAux - item;
                }
                else if (item is Jugo && tipo == ETipoProducto.Jugo)
                {
                    estAux = estAux - item;
                }
                else if (tipo == ETipoProducto.Todos)
                {
                    estAux._productos.Clear();
                    break;
                }
            }
            return estAux;  
            
            
            ////deberia funcionar.
            //        for (int i = 0; i < est._productos.Count ; i++)
            //        {
            //            if (est._productos[i] is Galletita && tipo == ETipoProducto.Galletita)
            //            {
            //                est._productos.Remove(est._productos[i]);
            //                i--;   //si no descuento uno me salteo un elemento. Esto iria en cada else if tambien.
            //            }
            //            else if (est._productos[i] is Gaseosa && tipo == ETipoProducto.Gaseosa)
            //            {
            //                est._productos.Remove(est._productos[i]);
            //            }
            //            else if (est._productos[i] is Jugo && tipo == ETipoProducto.Jugo)
            //            {
            //                est._productos.Remove(est._productos[i]);
            //            }
            //        }
            //        return est;
        }

        private float GetValorEstante()
        {
            return this.GetValorEstante(ETipoProducto.Todos);
        }

        public float GetValorEstante(ETipoProducto tipo)
        {
            float acum = 0;
            foreach (var item in this._productos)
            {
                if (item is Galletita && tipo == ETipoProducto.Galletita  )
                {
                    acum += item.Precio;
                }
                else if (item is Gaseosa && tipo == ETipoProducto.Gaseosa)
                {
                    acum += item.Precio;
                }
                else if (item is Jugo && tipo == ETipoProducto.Jugo)
                {
                    acum += item.Precio;
                }
                else if (tipo == ETipoProducto.Todos)
                {
                    acum += item.Precio;
                }
            }
            return acum;
        }

    }
}
