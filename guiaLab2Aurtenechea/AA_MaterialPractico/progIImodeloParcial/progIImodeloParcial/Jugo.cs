using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progIImodeloParcial
{
   public class Jugo:Producto
    {
        protected ESaborJugo _sabor;

        // si no llamo al base rompe. averiguar
        public Jugo(int codigo, float precio, EMarcaProducto marca, ESaborJugo sabor)
            : base(codigo, marca, precio)
        {
            this._sabor = sabor;
        }


        public string MostrarJugo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append( Producto.MostrarProducto(this) );
            sb.AppendLine(this._sabor.ToString());
            return sb.ToString();
        }
    }
}
