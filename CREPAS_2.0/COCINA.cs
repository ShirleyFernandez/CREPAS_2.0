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
using FirebaseAdmin;
using FirebaseAdmin.Messaging;
using Google.Apis.Auth.OAuth2;
using System.IO;
using System.Net;

namespace CREPAS_2._0
{
    public partial class COCINA : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public COCINA()
        {
            InitializeComponent();
        }

        //REFERENCIA AL MENÚ
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            MENU fr1 = new MENU();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        //ENLACE A TOMAR PEDIDO
        private void tomarPedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            PEDIDOS fr1 = new PEDIDOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        //pedidos cocina
        private void pedidosCocinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            COCINA fr1 = new COCINA();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        //AGREGAR NUEVO USUARIO
        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            AGREGAR_USUARIOS fr1 = new AGREGAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void COCINA_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'elRinconcitoDataSet1.View_Cocina' Puede moverla o quitarla según sea necesario.
            this.view_CocinaTableAdapter.Fill(this.elRinconcitoDataSet1.View_Cocina);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pedido = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mesero = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            string producto = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            string mesa = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            conexion.Open();
            string query = "UPDATE Productos_tiene_Pedidos SET estado = 1 WHERE Pedidos_idPedido = " + pedido + "";
            SqlCommand cmdn = new SqlCommand(query, conexion);
            cmdn.ExecuteReader();
            conexion.Close();        
            COCINA_Load(sender,e);
            string t = token(mesero);
            notificar(t, producto, mesa);
            
        }

        public void notificar (string token, string producto, string mesa)
        {
            FireBasePush pushO = new FireBasePush("AAAAjDP4PCA:APA91bFqNdTImQdJSMYdUMKyWAC2Dg2oPlUkeIp7ez50WqEcrlrBYRm2kKeZ5_vSmV1T9mocKp4eYYRI8BQFP4sNC9w1HtH9byamPS3dFFcCDwueYykZw508Ljgld8ru9b63Ytmg6k0O");
            pushO.SendPush(new PushMessage()
            {
                to = token, //for a topic to": "/topics/foo-bar"
                notification = new PushMessageData
                {
                    title = "Pedido Listo",
                    text = "Su pedido " + producto + " de la mesa: "+mesa+" esta listo"
                },
                data = new
                {
                    example = "ey, Ya esta listo"
                }
            });
            conexion.Close();
        }

        public string token(string mesero)
        {
            conexion.Open();
            string querym = "SELECT token FROM Usuarios WHERE idUsuario = " + mesero + "";
            SqlCommand cmdn = new SqlCommand(querym, conexion);
            SqlDataReader drn = cmdn.ExecuteReader();
            drn.Read();
            return drn[0].ToString();
        }

        private void tomarPedidoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            PEDIDOS fr1 = new PEDIDOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void cuentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            CUENTAS fr1 = new CUENTAS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }
    }
}
