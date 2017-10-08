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
using System.Net;
using libAccesoBD;
using System.IO;

namespace prestamo
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
            //lbEquipo.Text= "Nombre del equipo: "+ Dns.GetHostName().ToString() +"       IP Local: "+GetComputer_LanIP().ToString() +"       IP Publica: "+GetComputer_InternetIP(); //nombre del equipo, ip local e ip externa (tarda en cargar ip externa)
            lbEquipo.Text = "Nombre del equipo: " + Dns.GetHostName().ToString() + "       IP Local: " + GetComputer_LanIP().ToString(); //nombre del equipo e ip local
            lbFecha.Text = "Fecha: " + DateTime.Today.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
            MySQL basedatos = new libAccesoBD.MySQL(); //conexión a libreria
            if (MySQL.valor == 1) //verificar que es cobrador, para desactivar modulos
            {
                usuariosToolStripMenuItem.Visible = false; //desactivar acceso a usuario a cobrador
                reporteDeUsuariosToolStripMenuItem.Visible = false; //desactiva acceso a reporte usuarios a cobrador
                btn_Usuarios.Visible = false; //desactiva boton usuarios a cobrador
                abrirUsuariosToolStripMenuItem.Visible = false; //desactiva Abrir Usuarios en menú secundario si es cobrador
            }
        }

        private void menu_Load(object sender, EventArgs e)
        {
            lbbienvenido.Text = "Bienvenido " + MySQL.nivel + ":";
            lbnombre.Text = MySQL.nombre + " " + MySQL.ApellidoP + " " + MySQL.ApellidoM; //leer el nombre del usuario actual
        }


        private string GetComputer_LanIP() //obtiene la ip local, para soporte remoto
        {
            string strHostName = Dns.GetHostName();

            IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);

            foreach (IPAddress ipAddress in ipEntry.AddressList)
            {
                if (ipAddress.AddressFamily.ToString() == "InterNetwork")
                {
                    return ipAddress.ToString();
                }
            }
            return "-";
        }

        private string GetComputer_InternetIP() //ip publica
        {
            // check IP using DynDNS's service
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org");
            WebResponse response = request.GetResponse();
            StreamReader stream = new StreamReader(response.GetResponseStream());

            // IMPORTANT: set Proxy to null, to drastically INCREASE the speed of request
            //request.Proxy = null;

            // read complete response
            string ipAddress = stream.ReadToEnd();

            // replace everything and keep only IP
            return ipAddress.
                Replace("<html><head><title>Current IP Check</title></head><body>Current IP Address: ", string.Empty).
                Replace("</body></html>", string.Empty);
        }


        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e) //abre admin de usuarios
        {
            AdminUsuarios.GetForm.ShowDialog();
            //new AdminUsuarios().ShowDialog();
        }

        private void deudoresToolStripMenuItem_Click(object sender, EventArgs e) //abre admin de deudores
        {
            new AdminDeudores().ShowDialog();
        }

        private void acercaDelSisremaToolStripMenuItem_Click(object sender, EventArgs e) //acerca de
        {
            new AboutBox1().ShowDialog();
        }

        private void prendasToolStripMenuItem_Click(object sender, EventArgs e) //abre admin de prendas
        {
            new AdminPrenda().ShowDialog();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminPrestamo().ShowDialog();
        }

        private void bt_salir_Click(object sender, EventArgs e) //boton salir
        {
            this.Close();
        }

        private void btn_Usuarios_Click(object sender, EventArgs e)
        {
            new AdminUsuarios().ShowDialog();
        }

        private void btn_Deudores_Click(object sender, EventArgs e)
        {
            new AdminDeudores().ShowDialog();
        }

        private void btn_Prestamos_Click(object sender, EventArgs e)
        {
            new AdminPrestamo().ShowDialog();
        }

        private void btn_Prendas_Click(object sender, EventArgs e)
        {
            new AdminPrenda().ShowDialog();
        }

        private void reporteDePrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReportePrestamos().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = "Fecha: " + DateTime.Today.ToLongDateString() + " " + DateTime.Now.ToLongTimeString();
        }

        private void ayudaDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/perloan");
        }

        private void reporteDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ReporteUsuario().ShowDialog();
        }

        private void abrirDeudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminDeudores().ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminUsuarios().ShowDialog();
        }

        private void abrirPrestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            new AdminPrestamo().ShowDialog();
        }

        private void abrirPrendaasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminPrenda().ShowDialog();
        }

        private void abrirAyudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sontechs.com/perloan");
        }
    }
}