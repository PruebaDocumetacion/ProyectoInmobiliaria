﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaClientes
    {
        public static int agregarcliente(MySqlConnection conexion, Clientes cli)
        {
            int retorno = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Cliente (idCliente, nombreCliente, telefonoCliente, correoCliente," +
                " oficioCliente, direccionCliente) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}'); ", cli.Id, cli.Nombre, cli.Telefono, cli.Correo, cli.Oficio, cli.Direccion);
            MySqlCommand comando = new MySqlCommand(sql1, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int modificarcliente(MySqlConnection conexion, Clientes clien)
        {
            int retorno1 = 0;
            string sql = string.Format("Update brproyecto.Cliente set nombreCliente='{0}', telefonoCliente='{1}', " +
                "correoCliente='{2}',oficioCliente ='{3}', direccionCliente='{4}' where idCliente='{5}';", clien.Nombre, clien.Telefono, clien.Correo, clien.Oficio, clien.Direccion, clien.Id);
            MySqlCommand comando1 = new MySqlCommand(sql, conexion);
            retorno1 = comando1.ExecuteNonQuery();
            return retorno1;
        }

        public static int eliminarcliente(MySqlConnection conexion, Clientes clien)
        {
            int retorno2 = 0;
            string sql = string.Format("Delete from brproyecto.Cliente where idCliente='{0}'", clien.Id);
            MySqlCommand comando2 = new MySqlCommand(sql, conexion);
            retorno2 = comando2.ExecuteNonQuery();
            return retorno2;
        }

        public static List<Clientes> Buscar(MySqlConnection con)
        {
            List<Clientes> _lista = new List<Clientes>();
            string sql = "SELECT * FROM Cliente;"; 
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Clientes pCliente = new Clientes();
                pCliente.Id = _reader.GetString(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Telefono = _reader.GetString(2);
                pCliente.Correo = _reader.GetString(3);
                pCliente.Oficio = _reader.GetString(4);
                pCliente.Direccion = _reader.GetString(5);
                _lista.Add(pCliente);
            }

            return _lista;
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
                pCliente.Id = _reader.GetString(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Telefono = _reader.GetString(2);
                pCliente.Correo = _reader.GetString(3);
                pCliente.Oficio = _reader.GetString(4);
                pCliente.Direccion = _reader.GetString(5);


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
                    pCliente.Id = _reader.GetString(0);
                    pCliente.Nombre = _reader.GetString(1);
                    pCliente.Telefono = _reader.GetString(2);
                    pCliente.Correo = _reader.GetString(3);
                    pCliente.Oficio = _reader.GetString(4);
                    pCliente.Direccion = _reader.GetString(5);

                }
            }
            catch
            {
                pCliente.Id = null;
            }

            return pCliente;
        }

    }
}
