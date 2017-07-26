using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace PruebaThreads3
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(uno);
            t1.Start();
            Thread t2 = new Thread(dos);
            t2.Start();
            while(true)
            {
                if (!t2.IsAlive) { t1.Abort(); break; }
                
            }
            
            //Thread.Sleep(5000);   // 5 seg == 30000 ciclos for.
            //t.Abort();

            Console.Read();
        }

        public static void uno() 
        {
            for (int i = 0; i >= 0; i++)
            {
                Console.WriteLine(" - " + i);
            }
        }

        public static void dos()
        {
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0,0,10);
            dt = dt.Add(ts);

            while (dt.CompareTo(DateTime.Now) == 1)
            {
                Console.WriteLine("Ahora son: " + DateTime.Now + " y dt vale: " + dt.ToString() );
                Thread.Sleep(1000);
            }
        }

    }
}
