using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Employee : Person
    {

        private float salary;

        /*  Si en la herencia, la clase hija no hace referencia a la clase padre
            el compilador hara una llamada a :base() sin parametros. Por lo cual 
            la clase padre debera tener un constructor sin parametros para que no 
            de error. */
        public Employee(string name, int age, int dni, float salary)
            :base(name, age, dni){

            this.salary = salary;
        }
        /*  este constructor esta llamando al constructor de la clase base por defecto. */
        public Employee(float salary){
        }

        /*  si en esta clase no se definiera ningun constructor. Por defecto se crearia
            uno asi:
            public Employee()
                     :base(){}
         */

    }
}
