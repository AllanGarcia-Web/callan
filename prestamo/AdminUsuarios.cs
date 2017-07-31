using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libAccesoBD;

namespace prestamo
{
    public partial class AdminUsuarios : Form
    {
        public string estado="Si"; //siempre activo ya que casilla de activo esta marcada por default

        public AdminUsuarios()
        {
            InitializeComponent();
            cbNivel.Text = cbNivel.Items[0].ToString(); //deja cargado Cobrador por default
            cBactivo.Checked = true; //casilla activada por default
        }

        private void btSalir_Click(object sender, EventArgs e)
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
            dGvUsuarios.Rows.Clear();
            //AccederBD basedatos = new AccederBD();
            bd basedatos = new libAccesoBD.bd();
            if (basedatos.LeerUsuarios() == true)
            {
                while (bd.Lector.Read()) //datos de la bd
                {
                    dGvUsuarios.Rows.Add(bd.Lector.GetString(0), bd.Lector.GetString(1), bd.Lector.GetString(2), bd.Lector.GetString(3), bd.Lector.GetString(4), bd.Lector.GetString(5), bd.Lector.GetString(6), bd.Lector.GetString(7)); // cargar datos
                }
                basedatos.DesconectarDB();
            }
            else
            {
                MessageBox.Show("Error al leer datos. "+bd.Error);
            }
        }

        private void btCrear_Click(object sender, EventArgs e)
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
                MessageBox.Show("Algun campo esta en blanco verificalo");
                tBusuario.Focus();
            }
            else
            {
                try
                {
                    bd basedatos = new libAccesoBD.bd();
                    if (basedatos.CrearUsuario(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    {
                        MessageBox.Show("Agregado Correctamente");
                        tBusuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Se esta agregando a un usuario repetido");
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error en la alta de usuario");
                }
            }
            AdminUsuarios_Load(sender,e);
        }

        private void btActualizar_Click(object sender, EventArgs e)
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
                MessageBox.Show("Algun campo esta en blanco verificalo");
                tBusuario.Focus();
            }
            else
            {
                try
                {
                    bd basedatos = new libAccesoBD.bd();
                    if (basedatos.EditarUsuario(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    {
                        MessageBox.Show("Usuario seleccionado actualizado");
                        tBusuario.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Se esta actuaizando a un usuario inexistente");
                        tBusuario.Focus();
                        tBusuario.SelectAll();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error al actualizar el usuario");
                }
            }
            AdminUsuarios_Load(sender, e);
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar al usuario seleccionado?", "Eliminar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                bd basedatos = new libAccesoBD.bd();
                if (basedatos.EliminarUsuario(tBusuario.Text) == true)
                {
                    MessageBox.Show("Eliminado Correctamente");
                }
                else
                {
                    MessageBox.Show("" + bd.Error);
                }
                AdminUsuarios_Load(sender, e);
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
            AdminUsuarios_Load(sender, e);
        }

        private void btLimpiar_Click(object sender, EventArgs e)
        {
            cbNivel.Text = cbNivel.Items[0].ToString(); //tipo de usuario, posible error de ejecución
            tBusuario.Clear();
            tBpass.Clear();
            tBnombre.Clear();
            tBappaterno.Clear();
            tBapmaterno.Clear();
            tBemail.Clear();
            cBactivo.Checked = true;
            AdminUsuarios_Load(sender, e);
        }
    }
}