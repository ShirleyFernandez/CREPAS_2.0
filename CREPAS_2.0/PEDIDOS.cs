using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CREPAS_2._0
{
    public partial class PEDIDOS : Form
    {
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
    }
}
