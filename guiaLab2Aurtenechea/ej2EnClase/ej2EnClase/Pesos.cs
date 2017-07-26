using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2EnClase
{

    class Pesos
    {
        private float _valor;


        public Pesos() //   constructores no devuelven valores
        {
            this._valor = 0;
        }

         public Pesos(float num) //   constructores no devuelven valores
        {
            this._valor = num;
        }
        
        public static explicit operator Pesos(float num)
        {
            return new Pesos(num);
        }

        public static explicit operator float (Pesos unP)
        {
            return unP._valor;
        }


        public static Pesos operator + (Pesos unP, Dolar unD)
        {
            return (Pesos)unP._valor + ((float)unD * 15);
        }

    }
}
