using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica8
{
    public class Family
    {
        public List<Person> lsPerson;

        /*  Aca el constructor por defecto para serializar ya es parte de la clase. 
            No se crea especificamente para serializar. */
        public Family() {
            this.lsPerson = new List<Person>();
        }

        public string ToString() {
            return "La familia guardada tiene " + this.lsPerson.Count + " Personas.";
        }
    }
}
