using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Objeto varObjeto = new Objeto();
            Objeto.countPublic++; // es estatico por eso no se puede llamar desde una instancia, solo de la clase en general.
                                  // como es publico puedo llamarlo desde fuera de la clase.

            Objeto varObjeto2 = new Objeto(5);
            Objeto.countPublic++;
            


        }
    }
}
