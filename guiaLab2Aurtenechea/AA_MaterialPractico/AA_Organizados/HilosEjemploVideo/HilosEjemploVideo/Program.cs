using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HilosEjemploVideo
{

    public class ThreadedWorker
    {
        int ID;
        Thread t;

        public ThreadedWorker(int id)
        {
            this.ID = id;
            t = new Thread(new ThreadStart(DoWork));
            t.Start();
        }

        public void DoWork()
        { 
            for(int i=0; i<10; i++)
            {
                Console.WriteLine("Thread " +this.ID+ " is running...");
            }
            Console.WriteLine("Thread " + this.ID + " finished.");
        }
            
    }


    class Program
    {



        static void Main(string[] args)
        {

            for (int i = 0; i < 10; i++)
            {
                ThreadedWorker tw = new ThreadedWorker(i);
            }
            Console.ReadKey();

        }
    }
}
