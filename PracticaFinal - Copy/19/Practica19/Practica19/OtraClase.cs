using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19
{
    public sealed class OtraClase : ClasePadre
    {
        /*  una clase sellada que hereda de una clase abstracta tiene que 
            implementar todos sus metodos. 
            los metodos que se implementan deben tener el mismo modificador 
            de acceso: public o protected (abstract no puede ir en private al igual que virtual).
         */
        protected override void metodoAbstractoDeInstancia() { }
        public override void metodoAbstractoEstatico() { }

        public static void Main()
        {
            Console.WriteLine("wee");
            Console.ReadKey();
        }
    }
}
