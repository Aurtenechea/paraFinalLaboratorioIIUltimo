using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Nacho", 26, 35208599);
            Employee e = new Employee("Jose", 30, 35255234, (float)150.34);
            Boss b = new Boss("Pepe", 40, 35666222, (float)1700.20);

            Console.WriteLine(p.toString());
            Console.WriteLine(e.toString());
            p.myName();
            e.myName();

            /*  SOBREESCRITURA. */
            /*  VIRTUAL Y OVERRIDE. */
            /*  no se puede acceder al metodo original desde la clase que lo sobreescribio. */
            ((Person)e).myName();       // muestra EMPLEADO
            (e as Person).myName();     // idem anterior.

            /*  en la segunda herencia el metodo que se hereda es el del Empleado. Es decir el que esta 
                sobreescrito. Puede volver a ser sobreescrito. */
            b.myName();
            /*   Ya no se puede acceder al metodo original de la persona desde la segunda herencia. */
            ((Person)b).myName();       // muestra EMPLEADO
            (b as Person).myName();     // idem anterior


            /*  OCULTACION */
            /*  SIN NADA, OSEA SOLO CON OPERADOR NEW. */
            p.birthday();   // muesta PERSONA
            /*  se hereda el metodo de la ultima clase que lo oculto (la que uso new). */
            e.birthday();   // muesta EMPLEADO
            b.birthday();   // muesta EMPLEADO
            /*  se puede acceder al metedo original ya que este fue ocultado no sobreescrito. */
            ((Person)e).birthday();     // muesta PERSONA
            ((Person)b).birthday();     // muesta PERSONA
            (b as Person).birthday();   // idem anterior.

            Console.ReadKey();
        }
    }
}
