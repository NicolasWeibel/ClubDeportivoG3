﻿using ClubDeportivoG3.Datos;
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

        public string NombreUsuario { get; set; }
        public FormSocios()
        {
            InitializeComponent();
            CargarSocios();
            
        }
        

        private void CargarSocios()
        {
            dataGridViewSocios.DataSource = Socio.ListarSocios();
            
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
            // Verifica si se ha seleccionado una fila
            if (dataGridViewSocios.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un socio para dar de baja.", "Sin selección", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            DialogResult result = MessageBox.Show("¿Está seguro de que desea dar de baja a este socio?", "Confirmar baja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si el usuario selecciona que No, se cancela la operación
            if (result == DialogResult.No)
            {
                return;
            }

            // Obtiene el ID del cliente de la fila seleccionada y lo convierte a entero
            int idCliente = Convert.ToInt32(dataGridViewSocios.SelectedRows[0].Cells["Id"].Value); 

            // Creamos una instancia de Socio para usar el método DarBaja
            Socio socio = new Socio("nombre", "apellido", "dni", "mail", "telefono", true, idCliente, false, 0m, false); // Crea un nuevo objeto Socio con los datos proporcionados
            socio.DarBaja(idCliente); // Llama al método de baja pasando el id_cliente

            // Actualiza el DataGridView
            CargarSocios(); // Método para actualizar la lista
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

