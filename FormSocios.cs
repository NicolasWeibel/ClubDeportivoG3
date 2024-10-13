using ClubDeportivoG3.Datos;
using ClubDeportivoG3.Entidades;
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
    public partial class FormSocios : Form
    {
        public FormSocios()
        {
            InitializeComponent();
        }

        private void FormSocios_Load(object sender, EventArgs e)
        {
            cargarSocios(); // Cargar los socios cuando se carga el formulario
        }

        private void cargarSocios()
        {
            // Aquí llamas a un método que obtiene todos los socios desde la base de datos
            List<Socio> listaSocios = obtenerSocios();
            dataGridViewSocios.DataSource = listaSocios; // Mostrar la lista de socios en un DataGridView
        }

        // Método para obtener la lista de socios desde la base de datos
        private List<Socio> obtenerSocios()
        {
            List<Socio> listaSocios = new List<Socio>();

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT s.id_socio, s.id_cliente, s.carnet_entregado, s.cuota_mensual, s.estado_pago, c.Nombre AS NombreCliente, c.Apellido AS ApellidoCliente, c.DNI AS DniCliente, c.Mail AS MailCliente, c.Telefono AS TelefonoCliente FROM Socio s INNER JOIN Cliente c ON s.id_cliente = c.id_cliente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Socio socio = new Socio(
                                    reader.GetString("NombreCliente"),
                                    reader.GetString("ApellidoCliente"),
                                    reader.GetString("DniCliente"),
                                    reader.GetString("MailCliente"),
                                    reader.GetString("TelefonoCliente"),
                                    true, // Puedes ajustar este valor según tu lógica
                                    reader.GetInt32("id_socio"),
                                    reader.GetBoolean("carnet_entregado"),
                                    reader.GetDecimal("cuota_mensual"),
                                    reader.GetBoolean("estado_pago")
                                );
                                listaSocios.Add(socio);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaSocios; // Retorna la lista de socios
        }



        private void btnAgregarSocio_Click_1(object sender, EventArgs e)
        {
            // Aquí puedes abrir otro formulario para agregar un socio
            FormAgregarSocios agregarSocioForm = new FormAgregarSocios();
            agregarSocioForm.ShowDialog();
            cargarSocios(); // Refrescar la lista de socios después de agregar uno nuevo
        }
        
        private void btnModificarSocio_Click_1(object sender, EventArgs e)
        {

        }

        private void btnEliminarSocio_Click_1(object sender, EventArgs e)
        {

        }

        private void lblListaSocios_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewSocios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

