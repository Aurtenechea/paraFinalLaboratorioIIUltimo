using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3
{
    public class Platano : Fruta 
    {
        public string paisOrigen;

        public override bool TieneCarozo 
        {
            get{ return false; }
        }
        public string Tipo
        {
            get { return "Platano"; }
        }

        // serializar
        public Platano() { }

        public Platano(float peso, ConsoleColor color, string pais) 
            :base(peso, color)
        {
            this.paisOrigen = pais; 
        }

        protected override string FrutaToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.FrutaToString());
            sb.AppendLine("\tPais: " + this.paisOrigen);
            return sb.ToString();
        }

        new public string ToString()
        {
            return this.FrutaToString();
        }
    }
}
