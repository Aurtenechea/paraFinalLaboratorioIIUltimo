using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    public class Documento
    {
        public int numero;
        public string _fecha; // protected se ve dentro de la clase y dentro de todas sus herencias.
        // los protected solo se ven en los que son herencia directa
        
        public int _numeroDeControl; // private se ve solo dentro de esta clase. No en sus herencis.

        public Documento(int num, string fecha, int numCtrl) :this(num) //llama al otro
        {
            this._fecha = fecha;
            this._numeroDeControl = numCtrl;
        }

        public Documento(int num)
        {
               numero = num;
        }

        public void mostrar() 
        {
            Console.WriteLine(this.numero);
            
        }


    }
}
