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
        }

        private void btSalir_Click(object sender, EventArgs e) //boton salir
        {
            this.Close();
        }

        private void dGvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) //pasar fila seleccionada para editar
        {
            if (e.RowIndex != -1)
            {
                TbNumPrestamo.Text = dGvPrestamos[0, e.RowIndex].Value.ToString();
                cBbumDeudor.Text = dGvPrestamos[1, e.RowIndex].Value.ToString();
                TbMontoPrestamo.Text = dGvPrestamos[2, e.RowIndex].Value.ToString();
                TbPlazoSemanas.Text = dGvPrestamos[3, e.RowIndex].Value.ToString();
                CbNumPrenda.Text = dGvPrestamos[4, e.RowIndex].Value.ToString();
                TbNomPrenda.Text = dGvPrestamos[5, e.RowIndex].Value.ToString();
            }
            //cBbumDudor_SelectedIndexChanged(sender, e);
            //CbNumPrenda_SelectedIndexChanged(sender, e);
        }

        private void AdminPrestamo_Load(object sender, EventArgs e)
        {
            dGvPrestamos.Rows.Clear();
            //AccederBD basedatos = new AccederBD();
            BD basedatos = new libAccesoBD.BD();
            // inicio leer deudores
            if (basedatos.LeerDeudores()==true)
            {
                while (BD.Lector.Read())
                {
                    cBbumDeudor.Items.Add(BD.Lector.GetString(0));
                }
            }
            // fin leer deudores
            // inicio leer prendas
            if (basedatos.LeerPrendas() == true)
            {
                while (BD.Lector.Read())
                {
                    CbNumPrenda.Items.Add(BD.Lector.GetString(0));
                }
            }
            // fin leer prendas
            if (basedatos.LeerPrestamos() == true) //carga datos al datagredview
            {
                while (BD.Lector.Read()) //datos de la bd
                {
                    dGvPrestamos.Rows.Add(BD.Lector.GetString(0), BD.Lector.GetString(1), BD.Lector.GetString(2), BD.Lector.GetString(3), BD.Lector.GetString(4), BD.Lector.GetString(5)); // cargar datos
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
            if (cBbumDeudor.Text.Trim() == "") //verificar campos en blanco
            {
                if (cBbumDeudor.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Usuario Vacio", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBbumDeudor.Focus();
                }
                else if (TbPlazoSemanas.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Contraseña Vacia", "Campo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbPlazoSemanas.Focus();
                }
            }
            else
            {
                try
                {
                    //BD basedatos = new libAccesoBD.BD();
                    //if (basedatos.CrearUsuario(cbNivel.Text, tBusuario.Text, tBpass.Text, tBnombre.Text, tBappaterno.Text, tBapmaterno.Text, tBemail.Text, estado) == true) //verifica creación
                    //{
                    //    DialogResult dialog = MessageBox.Show("Usuario Agregado Correctamnte!!. ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    tBusuario.Focus();
                    //}
                    //else
                    //{
                    //    DialogResult dialog = MessageBox.Show("Usuario repetido", "Se esta agregando a un usuario repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    tBusuario.Focus();
                    //    tBusuario.SelectAll();
                    //}
                    //basedatos.DesconectarDB();
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
            if (TbMontoPrestamo.Text.Trim() == "" || TbPlazoSemanas.Text.Trim() == "") //verificar campos en blanco
            {
                DialogResult dialog = MessageBox.Show("Algun campo esta en blanco verificalo", "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    BD basedatos = new libAccesoBD.BD();
                    //if (basedatos.EditarUsuario(cbNivel.Text, TbNomDeudor.Text, tBpass.Text, TbMontoPrenda.Text, TbPlazoSemanas.Text, TbNomPrenda.Text, tBemail.Text, estado) == true) //verifica creación
                    //{
                    //    DialogResult dialog = MessageBox.Show("Usuario seleccionado actualizado", "Actualizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    TbNomDeudor.Focus();
                    //}
                    //else
                    //{
                    //    DialogResult dialog = MessageBox.Show("Se esta actuaizando a un usuario inexistente", "Usuario Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    TbNomDeudor.Focus();
                    //    TbNomDeudor.SelectAll();
                    //}
                    //basedatos.DesconectarDB();
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
            DialogResult dialog = MessageBox.Show("Quieres eliminar el prestamo seleccionado? \n ES IRREVERSIBLE", "Eliminar Prestamo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                BD basedatos = new libAccesoBD.BD();
                if (basedatos.EliminarPrestamo(TbNumPrestamo.Text) == true)
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
            TbMontoPrestamo.Clear();
            TbPlazoSemanas.Clear();
            TbNumPrestamo.Clear();
            AdminPrestamo_Load(sender, e);
        }

        private void tBnombre_Leave(object sender, EventArgs e) // valida nombre usuario
        {
            if (libValidaciones.libValidaciones.NombrePersonal(TbMontoPrestamo.Text))
            {
                nombre = true;
            }
            else
            {
                TbMontoPrestamo.Focus();
                TbMontoPrestamo.SelectAll();
            }
        }

        private void tBappaterno_Leave(object sender, EventArgs e) // valida apellido paterno usuario
        {
            if (libValidaciones.libValidaciones.NombrePersonal(TbPlazoSemanas.Text))
            {
                apellidop = true;
            }
            else
            {
                TbPlazoSemanas.Focus();
                TbPlazoSemanas.SelectAll();
            }
        }

        private void CbNumPrenda_SelectedIndexChanged(object sender, EventArgs e)
        {
            BD basedatos = new libAccesoBD.BD();
            if (basedatos.LeerPrendaID(CbNumPrenda.Text) == true) //cargar label nombre de prenda con el nombre de prenda
            {
                while (BD.Lector.Read())
                {
                    TbNomPrenda.Text=BD.Lector.GetString(2);
                }
            }
        }

        private void cBbumDuedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            BD basedatos = new libAccesoBD.BD();
            //if (basedatos.LeerDuedorID(cBbumDudor.Text) == true) //cargar label nombre de prenda con el nombre de prenda
            if (basedatos.LeerDuedorID(cBbumDeudor.Text) == true)
            {
                while (BD.Lector.Read())
                {
                    tBNombreDudor.Text = BD.Lector.GetString(1)+" "+ BD.Lector.GetString(2);
                }
            }
            else
            {
                MessageBox.Show("" + BD.Error);
            }
        }
    }
}