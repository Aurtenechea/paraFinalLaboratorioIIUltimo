using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericInterface
{
    public class Persona : IPesoAltura<Persona>
    {
        public float Peso { get; set; }
        public float Altura { get; set; }
        public string Nombre { get; set; } 
        public string Idioma  { get; set; }

        public Persona(string nombre, string idioma, float peso, float altura)
        {
            this.Peso = peso;
            this.Altura = altura;
            this.Nombre = nombre;
            this.Idioma = idioma;
        }

        float IPesoAltura<Persona>.GetPeso(Persona criatura)
        {
            return criatura.Peso;
        }

        float IPesoAltura<Persona>.GetAltura(Persona criatura)
        {
            return criatura.Altura;
        }

        public float GetPeso(Persona criatura)
        {
            return criatura.Peso;
        }

        public float GetAltura(Persona criatura)
        {
            return criatura.Altura;
        }
    }
}
