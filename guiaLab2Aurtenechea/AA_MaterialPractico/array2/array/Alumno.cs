using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    public class Alumno
    {

        public string nombre;
        public int legajo;

        public Alumno(string nombre, int legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
        }

        public static bool operator ==(Alumno alm1, Alumno alm2)
        {
            bool rtn = false;
            if (alm1.legajo == alm2.legajo)
                rtn = true;

            return rtn;
        }

        public static bool operator !=(Alumno alm1, Alumno alm2)
        {
            bool rtn = false;
            if (alm1.legajo != alm2.legajo)
                rtn = true;

            return rtn;
        }

        


    }
}
