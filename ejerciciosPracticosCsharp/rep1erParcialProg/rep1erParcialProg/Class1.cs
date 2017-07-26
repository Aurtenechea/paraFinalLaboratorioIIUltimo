using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rep1erParcialProg
{
    public class Class1
    {
        #region atributos

        protected string _name;
        private int _numeroDeSerie;
        public List<int> paresDeNumeros;
        private static int _countObj;

        #endregion

        #region propiedades

        public string Name
        {
            get
            {
                return this._name;
            }

            set 
            {
                this._name = value;     
            }
        }

        public int Numero
        {
            get
            {
                return this._numeroDeSerie;
            }

            set 
            {
                this._numeroDeSerie = value;
            }
        }

        #endregion

        #region constructores

        public Class1()
        {
            this._name = "blank";
            this._numeroDeSerie = -1;
            _countObj += 1;
            this.paresDeNumeros = new List<int>();
        }

        public Class1(int numSerie)
            : this()
        {
            this._numeroDeSerie = numSerie;
        }

        public Class1(int numSerie, string name)
            : this(numSerie)
        {
            this._name = name;
        }

        static Class1() //no existen constructores privados!! y en los staticos no va modificador de acceso.
        {
            _countObj = 0; // como este atributo es private no se va a poder modificar desde afuera.
        }


        #endregion

        #region metodos
        public void generadorParesValores()
        {
            Random rdm = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.paresDeNumeros.Add(rdm.Next(10, 99));
            }

            //return this.paresDeNumeros; 
        }

        public static int ordenarAsc(int num1, int num2)
        {
            return string.Compare(num1.ToString(), num2.ToString());
        }

        #endregion

        #region operadores
        public static implicit operator int(Class1 objC1) // implicit = implicit + explicit.
        {
            return objC1.Numero;
        }

        public static explicit operator string(Class1 objC1) // explicit = only explicit.
        {
            return objC1._name;
        }

        public static int operator +(Class1 objC1, int num)
        {
            return objC1.Numero + num;
        }

        #endregion

    }
}
