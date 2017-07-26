using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib;
namespace PruebaForm
{
    public partial class Form1 : Form
    {
        List<Persona> Personas;

        public Form1()
        {
            InitializeComponent();
            Personas = new List<Persona>();
            this.cb1.Enabled = false;

            this.tb1.Text = "Nacho";
            this.tb2.Text = "Aurtenechea";

            MessageBox.Show("Bienvenido");

            this.cmb1.MouseClick += hacer;
            cmb1.Items.Add("hola");
            cmb1.Items.Add("chau"); 
        }

        private void hacer(object sender, EventArgs e) 
        {
            this.cb1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = this.tb1.Text;
            string apellido = this.tb2.Text;

            Persona p = new Persona(nombre, apellido);
            Personas.Add(p);
            refrescarLista();
            limpiarForm();

            
        }

        private void refrescarLista() 
        {
            this.lb1.Items.Clear();
            foreach (Persona p in Personas)
            {
                this.lb1.Items.Add(p.nombre + " " + p.apellido);
            }
        }

        private void limpiarForm()
        {
            this.tb1.Text = "";
            this.tb2.Text = "";
        }




        //private void lbl1_Click(object sender, EventArgs e)
        //{

        //}


    }
}
