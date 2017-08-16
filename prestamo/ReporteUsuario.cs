using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text.pdf; //generar el pdf
using iTextSharp.text; //datos para el pdf
using libperloan; //libreria de middleware perloan
using Microsoft.Office.Interop.Excel; //guardar en formato xlxs

namespace prestamo
{
    public partial class ReporteUsuario : Form
    {
        public ReporteUsuario()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            dGvUsuarios.Rows.Clear();
            Usuarios ClassUsuarios = new Usuarios();
            if (ClassUsuarios.Leer() == true) //carga datos al datagredview desde middleware
            {
                while (Usuarios.Lector.Read()) //datos de la bd
                {
                    dGvUsuarios.Rows.Add(Usuarios.Lector.GetString(0), Usuarios.Lector.GetString(1), Usuarios.Lector.GetString(2), Usuarios.Lector.GetString(3), Usuarios.Lector.GetString(4), Usuarios.Lector.GetString(5), Usuarios.Lector.GetString(6), Usuarios.Lector.GetString(7)); // cargar datos
                }
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. " + Usuarios.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
            File.FileName = "Reporte de Usuarios";
            if (File.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application app; //selecciona la app
                Microsoft.Office.Interop.Excel.Workbook libro; //genera libro para excel
                Microsoft.Office.Interop.Excel.Worksheet hoja; //genera la hoja del libro
                app = new Microsoft.Office.Interop.Excel.Application();
                libro = app.Workbooks.Add();
                hoja = (Microsoft.Office.Interop.Excel.Worksheet)libro.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range Rango;
                for (int i = 1; i <= dGvUsuarios.Columns.Count; i++)
                {
                    hoja.Cells[1, i] = dGvUsuarios.Columns[i - 1].HeaderText.ToString();
                    Rango = hoja.Cells[1, i];
                    Rango.Font.Bold = true;
                    Rango.Font.Name = "Arial"; //Nombre de fuente, como se llama en el sistema operativo
                    //Rango.Font.Size = 18;
                    Rango.Interior.Color = Color.Gray;
                }
                for (int i = 0; i < dGvUsuarios.Rows.Count; i++)
                {
                    for (int j = 0; j < dGvUsuarios.Columns.Count; j++)
                    {
                        hoja.Cells[2 + i, j + 1] = dGvUsuarios[j, i].Value.ToString();
                    }
                }
                libro.SaveAs(File.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                libro.Close(true);
                app.Quit();
                MessageBox.Show("Archivo " + File.FileName + " guardado correctamente.");
                System.Diagnostics.Process.Start(File.FileName); //abre reporte
            }
        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Filter = "Archivo PDF (*.pdf)| *.pdf";
            File.FileName = "Reporte de Usuarios";
            if (File.ShowDialog() == DialogResult.OK)
            {
                Document pdf = new Document(PageSize.A4.Rotate());
                try
                {
                    PdfWriter.GetInstance(pdf, new FileStream(File.FileName, FileMode.Create)); //inicio de la generación del pdf
                    pdf.Open();
                    PdfPTable Tabla = new PdfPTable(5); //cantidad de columnas PDF
                    PdfPCell Titulo = new PdfPCell(new Phrase("Reporte de Usuarios"));
                    Titulo.HorizontalAlignment = 1; //1 para centrar
                    Titulo.Colspan = 5;
                    Tabla.AddCell(Titulo); //header pdf
                    Tabla.AddCell("Tipo Usuario"); //titulo columna
                    Tabla.AddCell("Usuario");
                    Tabla.AddCell("Nombre");
                    Tabla.AddCell("Email");
                    //Tabla.AddCell("No. Prenda");
                    Tabla.AddCell("Activo");
                    for (int i = 0; i < dGvUsuarios.Rows.Count; i++) //leer datagrid
                    {
                        Tabla.AddCell(dGvUsuarios[0, i].Value.ToString()); //Tipo Usuario
                        Tabla.AddCell(dGvUsuarios[1, i].Value.ToString()); //Usuario
                        Tabla.AddCell(dGvUsuarios[3, i].Value.ToString()); //Nombre
                        Tabla.AddCell(dGvUsuarios[6, i].Value.ToString()); //Email
                      //Tabla.AddCell(GvUsuarios[4, i].Value.ToString());
                        Tabla.AddCell(dGvUsuarios[7, i].Value.ToString()); //Activo
                    }
                    pdf.Add(Tabla);
                    pdf.Close(); //fin del pdf
                }
                catch (DocumentException PDFerror)
                {
                    MessageBox.Show("Error al generar el archivo PDF");
                }
                catch (IOException IOerror)
                {
                    MessageBox.Show("Error al acceder a la ruta de guardado");
                }
                MessageBox.Show("Archivo " + File.FileName + " guardado correctamente.");
                System.Diagnostics.Process.Start(File.FileName); //abre reporte
            }
        }
    }
}
