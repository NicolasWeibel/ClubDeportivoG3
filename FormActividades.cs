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

namespace ClubDeportivoG3
{
    public partial class FormActividades : Form
    {
        // Cambia esta cadena con los datos de tu base de datos
        private string connectionString = "Server=localhost;Database=baseusuarios;User ID=root;Password=1234;";

        public FormActividades()
        {
            InitializeComponent();
            CargarActividades();
        }

        private void CargarActividades()
        {
            // Definir la consulta SQL
            string query = "SELECT * FROM Actividad";

            // Crear la conexión y el adaptador
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    // Configurar el DataGridView
                    dataGridView1.DataSource = dataTable;
                    // Ocultar la columna "idActividad"
                    if (dataGridView1.Columns.Contains("idActividad"))
                    {
                        dataGridView1.Columns["idActividad"].Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las actividades: " + ex.Message);
                }
            }
        }
        private void AgregarActividad(string nombre, string dia, string horario, decimal monto)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_AgregarActividad", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("nombreActividad", nombre);
                        cmd.Parameters.AddWithValue("diaActividad", dia);
                        cmd.Parameters.AddWithValue("horarioActividad", horario);
                        cmd.Parameters.AddWithValue("montoActividad", monto);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actividad agregada correctamente.");
                        CargarActividades(); // Refresca el DataGridView después de agregar
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar actividad: " + ex.Message);
                }
            }
        }


        private void EliminarActividad(int idActividad)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("sp_EliminarActividad", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("id", idActividad);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Actividad eliminada correctamente.");
                        CargarActividades(); // Refrescar el DataGridView después de eliminar
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar actividad: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Puedes agregar aquí lógica adicional si necesitas
        }

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string dia = txtDia.Text; // Ejemplo: "Lunes", "Martes", etc.
            string horario = txtHorario.Text;
            decimal monto = decimal.Parse(txtMonto.Text);

            AgregarActividad(nombre, dia, horario, monto);

          
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int idActividad = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["idActividad"].Value);
                EliminarActividad(idActividad);
            }
            else
            {
                MessageBox.Show("Selecciona una actividad para eliminar.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
