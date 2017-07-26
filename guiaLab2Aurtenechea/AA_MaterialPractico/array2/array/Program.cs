using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula unAula = new Aula();

            Alumno alumno1 = new Alumno("juan", 01);
            Alumno alumno2 = new Alumno("pedro", 02);
            Alumno alumno3 = new Alumno("matias", 03);

            unAula.agregarAlumno(alumno1);
            unAula.agregarAlumno(alumno2);
            unAula.agregarAlumno(alumno3);

            unAula.borrarAlumno(alumno2);

            Alumno alumno4 = new Alumno("jose", 04);

            unAula.agregarAlumno(alumno4);
           
            //bool retorno = unAula.existeAlumno(alumno3);
            //retorno = unAula.existeAlumno(alumno4);

            unAula.agregarAlumno(alumno1);
            unAula.agregarAlumno(alumno2);
            unAula.agregarAlumno(alumno3);


            Aula.mostrarAlumnos(unAula);

            unAula.listaDeAlumnos[0].nombre = "lalala";
            // a ese alumno del cual tengo la "direccion en mi array... le pongo este nombre. Pero se modifica el alumno"


            Console.ReadLine();

            Console.WriteLine("------------------------");
            Aula nuevaAula = new Aula();

            nuevaAula = nuevaAula + alumno1;

            Aula.mostrarAlumnos(nuevaAula);
        }




    }
}
