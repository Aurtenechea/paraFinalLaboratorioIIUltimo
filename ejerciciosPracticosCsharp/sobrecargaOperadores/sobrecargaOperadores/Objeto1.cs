using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaOperadores
{
    class Objeto1
    {
        public int cantidad;
        public string descripcion;
        public static int count;

        public Objeto1(){
            this.cantidad = -1;
            this.descripcion = "blank";
            //Objeto1.count++;
        }

        public Objeto1(string var):this()
        {
            this.descripcion = var;
            //Objeto1.count++;
        }

        static Objeto1()
        {  // un constructor estatico no puede ser publico sino se podria hacer Objeto1.Objeto1() cosa que no queda muy bien...
           // en realidad un constructor estatico no acepta modificador de acceso.
            Objeto1.count = 0;
        }


        // sobrecarga de operadores:
        public static Objeto1 operator +(Objeto1 uno, Objeto2 dos)
        //[access mod] [static mod] [return] [operator] ([param1], [param2])
        //  la subrecarga de operadores siempre es static y punto.
        {
            string varStr = uno.descripcion + dos.nombre;
            return new Objeto1(varStr);            
        }

        public static Objeto1 operator +(Objeto1 obj, int num)
        {   // no se puede usar public o private dentro de un metodo.
            Objeto1 newObj = new Objeto1();
            newObj.cantidad += num;
            return newObj;
        }

    }
}
