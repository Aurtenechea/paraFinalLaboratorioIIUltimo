using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades1;
using Entidades2;

namespace Entidades3
{
    public class Articulo
    {
        private int _codigo;
        private string _nombre;
        private float _precioCosto;
        private float _precioVenta;
        private int _stock;

        public string NombreYCodigo
        {
            get
            {
                return  this._nombre + this._codigo.ToString();
            }
        }
        public float PrecioCosto
        {
            set
            {
                this._precioCosto = value;
                this._precioVenta = value + (0.3f * value); //
            }
        }
        public float PrecioVenta
        {
            get
            {
                return this._precioVenta;
            }
        }
        public int Stock
         {
             set
             {
                 this._stock = value;
             }
         }

        public Articulo(int codigo, string nombre, float precioCosto, int cantidad)
        {
            this._codigo = codigo;
            this._nombre = nombre;
            this.PrecioCosto = precioCosto; // set 
            this.Stock = cantidad; // set 

            //this._precioCosto = precioCosto;
            //this._precioVenta = precioCosto + ((float)0.3 * precioCosto);
        }

        public bool HayStock(int cantidad)
        {
            if (this._stock >= cantidad)
                return true;
            return false;
        }

        public static bool operator ==(Articulo articuloUno, Articulo articuloDos)
        {
            if (articuloUno.NombreYCodigo == articuloDos.NombreYCodigo)
                return true;
            return false;
        }
        public static bool operator !=(Articulo articuloUno, Articulo articuloDos)
        {
            return !(articuloDos == articuloUno);
        }

        public static int operator +(Articulo articuloUno, Articulo articuloDos)
        {
            return articuloUno._stock + articuloDos._stock;
        }
        public static int operator -(Articulo articuloUno, int cantidad)
        {
            return articuloUno._stock - cantidad;
        }
    }
}
