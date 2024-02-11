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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void bunifuLabel5_Click(object sender, EventArgs e)
        {

        }

        private void btnHistorialConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenuHistorial();
            form.Show();
        }

        private void btnMedicionRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMedicionYRegistro();
            form.Show();
        }

        private void btnTeoriaRelacional_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmTeoriaRelacional();
            form.Show();
        }

        private void btnInformacion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmInformacion();
            form.Show();
        }
    }
}
