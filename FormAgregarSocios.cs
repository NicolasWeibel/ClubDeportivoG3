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
using System.Text.RegularExpressions;
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
        private bool EsEmailValido(string email)
        {
            // Expresión regular para validar el formato de un correo electrónico
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            Regex regex = new Regex(patronEmail);
            return regex.IsMatch(email);
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Verifica que todos los campos estén llenos antes de continuar
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text) ||
                string.IsNullOrWhiteSpace(txtMail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.", "Campo incompleto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si hay campos vacíos
            }

            // Validar el formato del correo electrónico
            if (!EsEmailValido(txtMail.Text))
            {
                MessageBox.Show("Por favor, ingrese un correo electrónico válido.", "Formato de correo inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salimos del método si el formato no es válido
            }

            // Crea un nuevo socio con los datos del formulario
            Socio nuevoSocio = new Socio(
                                     txtNombre.Text,
                                     txtApellido.Text,
                                     txtDNI.Text,
                                     txtMail.Text,
                                     txtTelefono.Text,
                                     chkAptoFisico.Checked, // Asegúrate de que estás utilizando Checked
                                     0,
                                     chkCarnetEntrega.Checked, // Asegúrate de que estás utilizando Checked
                                     nudCuotaMensual.Value,
                                     false
                                          );

            // Llama al método para guardar el socio en la base de datos
            nuevoSocio.DarAlta();

            // Mostrar mensaje de confirmación
            MessageBox.Show("El socio ha sido guardado exitosamente.", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Cierra el formulario después de guardar y confirma el resultado
            this.DialogResult = DialogResult.OK;
            this.Close(); // Cierra el formulario
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }
    }
}
