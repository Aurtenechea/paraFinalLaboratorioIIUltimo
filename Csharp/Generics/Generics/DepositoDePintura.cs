using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class DepositoDePintura
    {
        public List<Producto> lsProductos;
        public int cantidadMax;



        #region constructores
        public DepositoDePintura(int cantidadMax)
        {
            this.cantidadMax = cantidadMax;
            this.lsProductos = new List<Producto>();
        }
        #endregion 

        #region metodos
        public bool Agregar(Producto algo)
        {
            return this + algo;
            // como sobrecargamos el operador + no es necesario el codigo aca dentro.
        }
        public bool NoHayLugar()
        {
            return this.cantidadMax == this.lsProductos.Count;
            //no puede ser mayor
        }
        public bool ExisteElElemento(Producto algo)
        {
            foreach (Producto item in this.lsProductos)
            {
                if (item == algo)
                    return true;
            }
            return false;
        }

        #endregion
       
       #region operadores
        public static bool operator + (DepositoDePintura dep, Producto prod)
        {
            if (!dep.NoHayLugar() && !dep.ExisteElElemento(prod))
            {
                dep.lsProductos.Add(prod);
                return true;
            }
            return false;
        }
        #endregion

    }
}
