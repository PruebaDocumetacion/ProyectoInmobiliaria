using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{

    public class Clientes:Inmuebles
    {

        
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
    }


}
