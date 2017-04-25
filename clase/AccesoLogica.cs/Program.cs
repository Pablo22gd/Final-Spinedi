using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoLogica.cs
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AccesoLogica());
        }
    }
}
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

using Logica;

namespace Presentacion

{

    public partial class Productos : Form

    {

        public Productos()

        {

            InitializeComponent();

        }

        private void Productos_Load(object sender, EventArgs e)

        {

            gvProductos.DataSource = AccesoLogica.ObtenerProductos();

        }

    }

}