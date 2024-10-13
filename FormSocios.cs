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
            List<Socio> listaSocios = Socio.ListarSocios(); // Utiliza el método estático
            dataGridViewSocios.DataSource = listaSocios; // Mostrar la lista de socios en un DataGridView
        }





        private void btnAgregarSocio_Click_1(object sender, EventArgs e)
        {
            // Abre el formulario para agregar un socio
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

