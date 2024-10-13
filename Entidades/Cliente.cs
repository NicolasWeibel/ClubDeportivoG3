using ClubDeportivoG3.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoG3.Entidades
{
    internal class Cliente
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string mail;
        private string telefono;
        private bool aptoFisico;

        public Cliente(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.mail = mail;
            this.telefono = telefono;
            this.aptoFisico = aptoFisico;
        }

        public string Nombre => nombre; // Propiedad de solo lectura para Nombre
        public string Apellido => apellido; // Propiedad de solo lectura para Apellido
        public string DNI => dni; // Propiedad de solo lectura para DNI
        public string Mail => mail; // Propiedad de solo lectura para Mail
        public string Telefono => telefono; // Propiedad de solo lectura para Telefono
        public bool AptoFisico => aptoFisico; // Propiedad de solo lectura para AptoFisico

        public virtual void DarAlta()
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Cliente (Nombre, Apellido, DNI, Mail, Telefono, Apto_Fisico) VALUES (@Nombre, @Apellido, @DNI, @Mail, @Telefono, @AptoFisico)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", this.nombre);
                        cmd.Parameters.AddWithValue("@Apellido", this.apellido);
                        cmd.Parameters.AddWithValue("@DNI", this.dni);
                        cmd.Parameters.AddWithValue("@Mail", this.mail);
                        cmd.Parameters.AddWithValue("@Telefono", this.telefono);
                        cmd.Parameters.AddWithValue("@AptoFisico", this.aptoFisico);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al dar de alta al cliente: " + ex.Message);
            }
        }
    

        public virtual void DarBaja()
        {
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    // Supongamos que tienes un campo "Estado" que indica si el cliente está activo o no
                    string query = "UPDATE Cliente SET Estado = 'Inactivo' WHERE DNI = @DNI"; // o usar un ID si lo prefieres

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@DNI", this.dni); // Suponiendo que usas DNI para identificar clientes

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                MessageBox.Show("Error al dar de baja al cliente: " + ex.Message);
            }
        }

        public bool PresentaApto()
        {
            return aptoFisico;
        }
    }
}