
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace ProyectoSeparado
{
    public class ClaseQueLanzaExcepciones
    {
        public static void func1() 
        {
            try
            {
                int cero = 0;
                int result = 4 / cero;
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("Ejecucion catch DivideByZeroException dentro de ClaseQueLanzaExcepciones");
                throw new ExcepcionPropia(e);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ejecucion catch Exception dentro de ClaseQueLanzaExcepciones");
                throw new ExcepcionPropia(e);
            }
            finally
            {
                Console.WriteLine("Ejecucion finally de func1 en ClaseQueLanzaExcepciones");
            }

        }
    }
}
