using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    //Clase empleados con sus campos respectivos    
    public class Empleados
    {
        Conexion conexion;
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }

        public Empleados () { }

        public Empleados(string pId, string pNombre, string pTelefono, string pCorreo, string pDireccion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.Direccion = pDireccion;
        }
        public void Agregar()
        {

            int retorno = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Empleado (idEmpleado, nombreEmpleado, telefonoEmpleado, correoEmpleado, direccionEmpleado) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}'); ", Id, Nombre, Telefono, Correo, Direccion);
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
    }
}
