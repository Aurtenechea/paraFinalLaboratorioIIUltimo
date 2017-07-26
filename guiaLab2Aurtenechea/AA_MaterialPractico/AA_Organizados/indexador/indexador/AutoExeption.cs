using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    class AutoExeption: miExepcion
    {
        public Auto miAuto;

        public AutoExeption(string mensaje, DateTime fecha, Auto auto,Exception excepAnterior)
            : base(fecha, mensaje,excepAnterior)
        {
            this.miAuto = auto;
        }

        public AutoExeption(string mensaje, DateTime fecha, Auto auto) : this(mensaje, fecha, auto, null) { }
    }
}
