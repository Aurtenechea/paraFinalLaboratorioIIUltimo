using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaDeAlumnos;
        //tipo de dato
        /*
          public Alumno[] listaDeAlumnos;
          this.listaDeAlumnos = new Alumno[10]; 
          la primera linea se resume en decirle al compilador: 
            -crea una variable publica que va a ser del tipo array. (osea un puntero a una direccion de mem) 
          la segunda le dice: 
            -reserva espacio en memoria para 10 objetos de tipo alumno. 
             y devolveme la direccion del primero asi la guardo en el puntero.            
         */

        public Aula()
        {
            this.listaDeAlumnos = new Alumno[10];
            // no estan instanciados los objetos de dentro del array, pero si el array, sabiendo que van a ser todos alumnos.

            //for (int i = 0; i < 10; i++) 
            //{
            //    listaDeAlumnos[i] = new Alumno();
            //}
            
            
            //foreach (Alumno objAlum in this.listaDeAlumnos)
            //{
            //    objAlum.nombre = "NN";
            //}
            //// en un for each no se puede instanciar los objetos
        }

        /// <summary>
        /// devuelve el indice del primer elemento null de lo contrario retorna -1.
        /// </summary>
        /// <returns>devuelve el indice del primer elemento null de lo contrario retorna -1.</returns>
        public int obtenerIndice()
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if (  (object) this.listaDeAlumnos[i] == null )
                {
                    break;
                }
            }
            if (i < 10)
            return i;
            return -1;
        }

        /// <summary>
        /// retorna el indice del objeto de lo contrario retorna -1.
        /// </summary>
        /// <param name="unAlumno">alumno del que se quiere buscar el indice.</param>
        /// <returns>retorna el indice del objeto de lo contrario retorna -1.</returns>
        public int obtenerIndice(Alumno unAlumno)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                if ( (object) this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i].legajo == unAlumno.legajo)
                {   //para que no se rompa va el this.listaDeAlumnos[i] != null. Es decir si es null no sigue evaluando.
                    break;
                }
            }
            return i;
        }


        public void agregarAlumno(Alumno unAlumno)
        {
            int indice;
            indice = this.obtenerIndice();
             // (indice != -1 && this.obtenerIndice(unAlumno) == -1)
            if ( indice != -1 && !this.existeAlumno(unAlumno) )
                this.listaDeAlumnos[indice] = unAlumno;
            else
                Console.WriteLine("no hay lugar, o el alumno ya existe..");
        }

        public static void mostrarAlumnos(Aula miAula)
        {
            foreach (Alumno objAlum in miAula.listaDeAlumnos)
            {
                if(objAlum != null)
                Console.WriteLine("El nombre es: {0}", objAlum.nombre);
            }
        }

        public void borrarAlumno(Alumno unAlumno)
        {
            int i;
           
            for (i = 0; i < 10; i++)
            {
                if (this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i].legajo == unAlumno.legajo)
                {   //para que no se rompa
                    this.listaDeAlumnos[i] = null;
                    break;
                }
            }
        }

        public bool existeAlumno(Alumno unAlumno)
        {
            bool rtn = false;
            if ( this.obtenerIndice(unAlumno) != -1)
            {   
                    rtn = true;
            }
            return rtn;
        }

        public static bool operator == (Aula aul, Alumno alm)
        {
            return aul.existeAlumno(alm);
        }

        public static bool operator !=(Aula aul, Alumno alm)
        {
            return !aul.existeAlumno(alm);
        }

        public static Aula operator +(Aula aul, Alumno alm)
        {
            aul.agregarAlumno(alm);
            return aul;
        }

        public static Aula operator -(Aula aul, Alumno alm)
        {
            aul.borrarAlumno(alm);
            return aul;
        }

    }
}
