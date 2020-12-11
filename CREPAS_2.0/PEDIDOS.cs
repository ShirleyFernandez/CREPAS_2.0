﻿using System;
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

        }
        public PEDIDOS(String cuenta, String mesa)
        {
            InitializeComponent();
            this.cuentas = cuenta;
            this.mesa = mesa;


        }
        string mesa, cuentas;
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
        public DataTable cargarCategorias()
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

        public void PEDIDOS_Load(object sender, EventArgs e)
        {
            cbx_categorias.DataSource = cargarCategorias();
            cbx_categorias.DisplayMember = "nombreCategoria";
            CargarVista(cuentas);

        }

        public void CargarVista(String cuenta)
        {
            
            SqlCommand vista = new SqlCommand("SELECT Pr.nombreProd, Pr.precio, Pt.nota FROM Pedidos as Pe, Productos as Pr, Productos_tiene_Pedidos as Pt WHERE Pr.idProducto = Pt.Productos_idProducto AND Pe.idPedido = Pt.Pedidos_idPedido AND Pe.idCuenta = " + cuenta, conexion);
            SqlDataReader drn = vista.ExecuteReader();
            dataGridView1.Columns.Add("Nombre", "nombre");
            dataGridView1.Columns.Add("Precio", "precio");
            dataGridView1.Columns.Add("Notas", "notas");

            if (drn.HasRows)
            {
                while (drn.Read())
                {
                    dataGridView1.Rows.Add(drn["nombreProd"].ToString(), drn["precio"].ToString(), drn["nota"].ToString());
                }
            }
            conexion.Close();
        }

        private void AGREGAR_Click(object sender, EventArgs e)
        {
            //SqlCommand comandoPedido = new SqlCommand("INSERT INTO Productos_tiene_Pedidos");
        }

        private void cbx_categorias_SelectedIndexChanged(object sender, EventArgs e)
        {
                int indice = cbx_categorias.SelectedIndex + 1;
                String ind = indice.ToString();
                //int idCatp = 2;

                DataTable dtp = new DataTable();

                //int selectedIndex = cbx_categorias.SelectedIndex;
                Object selectedIntem = cbx_categorias.SelectedItem;
                String categoria = selectedIntem.ToString();
                // String categoria = cbx_categorias.SelectedValue.ToString();

                SqlCommand comandoIdCategorias = new SqlCommand("SELECT idCategoria FROM Categorias WHERE nombreCategoria = '" + categoria + "';", conexion);
                //comandoIdCategorias.Parameters.AddWithValue("@idCategoria", SqlDbType.Int);
                //int idCat = Convert.ToInt32(comandoIdCategorias.ExecuteScalar());
                SqlCommand comandoProducto = new SqlCommand("SELECT nombreProd FROM Productos WHERE idCategoria = '" + indice + "'", conexion);
                SqlDataAdapter adaptadorProc = new SqlDataAdapter(comandoProducto);
                adaptadorProc.Fill(dtp);
                cbx_producto.DataSource = dtp;
                cbx_producto.DisplayMember = "nombreProd";

            }
        }
    }

