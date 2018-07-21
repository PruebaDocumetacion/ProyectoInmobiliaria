using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    // establecer conexion con la base de datos
    public class Conexion
    {
        private string servidor = "127.0.0.1";
        private string puerto = "3306";
        private string bd = "brproyecto";
        private string usuario = "root";
        private string pass = "DesarrolloSoftware";

        public MySqlConnection con;

        public Conexion()
        {
            con = new MySqlConnection(string.Format("server= {0} ; port= {1} ; database= {2} ; user= {3} ; pwd= {4}", servidor, puerto, bd, usuario, pass));
        }

        public bool abrirconexion()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool cerrarconexion()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

    }
}
