using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07Js
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            Juego miJuego = new Juego((Valores)0);
            lbl1.Text = "Jugador: " + miJuego.valorJugador.ToString();
            lbl2.Text = "Maquina: " + miJuego.valorMaquina.ToString();
            lbl3.Text = "Ganador: " + miJuego.getGanador();
            lbl4.Text = "El jugador gano: " + Juego.ganadasJugador.ToString();
            lbl5.Text = "La maquina gano: " + Juego.ganadasMaquina.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            Juego miJuego = new Juego((Valores)1);
            lbl1.Text = "Jugador: " + miJuego.valorJugador.ToString();
            lbl2.Text = "Maquina: " + miJuego.valorMaquina.ToString();
            lbl3.Text = "Ganador: " + miJuego.getGanador();
            lbl4.Text = "El jugador gano: " + Juego.ganadasJugador.ToString();
            lbl5.Text = "La maquina gano: " + Juego.ganadasMaquina.ToString();
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            Juego miJuego = new Juego((Valores)2);
            lbl1.Text = "Jugador: " + miJuego.valorJugador.ToString();
            lbl2.Text = "Maquina: " + miJuego.valorMaquina.ToString();
            lbl3.Text = "Ganador: " + miJuego.getGanador();
            lbl4.Text = "El jugador gano: " + Juego.ganadasJugador.ToString();
            lbl5.Text = "La maquina gano: " + Juego.ganadasMaquina.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {

        }
    }
}
