using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazpHidrogem
{
    public partial class frmTeoriaRelacional : Form
    {
        public frmTeoriaRelacional()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenu();
            form.Show();
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo { FileName = @"https://l.facebook.com/l.php?u=https%3A%2F%2Fphet.colorado.edu%2Fsims%2Fhtml%2Fph-scale%2Flatest%2Fph-scale_all.html%3Flocale%3Des%26fbclid%3DIwAR2lguo18qIxFV8SbPfMmFXp-FTTzCbXL8_coWENtxlb6CeCiLJtizgoAZ4&h=AT3P9h2z4UnhhkOcKx67zmy2x1bTl2klK8LHaisa74gGuwC98AXGL6JvZOSkgu6EqsN05PnShwTK5NltRtgTaV6_kajIaIJHbNYXa_vxVGnoJ0cO-hfn6QBtPC9O-S8siKfEpA", UseShellExecute = true });
        }
    }
}
