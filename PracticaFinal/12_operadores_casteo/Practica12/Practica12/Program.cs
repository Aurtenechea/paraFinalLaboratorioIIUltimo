using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  como el operador de casteo definido es del tipo implicit, 
                sirve para usarlo de las dos formas. Si fuese explicit 
                serviria de una. */


            /*  operador de casteo de forma implicita. */
            GrupoPersonas g = 3;
            /*  operador de casteo de forma explicita. */
            GrupoPersonas g2 = (GrupoPersonas)3;

            g[0].nombre = "nacho";
            g[1].nombre = "eze";
            g[2].nombre = "jose";          
            
            Console.ReadKey();
        }
    }
}
