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
        public OpcionesForm()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSocios gestionSociosForm = new FormSocios();
            gestionSociosForm.ShowDialog();  // Mostrar el formulario de gestión de socios
        }

        private void btnGestionNoSocios_Click(object sender, EventArgs e)
        {

        }
    }
}
