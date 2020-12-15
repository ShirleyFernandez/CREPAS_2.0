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
    public partial class ELIMINAR_USUARIOS : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public ELIMINAR_USUARIOS()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string usuario = Eusuario_txt.SelectedValue.ToString();
            eliminar(usuario);
            ELIMINAR_USUARIOS_Load(sender, e);

        }

        public void eliminar(string usuario)
        {
            cambio(usuario);
            conexion.Open();
            SqlCommand cmdn = new SqlCommand("DELETE FROM Usuarios WHERE idUsuario = " + usuario + "", conexion);
            cmdn.ExecuteReader();
            conexion.Close();
        }

        public void cambio (string usuario)
        {
            conexion.Open();
            SqlCommand cmdn = new SqlCommand("UPDATE Cuentas SET idUsuario = 1 WHERE idUsuario = " + usuario + "", conexion);
            cmdn.ExecuteReader();
            conexion.Close();
        }

        private void ELIMINAR_USUARIOS_Load(object sender, EventArgs e)
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand usuarios = new SqlCommand("SELECT idUsuario, nombre FROM Usuarios", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(usuarios);
            adaptadorCat.Fill(dt);
            Eusuario_txt.ValueMember = "idUsuario";
            Eusuario_txt.DisplayMember = "nombre";
            Eusuario_txt.DataSource = dt;
            conexion.Close();
        }


        //DIRECCIONES DE LOS FORMS DEL MENÚ
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
        {//invocamos otra ventana, esta es la forma mas facil
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
    }
}
