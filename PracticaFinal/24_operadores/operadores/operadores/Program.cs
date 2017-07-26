using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {

            GrupoPersonas g = new GrupoPersonas();
            Persona p = new Persona("nacho");
            Persona p2 = new Persona("mariana");


            g = g + p;
            g = g - p2;
            g = g + p2;
            g = g - p;

            /*  implicito */
            Persona p3 = "sofia";
            
            /*  explicito */
            Object o = (Persona) "Karen";

            

            Console.ReadKey();
        }
    }
}
