using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace InterfazpHidrogem
{
    public partial class frmGraficas : Form
    {
        MySqlConnection myCon;

        public frmGraficas()
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
        private void Graficas_Load(object sender, EventArgs e)
        {

        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new frmMenu();
            form.Show();
        }
        private void dgrmBarras_Click (object sender, EventArgs e)
        {

        }
        private void btnMostrarGrafica(object sender, EventArgs e)
        {
            if (cmbGrado.SelectedItem != null && cmbEscala.SelectedItem != null)
            {
               if(cmbEscala.SelectedItem.ToString() == "Repollo")
                {
                    string grado = cmbGrado.SelectedItem.ToString();
                    string escala = cmbEscala.SelectedItem.ToString();

                    string query = "SELECT tipoSustancia, COUNT(*) AS Cantidad FROM sustanciasregistros WHERE grado_alumno = @grado AND escala = @escala GROUP BY tipoSustancia;";

                    using (MySqlCommand comandoDB = new MySqlCommand(query, myCon))
                    {
                        comandoDB.Parameters.AddWithValue("@grado", grado);
                        comandoDB.Parameters.AddWithValue("@escala", escala);

                        try
                        {
                            using (MySqlDataReader reader = comandoDB.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    chart1.Series.Clear();
                                    while (reader.Read())
                                    {
                                        if (reader["tipoSustancia"] != DBNull.Value)
                                        {
                                            string tipoSustancia = reader["tipoSustancia"].ToString();
                                            int cantidad = Convert.ToInt32(reader["Cantidad"]);

                                            // Agregar punto al gráfico
                                            chart1.Series.Add(tipoSustancia);
                                            chart1.Series[tipoSustancia].Points.AddXY(tipoSustancia, cantidad);
                                        }
                                        else
                                        {
                                            MessageBox.Show("La columna 'tipoSustancia' no está presente en los resultados de la consulta.");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron datos para mostrar en la gráfica.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                        }
                    }
                }else if(cmbEscala.SelectedItem.ToString() == "Normal")
                {
                    string grado = cmbGrado.SelectedItem.ToString();
                    string escala = cmbEscala.SelectedItem.ToString();

                    string query = "SELECT tipoSustanciaN, COUNT(*) AS Cantidad FROM sustanciasregistrosnormales WHERE grado_alumnoN = @grado AND escala = @escala GROUP BY tipoSustanciaN;";

                    using (MySqlCommand comandoDB = new MySqlCommand(query, myCon))
                    {
                        comandoDB.Parameters.AddWithValue("@grado", grado);
                        comandoDB.Parameters.AddWithValue("@escala", escala);

                        try
                        {
                            using (MySqlDataReader reader = comandoDB.ExecuteReader())
                            {
                                if (reader.HasRows)
                                {
                                    chart1.Series.Clear();
                                    while (reader.Read())
                                    {
                                        if (reader["tipoSustanciaN"] != DBNull.Value)
                                        {
                                            string tipoSustanciaN = reader["tipoSustanciaN"].ToString();
                                            int cantidad = Convert.ToInt32(reader["Cantidad"]);

                                            // Agregar punto al gráfico
                                            chart1.Series.Add(tipoSustanciaN);
                                            chart1.Series[tipoSustanciaN].Points.AddXY(tipoSustanciaN, cantidad);
                                        }
                                        else
                                        {
                                            MessageBox.Show("La columna 'tipoSustanciaN' no está presente en los resultados de la consulta.");
                                        }
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron datos para mostrar en la gráfica.");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona un grado y una escala antes de mostrar la información.");
            }
        }
    }
}