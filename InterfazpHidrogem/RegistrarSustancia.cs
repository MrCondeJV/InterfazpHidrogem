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

namespace InterfazpHidrogem
{
    public partial class frmRegistrarSustancia : Form
    {
        MySqlConnection myCon;
        String nomEstudiante = "";
        String sustancia = "";
       
        String tipoSustancia = "";
        String ph = "";
        String observacion = "";
        String escalaSustancia = "";
        
        String nomEstudianteN = "";
        String sustanciaN = "";
        String tipoSustanciaN = "";
        String phN = "";
        String observacionN = "";

        public frmRegistrarSustancia()
        {
            InitializeComponent();
            conectar();
            llenarcomboNombresNormal();
            llenarcomboNombresRepollo();
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

        private void llenarcomboNombresRepollo()
        {
            String query = "select identificacion,nombre,grado from estudiantes;";
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
                       
                        cmbEstudiantes.Items.Add(reader.GetString(1));

                       

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
        private void llenarcomboNombresNormal()
        {
            String query = "select identificacion,nombre,grado from estudiantes;";
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

                       
                        cmbEstudianteList.Items.Add(reader.GetString(1));
                        
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmRegistrarSustancia_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardarSustancia_Click(object sender, EventArgs e)
        {
            nomEstudiante = cmbEstudiantes.Text;
            sustancia = txtSustancia.Text;
            tipoSustancia = cmbTipoSustancias.Text;
            ph = txtpH.Text;
            observacion = txtObservacion.Text;
            escalaSustancia = "repollo";

            String query = "";

            if (cmbEstudiantes.Text == "" || txtSustancia.Text == "" || cmbTipoSustancias.Text == "" || txtpH.Text == "" || txtObservacion.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!");
            }
            else
            {
                if (MessageBox.Show("Quiere agregar el Registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Obtener el grado del estudiante
                    string queryGrado = "SELECT grado FROM estudiantes WHERE nombre = '" + nomEstudiante + "'";
                    MySqlCommand comandoGrado = new MySqlCommand(queryGrado, myCon);
                    string grado_Repollo = comandoGrado.ExecuteScalar().ToString(); // Suponiendo que grado es un string


                    // Insertar el registro en la base de datos con el grado del estudiante seleccionado
                    query = "INSERT INTO sustanciasregistros " +
                            "(estudiante, grado_alumno,escala, sustancia, tipoSustancia, ph, observacion) VALUES " +
                            "('" + nomEstudiante + "','" + grado_Repollo + "','"+escalaSustancia+"','" + sustancia + "','" + tipoSustancia + "','" + ph + "','" + observacion + "')";

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

                    // Limpiar los campos después de agregar el registro
                    cmbEstudiantes.Text = "";
                    txtSustancia.Text = "";
                    txtpH.Text = "";
                    txtObservacion.Text = "";
                    cmbTipoSustancias.Text = "";
                    
                   
                    MessageBox.Show("Agregado con Exito!!");
                }
            }
        }

        private void btnGuardarSustanciaNormal(object sender, EventArgs e)
        {
           
            nomEstudianteN = cmbEstudianteList.Text;
            sustanciaN = txtSustanciaNormal.Text;
            tipoSustanciaN = cmbTipoSustanciaList.Text;
            phN = txtpHNormal.Text;
            observacionN = txtObservacionNromal.Text;
            escalaSustancia = "normal";
            String query = "";

            if (cmbEstudianteList.Text == "" || txtSustanciaNormal.Text == "" || cmbTipoSustanciaList.Text == "" || txtpHNormal.Text == "" || txtObservacionNromal.Text == "")
            {
                MessageBox.Show("Los campos no pueden estar vacios!!");
            }
            else
            {
                if (MessageBox.Show("Quiere agregar el Registro?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Obtener el grado del estudiante
                    string queryGrado = "SELECT grado FROM estudiantes WHERE nombre = '" + nomEstudianteN + "'";
                    MySqlCommand comandoGrado = new MySqlCommand(queryGrado, myCon);
                    string grado_Normal = comandoGrado.ExecuteScalar().ToString(); // Suponiendo que grado es un string

                    query = "insert into sustanciasregistrosnormales " +
                       "(estudianteN,grado_alumnoN,escala,sustanciaN,tipoSustanciaN,phN,observacionN) values " +
                       "('" + nomEstudianteN + "','"+grado_Normal+"','"+escalaSustancia+"','" + sustanciaN + "','" + tipoSustanciaN + "','" + phN + "','" + observacionN + "')";
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
                    cmbEstudianteList.Text = "";
                    txtSustanciaNormal.Text = "";
                    txtpHNormal.Text = "";
                    txtObservacionNromal.Text = "";
                    cmbTipoSustanciaList.Text = "";
                    
                    
                    MessageBox.Show("Agregado con Exito!!");

                }


            }
        }

        private void bunifuButton21_Click(object sender, EventArgs e)
        {
            cmbEstudianteList.Text = "";
            txtSustanciaNormal.Text = "";
            txtpHNormal.Text = "";
            txtObservacionNromal.Text = "";
            cmbTipoSustanciaList.Text = "";
        }

        private void bunifuButton22_Click_1(object sender, EventArgs e)
        {
            phN = txtpHNormal.Text;
            switch (phN)
            {
                case "0": pnColorSustancia.BackColor = Color.Red; break;
                case "1": pnColorSustancia.BackColor = Color.OrangeRed; break;
                case "2": pnColorSustancia.BackColor = Color.Gold; break;
                case "3": pnColorSustancia.BackColor = Color.Yellow; break;
                case "4": pnColorSustancia.BackColor = Color.YellowGreen; break;
                case "5": pnColorSustancia.BackColor = Color.Lime; break;
                case "6": pnColorSustancia.BackColor = Color.Green; break;
                case "7": pnColorSustancia.BackColor = Color.Green; break;
                case "8": pnColorSustancia.BackColor = Color.Green; break;
                case "9": pnColorSustancia.BackColor = Color.Aquamarine; break;
                case "10": pnColorSustancia.BackColor = Color.DodgerBlue; break;
                case "11": pnColorSustancia.BackColor = Color.Blue; break;
                case "12": pnColorSustancia.BackColor = Color.SlateBlue; break;
                case "13": pnColorSustancia.BackColor = Color.Indigo; break;
                case "14": pnColorSustancia.BackColor = Color.DarkSlateBlue; break;

                    /*case 0: pnColorPh.BackColor = Color.Red; break;
                case 1: pnColorPh.BackColor = Color.OrangeRed; break;
                case 2: pnColorPh.BackColor = Color.Gold; break;
                case 3: pnColorPh.BackColor = Color.Yellow; break;
                case 4: pnColorPh.BackColor = Color.YellowGreen; break;
                case 5: pnColorPh.BackColor = Color.Lime; break;
                case 6: pnColorPh.BackColor = Color.Green; break;
                case 7: pnColorPh.BackColor = Color.Green; break;
                case 8: pnColorPh.BackColor = Color.Green; break;
                case 9: pnColorPh.BackColor = Color.Aquamarine; break;
                case 10: pnColorPh.BackColor = Color.DodgerBlue; break;
                case 11: pnColorPh.BackColor = Color.Blue; break;
                case 12: pnColorPh.BackColor = Color.SlateBlue; break;
                case 13: pnColorPh.BackColor = Color.Indigo; break;
                case 14: pnColorPh.BackColor = Color.DarkSlateBlue; break;*/
            }
        }

        private void bunifuButton23_Click(object sender, EventArgs e)
        {
            ph = txtpH.Text;
            switch (ph)
            {
                case "0": pnColorSustanciaR.BackColor = Color.Red; break;
                case "1": pnColorSustanciaR.BackColor = Color.Red; break;
                case "2": pnColorSustanciaR.BackColor = Color.OrangeRed; break;
                case "3": pnColorSustanciaR.BackColor = Color.DeepPink; break;
                case "4": pnColorSustanciaR.BackColor = Color.Orchid; break;
                case "5": pnColorSustanciaR.BackColor = Color.MediumOrchid; break;
                case "6": pnColorSustanciaR.BackColor = Color.DarkViolet; break;
                case "7": pnColorSustanciaR.BackColor = Color.DarkSlateBlue; break;
                case "8": pnColorSustanciaR.BackColor = Color.Blue; break;
                case "9": pnColorSustanciaR.BackColor = Color.LightSeaGreen; break;
                case "10": pnColorSustanciaR.BackColor = Color.LimeGreen; break;
                case "11": pnColorSustanciaR.BackColor = Color.MediumSeaGreen; break;
                case "12": pnColorSustanciaR.BackColor = Color.Green; break;
                case "13": pnColorSustanciaR.BackColor = Color.YellowGreen; break;
                case "14": pnColorSustanciaR.BackColor = Color.Yellow; break;

                
            }
        }

        private void txtpH_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void tabPage1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}
