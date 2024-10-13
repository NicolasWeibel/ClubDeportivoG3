using ClubDeportivoG3.Datos;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Id => id; // Propiedad de solo lectura para Id
        public bool CarnetEntrega => carnetEntrega; // Propiedad de solo lectura para carnetEntrega
        public decimal CuotaMensual => cuotaMensual; // Propiedad de solo lectura para cuotaMensual
        public bool EstadoPago => estadoPago; // Propiedad de solo lectura para estadoPago

        public void AbonarCuota()
        {
            estadoPago = true;
            // Lógica para registrar el pago de la cuota
        }

        public void EntregarCarnet()
        {
            carnetEntrega = true;
            // Lógica para registrar que el carnet fue entregado
        }

        public static List<Socio> ListarSocios()
        {
            List<Socio> listaSocios = new List<Socio>();

            try
            {
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();
                    string query = "SELECT s.id_socio, s.id_cliente, s.carnet_entregado, s.cuota_mensual, s.estado_pago, c.Nombre AS NombreCliente, c.Apellido AS ApellidoCliente, c.DNI AS DniCliente, c.Mail AS MailCliente, c.Telefono AS TelefonoCliente FROM Socio s INNER JOIN Cliente c ON s.id_cliente = c.id_cliente";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Socio socio = new Socio(
                                    reader.GetString("NombreCliente"),
                                    reader.GetString("ApellidoCliente"),
                                    reader.GetString("DniCliente"),
                                    reader.GetString("MailCliente"),
                                    reader.GetString("TelefonoCliente"),
                                    true, // Ajusta según tu lógica
                                    reader.GetInt32("id_socio"),
                                    reader.GetBoolean("carnet_entregado"),
                                    reader.GetDecimal("cuota_mensual"),
                                    reader.GetBoolean("estado_pago")
                                );
                                listaSocios.Add(socio);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar los socios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return listaSocios; // Retorna la lista de socios
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
                        // Aquí necesitas obtener el ID del cliente que acabas de insertar
                        // Supongamos que tienes un método que obtiene el último ID insertado
                        int idCliente = ObtenerIdClientePorDNI(this.DNI); // Método ficticio

                        // Asigna los parámetros
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
                // Manejo de excepciones
                MessageBox.Show("Error al dar de alta al socio: " + ex.Message);
            }
        }

        // Método ficticio para obtener el ID del cliente
        private int ObtenerIdClientePorDNI(string dni)
        {
            // Lógica para obtener el ID del cliente en base al DNI
            // Retorna un entero
            return 1; // Placeholder, debes implementar la lógica
        }

        // Método ficticio para asignar el ID al socio
        private void SetId(int id)
        {
            this.id = id;
        }
    }
}