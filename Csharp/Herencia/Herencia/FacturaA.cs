using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class FacturaA: Factura
    {
        public int iva;
        // ver diagrama uml

        public FacturaA (int iva, Factura fac) :base(fac.numero, fac._fecha,fac._numeroDeControl )
        {
            this.iva = iva;
        }
    }
}
