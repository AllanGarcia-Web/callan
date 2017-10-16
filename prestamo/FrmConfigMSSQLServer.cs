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

namespace Perloan_Desktop
{
    public partial class FrmConfigMSSQLServer : Form
    {
        private string filename = "mssqlserver.ini";
        ArchivosBD File = new ArchivosBD();
        /// <summary>
        /// Carga configuración de BD
        /// </summary>
        private void CargarConf()
        {
            if (File.MSSQLConnectionRead(filename))
            {
                tbMSSQLServer.Text = File.mssqlserver;
            }
            else
            {
                MessageBox.Show("Error al leer el archivo de configuración de MS SQL Server", "Error al leer el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Guarda configuración de BD
        /// </summary>
        private void GuardarConf()
        {
            if (tBhost.Text.Trim() == "" && tBusuario.Text.Trim() == "" && tBpass.Text.Trim() == "" && tBbd.Text.Trim() == "")
            {
                MessageBox.Show("Algun campo esta vacio", "Algun campo vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (File.MSSQLConnectionWrite(filename, tBhost.Text, tBbd.Text, tBusuario.Text, tBpass.Text))
                {
                    MessageBox.Show("Guardado Correctamente");
                }
                else
                {
                    MessageBox.Show("No se puedo escribir en el archivo de configuración: " + filename, "Erro al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public FrmConfigMSSQLServer()
        {
            InitializeComponent();
            CargarConf();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarConf();
        }
    }
}
