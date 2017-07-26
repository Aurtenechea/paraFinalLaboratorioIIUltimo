using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

// hay dos tipos de colecciones  -----  

// generic      using System.Collections.Generic;         
// aca las que tienen           
// genero.
// list<Autos>
// stack <autos>
// queue  <auto>                       
// hashtable lleva tipo de clave y de dato.
// list<object> = arraylist

//no generic  using System.Collections;
// aca van las que se guardan como objet.
// puede ser cualquier cosa
// ArrayList
// stack
// queue           cola... (enqueue y dequeue son los push y pops)
// hashtable nada.

namespace Ejecicio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Auto> ls = new List<Auto>(); //generic

            ArrayList arrLs = new ArrayList();
            
            Stack <Auto> st = new Stack<Auto>();

            arrLs.Add("texto");
            arrLs.Add(5);

            //push agrega en orden.
            //pop devuelve y borra la ultima
            //peek solo la muestra no la borra no borra.
            
            Efabricante fabricante;

/*
            fabricante = Efabricante.Honda;
            Console.WriteLine(fabricante);

            fabricante = (Efabricante) 0;
            Console.WriteLine(fabricante);
            Console.ReadLine();
*/

            Rueda otraRueda = new Rueda("pirelli");
            // uso la sobrecarga de la clase Rueda.

            Rueda ruedaTres = new Rueda(4);


            Carrera miCarrera= new Carrera();
            miCarrera = miCarrera + new Auto();
            miCarrera = miCarrera + new Auto();
            miCarrera = miCarrera + new Auto();
            miCarrera = miCarrera + new Auto();
            miCarrera.correrCarrera((Tiempo)15);
            miCarrera.mostrarCarrera();
            miCarrera.volverACero();
            miCarrera.correrCarrera((Kilometro)20);
            miCarrera.mostrarCarrera();



         //   miCarrera.correrCarrera( (Tiempo) 15);
            
          //  miCarrera = new Carrera();
          //  miCarrera.correrCarrera( (Kilometro) 12);

           // miCarrera.mostrarCarrera();
            Console.ReadKey();

            /*
            Rueda nuevaRueda;
            nuevaRueda = new Rueda();

            Auto miAuto = new Auto();

            Auto miAuto1 = new Auto();

            Auto miAuto2 = new Auto();

            Auto miAuto3 = new Auto();
        */
        }


    }


}
