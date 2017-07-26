using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progIImodeloParcial
{
    public class Producto
    {

        protected int _codigoBarra;
        protected EMarcaProducto _marca;
        protected float _precio;

        public EMarcaProducto Marca
        {
            get { return this._marca; }
        }

        public float Precio
        {
            get { return this._precio; }
        }

        public Producto(int codigo, EMarcaProducto marca, float precio)
        {
            this._codigoBarra = codigo;
            this._precio = precio;
            this._marca = marca;
        }

        protected static string MostrarProducto(Producto prod)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(prod.Marca.ToString());
            sb.AppendLine(prod.Precio.ToString());
            sb.AppendLine(prod._codigoBarra.ToString());

            return sb.ToString();
        }

        #region operators

        public static bool operator ==(Producto prodUno, Producto prodDos)
        {
            if (prodUno.Marca == prodDos.Marca && prodUno._codigoBarra == prodDos._codigoBarra)
                return true;
                return false;
        }

        public static bool operator ==(Producto prodUno, EMarcaProducto marca)
        {
            if (prodUno.Marca == marca)
                return true;
            return false;
        }

        public static bool operator !=(Producto prodUno, Producto prodDos)
        {
            return !(prodUno == prodDos);
        }

        public static bool operator !=(Producto prodUno, EMarcaProducto marca)
        {
            return !(prodUno == marca);
        }

        public static explicit operator int(Producto prod)
        {
            return prod._codigoBarra;
        }

        #endregion

    }
}
