namespace Perloan_Desktop
{
    partial class FrmAdminPrenda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminPrenda));
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tBNombreDudor = new System.Windows.Forms.TextBox();
            this.tBnumDeudor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGvPrendas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoPrenda = new System.Windows.Forms.ComboBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rTdetalles = new System.Windows.Forms.RichTextBox();
            this.rTdescripcion = new System.Windows.Forms.RichTextBox();
            this.tBnumPrenda = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGvPrendas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(277, 105);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Detalles:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 25);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Descripción:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 177);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nombre Prenda:";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpiar.Image")));
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.Location = new System.Drawing.Point(150, 79);
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
            this.btSalir.Location = new System.Drawing.Point(150, 141);
            this.btSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(100, 50);
            this.btSalir.TabIndex = 100;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tBNombreDudor
            // 
            this.tBNombreDudor.Enabled = false;
            this.tBNombreDudor.Location = new System.Drawing.Point(92, 137);
            this.tBNombreDudor.Margin = new System.Windows.Forms.Padding(2);
            this.tBNombreDudor.Name = "tBNombreDudor";
            this.tBNombreDudor.Size = new System.Drawing.Size(179, 20);
            this.tBNombreDudor.TabIndex = 34;
            // 
            // tBnumDeudor
            // 
            this.tBnumDeudor.Enabled = false;
            this.tBnumDeudor.Location = new System.Drawing.Point(92, 102);
            this.tBnumDeudor.Margin = new System.Windows.Forms.Padding(2);
            this.tBnumDeudor.Name = "tBnumDeudor";
            this.tBnumDeudor.Size = new System.Drawing.Size(179, 20);
            this.tBnumDeudor.TabIndex = 33;
            this.tBnumDeudor.TextChanged += new System.EventHandler(this.tBnumDeudor_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 137);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Nombre Deudor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "No. Deudor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo Prenda:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lista de Prendas de Deudores";
            // 
            // dGvPrendas
            // 
            this.dGvPrendas.AllowUserToAddRows = false;
            this.dGvPrendas.AllowUserToDeleteRows = false;
            this.dGvPrendas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvPrendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvPrendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column4,
            this.Column7,
            this.Column9,
            this.Column2,
            this.Column3});
            this.dGvPrendas.Location = new System.Drawing.Point(11, 40);
            this.dGvPrendas.Margin = new System.Windows.Forms.Padding(2);
            this.dGvPrendas.Name = "dGvPrendas";
            this.dGvPrendas.ReadOnly = true;
            this.dGvPrendas.RowTemplate.Height = 24;
            this.dGvPrendas.Size = new System.Drawing.Size(1162, 354);
            this.dGvPrendas.TabIndex = 27;
            this.dGvPrendas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvUsuarios_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. Prenda";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Nombre Prenda";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Descripción";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Detalles";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "No. Deudor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // cbTipoPrenda
            // 
            this.cbTipoPrenda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPrenda.FormattingEnabled = true;
            this.cbTipoPrenda.Items.AddRange(new object[] {
            "Automovil",
            "Joyeria",
            "Titulo",
            "Otros"});
            this.cbTipoPrenda.Location = new System.Drawing.Point(92, 59);
            this.cbTipoPrenda.Name = "cbTipoPrenda";
            this.cbTipoPrenda.Size = new System.Drawing.Size(179, 21);
            this.cbTipoPrenda.TabIndex = 1;
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::Perloan_Desktop.Properties.Resources.Clearallrequests_8816;
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
            this.btActualizar.Location = new System.Drawing.Point(5, 79);
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
            this.groupBox1.Controls.Add(this.rTdetalles);
            this.groupBox1.Controls.Add(this.rTdescripcion);
            this.groupBox1.Controls.Add(this.tBnumPrenda);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbTipoPrenda);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBnumDeudor);
            this.groupBox1.Controls.Add(this.tBNombreDudor);
            this.groupBox1.Controls.Add(this.tBnombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 202);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // rTdetalles
            // 
            this.rTdetalles.Location = new System.Drawing.Point(348, 105);
            this.rTdetalles.Name = "rTdetalles";
            this.rTdetalles.Size = new System.Drawing.Size(214, 91);
            this.rTdetalles.TabIndex = 4;
            this.rTdetalles.Text = "";
            // 
            // rTdescripcion
            // 
            this.rTdescripcion.Location = new System.Drawing.Point(348, 22);
            this.rTdescripcion.Name = "rTdescripcion";
            this.rTdescripcion.Size = new System.Drawing.Size(214, 72);
            this.rTdescripcion.TabIndex = 3;
            this.rTdescripcion.Text = "";
            // 
            // tBnumPrenda
            // 
            this.tBnumPrenda.Enabled = false;
            this.tBnumPrenda.Location = new System.Drawing.Point(92, 23);
            this.tBnumPrenda.Name = "tBnumPrenda";
            this.tBnumPrenda.Size = new System.Drawing.Size(180, 20);
            this.tBnumPrenda.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Numero Prenda";
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(92, 174);
            this.tBnombre.Margin = new System.Windows.Forms.Padding(2);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(179, 20);
            this.tBnombre.TabIndex = 2;
            this.tBnombre.Leave += new System.EventHandler(this.tBnombre_Leave);
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
            this.groupBox2.Size = new System.Drawing.Size(256, 199);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(586, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(239, 91);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nota:\r\nEl numero de prenda se genera automaticamente\r\n\r\nEliminar una prenda es IR" +
    "REVERSIBLE\r\n\r\n\r\nEl campo de detalles es opcional";
            // 
            // AdminPrenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 608);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGvPrendas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdminPrenda";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Prendas";
            this.Load += new System.EventHandler(this.AdminPrenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvPrendas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.TextBox tBNombreDudor;
        private System.Windows.Forms.TextBox tBnumDeudor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGvPrendas;
        private System.Windows.Forms.ComboBox cbTipoPrenda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tBnumPrenda;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox rTdetalles;
        private System.Windows.Forms.RichTextBox rTdescripcion;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}