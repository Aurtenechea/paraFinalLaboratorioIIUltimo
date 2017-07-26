using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public class ImplementaInterface : IDerivada
    {
        /*  NO LLEVA PUBLIC */
        /*  metodo explicto */
        void IUno.imprimoX()
        {
            Console.WriteLine("IUno XXXXXXXXXXXXXXX");
        }
        void IDos.imprimoX()
        {
            Console.WriteLine("IDos XXXXXXXXXXXXXXX");
        }


        // LLEVAN PUBLIC EN LA IMPLEMENTACION. 
        
        /*  metodo implicito. */
        public void imprimoX()
        {
            if(this.onImprimoXMetodEjecuted != null)
                this.onImprimoXMetodEjecuted(this, null);
            Console.WriteLine("XXXXXXXXXXXXXXX");
        }

        /*  propiedad */
        public string clave { get; set; }

        /*  indizadores */
        public string this[int index] 
        {
            get {
                if (index == 0)
                    return "blanco";
                else
                    return "negro";
            }
            set { }
        }

        /*  evento */
        public event EventHandler onImprimoXMetodEjecuted;
        /*  se podria definir manualmente add y remove. */
    }
}
