using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametrizadas2
{
    public class ClaseParametrizada<T> : ClasePadre, interface1<T>, interface2 
    {
        public T value;

        public ClaseParametrizada(T param) 
            :base(new Object())
        {
            this.value = param;
        }

        public void escribeX(T s) 
        {
            Console.WriteLine("XXXXXXXXX");
            Console.WriteLine(base.num);
        
        }

        void interface2.imprimeY() 
        {
            Console.WriteLine("YYYYYYYYY");
        }


    }
}
