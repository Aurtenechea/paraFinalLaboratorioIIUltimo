using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Employee : Person
    {

        private float salary;

        

        public Employee(string name, int age, int dni, float salary)
            : base(name, age, dni)
        {
            this.salary = salary;
            
            /*  tambien se puede hacer uso de la propiedad estatica heredada en la clase hija. */
            // Employee.partos += 10;
        }

       
    }
}
