using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace miSerializacion
{
    
    public class Class1 
    {
        private string nombre;
        public int edad;
        public List<int> lsInt;

        public string Nombre2
        {
            get 
            {
                Console.WriteLine("pase por get");
                return this.nombre; 
            
            }
            set {
                Console.WriteLine("pase por set");
                this.nombre = value; 
            }
        }

        //public string Chota
        //{
        //    get { return "chupamela!"; }
        //    set { this.nombre = "chupamela!"; }

        //}

        public Class1()
        { 
            this.nombre="nacho";
            this.edad = 26;
            this.lsInt = new List<int>();
            lsInt.Add(1);
            lsInt.Add(2);
            lsInt.Add(3);

        }

        



    }
}
