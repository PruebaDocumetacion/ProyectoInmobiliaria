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
            string sql1 = string.Format("INSERT INTO brproyecto.Saldo (idNumeroPago,Operacion_idOperacion,Numerofac,saldoPagado,saldoPendiente,Mora,cuotasPendiente,fechaPago) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'); ", clie.Id, clie.Operacion, clie.Factura,clie.Pagado, clie.Pendiente, clie.Mora, clie.CuotasP, clie.Fecha);
            MySqlCommand coman = new MySqlCommand(sql1, conexion);
            retor = coman.ExecuteNonQuery();
            return retor;
        }


        /*
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
        }*/
        //Sin terminar
        
        public static Pago Contrato1(string Id,MySqlConnection con)
        {
            Pago _lista1 = new Pago();
            string sql = string.Format("select idNumeroPago,Operacion_idOperacion,nombreCliente,direccionCliente,tipoInmueble,descripcion,cuotasPendiente,Prima,saldoPagado," +
                "saldoPendiente,Mora,fechaPago from brproyecto.operacion inner join brproyecto.saldo on(Operacion.idOperacion={0})" +
                "inner join brproyecto.cliente on(Operacion.Cliente_idCliente = Cliente.idCliente) "+ 
                "inner join brproyecto.inmueble on(operacion.Propiedad_idProp = inmueble.idProp);",Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
               
               _lista1.Id = _reader.GetString(0);
               _lista1.IdV = _reader.GetString(1);
                _lista1.NombreC= _reader.GetString(2);
                _lista1.DireccionC= _reader.GetString(3);
                _lista1.Tipo= _reader.GetString(4);
               _lista1.Descripcion= _reader.GetString(5);
               _lista1.CuotasP= _reader.GetInt16(6);
               _lista1.prima= _reader.GetDouble(7);
               _lista1.Pagado=  _reader.GetDouble(8);
               _lista1.Pendiente=  _reader.GetDouble(9);
               _lista1.Mora= _reader.GetDouble(10);
                _lista1.Fecha= _reader.GetString(11);

             
            }

            return _lista1;
        }
     
    }
}
