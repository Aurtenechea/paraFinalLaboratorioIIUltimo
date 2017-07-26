using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    public delegate void miDelegado();

    class CualquierClase
    {
        private event miDelegado evento;
        

        /* cuando se declara un evento es como declarar una propiedad.
         * si se declara como publica y sin cuerpo es como una propiedad sin cuerpo.
         * Es decir se auto generan el get y el set. Aca igual. Se declara un evento
         * de forma publica y se tiene el add remove de forma automatica. 
         * Pero se pueden implementar a gusto tambien. */
        public event miDelegado Evento
        {
            add 
            {
                Console.WriteLine("se registra un metodo al evento. nombre: " + value.ToString());
                evento += value;
            }
            remove
            {
                Console.WriteLine("se elimina un metodo del evento. nombre: " + value.ToString());
                evento -= value;
            }
        }

        public void miEjecucionDisparaElEvento() 
        {
            this.evento();
        }
        
    }
}
