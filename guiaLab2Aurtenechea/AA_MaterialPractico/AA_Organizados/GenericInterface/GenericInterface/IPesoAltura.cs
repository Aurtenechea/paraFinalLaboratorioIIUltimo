using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public interface IPesoAltura <T>
    {
        /*
         * interface que define las firmas de metodos que devuelven el peso y la altura de cualquier criatura.
         */
        float GetPeso(T criatura);

        float GetAltura(T criatura);

    }
}
