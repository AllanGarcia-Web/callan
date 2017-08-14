using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libperloan;
using libValidaciones;

namespace prestamo
{
    public partial class AdminPrenda : Form
    {
        public string estado="Si"; //siempre activo ya que casilla de activo esta marcada por default
        // resultados de validaciones
        public bool nombre = false;
        public bool apellidop = false;
        public bool email = false;
        // fin de resultados validaciones
        Prestamo ClassPrestamos = new Prestamo();
        Deudores ClassDeudores = new Deudores();
        Prenda ClassPrenda = new Prenda();

        public AdminPrenda()
        {
            InitializeComponent();
            cbTipoPrenda.Text = cbTipoPrenda.Items[0].ToString(); //deja cargado automovil por default
        }
        private void AdminPrenda_Load(object sender, EventArgs e)
        {
            dGvPrendas.Rows.Clear();
            if (ClassPrenda.Leer() == true) //carga datos al datagredview con la clase prenda
            {
                while (Prenda.Lector.Read()) //datos de la bd
                {
                    dGvPrendas.Rows.Add(Prenda.Lector.GetString(0), Prenda.Lector.GetString(1), Prenda.Lector.GetString(2), Prenda.Lector.GetString(3), Prenda.Lector.GetString(4), Prenda.Lector.GetString(5)); // cargar datos
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. " + Prenda.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dGvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e) //pasar fila seleccionada para editar
        {
            if (e.RowIndex != -1)
            {
                tBnumPrenda.Text = dGvPrendas[0, e.RowIndex].Value.ToString(); 
                cbTipoPrenda.Text = dGvPrendas[1, e.RowIndex].Value.ToString();
                tBnombre.Text = dGvPrendas[2, e.RowIndex].Value.ToString();
                rTdescripcion.Text = dGvPrendas[3, e.RowIndex].Value.ToString();
                rTdetalles.Text = dGvPrendas[4, e.RowIndex].Value.ToString();
                tBnumDeudor.Text = dGvPrendas[5, e.RowIndex].Value.ToString();
            }
        }

        private void btCrear_Click(object sender, EventArgs e) //agrega prenda
        {
            if (tBnombre.Text.Trim() == "" || rTdescripcion.Text.Trim() == "") //verificar campos en blanco
            {
                if (tBnombre.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Ingrese un nombre para la prenda", "Nombre Vacio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tBnombre.Focus();
                }
                else if (tBNombreDudor.Text.Trim() == "")
                {
                    DialogResult dialog = MessageBox.Show("Ingrese una descripción para la penda", "Descripción Vacia", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    rTdescripcion.Focus();
                }
            }
            else
            {
                try
                {
                    if (ClassPrenda.Insertar(cbTipoPrenda.Text,tBnombre.Text,rTdescripcion.Text,rTdetalles.Text) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Prenda Agregada Correctamnte", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBnombre.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Nombre de prenda repetido"+Prenda.Error, "Prenda Repetida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBnombre.Focus();
                        tBnombre.SelectAll();
                    }
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error en la alta de la prenda"+Prenda.Error, "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AdminPrenda_Load(sender,e);
        }

        private void btActualizar_Click(object sender, EventArgs e) // actuliza usuarios
        {
            if (tBnombre.Text.Trim() == "" || cbTipoPrenda.Text.Trim() == "" || rTdescripcion.Text.Trim() == "") //verificar campos en blanco
            {
                DialogResult dialog = MessageBox.Show("Algun campo esta en blanco verificalo", "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tBnombre.Focus();
            }
            else
            {
                try
                {
                    if (ClassPrenda.Actualizar(tBnumPrenda.Text,cbTipoPrenda.Text,tBnombre.Text,rTdescripcion.Text,rTdetalles.Text) == true) //verifica creación
                    {
                        DialogResult dialog = MessageBox.Show("Prenda seleccionada actualizada", "Actualizada Correctamente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tBnombre.Focus();
                    }
                    else
                    {
                        DialogResult dialog = MessageBox.Show("Se esta actuaizando a una prenda inexistente"+Prenda.Error, "Prenda Inexistente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        tBnombre.Focus();
                        tBnombre.SelectAll();
                    }
                }
                catch (Exception)
                {
                    DialogResult dialog = MessageBox.Show("Error al actualizar la prenda seleccionada"+Prenda.Error, "Error al actualizar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            AdminPrenda_Load(sender, e);
        }

        private void btEliminar_Click(object sender, EventArgs e) //elimina usuarios
        {
            DialogResult dialog = MessageBox.Show("Quieres eliminar la prenda seleccionada? \n ES IRREVERSIBLE", "Eliminar Prenda", MessageBoxButtons.YesNo, MessageBoxIcon.Warning); //confima salida del sistema
            if (dialog == DialogResult.Yes)
            {
                if (ClassPrenda.Eliminar(tBnumPrenda.Text) == true)
                {
                    dialog = MessageBox.Show("Eliminada Correctamente", "Eliminado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    dialog = MessageBox.Show("Error: " + Prenda.Error, "Error general", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (dialog == DialogResult.No)
            {
                //regresa a la ventana anterior
            }
            AdminPrenda_Load(sender, e);
        }

        private void btLimpiar_Click(object sender, EventArgs e) //limpia textbox
        {
            cbTipoPrenda.Text = cbTipoPrenda.Items[0].ToString(); //tipo de usuario, posible error de ejecución
            tBnumPrenda.Clear();
            tBnumDeudor.Clear();
            tBNombreDudor.Clear();
            tBnombre.Clear();
            rTdescripcion.Clear();
            rTdetalles.Clear();
            AdminPrenda_Load(sender, e);
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

        private void btSalir_Click(object sender, EventArgs e) //boton salir
        {
            this.Close();
        }

        private void tBnumDeudor_TextChanged(object sender, EventArgs e) // carga el nombre del deudor basado en el id de la tabla deudores
        {
            if (ClassPrestamos.LeerDuedorID(tBnumDeudor.Text) == true)
            {
                while (Prestamo.Lector.Read())
                {
                    tBNombreDudor.Text = Prestamo.Lector.GetString(1) + " " + Prestamo.Lector.GetString(2);
                }
            }
            else
            {
                MessageBox.Show("" + Prestamo.Error);
            }
        }
    }
}