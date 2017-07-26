using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Persona
    {
        public string nombre;
        public int dni;


        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Persona)obj)
                    bandera = true;
            }
            catch (Exception)
            {
                Console.WriteLine("No estan pasando un tipo Persona en Equals de Persona ");
            }
            return bandera;
        }

        public static bool operator ==(Persona prod1, Persona prod2)
        {
            if (prod1.dni == prod2.dni)
                return true;
            return false;
        }

        public static bool operator !=(Persona prod1, Persona prod2)
        {
            return !(prod1 == prod2);
        }

    }
}
