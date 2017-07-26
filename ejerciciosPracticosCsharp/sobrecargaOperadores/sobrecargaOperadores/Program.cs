using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            // para poder parsear un objeto a otro tipo existe la sobrecarga de operadores.
            //int num = (int)  new Objeto1();

            Objeto1 obj1 = new Objeto1(); //no existe el modificador public dentro del main(o eso creo)
           
            Objeto2 obj2 = new Objeto2();

            Objeto1 obj3 = obj1 + obj2;  // la sobrecarga de este operador ya devuelve un nuevo objeto por lo cual no necesito castearlo.
      
            Objeto1 obj4 = obj1 + 1;

        }
    }
}
