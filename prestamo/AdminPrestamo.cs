﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libAccesoBD;
using libValidaciones;

namespace prestamo
{
    public partial class AdminPrestamo : Form
    {
        public string estado="Si"; //siempre activo ya que casilla de activo esta marcada por default
        // resultados de validaciones
        public bool nombre = false;
        public bool apellidop = false;
        public bool email = false;
        // fin de resultados validaciones

        public AdminPrestamo()
        {
            InitializeComponent();
            cbNivel.Text = cbNivel.Items[0].ToString(); //deja cargado Cobrador por default
            cBactivo.Checked = true; //casilla activada por default
        }

        private void btSalir_Click(object sender, EventArgs e) //boton salir
        {
            this.Close();
        }

        private void dGvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) //pasar fila seleccionada para editar
        {
            if (e.RowIndex != -1)
            {
                cbNivel.Text = dGvUsuarios[0, e.RowIndex].Value.ToString(); //tipo de usuario, posible error de ejecución
                tBusuario.Text = dGvUsuarios[1, e.RowIndex].Value.ToString();
                tBpass.Text = dGvUsuarios[2, e.RowIndex].Value.ToString();
                tBnombre.Text = dGvUsuarios[3, e.RowIndex].Value.ToString();
                tBappaterno.Text = dGvUsuarios[4, e.RowIndex].Value.ToString();
                tBapmaterno.Text = dGvUsuarios[5, e.RowIndex].Value.ToString();
                tBemail.Text = dGvUsuarios[6, e.RowIndex].Value.ToString();
                if (dGvUsuarios[7, e.RowIndex].Value.ToString() == "No") //activar no desactivar la casilla de activo al leer
                {
                    cBactivo.Checked = false;
                }
                else if (dGvUsuarios[7, e.RowIndex].Value.ToString() == "Si")
                {
                    cBactivo.Checked = true;
                }
            }
        }

        private void AdminPrestamo_Load(object sender, EventArgs e)
        {
            dGvUsuarios.Rows.Clear();
            //AccederBD basedatos = new AccederBD();
            BD basedatos = new libAccesoBD.BD();
            if (basedatos.LeerUsuarios() == true) //carga datos al datagredview
            {
                while (BD.Lector.Read()) //datos de la bd
                {
                    dGvUsuarios.Rows.Add(BD.Lector.GetString(0), BD.Lector.GetString(1), BD.Lector.GetString(2), BD.Lector.GetString(3), BD.Lector.GetString(4), BD.Lector.GetString(5), BD.Lector.GetString(6), BD.Lector.GetString(7)); // cargar datos
                }
                basedatos.DesconectarDB();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. "+BD.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btCrear_Click(object sender, EventArgs e) //agrega usuarios
        {
            if (cBactivo.Checked == false)
            {
                estado = "No";
            }
            else
            {
                estado = "Si";
            }
            if (nombre == true && apellidop == true && email == true || tBusuario.Text.Trim() == "" || tBpass.Text.Trim() == "") //verificar campos en blanco
            {
                if (tBusuario.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Usuario Vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBusuario.Focus();
                }
                else if (tBpass.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Contraseña Vacia", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBpass.Focus();
                }
            }
            else
            {
                try
                {
                    BD basedatos = new libAccesoBD.BD();
                    if (basedatos.CrearUsuario(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Usuario Agregado Correctamnte!!. ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBusuario.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Usuario repetido", "Se esta agregando a un usuario repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error en la alta de usuario", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AdminPrestamo_Load(sender,e);
        }

        private void btActualizar_Click(object sender, EventArgs e) // actuliza usuarios
        {
            if (cBactivo.Checked == false)
            {
                estado = "No";
            }
            else
            {
                estado = "Si";
            }
            if (tBnombre.Text.Trim() == "" || tBappaterno.Text.Trim() == "" || tBusuario.Text.Trim() == "" || tBpass.Text.Trim() == "" || tBemail.Text.Trim() == "") //verificar campos en blanco
            {
                DialogResult dialog = MessageBox.Show("Algun campo esta en blanco verificalo", "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBusuario.Focus();
            }
            else
            {
                try
                {
                    BD basedatos = new libAccesoBD.BD();
                    if (basedatos.EditarUsuario(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Usuario seleccionado actualizado", "Actualizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBusuario.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Se esta actuaizando a un usuario inexistente", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error al actualizar el usuario", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AdminPrestamo_Load(sender, e);
        }

        private void btEliminar_Click(object sender, EventArgs e) //elimina usuarios
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al usuario seleccionado? \n Es irreversible", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                BD basedatos = new libAccesoBD.BD();
                if (basedatos.EliminarUsuario(tBusuario.Text) == true)
                {
                    dialog = MessageBox.Show("Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dialog = MessageBox.Show("Error: " + BD.Error, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                AdminPrestamo_Load(sender, e);
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
            AdminPrestamo_Load(sender, e);
        }

        private void btLimpiar_Click(object sender, EventArgs e) //limpia textbox
        {
            cbNivel.Text = cbNivel.Items[0].ToString(); //tipo de usuario, posible error de ejecución
            tBusuario.Clear();
            tBpass.Clear();
            tBnombre.Clear();
            tBappaterno.Clear();
            tBapmaterno.Clear();
            tBemail.Clear();
            cBactivo.Checked = true;
            AdminPrestamo_Load(sender, e);
        }

        private void tBnombre_Leave(object sender, EventArgs e) // valida nombre usuario
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

        private void tBappaterno_Leave(object sender, EventArgs e) // valida apellido paterno usuario
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

        private void tBemail_Leave(object sender, EventArgs e) // valida email usario
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