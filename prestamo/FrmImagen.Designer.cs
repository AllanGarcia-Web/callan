namespace Perloan_Desktop
{
    partial class FrmImagen
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.pBimagen = new System.Windows.Forms.PictureBox();
            this.BtnAgregarFoto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.cbListaFotos = new System.Windows.Forms.ComboBox();
            this.pBserver = new System.Windows.Forms.PictureBox();
            this.tBbuscar = new System.Windows.Forms.TextBox();
            this.tbBuscarimg = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBimagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBserver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 13);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(237, 20);
            this.txtDescripcion.TabIndex = 1;
            // 
            // pBimagen
            // 
            this.pBimagen.Location = new System.Drawing.Point(329, 12);
            this.pBimagen.Name = "pBimagen";
            this.pBimagen.Size = new System.Drawing.Size(127, 108);
            this.pBimagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimagen.TabIndex = 2;
            this.pBimagen.TabStop = false;
            // 
            // BtnAgregarFoto
            // 
            this.BtnAgregarFoto.Location = new System.Drawing.Point(215, 86);
            this.BtnAgregarFoto.Name = "BtnAgregarFoto";
            this.BtnAgregarFoto.Size = new System.Drawing.Size(108, 23);
            this.BtnAgregarFoto.TabIndex = 3;
            this.BtnAgregarFoto.Text = "Agregar a BD";
            this.BtnAgregarFoto.UseVisualStyleBackColor = true;
            this.BtnAgregarFoto.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(86, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(62, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // cbListaFotos
            // 
            this.cbListaFotos.FormattingEnabled = true;
            this.cbListaFotos.Location = new System.Drawing.Point(607, 13);
            this.cbListaFotos.Name = "cbListaFotos";
            this.cbListaFotos.Size = new System.Drawing.Size(237, 21);
            this.cbListaFotos.TabIndex = 6;
            this.cbListaFotos.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // pBserver
            // 
            this.pBserver.Location = new System.Drawing.Point(12, 186);
            this.pBserver.Name = "pBserver";
            this.pBserver.Size = new System.Drawing.Size(127, 108);
            this.pBserver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBserver.TabIndex = 8;
            this.pBserver.TabStop = false;
            // 
            // tBbuscar
            // 
            this.tBbuscar.Location = new System.Drawing.Point(145, 196);
            this.tBbuscar.Name = "tBbuscar";
            this.tBbuscar.Size = new System.Drawing.Size(237, 20);
            this.tBbuscar.TabIndex = 9;
            // 
            // tbBuscarimg
            // 
            this.tbBuscarimg.Location = new System.Drawing.Point(320, 222);
            this.tbBuscarimg.Name = "tbBuscarimg";
            this.tbBuscarimg.Size = new System.Drawing.Size(62, 23);
            this.tbBuscarimg.TabIndex = 10;
            this.tbBuscarimg.Text = "Buscar";
            this.tbBuscarimg.UseVisualStyleBackColor = true;
            this.tbBuscarimg.Click += new System.EventHandler(this.tbBuscarimg_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar en BD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FrmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 323);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbBuscarimg);
            this.Controls.Add(this.tBbuscar);
            this.Controls.Add(this.pBserver);
            this.Controls.Add(this.cbListaFotos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAgregarFoto);
            this.Controls.Add(this.pBimagen);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label1);
            this.Name = "FrmImagen";
            this.Text = "Imagenes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBimagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBserver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.PictureBox pBimagen;
        private System.Windows.Forms.Button BtnAgregarFoto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbListaFotos;
        private System.Windows.Forms.PictureBox pBserver;
        private System.Windows.Forms.TextBox tBbuscar;
        private System.Windows.Forms.Button tbBuscarimg;
        private System.Windows.Forms.Button button1;
    }
}

