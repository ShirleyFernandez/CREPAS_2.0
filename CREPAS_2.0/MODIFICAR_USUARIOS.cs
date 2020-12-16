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
    public partial class MODIFICAR_USUARIOS : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public MODIFICAR_USUARIOS()
        {
            InitializeComponent();
        }

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
            PEDIDOS_PRINCIPAL fr1 = new PEDIDOS_PRINCIPAL();
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

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void MODIFICAR_USUARIOS_Load(object sender, EventArgs e)
        {
            DataTable dtu = new DataTable();
            dtu.Columns.Add("id");
            dtu.Columns.Add("nombre");

            DataRow dru1 = dtu.NewRow();
            dru1["id"] = "1";
            dru1["nombre"] = "Administrador";
            dtu.Rows.Add(dru1);
            DataRow dru2 = dtu.NewRow();
            dru2["id"] = "2";
            dru2["nombre"] = "Cocinero";
            dtu.Rows.Add(dru2);
            DataRow dru3 = dtu.NewRow();
            dru3["id"] = "3";
            dru3["nombre"] = "Mesero";
            dtu.Rows.Add(dru3);

            cmb_tipo.DisplayMember = "nombre";
            cmb_tipo.ValueMember = "id";
            cmb_tipo.DataSource = dtu;
            mostrar();
        }
        public void mostrar()
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand usuarios = new SqlCommand("SELECT idUsuario, nombre FROM Usuarios", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(usuarios);
            adaptadorCat.Fill(dt);
            conexion.Close();
            usuario_txt.ValueMember = "idUsuario";
            usuario_txt.DisplayMember = "nombre";
            usuario_txt.DataSource = dt; 
        }

        private void MostrarDatoSeleccionado(object sender, EventArgs e)
        {
            conexion.Open();
            string Usuarios = usuario_txt.SelectedValue.ToString();
            SqlCommand usuarios = new SqlCommand("SELECT tipo, nombre, pass FROM Usuarios WHERE idUsuario = "+Usuarios+"", conexion);
            SqlDataReader dr = usuarios.ExecuteReader();
            dr.Read();
            txt_nombre.Text = dr[1].ToString();
            txt_pass.Text = dr[2].ToString();
            cmb_tipo.SelectedValue = dr[0].ToString();
            conexion.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string id = usuario_txt.SelectedValue.ToString();
            string nombre = txt_nombre.Text;
            string tipo = cmb_tipo.SelectedValue.ToString();
            string pass = txt_pass.Text;
            SqlCommand usuarios = new SqlCommand("UPDATE Usuarios SET tipo = "+tipo+", nombre = '"+nombre+"', pass = '"+pass+"' WHERE idUsuario = "+id+"", conexion);
            usuarios.ExecuteReader();
            conexion.Close();
            MODIFICAR_USUARIOS_Load(sender, e);
        }
    }
}
