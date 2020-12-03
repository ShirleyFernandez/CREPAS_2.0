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
            if (nombre == null || tipo == null || pass == null)
            {
                MessageBox.Show(" Inserte todos los datos", "STICS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.nombre_txt.Focus();
                return;
            }
            MessageBox.Show(tipo_txt.Text);
            /*string query = "INSERT INTO Usuarios (tipo,nombre,pass) VALUES (" +tipo+",'"+nombre+"',"+pass+")";
            SqlCommand cmdn = new SqlCommand(query, conexion);
            cmdn.ExecuteReader();
            nombre_txt.Clear();
            pass_txt.Clear();*/
        }

        private void AGREGAR_USUARIOS_Load(object sender, EventArgs e)
        {
            DataTable dtu = new DataTable();
            dtu.Columns.Add("id");
            dtu.Columns.Add("nombre");

            DataRow dru1 = dtu.NewRow();
            dru1["id"] = "001";
            dru1["nombre"] = "Administrador";
            dtu.Rows.Add(dru1);
            DataRow dru2 = dtu.NewRow();
            dru2["id"] = "002";
            dru2["nombre"] = "Cocinero";
            dtu.Rows.Add(dru2);
            DataRow dru3 = dtu.NewRow();
            dru3["id"] = "003";
            dru3["nombre"] = "Mesero";
            dtu.Rows.Add(dru3);

            tipo_txt.ValueMember = "id";
            tipo_txt.DisplayMember = "nombre";
            tipo_txt.DataSource = dtu;
        }
    }
}
