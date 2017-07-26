using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deposito<Producto> miDepProd = new Deposito<Producto>(3);

            Persona persona1 = new Persona("Nacho", 35208599);
            Persona persona2 = new Persona("Eze", 35256579);
            Persona persona3 = new Persona("Maxi", 35245679);

            Vehiculo vehic1 = new Vehiculo("Honda","Gris","HUF243");
            Vehiculo vehic2 = new Vehiculo("Ford", "Gris", "GRF673");
            Vehiculo vehic3 = new Vehiculo("Fiat", "Blanco", "TYF283");

            Mascota masc1 = new Mascota("Toby", "Generica");
            Mascota masc2 = new Mascota("Lila", "Collie");
            Mascota masc3 = new Mascota("Luna", "Doberman");

            Deposito<Persona> miDepPersona = new Deposito<Persona>(3);
            Deposito<Vehiculo> miDepVehiculo = new Deposito<Vehiculo>(3);
            Deposito<Mascota> miDepMascota = new Deposito<Mascota>(3);

            miDepPersona.Agregar(persona1);
            miDepPersona.Agregar(persona2);
            miDepPersona.Agregar(persona3);

            miDepVehiculo.Agregar(vehic1);
            miDepVehiculo.Agregar(vehic2);
            miDepVehiculo.Agregar(vehic3);

            miDepMascota.Agregar(masc1);
            miDepMascota.Agregar(masc2);
            miDepMascota.Agregar(masc3);


            foreach (Persona item in miDepPersona) //implementar GetEnumerator() de IEnumerable  con un for y yield para poder hacer andar asi el foreach
            {
                item.ToString();
            }


            //Producto p = new Producto();
            //Console.WriteLine(p.toString());

            Console.ReadLine();

        
        }
    }
}
