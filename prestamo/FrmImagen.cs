using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using libAccesoBD;
using MySql.Data.MySqlClient;

namespace prestamo
{
    public partial class FrmImagen : Form
    {
        public FrmImagen()
        {
            InitializeComponent();
        }
        string path;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Selecciona archivo a cargar";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pBimagenaguardar.Image = System.Drawing.Image.FromFile(openFile.FileName);
            }
            tBnombre.Text = openFile.SafeFileName;
            path = openFile.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openFile.Title = "Selecciona Imagen a buscar";
                //pBimagenguardada.Image = System.Drawing.Image.FromFile(openFile.FileName);
                tBnombreBD.Text = openFile.SafeFileName;
                
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //FileStream fs;
            //BinaryReader br;
            string FileName = path;
            byte[] ImageData = File.ReadAllBytes(path);
            //fs = new FileStream(FileName, FileMode.Open, FileAccess.Read);
            //br = new BinaryReader(fs);
            //ImageData = br.ReadBytes((int)fs.Length);
            //br.Close();
            //fs.Close();
            MySQL mysql = new MySQL();
            if (mysql.Insertar("imagen", "name, image", "'"+tBnombre.Text+"',"+ ImageData +""))
            {
                MessageBox.Show("Cargado");
            }
            else
            {
                MessageBox.Show(MySQL.Error);
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            if (mysql.Leer("*", "imagen WHERE name='" + tBnombreBD.Text + "'"))
            {
                while (MySQL.Lector.Read())
                {
                    sbyte ImageData = MySQL.Lector.GetSByte(0);
                    using (var byteStream = new MemoryStream(ImageData))
                    {
                        pBimagenguardada.Image = new Bitmap(byteStream);
                    }
                    //pBimagenguardada.Image = System.Drawing.Image.FromStream(BD.Lector.GetStream(0));
                }
            }
            else
            {
                MessageBox.Show(MySQL.Error);
            }
        }
    }
}
