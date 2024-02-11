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
    public partial class frmBienvenidos : Form
    {
        public frmBienvenidos()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenu();
            form.Show();
        }
    }
}
