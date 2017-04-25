using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoLogica.cs
{
    public partial class AccesoLogica : Form
    {
        public AccesoLogica()
        {
            InitializeComponent();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Datos;

namespace Logica

{

    public class AccesoLogica

    {

        public static DataTable ObtenerProductos()

        {

            return AccesoDatos.ObtenerProductos();

        }

    }

}