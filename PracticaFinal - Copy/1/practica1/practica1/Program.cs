using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Person;  /* Esto es para namespaces. */

namespace practica1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Nacho",26,35208599);
            Employee e = new Employee("Jose", 30, 35255234, (float)150.34);


            Console.WriteLine(p.toString());
            Console.WriteLine(e.toString());
            e.birthday();
            Console.WriteLine(e.toString());

            Console.ReadKey();
        }
    }
}
