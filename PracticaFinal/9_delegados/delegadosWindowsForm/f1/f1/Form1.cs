using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace f1
{
    public partial class Form1 : Form
    {
        //delegate void MyDelegate();

        public f2 f2;
        public f3 f3;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void subOp1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null)
            {
                f2 = new f2();
                f2.Show();
                f2.Owner = this;
                //f2.FormClosed += new FormClosedEventHandler(HacerLuegoDeCerrarF2);
                
                f2.FormClosed += HacerLuegoDeCerrarF2;
            }
            else
            {
                f2.Activate();
            }
        }

        public void HacerLuegoDeCerrarF2(object sender, EventArgs e)
        {
            f2 = null;
        }

        private void subOp2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f3 == null)
            {
                f3 = new f3();
                f3.Show();
                f3.Owner = this;
                //f3.FormClosed += new FormClosedEventHandler(HacerLuegoDeCerrarF3);

                f3.FormClosed += HacerLuegoDeCerrarF3;
            }
            else
            {
                f3.Activate();
            }
        }
        public void HacerLuegoDeCerrarF3(object sender, EventArgs e)
        {
            f3 = null;
        }
    }
}
