using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Factura: Documento
    {
        public float importe;

        public Factura(int numero)
            : base(numero)
        { }


         public Factura(int num, string fecha, int numCtrl) :base( num,  fecha,  numCtrl) //llama al otro
        {
           
        }

        // los constructores no se heredan
        // no quiere decir que factura tiene un documento adentro, sino que factura es un documento.
        // se heredan metodos y atributos.. los que son privados se heredan pero no se pueden ver.
        
    }
}
