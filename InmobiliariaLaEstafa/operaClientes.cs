using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaClientes
    {

        // lo que hace esta clase es la modificacion, eliminacion y busqueda de datos que se llaman en los modulos respectivos
        public static int modificarcliente(MySqlConnection conexion, Clientes clien)
        {
            int retorno1 = 0;
            string sql = string.Format("Update brproyecto.Cliente set nombreCliente='{0}', telefonoCliente='{1}', " +
                "correoCliente='{2}',oficioCliente ='{3}', direccionCliente='{4}' where idCliente='{5}';", clien.NombreC, clien.Telefono, clien.Correo, clien.Oficio, clien.DireccionC, clien.IdC);
            MySqlCommand comando1 = new MySqlCommand(sql, conexion);
            retorno1 = comando1.ExecuteNonQuery();
            return retorno1;
        }

        public static int eliminarcliente(MySqlConnection conexion, Clientes clien)
        {
            int retorno2 = 0;
            string sql = string.Format("Delete from brproyecto.Cliente where idCliente='{0}'", clien.IdC);
            MySqlCommand comando2 = new MySqlCommand(sql, conexion);
            retorno2 = comando2.ExecuteNonQuery();
            return retorno2;
        }




        public static List<Clientes> Buscarparametro(string Id, string Nombre, MySqlConnection con)
        {
            List<Clientes> _lista = new List<Clientes>();
            string sql = string.Format("SELECT IdCliente, nombreCliente, telefonoCliente, correoCliente, oficioCliente, direccionCliente FROM Cliente  where idCliente ='{0}' or nombreCliente ='{1}' ", Id, Nombre);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientes pCliente = new Clientes();
                pCliente.IdC = _reader.GetString(0);
                pCliente.NombreC = _reader.GetString(1);
                pCliente.Telefono = _reader.GetString(2);
                pCliente.Correo = _reader.GetString(3);
                pCliente.Oficio = _reader.GetString(4);
                pCliente.DireccionC = _reader.GetString(5);


                _lista.Add(pCliente);
            }

            return _lista;
        }



        public static Clientes Buscarparametro1(string Id, MySqlConnection con)
        {
            Clientes pCliente = new Clientes();
            string sql = string.Format("SELECT IdCliente, nombreCliente, telefonoCliente, correoCliente, oficioCliente, direccionCliente FROM Cliente  where idCliente ='{0}'  ", Id);
            try
            {
                MySqlCommand _comando = new MySqlCommand(sql, con);
                MySqlDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    pCliente.IdC = _reader.GetString(0);
                    pCliente.NombreC = _reader.GetString(1);
                    pCliente.Telefono = _reader.GetString(2);
                    pCliente.Correo = _reader.GetString(3);
                    pCliente.Oficio = _reader.GetString(4);
                    pCliente.DireccionC = _reader.GetString(5);

                }
            }
            catch
            {
                pCliente.IdC = null;
            }

            return pCliente;
        }

        public static List<Clientes> Buscar(MySqlConnection con)
        {
            List<Clientes> _lista = new List<Clientes>();
            string sql = "SELECT * FROM brproyecto.cliente;";
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientes pEmpleado = new Clientes();
                pEmpleado.IdC = _reader.GetString(0);
                pEmpleado.NombreC = _reader.GetString(1);
                pEmpleado.Telefono = _reader.GetString(2);
                pEmpleado.Correo = _reader.GetString(3);
                pEmpleado.Oficio = _reader.GetString(4);
                pEmpleado.DireccionC = _reader.GetString(5);
                _lista.Add(pEmpleado);
            }

            return _lista;
        }
    }
}
