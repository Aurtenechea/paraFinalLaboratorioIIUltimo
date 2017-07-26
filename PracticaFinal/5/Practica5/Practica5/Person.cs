using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica5
{
    class Person
    {

        protected string name;
        protected int age;
        protected int dni;


        public Person(string name, int age, int dni)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
        }

        /*  metodo simple. */
        public string toString()
        {
            return "Objeto Persona: >>\n nombre: " + this.name + " | dni: " + this.dni + " | edad: " + this.age;
        }

        /*  metodo virtual para sobreescritura. */
        /*  metodo virtual siempre debe ser publico.*/
        public virtual void myName()
        {
            Console.WriteLine("Nombre de la PERSONA: " + this.name);
        }

    }
}
