using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace PruebaThreads2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(uno);
            t.Start();
            while(t.IsAlive)
            {
                Console.WriteLine("yo se que el thread esta trabajando.");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }

        public static void uno() {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("funcion uno en ejecucion");
                Thread.Sleep(1000);
            }
            Console.WriteLine("fin ejecucion");
        }
    }
}
