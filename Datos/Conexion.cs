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
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;

<<<<<<< HEAD
        private Conexion() {
=======
        private Conexion()
        {
>>>>>>> upload-main
            this.baseDatos = "baseusuarios";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
<<<<<<< HEAD
            this.clave = "1234";
         }
=======
            this.clave = "root";
        }
>>>>>>> upload-main

        // proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // instanciamos una conexion
            MySqlConnection? cadena = new MySqlConnection();
            // el bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this.servidor +
                ";port=" + this.puerto +
                ";username=" + this.usuario +
                ";password=" + this.clave +
                ";Database=" + this.baseDatos;

            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        // para evaluar la instancia de la conectividad
        public static Conexion getInstancia()
        {
            if (con == null) // quiere decir que la conexion esta cerrada
            {
                con = new Conexion(); // se crea una nueva
            }
            return con;
        }
    }
}