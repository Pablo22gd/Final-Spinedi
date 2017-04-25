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
        cadenaConexion=@"Data Source=.\MSPDeveloper;Initial
Catalog=Tienda;User ID=sa;Password=mredison";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
       }

    }
}
