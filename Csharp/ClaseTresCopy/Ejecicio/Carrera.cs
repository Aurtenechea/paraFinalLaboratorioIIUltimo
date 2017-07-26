using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Carrera
    {
        // depreticated por coleccion 
        //public Auto auto1;
        //public Auto auto2;
        //public Auto auto3;
        //public Auto auto4;
        //public Auto auto5;
        //public Auto auto6;
        public List<Auto> listaDeAutos;
        public string nombre;
        public string fecha;
        public string lugar;
          
        public static Random rdm;

        #region constructores
        public Carrera(string nombre, string lugar, string fecha)
        {

             //auto1 = new Auto();
             //auto2 = new Auto();
             //auto3 = new Auto();
             //auto4 = new Auto();
             //auto5 = new Auto();
             //auto6 = new Auto();
            this.nombre = nombre;
            this.lugar = lugar;
            this.fecha = fecha;

            this.listaDeAutos = new List<Auto>();
        }

         static Carrera()
         {
             rdm = new Random();
         }
        #endregion  

        private void agregarAuto(Auto unAuto) 
        {
            this.listaDeAutos.Add(unAuto);
        }

       public static Carrera operator + (Carrera carrera, Auto auto)
       {
           carrera.agregarAuto(auto);
           return carrera;        
       }

         public void correrCarrera(Tiempo tiempo)
         {
             this.porTiempo((int)tiempo);
         }

         public void correrCarrera(Kilometro kilometros)
         {
             this.porKm((int)kilometros);
         }

         public void porTiempo(int minutos)
         {
             for (int i = 0; i < minutos; i++)
             {
                 foreach (var unAuto in this.listaDeAutos)
                 {
                     unAuto.agregar((Tiempo)((int)rdm.Next(10, 100)));
                 }
             }
         }

         public void porKm(int km)
         {
             for (int i = 0; i < km; i++)
             {
                 foreach (var unAuto in this.listaDeAutos)
                 {
                     unAuto.agregar((Kilometro)((int)rdm.Next(10, 100)));
                 }
             }
         }

        

         public string mostrarCarrera()
         {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine("=================================================");
             sb.AppendLine("La carrera tiene: ");

             //Console.WriteLine("=================================================");
             //Console.WriteLine("La carrera tiene: ");
             //Console.WriteLine();

             foreach (Auto unAuto in this.listaDeAutos)
             {
                 sb.AppendLine(unAuto.mostrarAuto());
             }
             // if (this.listaDeAutos[indice].getTiempo() == 0)

             Auto ganador;
             ganador = new Auto();

             if (this.listaDeAutos[0].getKm() == 0)
             {
                 for (int indice = 0; indice < this.listaDeAutos.Count; indice++)
                 {
                     if (this.listaDeAutos[indice].getTiempo() > ganador.getTiempo())
                     {
                         ganador = this.listaDeAutos[indice];
                     }
                 }
                 sb.AppendLine("El ganador tardo " + ganador.getTiempo().ToString() + "tiempo.");
             }
             else 
             {
                 for (int indice = 0; indice < this.listaDeAutos.Count; indice++)
                 {
                     if (this.listaDeAutos[indice].getKm() > ganador.getKm())
                     {
                         ganador = this.listaDeAutos[indice];
                     }

                 }
                 //Console.WriteLine("El ganador recorrio {0} kms.", ganador.getKm());
                 sb.AppendLine("El ganador recorrio " + ganador.getKm().ToString() + "kms.");
             }
             return sb.ToString();
        }

         public void volverACero()
         {
             foreach (Auto unAuto in this.listaDeAutos)
             {
                 unAuto.volverACero();
             }
         }


        #region deprecated
    
         //public void mostrarCarrera()
         //{
         //    Console.WriteLine("=================================================");
         //    Console.WriteLine("La carrera tiene: ");
         //    Console.WriteLine();


         //    foreach (Auto unAuto in this.listaDeAutos)
         //    {
         //        unAuto.mostrarAuto();
         //    }
         //    // deprecated por colection
         //    //this.auto1.mostrarAuto();
         //    //this.auto2.mostrarAuto();
         //    //this.auto3.mostrarAuto();
         //    //this.auto4.mostrarAuto(); 
         //    //this.auto5.mostrarAuto();
         //    //this.auto6.mostrarAuto();

         //    Auto ganador;
         //    ganador = new Auto();


         //    //max = this.auto1.getKm();
         //    //if (max < this.auto2.getKm())
         //    //{
         //    //    max = this.auto2.getKm();
         //    //    ganador = auto2;
         //    //}
         //    //if (max < this.auto3.getKm())
         //    //{
         //    //    max = this.auto3.getKm();
         //    //    ganador = auto3;
         //    //}
         //    //if (max < this.auto4.getKm())
         //    //{
         //    //    max = this.auto4.getKm();
         //    //    ganador = auto4;
         //    //}
         //    //if (max < this.auto5.getKm())
         //    //{
         //    //    max = this.auto5.getKm();
         //    //    ganador = auto5;
         //    //}
         //    //if (max < this.auto6.getKm())
         //    //{
         //    //    max = this.auto6.getKm();
         //    //    ganador = auto6;
         //    //}


        //public Carrera(Tiempo tiempo)
        //{ 

        //}

        //public Carrera(Kilometro km)
        //{

        //}

         //  //  max = 0;

         //    bool flag = false;

         //    Auto[] arrayAutos = new Auto[] { auto1, auto2, auto3, auto4, auto5, auto6 };

         //    if (this.auto1.getTiempo() == 0)
         //    {
         //        for (int i = 0; i < 6; i++)
         //        {
         //            if (arrayAutos[i].getKm() > ganador.getKm())
         //            {
         //                ganador = arrayAutos[i];
         //            }
         //        }

         //        Console.WriteLine("El ganador recorrio {0} kms.", ganador.getKm());
         //    }
         //    else
         //    {
         //        for (int i = 0; i < 6; i++)
         //        {
         //            if (arrayAutos[i].getTiempo() < ganador.getTiempo() || flag == false)
         //            {
         //                ganador = arrayAutos[i];
         //                flag = true;
         //            }
         //        }
         //        Console.WriteLine("El ganador tardo {0} tiempo.", ganador.getTiempo());
         //    }
        //}
        #endregion


    }
}
