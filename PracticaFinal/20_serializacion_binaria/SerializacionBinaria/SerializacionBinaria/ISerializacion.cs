using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerializacionBinaria
{
    public interface ISerializacion<T>
    {
        bool guardarSerializacion(string archivo, T datos);
        bool leerSerializacion(string archivo, out T datos);
    }
}
