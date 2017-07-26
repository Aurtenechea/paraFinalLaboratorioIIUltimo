using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension2
{
    public static class ClaseQueMeImportaUnCarajoElNombre
    {
        public static string agregarSaludo(this string str, string nombre)
        {
            return str + ". Saludos - " + nombre;
        }

    }
}
