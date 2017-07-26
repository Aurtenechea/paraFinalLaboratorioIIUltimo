using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica19
{
    public abstract class ClasePadre
    {
        protected  abstract void metodoAbstractoDeInstancia();
        public abstract void metodoAbstractoEstatico();
        public void metodoNoAbstractoDeInstancia() { }
        public void metodoNoAbstractoEstatico() { }

        /*  se pueden declarar metodos virtuales en clases abstractas. */
        public virtual void metodoVirtual(){}
        
    }
}
