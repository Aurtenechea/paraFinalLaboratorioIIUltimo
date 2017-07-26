using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public class Oso : IPesoAltura<Oso>
    {
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string Nombre { get; set; }
        public Oso(string nombre, float peso, float altura)
        {
            this.Peso = peso;
            this.Altura = altura;
            this.Nombre = nombre;
        }


         // Explicitos. metodos de interface son publicos por defoult
        float IPesoAltura<Oso>.GetPeso(Oso criatura)
        {
            return criatura.Peso;
        }

        float IPesoAltura<Oso>.GetAltura(Oso criatura)
        {
            return criatura.Altura;
        }

        // Implicitos.
        public float GetPeso(Oso criatura)
        {
            return criatura.Peso;

        public float GetAltura(Oso criatura)
        {
            return criatura.Peso;
        }
    }
}
