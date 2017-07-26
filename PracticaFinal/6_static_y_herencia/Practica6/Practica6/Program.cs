using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  en los metodos estaticos no se pueden utilizar los modificadores virtual override y abstract*/

            /*  las propiedades y metodos estaticos se heredan. los constructores estaticos, que solo se ejecutan 
                antes de la primera ejecucion de un constructor de instancia tambien se heredan.
                En este caso se instancie una persona o un empleado el constructor estatico se ejecuta.*/
            
            //Person p = new Person("Nacho", 26, 35208599);
            //Console.WriteLine(p.toString());
            /*  se ejecuta por unica vez el constructor estatico heredado. */
            Employee e = new Employee("Jose", 30, 35255234, (float)150.34);
            Console.WriteLine(e.toString());
            /*  funcion estatica heredada. */
            Employee.func();
            /*  utilizacion de una propiedad */
            e.apellido = "aurtenechea";
            e.Sexo = "masculino";
            Console.WriteLine(e.apellido);
            Console.WriteLine(e.Sexo);
            /*  consultar el valor de un atributo estatico heredado. */
            Console.WriteLine(Employee.partos);
            

            Console.ReadKey();
        }
    }
}
