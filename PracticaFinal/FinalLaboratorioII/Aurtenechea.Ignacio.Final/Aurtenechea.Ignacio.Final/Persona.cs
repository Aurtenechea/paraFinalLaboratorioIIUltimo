using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    namespace Inicio
    {


        public class Persona : Humano
        {
            public string apellido;
            public sbyte edad;

            public Persona(string nombre, string apellido, ERaza raza, sbyte edad)
                : base(nombre, raza)
            {
                this.apellido = apellido;
                this.edad = edad;
            }

        }

    }
}
