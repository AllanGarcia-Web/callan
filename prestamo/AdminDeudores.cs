﻿using System;
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
using libperloan;

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
        public bool telefonoaval = false;
        public bool nombreaval = false;
        // de resultados de validaciones
        BD basedatos = new libAccesoBD.BD();
        libperloan.Deudores ClassDeudores = new Deudores();

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close(); //cerrar form
        }

        private void AdminDeudores_Load(object sender, EventArgs e)
        {
            cBestados.Text = cBestados.Items[0].ToString(); //cargar aguascalientes
            dGvDeudores.Rows.Clear();

            if (ClassDeudores.LeerDeudores() == true)
            {
                while (Deudores.Lector.Read()) //datos de la bd
                {
                    dGvDeudores.Rows.Add(Deudores.Lector.GetInt32(0).ToString(), Deudores.Lector.GetString(1), Deudores.Lector.GetString(2), Deudores.Lector.GetString(3), Deudores.Lector.GetString(4), Deudores.Lector.GetString(5), Deudores.Lector.GetString(6), Deudores.Lector.GetString(7), Deudores.Lector.GetString(8), Deudores.Lector.GetString(9), Deudores.Lector.GetString(10), Deudores.Lector.GetString(11), Deudores.Lector.GetString(12), Deudores.Lector.GetString(13), Deudores.Lector.GetString(14), Deudores.Lector.GetString(15)); // cargar datos
                }
                //ClassDeudores.DesconectarBD();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. " + Deudores.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCrear_Click(object sender, EventArgs e) //crea deudor
        {
            if (tBnombre.Text.Trim() == "" || tBappaterno.Text.Trim() == "" || tbCalle.Text.Trim() == "" || tbNumero.Text.Trim() == "" || tbCiudad.Text.Trim() == "" || tbCodigoPostal.Text.Trim() == "" || tbIne.Text.Trim() == "" || tbAval.Text.Trim() == "" || tbTelefonoAval.Text.Trim() == "") //verificar campos en blanco
            {
                DialogResult dialog = MessageBox.Show("Algun campo esta en blanco verificalo", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBnombre.Focus();
            }
            else
            {
                try
                {
                    BD basedatos = new libAccesoBD.BD();
                    if (basedatos.CrearDeudor(tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tbIne.Text, tbCalle.Text, tbNumero.Text, tbColonia.Text, tbCiudad.Text, tbCodigoPostal.Text, cBestados.Text, tbTelefono.Text, tbAval.Text, tbTelefonoAval.Text, tBemail.Text) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Agregado Correctamente", "Deudor Creado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBnombre.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Se esta repitiendo un deudor", "Deudor Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBnombre.Focus();
                        tBnombre.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error en la alta del deudor" + BD.Error, "Error al crear deudor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AdminDeudores_Load(sender, e); // recargar datagrid
        }

        private void btActualizar_Click(object sender, EventArgs e) //actualiza deudor
        {
            BD basedatos = new libAccesoBD.BD();
            if (basedatos.EditarDeudor(tBdeudor.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tbIne.Text, tbCalle.Text, tbNumero.Text, tbColonia.Text, tbCiudad.Text, tbCodigoPostal.Text, cBestados.Text, tbTelefono.Text, tbAval.Text, tbTelefonoAval.Text, tBemail.Text) == true) //verifica creación
            {
                DialogResult dialog = MessageBox.Show("Deudor actualizado satisfactoriamente" , "Deudor actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tBnombre.Focus();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Hubo un error al actuliazar al deudor", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBnombre.Focus();
                tBnombre.SelectAll();
            }
            AdminDeudores_Load(sender, e); // recargar datagrid
            btLimpiar_Click(sender, e); //llamar a boton limpiar
        }

        private void btEliminar_Click(object sender, EventArgs e) //elimina deudor
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al deudor seleccionado?\nESTO ES IRREVERSIBLE", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                if (ClassDeudores.EliminarDeudor(tBdeudor.Text) == true)
                {
                    dialog = MessageBox.Show("Deudor eliminado correctamente", "Deudor eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dialog = MessageBox.Show("Hubo un error al eliminar al deudor. " + Deudores.Error, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {
                //cancelar borrado
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

        private void tBapmaterno_Leave(object sender, EventArgs e) //valida apellido materno
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

        private void tbIne_Leave(object sender, EventArgs e) //valida ine
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

        private void tbCalle_Leave(object sender, EventArgs e) //valida calle
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tbCalle.Text))
            {
                calle = true;
            }
            else
            {
                tbCalle.Focus();
                tbCalle.SelectAll();
            }
        }

        private void tbNumero_Leave(object sender, EventArgs e) //valida numero domicilio
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

        private void tbColonia_Leave(object sender, EventArgs e) // valida colonia
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tbColonia.Text))
            {
                colonia = true;
            }
            else
            {
                tbColonia.Focus();
                tbColonia.SelectAll();
            }
        }

        private void tbCiudad_Leave(object sender, EventArgs e) // valida ciudad
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tbCiudad.Text))
            {
                ciudad = true;
            }
            else
            {
                tbCiudad.Focus();
                tbCiudad.SelectAll();
            }
        }

        private void tbCodigoPostal_Leave(object sender, EventArgs e) // codigo postal
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

        private void tbAval_Leave(object sender, EventArgs e) // valida nombre aval
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

        private void tbTelefonoAval_Leave(object sender, EventArgs e) // valida telefono aval
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

        private void tbTelefono_Leave(object sender, EventArgs e) // valida telefono deudor
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

        private void tBemail_Leave(object sender, EventArgs e) //valida email deudor
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