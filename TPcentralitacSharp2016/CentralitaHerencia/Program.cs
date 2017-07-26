using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // En el Main() se creará una Centralita (―Telefónica‖) y cuatro llamadas. 
            // La primera llamada será de tipo Local, con una duración de 30 seg.
            // y un costo de 2.65. La segunda será Provincial 
            // (en la franja 1 y con duración de 21 seg.) y las restantes: Local (45 seg. y 1.99)
            // y Provincial (que recibe la segunda llamada y franja 3).

            Centralita miCentralita = new Centralita("La Hipotenusa");
            Local miLocal = new Local("Mongolia", 30, "Sudafrica", 2.65f);
            Provincial miProvincial = new Provincial("43435177", Franja.Franja_1, 21, "1130477439");
            Local miLocal2 = new Local("1130477439", 45, "43435177", 1.99f);
            Provincial miProvincial2 = new Provincial(Franja.Franja_3 ,miProvincial);
            miCentralita._listaDeLlamadas.Add(miLocal);
            miCentralita._listaDeLlamadas.Add(miProvincial);
            miCentralita._listaDeLlamadas.Add(miLocal2);
            miCentralita._listaDeLlamadas.Add(miProvincial2);

            miLocal.Mostrar();
            miLocal2.Mostrar();
            miProvincial.Mostrar();
            miProvincial2.Mostrar();

            Console.WriteLine(miCentralita.GananciaPorLocal);
            Console.WriteLine(miCentralita.GananciaPorProvincial);
            Console.WriteLine(miCentralita.GananciaPorTotal);

           // miLocal.Mostrar();
            //miProvincial.Mostrar();
            Console.ReadLine();
        }
    }
}
