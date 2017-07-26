using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pelotita
{
    public partial class Form3 : Form
    {
        Thread nuevoHilo;

        public Form3()
        {
            InitializeComponent();
            // registro los manejadores de eventos al evento.
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            this.btnPausar.Click += new System.EventHandler(this.Pausar);
            this.btnReanudar.Click += new System.EventHandler(this.Reanudar);
            this.btnDestruir.Click += new System.EventHandler(this.Destruir);
        }


        public void Destruir (object sender, EventArgs e)
        {
            nuevoHilo.Abort();
        }

        public void Reanudar(object sender, EventArgs e)
        {
            nuevoHilo.Resume();
        }

        public void Pausar(object sender, EventArgs e) 
        {
            nuevoHilo.Suspend();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_con_thread.Pelotita p = new Pelotita_con_thread.Pelotita(this.pictureBox1);
            nuevoHilo = new Thread(p.DoWork);
            nuevoHilo.Start();
            /*
             *  el Form3.Designer.cs crea un evento al objeto this.btnCrear.Click con: 
             *  this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
             *  luego quitamos el evento con la siguiente linea, y asi el boton deja de responder al evento.
             *  asi dolo se podra crear una sola pelota.  
             */
             this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
            // p.DoWork();
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {

        }
    }
}
