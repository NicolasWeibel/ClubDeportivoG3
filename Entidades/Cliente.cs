using ClubDeportivoG3.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

        // Propiedad de solo lectura para Nombre. Solo puede obtenerlo pero no modificarlo.

        public string Nombre
        {
            get { return nombre; }
        }
        // Propiedad de solo lectura para Apellido. Solo puede obtenerlo pero no modificarlo.
        public string Apellido 
        {
            get { return apellido; }
        }
        // Propiedad de solo lectura para DNI. Solo puede obtenerlo pero no modificarlo.
        public string DNI
        {
            get { return dni; }
        }
        // Propiedad de solo lectura para Mail. Solo puede obtenerlo pero no modificarlo.
        public string Mail
        {
            get { return mail; }
        }
        // Propiedad de solo lectura para Telefono. Solo puede obtenerlo pero no modificarlo.
        public string Telefono
        {
            get { return telefono; }
        }
        // Propiedad de solo lectura para AptoFisico. Solo puede obtenerlo pero no modificarlo.
        public bool AptoFisico
        {
            get { return aptoFisico; }
        }

        public virtual void DarAlta()
        {
            try
            {
                // Se crea una conexión a la base de datos usando la instancia de conexión
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open(); // Se abre la conexión a la base de datos

                    // Se define la consulta SQL para insertar un nuevo cliente
                    string query = "INSERT INTO Cliente (Nombre, Apellido, DNI, Mail, Telefono, Apto_Fisico) VALUES (@Nombre, @Apellido, @DNI, @Mail, @Telefono, @AptoFisico)";
                    
                    // Se prepara el comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Se añaden los valores de las propiedades del cliente a los parámetros de la consulta
                        cmd.Parameters.AddWithValue("@Nombre", this.nombre); // Nombre del cliente
                        cmd.Parameters.AddWithValue("@Apellido", this.apellido); // Apellido del cliente
                        cmd.Parameters.AddWithValue("@DNI", this.dni); // DNI del cliente
                        cmd.Parameters.AddWithValue("@Mail", this.mail); // Correo electrónico del cliente
                        cmd.Parameters.AddWithValue("@Telefono", this.telefono); // Teléfono del cliente
                        cmd.Parameters.AddWithValue("@AptoFisico", this.aptoFisico); // Estado de aptitud física del cliente
                        
                        // Se ejecuta la consulta para insertar el cliente en la base de datos
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


        public virtual void DarBaja(int idCliente)
        {
            try
            {

                // Se crea una conexión a la base de datos usando la instancia de conexión
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open(); // Se abre la conexión a la base de datos

                    // Se define la consulta SQL para eliminar un cliente por su ID
                    string query = "DELETE FROM Cliente WHERE id_cliente = @id_cliente";

                    // Se prepara el comando con la consulta y la conexión
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente); // Se añade el ID del cliente a eliminar como parámetro de la consulta
                        cmd.ExecuteNonQuery(); // Se ejecuta la consulta para eliminar el cliente de la base de datos
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el cliente: " + ex.Message);
            }
        }

        public bool PresentaApto()
        {
            return aptoFisico;
        }
    }
}