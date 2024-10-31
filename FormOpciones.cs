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
    public partial class OpcionesForm : Form
    {
        public string NombreUsuario { get; set; }  // Propiedad para el nombre del usuario
        public OpcionesForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = $"Usuario: {NombreUsuario}"; // Establece el texto del Label con el nombre del usuario al cargar el formulario

        }
       

        private void btnGestionNoSocios_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Para cerrar el form. Volvería al Login
        }

        private void btnGestionSocios_Click_1(object sender, EventArgs e)
        {
            FormSocios gestionSociosForm = new FormSocios();
            gestionSociosForm.ShowDialog();  // Mostrar el formulario de gestión de socios
        }
    }
}
