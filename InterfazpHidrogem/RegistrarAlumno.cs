using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace InterfazpHidrogem
{
    public partial class frmRegistrarAlumno : Form
    {
        MySqlConnection myCon;

        String grado = "";
        String nombre = "";
        String identificacion = "";
        public frmRegistrarAlumno()
        {
            InitializeComponent();
            conectar();
        }

        private void conectar()
        {
            try
            {
                String server = "localhost";
                String database = "sensorph";
                String user = "root";
                String pwd = "";
                String cadenaConexion = "server=" + server + ";database=" + database + ";" + "Uid=" + user + ";pwd=" + pwd;
                myCon = new MySqlConnection(cadenaConexion);
                myCon.Open();

            }
            catch (Exception error)
            {
                MessageBox.Show("Error de Conexion: " + error);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMedicionYRegistro();
            form.Show();
        }

        private void bunifuButton22_Click(object sender, EventArgs e)
        {
            cmbGrado.Text = "";
            txtIdentificacion.Text = "";
            txtNombre.Text = "";

        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
         grado = cmbGrado.SelectedItem.ToString();
         nombre = txtNombre.Text;
         identificacion = txtIdentificacion.Text;

            String query = "";

            if (cmbGrado.SelectedItem.ToString() == "" || txtNombre.Text == "" || txtIdentificacion.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!");
            }
            else
            {
                if (MessageBox.Show("Quiere agregar el Estudiante?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    query = "insert into estudiantes " +
                       "(identificacion,nombre,grado) values " +
                       "('" + identificacion + "','" + nombre + "','" + grado + "')";
                    MySqlCommand comando = new MySqlCommand(query, myCon);
                    comando.CommandTimeout = 60;
                    MySqlDataReader reader;
                    try
                    {
                        reader = comando.ExecuteReader();
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    cmbGrado.Text = "";
                    txtIdentificacion.Text = "";
                    txtNombre.Text = "";

                    MessageBox.Show("Agregado con Exito!!");

                }


            }
        }
    }
}
