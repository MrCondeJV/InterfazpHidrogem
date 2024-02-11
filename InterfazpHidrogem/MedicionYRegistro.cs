using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazpHidrogem
{
    public partial class frmMedicionYRegistro : Form
    {
        public frmMedicionYRegistro()
        {
            InitializeComponent();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenu();
            form.Show();
        }

        private void btnRegistrarAlumno_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmRegistrarAlumno();
            form.Show();
        }

        private void btnHistorialConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmRegistrarSustancia();
            form.Show();
        }
    }
}
