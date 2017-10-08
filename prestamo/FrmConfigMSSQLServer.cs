using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibArchivo;

namespace prestamo
{
    public partial class FrmConfigMSSQLServer : Form
    {
        private string filename = "mssqlserver.ini";
        Archivos File = new Archivos();
        public FrmConfigMSSQLServer()
        {
            InitializeComponent();
            if (File.MSSQLConnectionRead(filename))
            {
                tbMSSQLServer.Text = File.mssqlserver;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (File.MSSQLConnectionWrite(filename,tBhost.Text,tBbd.Text,tBusuario.Text,tBpass.Text))
            {
                MessageBox.Show("Guardado Correctamente");
            }
        }
    }
}
