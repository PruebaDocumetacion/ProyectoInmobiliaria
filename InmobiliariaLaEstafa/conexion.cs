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
        private string servidor = "";
        private string puerto = "3306";
        private string bd = "brproyecto";
        private string usuario = "root";
        private string pass = "DesarrolloSoftware";

        public MySqlConnection con;

        public String Ser
        {
            get { return servidor; }
            set { servidor = value; }
        }

        public Conexion()
        {
            con = new MySqlConnection(string.Format("server= {0}; database= {1} ; user= {2} ; pwd= {3}; SslMode=none", servidor, bd, usuario, pass));
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
