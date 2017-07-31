using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            BD basedatos = new libAccesoBD.BD(); //conexión a libreria
            if (BD.valor == 1) //verificar que es cobrador
            {
                usuariosToolStripMenuItem.Visible = false; //desactivar acceso a usuario a cobrador
            }
        }

        private string GetComputer_LanIP() //obtine la ip local
        {
            string strHostName = System.Net.Dns.GetHostName();

            IPHostEntry ipEntry = System.Net.Dns.GetHostEntry(strHostName);

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

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminUsuarios().ShowDialog();
        }

        private void deudoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AdminDeudores().ShowDialog();
        }

        private void menu_Load(object sender, EventArgs e)
        {
            lbnombre.Text = BD.nombre+" "+BD.ApellidoP+" "+BD.ApellidoM; //leer el nombre del usuario actual
        }

        private void acercaDelSisremaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutBox1().ShowDialog();
        }
    }
}
