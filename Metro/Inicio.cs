using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metro
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void bEmpleados_Click(object sender, EventArgs e)
        {
            Empleados vetanaEmpleados = new Empleados();
            vetanaEmpleados.Show();
            this.Visible = false;
        }

        private void bLineas_Click(object sender, EventArgs e)
        {
            Lineas ventanaLineas = new Lineas();
            ventanaLineas.Show();
            this.Visible = false;
        }
    }
}



