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
        private List<Socio> listaSocios;

        public FormSocios()
        {
            InitializeComponent();
            CargarSocios();
        }

        private void CargarSocios()
        {
            dataGridViewSocios.DataSource = null; // Limpia el DataGridView
            var socios = Socio.ListarSocios();
            dataGridViewSocios.DataSource = socios;
        }

        private void btnAgregarSocio_Click_1(object sender, EventArgs e)
        {
            // Abre el formulario para agregar un socio
            FormAgregarSocios agregarSocioForm = new FormAgregarSocios();
            agregarSocioForm.ShowDialog();

            // Después de cerrar el formulario de agregar, recarga la lista de socios
            CargarSocios();
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

        private void FormSocios_Load(object sender, EventArgs e)
        {

        }
    }
}

