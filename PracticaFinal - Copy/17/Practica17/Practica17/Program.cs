using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aviso: Paciencia, puede demorar hasta 20 seg...");
            MisAccionesDemoran m = new MisAccionesDemoran();

            /*  me suscribo a cierto evento de una funcion, para que cuando 
                se active llame a la funcion que le paso. */
            m.onEnd += NecesitoHacerEstoCuandoTermineAquellaFuncion;


            /*  prueba de suscripcion sin eventos. */
            m.suscripcionSinEventos(NecesitoHacerEstoCuandoTermineAquellaFuncion2);
            m.suscripcionSinEventos(NecesitoHacerEstoCuandoTermineAquellaFuncion2);
            m.suscripcionSinEventos(NecesitoHacerEstoCuandoTermineAquellaFuncion2);


            /*  luego hago hacer algo en la misma instancia m donde me suscribi,
                que en algun momento puede activar ese evento. */
            m.DemoroXEnTerminar();

            Console.ReadKey();
        }

        public static void NecesitoHacerEstoCuandoTermineAquellaFuncion()
        {
            Console.WriteLine("VAAAAAMO LA REPUTA MAADREE!");
        }
        public static void NecesitoHacerEstoCuandoTermineAquellaFuncion2()
        {
            Console.WriteLine("VAAAAAMO LA REPUTA MAADREE 2 !");
        }
    }
}
