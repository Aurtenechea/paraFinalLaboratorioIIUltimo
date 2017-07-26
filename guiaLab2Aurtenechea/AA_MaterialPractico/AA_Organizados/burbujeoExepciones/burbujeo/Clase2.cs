using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace burbujeo
{
    public class Clase2
    {
        public Clase2()
        {

        }   
            public void Method()
            {
                try
                {
                    Clase1 miObjeto = new Clase1();
                }
                catch(Exception ex)
                {
                    throw new Exception("Exception desde la instancia", ex);
                }
            }
            
        


    }
}
