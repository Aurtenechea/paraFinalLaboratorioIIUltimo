using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Nacho", 26, 35208599);
            Person e = new Employee("Jose", 30, 35255234, (float)150.34);
            
            
            /*  Metodo heredado simplemente. Es un metodo de la clase persona. */
            Console.WriteLine(p.toString());
            Console.WriteLine(e.toString());
            /*  Metodo sobreescrito. No se puede acceder al metodo de persona mediante polimorfismo.*/
            p.myName();     // muestra PERSONA
            e.myName();     // muestra EMPLEADO
            /*  Metodo ocultado. Existe el metodo en persona y en empleado esta ocultado con "new" */
            p.birthday();   // muesta PERSONA
            e.birthday();   // muesta PERSONA


            /*  El metodo acepta Personas como parametro. pero como e en realidad es un Empleado 
                lo detecta mediante el operador is y va a imprimir un cuil en su lugar. */
            Person.dni_o_cuil(p);   // muesta DNI
            Person.dni_o_cuil(e);   // muesta CUIL
            /*  version de instancia. */
            p.dni_o_cuil();     // muesta DNI
            e.dni_o_cuil();     // muesta CUIL



            Console.WriteLine("-- CASO PARTICULAR: ");
            Console.WriteLine(p.getDni());
            Console.WriteLine(e.getDni());


            Console.ReadKey();
        }
    }
}
