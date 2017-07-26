using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Remito: Documento
    {
        public string fecha;

        public Remito(int numero)
            : base(numero)
        { }

         public Remito(int num, string fecha, int numCtrl) :base( num,  fecha,  numCtrl) //llama al otro
        {
           // base llama al constructor de la clase del cual se hereda.
        }

    }
}
