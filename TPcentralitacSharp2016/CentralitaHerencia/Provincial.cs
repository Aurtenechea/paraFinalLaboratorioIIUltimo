using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Provincial:Llamada
    {
        protected Franja _franjaHoraria;

        public float CostoLlamada
        {
            get
            {
                return this.calcularCosto();
            }
        }

        public Provincial(Franja miFranja, Llamada unaLlamada)
            :base (unaLlamada.NroOrigen, unaLlamada.NroDestino,unaLlamada.Duracion)
        {
            this._franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : base(origen, destino, duracion)
        {
            this._franjaHoraria = miFranja;
        }
        
        public float calcularCosto()
        {
            return ((this.CostoPorMinuto() / 60) * this._duracion); // el precio por minuto /60 me da el precio del segundo.
        }

        public float CostoPorMinuto()
        {
            float r = 0;
            switch ((int)this._franjaHoraria) // ubiese sido mas facil con constantes en ves de enumerados. 
            {
                case 0:
                    r = 0.99f;
                    break;
                case 1:
                    r = 1.25f;
                    break;
                case 2:
                    r = 0.66f;
                    break;
            }
            return r;
        }

        public void Mostrar()
        {
            base.Mostrar(); // funciono :D
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Franja horaria " + this._franjaHoraria + ".");
            sb.AppendLine("Costo por minuto: " + this.CostoPorMinuto());
            sb.AppendLine("Costo de llamada: " + this.CostoLlamada);
            sb.AppendLine("---------------------------------------------------------------------");
            Console.Write(sb);
        }

    
    }
}
