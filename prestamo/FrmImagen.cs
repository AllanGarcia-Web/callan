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
using LibArchivo;

namespace Perloan_Desktop
{
    public partial class FrmImagen : Form
    {
        private OpenFileDialog openFile = new OpenFileDialog();
        /// <summary>
        /// Formulario de manejo de imagen
        /// </summary>
        public FrmImagen()
        {
            InitializeComponent();
        }
        string path;
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                openFile.Title = "Selecciona archivo a cargar";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    pBimagenaguardar.Load(openFile.FileName); //cargar picturebox
                }
                tBnombre.Text = openFile.SafeFileName;
                path = openFile.FileName;
            }
            catch (IOException Error)
            {
                MessageBox.Show("No se pudo seleccionar la imagen "+Error);
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            MySQL mysql = new MySQL();
            Imagen Img = new Imagen();
            byte[] ImageData = File.ReadAllBytes(path);
            //System.IO.MemoryStream ms = new System.IO.MemoryStream(ImageData);
            //if (mysql.Insertar("imagen", "name, image", "'"+tBnombre.Text+"',"+ ImageData +""))
            if (Img.Guardar(tBnombre.Text,openFile.SafeFileName,ImageData))
            {
                MessageBox.Show("Cargado");
            }
            else
            {
                MessageBox.Show(MySQL.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                openFile.Title = "Selecciona Imagen a buscar";
                //pBimagenguardada.Load(openFile.FileName);
                tBnombreBD.Text = openFile.SafeFileName;
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
