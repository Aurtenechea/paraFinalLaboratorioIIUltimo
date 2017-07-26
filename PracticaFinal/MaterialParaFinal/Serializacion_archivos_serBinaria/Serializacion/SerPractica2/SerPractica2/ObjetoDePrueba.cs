using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerPractica2
{
    /*  necesario para serializacion binaria. Asi como el constructor por defecto. 
     * No hace falta que sea publica la clase ni los atributos.*/
    [Serializable]
    public class ObjetoDePrueba
    {
        private int _value;

        public int Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public ObjetoDePrueba() { }



    }
}
