using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indizador
{
    class ClaseConLista
    {

        private string[] _nombres;

        public string this[int index]
        {
            get 
            {
                return this._nombres[index];

            }
            set 
            {
                this._nombres[index] = value;
            }
        }



        private ClaseConLista(int cant) 
        {
            this._nombres = new string[cant];
        }

        public static ClaseConLista getInstance(int cant)
        {
            return new ClaseConLista(cant);
        }

    }
}
