using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  para hacer uso de una clase en un proyecto separado dentro de la misma solucion..
    1- agrego la referencia en el proyecto que quiere utilizar esa clase.
    2- los dos tienen que tener el mismo namespace. O bien incluir el namespace del que 
        quiero hacer uso en la clase con "using". */
using ProyectoAparte;


namespace Practica7
{
    class Program
    {
        public enum Color {
            Rojo,
            Negro
        }
        static void Main(string[] args)
        {

            /*  practica enums. */
            Mascota m = Mascota.Gato;
            Mascota m2 = Mascota.Perro;
            Mascota m3 = (Mascota) 2; // tortuga.

            Color c = Color.Negro;

            Console.WriteLine(m);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(c);

            /*  practica StringBuilder */
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\n\n");
            sb.AppendLine("primera linea");
            sb.AppendLine("segunda linea");
            Console.Write(sb);
                       
            /*  separado es una clase que esta en un proyecto separado. */
            /*  son iguales cuando su valor es igual. */
            Separado s = new Separado();
            s.valor = 5;
            Separado s2 = new Separado();
            s2.valor = 7;
            Console.WriteLine(s == s2);

            Queue <Mascota> misMascotas =  new Queue<Mascota>();
            misMascotas.Enqueue(Mascota.Gato);
            misMascotas.Enqueue(Mascota.Gato);
            misMascotas.Enqueue(Mascota.Tortuga);

            Console.WriteLine(misMascotas.ElementAt(2));
            Console.WriteLine(misMascotas.Count());

            Console.WriteLine("Imprimo todas las de la queue.");
            foreach (var item in misMascotas)
            {
                Console.WriteLine(item);
            }

            Random random = new Random();
            Console.WriteLine("3 randoms: ");
            Console.WriteLine(random.Next(0,9999));
            Console.WriteLine(random.Next(0,9999));
            Console.WriteLine(random.Next(0,9999));

            /*  INDIZADORES. */
            Console.WriteLine("Indizador: ");
            Separado s3 = new Separado();
            s3[0] = 1111;
            s3[1] = 1222;
            s3[2] = 1333;
            /*  varios indizadores se diferencia por el tipo de indice. */
            Console.WriteLine(s3[0]);
            Console.WriteLine(s3["cero"]);
            Console.WriteLine(s3[1]);
            Console.WriteLine(s3["uno"]);
            Console.WriteLine(s3[2]);
            Console.WriteLine(s3["dos"]);



            Console.ReadKey();

        }
    }
}
