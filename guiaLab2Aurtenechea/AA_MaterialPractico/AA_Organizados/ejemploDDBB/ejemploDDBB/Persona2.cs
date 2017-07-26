using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploDDBB
{
    public partial class Persona2 : Form
    {
        public Persona2()
        {
            InitializeComponent();
        }

        private void personaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.personaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ejemplo1DataSet);

        }

        private void Persona2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ejemplo1DataSet.Persona' table. You can move, or remove it, as needed.
            this.personaTableAdapter.Fill(this.ejemplo1DataSet.Persona);

        }
    }
}
