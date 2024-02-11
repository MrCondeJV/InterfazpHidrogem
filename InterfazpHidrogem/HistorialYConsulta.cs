using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace InterfazpHidrogem
{
    public partial class frmHistorialYConsulta : Form
    {
        MySqlConnection myCon;
        public frmHistorialYConsulta()
        {
            InitializeComponent();
            conectar();
            llenarTabla();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void HistorialYConsulta_Load(object sender, EventArgs e)
        {

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

        private void llenarTabla()
        {
            String query = "select estudianteN,sustanciaN,tipoSustanciaN,phN,observacionN from sustanciasregistrosnormales;";
            MySqlCommand comandoDB = new MySqlCommand(query, myCon);
            comandoDB.CommandTimeout = 60;
            MySqlDataReader reader;
            try
            {
                reader = comandoDB.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgvTablaHistorial.Rows.Add();
                        dgvTablaHistorial.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvTablaHistorial.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvTablaHistorial.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvTablaHistorial.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgvTablaHistorial.Rows[n].Cells[4].Value = reader.GetString(4);

                        // MessageBox.Show(reader.GetString(0));
                    }
                }
                else
                {
                    Console.WriteLine("No hay trabajadores");
                }
                reader.Close();
            }
            catch (Exception error)
            {
                Console.WriteLine(error.ToString());
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenuHistorial();
            form.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String where = "where 1=1";
            if (txtBuscarSustancia.Text != "")
            {
                where = where + " and estudianteN like'%" + txtBuscarSustancia.Text + "%' ";
            }
          

            String query = "select estudianteN,sustanciaN,tipoSustanciaN,pHN,observacionN from sustanciasregistrosnormales " + where;
            MySqlCommand comandoBD = new MySqlCommand(query, myCon);
            comandoBD.CommandTimeout = 60;
            MySqlDataReader reader;
            dgvTablaHistorial.Rows.Clear();
            dgvTablaHistorial.Refresh();
            try
            {
                reader = comandoBD.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int n = dgvTablaHistorial.Rows.Add();
                        dgvTablaHistorial.Rows[n].Cells[0].Value = reader.GetString(0);
                        dgvTablaHistorial.Rows[n].Cells[1].Value = reader.GetString(1);
                        dgvTablaHistorial.Rows[n].Cells[2].Value = reader.GetString(2);
                        dgvTablaHistorial.Rows[n].Cells[3].Value = reader.GetString(3);
                        dgvTablaHistorial.Rows[n].Cells[4].Value = reader.GetString(4);
                       
                    }
                }
                else
                {
                    Console.WriteLine("NO hay trabajadores");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmGraficas();
            form.Show();
        }

        private void dgvTablaHistorial_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
