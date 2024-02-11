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
    public partial class frmMenuHistorial : Form
    {
        public frmMenuHistorial()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenu();
            form.Show();
        }

        private void btnMedicionRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmHistorialYConsulta();
            form.Show();
        }

        private void btnHistorialConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmHistorialYConsultaRepollo();
            form.Show();
        }
    }
}
