using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructores
{
    class Objeto
    {
        // atributos
        private string nombre;
        public int atributo1;
        public static int countPublic;
        private static int countPrivate;

        // metodos constructores.
        // si no creo ninguno hay uno por default vacio. Si creo alguno el por default se elimina.

        public Objeto() // constructores nunca retornan nada. Ni siquiera llevan void.
        {
            // en general en el constructor por defecto (sin parametros) se inicializan los atributos en cero.
            this.nombre = "";
            this.atributo1 = 0;
            // los atributos static deben inicializarse en un constructor static que se ejecutara una sola vez. (constructor de clase)
            
            // luego como el constructor static se va a ejecutar antes que este, y solo una vez la variable ya va a estar inicializada a cero.
            Objeto.countPrivate++;
            
        }

        static Objeto ()  // se llama solo en la instanciacion del primer objeto de este tipo. Se ejecuta antes que culquier constructor.
        {
            // para ver en el debugger metodos estaticos y sobrecarga de operadores se necesita breakpoint. 

            // this.countPublic = 0 estaria mal ya que no se puede usar "this" dentro de un metodo estatico o de clase.
            Objeto.countPublic = 0;  // se logra referenciando el nombre de la clase. Atributos static.
            Objeto.countPrivate = 0;
        }

        public Objeto (int num):this()  // este constructor llama al por defecto antes de ejecutarse asi mismo.
        {
            this.atributo1 = num;
        }

        public Objeto(int num, string cadena):this(num) // se van a ir invicando en orden este llama a Objeto(int) antes de ejecutarse a si mismo
        {                                               // y a su vez el otro tambien antes va a llamar al por de defecto. Por lo tanto el resultado es el esperado
            this.nombre = cadena;
        }

        public Objeto(string cadena, int num):this(num, cadena)
        {
            // vacio. ya esta el codigo necesario en los demas
        }



        //  para finalizar.. los constructores deben diferir en:
        //  1) cantidad de parametros
        //  2) tipo de parametros 
        //  3) orden de parametros de tipos diferentes
        //  
        //  asi el compilador sabe a cual llamar.

    }
}
