using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Tiempo
    {

        private int _cantidad;

        private Tiempo()
        { }

        private Tiempo(int cantidad) {
            this._cantidad = cantidad;
        }

        
        //public static Tiempo sumar( Tiempo tiempoAux, int valor) 
        //{
        //    tiempoAux.cantidad = tiempoAux.cantidad + valor;
        //    return tiempoAux;


        //    // y para usarlo:
        //    //tiempoAux t1 = new Tiempo();
        //    //tiempoAux result = tiempoAux.sumar(t1, 10);
        //}

        //public static Tiempo operator + (Tiempo tiempoAux, int valor)
        //{
        //    tiempoAux.cantidad = tiempoAux.cantidad + valor;
        //    return tiempoAux;

        //    // y para usarlo:
        //    //tiempoAux t1 = new Tiempo();
        //    //tiempo = tiempo + 10;
        //}
        

        //sobrecarga de operadores
         public static Tiempo operator + (Tiempo miTiempo , int valor)
        {
             //tiempo en la firma es el valor de retorno
            miTiempo._cantidad += valor; 
            return miTiempo;
        }

         public static Tiempo operator +(Tiempo miTiempo, Tiempo miTiempo2)
         {
             //tiempo en la firma es el valor de retorno

             miTiempo._cantidad = miTiempo._cantidad + miTiempo2._cantidad;
             return miTiempo;
         }


         public static Tiempo operator -(Tiempo miTiempo, int valor)
         {
             //tiempo en la firma es el valor de retorno
             miTiempo._cantidad -= valor;
             return miTiempo;
         }

         public static Tiempo operator -(Tiempo miTiempo, Tiempo miTiempo2)
         {
             //tiempo en la firma es el valor de retorno
             miTiempo._cantidad -= miTiempo2._cantidad;
             return miTiempo;
         }




         public static bool operator == (Tiempo miTiempo, int valor)
         {
             //tiempo en la firma es el valor de retorno
             if (miTiempo._cantidad == valor)
                return true;
                return false;
         }

         public static bool operator ==(Tiempo miTiempo, Tiempo miTiempo2)
         {
             //tiempo en la firma es el valor de retorno
             if (miTiempo._cantidad == miTiempo2._cantidad)
                return true;
                return false;
         }


         public static bool operator !=(Tiempo miTiempo, int valor)
         {
             //tiempo en la firma es el valor de retorno
             if (miTiempo._cantidad != valor)
                 return true;
             return false;
         }

         public static bool operator !=(Tiempo miTiempo, Tiempo miTiempo2)
         {
             //tiempo en la firma es el valor de retorno
             if (miTiempo._cantidad != miTiempo2._cantidad)
                 return true;
             return false;
         }


         public static implicit operator Tiempo(int numero)
         { 
            return new Tiempo(numero);
            // y para usarlo...
            // de forma implicita:
            // Tiempo reloj = 33;
            // de forma explicita:
            // Tiempo reloj = (Tiempo) 33;
            // si se define el metodo de forma explicita funciona para las dos formas, 
            // sino, si es explicita funciona solo de forma explicita.

         }

        public static explicit operator int (Tiempo tiempo)
        {
            return tiempo._cantidad;
        }



        public static bool operator >(Tiempo tiempo1, Tiempo tiempo2)
        {
            return (int)tiempo1 > (int)tiempo2;
        }

        public static bool operator <(Tiempo tiempo1, Tiempo tiempo2)
        {
            return !(tiempo1 > tiempo2);
        }



        public static bool operator >(Tiempo tiempo1, int num)
        {
            return (int)tiempo1 > num;
        }

        public static bool operator <(Tiempo tiempo1, int num)
        {
            return !(tiempo1 > num);
        }
    }
}
