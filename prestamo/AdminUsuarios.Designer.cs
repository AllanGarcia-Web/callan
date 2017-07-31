namespace prestamo
{
    partial class AdminUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUsuarios));
            this.label5 = new System.Windows.Forms.Label();
            this.tBemail = new System.Windows.Forms.TextBox();
            this.tBapmaterno = new System.Windows.Forms.TextBox();
            this.tBappaterno = new System.Windows.Forms.TextBox();
            this.tBnombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btLimpiar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.tBusuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dGvUsuarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbNivel = new System.Windows.Forms.ComboBox();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btActualizar = new System.Windows.Forms.Button();
            this.btCrear = new System.Windows.Forms.Button();
            this.cBactivo = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Email:";
            // 
            // tBemail
            // 
            this.tBemail.Location = new System.Drawing.Point(362, 133);
            this.tBemail.Margin = new System.Windows.Forms.Padding(2);
            this.tBemail.Name = "tBemail";
            this.tBemail.Size = new System.Drawing.Size(179, 20);
            this.tBemail.TabIndex = 49;
            this.tBemail.Leave += new System.EventHandler(this.tBemail_Leave);
            // 
            // tBapmaterno
            // 
            this.tBapmaterno.Location = new System.Drawing.Point(362, 99);
            this.tBapmaterno.Margin = new System.Windows.Forms.Padding(2);
            this.tBapmaterno.Name = "tBapmaterno";
            this.tBapmaterno.Size = new System.Drawing.Size(179, 20);
            this.tBapmaterno.TabIndex = 48;
            // 
            // tBappaterno
            // 
            this.tBappaterno.Location = new System.Drawing.Point(362, 62);
            this.tBappaterno.Margin = new System.Windows.Forms.Padding(2);
            this.tBappaterno.Name = "tBappaterno";
            this.tBappaterno.Size = new System.Drawing.Size(179, 20);
            this.tBappaterno.TabIndex = 47;
            this.tBappaterno.Leave += new System.EventHandler(this.tBappaterno_Leave);
            // 
            // tBnombre
            // 
            this.tBnombre.Location = new System.Drawing.Point(362, 24);
            this.tBnombre.Margin = new System.Windows.Forms.Padding(2);
            this.tBnombre.Name = "tBnombre";
            this.tBnombre.Size = new System.Drawing.Size(179, 20);
            this.tBnombre.TabIndex = 46;
            this.tBnombre.Leave += new System.EventHandler(this.tBnombre_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(271, 100);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 45;
            this.label7.Text = "Apellido Materno:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(271, 65);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 44;
            this.label8.Text = "Apellido Paterno:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(271, 25);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Nombre:";
            // 
            // btLimpiar
            // 
            this.btLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btLimpiar.Image")));
            this.btLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btLimpiar.Location = new System.Drawing.Point(150, 61);
            this.btLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btLimpiar.Name = "btLimpiar";
            this.btLimpiar.Size = new System.Drawing.Size(100, 33);
            this.btLimpiar.TabIndex = 41;
            this.btLimpiar.Text = "Limpiar";
            this.btLimpiar.UseVisualStyleBackColor = true;
            this.btLimpiar.Click += new System.EventHandler(this.btLimpiar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Image = ((System.Drawing.Image)(resources.GetObject("btSalir.Image")));
            this.btSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSalir.Location = new System.Drawing.Point(171, 99);
            this.btSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(79, 50);
            this.btSalir.TabIndex = 40;
            this.btSalir.Text = "&Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // tBpass
            // 
            this.tBpass.Location = new System.Drawing.Point(86, 99);
            this.tBpass.Margin = new System.Windows.Forms.Padding(2);
            this.tBpass.Name = "tBpass";
            this.tBpass.PasswordChar = '*';
            this.tBpass.Size = new System.Drawing.Size(179, 20);
            this.tBpass.TabIndex = 34;
            // 
            // tBusuario
            // 
            this.tBusuario.Location = new System.Drawing.Point(86, 64);
            this.tBusuario.Margin = new System.Windows.Forms.Padding(2);
            this.tBusuario.Name = "tBusuario";
            this.tBusuario.Size = new System.Drawing.Size(179, 20);
            this.tBusuario.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Tipo Usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Lista de Usuarios";
            // 
            // dGvUsuarios
            // 
            this.dGvUsuarios.AllowUserToAddRows = false;
            this.dGvUsuarios.AllowUserToDeleteRows = false;
            this.dGvUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column9,
            this.Column2,
            this.Column3,
            this.Column5,
            this.Column8,
            this.Column4});
            this.dGvUsuarios.Location = new System.Drawing.Point(11, 40);
            this.dGvUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.dGvUsuarios.Name = "dGvUsuarios";
            this.dGvUsuarios.ReadOnly = true;
            this.dGvUsuarios.RowTemplate.Height = 24;
            this.dGvUsuarios.Size = new System.Drawing.Size(1162, 354);
            this.dGvUsuarios.TabIndex = 27;
            this.dGvUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGvUsuarios_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tipo Usuario";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Usuario";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Contraseña";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Apellido Paterno";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Apellido Materno";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Email";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Activo";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // cbNivel
            // 
            this.cbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivel.FormattingEnabled = true;
            this.cbNivel.Items.AddRange(new object[] {
            "Cobrador",
            "Administrador"});
            this.cbNivel.Location = new System.Drawing.Point(86, 21);
            this.cbNivel.Name = "cbNivel";
            this.cbNivel.Size = new System.Drawing.Size(179, 21);
            this.cbNivel.TabIndex = 51;
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::prestamo.Properties.Resources.Clearallrequests_8816;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btEliminar.Location = new System.Drawing.Point(150, 23);
            this.btEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(100, 34);
            this.btEliminar.TabIndex = 39;
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
            this.btActualizar.TabIndex = 38;
            this.btActualizar.Text = "&Actualizar";
            this.btActualizar.UseVisualStyleBackColor = true;
            this.btActualizar.Click += new System.EventHandler(this.btActualizar_Click);
            // 
            // btCrear
            // 
            this.btCrear.Image = global::prestamo.Properties.Resources._1491352434_Accept;
            this.btCrear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btCrear.Location = new System.Drawing.Point(5, 21);
            this.btCrear.Margin = new System.Windows.Forms.Padding(2);
            this.btCrear.Name = "btCrear";
            this.btCrear.Size = new System.Drawing.Size(100, 33);
            this.btCrear.TabIndex = 37;
            this.btCrear.Text = "&Crear";
            this.btCrear.UseVisualStyleBackColor = true;
            this.btCrear.Click += new System.EventHandler(this.btCrear_Click);
            // 
            // cBactivo
            // 
            this.cBactivo.AutoSize = true;
            this.cBactivo.Location = new System.Drawing.Point(86, 132);
            this.cBactivo.Name = "cBactivo";
            this.cBactivo.Size = new System.Drawing.Size(15, 14);
            this.cBactivo.TabIndex = 52;
            this.cBactivo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cBactivo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbNivel);
            this.groupBox1.Controls.Add(this.tBemail);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tBapmaterno);
            this.groupBox1.Controls.Add(this.tBusuario);
            this.groupBox1.Controls.Add(this.tBappaterno);
            this.groupBox1.Controls.Add(this.tBpass);
            this.groupBox1.Controls.Add(this.tBnombre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 399);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 167);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Usuario Activo:";
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
            this.groupBox2.Size = new System.Drawing.Size(256, 166);
            this.groupBox2.TabIndex = 54;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Acciones";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(571, 402);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(216, 91);
            this.label10.TabIndex = 55;
            this.label10.Text = "Nota:\r\nEl nombre de usuario no se puede actualizar\r\n\r\n\r\nUsuario Activo:\r\nCasilla " +
    "marcada = Activo\r\nCasilla desmarcada =Inactivo";
            // 
            // AdminUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 580);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dGvUsuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminUsuarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de Usuarios";
            this.Load += new System.EventHandler(this.AdminUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tBemail;
        private System.Windows.Forms.TextBox tBapmaterno;
        private System.Windows.Forms.TextBox tBappaterno;
        private System.Windows.Forms.TextBox tBnombre;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btLimpiar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btActualizar;
        private System.Windows.Forms.Button btCrear;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.TextBox tBusuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dGvUsuarios;
        private System.Windows.Forms.ComboBox cbNivel;
        private System.Windows.Forms.CheckBox cBactivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label label10;
    }
}