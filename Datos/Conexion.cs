using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;

namespace ClubDeportivoG3.Datos
{
    internal class Conexion
    {
        private static Conexion? _instancia = null;

        private readonly string baseDatos = "baseusuarios";
        private readonly string servidor = "localhost";
        private readonly string puerto = "3306";
        private readonly string usuario = "root";
        private readonly string clave = "root";

        // Constructor privado para evitar instanciación externa
        private Conexion() { }

        // Método para obtener la instancia única
        public static Conexion getInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Conexion();
            }
            return _instancia;
        }

        // Método para crear la conexión
        public MySqlConnection CrearConexion()
        {
            string cadenaConexion = $"Server={servidor};Port={puerto};Database={baseDatos};User Id={usuario};Password={clave};";
            return new MySqlConnection(cadenaConexion);
        }
    }
}
