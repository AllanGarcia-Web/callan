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
    public partial class AdminDeudores : Form
    {
        public AdminDeudores()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDeudores_Load(object sender, EventArgs e)
        {

        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Guardado correctamente");
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Actualizado Correctamente");
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al deudor?", "Eliminar deudor", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                //accion para eleminar
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }
    }
}
