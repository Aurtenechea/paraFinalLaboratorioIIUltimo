using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Ejercicio_01
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";

            int[] numeros = new int[5]; //  utilice un array para aprender a usarlo.
            bool result;
            int suma = 0;
      
            for (int i = 0 ; i < 5; i++)
            {
                do{    
                    Console.WriteLine("ingrese un numero {0}...", i);
                    result = int.TryParse(Console.ReadLine(), out numeros[i]);
                } while (!result);
                suma += numeros[i];
            }

            int max = 0;  // si no se inicializa da error.
            int min = 0;
            bool flag = false; // utilizo un flag por si se ingresan numeros negativos.

            for (int i = 0 ; i < 5; i++)
            {
                if( min > numeros[i] || flag == false)
                {
                    min = numeros[i];
                }
       
                if( max < numeros[i] || flag == false)
                {
                    max = numeros[i];
                    flag = true;
                }
             }

            Console.WriteLine("El menor ingresado fue: {0}", min);
            Console.WriteLine("El mayor ingresado fue: {0}", max);
            Console.WriteLine("El promedio es: {0}", decimal.Divide(suma, 5)); // falta el formato especificado.

            Console.ReadKey();
        }
    }
}
