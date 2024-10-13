using ClubDeportivoG3.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ClubDeportivoG3.Entidades
{
    internal class Socio : Cliente
    {
        private int id;
        private bool carnetEntrega;
        private decimal cuotaMensual;
        private bool estadoPago;

        public Socio(string nombre, string apellido, string dni, string mail, string telefono, bool aptoFisico, int id, bool carnetEntrega, decimal cuotaMensual, bool estadoPago)
            : base(nombre, apellido, dni, mail, telefono, aptoFisico)
        {
            this.id = id;
            this.carnetEntrega = carnetEntrega;
            this.cuotaMensual = cuotaMensual;
            this.estadoPago = estadoPago;
        }

        public int Id => id;
        public bool CarnetEntrega => carnetEntrega;
        public decimal CuotaMensual => cuotaMensual;
        public bool EstadoPago => estadoPago;

        public void AbonarCuota()
        {
            estadoPago = true;
            // Después vemos esto
        }

        public void EntregarCarnet()
        {
            carnetEntrega = true;
            // Después vemos esto
        }

        public static List<Socio> ListarSocios()
        {
            List<Socio> listaSocios = new List<Socio>();
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();
                string query = @"
        SELECT 
            c.id_cliente AS id, 
            c.nombre, 
            c.apellido, 
            c.dni, 
            c.mail, 
            c.telefono, 
            s.carnet_entregado AS carnet, 
            s.cuota_mensual, 
            s.estado_pago AS estadoPago 
        FROM 
            Socio s 
        JOIN 
            Cliente c ON s.id_cliente = c.id_cliente;";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Obtener el ID del socio
                            int id = reader.GetInt32("id");

                            // Verifica si el socio ya existe en la lista por ID
                            var socioExistente = listaSocios.FirstOrDefault(s => s.Id == id);

                            if (socioExistente == null)
                            {
                                // Crear nuevo socio solo si no existe
                                Socio socio = new Socio(
                                    reader.GetString("nombre"),
                                    reader.GetString("apellido"),
                                    reader.GetString("dni"),
                                    reader.GetString("mail"),
                                    reader.GetString("telefono"),
                                    reader.GetBoolean("carnet"),
                                    id, // ID del cliente
                                    reader.GetBoolean("carnet"), // carnetEntrega
                                    reader.GetDecimal("cuota_mensual"),
                                    reader.GetBoolean("estadoPago")
                                );

                                listaSocios.Add(socio);
                            }
                        }
                    }
                }
            }
            return listaSocios;
        }

        public override void DarAlta()
        {
            // Primero, llama al método de la clase base para registrar el cliente
            base.DarAlta();

            // Luego, registra al socio
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string query = "INSERT INTO Socio (id_cliente, carnet_entregado, cuota_mensual, estado_pago) VALUES (@id_cliente, @carnet_entregado, @cuota_mensual, @estado_pago);";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        int idCliente = ObtenerIdClientePorDNI(this.DNI); // Método ficticio

                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmd.Parameters.AddWithValue("@carnet_entregado", carnetEntrega);
                        cmd.Parameters.AddWithValue("@cuota_mensual", cuotaMensual);
                        cmd.Parameters.AddWithValue("@estado_pago", estadoPago);

                        cmd.ExecuteNonQuery();

                        // Obtener el ID generado
                        int idGenerado = (int)cmd.LastInsertedId;
                        SetId(idGenerado); // Asigna el ID al objeto Socio
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al dar de alta al socio: {ex.Message}");
            }
        }
        public override void DarBaja(int idCliente)
        {
            // Primero, elimina al socio en la tabla Socio
            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string query = "DELETE FROM Socio WHERE id_cliente = @id_cliente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el socio: " + ex.Message);
            }

            // Luego, elimina al cliente (superclase)
            base.DarBaja(idCliente); // Elimina el cliente correspondiente en la base de datos
        }

        private int ObtenerIdClientePorDNI(string dni)
        {
            int idCliente = 0;
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();
                string query = "SELECT id_cliente FROM Cliente WHERE dni = @DNI";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni);
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        idCliente = Convert.ToInt32(result);
                    }
                }
            }
            return idCliente;
        }

        private void SetId(int id)
        {
            this.id = id;
        }
    }
}
