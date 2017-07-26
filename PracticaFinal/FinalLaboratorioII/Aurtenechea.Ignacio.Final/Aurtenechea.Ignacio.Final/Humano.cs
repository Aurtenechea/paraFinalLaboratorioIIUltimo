using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    //Entidades.Punto3.
    //Agregar en Humano el metodo Mostrar():string y Mostrar(Humano):string, ambos abstractos.
    //El metodo que no recibe parametros, retornara nombre y raza, mientras que el otro
    //retornara todas las caracteristicas de la instancia que recibe como parametro. REUTILIZAR CODIGO.
    
    /*  NOTA no puedo agregar metodos abstractos a una clase que se instancia. */



namespace Entidades
{
    namespace Inicio
    {

        public enum ERaza
        {
            Aria, Mestiza, Negra, Cabeza
        }

        public class Humano
        {
            public string nombre;
            public ERaza raza;


            public Humano(string nombre, ERaza raza)
            {
                this.nombre = nombre;
                this.raza = raza;
            }
        }

    }

}
