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
    public partial class Lineas : Form
    {
        public Lineas()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            Inicio ventanaInicio = new Inicio();
            ventanaInicio.Show();
            this.Visible = false;
        }

        private void bTrenes_Click(object sender, EventArgs e)
        {
            Trenes ventanaTrenes = new Trenes();
            ventanaTrenes.Show();
            this.Visible = false;
        }

        private void bJefeEstacion_Click(object sender, EventArgs e)
        {
            JefeEstacion ventanaJefe = new JefeEstacion();
            ventanaJefe.Show();
            this.Visible = false;
        }
    }
}
            