using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Program
    {
        static void Main(string[] args)
        {
             Factura miFactura = new Factura(666);
             List <Documento> miListado = new List<Documento>();
             miListado.Add(miFactura);
             Remito unRemito = new Remito(999);
             miListado.Add(unRemito);

             foreach (var item in miListado)
             {
                 item.mostrar();
                 // ve solo ese atributo... del que heredab
             }



             FacturaA miFacA = new FacturaA(21, miFactura);
             FacturaAPagada miFacAPag = new FacturaAPagada("una fecha", miFacA);
             miListado.Add(miFacA);
             miListado.Add(miFacAPag);

             foreach (var item in miListado)
             {
                 item.mostrar();
                 // ve solo ese atributo... del que heredab
             }

             Console.Read();

        }
    }
}
