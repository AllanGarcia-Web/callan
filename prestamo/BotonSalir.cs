using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prestamo
{
    public partial class BotonSalir : UserControl
    {
        public BotonSalir()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres salir del sistema", "Cerrar el programa", MessageBoxButtons.YesNo); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a al ventana anterior
            }
        }
    }
}
