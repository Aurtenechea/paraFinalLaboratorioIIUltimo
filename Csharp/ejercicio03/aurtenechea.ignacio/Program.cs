using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aurtenechea.ignacio
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("Ingrese un numero...");
            bool boolean = int.TryParse(Console.ReadLine(), out numero);

            while (!boolean) {
                Console.WriteLine("El valor ingresado es incorrecto, intentelo nuevamente.");
                boolean = int.TryParse(Console.ReadLine(), out numero);
            }

            for (int i = 0; i <= numero; i++ ){ 
                if ((i == 1 || i == 2 || i == 3 || i == 5 || i == 7) || (i % 2 != 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)){
                    Console.WriteLine(i);    
                }
            }

            Console.ReadLine();
        }
    }
}
