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
        public bool monto = false;
        public bool plazo = false;
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
        }

        private void AdminPrestamo_Load(object sender, EventArgs e)
        {
            dGvPrestamos.Rows.Clear(); //limpia datgrid
            cBbumDeudor.Items.Clear(); //limpia combo de deudor
            CbNumPrenda.Items.Clear(); //limpia combo de prenda
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
            if (cBbumDeudor.Text.Trim() == "" || CbNumPrenda.Text.Trim() == "" || TbMontoPrestamo.Text.Trim() == "" || TbPlazoSemanas.Text.Trim() == "") //verificar campos en blanco
            {
                if (TbMontoPrestamo.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Cantidar a prestar vacia", "Prestamo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBbumDeudor.Focus();
                }
                else if (TbPlazoSemanas.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Semanas del Plazo Vacio", "Plazo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbPlazoSemanas.Focus();
                }
            }
            else
            {
                try
                {
                    BD basedatos = new libAccesoBD.BD();
                    if (basedatos.CrearPrestamo(cBbumDeudor.Text, TbMontoPrestamo.Text, TbPlazoSemanas.Text, CbNumPrenda.Text, TbNomPrenda.Text, tBNombreDudor.Text) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Prestamo Registrado \n Consulte No. de Prestamo ", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TbMontoPrestamo.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Se le esta asignado otro presteamo al mismo deudor", "Deudor con Prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cBbumDeudor.Focus();
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
            if (cBbumDeudor.Text.Trim() == "" || CbNumPrenda.Text.Trim() == "" || TbMontoPrestamo.Text.Trim() == "" || TbPlazoSemanas.Text.Trim() == "") //verificar campos en blanco
            {
                if (TbMontoPrestamo.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Cantidad a prestar vacia", "Prestamo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cBbumDeudor.Focus();
                }
                else if (TbPlazoSemanas.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Semanas del Plazo Vacio", "Plazo Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    TbPlazoSemanas.Focus();
                }
            }
            else
            {
                try
                {
                    BD basedatos = new libAccesoBD.BD();
                    if (basedatos.EditarPrestamo(TbNumPrestamo.Text ,cBbumDeudor.Text, TbMontoPrestamo.Text, TbPlazoSemanas.Text, CbNumPrenda.Text, TbNomPrenda.Text, tBNombreDudor.Text) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Prestamo seleccionado actualizado", "Actualizado Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        TbMontoPrestamo.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Se esta actualizando un prestamo inexistente \n Por favor verifique ", "Prestamo Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TbNumPrestamo.Focus();
                    }
                    basedatos.DesconectarDB();
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error al actualizar el prestamo", "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void TbMontoPrestamo_Leave(object sender, EventArgs e) // valida nombre usuario
        {
            if (libValidaciones.libValidaciones.Numeros(TbMontoPrestamo.Text))
            {
                monto = true;
            }
            else
            {
                TbMontoPrestamo.Focus();
                TbMontoPrestamo.SelectAll();
            }
        }

        private void TbPlazoSemanas_Leave(object sender, EventArgs e) // valida apellido paterno usuario
        {
            if (libValidaciones.libValidaciones.Numeros(TbPlazoSemanas.Text))
            {
                plazo = true;
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