using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Class1 : ClassPadre, Interface1, Interface2,Interface3
    {
        public void Method1()
        {
            Console.WriteLine("Implementacion de method1 implicito para interface1 y interface2");
        }
        
        public void Method2()
        {
            Console.WriteLine("Implementacion de method2 implicito interface2");
        }

        void Interface2.Method2() // este no se ve desde el objeto a menos que se castee a interface.
        {
            Console.WriteLine("Implementacion de method2 explicito para interface2");
        }

        public void Method1Inter3()
        {
            Console.WriteLine("Implementacion de method3 implicito interface3");
        }


    }
}
