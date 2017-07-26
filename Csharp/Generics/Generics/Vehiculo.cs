using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Vehiculo
    {
        public string marca;
        public string color;
        public string patente;

        public Vehiculo(string marca, string color, string patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;

        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Vehiculo)obj)
                    bandera = true;
            }
            catch (Exception)
            {
                Console.WriteLine("No estan pasando un tipo Vehiculo en Equals de Vehiculo ");
            }
            return bandera;
        }

        public static bool operator ==(Vehiculo prod1, Vehiculo prod2)
        {
            if (prod1.patente == prod2.patente)
                return true;
            return false;
        }

        public static bool operator !=(Vehiculo prod1, Vehiculo prod2)
        {
            return !(prod1 == prod2);
        }

    }
}
