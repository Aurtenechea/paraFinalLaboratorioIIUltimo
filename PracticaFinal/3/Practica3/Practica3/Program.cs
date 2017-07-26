using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  No se puede instanciar una clase abstracta. */
            // Person p = new Person("Nacho", 26, 35208599);

            Employee e = new Employee("Jose", 30, 35255234, (float)150.34);
            
            /*  metodo heredado de la clase abstracta con la implementacion en esa misma clase abstracta. */
            Console.WriteLine(e.toString());

            /*  metodo abstracto, con la implementacion en la clase hija. */
            e.myName();

            /*  como al dar implementacion en la clase hija a un metodo abstracto se sobreescribe
                ya no se puede acceder al metodo de la clase padre. (tampoco tendria sentido ya que no 
                tiene implementacion) */
            ((Person)e).myName();
            
            Console.ReadKey();
        }
    }
}
