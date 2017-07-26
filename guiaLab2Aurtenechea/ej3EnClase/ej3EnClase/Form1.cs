using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ej3EnClase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
           
            string aux;
            aux = this.txtNombre.Text;
            MessageBox.Show(aux);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            this.txtLabel.Text = "cambie el texto";   




            //los metodos dejan de mostar cosas, solo retornan string

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAprobarMateria_MouseHover(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = false;
        }

        private void btnAprobarMateria_MouseLeave(object sender, EventArgs e)
        {
            //this.btnAprobarMateria.Visible = true;
        }

        private void btnAprobarMateria_MouseEnter(object sender, EventArgs e)
        {
            this.btnAprobarMateria.Visible = false;

        }
    }
}
