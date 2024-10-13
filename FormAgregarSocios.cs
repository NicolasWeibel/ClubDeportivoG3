using ClubDeportivoG3.Datos;
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
    public partial class FormAgregarSocios : Form
    {
        public FormAgregarSocios()
        {
            InitializeComponent();
        }


        private void FormAgregarSocios_Load(object sender, EventArgs e)
        {


        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string dni = txtDNI.Text;
            string mail = txtMail.Text;
            string telefono = txtTelefono.Text;
            bool aptoFisico = chkAptoFisico.Checked;
            decimal cuotaMensual = nudCuotaMensual.Value;
            bool carnetEntregado = false; 
            bool estadoPago = false; 

            // Validación simple
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni) || string.IsNullOrEmpty(mail) || string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Por favor complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Llamar al procedimiento almacenado para agregar el socio
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand("AgregarSocio", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Asignar parámetros al procedimiento almacenado
                        cmd.Parameters.AddWithValue("@p_nombre", nombre);
                        cmd.Parameters.AddWithValue("@p_apellido", apellido);
                        cmd.Parameters.AddWithValue("@p_dni", dni);
                        cmd.Parameters.AddWithValue("@p_mail", mail);
                        cmd.Parameters.AddWithValue("@p_telefono", telefono);
                        cmd.Parameters.AddWithValue("@p_apto_fisico", aptoFisico);
                        cmd.Parameters.AddWithValue("@p_cuota_mensual", cuotaMensual);
                        cmd.Parameters.AddWithValue("@p_carnet_entregado", carnetEntregado); 
                        cmd.Parameters.AddWithValue("@p_estado_pago", estadoPago); 


                        // Ejecutar el comando
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Socio agregado con éxito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el socio: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}
