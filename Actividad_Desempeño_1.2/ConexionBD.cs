using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Desempeño_1._2
{
    internal class ConexionBD
    {
        string cadena= "Data Source = DESKTOP-94LRUI8; Initial Catalog = Acvtivad1; Integrated Security = true";
        public SqlConnection conectarx = new SqlConnection();

        public ConexionBD()
        {
            conectarx.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarx .Open ();
            }
            catch(Exception ex)
            {
                MessageBox.Show("no se ha pidido conectar a la base de datos " + ex.Message);
            }
        }
        public void cerrar ()
        {
            conectarx.Close ();
        }

    }

}
