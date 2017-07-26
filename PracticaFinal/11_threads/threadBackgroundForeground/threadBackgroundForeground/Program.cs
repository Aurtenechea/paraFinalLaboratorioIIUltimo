using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace threadBackgroundForeground
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(metodoX);
            Thread t2 = new Thread(metodoY);

            /*  esto define si se cierra la aplicacion o no. 
                los threads foreground mantienen vivo el proceso de la aplicacion
                mientras estos se esten ejecutando. 
                los threads background no. Cuando todos los threads foreground 
                terminan la aplicacion se cierra terminando asi abruptamente con todos 
                los threads background. */
            t2.IsBackground = true;
            
            t1.Start();
            t2.Start();

            Thread.Sleep(5000);
            Console.WriteLine("End t1");
            t1.Abort();
            /*  Aca el thread main termina. 
                El thread t1 termina por el abort.
                y queda el t2:
                - si es background se cierra al aplicacion.
                - si es foreground se mantiene viva. */
            
        }

        public static void metodoX() 
        {
            while (true)
            {
                Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXX");
                Thread.Sleep(1000);
            }
        }
        public static void metodoY()
        {
            while (true)
            {
                Console.WriteLine("YYYYYYYYYYYYYYYYYYYYYYYYYY");
                Thread.Sleep(1000);
            }
        }



    }
}
