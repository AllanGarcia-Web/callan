using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using libAccesoBD;

namespace prestamo
{ 
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }
        private void btAcceso_Click(object sender, EventArgs e)
        {
            if (tBusuario.Text.Trim() == "" || tBpass.Text.Trim() == "") //verifica que no este vacio
            {
                MessageBox.Show("Error: El usuario o contraseña estan en blanco");
                if (tBusuario.Text.Trim() == "") //vemos cual esta vacio y mandamos el focus al lugar vacio
                {
                    tBusuario.Focus();
                }
                else
                {
                    tBpass.Focus();
                }
            }
            else
            {
                bd basedatos = new libAccesoBD.bd();
                if (basedatos.login(tBusuario.Text, tBpass.Text) == true) //verifica estado de acceso para el error
                {
                    new menu().ShowDialog();
                }
                else
                {
                    MessageBox.Show("Error: " + bd.Error); //especifica el error
                }
                basedatos.DesconectarDB();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e) //boton salir
        {
            DialogResult dialog = MessageBox.Show("Quieres salir del sistema?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //new AboutBox1().ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/trabajos/analisis");
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            this.lbVer.Text = String.Format("Versión {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
    }
}