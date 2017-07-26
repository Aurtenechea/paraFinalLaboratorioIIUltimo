using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    class Employee : Person
    {

        private float salary;

       
        public Employee(string name, int age, int dni, float salary)
            : base(name, age, dni){
            this.salary = salary;
        }


        /*  sin usar los tipos virtual y override el compilador lanza un warning de que 
            se esta ocultando un metodo en la herencia. Hay que usar new si realmente se 
            quiere ocultar. */
        public new void birthday(){
            Console.WriteLine("Cumpleanios del EMPLEADO: " + this.name);
            this.age++;
        }

        /*  El metodo sobre escrito no puede ser virtual. Si otra clase hereda de esta y quisiera 
            sobreescribir el metodo, no se sabria cual de los dos se estaria heredando como virutal. */
        public override void myName()
        {
            Console.WriteLine("Nombre del EMPLEADO: " + this.name);
        }
    }
}
