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
    public partial class AdminDeudores : Form
    {
        public AdminDeudores()
        {
            InitializeComponent();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdminDeudores_Load(object sender, EventArgs e)
        {
            dGvDeudores.Rows.Clear();
            AccederBD basedatos = new AccederBD();
            if (basedatos.LeerDeudores() == true)
            {
                while (AccederBD.Lector.Read()) //datos de la bd
                {
                    dGvDeudores.Rows.Add(AccederBD.Lector.GetInt32(0).ToString(), AccederBD.Lector.GetString(1), AccederBD.Lector.GetString(2), AccederBD.Lector.GetString(3), AccederBD.Lector.GetString(4), AccederBD.Lector.GetString(5), AccederBD.Lector.GetString(6), AccederBD.Lector.GetString(7), AccederBD.Lector.GetString(8), AccederBD.Lector.GetString(9), AccederBD.Lector.GetString(10), AccederBD.Lector.GetString(11), AccederBD.Lector.GetString(12), AccederBD.Lector.GetString(13), AccederBD.Lector.GetString(14), AccederBD.Lector.GetString(15)); // cargar datos
                }
                basedatos.DesconectarDB();
            }
            else
            {
                MessageBox.Show("Error al leer datos. " + AccederBD.Error);
            }
        }

        private void btCrear_Click(object sender, EventArgs e)
        {
            if (tBnombre.Text.Trim() == "" || tBappaterno.Text.Trim() == "" || tbCalle.Text.Trim() == "" || tbNumero.Text.Trim() == "" || tbCiudad.Text.Trim() == "" || tbCodigoPostal.Text.Trim() == "" || tbIne.Text.Trim() == "" || tbAval.Text.Trim() == "" || tbTelefonoAval.Text.Trim() == "") //verificar campos en blanco
            {
                MessageBox.Show("Algun campo esta en blanco verificalo");
                tBnombre.Focus();
            }
            else
            {
                try
                {
                    AccederBD basedatos = new AccederBD();
                    if (basedatos.CrearDeudor(tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tbIne.Text, tbCalle.Text, tbNumero.Text, tbColonia.Text, tbCiudad.Text, tbCodigoPostal.Text, tbEstado.Text, tbTelefono.Text, tbAval.Text, tbTelefonoAval.Text, tBemail.Text) == true) //verifica creación
                    {
                        MessageBox.Show("Agregado Correctamente");
                        tBnombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Se esta agregando a un usuario repetido" + AccederBD.Error);
                        tBnombre.Focus();
                        tBnombre.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la alta de usuario");
                }
            }
            AdminDeudores_Load(sender, e);
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            AccederBD basedatos = new AccederBD();
            if (basedatos.EditarDeudor(tBdeudor.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tbIne.Text, tbCalle.Text, tbNumero.Text, tbColonia.Text, tbCiudad.Text, tbCodigoPostal.Text, tbEstado.Text, tbTelefono.Text, tbAval.Text, tbTelefonoAval.Text, tBemail.Text) == true) //verifica creación
            {
                MessageBox.Show("Actualizado Correctamente");
                tBnombre.Focus();
            }
            else
            {
                MessageBox.Show("Error al actualizar" + AccederBD.Error);
                tBnombre.Focus();
                tBnombre.SelectAll();
            }
            AdminDeudores_Load(sender, e);
            btLimpiar_Click(sender, e);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al deudor seleccionado? ESTO ES IRREBERSIBLE", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                AccederBD basedatos = new AccederBD();
                if (basedatos.EliminarDeudor(tBdeudor.Text) == true)
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("" + AccederBD.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
            AdminDeudores_Load(sender, e);
            btLimpiar_Click(sender, e);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            tBdeudor.Clear();
            tBnombre.Clear();
            tBappaterno.Clear();
            tBapmaterno.Clear();
            tbIne.Clear();
            tbCalle.Clear();
            tbNumero.Clear();
            tbColonia.Clear();
            tbCiudad.Clear();
            tbCodigoPostal.Clear();
            tbEstado.Clear();
            tbTelefono.Clear();
            tbAval.Clear();
            tbTelefonoAval.Clear();
            tBemail.Clear();
            tBnombre.Focus();
        }

        private void dGvDeudores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                tBdeudor.Text = dGvDeudores[0, e.RowIndex].Value.ToString(); 
                tBnombre.Text = dGvDeudores[1, e.RowIndex].Value.ToString();
                tBappaterno.Text = dGvDeudores[2, e.RowIndex].Value.ToString();
                tBapmaterno.Text = dGvDeudores[3, e.RowIndex].Value.ToString();
                tbIne.Text = dGvDeudores[4, e.RowIndex].Value.ToString();
                tbCalle.Text = dGvDeudores[5, e.RowIndex].Value.ToString();
                tbNumero.Text = dGvDeudores[6, e.RowIndex].Value.ToString();
                tbColonia.Text = dGvDeudores[7, e.RowIndex].Value.ToString();
                tbCiudad.Text = dGvDeudores[8, e.RowIndex].Value.ToString();
                tbCodigoPostal.Text = dGvDeudores[9, e.RowIndex].Value.ToString();
                tbEstado.Text = dGvDeudores[10, e.RowIndex].Value.ToString();
                tbTelefono.Text = dGvDeudores[11, e.RowIndex].Value.ToString();
                tbAval.Text = dGvDeudores[12, e.RowIndex].Value.ToString();
                tbTelefonoAval.Text = dGvDeudores[13, e.RowIndex].Value.ToString();
                tBemail.Text = dGvDeudores[14, e.RowIndex].Value.ToString();
            }
        }
    }
}