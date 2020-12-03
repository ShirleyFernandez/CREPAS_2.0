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

namespace CREPAS_2._0
{
    public partial class AGREGAR_USUARIOS : Form
    {
        public AGREGAR_USUARIOS()
        {
            InitializeComponent();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            LOGIN fr1 = new LOGIN();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void tomarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            PEDIDOS fr1 = new PEDIDOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void pedidosCocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            COCINA fr1 = new COCINA();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void agregar_btn_Click(object sender, EventArgs e)
        {
            string nombre, tipo, pass;
            SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
            conexion.Open();
            nombre = nombre_txt.Text;
            tipo = tipo_txt.Text;
            pass = pass_txt.Text;
            if (nombre == null || tipo == null || tipo == null)
            {
                MessageBox.Show(" Inserte Usuario y Contraseña", "STICS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.nombre_txt.Focus();
                return;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
