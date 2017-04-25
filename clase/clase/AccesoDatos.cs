using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace Datos

{

    public class AccesoDatos

    {

        public static DataTable ObtenerProductos()

        {

            SqlCommand _comando = MetodosDatos.CrearComando();

            _comando.CommandText = "SELECT * FROM Productos";

            return MetodosDatos.EjecutarComandoSelect(_comando);

        }

    }

}
