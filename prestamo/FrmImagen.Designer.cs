namespace prestamo
{
    partial class FrmImagen
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
            this.pBimagenaguardar = new System.Windows.Forms.PictureBox();
            this.pBimagenguardada = new System.Windows.Forms.PictureBox();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.tBnombreBD = new System.Windows.Forms.TextBox();
            this.gBGuardar = new System.Windows.Forms.GroupBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.gBLeer = new System.Windows.Forms.GroupBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBimagenaguardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimagenguardada)).BeginInit();
            this.gBGuardar.SuspendLayout();
            this.gBLeer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBimagenaguardar
            // 
            this.pBimagenaguardar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBimagenaguardar.Location = new System.Drawing.Point(6, 17);
            this.pBimagenaguardar.Name = "pBimagenaguardar";
            this.pBimagenaguardar.Size = new System.Drawing.Size(113, 103);
            this.pBimagenaguardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimagenaguardar.TabIndex = 0;
            this.pBimagenaguardar.TabStop = false;
            // 
            // pBimagenguardada
            // 
            this.pBimagenguardada.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pBimagenguardada.Location = new System.Drawing.Point(289, 10);
            this.pBimagenguardada.Name = "pBimagenguardada";
            this.pBimagenguardada.Size = new System.Drawing.Size(113, 98);
            this.pBimagenguardada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBimagenguardada.TabIndex = 1;
            this.pBimagenguardada.TabStop = false;
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(125, 32);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(188, 20);
            this.tBnombre.TabIndex = 2;
            // 
            // tBnombreBD
            // 
            this.tBnombreBD.Location = new System.Drawing.Point(95, 32);
            this.tBnombreBD.Name = "tBnombreBD";
            this.tBnombreBD.Size = new System.Drawing.Size(188, 20);
            this.tBnombreBD.TabIndex = 3;
            // 
            // gBGuardar
            // 
            this.gBGuardar.Controls.Add(this.btnCargar);
            this.gBGuardar.Controls.Add(this.btnSeleccionar);
            this.gBGuardar.Controls.Add(this.pBimagenaguardar);
            this.gBGuardar.Controls.Add(this.tBnombre);
            this.gBGuardar.Location = new System.Drawing.Point(12, 2);
            this.gBGuardar.Name = "gBGuardar";
            this.gBGuardar.Size = new System.Drawing.Size(414, 126);
            this.gBGuardar.TabIndex = 4;
            this.gBGuardar.TabStop = false;
            this.gBGuardar.Text = "Guardar";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Location = new System.Drawing.Point(333, 32);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.btnSeleccionar.TabIndex = 3;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = true;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // gBLeer
            // 
            this.gBLeer.Controls.Add(this.btnLeer);
            this.gBLeer.Controls.Add(this.button1);
            this.gBLeer.Controls.Add(this.tBnombreBD);
            this.gBLeer.Controls.Add(this.pBimagenguardada);
            this.gBLeer.Location = new System.Drawing.Point(18, 135);
            this.gBLeer.Name = "gBLeer";
            this.gBLeer.Size = new System.Drawing.Size(409, 114);
            this.gBLeer.TabIndex = 5;
            this.gBLeer.TabStop = false;
            this.gBLeer.Text = "Leer";
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(7, 84);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 5;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(333, 96);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 4;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // FrmImagen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 261);
            this.Controls.Add(this.gBLeer);
            this.Controls.Add(this.gBGuardar);
            this.Name = "FrmImagen";
            this.Text = "FrmImagen";
            ((System.ComponentModel.ISupportInitialize)(this.pBimagenaguardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBimagenguardada)).EndInit();
            this.gBGuardar.ResumeLayout(false);
            this.gBGuardar.PerformLayout();
            this.gBLeer.ResumeLayout(false);
            this.gBLeer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pBimagenaguardar;
        private System.Windows.Forms.PictureBox pBimagenguardada;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.TextBox tBnombreBD;
        private System.Windows.Forms.GroupBox gBGuardar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox gBLeer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnCargar;
    }
}