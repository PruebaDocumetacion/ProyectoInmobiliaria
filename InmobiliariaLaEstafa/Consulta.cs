using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conexion
{
    public class Consulta
    {
        public string IdPago { get; set; }
        public string IdContrato { get; set; }        
        public string NombreCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string TipoInmueble { get; set; }
        public string DescripcionInmueble { get; set; }
        public int CuotasPago { get; set; }
        public double ValorCuota { get; set; } 
        public double CuotasPagadas { get; set; }
        public double CuotasPendientes { get; set; }
        public double MoraPago { get; set; }
        public string FechaPago { get; set; }

        public Consulta() { }

        public Consulta(string pIdpago, string pIdcontrato, string pnombrec,string pdireccionc,string ptipoi,string pdescripcioni,int pcuotas ,double pvalorcuota, double pcuotapagado, double pcuotaspendiente, double pMora, string pFecha)
        {
            this.IdPago = pIdpago;
            this.IdContrato = pIdcontrato;
            this.NombreCliente = pnombrec;
            this.DireccionCliente = pdireccionc;
            this.TipoInmueble = ptipoi;
            this.DescripcionInmueble = pdescripcioni;
            this.CuotasPago = pcuotas;
            this.CuotasPagadas = pcuotapagado;
            this.CuotasPendientes = pcuotaspendiente;
            this.MoraPago = pMora;            
            this.FechaPago = pFecha;
        }
      
    }
}
