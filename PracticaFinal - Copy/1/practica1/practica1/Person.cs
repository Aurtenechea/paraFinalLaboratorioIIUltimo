using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica1
{
    class Person
    {

        private string name;
        private int age;
        private int dni;


        public Person(string name, int age, int dni){
            this.name = name;
            this.age = age;
            this.dni = dni;
        }
        public Person()
        {
        }

        public string toString(){
            return "Objeto Persona: >>\n nombre: " + this.name + " | dni: " + this.dni + " | edad: " + this.age;
        }

        public void birthday(){
            this.age ++ ;
        }
    }
}
