using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    public class Puerto
    {


        public delegate void informarDelegate(object o, BarcoEventArgs e);
        public event informarDelegate LLegoUnBarco;

        public string localidad;
        public string contenidoDelUltimoBarco;

        public Puerto(string loc)
        {
            this.localidad = loc;
        }



        public void OnArribaUnBarco(string contenido) 
        {
            
            //v1
            //this.contenidoDelUltimoBarco = contenido;
            //if (LLegoUnBarco != null)
            //    LLegoUnBarco(this, EventArgs.Empty); 



            //v2
            if (LLegoUnBarco != null)
            {
                BarcoEventArgs var = new BarcoEventArgs();
                var.contenido = contenido;
                LLegoUnBarco(this, var); 
            }
        
        
        } 
    }
}
