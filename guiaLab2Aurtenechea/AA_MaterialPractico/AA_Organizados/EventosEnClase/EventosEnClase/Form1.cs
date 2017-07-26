using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventosEnClase
{
    public partial class Form1 : Form
    {
        public ClassLibrary1.Cuenta cuenta;



        public Form1()
        {
            InitializeComponent();

            cuenta = new ClassLibrary1.Cuenta();

            /*  saldoNegativo es el evento. */
            cuenta.SaldoNegativo += this.MostrarSaldoNegativoEnCuenta;

        }

        /*
         * para crear un efento hay que definir la firma. Esta se define en el delegado.
         * 
         * crear el evento del tipo del delegado que cree antes.
         * 
         * invoco al evento en la clase.
         * 
         * creo el manejador donde corresponda.
         */

        public void MostrarSaldoNegativoEnCuenta(float SaldoNegativo)
        {
            // manejador del evento.
            MessageBox.Show(SaldoNegativo.ToString());
        }


        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            cuenta.SacarDinero(1000);
        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(sender.GetType() == typeof(System.Windows.Forms.TabAlignment));
            //if (((System.Windows.Forms.TextBox)sender).Name == "txtBox1")
            
            if( ((System.Windows.Forms.TextBox)sender).Name == "txtBox1" )
                MessageBox.Show("Este evento KeyPress se disparo desde el txtBox1");
            else
                MessageBox.Show("Este evento KeyPress se disparo desde el txtBox2");
        }
        private void txtBox1_KeyPress2(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show("txtBox1_KeyPress2");
            if (((System.Windows.Forms.TextBox)sender).Name == "txtBox1")
                MessageBox.Show("Este evento KeyPress2 se disparo desde el txtBox1");
            else
                MessageBox.Show("Este evento KeyPress2 se disparo desde el txtBox2");
        }
        private void mio(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Mio. Lo envio el objeto: " + sender.GetType() + "\nLa tecla presionada fue: " + e.KeyChar);
        }



    }
}
