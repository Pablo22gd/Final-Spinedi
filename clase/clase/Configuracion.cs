using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase
{
    class Configuracion

    {
        static string
        cadenaConexion= @"data source = 192.168.5.112; initial catalog = Stock; user id = julian; password = casa12";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
       }

    }
}
