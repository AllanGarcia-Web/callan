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
using libperloan;

namespace Perloan_Desktop
{ 
    public partial class FrmInicio : Form
    {
        
        public FrmInicio()
        {
            InitializeComponent();
            tBusuario.Focus();
        }
        #region Singleton
        /// <summary>
        /// Uso de sigletion en formulario
        /// </summary>
        private static FrmInicio _instance;
        public FrmInicio instance
        {
            get
            {
                if (FrmInicio._instance == null)
                {
                    FrmInicio._instance = new FrmInicio();
                }
                else
                {
                    MessageBox.Show("Ya esta abierto menu inicio, se volvera a mostrar");
                }
                return FrmInicio._instance;
            }
        }
        #endregion
        /// <summary>
        /// Acceder al sistema
        /// </summary>
        private void Login()
        {
            if (tBusuario.Text.Trim() == "" || tBpass.Text.Trim() == "")
            {
                DialogResult dialog = MessageBox.Show("El usuario o contraseña estan en blanco", "Campos en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (tBusuario.Text.Trim() == "")
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
                Usuarios ClassUsuarios = new Usuarios(); //clase usuarios
                if (ClassUsuarios.Login(tBusuario.Text, tBpass.Text)) //verifica estado de acceso para el error
                {
                    if (Usuarios.valor == 0)
                    {
                        this.Hide();
                        FrmMenu menu = new FrmMenu(Usuarios.valor, Usuarios.nivel, Usuarios.nombre, Usuarios.ApellidoP, Usuarios.ApellidoM);
                        menu.instance.Show();
                    }
                    else
                    {
                        this.Hide();
                        FrmMenuUsuario menusuario = new FrmMenuUsuario(Usuarios.valor, Usuarios.nivel, Usuarios.nombre, Usuarios.ApellidoP, Usuarios.ApellidoM);
                        menusuario.instance.Show();
                    }
                    //new FrmMenu(Usuarios.valor, Usuarios.nivel, Usuarios.nombre, Usuarios.ApellidoP, Usuarios.ApellidoM).ShowDialog();
                }
                else
                {
                    DialogResult dialog = MessageBox.Show("Error: " + Usuarios.Error, "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error); //especifica el error
                    tBusuario.Focus();
                }
            }
        }
        /// <summary>
        /// Salir del sistema
        /// </summary>
        private void Salir()
        {
            DialogResult dialog = MessageBox.Show("¿Quieres salir del sistema?", "Salir del Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (dialog == DialogResult.No)
            {
                tBusuario.Focus();
            }
        }
        private void BtnAcceso_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Salir();
        }
        private void LinkLabelAyuda_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/perloan");
        }
        private void Inicio_Load(object sender, EventArgs e)
        {
            this.lblVer.Text = String.Format("Versión {0}", Assembly.GetExecutingAssembly().GetName().Version.ToString());
            tBusuario.Focus();
        }

        private void btnVer_MouseHover(object sender, EventArgs e)
        {
            tBpass.UseSystemPasswordChar = false;
        }

        private void btnVer_MouseLeave(object sender, EventArgs e)
        {
            tBpass.UseSystemPasswordChar = true;
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmInicio inicio = new FrmInicio();
            inicio.instance.Show();
        }
    }
}