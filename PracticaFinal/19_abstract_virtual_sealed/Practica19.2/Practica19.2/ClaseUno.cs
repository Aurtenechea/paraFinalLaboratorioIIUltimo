using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19._2
{

    public abstract class ClaseUno
    {
        /*  no existen constructores abstractos */
        //public virtual ClaseUno() { }


        /*  se puede crear un constructor en una clase abstracta para que 
            este sea llamado en la clase hija desde :base() e inicializar sus 
            atributos */
        public ClaseUno() { }
        /*  tambien se puede crear un constructor estatico.
            Ademas los constructores estaticos no pueden llevar modificadores 
            de acceso. */
        static ClaseUno() { }
    }
}
