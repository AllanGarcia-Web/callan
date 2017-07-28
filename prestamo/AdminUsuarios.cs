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
    public partial class AdminUsuarios : Form
    {
        public string estado="Si"; //siempre activo ya que casilla de activo esta marcada por default

        public AdminUsuarios()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            cbNivel.Text = cbNivel.Items[0].ToString(); //deja cargado Cobrador por default
            cBactivo.Checked = true; //casilla activada por default
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            if (cBactivo.Checked == false)
            {
                estado = "No";
            }
            if (tBnombre.Text.Trim() == "" || tBappaterno.Text.Trim() == "" || tBusuario.Text.Trim() == "" || tBpass.Text.Trim() == "" || tBemail.Text.Trim() == "") //verificar campos en blanco
            {
                MessageBox.Show("Algun campo esta en blanco verificalo");
                tBusuario.Focus();
            }
            else
            {
                try
                {
                    AccederBD basedatos = new AccederBD();
                    if (basedatos.CrearUsuario(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    {
                        MessageBox.Show("Agregado Correctamente");
                        tBusuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Se esta agregando a un usurio repetido");
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la alta de usuario");
                }
            }
        }
    }
}