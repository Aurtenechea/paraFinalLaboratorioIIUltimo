using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Deposito<T> : IEnumerable<T> // este para sobreescribir un metodo de foreach
    {
        public List<T> lsProductos;
        public int cantidadMax;


       #region constructores
        public Deposito(int cantidadMax)
        {
            this.cantidadMax = cantidadMax;
            this.lsProductos = new List<T>();
        }
        #endregion 

        #region metodos
        public bool Agregar(T algo)
        {
            return this + algo;
            // como sobrecargamos el operador + no es necesario el codigo aca dentro.
        }
        public bool NoHayLugar()
        {
            return this.cantidadMax == this.lsProductos.Count;
            //no puede ser mayor
        }
        public bool ExisteElElemento(T algo)
        {
            foreach (T item in this.lsProductos)
            {
                if (item.Equals(algo))
                    return true;
            }
            return false;
        }

        

        #endregion
       
       #region operadores
        public static bool operator + (Deposito<T> dep, T prod)
        {
            if (!dep.NoHayLugar() && !dep.ExisteElElemento(prod))
            {
                dep.lsProductos.Add(prod);
                return true;
            }
            return false;
        }
        #endregion






        public IEnumerator<T> GetEnumerator() // implementar este
        {
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
