using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaPagos:operaVenta
    {
        /*Agregar los pagos */
        public static int agregarPago(MySqlConnection conexion, Pago clie)
        {
            int retor = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Saldo (idNumeroPago,Operacion_idOperacion,saldoPagado,saldoPendiente,Mora,cuotasPendiente,fechaPago) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'); ", clie.Id, clie.Operacion, clie.Pagado, clie.Pendiente, clie.Mora, clie.CuotasP, clie.Fecha);
            MySqlCommand coman = new MySqlCommand(sql1, conexion);
            retor = coman.ExecuteNonQuery();
            return retor;
        }


        //
        public static Clientes BuscarparametroCli(string Id, MySqlConnection con)
        {
            Clientes pCliente = new Clientes();
            string sql = string.Format("SELECT IdCliente, nombreCliente,direccionCliente FROM Cliente  where idCliente ='{0}'  ", Id);
            MySqlCommand _comando3 = new MySqlCommand(sql, con);
            MySqlDataReader _reader3 = _comando3.ExecuteReader();
            while (_reader3.Read())
            {
                pCliente.Id = _reader3.GetString(0);
                pCliente.Nombre = _reader3.GetString(1);
                pCliente.Direccion = _reader3.GetString(2);
            }

            return pCliente;
        }
        public static Inmuebles Buscarinm(string Id, MySqlConnection con)
        {
            Inmuebles pInmueble = new Inmuebles();
            string sql = string.Format("SELECT idProp,descripcion,tipoInmueble FROM Inmueble where idProp ='{0}' ", Id);
            MySqlCommand _comando1 = new MySqlCommand(sql, con);
            MySqlDataReader _reader1 = _comando1.ExecuteReader();
            while (_reader1.Read())
            {
                pInmueble.Id = _reader1.GetString(0);
                pInmueble.Descripcion = _reader1.GetString(1);
                pInmueble.Tipo = _reader1.GetString(2);
              
            }

            return pInmueble;
        }
        public static Ventas BuscarContratos(string Id, MySqlConnection con)
        {
            Ventas _lista = new Ventas();
            string sql = string.Format("SELECT idOperacion,Cuotas,Prima,Total FROM Operacion where idOperacion ='{0}' ", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Ventas pInmueble = new Ventas();
                pInmueble.Id = _reader.GetString(0);
                pInmueble.Cuotas = _reader.GetInt16(1);
                pInmueble.prima = _reader.GetDouble(2);
                pInmueble.Total = _reader.GetDouble(3);
               
            }
            return _lista;
        }
        //Sin terminar
        public static List<Pago> BuscarContrato1(string Id,MySqlConnection con)
        {
            List<Pago> _lista1 = new List<Pago>();
            string sql = string.Format("SELECT idNumeroPago,Operacion_idOperacion,nombreCliente,direccionCliente,tipoInmueble,descripcion,Prima,saldoAcumulado,saldoPendiente,Mora Fecha FROM Saldo inner join Operacion join Clientes on Operacion_idOperacion ={0} ",Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Ventas pInmueble = new Ventas();
                Pago pInmueble1 = new Pago();
                Clientes clientes = new Clientes();
                pInmueble1.Operacion= _reader.GetString(0);
                pInmueble1.Id = _reader.GetString(1);
                clientes.Nombre = _reader.GetString(2);
                clientes.Direccion = _reader.GetString(3);
                pInmueble.Fecha = _reader.GetString(1);
                pInmueble.Observacion = _reader.GetString(2);
                pInmueble.Cliente = _reader.GetString(3);
                pInmueble.Empleado = _reader.GetString(4);
                pInmueble.Propiedad = _reader.GetString(5);
                pInmueble.Forma = _reader.GetString(6);
                pInmueble.Cuotas = _reader.GetInt16(7);
                pInmueble.prima = _reader.GetDouble(8);
                pInmueble.Descuento = _reader.GetDouble(9);
                pInmueble.Total = _reader.GetDouble(10);
                _lista1.Add(pInmueble1);
            }

            return _lista1;
        }
      
    }
}
