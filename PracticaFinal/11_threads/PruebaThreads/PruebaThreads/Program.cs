using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading; 

namespace PruebaThreads
{
    class Program
    {
        /*  sin el lock, y sin el sleep del Main, el resultado es que se 
            imprimen varias veces el mismo numero.
            ya que un hilo puede incrementar el count. pasa al otro hilo
            el otro hilo incrementa el count y luego imprime, y el primer
            hilo tambien imprime. La solucion es con el lock o con el Thread.Sleep. */
        
        static int count = 0;
        static object l = new object();

        static void IncrementCount() {
            while (true) {
                lock (l) {
                    count++;
                    Console.WriteLine("Thread ID " + Thread.CurrentThread.ManagedThreadId +
                        " incremented count to " + count);
                    Thread.Sleep(1000);
                }
            }
        }

        static void Main(string[] args)
        {
            Thread t1 = new Thread(IncrementCount);
            Thread t2 = new Thread(IncrementCount);
            t1.Start();
            //Thread.Sleep(500);
            t2.Start();
        }
    }
}
