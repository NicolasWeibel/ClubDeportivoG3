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

        // Propiedades de solo lectura usando la sintaxis abreviada para getters
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

        public static List<Socio> ListarSocios() // Método estático para listar todos los socios
        {
            List<Socio> listaSocios = new List<Socio>(); // Creamos una lista para almacenar los socios

            // Abrimos una conexión a la base de datos
            using (MySqlConnection connection = Conexion.getInstancia().CrearConexion())
            {
                connection.Open();

                // Definimos la consulta SQL para obtener datos de socios y clientes
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

                // Preparamos el comando con la consulta y la conexión
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {

                    // Ejecutamos el comando y obtenemos un lector para leer los resultados
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        // Iteramos sobre cada fila de resultados
                        while (reader.Read())
                        {
                            // Obtenemos el ID del socio
                            int id = reader.GetInt32("id");

                            // Verificamos si el socio ya está en la lista usando su ID
                            var socioExistente = listaSocios.FirstOrDefault(s => s.Id == id); // var permite inferir el tipo de la variable automáticamente basado en el valor que se le asigna.

                            if (socioExistente == null) // Si no existe, lo creamos
                            {
                                
                                // Creamos un nuevo objeto Socio con los datos leídos
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
                                
                                // Agregamos el nuevo socio a la lista
                                listaSocios.Add(socio);
                            }
                        }
                    }
                }
            }
            return listaSocios; // Retornamos la lista de socios
        }

        public override void DarAlta()
        {
            // Primero, llama al método de la clase base para registrar al cliente (es como asegurarse de que el cliente ya está en la base de datos).
            base.DarAlta();

            // Luego, registra al socio en la base de datos
            try
            {
                // Abre una conexión a la base de datos.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Prepara la consulta SQL para insertar al socio.
                    string query = "INSERT INTO Socio (id_cliente, carnet_entregado, cuota_mensual, estado_pago) VALUES (@id_cliente, @carnet_entregado, @cuota_mensual, @estado_pago);";

                    // Crea el comando SQL con la consulta y la conexión.
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Obtiene el ID del cliente usando su DNI (no lo comprendo mucho pero si lo saco rompe todo)
                        int idCliente = ObtenerIdClientePorDNI(this.DNI); // Método ficticio

                        // Añadimos los parámetros necesarios para la consulta.
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente);
                        cmd.Parameters.AddWithValue("@carnet_entregado", carnetEntrega);
                        cmd.Parameters.AddWithValue("@cuota_mensual", cuotaMensual);
                        cmd.Parameters.AddWithValue("@estado_pago", estadoPago);


                        // Ejecutamos la consulta para insertar al socio en la base de datos.
                        cmd.ExecuteNonQuery();

                        // Obtiene el ID generado automáticamente por la base de datos al insertar el nuevo socio.
                        int idGenerado = (int)cmd.LastInsertedId; // "LastInsertedId" devuelve el último ID creado
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
                // Abre una conexión a la base de datos para realizar la eliminación.
                using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
                {
                    conn.Open();

                    // Prepara la consulta SQL para eliminar al socio basado en el ID del cliente.
                    string query = "DELETE FROM Socio WHERE id_cliente = @id_cliente";

                    // Crea el comando SQL con la consulta y la conexión.
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id_cliente", idCliente); // Añade el parámetro del ID del cliente a la consulta.
                        cmd.ExecuteNonQuery(); // Ejecuta la consulta para eliminar al socio de la base de datos.
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el socio: " + ex.Message);
            }

            // Luego, elimina al cliente (superclase)
            base.DarBaja(idCliente); // Aquí se llama al método de la clase base para eliminar el cliente correspondiente en la base de datos.
        }

        private int ObtenerIdClientePorDNI(string dni) // Este método obtiene el ID del cliente basado en su DNI. Dado que no pusimos un idCliente.
        {
            int idCliente = 0; // Inicializa el ID del cliente en 0.
            using (MySqlConnection conn = Conexion.getInstancia().CrearConexion())
            {
                conn.Open();                
                string query = "SELECT id_cliente FROM Cliente WHERE dni = @DNI"; // Prepara la consulta SQL para buscar el ID del cliente por su DNI.
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@DNI", dni); // Añade el parámetro del DNI a la consulta.
                    object result = cmd.ExecuteScalar(); // Ejecuta la consulta y obtiene el resultado.
                    if (result != null) // Si se encuentra un resultado, convierte el objeto a int.
                    {
                        idCliente = Convert.ToInt32(result);
                    }
                }
            }
            return idCliente; // Devuelve el ID del cliente encontrado.
        }

        private void SetId(int id) // Este método establece el ID del socio.
        {
            this.id = id; // Se asigna el ID al objeto Socio.
        }
    }
}
