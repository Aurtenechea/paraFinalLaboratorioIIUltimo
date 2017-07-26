using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Drawing;
//using Final.Test;


namespace Entidades
{
    namespace Punto2F
    {
        public class ClaseConstructores
        {
            static ClaseConstructores()
            {
                MessageBox.Show("static ClaseConstructores");
                metodoEstatico();
            }

            private ClaseConstructores(int param1, int param2)
            {
                MessageBox.Show("private ClaseConstructores(int param1, int param2) ");
                int a = soloLectura;
            }

            public ClaseConstructores()
                : this(1, 2)
            {
                MessageBox.Show("public ClaseConstructores()");
                soloEscritura = 2;
            }

            public int soloEscritura
            {
                set { MessageBox.Show("public int soloEscritura"); metodoDeInstancia(); }
            }

            public int soloLectura
            {
                get { MessageBox.Show("public int soloEscritura"); return 0; }
            }

            public static void metodoEstatico()
            {
                MessageBox.Show("public static void metodoEstatico()");
            }

            public void metodoDeInstancia() 
            {
                MessageBox.Show("metodoDeInstancia()");
                
            }

            
        }
    }
}
