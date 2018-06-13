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
        public static int agregarVenta(MySqlConnection conexion,Pago clie)
        {
            int retor = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Saldo (idNumeroPago,Operacion_idOperacion,saldoPagado,saldoPendiente,Mora,cuotasPendiente,fechaPago) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'); ", clie.Id, clie.Operacion,clie.Pagado,clie.Pendiente,clie.Mora,clie.CuotasP,clie.Fecha);
            MySqlCommand coman = new MySqlCommand(sql1, conexion);
            retor = coman.ExecuteNonQuery();
            return retor;
        }

      

        public static Clientes BuscarparametroC(string Id, MySqlConnection con)
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
        public static List<Ventas> BuscarContrato(string Id, MySqlConnection con)
        {
            List<Ventas> _lista = new List<Ventas>();
            string sql = string.Format("SELECT idOperacion,Cuotas,Prima,Total FROM Operacion where idOperacion ='{0}' ", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Ventas pInmueble = new Ventas();
                pInmueble.Id = _reader.GetString(0);
                pInmueble.Cuotas = _reader.GetInt16(1);
                pInmueble.prima = _reader.GetDouble(2);
                pInmueble.Total = _reader.GetInt32(3);
                 _lista.Add(pInmueble);
            }

            return _lista;
        }
        public static List<Ventas> BuscarContrato1(MySqlConnection con)
        {
            List<Ventas> _lista1 = new List<Ventas>();
            string sql = string.Format("SELECT * FROM Operacion ");
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Ventas pInmueble = new Ventas();
                pInmueble.Id = _reader.GetString(0);
                pInmueble.Fecha = _reader.GetString(1);
                pInmueble.Observacion = _reader.GetString(2);
                pInmueble.Cliente = _reader.GetString(3);
                pInmueble.Empleado = _reader.GetString(4);
                pInmueble.Propiedad = _reader.GetString(5);
                pInmueble.Forma = _reader.GetString(6);
                pInmueble.Cuotas = _reader.GetInt16(7);
                pInmueble.prima = _reader.GetDouble(8);
                pInmueble.Descuento = _reader.GetDouble(9);


                _lista1.Add(pInmueble);
            }

            return _lista1;
        }
        public static Inmuebles BuscarDE(string Id, MySqlConnection con)
        {
            Inmuebles pInmueble = new Inmuebles();
            string sql = string.Format("SELECT idProp,precioProp FROM Inmueble where idProp ='{0}' ", Id);
            MySqlCommand _comando1 = new MySqlCommand(sql, con);
            MySqlDataReader _reader1 = _comando1.ExecuteReader();
            while (_reader1.Read())
            {
                pInmueble.Id = _reader1.GetString(0);
                pInmueble.Descripcion = _reader1.GetString(1);
                pInmueble.Tipo = _reader1.GetString(2);
                pInmueble.Precio = _reader1.GetInt32(1);
            }

            return pInmueble;
        }
    }
}
