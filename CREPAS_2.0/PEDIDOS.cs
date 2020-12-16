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
        string mesa, cuentas;
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public PEDIDOS()
        {

        }
        public PEDIDOS(string cuenta, string mesa)
        {
            InitializeComponent();
            this.cuentas = cuenta;
            this.mesa = mesa;


        }
        
        private void mostrarTotal()
        {
            conexion.Open();
            SqlCommand obtenerTotal = new SqlCommand("select SUM(costo) from Productos_tiene_Pedidos where Pedidos_idCuenta = " + cuentas + "", conexion);
            SqlDataReader drn = obtenerTotal.ExecuteReader();
            drn.Read();
            string cadenaTotal = drn[0].ToString();
            double total = Convert.ToDouble(cadenaTotal);
            txt_total.Text = "$" + cadenaTotal + ".00";
            conexion.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            conexion.Open();
            SqlCommand obtenerTotal = new SqlCommand("select SUM(costo) from Productos_tiene_Pedidos where Pedidos_idCuenta = " + cuentas + "", conexion);
            SqlDataReader drn = obtenerTotal.ExecuteReader();
            drn.Read();
            string cadenaTotal = drn[0].ToString();
            double total = Convert.ToDouble(cadenaTotal);
            txt_total.Text = "$"+cadenaTotal+".00";
            conexion.Close();
            actualizarCuenta(total);
            

        }

        private void actualizarCuenta(double total)
        {
            conexion.Open();
            SqlCommand actualizaCuenta = new SqlCommand("UPDATE Cuentas SET total = "+total+" WHERE idCuenta = " + cuentas + "",conexion);
            actualizaCuenta.ExecuteReader();
            conexion.Close();
            PEDIDOS_PRINCIPAL ped = new PEDIDOS_PRINCIPAL();
            this.Hide();
            ped.Show();
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
        public DataTable cargarCategorias()
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand comandoCategorias = new SqlCommand("SELECT nombreCategoria FROM Categorias", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(comandoCategorias);
            adaptadorCat.Fill(dt);
            conexion.Close();
            return dt;
        }

        public void PEDIDOS_Load(object sender, EventArgs e)
        {
            cbx_categorias.DataSource = cargarCategorias();
            cbx_categorias.DisplayMember = "nombreCategoria";
            CargarVista(cuentas);
            mostrarTotal();

        }

        public void CargarVista(String cuenta)
        {
            conexion.Open();
            DataTable dt = new DataTable();
            SqlCommand vista = new SqlCommand("SELECT Pe.idPedido, Pr.nombreProd, Pt.costo, Pt.nota FROM " +
                "Pedidos as Pe, Productos as Pr, Productos_tiene_Pedidos as Pt WHERE Pr.idProducto = Pt.Productos_idProducto AND Pe.idPedido = Pt.Pedidos_idPedido AND Pe.idCuenta = " + cuenta, conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(vista);
            adaptadorCat.Fill(dt);
            dataGridView1.DataSource = dt;
            conexion.Close();
        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            string producto = cbx_producto.SelectedValue.ToString();
            int categoria = cbx_categorias.SelectedIndex + 1;
            string cantidad = textBox1.Text;
            string nota = textBox2.Text;
            int ultimo = ultimoPedido();
            insertarPedido(mesa, cuentas);
            string p = precio(producto);
            int costo = (Convert.ToInt32(p)) * (Convert.ToInt32(cantidad));
            productosTienePedidos(producto, ultimo, categoria, cuentas, cantidad, nota, costo);
            PEDIDOS_Load(sender, e);
            mostrarTotal();
        }
        private void productosTienePedidos(string idProduto, int idPedido, int categoria, string cuenta, string cantidad, string nota, int costo)
        {
            conexion.Open();
            SqlCommand insertarPedido = new SqlCommand("INSERT INTO Productos_tiene_Pedidos(Productos_idProducto, Pedidos_idPedido, Productos_idCategoria, Pedidos_idCuenta, estado, cantidad, nota, costo) " +
                "VALUES(" + idProduto + "," + idPedido + "," + categoria + "," + cuenta + ",0," + cantidad + ",'" + nota + "'," + costo + ");", conexion);
            insertarPedido.ExecuteReader();
            conexion.Close();
        }
        public string precio(string idProducto)
        {
            conexion.Open();
            SqlCommand obtenerPrecio = new SqlCommand("SELECT precio FROM Productos WHERE idProducto = " + idProducto + "", conexion);
            SqlDataReader drn = obtenerPrecio.ExecuteReader();
            drn.Read();
            string p = drn[0].ToString();
            conexion.Close();
            return p;
        }

        private void insertarPedido(string mesa, string cuenta)
        {
            conexion.Open();
            SqlCommand insertarPedido = new SqlCommand("INSERT INTO Pedidos (idCuenta, mesa) VALUES(" + cuenta + ", " + mesa + ");", conexion);
            insertarPedido.ExecuteReader();
            conexion.Close();
        }
        public int ultimoPedido()
        {
            conexion.Open();
            SqlCommand comandoPedido = new SqlCommand("select max(idPedido) from Pedidos;", conexion);
            SqlDataReader drn = comandoPedido.ExecuteReader();
            drn.Read();
            string pedido = drn[0].ToString();
            int ultimo = Convert.ToInt32(pedido);
            conexion.Close();
            return ultimo+1;
        }

        private void eliminarPtp(string idPedido)
        {
            conexion.Open();
            SqlCommand comandoEliminar = new SqlCommand("DELETE FROM Productos_tiene_Pedidos WHERE Pedidos_idPedido = " + idPedido + "", conexion);
            comandoEliminar.ExecuteReader();
            conexion.Close();
        }

        private void eliminarPedido(string idPedido)
        {
            conexion.Open();
            SqlCommand comandoEliminar = new SqlCommand("DELETE FROM Pedidos WHERE idPedido = " + idPedido + "", conexion);
            comandoEliminar.ExecuteReader();
            conexion.Close();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            string idPedido = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            eliminarPtp(idPedido);
            eliminarPedido(idPedido);
            PEDIDOS_Load(sender, e);
            mostrarTotal();
        }

        //BOTONES QUE CORRESPONDEN AL MENU
        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            MENU fr13 = new MENU();
            fr13.Show(); //Crear una instancia de muestra del formulario
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
            COCINA fr2 = new COCINA();
            fr2.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void agregarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            AGREGAR_USUARIOS fr1 = new AGREGAR_USUARIOS();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cbx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexion.Open();
            int indice = cbx_categorias.SelectedIndex + 1;
            String ind = indice.ToString();

            DataTable dtp = new DataTable();
            Object selectedIntem = cbx_categorias.SelectedItem;
            String categoria = selectedIntem.ToString();
            SqlCommand comandoProducto = new SqlCommand("SELECT idProducto, nombreProd FROM Productos WHERE idCategoria = '" + indice + "'", conexion);
            SqlDataAdapter adaptadorCat = new SqlDataAdapter(comandoProducto);
            adaptadorCat.Fill(dtp);

            cbx_producto.ValueMember = "idProducto";
            cbx_producto.DisplayMember = "nombreProd";
            cbx_producto.DataSource = dtp;
            conexion.Close();
        }
    }
}
