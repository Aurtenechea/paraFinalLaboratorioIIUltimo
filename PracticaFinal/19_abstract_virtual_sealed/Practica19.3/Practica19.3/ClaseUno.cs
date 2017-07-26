using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19._3
{
    class ClaseUno :IUno
    {
        public static int at1;
        public int at2;
        private int at3;

        public ClaseUno() {
            /*  se puede acceder a attributos estaticos. 
                Desde un constructor de instancia. */
            at1 = 0;
        }

        static ClaseUno() { 
            /*  no se puede acceder atributos de instancia desde un constructor 
                estatico. */
        }

        public static void mEstatico(){}


        public int MiPropiedad{
            get;
            set;
        }


        public void miFuncion()
        {
            // naranja...
        }
        void IUno.miFuncion()
        {
            // naranja...
        }

        
    }
}
