using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujeo
{
    class Program
    {
        static void Main(string[] args)
        {
            // constructor / instancia / program



            Clase2 miVar = new Clase2();
            try
            {
                miVar.Method();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Mensaje del error: " + ex.Message + "\n" + "Mensaje de la excepcion padre:  " + ex.InnerException.Message);
            }

            Console.ReadKey();
            

        }
    }
}
