using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica12
{
    class GrupoPersonas
    {

        private int cantidad_personas;
        private List<Persona> lsPersona; 


        public Persona this[int i]
        {
            get { return this.lsPersona[i]; }
            set { this.lsPersona[i] = value; } 
        }

        int CantidadPersonas {
            get { return this.cantidad_personas;  }
            set { this.cantidad_personas = value; }
        }


        public GrupoPersonas(int c) {
            this.lsPersona = new List<Persona>();
            this.CantidadPersonas = c;
            for (int i = 0; i < this.CantidadPersonas ; i++)
            {
                this.lsPersona.Add(new Persona());
            }
        }


        public static implicit operator GrupoPersonas(int c)
        {
            return new GrupoPersonas(c);
        }

    }
}
