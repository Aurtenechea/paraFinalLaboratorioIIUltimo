using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoAparte
{
    public class Separado
    {
        public int valor;
        private List<int> valores;

        public Separado(){
            this.valores = new List<int>();
        }

        /*  Los indizadores llevan nombre this. No tiene sentido que 
            tengan nombre porque se acceden por el operador [] a 
            travez del objeto. */
        public int this[int i] 
        {
            get
            {
                return this.valores[i];
            }
            set 
            {
                this.valores.Add(value);
            }
        }
        /*  Dos indizadores se diferencian por el tipo de indice. */
        public int this[string i] 
        {
            get
            {
                if(i == "cero")
                    return this.valores[0];
                else if (i == "uno" )
                    return this.valores[1];
                else
                    return this.valores[2];
            }
            set
            {
                this.valores.Add(value);
            }
        }

        /*  son iguales cuando su valor es igual. */
        public static bool operator ==(Separado s1, Separado s2)
        {
            return s1.valor == s2.valor;
        }
        public static bool operator !=(Separado s1, Separado s2)
        {
            return !(s1 == s2);
        }

    }
}
