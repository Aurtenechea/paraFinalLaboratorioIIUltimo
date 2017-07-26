using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public abstract class Vehiculo
    {
        public string Patente;

        public Vehiculo(string pat)
        {
            this.Patente = pat;
        }


        public override string ToString()
        {
            return this.Patente;
        }

        public virtual string mostrarDatos() 
        {
            // virtual indica que este metodo puede ser reescrito en clases hijas.  siempre que sea virtual va a ser public sino carece de sentido.
            //    ya que se estaria pidiendo la implementacion de un metodo al que no se tiene acceso.
            // si no se indica no puede ser sobreescrito
            // en la clase hija debe estar el modificador override 
            // en el metodo de la clase hija donde va override debe haber un metodo virtual con ese nombre en la padre sino da error.
            StringBuilder sb = new StringBuilder();
            sb.Append("Vehiculo ");
            sb.AppendLine(this.Patente);
            return sb.ToString();
        }

        public abstract float CalcularCosto();
        // todo metodo abstracto es implicitamente virtual. Sino no tendria sentido...
        //     Se pide obligatoriamente que se sobreescriba pero no se permite sobreescribirlo
        // tambien es posible marcar un método como abstract y override a la vez, lo que convertiría al
        // método en abstracto para sus clases hijas y forzaría a que éstas lo tuviesen que
        // reimplementar si no se quisiese que fuesen clases abstractas. 
    }
}
