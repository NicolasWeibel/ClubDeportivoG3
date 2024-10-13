using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoG3.Datos
{
    internal class Usuarios
    {
        // Método que retorna una tabla con la información del login
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado; // Variable de tipo DataReader
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = null; // Inicializa la conexión

            try
            {
                // Crea la conexión
                sqlCon = Conexion.getInstancia().CrearConexion();

                // El comando almacena el nombre del procedimiento almacenado
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Define los parámetros que tiene el procedimiento almacenado
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;

                // Abre la conexión
                sqlCon.Open();

                // Ejecuta el comando y almacena el resultado
                resultado = comando.ExecuteReader();
                tabla.Load(resultado); // Carga la tabla con el resultado
                return tabla; // Retorna la tabla con los datos
            }
            catch (Exception ex)
            {
                throw; // Lanza la excepción
            }
            finally
            {
                // Cierra la conexión si está abierta
                if (sqlCon != null && sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}