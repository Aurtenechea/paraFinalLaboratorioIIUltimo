using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoSeparado;
namespace Practica10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClaseQueLanzaExcepciones.func1();
            }
            catch 
            {
                Console.WriteLine("Ejecucion catch sin nada dentro de main");
            }
            finally
            {
                Console.WriteLine("Ejecucion finally de Main en Program ");
            }

            Console.ReadKey();

            /*
                Ejecucion catch DivideByZeroException dentro de ClaseQueLanzaExcepciones
                Ejecucion finally de func1 en ClaseQueLanzaExcepciones
                Ejecucion catch sin nada dentro de main
                Ejecucion finally de Main en Program
            */
        }
    }
}
