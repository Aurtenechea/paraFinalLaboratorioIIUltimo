using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces2
{
    public interface IDos
    {

        void imprimoX();
        
        /*  propiedad */
        string clave { get; set; }

        /*  indizadores */
        string this[int index]
        {
            get;
            set;
        }

        /*  evento */
        event EventHandler onImprimoXMetodEjecuted;
    }
}
