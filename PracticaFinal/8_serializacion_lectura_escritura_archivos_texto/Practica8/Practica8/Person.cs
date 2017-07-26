using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    public class Person
    {
        public string name;

        public Person(string name) {
            this.name = name;
        }


        /*  Si la clase no lo tiene, para serializar debo crear un constructor por defecto. */
        public Person() { }



    }
}
