using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Local: Llamada
    {
        protected float _costo;
        
        public float CostoLlamada
        {
            get 
            {
                return this.calcularCosto();
            }
        }

        public Local (Llamada unaLlamada, float costo)
            :base(unaLlamada.NroOrigen, unaLlamada.NroDestino, unaLlamada.Duracion)
        {
            // si no se deja explicito hay una invocacion implicita al constructor por defecto de la clase padre.
            this._costo = costo;
        }

        public Local (string origen, float duracion, string destino, float costo)
            :base(origen, destino, duracion)
        {
            // si no se deja explicito hay una invocacion implicita al constructor por defecto de la clase padre.
            this._costo = costo;
        }

        private float calcularCosto()
        {
            return ((this._costo / 60) * this._duracion); // el precio por minuto /60 me da el precio del segundo.
        }

        public void Mostrar()
        {
            base.Mostrar(); // funciono :D
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Costo por minuto: " + this._costo );
            sb.AppendLine("Costo de llamda: " + this.CostoLlamada);
            sb.AppendLine("---------------------------------------------------------------------");
            Console.Write(sb);
        }

        
    }
}
