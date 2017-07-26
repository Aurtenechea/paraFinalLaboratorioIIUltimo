using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rep1erParcialProg
{
    class Program
    {
        static void Main(string[] args)
        {
            int intVar;
            string strVar;
            Class1 objClass1 = new Class1(3456, "Atenea");
            objClass1.generadorParesValores();

            
            StringBuilder sb = new StringBuilder();

            foreach (var item in objClass1.paresDeNumeros)
            {
                sb.AppendLine( item.ToString() );
            }


            intVar = objClass1;
            
            sb.AppendLine("funciona el implicit: "+ (intVar + 0) );
            sb.AppendLine("funciona el explicit: " + (int)objClass1);
            //strVar = objClass1; // da error;
            sb.AppendLine("no funciona el implicit: ");
            strVar = (string)objClass1;
            sb.AppendLine("funciona el explicit: " + strVar);
            
            intVar = (int)objClass1;



            Console.Write(sb);
            objClass1.paresDeNumeros.Sort(Class1.ordenarAsc);

            Console.ReadKey();
        }
    }
}
