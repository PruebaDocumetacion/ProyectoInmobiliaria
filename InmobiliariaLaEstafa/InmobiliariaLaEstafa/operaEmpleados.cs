using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaEmpleados
    {

        // lo que hace esta clase es la agregar modificacion, eliminacion y busqueda de datos que se llaman en los modulos respectivos
        public static int agregarempleado(MySqlConnection conexion, Empleados cli)
        {
            int retorno = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Empleado (idEmpleado, nombreEmpleado, telefonoEmpleado, correoEmpleado, direccionEmpleado) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}'); ", cli.Id, cli.Nombre, cli.Telefono, cli.Correo, cli.Direccion);
            MySqlCommand comando = new MySqlCommand(sql1, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int modificarempleado(MySqlConnection conexion, Empleados clien)
        {
            int retorno1 = 0;
            string sql = string.Format("Update brproyecto.Empleado set nombreEmpleado='{0}', telefonoEmpleado='{1}', " +
                "correoEmpleado='{2}', direccionEmpleado='{3}' where idEmpleado='{4}';", clien.Nombre, clien.Telefono, clien.Correo, clien.Direccion, clien.Id);
            MySqlCommand comando1 = new MySqlCommand(sql, conexion);
            retorno1 = comando1.ExecuteNonQuery();
            return retorno1;
        }

        public static int eliminarempleado(MySqlConnection conexion, Empleados clien)
        {
            int retorno2 = 0;
            string sql = string.Format("Delete from brproyecto.Empleado where idEmpleado='{0}'", clien.Id);
            MySqlCommand comando2 = new MySqlCommand(sql, conexion);
            retorno2 = comando2.ExecuteNonQuery();
            return retorno2;
        }

        public static List<Empleados> Buscar(MySqlConnection con)
        {
            List<Empleados> _lista = new List<Empleados>();
            string sql = "SELECT * FROM Empleado;";
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Empleados pEmpleado = new Empleados();
                pEmpleado.Id = _reader.GetString(0);
                pEmpleado.Nombre = _reader.GetString(1);
                pEmpleado.Telefono = _reader.GetString(2);
                pEmpleado.Correo = _reader.GetString(3);
            
                pEmpleado.Direccion = _reader.GetString(4);
                _lista.Add(pEmpleado);
            }

            return _lista;
        }


        public static List<Empleados> Buscarparametro(string Id, string Nombre, MySqlConnection con)
        {
            List<Empleados> _lista = new List<Empleados>();
            string sql = string.Format("SELECT IdEmpleado, nombreEmpleado, telefonoEmpleado, correoEmpleado, direccionEmpleado FROM Empleado  where idEmpleado ='{0}' or nombreEmpleado ='{1}' ", Id, Nombre);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Empleados pEmpleado = new Empleados();
                pEmpleado.Id = _reader.GetString(0);
                pEmpleado.Nombre = _reader.GetString(1);
                pEmpleado.Telefono = _reader.GetString(2);
                pEmpleado.Correo = _reader.GetString(3);
                pEmpleado.Direccion = _reader.GetString(4);


                _lista.Add(pEmpleado);
            }

            return _lista;
        }



        public static Empleados Buscarparametro1(string Id, MySqlConnection con)
        {

            Empleados pEmpleado = new Empleados();
            string sql = string.Format("SELECT IdEmpleado, nombreEmpleado, telefonoEmpleado, correoEmpleado, direccionEmpleado FROM Empleado  where idEmpleado ='{0}' ", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pEmpleado.Id = _reader.GetString(0);
                pEmpleado.Nombre = _reader.GetString(1);
                pEmpleado.Telefono = _reader.GetString(2);
                pEmpleado.Correo = _reader.GetString(3);
                pEmpleado.Direccion = _reader.GetString(4);

            }

            return pEmpleado;
        }
    }
}
