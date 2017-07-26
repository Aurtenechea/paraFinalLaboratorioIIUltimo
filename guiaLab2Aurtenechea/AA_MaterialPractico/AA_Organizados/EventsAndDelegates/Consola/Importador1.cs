using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola
{
    class Importador1
    {
        public void OnArribaUnBarco(object sender, BarcoEventArgs e) 
        {   
            
            //v1
            //// sender dice quien lo envio. si es el puerto, si es ...
            //Console.WriteLine("Soy importador me acaban de avisar que llego un barco a la localidad de: " +  ((Puerto)sender).localidad);
            //Console.WriteLine("Info del barco desde importador: " + ((Puerto)sender).contenidoDelUltimoBarco);

            //v2
            Console.WriteLine("Soy importador me acaban de avisar que llego un barco a la localidad de: " +  ((Puerto)sender).localidad);            
            Console.WriteLine("Soy importador: " +  e.contenido);
         }


    }
}
