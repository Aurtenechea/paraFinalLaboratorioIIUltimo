using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexador
{
    class Program
    {
        static void Main(string[] args)
        {


            #region
            ////Pc pcUno = new Pc("Dell", "Linux");
            ////Pc pcDos = new Pc("Asus");
            //Laboratorio miLab = new Laboratorio("Lab4");

            ////Pc pcTres = new Pc("Sony");



            //miLab[0] = "Sony";
            //miLab[1] = "Dell";
            //miLab[2] = "Asus";
            //// Pc varInt = miLab[5]; 
            //for (int i = 0; i < miLab.listaDePc.Count; i++)
            //{
            //    Console.WriteLine(miLab.listaDePc[i].marca + " " + miLab.listaDePc[i].SO + " " + miLab.listaDePc[i].numero.ToString() );
            //}

            //Console.ReadKey();
            #endregion

            Carrera unaCarrera = new Carrera( "sarasa ");
            

            Auto unAuto = new Auto("honda", 3);
            //unAuto.Andar();

            Auto auto1 = new Auto("honda", 3);
            Auto auto2 = new Auto("ford", 5);
            Auto auto3 = new Auto("chevrolet", 2);
            Auto auto4 = new Auto("fiat", 1);

            auto1.lsRuedas.Add(new Rueda("a"));
            auto1.lsRuedas.Add(new Rueda("b"));
            auto1.lsRuedas.Add(new Rueda("c"));
            auto1.lsRuedas.Add(new Rueda("d"));

            auto2.lsRuedas.Add(new Rueda("e"));
            auto2.lsRuedas.Add(new Rueda("f"));
            auto2.lsRuedas.Add(new Rueda("g"));
            auto2.lsRuedas.Add(new Rueda("h"));

            auto3.lsRuedas.Add(new Rueda("i"));
            auto3.lsRuedas.Add(new Rueda("j"));
            auto3.lsRuedas.Add(new Rueda("k"));
            auto3.lsRuedas.Add(new Rueda("l"));

            auto4.lsRuedas.Add(new Rueda("m"));
            auto4.lsRuedas.Add(new Rueda("n"));
            auto4.lsRuedas.Add(new Rueda("o"));
            auto4.lsRuedas.Add(new Rueda("p"));


            unaCarrera.lsAutos.Add(auto1);
            unaCarrera.lsAutos.Add(auto2);
            unaCarrera.lsAutos.Add(auto3);
            unaCarrera.lsAutos.Add(auto4);


            try 
            {
                unaCarrera.correrCarrera();                
            }
            catch (AutoExeption miExepAuto)
            {
                Console.WriteLine(miExepAuto.Message);
            }
            catch (PinchaduraExeption miExepPinch)
            {
                Console.WriteLine(miExepPinch.Message);
            }
            catch (MiExeption miExep)
            {
                Console.WriteLine(miExep.Message);
            }
            


            Console.ReadLine();
        }
    }
}
