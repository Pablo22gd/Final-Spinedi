using System;

using System.Data;

using System.Data.SqlClient;

namespace clase
{
    class MetodosDatos
    {
        public static SqlCommand CrearComando()

        {
            //string _cadenaConexion = Configuracion.CadenaConexion;

            //SqlConnection _conexion = new SqlConnection();

            //_conexion.ConnectionString = _cadenaConexion;

            SqlConnection _conexion = new SqlConnection ("data source = 192.168.5.112; initial catalog = Stock; user id = julian; password = casa12");

            //SqlCommand _comando = new SqlCommand();

            //_comando = _conexion.CreateCommand();

            //_comando.CommandType = CommandType.Text;

            //return _comando;
        }
}
}
public static DataTable EjecutarComandoSelect(SqlCommand comando)

{

    DataTable _tabla = new DataTable();

    try

    {

        comando.Connection.Open();

        SqlDataAdapter adaptador = new SqlDataAdapter();

        adaptador.SelectCommand = comando;

        adaptador.Fill(_tabla);

    }

    catch (Exception ex)

    { throw ex; }

    finally

    { comando.Connection.Close(); }

    return _tabla;

}