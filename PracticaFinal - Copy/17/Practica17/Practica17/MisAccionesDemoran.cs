using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica17
{
    class MisAccionesDemoran
    {
        /*  declarar un delegado  es como declarar un tipo. No una variable.*/
        public delegate void Deleg();
        
        /*  El evento se usa para guardar referencias a funciones del tipo del delegado.
            El delegado establece el tipo de firma de metodo que se puede suscribir.
            El evento una vez que se dispara, se ejecutan todas las funciones. */
        public event Deleg onEnd;
        
        /*  para probar sin eventos. Aca si crea una variable de instancia, del tipo del 
            delegado. Es decir que en esta variable puedo guardar metodos con firmas que 
            sean exactas a la definida por el delegado. */
        private Deleg d;



        public void DemoroXEnTerminar()
        {
            Random r = new Random();
            System.Threading.Thread.Sleep(r.Next(1000, 20000));
            /*  disparo el evento. Esto dispara todas las funciones suscritas a el. */
            this.onEnd();
            
            /*  prueba delegado, disparo el deleg. Esto dispara todas las funciones suscritas a el. */
            this.d();
        }

        /*  tambien se podria hacer el atributo d publico y que se asignen las 
            funciones directamente desde el program. */
        public void suscripcionSinEventos(Deleg param){
            if (this.d == null)
                this.d = param;
            else
                this.d += param;
        }
    }
}
