using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica4
{
    class Person
    {

        protected string name;
        protected int age;
        protected double dni;


        public Person(string name, int age, double dni)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
        }

        public string toString()
        {
            return "Objeto Persona: >>\n nombre: " + this.name + " | dni: " + this.dni + " | edad: " + this.age;
        }

        /*  sin usar los tipos virtual y override el compilador lanza un warning de que 
           se esta ocultando un metodo en la herencia. Hay que usar new si realmente se 
           quiere ocultar. */
        public void birthday()
        {
            Console.WriteLine("Cumpleanios de la PERSONA: " + this.name);
            this.age++;
        }

        /*  metodo virtual siempre debe ser publico.*/
        public virtual void myName()
        {
            Console.WriteLine("Nombre de la PERSONA: " + this.name);
        }

        /*  version estatica. */
        public static void dni_o_cuil(Person p){
            double result;
            if (p is Employee)
            {
                result = double.Parse("20" + p.dni.ToString() + "6");
            }
            else {
                result = p.dni;
            }
            Console.WriteLine(result);
        }

        /*  version de instancia. */
        public void dni_o_cuil()
        {
            double result;
            if (this is Employee)
            {
                result = double.Parse("20" + this.dni.ToString() + "6");
            }
            else
            {
                result = this.dni;
            }
            Console.WriteLine(result);
        }

        




        /*  CASO PARTICULAR. */
        public virtual string getDni(){
            return this.dni.ToString();
        }
    }
}
