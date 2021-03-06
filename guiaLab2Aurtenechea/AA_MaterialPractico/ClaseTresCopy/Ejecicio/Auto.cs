﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecicio
{
    public class Auto
    {
        private Efabricante fabricante;
        public Rueda DI;
        public Rueda DD;
        public Rueda TI;
        public Rueda TD;
        private string _nombrePiloto;
        public static int contadorDeObjetos;
        //atributo estatico es de clase no de objeto. 
        
        //private int kmRecorridos;
        //private int tiempoDemorado;

        private Kilometro kmRecorridos;
        private Tiempo tiempoDemorado;


        private static Random rdm;

        // propiedades
        public string NombrePiloto
        {
            set 
            {
                this._nombrePiloto = value;
            }
            get
            {
                return _nombrePiloto;
            }

        }

        public string DatosEnString
        {
            get
            {
                return devuelveStringParaListar();
            }

        }


        public Auto() {

            int num = rdm.Next(0, 2);
            this.fabricante = (Efabricante) num;
            this.kmRecorridos= 0;
            this.tiempoDemorado = 0;
            this.DI= new Rueda();
            this.DD= new Rueda();
            this.TI= new Rueda();
            this.TD= new Rueda();
            Auto.contadorDeObjetos++;
        }

        public Auto(string nombrePiloto, Efabricante fabricante)  :this()
        {
            this._nombrePiloto = nombrePiloto;
            this.fabricante = fabricante;
        }

        static Auto()
        {
            Auto.contadorDeObjetos = 0;
            rdm = new Random();
            /*
             *  metodo static se ejecuta una sola vez cuando se crea el primer objeto auto.
             *  no se puede sobrecargar.
             */
        }


         private string devuelveStringParaListar()
         {
             StringBuilder sb = new StringBuilder();
             sb.AppendLine("P:" + this._nombrePiloto + " - " );
             sb.AppendLine("F:" + this.fabricante);
             return sb.ToString();
         }



        public string mostrarAuto() 
        {
            StringBuilder sb = new StringBuilder();
            if (this.tiempoDemorado == 0)
            {
                //sb.AppendLine("El fab es: " + this.fabricante.ToString());
                sb.AppendFormat("El fab es: {0}", this.fabricante);
                sb.AppendFormat(" Y este auto recorrio: {0}", (int) this.kmRecorridos);
                //Console.WriteLine("El fab es: {0}", this.fabricante);                
                //Console.WriteLine("Y este auto recorrio: {0}", (int)this.kmRecorridos);
                //falta otro mostrar autoo ve como hacerlo 
                return sb.ToString();
            }
            else 
            {
                sb.AppendLine("El fab es: " + this.fabricante.ToString());
                sb.AppendLine("Y este auto tardo: " + (int)this.kmRecorridos);
                return sb.ToString();
            }
        }

        

        public int getKm()
        {
            return (int) this.kmRecorridos;
        }

        public int getTiempo()
        {
            return (int)this.tiempoDemorado;
        }

        public void volverACero() {
            this.kmRecorridos = 0;
            this.tiempoDemorado = 0;
        }

        //deprecated: sobrecarga de metodos
        //public void agregarKm(int km)
        //{
        //    this.kmRecorridos = km;
        //}

        //public void agregarTiempo(int tiempo)
        //{
        //    this.tiempoDemorado = tiempo;
        //}
       
        public static bool compararAuto(Auto uno, Auto dos){
            if (uno.fabricante == dos.fabricante)
                return true;
                return false;
        }


        public void agregar(Tiempo tiempo)
        {
            this.tiempoDemorado = this.tiempoDemorado + tiempo;
        }

        public void agregar(Kilometro km)
        {
            this.kmRecorridos = this.kmRecorridos + km;
        }

        public static int ordenarPorFabricanteAsc(Auto unAuto,Auto otroAuto) 
        {
           return string.Compare(unAuto.fabricante.ToString(), otroAuto.fabricante.ToString());
        }
        public static int ordenarPorFabricanteDesc(Auto unAuto, Auto otroAuto)
        {
            return string.Compare(otroAuto.fabricante.ToString(), unAuto.fabricante.ToString());
        }

        public static int ordenarPorPilotoAsc(Auto unAuto,Auto otroAuto)
        {
            return string.Compare(unAuto._nombrePiloto , otroAuto._nombrePiloto);
        }
        public static int ordenarPorPilotoDesc(Auto unAuto, Auto otroAuto)
        {
            return string.Compare(otroAuto._nombrePiloto, unAuto._nombrePiloto);
        }


    }
}
