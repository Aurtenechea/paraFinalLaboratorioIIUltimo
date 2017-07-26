using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app1
{
    delegate void myDelegate(string nombre); 
    public partial class Form1 : Form
    {

        Form2 f2;

        public myDelegate metodoAEjecutar;

        Form3

        public Form1()
        {
            InitializeComponent();
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            if (f2 == null)
            {
                f2 = new Form2();
                f2.Owner = this;
                // f2.MdiParent = this;
                f2.Show();
            }
            
        }


    }
}
