using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaOperadores
{
    class Objeto2
    {
        public string nombre;
        public bool varBool;

        
        public Objeto2()
        {
            this.varBool = false;
            this.nombre = "blank";
        }

        static Objeto2()
        {  //un constructor estatico no puede ser publico sino se podria hacer Objeto1.Objeto1() cosa que no queda muy bien...

        }

    
    }
}
