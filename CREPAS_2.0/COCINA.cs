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
    public partial class COCINA : Form
    {
        public COCINA()
        {
            InitializeComponent();
        }

        //REFERENCIA AL MENÚ
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            LOGIN fr1 = new LOGIN();
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
            SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
            conexion.Open();
            string query = "UPDATE Productos_tiene_Pedidos SET estado = 1 WHERE Pedidos_idPedido = " + pedido + "";
            SqlCommand cmdn = new SqlCommand(query, conexion);
            cmdn.ExecuteReader();
            COCINA_Load(sender,e);
        }
    }
}
