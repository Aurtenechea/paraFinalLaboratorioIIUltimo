using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    public class GrupoPersonas
    {
        private List<Persona> grupo;

        public GrupoPersonas()
        { 
            this.grupo = new List<Persona>();
        }

        public static GrupoPersonas operator +(GrupoPersonas g, Persona p)
        {
            g.grupo.Add(p);
            return g;
        }

        public static GrupoPersonas operator -(GrupoPersonas g, Persona p)
        {
            int index = -1;
            for (int i = 0; i < g.grupo.Count; i++)
            {
                if (g.grupo[i].nombre == p.nombre)
                {
                    index = i;
                    break;
                }
            }
            if( index != -1)
                g.grupo.RemoveAt(index);
            
            return g;
        }
    }

    public class Persona 
    {
        public string nombre;

        public Persona(string n)
        {
            this.nombre = n;
        }

        //public static explicit operator Persona(string n)
        //{
        //    /*  uso el implicito dentro del explicito. */
        //    Persona p = n;
        //    return p;
        //}

        /*  si existe solo el implicit, este funciona de forma implicit o explicit. */
        public static implicit operator Persona(string n)
        {
            return new Persona(n);
        }



    }


}
