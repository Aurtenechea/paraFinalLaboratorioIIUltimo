using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class miExepcion : Exception
    {
        public DateTime horaExcepcion;

        public miExepcion(DateTime hora, string mensaje, Exception excepAnterior)
            : base(mensaje, excepAnterior)
        {
            this.horaExcepcion = hora;

        }

        public miExepcion(DateTime hora, string mensaje) : this(hora, mensaje, null) { }

    }
}
