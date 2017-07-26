using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial3
{
    public abstract class Fruta
    {

        private float _peso;
        private ConsoleColor _color;


        public abstract bool TieneCarozo { get; }

        public Fruta(float peso, ConsoleColor color)
        { 
            this._peso = peso;
            this._color = color;
        }

        protected virtual string FrutaToString() 
        { 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("FRUTA:");
            sb.AppendLine("\tPeso: " + this._peso);
            sb.AppendLine("\tcolor: " + this._color);
            return sb.ToString();
        }

        //serializar
        public Fruta() { }
    }
}
