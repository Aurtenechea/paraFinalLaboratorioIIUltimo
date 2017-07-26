using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace ThreadAndForm
{
    public partial class Form1 : Form
    {
        Form2 f2;
        Thread t;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            f2 = new Form2();
            t = new Thread(f2.Show);

            t.Start();
    
        }
    }
}
