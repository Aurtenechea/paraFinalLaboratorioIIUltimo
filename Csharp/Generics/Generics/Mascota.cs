using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Mascota)obj)
                    bandera = true;
            }
            catch (Exception)
            {
                Console.WriteLine("No estan pasando un tipo Mascota en Equals de Mascota ");
            }
            return bandera;
        }

        public static bool operator ==(Mascota prod1, Mascota prod2)
        {
            if (prod1.nombre == prod2.nombre && prod1.raza == prod2.raza)
                return true;
            return false;
        }

        public static bool operator !=(Mascota prod1, Mascota prod2)
        {
            return !(prod1 == prod2);
        }


    }
}
