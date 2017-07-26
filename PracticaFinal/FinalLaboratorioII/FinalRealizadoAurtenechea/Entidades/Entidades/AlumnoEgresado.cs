using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    namespace Inicio
    {

        public class AlumnoEgresado : Alumno
        {
            float promedio;
            short promocion;

            public AlumnoEgresado(Alumno a, float promedio, short promocion)
                : base(((Persona)a), a.legajo, a.nivel)
            {
                this.promedio = promedio;
                this.promocion = promocion;
            }
      


        }
    }
}
