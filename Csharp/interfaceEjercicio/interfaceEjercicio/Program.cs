using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceEjercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Privado miAvPriv = new Privado(1000, 700);

            Gestion.MostrarImpuestoNacional(miAvPriv);

        }
    }
}
