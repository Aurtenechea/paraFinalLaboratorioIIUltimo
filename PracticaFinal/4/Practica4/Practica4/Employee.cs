using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Employee : Person
    {

        private float salary;

        public Employee(string name, int age, double dni, float salary)
            : base(name, age, dni)
        {
            this.salary = salary;
        }

        /*  sin usar los tipos virtual y override el compilador lanza un warning de que 
            se esta ocultando un metodo en la herencia. Hay que usar new si realmente se 
            quiere ocultar. */
        public new void birthday()
        {
            Console.WriteLine("Cumpleanios del EMPLEADO: " + this.name);
            this.age++;
        }

        /*  El metodo sobre escrito no puede ser virtual. Si otra clase hereda de esta y quisiera 
            sobreescribir el metodo, no se sabria cual de los dos se estaria heredando como virutal. */
        public override void myName()
        {
            Console.WriteLine("Nombre del EMPLEADO: " + this.name);
        }







        /*  CASO PARTICULAR. */
        /*  dentro de override la unica manera de acceder al metodo virtual de la clase padre 
            es a travez de "base". Ya que el metodo sobreescrito no permite acceder al de la
            clase base a travez de polimorfismo. A su vez base invoca al metodo de INSTANCIA y 
            dentro de el se va a poder acceder a los atributos del objeto con this.
            A tener en cuenta es que no se puede hacer base para acceder a un metodo abstracto
            ya que no tendria implementacion. */
        public override string getDni()
        {
            /*  reemplazaria a esto, que no funcionaria. */
            // return "20" + ((Person)this).getDni() + "6";
            
            return "20" + base.getDni() + "6";
        }
    }
}
