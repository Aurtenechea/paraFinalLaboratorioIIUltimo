using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2EnClase
{
    class Program
    {
        static void Main(string[] args)
        {

            Dolar unD;
            Pesos unP;
            unD = 1;
            unP = (Pesos)1;

            // sobrecarga de operadores.
            unD = unD + unP;

            unP = unP + unD;

        }
    }
}
