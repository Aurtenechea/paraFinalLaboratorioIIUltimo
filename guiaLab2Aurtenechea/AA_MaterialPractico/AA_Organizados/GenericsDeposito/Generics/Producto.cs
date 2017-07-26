using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Producto
    {
        public int codigo;
        public string descripcion;
        public float precioDeVenta;

        #region constructores
        //public Producto(int cantidad, string descripcion, float precio)
        //{

        //}
        #endregion
         

        #region metodos
        public string toString()
        {
            return "Codigo: " + codigo + "\n" + "Descripcion: " + "\n" + descripcion + "\n" + "Precio de venta: " + precioDeVenta;
        }

        public override bool Equals(object obj)
        {
            bool bandera = false;
            try
            {
                if (this == (Producto)obj)
                    bandera=  true;
            }
            catch (Exception)
            {
                Console.WriteLine("No estan pasando un tipo Producto en Equals de Producto ");
            }
            return bandera;
        }

        #endregion

        #region operadores
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (prod1.codigo == prod2.codigo)
                return true;
            return false;
        }

        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return ! (prod1 == prod2);
        }
         
         #endregion


    }
}
