using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{

    public class Clientes
    {

        
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string Oficio { get; set; }
        public string Direccion { get; set; }

        public Clientes() { }

        public Clientes(string pId, string pNombre,  string pTelefono, string pCorreo , string pOficio, string pDireccion)
        {
            this.Id = pId;
            this.Nombre = pNombre;
            this.Telefono = pTelefono;
            this.Correo = pCorreo;
            this.Oficio = pOficio;
            this.Direccion = pDireccion;
        }
    }


}
