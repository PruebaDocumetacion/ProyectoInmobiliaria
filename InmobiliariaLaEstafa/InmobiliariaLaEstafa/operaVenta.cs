using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaVenta
    {
        public static int agregarVenta(MySqlConnection conexion, Ventas clie)
        {
            int retor = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Operacion (idOperacion, fechaOperacion, observacionOpeacion, Cliente_idCliente," +
                "Empleado_idEmpleado, Propiedad_idProp,FormaPago,Cuota,Prima,Descuento,Total) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'," +
                "'{7}','{8}','{9}','{10}'); ", clie.IdV, clie.FechaV,clie.Observacion,clie.Cliente,clie.Empleado,clie.Propiedad,clie.Forma,clie.Cuotas,clie.prima,clie.Descuento,clie.Total);
            MySqlCommand coman = new MySqlCommand(sql1, conexion);
            retor = coman.ExecuteNonQuery();
            return retor;
        }
        /*
        public static int agregarPago(MySqlConnection conexion, Ventas cl)
        {
            int retor = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Saldo (idNumeroPago,Operacion_idOperacion,saldoPagado,saldoPendiente,Mora,cuotasPendiente,fechaPago) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}'); ", cl.pago, cl.Id,  cl.prima,cl.Total, cl.mora, cl.Cuotas, cl.Fecha);
            MySqlCommand coman = new MySqlCommand(sql1, conexion);
            retor = coman.ExecuteNonQuery();
            return retor;
        }*/
        public static int modificarVenta(MySqlConnection conexion, Ventas cli)
        {
            int retorno1 = 0;
            string sql = string.Format("Update brproyecto.Operacion set  fechaOperacion='{0}', observacionOpeacion='{1}', Cliente_idCliente='{2}'" +
                "Empleado_idEmpleado='{3}', Propiedad_idProp='{4}',FormaPago='{5}',Cuota='{6}',Prima='{7}',Descuento='{8}' where idOperacion='{9}';", cli.FechaV, cli.Observacion, cli.Cliente, cli.Empleado, cli.Propiedad, cli.Forma, cli.Cuotas,cli.prima,cli.Descuento, cli.IdV);
            MySqlCommand comando1 = new MySqlCommand(sql, conexion);
            retorno1 = comando1.ExecuteNonQuery();
            return retorno1;
        }

        public static int eliminarVenta(MySqlConnection conexion, Ventas clien)
        {
            int retorno2 = 0;
            string sql = string.Format("Delete from brproyecto.Venta where idOperacion='{0}'", clien.IdV);
            MySqlCommand comando2 = new MySqlCommand(sql, conexion);
            retorno2 = comando2.ExecuteNonQuery();
            return retorno2;
        }

        public static Inmuebles BuscarDE(string Id,MySqlConnection con)
        {
            Inmuebles pInmueble = new Inmuebles();
            string sql = string.Format("SELECT idProp,descripcion,precioProp FROM Inmueble where idProp ='{0}' ", Id);
            MySqlCommand _comando1 = new MySqlCommand(sql, con);
            MySqlDataReader _reader1 = _comando1.ExecuteReader();
            while (_reader1.Read())
            {
                pInmueble.IdI = _reader1.GetString(0);
                pInmueble.Descripcion = _reader1.GetString(1);
                pInmueble.Precio = _reader1.GetInt32(2);
            }

            return pInmueble;
        }


        public static List<Inmuebles> BuscarparametroI(string Id, MySqlConnection con)
        {
            List<Inmuebles> _lista = new List<Inmuebles>();
            string sql = string.Format("SELECT idProp, ciudadProp, direccionProp, descripcion," +
                "tipoInmueble, precioProp,comisionProp,medidaCProp,banos,dormitorios,foto FROM Inmueble where idProp ='{0}' ", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Inmuebles pInmueble = new Inmuebles();
                pInmueble.IdI = _reader.GetString(0);
                pInmueble.Ciudad = _reader.GetString(1);
                pInmueble.DireccionI = _reader.GetString(2);
                pInmueble.Descripcion = _reader.GetString(3);
                pInmueble.Tipo = _reader.GetString(4);
                pInmueble.Precio = _reader.GetInt32(5);
                pInmueble.Comision = _reader.GetInt32(6);
                pInmueble.Medida = _reader.GetInt16(7);
                pInmueble.Banos = _reader.GetInt16(8);
                pInmueble.Dormitorios = _reader.GetInt16(9);
                pInmueble.Foto = _reader.GetString(10);

                _lista.Add(pInmueble);
            }

            return _lista;
        }



        public static Empleados BuscarparametroE(string Id, MySqlConnection con)
        {
            
            Empleados pEmpleado = new Empleados();
            string sql = string.Format("SELECT idEmpleado,nombreEmpleado FROM Empleado where idEmpleado ='{0}' ", Id);
            MySqlCommand _comando2 = new MySqlCommand(sql, con);
            MySqlDataReader _reader2 = _comando2.ExecuteReader();
            //retorno = _comando2.ExecuteNonQuery();
            
            while (_reader2.Read())
            {
                pEmpleado.Id = _reader2.GetString(0);
                pEmpleado.Nombre = _reader2.GetString(1);
                
            }
            return   pEmpleado;
        }

        public static Clientes BuscarparametroC(string Id, MySqlConnection con)
        {

            Clientes pCliente = new Clientes();
            string sql = string.Format("SELECT IdCliente, nombreCliente FROM Cliente  where idCliente ='{0}'  ", Id);
            MySqlCommand _comando3 = new MySqlCommand(sql, con);
            MySqlDataReader _reader3 = _comando3.ExecuteReader();
            while (_reader3.Read())
            {
                pCliente.IdC = _reader3.GetString(0);
                pCliente.NombreC = _reader3.GetString(1);
            }

            return pCliente;
        }
        public static List<Ventas> BuscarContrato(string Id, MySqlConnection con)
        {
            List<Ventas> _lista = new List<Ventas>();
            string sql = string.Format("SELECT * FROM Operacion where idOperacion ='{0}' ", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Ventas pInmueble = new Ventas();
                pInmueble.IdV = _reader.GetString(0);
                pInmueble.FechaV = _reader.GetString(1);
                pInmueble.Observacion = _reader.GetString(2);
                pInmueble.Cliente = _reader.GetString(3);
                pInmueble.Empleado = _reader.GetString(4);
                pInmueble.Propiedad = _reader.GetString(5);
                pInmueble.Forma = _reader.GetString(6);
                pInmueble.Cuotas = _reader.GetInt16(7);
                pInmueble.prima = _reader.GetDouble(8);
                pInmueble.Descuento = _reader.GetDouble(9);
                

                _lista.Add(pInmueble);
            }

            return _lista;
        }
        public static List<Ventas> BuscarContrato1( MySqlConnection con)
        {
            List<Ventas> _lista1 = new List<Ventas>();
            string sql = string.Format("SELECT * FROM Operacion ");
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Ventas pInmueble = new Ventas();
                pInmueble.IdV = _reader.GetString(0);
                pInmueble.FechaV = _reader.GetString(1);
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
    }
}
