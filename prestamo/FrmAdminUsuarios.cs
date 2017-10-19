using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libValidaciones;
using libperloan;

namespace Perloan_Desktop
{
    public partial class FrmAdminUsuarios : Form
    {
        public string estado="Si"; //siempre activo ya que casilla de activo esta marcada por default
        Usuarios ClassUsuarios = new Usuarios();
        
        /// <summary>
        /// Carga inicial del formulario
        /// </summary>
        public void Inicio()
        {
            dGvUsuarios.Rows.Clear();
            if (ClassUsuarios.Leer() == true) //carga datos al datagredview desde middleware
            {
                if (Usuarios.Lector.HasRows)
                {
                    while (Usuarios.Lector.Read()) //datos de la bd
                    {
                        dGvUsuarios.Rows.Add(Usuarios.Lector.GetString(0), Usuarios.Lector.GetString(1), Usuarios.Lector.GetString(2), Usuarios.Lector.GetString(3), Usuarios.Lector.GetString(4), Usuarios.Lector.GetString(5), Usuarios.Lector.GetString(6), Usuarios.Lector.GetString(7)); // cargar datos
                    }
                }
                //if (Usuarios.Lector2.HasRows)
                //{
                //    while (Usuarios.Lector2.Read()) //datos de la bd
                //    {
                //        dGvUsuarios.Rows.Add(Usuarios.Lector2.GetString(0), Usuarios.Lector2.GetString(1), Usuarios.Lector2.GetString(2), Usuarios.Lector2.GetString(3), Usuarios.Lector2.GetString(4), Usuarios.Lector2.GetString(5), Usuarios.Lector2.GetString(6), Usuarios.Lector2.GetString(7)); // cargar datos
                //    }
                //}
                if (Usuarios.Lector3.HasRows)
                {
                    while (Usuarios.Lector3.Read()) //datos de la bd
                    {
                        dGvUsuarios.Rows.Add(Usuarios.Lector3.GetString(0), Usuarios.Lector3.GetString(1), Usuarios.Lector3.GetString(2), Usuarios.Lector3.GetString(3), Usuarios.Lector3.GetString(4), Usuarios.Lector3.GetString(5), Usuarios.Lector3.GetString(6), Usuarios.Lector3.GetString(7)); // cargar datos
                    }
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. " + Usuarios.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //EliminarRepetidos();
        }
        /// <summary>
        /// Elimina datos repetidos en datagridview
        /// </summary>
        public void EliminarRepetidos()
        {
            int m = 0;  // Apunta a la fila actual
            int n = dGvUsuarios.Rows.Count - 1;  // cantidad de filas en el DataGridView
            int k = 0;
            string estaFila, unaFila;

            while (m <= n)
            {
                k = 1;
                estaFila = String.Empty;

                // Relleno la cadena con los datos de toda la fila
                for (int i = 0; i < dGvUsuarios.Columns.Count - 1; i++)
                    estaFila = String.Concat(estaFila, dGvUsuarios.Rows[m].Cells[i].Value.ToString());

                while (k <= dGvUsuarios.Rows.Count - 1)
                {
                    unaFila = String.Empty;  // Fila a comparar

                    for (int i = 0; i < dGvUsuarios.Columns.Count - 1; i++)
                        unaFila = String.Concat(unaFila, dGvUsuarios.Rows[k].Cells[i].Value.ToString());

                    if (String.Compare(estaFila, unaFila) == 0 && k != m)
                    {
                        dGvUsuarios.Rows.RemoveAt(k); // Si son iguales remuevo unaFila solamente
                        n--;                            // Tamaño actual del DataGridView, al remover disminuye en uno
                        k--;
                    }
                    k++;
                }
                m++;
            }
        }
        /// <summary>
        /// Crea Usuario
        /// </summary>
        private void Crear()
        {
            if (cBactivo.Checked == false)
            {
                estado = "No";
            }
            else
            {
                estado = "Si";
            }
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
            else
            {
                try
                {
                    if (ClassUsuarios.Insertar(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true)
                    {
                        DialogResult dialog = MessageBox.Show("Usuario Agregado Correctamente ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBusuario.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Usuario repetido", "Se esta agregando a un usuario repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error en la alta de usuario", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Inicio();
        }
        /// <summary>
        /// Actualiza Usuario
        /// </summary>
        private void Actualizar()
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
                    if (ClassUsuarios.Actualizar(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Usuario seleccionado actualizado", "Actualizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBusuario.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Se esta actuaizando a un usuario inexistente" + Usuarios.Error, "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error al actualizar el usuario", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Inicio();
        }
        /// <summary>
        /// Elimina Usuario
        /// </summary>
        private void Eliminar()
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al usuario seleccionado? \n Es irreversible", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                if (ClassUsuarios.Eliminar(tBusuario.Text) == true)
                {
                    dialog = MessageBox.Show("Eliminado Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dialog = MessageBox.Show("Error: " + Usuarios.Error, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
            Inicio();
        }
        /// <summary>
        /// Limpia los datos nesarios del formulario
        /// </summary>
        private void Limpiar()
        {
            cbNivel.Text = cbNivel.Items[0].ToString(); //tipo de usuario, posible error de ejecución
            tBusuario.Clear();
            tBpass.Clear();
            tBnombre.Clear();
            tBappaterno.Clear();
            tBapmaterno.Clear();
            tBemail.Clear();
            cBactivo.Checked = true;
            Inicio();
        }
        public FrmAdminUsuarios()
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

        private void AdminUsuarios_Load(object sender, EventArgs e)
        {
            Inicio();
        }

        private void btCrear_Click(object sender, EventArgs e) //agrega usuarios
        {
            Crear();
        }

        private void btActualizar_Click(object sender, EventArgs e) // actuliza usuarios
        {
            Actualizar();
        }

        private void btEliminar_Click(object sender, EventArgs e) //elimina usuario
        {
            Eliminar();
        }

        private void btLimpiar_Click(object sender, EventArgs e) //limpia textbox
        {
            Limpiar();
        }

        private void tBnombre_Leave(object sender, EventArgs e) // valida nombre usuario
        {
            if (libValidaciones.libValidaciones.NombrePersonal(tBnombre.Text))
            {
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
            }
            else
            {
                tBemail.Focus();
                tBemail.SelectAll();
            }
        }
    }
}