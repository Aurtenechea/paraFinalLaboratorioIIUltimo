using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;
namespace Partica10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClaseUno uno = new ClaseUno();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Source);
                Console.WriteLine(e.InnerException.InnerException.InnerException.Message);
                Console.WriteLine(e.InnerException.InnerException.Message);
                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.Message);               
                Console.WriteLine(e.InnerException.InnerException.InnerException.TargetSite);
                Console.WriteLine(e.InnerException.InnerException.TargetSite);
                Console.WriteLine(e.InnerException.TargetSite);
                Console.WriteLine(e.TargetSite);               
            }


            Console.ReadKey();
            /*  
                hacer una excepcion que pase por 
                constructor
                metodo de clase
                metodo estatico
                constructor.
             */
        }
    }
}
