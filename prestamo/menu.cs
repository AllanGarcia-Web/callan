using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libAccesoBD;

namespace prestamo
{
    public partial class menu : Form
    {
        
        public menu()
        {
            InitializeComponent();
            bd basedatos = new libAccesoBD.bd(); //conexión a libreria
            if (bd.valor == 1) //verificar que es cobrador
            {
                usuariosToolStripMenuItem.Visible = false; //desactivar acceso a usuario a cobrador
            }
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
            lbnombre.Text = bd.nombre+" "+bd.ApellidoP+" "+bd.ApellidoM; //leer el nombre del usuario actual
        }

        private void acercaDelSisremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
