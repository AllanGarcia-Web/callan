using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestamo
{
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();
            AccederBD basedatos = new AccederBD();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminUsuarios().ShowDialog();
        }

        private void deudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminDeudores().ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            lbnombre.Text = AccederBD.nombre+" "+AccederBD.ApellidoP+" "+AccederBD.ApellidoM;
        }
    }
}
