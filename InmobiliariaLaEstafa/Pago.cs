using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Pago:Ventas
    {
        public string Id { get; set; }
        public string Operacion { get; set; }
        public double Pagado { get; set; }
        public double Pendiente { get; set; }
        public double Mora { get; set; }
        public int CuotasP { get; set; }
        public string Fecha { get; set; }
        

        public Pago() { }

        public Pago(string pId,string pOperacion,int pPagado,int pPendiente, int pMora,int pCuotasP,string pFecha)
        {
            this.Id = pId;          
            this.Operacion = pOperacion;
            this.Pagado = pPagado;
            this.Pendiente = pPendiente;
            this.Mora = pMora;
            this.CuotasP = pCuotasP;
            this.Fecha = pFecha;
        }
    }
}
