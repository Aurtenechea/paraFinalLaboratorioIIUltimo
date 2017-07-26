using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Ejercicio_02
    {

        public static int getPositive()
        {
            bool result;
            int value;

            Console.WriteLine("ingrese un numero positivo");
            result = int.TryParse(Console.ReadLine(), out value);
            
            while (!result || value<0)
            {
                Console.WriteLine("ERROR. Reingresar número!!!");
                result = int.TryParse(Console.ReadLine(), out value);
            }
      
            return value;
        }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 02";

            int numIngresado = Ejercicio_02.getPositive();

            Console.WriteLine("El cuadrado es: {0}", Math.Pow((double)numIngresado, 2));  // el casteo a double no hace falta.
            Console.WriteLine("El cuadrado es: {0}", Math.Pow((double)numIngresado, 3));
            Console.ReadKey();
        }
    }
}
