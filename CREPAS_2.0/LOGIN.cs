using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace CREPAS_2._0
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Acceder, botón de inicio de sesión 
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, contraseña;
            //Conexión para el usuario de la BD :D 
            SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
            conexion.Open();
            usuario = textBox1.Text;
            contraseña = textBox2.Text;
            //
            if (usuario == null || contraseña == null)
            {
                MessageBox.Show(" Inserte Usuario y Contraseña", "STICS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
                return;
            }
            else
            {
                try
                {
                    SqlConnection SQLConnection = new SqlConnection();

                    //Hago la Consulta
                    //string commandString = "SELECT Nombre, password FROM pruebas WHERE Nombre= " + this.textBox1 + " AND password= " + this.textBox2 + "";
                    string queryNombre = "Select nombre,pass FROM Usuarios WHERE nombre = '" + usuario + "'";
                    //string queryPassword = "Select password FROM Usuarios WHERE Nombre = '" + usuario + "'";
                    //Instrucciones para recibir el nombre de la bd
                    SqlCommand cmdn = new SqlCommand(queryNombre, conexion);
                    SqlDataReader drn = cmdn.ExecuteReader();
                    drn.Read();
                    
                        if (contraseña == drn[1].ToString())
                        {
                            PEDIDOS pedidos = new PEDIDOS();
                            pedidos.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario o Contraseña incorrectos", "STICS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                }
                catch(System.InvalidOperationException E)
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos", "STICS Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }   
    }
}

