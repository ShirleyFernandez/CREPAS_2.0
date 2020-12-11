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
using System.Globalization;

namespace CREPAS_2._0
{
    public partial class PEDIDOS_PRINCIPAL : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
        public PEDIDOS_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string fecha = DateTime.Today.ToString("yyyy/MM/dd");
            conexion.Open();
            SqlCommand cmdn = new SqlCommand("INSERT INTO Cuentas(idUsuario, total, fecha) VALUES(1, 0.00, "+fecha+")", conexion);
            cmdn.ExecuteReader();
            conexion.Close();
        }

        public void enviarDatos()
        {
            conexion.Open();
            string mesa = mesas_box.SelectedItem.ToString();

        }

        private void PEDIDOS_PRINCIPAL_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'elRinconcitoDataSet5.View_CuentasAbiertas' Puede moverla o quitarla según sea necesario.
            this.view_CuentasAbiertasTableAdapter.Fill(this.elRinconcitoDataSet5.View_CuentasAbiertas);


            DataTable dm = new DataTable();
            dm.Columns.Add("mesa");
            for(int i = 1; i <= 10; i++)
            {
                DataRow drm = dm.NewRow();
                        drm["mesa"] = i;
                dm.Rows.Add(drm);
            }
            mesas_box.DisplayMember = "mesa";
            mesas_box.DataSource = dm;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cuenta = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string mesa = dataGridView1.CurrentRow.Cells[1].Value.ToString();

            PEDIDOS ped = new PEDIDOS(cuenta, mesa);
            this.Hide();
            ped.Show();
        }
    }
}
