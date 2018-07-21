using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    //ventas lleva el control de los contratos
    public class Ventas
    {
        public string IdV { get; set; }
        public string FechaV { get; set; }
        public string Observacion { get; set; }
        public string Cliente { get; set; }
        public string Empleado { get; set; }
        public string Propiedad { get; set; }
        public string Forma{ get; set; }
        public int Cuotas { get; set; }
        public double prima { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }
        

        public Ventas() { }

        public Ventas(string pId, string pFecha, string pObservacion, string pCliente, string pEmpleado, string pPropiedad, string pForma,int pCuotas, double pPrima, double pDescuento,double pTotal)
        {
            this.IdV = pId;
            this.FechaV = pFecha;
            this.Observacion = pObservacion;
            this.Cliente = pCliente;
            this.Empleado = pEmpleado;
            this.Propiedad = pPropiedad;
            this.Forma = pForma;
            this.Cuotas = pCuotas;
            this.prima = pPrima;
            this.Descuento = pDescuento;
            this.Total = pTotal;
        }
    }
}
