using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo1
{
    public interface ISerializacion
    {
        string RutaArchivo { get; set; }

        bool guardarSerializacion();
        bool leerSerializacion();
    }
}
