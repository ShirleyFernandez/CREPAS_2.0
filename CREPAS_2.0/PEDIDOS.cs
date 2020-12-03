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
using System.Data.Sql;

namespace CREPAS_2._0
{
    public partial class PEDIDOS : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public PEDIDOS()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        //PEDIDOS COCINA
        private void button1_Click(object sender, EventArgs e)
        {
            COCINA pcocina = new COCINA();
            pcocina.Show(); //Abre este formulario
            this.Hide();
        }

        //ENLACE A CUENTAS
        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        //ENLACE A ALTAS DE USUARIOS
        private void button7_Click(object sender, EventArgs e)
        {
            AGREGAR_USUARIOS usuarios = new AGREGAR_USUARIOS();
            usuarios.Show(); //Abre este formulario
            this.Hide();
        }

        //CERRAR LA SESION ACTUAL
        private void button5_Click(object sender, EventArgs e)
        {

        }
        private DataTable cargarCategorias()
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand comandoCategorias = new SqlCommand("SELECT nombreCategoria FROM Categorias", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(comandoCategorias);
            //adaptadorCat.SelectCommand = comandoCategorias;
            //DataTable tablaCat = new DataTable();
            adaptadorCat.Fill(dt);
            return dt;
        }


        private void PEDIDOS_Load(object sender, EventArgs e)
        {
            //conexion.Open(); 

            cbx_categorias.DataSource = cargarCategorias();
            cbx_categorias.DisplayMember = "nombreCategoria";
            //cbx_categorias.ValueMember = "idCategoria";

            String categoria = cbx_categorias.Text;
            SqlCommand comandoIdCategorias = new SqlCommand("SELECT idCategoria FROM Categorias WHERE nombreCategoria = '"+categoria+"';", conexion);
            comandoIdCategorias.Parameters.AddWithValue("@idCategoria", SqlDbType.Int);
            int idCat = Convert.ToInt32(comandoIdCategorias.ExecuteScalar());


            //conexion.Close();


        }
    }
}
