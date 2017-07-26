using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
    class Ejercicio_05
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
            Console.Title = "Ejercicio Nro 05";

            int numIngresado = Ejercicio_05.getPositive();

            int acum, acum2;

            Console.WriteLine("Los centros numericos del 1 al {0} son:", numIngresado);
            for (int i = 2; i < numIngresado; i++)
            {
                acum = 0;
                acum2 = 0;

                for (int j = i-1; j > 0 ; j--)
                {
                    acum += j;
                }

                for (int k = i + 1; k <= numIngresado; k++)
                {
                    acum2 += k;
                }

                if (acum == acum2)
                    Console.WriteLine("{0}", i );
            }


            Console.WriteLine("Fin");
            Console.ReadLine();
        }
    }
}
