using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6
{
    class Person
    {

        protected string name;
        protected int age;
        protected int dni;
        public static int partos;
        
        /*  PROPIEDADES. */
        public string apellido { get; set; }
        private string sexo;       
        public string Sexo{ get {
                                    return this.sexo;
                                }
                            set {
                                    this.sexo = value;
                                }
                            }



        public Person(string name, int age, int dni)
        {
            this.name = name;
            this.age = age;
            this.dni = dni;
            Person.partos ++;
        }
        static Person() {
            Console.WriteLine("ejecucion del constructor statico de Person.");
            Person.partos = 0;
        }

        public string toString()
        {
            return "Objeto Persona: >>\n nombre: " + this.name + " | dni: " + this.dni + " | edad: " + this.age;
        }

        public static void func(){
            Console.WriteLine("metodo func ");
        }
    }
}
