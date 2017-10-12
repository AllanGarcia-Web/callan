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
    public partial class FrmReportePrestamos : Form
    {
        Prestamo ClassPrestamos = new Prestamo();

        public FrmReportePrestamos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Guarda el reporte de prestamo en pdf
        /// </summary>
        private void PdfPrestamo()
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Filter = "Archivo PDF (*.pdf)| *.pdf";
            File.FileName = "Reporte de Prestamos";
            if (File.ShowDialog() == DialogResult.OK)
            {
                Document pdf = new Document(PageSize.A4.Rotate());
                try
                {
                    PdfWriter.GetInstance(pdf, new FileStream(File.FileName, FileMode.Create)); //inicio de la generación del pdf
                    pdf.Open();
                    PdfPTable Tabla = new PdfPTable(5); //cantidad de columnas PDF
                    PdfPCell Titulo = new PdfPCell(new Phrase("Reporte de Prestamos"));
                    Titulo.HorizontalAlignment = 1; //1 para centrar
                    Titulo.Colspan = 5;
                    Tabla.AddCell(Titulo); //header pdf
                    Tabla.AddCell("No. Prestamo"); //titulo columna
                    Tabla.AddCell("No. Deudor");
                    Tabla.AddCell("Monto Prestado");
                    Tabla.AddCell("Plazo en Semanas");
                    //Tabla.AddCell("No. Prenda");
                    Tabla.AddCell("Prenda");
                    for (int i = 0; i < dGvPrestamos.Rows.Count; i++) //leer datagrid
                    {
                        Tabla.AddCell(dGvPrestamos[0, i].Value.ToString()); //No. Prestamo
                        Tabla.AddCell(dGvPrestamos[1, i].Value.ToString()); //No. Deudor
                        Tabla.AddCell(dGvPrestamos[2, i].Value.ToString()); //Monto Prestado
                        Tabla.AddCell(dGvPrestamos[3, i].Value.ToString()); //Plazo en Semanas
                                                                            // Tabla.AddCell(dGvPrestamos[4, i].Value.ToString()); //No. Prenda
                        Tabla.AddCell(dGvPrestamos[5, i].Value.ToString()); //Prenda
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
        private void ReportePrestamos_Load(object sender, EventArgs e)
        {
            if (ClassPrestamos.Leer() == true) //carga datos al datagredview
            {
                while (Prestamo.Lector.Read()) //datos de la bd
                {
                    dGvPrestamos.Rows.Add(Prestamo.Lector.GetString(0), Prestamo.Lector.GetString(1), Prestamo.Lector.GetString(2), Prestamo.Lector.GetString(3), Prestamo.Lector.GetString(4), Prestamo.Lector.GetString(5)); // cargar datos
                }
                //basedatos.DesconectarDB();
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Error al leer datos. " + Prestamo.Error, "Error al leer datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Pdf_Click(object sender, EventArgs e)
        {
            PdfPrestamo();
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            SaveFileDialog File = new SaveFileDialog();
            File.Filter = "Archivo de Excel (*.xlsx)|*.xlsx";
            File.FileName = "Reporte de Prestamos";
            if (File.ShowDialog() == DialogResult.OK)
            {
                Microsoft.Office.Interop.Excel.Application app; //selecciona la app
                Microsoft.Office.Interop.Excel.Workbook libro; //genera libro para excel
                Microsoft.Office.Interop.Excel.Worksheet hoja; //genera la hoja del libro
                app = new Microsoft.Office.Interop.Excel.Application();
                libro = app.Workbooks.Add();
                hoja = (Microsoft.Office.Interop.Excel.Worksheet)libro.Worksheets[1];
                Microsoft.Office.Interop.Excel.Range Rango;
                for (int i = 1; i <= dGvPrestamos.Columns.Count; i++)
                {
                    hoja.Cells[1, i] = dGvPrestamos.Columns[i - 1].HeaderText.ToString();
                    Rango = hoja.Cells[1, i];
                    Rango.Font.Bold = true;
                    Rango.Font.Name = "Arial"; //Nombre de fuente, como se llama en el sistema operativo
                    //Rango.Font.Size = 18;
                    Rango.Interior.Color = Color.Gray;
                }
                for (int i = 0; i < dGvPrestamos.Rows.Count; i++)
                {
                    for (int j = 0; j < dGvPrestamos.Columns.Count; j++)
                    {
                        hoja.Cells[2 + i, j + 1] = dGvPrestamos[j, i].Value.ToString();
                    }
                }
                libro.SaveAs(File.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook);
                libro.Close(true);
                app.Quit();
                MessageBox.Show("Archivo " + File.FileName + " guardado correctamente.");
                System.Diagnostics.Process.Start(File.FileName); //abre reporte
            }
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}