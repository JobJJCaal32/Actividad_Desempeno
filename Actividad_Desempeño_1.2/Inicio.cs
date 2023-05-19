using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_Desempeño_1._2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            FrmRegistro form1 = new FrmRegistro();
            this.Hide(); 
            form1.Show();
        }

        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta form2 = new FrmConsulta();
            this.Hide();
            form2.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
