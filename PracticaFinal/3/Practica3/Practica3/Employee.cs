using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    class Employee : Person
    {

        private float salary;


        public Employee(string name, int age, int dni, float salary)
            : base(name, age, dni)
        {
            this.salary = salary;
        }

        

        /*  Implementacion (o metodo sobreescrito) de la clase abstracta. */
        public override void myName()
        {
            Console.WriteLine("Nombre del EMPLEADO: " + this.name);
        }
    }
}
