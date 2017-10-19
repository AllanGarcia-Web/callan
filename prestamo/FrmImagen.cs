using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perloan_Desktop
{
    public partial class FrmImagen : Form
    {
        Imagen img = new Imagen();
        public static ComboBox cbListaFotosBD = new ComboBox();
        public static PictureBox paspic = new PictureBox();
        private OpenFileDialog Open = new OpenFileDialog();
        public FrmImagen()
        {
            InitializeComponent();
        }
        private void LeerLista()
        {
            for (int i = 0; i < cbListaFotosBD.Items.Count; i++)
            {
                cbListaFotosBD.SelectedIndex = i;
                cbListaFotos.Items.Add(cbListaFotosBD.Text);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Open.Title = "Selecciona un archivo a cargar";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                pBimagen.Load(Open.FileName);
                txtDescripcion.Text = Open.SafeFileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            img.abrirConexion();
            img.cargarImagenes();
            LeerLista();
            //if (cbListaFotos.Items.Count > 0)
            //{
            //    cbListaFotos.SelectedIndex = 0;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            paspic = pBimagen;
            MessageBox.Show(img.insertarImagen(txtDescripcion.Text));
            cbListaFotosBD.Items.Clear();
            cbListaFotos.Items.Clear();
            img.cargarImagenes();
            LeerLista();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            paspic = pBimagen;
            img.verImagen(cbListaFotos.SelectedItem.ToString());
        }

        private void tbBuscarimg_Click(object sender, EventArgs e)
        {
            Open.Title = "Selecciona un archivo a cargar";
            if (Open.ShowDialog() == DialogResult.OK)
            {
                //pBimagen.Load(Open.FileName);
                tBbuscar.Text = Open.SafeFileName;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            paspic = pBserver;
            img.verImagen(tBbuscar.Text);
            MessageBox.Show(img.verImagen(tBbuscar.Text));
        }
    }
}
