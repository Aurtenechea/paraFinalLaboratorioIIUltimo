using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07Js
{
    class Juego
    {
        public Valores valorMaquina;
        public Valores valorJugador;
        public string ganador;
        static Random rdm;
        public static int ganadasJugador;
        public static int ganadasMaquina;


        public Juego( Valores jugador)
        {
            valorJugador = jugador;
            valorMaquina = (Valores) rdm.Next(0, 3);
            this.ganador = "maquina";
            switch ((int)this.valorJugador)
            {
                case 0:
                    if ((int)this.valorMaquina == 0)
                        this.ganador = "empate";
                    else if ((int)this.valorMaquina == 2)
                        this.ganador = "jugador";
                    break;

                case 1:
                    if ((int)this.valorMaquina == 0)
                        this.ganador = "jugador";
                    else if ((int)this.valorMaquina == 1)
                        this.ganador = "empate";
                    break;

                case 2:
                    if ((int)this.valorMaquina == 1)
                        this.ganador = "jugador";
                    else if ((int)this.valorMaquina == 2)
                        this.ganador = "empate";
                    break;

            }

            actualizarEstadisticas();

        }

        static Juego()
        {
            rdm = new Random();
            ganadasJugador = 0;
            ganadasMaquina = 0;
        }

        public string getGanador() 
        {
            return this.ganador;
        }

        public void actualizarEstadisticas()
        {
            if (this.ganador == "maquina")
                Juego.ganadasMaquina++;
            else if (this.ganador == "jugador")
                Juego.ganadasJugador++;
        }
    }
}
