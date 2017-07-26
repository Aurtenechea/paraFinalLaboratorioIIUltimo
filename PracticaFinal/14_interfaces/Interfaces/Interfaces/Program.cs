using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            Class1 obj = new Class1();
            obj.Method1();
            obj.Method2(); // la implementacion del metodo debe ser implicita para poder verse desde el program
            ((Interface2)obj).Method2(); // la implementacion explicita necesita ser casteada a la interface para poder verse del program.           
            obj.Method1Inter3(); // Class1 hereda la interface3 

            Console.ReadKey();
        }
    }
}
