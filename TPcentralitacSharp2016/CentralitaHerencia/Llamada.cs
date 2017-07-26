using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Llamada
    {
        protected float _duracion;
        protected string _nroDestino;
        protected string _nroOrigen;

        public float Duracion 
        {
            get 
            {
                return _duracion;    
            }
        }
        public string NroDestino
        { 
            get 
            {
                return _nroDestino;
            }
        }
        public string NroOrigen
        {
            get 
            {
                return _nroOrigen;
            }
        }

        public Llamada(string origen, string destino, float duracion)
        {
            this._nroOrigen = origen;
            this._nroDestino = destino;
            this._duracion = duracion;
        }

        public void Mostrar()
        { 
            //Utiliza stringBuilder
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Llamada de " + this.NroOrigen + " a " + this.NroDestino + ".");
            sb.AppendLine("Duracion: " + this.Duracion + " segundos.");
            Console.Write(sb);
        }

        public static int ordenarPorDuracion(Llamada llamadaUno, Llamada llamadaDos)
        {
            // sera utilizado por el metodo sort de la lista generica en centralita.
            return 0;
        }

    }
}
