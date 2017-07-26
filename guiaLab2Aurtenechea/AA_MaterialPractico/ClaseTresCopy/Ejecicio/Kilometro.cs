using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Kilometro
    {
        private int _cantidad;


        private Kilometro(int cantidad) {
            this._cantidad = cantidad;
        }


        public static Kilometro operator +(Kilometro miKm, int valor)
        {
             //tiempo en la firma es el valor de retorno
            miKm._cantidad += valor; 
            return miKm;
        }

        public static Kilometro operator +(Kilometro miKm, Kilometro miKm2)
         {
             //tiempo en la firma es el valor de retorno

             miKm._cantidad = miKm._cantidad + miKm2._cantidad;
             return miKm;
         }


        public static Kilometro operator -(Kilometro miKm, int valor)
         {
             //tiempo en la firma es el valor de retorno
             miKm._cantidad -= valor;
             return miKm;
         }

        public static Kilometro operator -(Kilometro miKm, Kilometro miKm2)
         {
             //tiempo en la firma es el valor de retorno
             miKm._cantidad -= miKm2._cantidad;
             return miKm;
         }
        
         public static bool operator ==(Kilometro miKm, int valor)
         {
             //tiempo en la firma es el valor de retorno
             if (miKm._cantidad == valor)
                return true;
                return false;
         }

        public static bool operator ==(Kilometro miKm, Kilometro miKm2)
         {
             //tiempo en la firma es el valor de retorno
             if (miKm._cantidad == miKm2._cantidad)
                return true;
                return false;
         }


        public static bool operator !=(Kilometro miKm, int valor)
        {
            //tiempo en la firma es el valor de retorno
            if (miKm._cantidad != valor)
                return true;
                return false;
        }

        public static bool operator !=(Kilometro miKm, Kilometro miKm2)
        {
            //tiempo en la firma es el valor de retorno
            if (miKm._cantidad != miKm2._cantidad)
                return true;
                return false;
        }

        public static implicit operator Kilometro(int numero)
        {
            return new Kilometro(numero);
        }

        public static explicit operator int(Kilometro km)
        {
            return km._cantidad;
        }


        public static bool operator >  (Kilometro km1, Kilometro km2)
        {
            return (int)km1  > (int)km2;
        }

        public static bool operator < (Kilometro km1, Kilometro km2)
        {
            return !(km1 > km2);
        }



        public static bool operator >(Kilometro km1, int num)
        {
            return (int)km1 > num;
        }

        public static bool operator <(Kilometro km1, int num)
        {
            return !(km1 > num);
        }

    }
}
