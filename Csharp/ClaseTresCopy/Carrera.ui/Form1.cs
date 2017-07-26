using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejecicio;


namespace CarreraInterface.ui
{
    public partial class Form1 : Form
    {
        public Carrera miCarrera;

        public Form1()
        {
            InitializeComponent();
            miCarrera = new Carrera();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rueda miRueda = new Rueda();
        }

    
    }
}
