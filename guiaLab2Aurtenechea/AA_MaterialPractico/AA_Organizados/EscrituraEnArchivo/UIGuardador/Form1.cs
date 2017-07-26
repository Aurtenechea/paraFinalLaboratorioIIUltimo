using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscrituraEnArchivo;



namespace UIGuardador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona(txtNombre.Text, txtClave.Text);
            if (Guardador.GuardarPersona(p))
            {
                lblRespuesta.Text = "Save successful!";
            }
            else
            {
                lblRespuesta.Text = "Unsaved";
            }

            txtClave.Text = "";
            txtNombre.Text = "";
            CargarListado();
            

        }

        public void CargarListado()
        {
            //StringBuilder sb = new StringBuilder();
            List<Persona> lsPersonas = Guardador.RetornarListado();
            foreach (Persona item in lsPersonas)
            {
                lsBox.Items.Add(item);
                //sb.AppendLine(item.ToString());
            }
            
            
            //lsBox.Text = sb.ToString();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
