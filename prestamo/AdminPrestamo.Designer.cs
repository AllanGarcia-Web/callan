namespace prestamo
{
    partial class AdminPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPrestamo));
            this.TbPlazoSemanas = new System.Windows.Forms.TextBox();
            this.TbMontoPrestamo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGvPrestamos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBNombreDudor = new System.Windows.Forms.TextBox();
            this.lNombreDudor = new System.Windows.Forms.Label();
            this.cBbumDeudor = new System.Windows.Forms.ComboBox();
            this.CbNumPrenda = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbNomPrenda = new System.Windows.Forms.TextBox();
            this.TbNumPrestamo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGvPrestamos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbPlazoSemanas
            // 
            this.TbPlazoSemanas.Location = new System.Drawing.Point(375, 50);
            this.TbPlazoSemanas.Margin = new System.Windows.Forms.Padding(2);
            this.TbPlazoSemanas.Name = "TbPlazoSemanas";
            this.TbPlazoSemanas.Size = new System.Drawing.Size(179, 20);
            this.TbPlazoSemanas.TabIndex = 4;
            this.TbPlazoSemanas.Leave += new System.EventHandler(this.TbPlazoSemanas_Leave);
            // 
            // TbMontoPrestamo
            // 
            this.TbMontoPrestamo.Location = new System.Drawing.Point(375, 22);
            this.TbMontoPrestamo.Margin = new System.Windows.Forms.Padding(2);
            this.TbMontoPrestamo.Name = "TbMontoPrestamo";
            this.TbMontoPrestamo.Size = new System.Drawing.Size(179, 20);
            this.TbMontoPrestamo.TabIndex = 3;
            this.TbMontoPrestamo.Leave += new System.EventHandler(this.TbMontoPrestamo_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 106);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "No. Prenda:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 53);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Plazo Semanas:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Monto de Prestamo:";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpiar.Image")));
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.Location = new System.Drawing.Point(150, 61);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(100, 33);
            this.btLimpiar.TabIndex = 8;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalir.Location = new System.Drawing.Point(150, 114);
            this.btSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 35);
            this.btSalir.TabIndex = 20;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "No. Deudor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "No. Prestamo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lista de Prestamos de Deudores";
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
            this.dGvPrestamos.Location = new System.Drawing.Point(11, 40);
            this.dGvPrestamos.Margin = new System.Windows.Forms.Padding(2);
            this.dGvPrestamos.Name = "dGvPrestamos";
            this.dGvPrestamos.ReadOnly = true;
            this.dGvPrestamos.RowTemplate.Height = 24;
            this.dGvPrestamos.Size = new System.Drawing.Size(1162, 354);
            this.dGvPrestamos.TabIndex = 27;
            this.dGvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvUsuarios_CellClick);
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
            // btEliminar
            // 
            this.btEliminar.Image = global::prestamo.Properties.Resources.Clearallrequests_8816;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.Location = new System.Drawing.Point(150, 23);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 34);
            this.btEliminar.TabIndex = 7;
            this.btEliminar.Text = "&Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btActualizar
            // 
            this.btActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btActualizar.Image")));
            this.btActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btActualizar.Location = new System.Drawing.Point(5, 61);
            this.btActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btActualizar.Name = "btActualizar";
            this.btActualizar.Size = new System.Drawing.Size(100, 33);
            this.btActualizar.TabIndex = 6;
            this.btActualizar.Text = "&Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btCrear
            // 
            this.btCrear.Image = ((System.Drawing.Image)(resources.GetObject("btCrear.Image")));
            this.btCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrear.Location = new System.Drawing.Point(5, 21);
            this.btCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(100, 33);
            this.btCrear.TabIndex = 5;
            this.btCrear.Text = "&Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBNombreDudor);
            this.groupBox1.Controls.Add(this.lNombreDudor);
            this.groupBox1.Controls.Add(this.cBbumDeudor);
            this.groupBox1.Controls.Add(this.CbNumPrenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TbNomPrenda);
            this.groupBox1.Controls.Add(this.TbNumPrestamo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TbPlazoSemanas);
            this.groupBox1.Controls.Add(this.TbMontoPrestamo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 153);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // tBNombreDudor
            // 
            this.tBNombreDudor.Enabled = false;
            this.tBNombreDudor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBNombreDudor.Location = new System.Drawing.Point(375, 75);
            this.tBNombreDudor.Name = "tBNombreDudor";
            this.tBNombreDudor.Size = new System.Drawing.Size(179, 22);
            this.tBNombreDudor.TabIndex = 100;
            // 
            // lNombreDudor
            // 
            this.lNombreDudor.AutoSize = true;
            this.lNombreDudor.Location = new System.Drawing.Point(275, 80);
            this.lNombreDudor.Name = "lNombreDudor";
            this.lNombreDudor.Size = new System.Drawing.Size(82, 13);
            this.lNombreDudor.TabIndex = 99;
            this.lNombreDudor.Text = "Nombre Deudor";
            // 
            // cBbumDeudor
            // 
            this.cBbumDeudor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBbumDeudor.FormattingEnabled = true;
            this.cBbumDeudor.Location = new System.Drawing.Point(86, 61);
            this.cBbumDeudor.Name = "cBbumDeudor";
            this.cBbumDeudor.Size = new System.Drawing.Size(179, 21);
            this.cBbumDeudor.TabIndex = 0;
            this.cBbumDeudor.SelectedIndexChanged += new System.EventHandler(this.cBbumDuedor_SelectedIndexChanged);
            // 
            // CbNumPrenda
            // 
            this.CbNumPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbNumPrenda.FormattingEnabled = true;
            this.CbNumPrenda.Location = new System.Drawing.Point(86, 103);
            this.CbNumPrenda.Name = "CbNumPrenda";
            this.CbNumPrenda.Size = new System.Drawing.Size(179, 21);
            this.CbNumPrenda.TabIndex = 1;
            this.CbNumPrenda.SelectedIndexChanged += new System.EventHandler(this.CbNumPrenda_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(275, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Nombre Prenda";
            // 
            // TbNomPrenda
            // 
            this.TbNomPrenda.Enabled = false;
            this.TbNomPrenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNomPrenda.Location = new System.Drawing.Point(375, 102);
            this.TbNomPrenda.Name = "TbNomPrenda";
            this.TbNomPrenda.Size = new System.Drawing.Size(179, 22);
            this.TbNomPrenda.TabIndex = 95;
            // 
            // TbNumPrestamo
            // 
            this.TbNumPrestamo.Enabled = false;
            this.TbNumPrestamo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbNumPrestamo.Location = new System.Drawing.Point(86, 22);
            this.TbNumPrestamo.Name = "TbNumPrestamo";
            this.TbNumPrestamo.Size = new System.Drawing.Size(179, 22);
            this.TbNumPrestamo.TabIndex = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCrear);
            this.groupBox2.Controls.Add(this.btActualizar);
            this.groupBox2.Controls.Add(this.btSalir);
            this.groupBox2.Controls.Add(this.btLimpiar);
            this.groupBox2.Controls.Add(this.btEliminar);
            this.groupBox2.Location = new System.Drawing.Point(916, 402);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(256, 152);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(590, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(252, 52);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nota:\r\nEl numero de  prestamo se genera automaticamente\r\n\r\nEliminar un prestamo e" +
    "s IRREVERSIBLE";
            // 
            // AdminPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 566);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGvPrestamos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminPrestamo";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Prestamos";
            this.Load += new System.EventHandler(this.AdminPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvPrestamos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbPlazoSemanas;
        private System.Windows.Forms.TextBox TbMontoPrestamo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGvPrestamos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TbNumPrestamo;
        private System.Windows.Forms.TextBox TbNomPrenda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbNumPrenda;
        private System.Windows.Forms.ComboBox cBbumDeudor;
        private System.Windows.Forms.TextBox tBNombreDudor;
        private System.Windows.Forms.Label lNombreDudor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}