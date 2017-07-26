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

namespace CarreraInterface
{
    public partial class Form1 : Form
    {
        private Carrera miCarrera;

        public Form1()
        {
            InitializeComponent();
            
            // testing
            txtNombre.Text = "Dakar 2016";
            txtFecha.Text = "22/11/16";
            txtLugar.Text = "CABA";
            // end testing


            cmbResultado.Items.Add("Por Tiempo");
            cmbResultado.Items.Add("Por Km");
            cmbResultado.SelectedItem = 0;

            cmbOrdenar.Items.Add("Fabricante");
            cmbOrdenar.Items.Add("Piloto");
            cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbOrdenar.SelectedIndex = 0;
            rbAsc.Checked = true;

            foreach (Efabricante item in Enum.GetValues(typeof(Efabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }
            this.cmbFabricante.SelectedIndex = 1;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miCarrera = new Carrera(this.txtNombre.Text, this.txtLugar.Text, this.txtFecha.Text);
            grpCarrera.Enabled = false;
            grpAutos.Enabled = true;
           
            // testing
            Auto autito = new Auto("Juancho", (Efabricante)1);
            this.miCarrera = this.miCarrera + autito;
            autito = new Auto("zzzz", (Efabricante)2);
            this.miCarrera = this.miCarrera + autito;
            autito = new Auto("aaaa", (Efabricante)0);
            this.miCarrera = this.miCarrera + autito;
            listarAutos();
            // end testing
        }

        private void btnAgregarAuto_MouseClick(object sender, MouseEventArgs e)
        {
            Auto autito = new Auto(this.txtNombrePiloto.Text, (Efabricante)cmbFabricante.SelectedItem);
            this.miCarrera = this.miCarrera + autito;
            listarAutos();
        }

        public void listarAutos()
        {
            lsbListaAutos.Items.Clear();
            foreach (Auto item in this.miCarrera.listaDeAutos)
            {
                lsbListaAutos.Items.Add(item.DatosEnString);
            }
        }
        private void btnCorrer_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (cmbResultado.SelectedIndex == 0)
            { 
                this.miCarrera.correrCarrera((Tiempo) 100) ;
            }
            else if (cmbResultado.SelectedIndex == 1)
            {
                this.miCarrera.correrCarrera((Kilometro)100); 
            }

            txtResultado.Text = this.miCarrera.mostrarCarrera();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            switch (this.cmbOrdenar.SelectedIndex)
            {
                case 0:
                    if (rbAsc.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorFabricanteAsc);
                    }
                    else if (rbDesc.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorFabricanteDesc);
                    }
                    break;
                case 1:
                    if (rbAsc.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorPilotoAsc);
                    }
                    else if (rbDesc.Checked == true)
                    {
                        this.miCarrera.listaDeAutos.Sort(Auto.ordenarPorPilotoDesc);
                    }
                    break;
            }
            listarAutos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

     }
}
