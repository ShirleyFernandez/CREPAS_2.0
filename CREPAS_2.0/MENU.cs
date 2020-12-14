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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        //TOMAR PEDIDO
        private void button1_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            PEDIDOS_PRINCIPAL fr1 = new PEDIDOS_PRINCIPAL();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        //PEDIDOS COCINA
        private void button2_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            COCINA fr1 = new COCINA();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        //USUARIOS
        private void button4_Click(object sender, EventArgs e)
        {
            //invocamos otra ventana, esta es la forma mas facil
            AGREGAR_USUARIOS fr1 = new AGREGAR_USUARIOS();
            fr1.Show(); //Crear una instancia de muestra del formulario
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
