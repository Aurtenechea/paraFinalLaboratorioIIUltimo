using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtroNamespace;

namespace Practica18
{
    public static class Program
    {
        
        static void Main(string[] args)
        {
            Random r = new Random();
            Array arrRand = r.getArray(10);

            Console.WriteLine("Lista de numeros: ");
            foreach (var item in arrRand)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(10.ToString());

            int [] a = new int[10];


            /*  No se puede sobreescribir un metodo que ya existe.. */
            Console.WriteLine(a.ToString());


            Console.ReadKey();
        }
    }
}
