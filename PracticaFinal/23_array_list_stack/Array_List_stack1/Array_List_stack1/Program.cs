using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_stack1
{
    class Program
    {
        /*  Array dos maneras de crearlos. */
        public static string[] sArray;
        public static string[] sArray2;
        /*  List */
        public static List<string> sList;
        /*  Stack */
        public static Stack<string> sStack;
        /*  Queue */
        public static Queue<string> sQueue;

        static void Main(string[] args)
        {
            /*  Arrays dos maneras de crearlos. */
            sArray = new string[10];
            ///*  asi se puede inicializar. deben estar todos los elementos. */
            //sArray = new string[10] { "nacho", "jorge", "", "", "", "", "", "", "", "" };
            
            sArray2 = (string[])Array.CreateInstance( typeof(string), 10 );

            sArray[0] = "nacho";
            sArray2[0] = "nacho";
            sArray[1] = "Georgina";
            sArray2[1] = "Georgina";

            /*  List */
            sList = new List<string>();
            sList.Add("nacho");
            sList.Add("eze");
            sList.Remove("eze");
            sList[0] = "weee";
            /*  no se puede agregar un elemento en un indice que no existe. */
            // sList[1] = "Eze";
            sList.RemoveAt(0);
            /*  insert index debe estar dentro de los limites de la lista. */
            // sList.Insert(10, "nacho");
            sList.Clear();


            /*  Stack */
            sStack = new Stack<string>();
            sStack.Push("nacho");
            sStack.Push("nacho1");
            sStack.Push("nacho2");
            sStack.Push("nacho3");
            sStack.Pop();
            /* no se puede acceder como array */
            // sStack[0] = "asdq";
            // Console.WriteLine(sStack[0]);

            /* Queue */
            sQueue = new Queue<string>();
            sQueue.Enqueue("nacho");
            sQueue.Enqueue("Eze");
            sQueue.Enqueue("Jorge");
            sQueue.Dequeue();
            /* no se puede acceder como array */
            // sQueue[0] = "wqe";
            // Console.WriteLine(sQueue[0]);
            


            Console.ReadKey();
        }
    }
}
