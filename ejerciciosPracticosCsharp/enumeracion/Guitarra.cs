using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeracion
{
    class Guitarra  //una clase Guitarra
    {

        public eGuitarras tipo;  // variable que va a contener alguno de los valores definido en la enumeracion eGuitarras
        
        public Guitarra(){
            // recibe un entero que lo pasa a uno de los valores pre-definidos.
            tipo = (eGuitarras) 0;
        }

        public void setTipo(int num) {
            this.tipo = (eGuitarras) num;
        }

        
    }
}
