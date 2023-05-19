using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Actividad_Desempeño_1._2
{
    public partial class FrmConsulta : Form
    {
        ConexionBD conexion1 = new ConexionBD();
        public FrmConsulta()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (TxtBuscar.Text == "")
            {
                conexion1.abrir();
                string cadena = "SELECT * FROM Tb_Empadronado";
                SqlCommand comando = new SqlCommand(cadena, conexion1.conectarx);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                TbDatos.DataSource = tabla;
            }
            else
            {
                conexion1.abrir();
                string cadena = "SELECT * FROM Tb_Empadronado where DPI = '"+TxtBuscar.Text+"'";
                SqlCommand comando = new SqlCommand(cadena, conexion1.conectarx);
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                TbDatos.DataSource = tabla;
            }

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {

            conexion1.cerrar();
            Inicio form3 = new Inicio();
            this.Close();
            form3.Show(); 
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtBuscar.Clear();
            TxtBuscar.Focus();
            conexion1.cerrar(); 
        }
    }
}
