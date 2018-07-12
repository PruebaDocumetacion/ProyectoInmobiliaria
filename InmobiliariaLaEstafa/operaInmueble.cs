using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conexion
{
    class operaInmueble
    {
        public static int agregarinmueble(MySqlConnection conexion, Inmuebles cli)
        {
            int retorno = 0;
            string sql1 = string.Format("INSERT INTO brproyecto.Inmueble (idProp, ciudadProp, direccionProp, descripcion," +
                "tipoInmueble, precioProp,comisionProp,medidaCProp,banos,dormitorios,foto) VALUES ('{0}', '{1}', '{2}', '{3}', " +
                "'{4}', '{5}', '{6}', '{7}', '{8}', '{9}','{10}'); ", cli.IdI, cli.Ciudad,cli.DireccionI,cli.Descripcion,cli.Tipo,cli.Precio,cli.Comision,cli.Medida,cli.Banos,cli.Dormitorios,cli.Foto);
            MySqlCommand comando = new MySqlCommand(sql1, conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }

        public static int modificarinmueble(MySqlConnection conexion, Inmuebles cli)
        {
            int retorno1 = 0;
            string sql = string.Format("Update brproyecto.Inmueble set ciudadProp='{0}', direccionProp='{1}', descripcion='{2}'," +
                "tipoInmbleue='{3}', precioProp='{4}',comisionProp='{5}',medidaCProp='{6}',banos='{7}'," +
                "dormitorios='{8}',foto='{9}' where idProp='{10}';", cli.Ciudad, cli.DireccionI, cli.Descripcion, cli.Tipo, cli.Precio, cli.Comision, cli.Medida, cli.Banos, cli.Dormitorios, cli.Foto, cli.IdI);
            MySqlCommand comando1 = new MySqlCommand(sql, conexion);
            retorno1 = comando1.ExecuteNonQuery();
            return retorno1;
        }

        public static int eliminarinmueble(MySqlConnection conexion, Inmuebles clien)
        {
            int retorno2 = 0;
            string sql = string.Format("Delete from brproyecto.Inmueble where idProp='{0}'", clien.IdI);
            MySqlCommand comando2 = new MySqlCommand(sql, conexion);
            retorno2 = comando2.ExecuteNonQuery();
            return retorno2;
        }

        public static List<Inmuebles> Buscar(MySqlConnection con)
        {
            List<Inmuebles> _lista = new List<Inmuebles>();
            string sql = "SELECT idProp, ciudadProp, direccionProp, descripcion," +
                "tipoInmueble, precioProp,comisionProp,medidaCProp,banos,dormitorios FROM Inmueble;";
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
                pInmueble.Banos= _reader.GetInt16(8);
                pInmueble.Dormitorios = _reader.GetInt16(9);
               // pInmueble.Foto = _reader.GetString(10);
                _lista.Add(pInmueble);
            }

            return _lista;
        }


        public static List<Inmuebles> Buscarparametro(string Id, string Direccion, string Tipo,MySqlConnection con)
        {
            List<Inmuebles> _lista = new List<Inmuebles>();
            string sql = string.Format("SELECT idProp, ciudadProp, direccionProp, descripcion," +
                "tipoInmueble, precioProp,comisionProp,medidaCProp,banos,dormitorios,foto FROM Inmueble where idProp ='{0}' or direccionProp ='{1}' or tipoInmueble ", Id, Direccion,Tipo);
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



        public static Inmuebles Buscarparametro1(string Id, MySqlConnection con)
        {

            Inmuebles pInmueble = new Inmuebles();
            string sql = string.Format("SELECT idProp, ciudadProp, direccionProp, descripcion," +
                "tipoInmueble, precioProp,comisionProp,medidaCProp,banos,dormitorios,foto FROM Inmueble where idProp ='{0}' ", Id);
            MySqlCommand _comando = new MySqlCommand(sql, con);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
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

            }

            return pInmueble;
        }
    }
}
