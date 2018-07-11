using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{

    public class Clientes:Inmuebles
    {
        Conexion conexion;
        
        public string IdC { get; set; }
        public string NombreC { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Oficio { get; set; }
        public string DireccionC { get; set; }

        public Clientes() { }

        public Clientes(string pId, string pNombre,  string pTelefono, string pCorreo , string pOficio, string pDireccion)
        {
            this.IdC = pId;
            this.NombreC = pNombre;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.Oficio = pOficio;
            this.DireccionC = pDireccion;
        }

        public void Agregar()
        {
            
            int retorno = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Cliente (idCliente, nombreCliente, telefonoCliente, correoCliente," +
                " oficioCliente, direccionCliente) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}'); ", IdC, NombreC, Telefono, Correo, Oficio, DireccionC);
            try
            {
                conexion = new Conexion();
                conexion.abrirconexion();
                MySqlCommand comando = new MySqlCommand(sql1, conexion.con);
                retorno = comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {

                throw ex;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }

        public static List<Clientes> listarTodos()
        {
            Conexion conexion = new Conexion();
            List<Clientes> _lista = new List<Clientes>();
            try
            { 
                conexion.abrirconexion();
                
                string sql = "SELECT * FROM Cliente;";
                MySqlCommand _comando = new MySqlCommand(sql, conexion.con);
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
            }
            catch(MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.cerrarconexion();
            }

            return _lista;
        }

    }


}
