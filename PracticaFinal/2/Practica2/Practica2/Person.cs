using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
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

        public string toString(){
            return "Objeto Persona: >>\n nombre: " + this.name + " | dni: " + this.dni + " | edad: " + this.age;
        }
        
        /*  sin usar los tipos virtual y override el compilador lanza un warning de que 
           se esta ocultando un metodo en la herencia. Hay que usar new si realmente se 
           quiere ocultar. */
        public void birthday(){
            Console.WriteLine("Cumpleanios de la PERSONA: " + this.name);
            this.age++;
        }

        /*  metodo virtual siempre debe ser publico.*/
        public virtual void myName(){
            Console.WriteLine("Nombre de la PERSONA: " + this.name);
        }

    }
}
