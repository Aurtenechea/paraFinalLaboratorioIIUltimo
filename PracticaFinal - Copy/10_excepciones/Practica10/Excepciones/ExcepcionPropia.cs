using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ExcepcionPropia : Exception
    {
        public ExcepcionPropia(Exception e)
            :base("Descripcion de ExcepcionPropia", e)
        {
            
        }

    }
}
