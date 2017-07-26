using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progIImodeloParcial
{
    public class Galletita:Producto
    {
        protected float _peso;

        public Galletita(int codigo, float precio, EMarcaProducto marca, float peso)
            : base(codigo, marca, precio)
        {
            this._peso = peso;
        }

        public static string MostrarGalletita(Galletita galleta)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( Producto.MostrarProducto((Producto)galleta) ); // (Producto) esta de mas. se castea solo
            sb.AppendLine( galleta._peso.ToString() );
            return sb.ToString();
        }
    }
}
