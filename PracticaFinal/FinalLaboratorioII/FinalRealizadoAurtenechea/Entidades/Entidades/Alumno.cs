using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    namespace Inicio
    {

        public enum ENivelDeEstudio
        {
            Primaria, Secundaria, Terciaria, Universitaria
        }

        public class Alumno : Persona
        {
            public short legajo;
            public ENivelDeEstudio nivel;


            public Alumno(Persona p, short legajo, ENivelDeEstudio nivel)
                : base(p.nombre, p.apellido, p.raza, p.edad)
            {
                this.legajo = legajo;
                this.nivel = nivel;
            }



        }

    }

}
