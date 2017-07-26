using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Nacho", 26, 35208599);
            Employee e = new Employee("Jose", 30, 35255234, (float)150.34);
            Boss b = new Boss("Pepe", 40, 35666222, (float)1700.20);

            /*  metodos simples heredados. */
            Console.WriteLine(p.toString());
            Console.WriteLine(e.toString());
            
            /*  SOBREESCRITURA. */
            /*  VIRTUAL Y OVERRIDE. */
            Console.WriteLine("VIRTUAL Y OVERRIDE");
            p.myName();
            e.myName();
            b.myName();

            /*  Un metodo virtual de Person puede ser sobreescrito en la clase hija y en la nieta. 
                Por eso segun como se castee un objeto se puede ejecutar cierto metodo si hay 
                herencias intermedias que no hayan hecho una implementacion del metodo. 
                Una de las ventajas de usar una clase "sealed" como Boss es el asegurarse que el override hecho
                para ese metodo, va a ser el ultimo, ya que no se puede heredar de esa clase. */
            /*  no se puede acceder al metodo original desde la clase que lo sobreescribio. */
            Console.WriteLine("VIRTUAL Y OVERRIDE");
            (p as Person).myName();
            (e as Person).myName();
            (b as Person).myName();

            Console.ReadKey();
        }
    }
}
