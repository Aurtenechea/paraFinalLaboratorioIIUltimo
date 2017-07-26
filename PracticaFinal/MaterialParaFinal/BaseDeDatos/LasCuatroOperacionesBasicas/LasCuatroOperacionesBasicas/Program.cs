using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LasCuatroOperacionesBasicas
{
    class Program
    {
        static void Main(string[] args)
        {
            Lib.BaseDeDatos.borrar();
            Console.WriteLine(Lib.BaseDeDatos.ObtenerNombreDeColumnas());
            Console.WriteLine(" **** leo datos pre ****");
            Console.WriteLine(Lib.BaseDeDatos.leer());
            Console.WriteLine(" **** hago insert ****");
            Lib.BaseDeDatos.insertar();
            Console.WriteLine(" **** leo datos post insert ****");
            Console.WriteLine(Lib.BaseDeDatos.leer());
            Console.WriteLine(" **** hago update ****");
            Lib.BaseDeDatos.modificar();
            Console.WriteLine(" **** leo datos post update****");
            Console.WriteLine(Lib.BaseDeDatos.leer());
  


            Console.ReadKey();

        }
    }
}
