using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    public class Auto
    {

        public string marca;
        public int numero;
        public List<Rueda> lsRuedas;

        public Auto(string marca, int numero) 
        {
            this.marca = marca;
            this.numero = numero;
            this.lsRuedas = new List<Rueda>();
        }

        public void Andar()
        {
            if (this.lsRuedas.Count < 4)
            {
                throw new MiExeption("Reudas insuficientes", DateTime.Now);
            }
            else
            {
                try
                {
                    foreach (Rueda item in this.lsRuedas)
                    {
                        item.Rodar();

                    }
                }
                catch(PinchaduraExeption ex)
                {
                    AutoExeption exceptionAuto = new AutoExeption("Pinchadura en rueda " + ex.marca, DateTime.Now, this, ex);
                    throw exceptionAuto;
                }
            
            }
        }


    }
}
