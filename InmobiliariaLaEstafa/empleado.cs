using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    //Clase empleados con sus campos respectivos    
    public class Empleados
    {
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
    }
}
