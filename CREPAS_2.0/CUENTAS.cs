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
    public partial class CUENTAS : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public CUENTAS()
        {
            InitializeComponent();
        }

        //BOTONES DEL MENU
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            MENU fr1 = new MENU();
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

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            MODIFICAR_USUARIOS fr1 = new MODIFICAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void eliminarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            ELIMINAR_USUARIOS fr1 = new ELIMINAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }
        //FIN DE LOS BOTONES DEL MENU

        private void CUENTAS_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conexion.Open();
            SqlCommand cuenta = new SqlCommand(" SELECT fecha FROM Cuentas WHERE total > 0 GROUP BY fecha;", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(cuenta);
            adaptadorCat.Fill(dt);
            conexion.Close();
            cmb_fecha.DisplayMember = "fecha";
            cmb_fecha.ValueMember = "fecha";
            cmb_fecha.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime fecha = new DateTime();
            fecha = DateTime.Parse(cmb_fecha.SelectedValue.ToString());
            MessageBox.Show(fecha.ToString("yyyy/MM/dd"));
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand vista = new SqlCommand("SELECT C.idCuenta, U.nombre, C.total FROM Cuentas as C, Usuarios as U WHERE C.idUsuario = U.idUsuario AND C.total > 0 AND fecha = '" + fecha.ToString("yyyy/MM/dd") + "'", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(vista);
            adaptadorCat.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
            lbl_ganancias.Text = ganancias(fecha.ToString("yyyy/MM/dd"));
        }

        public string ganancias(string fecha)
        {
            conexion.Open();
            SqlCommand ganancia = new SqlCommand("SELECT SUM(total) FROM Cuentas WHERE fecha = '"+fecha+"'", conexion);
            SqlDataReader drn = ganancia.ExecuteReader();
            drn.Read();
            string g = drn[0].ToString();
            conexion.Close();
            return g;
        }
    }
}
