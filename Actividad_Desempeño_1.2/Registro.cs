using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Desempeño_1._2
{
    public partial class FrmRegistro : Form
    {
        ConexionBD conexion1 = new ConexionBD();
        public FrmRegistro()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            conexion1.abrir();
            string cadena1 = "Insert Into Tb_Empadronado([DPI],[Nombre1],[Nombre2],[Nombre3],[Apellido1],[Apellido2],[Correo])" +
                "values( '"+TxtDPI.Text+"','"+TxtNombre1.Text+"','"+TxtNombre2.Text+"','"+TxtNombre3.Text+"','"+TxtApellido1.Text+"','"+TxtApellido2.Text+"','"+TxtCorreo.Text+"')";
            SqlCommand comando = new SqlCommand(cadena1 , conexion1.conectarx);
            comando.ExecuteNonQuery(); 

        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Inicio form4 = new Inicio();
            this.Close();
            form4.Show();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtDPI.Clear();
            TxtNombre1.Clear(); 
            TxtNombre2.Clear();
            TxtNombre3.Clear();
            TxtApellido1.Clear();
            TxtApellido2.Clear();
            TxtCorreo.Clear();
            TxtDPI.Focus(); 
        }
    }
}
