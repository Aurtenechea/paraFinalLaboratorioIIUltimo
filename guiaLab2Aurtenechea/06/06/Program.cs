using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    class Ejercicio_06
    {

        public static int getPositive()
        {
            bool result;
            int value;

            Console.WriteLine("ingrese un numero positivo");
            result = int.TryParse(Console.ReadLine(), out value);

            while (!result || value < 0)
            {
                Console.WriteLine("ERROR. Reingresar número!!!");
                result = int.TryParse(Console.ReadLine(), out value);
            }

            return value;
        }

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";




               // SI ((año divisible por 4) Y ((año no divisible por 100) O (año divisible por 400))) ENTONCES
        }
    }
}
