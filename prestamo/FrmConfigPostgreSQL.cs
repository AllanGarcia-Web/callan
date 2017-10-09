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
    public partial class FrmConfigPostgreSQL : Form
    {
        private string filename = "postgresql.ini";
        ArchivosBD File = new ArchivosBD();
        /// <summary>
        /// Carga configuración de BD
        /// </summary>
        private void CargaConf()
        {
            if (File.PostgreSQLConnectionRead(filename))
            {
                tbPostgreSQL.Text = File.PostgreSQL;
            }
            else
            {
                MessageBox.Show("Error al leer el archivo de configuración de PostgreSQL: " + filename, "Error al leer el archivo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (File.PostgreSQLConnectionWriter(filename, tBhost.Text, tBbd.Text, tBusuario.Text, tBpass.Text))
                {
                    MessageBox.Show("Datos gurdados correctamente", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        public FrmConfigPostgreSQL()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarConf();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
