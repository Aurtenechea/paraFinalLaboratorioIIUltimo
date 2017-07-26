using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate void CuentaDelegado(float dineroQueSaco);
    // delegado. Se define igual que un abstract.

    public class Cuenta
    {
        public float saldo;


        public event CuentaDelegado SaldoNegativo;
        // nombre del evento el que aparece con un rayo. Como si fuese la variable que almacena la funcion.
        // quiere decir, este va a ser el evento que se va a disparar.. y como guarda funciones a disparar (si es que alguien guardo.) 
        // cuando se dispare el evento, se ejecutaran las funciones.


        public Cuenta() 
        {
            this.saldo = 0;
        }
        
        public void SacarDinero(float dineroQuePide)
        {
            if (dineroQuePide > this.saldo)
            {
                this.SaldoNegativo(dineroQuePide);
                /*
                 * 
                 * si estuvieramos en aplicacion de consola console write
                 * 
                 * si estuvieramos en windowsForm MessageBox
                 * 
                 * si estuvieramos en una pagina web alert
                 *
                 */
            }
        }
    }
}
