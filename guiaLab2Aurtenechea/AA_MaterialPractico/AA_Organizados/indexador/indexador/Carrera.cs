using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Carrera
    {


        public List<Auto> lsAutos;
        public string autodromo;

        public Carrera(string autodromo)
        {
            this.autodromo = autodromo;
            lsAutos = new List<Auto>();
        }

        public void correrCarrera()
        {
            if (this.lsAutos.Count < 1)
            {
                throw new MiExeption("texto ", new DateTime());
            }
            else 
            {
                foreach (Auto item in this.lsAutos)
                {
                    item.Andar();
                }
            }
        }



    }
}
