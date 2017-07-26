using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Ejercicio_04
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";

            int cont = 0, acum = 0, j=1;


            Console.WriteLine("Primeros 4 numeros perfectos: ");
            while(cont != 4)
            {
                for (int i = j-1; i > 0; i--)
                {
                    if (j % i == 0) 
                    {
                        acum += i;
                    }
                }
                if (acum == j)
                {
                    Console.WriteLine("{0}", j);
                    cont++;
                }
                j++;
                acum = 0;
            }

            Console.ReadKey();
        }
    }
}
