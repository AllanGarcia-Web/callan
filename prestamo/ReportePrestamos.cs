using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libperloan;

namespace prestamo
{
    public partial class ReportePrestamos : Form
    {
        Prestamo ClassPrestamos = new Prestamo();

        public ReportePrestamos()
        {
            InitializeComponent();
        }

        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            if (ClassPrestamos.Leer() == true) //carga datos al datagredview
            {
                while (Prestamo.Lector.Read()) //datos de la bd
                {
                    dGvPrestamos.Rows.Add(Prestamo.Lector.GetString(0), Prestamo.Lector.GetString(1), Prestamo.Lector.GetString(2), Prestamo.Lector.GetString(3), Prestamo.Lector.GetString(4), Prestamo.Lector.GetString(5)); // cargar datos
                }
                //basedatos.DesconectarDB();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. " + Prestamo.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}