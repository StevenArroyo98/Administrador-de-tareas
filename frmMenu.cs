using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto1
{
    public partial class frmAdministradordetareas : Form
    {
        public frmAdministradordetareas()
        {
            InitializeComponent();

        }

        private void btnSaliarAdministradorTareas_Click(object sender, EventArgs e) => Close();

        private void azulAmarilloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnTareasporrealizar_Click(object sender, EventArgs e)
        {
            frmTareasxrealizar frmTareasxrealizar = new frmTareasxrealizar();
            frmTareasxrealizar.Show();
        }

        private void btnTareasenprogreso_Click(object sender, EventArgs e)
        {
            frmTareasprogreso frmTareasprogreso = new frmTareasprogreso();
            frmTareasprogreso.Show();
        }

        private void btnTareascompletadas_Click(object sender, EventArgs e)
        {
            frmTareascompletadas frmTareascompletadas = new frmTareascompletadas();
            frmTareascompletadas.Show();
        }

        private void frmAdministradordetareas_Load(object sender, EventArgs e)
        {

        }
    }
}
