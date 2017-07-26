using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejEnClase
{
    public class Producto
    {
        public float precio;



        public Producto()
        {
            precio = 0;
        }

        public Producto(int num)
        {
            precio = num;
        }

        public static implicit operator Producto (int num)
        {
            return new Producto(num);
        }

        public static implicit operator float(Producto p1)
        {
            return p1.precio;
        }

        public static int operator +(Producto p1, Producto p2)
        {
            return (int)p1 + (int)p2;
        }



    }
}
