using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Avion : Vehiculo, IAFIP, IARBA  
    {
        /*
         * que implenente las dos interfaces quiere decir que va a tener que haber implementacion para todos los metodos de cada interface.
         * 
         */



        protected double velocidadMaxima;

        public Avion(double precio, double velMax) : base(precio)
        {
            this.velocidadMaxima = velMax;
        }

        double IAFIP.CalcularImpuesto() // implementacion explicita.
        {
            /*
             * En una implementacion explicita no se puede poner el modificador de acceso public. 
             * Y las implementaciones de las interfaces por defecto son privadas.
             * Por lo tanto desde un objeto de tipo Privado no se va a tener acceso a este metodo.
             * esta declaracion del metodo no es confundible ya que se sabe que se trata de esa sola interface.
             * 
             */
            return (this._precio * 0.33);
        }

        //public double CalcularImpuesto() // implementacion explicita.
        //{
        //    /*
        //     * Esta forma podria ser para cualquiera de las dos interfaces. Como se declara para IAFIP una de forma explicita.. 
        //     * se puede decir que IAFIP nunca va a entrar en esta implementacion. y esta es para IARBA.
        //     * 
        //     */
        //    return (this._precio * 0.27);
        //}

        double IARBA.CalcularImpuesto() // implementacion explicita.
        {
            return (this._precio * 0.27);
        }

        public override void MostrarPrecio()
        {
            Console.WriteLine(this._precio);
        }
    }
}
