using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;
using libAccesoBD;
using libValidaciones;

namespace prestamo
{
    public partial class AdminDeudores : Form
    {
        public AdminDeudores()
        {
            InitializeComponent();
        }
        // resultados de validaciones
        public bool nombre = false;
        public bool apellidop = false;
        public bool apellidom = true; //por el momento true
        public bool calle = false;
        public bool numerodomicilio = false;
        public bool curp = false;
        public bool rfc = false;
        public bool telefono = false;
        public bool email = false;
        public bool ine = false;
        public bool numero = false;
        public bool colonia = false;
        public bool ciudad = false;
        public bool codigopostal = false;
        public bool estado = false;
        public bool telefonoaval = false;
        public bool nombreaval = false;
        // de resultados de validaciones

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar form
        }

        private void AdminDeudores_Load(object sender, EventArgs e)
        {
            cBestados.Text = cBestados.Items[0].ToString(); //cargar aguascalientes
            dGvDeudores.Rows.Clear();
            BD basedatos = new libAccesoBD.BD();
            if (basedatos.LeerDeudores() == true)
            {
                while (BD.Lector.Read()) //datos de la bd
                {
                    dGvDeudores.Rows.Add(BD.Lector.GetInt32(0).ToString(), BD.Lector.GetString(1), BD.Lector.GetString(2), BD.Lector.GetString(3), BD.Lector.GetString(4), BD.Lector.GetString(5), BD.Lector.GetString(6), BD.Lector.GetString(7), BD.Lector.GetString(8), BD.Lector.GetString(9), BD.Lector.GetString(10), BD.Lector.GetString(11), BD.Lector.GetString(12), BD.Lector.GetString(13), BD.Lector.GetString(14), BD.Lector.GetString(15)); // cargar datos
                }
                basedatos.DesconectarDB();
            }
            else
            {
                MessageBox.Show("Error al leer datos. " + BD.Error);
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
                    BD basedatos = new libAccesoBD.BD();
                    if (basedatos.CrearDeudor(tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tbIne.Text, tbCalle.Text, tbNumero.Text, tbColonia.Text, tbCiudad.Text, tbCodigoPostal.Text, cBestados.Text, tbTelefono.Text, tbAval.Text, tbTelefonoAval.Text, tBemail.Text) == true) //verifica creación
                    {
                        MessageBox.Show("Agregado Correctamente");
                        tBnombre.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Se esta agregando a un usuario repetido" + BD.Error);
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
            AdminDeudores_Load(sender, e); // recargar datagrid
        }

        private void btActualizar_Click(object sender, EventArgs e)
        {
            BD basedatos = new libAccesoBD.BD();
            if (basedatos.EditarDeudor(tBdeudor.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tbIne.Text, tbCalle.Text, tbNumero.Text, tbColonia.Text, tbCiudad.Text, tbCodigoPostal.Text, cBestados.Text, tbTelefono.Text, tbAval.Text, tbTelefonoAval.Text, tBemail.Text) == true) //verifica creación
            {
                MessageBox.Show("Actualizado Correctamente");
                tBnombre.Focus();
            }
            else
            {
                MessageBox.Show("Error al actualizar" + BD.Error);
                tBnombre.Focus();
                tBnombre.SelectAll();
            }
            AdminDeudores_Load(sender, e); // recargar datagrid
            btLimpiar_Click(sender, e); //llamar a boton limpiar
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al deudor seleccionado? ESTO ES IRREBERSIBLE", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                BD basedatos = new libAccesoBD.BD();
                if (basedatos.EliminarDeudor(tBdeudor.Text) == true)
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("" + BD.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
            AdminDeudores_Load(sender, e); // recargar datagrid
            btLimpiar_Click(sender, e); //llamar a boton limpiar
        }

        private void btLimpiar_Click(object sender, EventArgs e) //limpiar campos
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
            cBestados.Text = cBestados.Items[0].ToString(); //cargar aguascalientes
            tbTelefono.Clear();
            tbAval.Clear();
            tbTelefonoAval.Clear();
            tBemail.Clear();
            tBnombre.Focus();
        }

        private void dGvDeudores_CellClick(object sender, DataGridViewCellEventArgs e) //cargar datos de dudores a los campos para edición
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
                cBestados.Text = dGvDeudores[10, e.RowIndex].Value.ToString();
                tbTelefono.Text = dGvDeudores[11, e.RowIndex].Value.ToString();
                tbAval.Text = dGvDeudores[12, e.RowIndex].Value.ToString();
                tbTelefonoAval.Text = dGvDeudores[13, e.RowIndex].Value.ToString();
                tBemail.Text = dGvDeudores[14, e.RowIndex].Value.ToString();
            }
        }

        private void tBnombre_Leave(object sender, EventArgs e) //validar nombre
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tBnombre.Text))
            {
                nombre = true;
            }
            else
            {
                tBnombre.Focus();
                tBnombre.SelectAll();
            }
        }

        private void tBappaterno_Leave(object sender, EventArgs e) //validar apellido paterno
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tBappaterno.Text))
            {
                apellidop = true;
            }
            else
            {
                tBappaterno.Focus();
                tBappaterno.SelectAll();
            }
        }

        private void tBapmaterno_Leave(object sender, EventArgs e)
        {
            //if (libValidaciones.libValidaciones.NombrePersonal(tBapmaterno.Text))
            //{
            //    //nonbre = true;
            //    //sin acción ya que es opcional
            //}
            //else
            //{
            //    tBapmaterno.Focus();
            //    tBapmaterno.SelectAll();
            //}
        }

        private void tbIne_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.INE(tbIne.Text))
            {
                ine = true;
            }
            else
            {
                tbIne.Focus();
                tbIne.SelectAll();
            }
        }

        private void tbCalle_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Direccion(tbCalle.Text))
            {
                calle = true;
            }
            else
            {
                tbCalle.Focus();
                tbCalle.SelectAll();
            }
        }

        private void tbNumero_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Numeros(tbNumero.Text))
            {
                numero = true;
            }
            else
            {
                tbNumero.Focus();
                tbNumero.SelectAll();
            }
        }

        private void tbColonia_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Direccion(tbColonia.Text))
            {
                colonia = true;
            }
            else
            {
                tbColonia.Focus();
                tbColonia.SelectAll();
            }
        }

        private void tbCiudad_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Direccion(tbCiudad.Text))
            {
                ciudad = true;
            }
            else
            {
                tbCiudad.Focus();
                tbCiudad.SelectAll();
            }
        }

        private void tbCodigoPostal_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Numeros(tbCodigoPostal.Text))
            {
                codigopostal = true;
            }
            else
            {
                tbCodigoPostal.Focus();
                tbCodigoPostal.SelectAll();
            }
        }

        private void tbAval_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tbAval.Text))
            {
                nombreaval = true;
            }
            else
            {
                tbAval.Focus();
                tbAval.SelectAll();
            }
        }

        private void tbTelefonoAval_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Telefono(tbTelefonoAval.Text))
            {
                telefonoaval = true;
            }
            else
            {
                tbTelefonoAval.Focus();
                tbTelefonoAval.SelectAll();
            }
        }

        private void tbTelefono_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Telefono(tbTelefono.Text))
            {
                telefono = true;
            }
            else
            {
                tbTelefono.Focus();
                tbTelefono.SelectAll();
            }
        }

        private void tBemail_Leave(object sender, EventArgs e)
        {
            if (libValidaciones.libValidaciones.Email(tBemail.Text))
            {
                email = true;
            }
            else
            {
                tBemail.Focus();
                tBemail.SelectAll();
            }
        }
    }
}