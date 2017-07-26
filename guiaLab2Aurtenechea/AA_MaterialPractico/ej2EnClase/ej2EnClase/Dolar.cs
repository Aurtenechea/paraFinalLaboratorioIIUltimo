using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ej2EnClase
{
    class Dolar
    {
        private float _valor;

        public Dolar() //   constructores no devuelven valores
        {
            this._valor = 0;
        }

         public Dolar(float num) //   constructores no devuelven valores
        {
            this._valor = num;
        }

        public static implicit operator Dolar (float num)
        {
            return new Dolar(num);
        }

        public static Dolar operator +(Dolar unD, Pesos unP)
        {
            return  unD._valor + ( (float)unP / 15); 
            // _valor de unD es privado pero como estoy dentro de la clase lo puedo usar, no asi con unP._valor
        }

        public static explicit operator float(Dolar unD)
        {
            return unD._valor;
        }

    }
}
