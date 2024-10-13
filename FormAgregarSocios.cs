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
            // Crea un nuevo objeto Socio con los datos del formulario
            Socio nuevoSocio = new Socio(
                txtNombre.Text,
                txtApellido.Text,
                txtDNI.Text,
                txtMail.Text,
                txtTelefono.Text,
                true, // o ajusta según sea necesario
                0, // Este ID se asignará en la base de datos
                chkCarnet.Checked,
                nudCuotaMensual.Value, // Suponiendo que tienes un NumericUpDown
                false // Estado de pago inicial
            );

            // Llama al método de alta del socio
            nuevoSocio.DarAlta();

            // Cierra el formulario
            this.Close();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtMail.Clear();
            txtTelefono.Clear();
            chkAptoFisico.Checked = false;
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); // Cerrar el formulario
        }



    }
}
