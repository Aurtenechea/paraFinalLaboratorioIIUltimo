using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3
{
    public abstract class Person
    {
        protected string name;
        protected int age;
        protected int dni;

        /*  un constructor en la clase abstracta tiene sentido ya que se van a heredar los atributos
            de esta clase, y estos pueden ser inicializados a travez de la llamada a :base() en el constructor 
            de la clase hija. */
        public Person(string name, int age, int dni)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
        }

        public string toString()
        {
            return "Objeto Persona: >>\n nombre: " + this.name + " | dni: " + this.dni + " | edad: " + this.age;
        }

        /*  una clase abstracta puede tener metodos no abstractos. */
        public void birthday()
        {
            Console.WriteLine("Cumpleanios de la PERSONA: " + this.name);
            this.age++;
        }

        /*  todo metodo abstracto siempre es implicitamente virtual y todo metodo virtual debe ser publico.*/
        public abstract void myName();
    
    
    }
}
