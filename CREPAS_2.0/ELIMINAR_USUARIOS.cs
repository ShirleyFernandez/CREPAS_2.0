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
    public partial class ELIMINAR_USUARIOS : Form
    {
        public ELIMINAR_USUARIOS()
        {
            InitializeComponent();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("Data Source=equipo2.database.windows.net;Initial Catalog=ElRinconcito;Persist Security Info=True; User ID=crepa;Password=creperiaElrinconcito12");
            conexion.Open();
            string usuario = Eusuario_txt.SelectedValue.ToString();
            string query = "DELETE FROM Usuarios WHERE idUsuario = "+usuario+"";
            SqlCommand cmdn = new SqlCommand(query, conexion);
            cmdn.ExecuteReader();
        }

        private void ELIMINAR_USUARIOS_Load(object sender, EventArgs e)
        {

        }
    }
}
