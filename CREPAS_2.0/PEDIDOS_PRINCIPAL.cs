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
    public partial class PEDIDOS_PRINCIPAL : Form
    {
        public PEDIDOS_PRINCIPAL()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PEDIDOS_PRINCIPAL_Load(object sender, EventArgs e)
        {
            List<int> lista = new List<int>();
            DataTable dm = new DataTable();
            dm.Columns.Add("mesa");
            SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
            conexion.Open();
            string query = "SELECT mesa FROM Pedidos GROUP BY mesa;";
            SqlCommand cmdn = new SqlCommand(query, conexion);
            SqlDataReader drn = cmdn.ExecuteReader();
            
            if (drn.HasRows)
            {
                while (drn.Read())
                {
                    lista.Add((int)drn["mesa"]);
                }
            }
            conexion.Close();
            for(int i = 0; i < lista.Count; i++)
            {
                DataRow drm = dm.NewRow();
                for (int j = 0; j <= 10; j++)
                {
                    if (j != lista[i])
                    {
                        drm["mesa"] = j;
                    }
                }
                dm.Rows.Add(drm);
            }
            mesas_box.DisplayMember = "mesa";
            mesas_box.DataSource = dm;
            
        }
    }
}
