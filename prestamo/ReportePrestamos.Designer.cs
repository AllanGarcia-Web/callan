namespace prestamo
{
    partial class ReportePrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dGvPrestamos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Pdf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // dGvPrestamos
            // 
            this.dGvPrestamos.AllowUserToAddRows = false;
            this.dGvPrestamos.AllowUserToDeleteRows = false;
            this.dGvPrestamos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dGvPrestamos.Location = new System.Drawing.Point(7, 34);
            this.dGvPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.dGvPrestamos.Name = "dGvPrestamos";
            this.dGvPrestamos.ReadOnly = true;
            this.dGvPrestamos.RowTemplate.Height = 24;
            this.dGvPrestamos.Size = new System.Drawing.Size(1162, 354);
            this.dGvPrestamos.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. Prestamo";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "No. Deudor";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Monto Prestado";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Plazo en Semanas";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No. Prenda";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Prenda";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // btn_Pdf
            // 
            this.btn_Pdf.Location = new System.Drawing.Point(7, 408);
            this.btn_Pdf.Name = "btn_Pdf";
            this.btn_Pdf.Size = new System.Drawing.Size(91, 23);
            this.btn_Pdf.TabIndex = 29;
            this.btn_Pdf.Text = "Exportar a PDF";
            this.btn_Pdf.UseVisualStyleBackColor = true;
            // 
            // ReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 459);
            this.Controls.Add(this.btn_Pdf);
            this.Controls.Add(this.dGvPrestamos);
            this.Name = "ReportePrestamos";
            this.Text = "ReportePrestamos";
            this.Load += new System.EventHandler(this.ReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvPrestamos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dGvPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button btn_Pdf;
    }
}