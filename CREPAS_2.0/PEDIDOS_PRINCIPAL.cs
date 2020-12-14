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
using System.Globalization;

namespace CREPAS_2._0
{
    public partial class PEDIDOS_PRINCIPAL : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public PEDIDOS_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Today.ToString("yyyy/MM/dd");
            conexion.Open();
            SqlCommand cmdn = new SqlCommand("INSERT INTO Cuentas(idUsuario, total, fecha) VALUES(1, 0.00, '" + fecha + "')", conexion);
            cmdn.ExecuteReader();
            conexion.Close();
            enviarDatos();

        }

        public void enviarDatos()
        {
            conexion.Open();
            string mesa = mesas_box.SelectedValue.ToString();
            SqlCommand comandoPedido = new SqlCommand("SELECT MAX(idCuenta) from Cuentas", conexion);
            SqlDataReader drn = comandoPedido.ExecuteReader();
            drn.Read();
            string cuenta = drn[0].ToString();
            PEDIDOS ped = new PEDIDOS(cuenta, mesa);
            this.Hide();
            ped.Show();

        }

        private void PEDIDOS_PRINCIPAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'elRinconcitoDataSet5.View_CuentasAbiertas' Puede moverla o quitarla según sea necesario.
            this.view_CuentasAbiertasTableAdapter.Fill(this.elRinconcitoDataSet5.View_CuentasAbiertas);


            DataTable dm = new DataTable();
            dm.Columns.Add("mesa");
            for (int i = 1; i <= 10; i++)
            {
                DataRow drm = dm.NewRow();
                drm["mesa"] = i;
                dm.Rows.Add(drm);
            }
            mesas_box.DisplayMember = "mesa";
            mesas_box.ValueMember = "mesa";
            mesas_box.DataSource = dm;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cuenta = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mesa = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            PEDIDOS ped = new PEDIDOS(cuenta, mesa);
            this.Hide();
            ped.Show();
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

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            CUENTAS fr1 = new CUENTAS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            AGREGAR_USUARIOS fr1 = new AGREGAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        //EDITAR USUARIO
        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            MODIFICAR_USUARIOS fr1 = new MODIFICAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            ELIMINAR_USUARIOS fr1 = new ELIMINAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }
    }
}

