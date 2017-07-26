using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19._2
{
    class ClaseDos
    {
        private int numero;

        /*  propiedad definida automaticamente, es decir sin body. */
        //public int Numero
        //{
        //    get;
        //    set;
        //}

        /*  las propiedades pueden ser vituales y pueden no tener body. 
            en este caso, debe ser get y set para que funcione la implementacion
            automatica. */
        public virtual int Numero
        {
            get;
            set;
        }
    }
}
