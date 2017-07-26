using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class FacturaAPagada : FacturaA 
    {
        public FacturaAPagada(string fechaPago, FacturaA facA): base(facA.iva, facA)
        { 
            // se le puede pasar una factura a al base que pide una factura porque facturaA es una factura.
            // cualquiera de los hijos puede reemplazar al padre.
            // los protected solo se ven en los que son herencia directa
        }
    }
}
