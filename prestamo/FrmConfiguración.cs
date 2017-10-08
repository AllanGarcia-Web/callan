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
    public partial class FrmConfiguraciónMySQL : Form
    {
        private string filename = "mysql.ini";
        Archivos File = new Archivos();
        public FrmConfiguraciónMySQL()
        {
            InitializeComponent();
            if (File.MySqlConnectionRead(filename))
            {
                tbMysql.Text = File.mysqlcon;
            }
            else
            {
                MessageBox.Show("Error al leer el archivo de configuración de MySQL", "Error al leer el archivo",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tBhost.Text.Trim()=="" && tBusuario.Text.Trim() == "" && tBpass.Text.Trim() == "" && tBbd.Text.Trim() == "")
            {
                MessageBox.Show("Algun campo esta vacio", "Algun campo vacio", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                if (File.MySqlConnectionWriter(filename,tBhost.Text,tBbd.Text,tBusuario.Text,tBpass.Text))
                {
                    MessageBox.Show("Datos gurdados correctamente","Guardado",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmConfiguraciónMySQL_Load(object sender, EventArgs e)
        {
            btnSalir.Focus();
        }
    }
}
