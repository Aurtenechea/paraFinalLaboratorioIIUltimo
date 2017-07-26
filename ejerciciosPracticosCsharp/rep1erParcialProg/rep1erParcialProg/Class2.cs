using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rep1erParcialProg
{
    public class Class2 : Class1 // Herencia!
    {
        private string _nuevoAtributo;
        private int[] intArray;

        public string NuevoAtributo
        {
            get
            {
                return this._nuevoAtributo;
            }
            set 
            {
                this._nuevoAtributo = value;
            }
        }

        public Class2(string unStr)
            : base()
        {
            this.NuevoAtributo = unStr;
            intArray = new int[10];
            
        }


        public void inicializarArray()
        {
            Random rdm = new Random();
            for (int i = 0; i < 10; i++)
            {
                this.intArray[i] = (rdm.Next(10, 99));
            }
        }

            





    }
}
