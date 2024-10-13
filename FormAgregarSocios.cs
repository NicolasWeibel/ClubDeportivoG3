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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtDNI.Text) ||
        string.IsNullOrWhiteSpace(txtMail.Text) ||
        string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si hay campos vacíos
            }
            // Verifica que todos los campos estén correctamente llenos

            Socio nuevoSocio = new Socio(
                                     txtNombre.Text,
                                     txtApellido.Text,
                                     txtDNI.Text,
                                     txtMail.Text,
                                     txtTelefono.Text,
                                     chkAptoFisico.Checked,
                                     0, // ID, puedes ajustar este valor según tu lógica
                                     chkCarnetEntrega.Checked,
                                     nudCuotaMensual.Value,
                                     false // Estado de pago inicial
                                          );

            // Llama al método para guardar el socio
            nuevoSocio.DarAlta();

            // Cierra el formulario después de guardar
            this.DialogResult = DialogResult.OK; // Establece el resultado del diálogo
            this.Close(); // Cierra el formulario
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }



    }
}
