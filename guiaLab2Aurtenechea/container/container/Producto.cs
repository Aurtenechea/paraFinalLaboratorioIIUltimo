using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container
{
    class Producto
    {
        private int _codigoDeBarra;
        private string _nombre;
        private double _precio;
        private eTipoComestible tipo;

        
        private Producto(int codigoDeBarra) 
        {
            this._codigoDeBarra = codigoDeBarra;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo):this(codigoDeBarra)
        {
            this._nombre = nombre;
            this.tipo = tipo;
        }

        public Producto(int codigoDeBarra, string nombre, eTipoComestible tipo, double precio):this(codigoDeBarra, nombre, tipo)
        {
            this._precio = precio;
        }


        public void mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("cod: " + this._codigoDeBarra);
            sb.AppendLine("nombre: " + this._nombre);
            sb.AppendLine("precio: " + this._precio);
            sb.AppendLine("tipo: " + this.tipo);
            sb.AppendLine("------------------------------------------");
            Console.Write(sb);
        }

        public static bool operator ==(Producto proUno, Producto proDos)
        {
            bool r= false;
            if (proUno._codigoDeBarra == proDos._codigoDeBarra)
            {
                r = true;
            }
            return r;
        }

        public static bool operator !=(Producto proUno, Producto proDos)
        {
            return !(proUno == proDos);
        }

        public static bool operator ==(Producto proUno, eTipoComestible tipo)
        {
            bool r = false;
            if (proUno.tipo == tipo)
            {
                r = true;
            }
            return r;
        }
        public static bool operator !=(Producto proUno, eTipoComestible tipo)
        {
            return !(proUno.tipo == tipo);
        }


    }
}
