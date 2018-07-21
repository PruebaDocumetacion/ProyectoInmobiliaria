using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaPagos
    {
        /*Agregar los pagos */
        public static int agregarPago(MySqlConnection conexion, Pago clie)
        {
            int retor = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Saldo (Operacion_idOperacion,Numerofac,saldoPagado,saldoPendiente,Mora,cuotasPendiente,fechaPago) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'); ", clie.Operacion, clie.Factura,clie.Pagado, clie.Pendiente, clie.Mora, clie.CuotasP, clie.Fecha);
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
        }*/
        ///
        public static List<Consulta> BuscarContratos(string Id, MySqlConnection con)
        {
            List<Consulta> _lista1 = new List<Consulta>();
           // string sql = string.Format("SELECT * FROM brproyecto.Saldo where idPago ='{0}' ", Id);
            string sql = string.Format("select Operacion_idOperacion, idNumeroPago,nombreCliente, direccionCliente, tipoInmueble, descripcion, cuotasPendiente, Prima, saldoPagado, " +
                "saldoPendiente,Mora,fechaPago from brproyecto.operacion inner join brproyecto.saldo on(Operacion.idOperacion={0})" +
                "inner join brproyecto.cliente on(Operacion.Cliente_idCliente = Cliente.idCliente) " +
                "inner join brproyecto.inmueble on(operacion.Propiedad_idProp = inmueble.idProp);", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Consulta _lista = new Consulta
                {
                    IdContrato = _reader.GetString(0),
                    numeroFac = _reader.GetInt16(1),
                    NombreCliente = _reader.GetString(2),
                    DireccionCliente = _reader.GetString(3),
                    TipoInmueble = _reader.GetString(4),
                    DescripcionInmueble = _reader.GetString(5),
                    CuotasPago = _reader.GetInt16(6),
                    ValorCuota = _reader.GetDouble(7),
                    CuotasPagadas = _reader.GetDouble(8),
                    CuotasPendientes = _reader.GetDouble(9),
                    MoraPago = _reader.GetDouble(10),
                    FechaPago = _reader.GetString(11)
                };
                _lista1.Add(_lista);
            }
            return _lista1;
        }
        //Sin terminar
        
        public static Consulta Contrato1(string Id,MySqlConnection con)
        {
            Consulta _lista1 = new Consulta();
            string sql = string.Format("select Operacion_idOperacion,Numerofac,nombreCliente,direccionCliente,tipoInmueble,descripcion,cuotasPendiente,Prima,saldoPagado," +
                "saldoPendiente,Mora,fechaPago from brproyecto.operacion inner join brproyecto.saldo on(Operacion.idOperacion={0})" +
                "inner join brproyecto.cliente on(Operacion.Cliente_idCliente = Cliente.idCliente) "+ 
                "inner join brproyecto.inmueble on(operacion.Propiedad_idProp = inmueble.idProp);",Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
               
               
               _lista1.IdContrato = _reader.GetString(0);
                _lista1.numeroFac = _reader.GetInt16(1);
                _lista1.NombreCliente= _reader.GetString(2);
                _lista1.DireccionCliente= _reader.GetString(3);
                _lista1.TipoInmueble= _reader.GetString(4);
               _lista1.DescripcionInmueble= _reader.GetString(5);
               _lista1.CuotasPago= _reader.GetInt16(6);
               _lista1.ValorCuota= _reader.GetDouble(7);
               _lista1.CuotasPagadas =  _reader.GetDouble(8);
               _lista1.CuotasPendientes=  _reader.GetDouble(9);
               _lista1.MoraPago = _reader.GetDouble(10);
                _lista1.FechaPago = _reader.GetString(11);

             
            }

            return _lista1;
        }
     
    }
}
