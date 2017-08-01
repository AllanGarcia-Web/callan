namespace prestamo
{
    partial class menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.bt_salir = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deudoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDelSisremaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbbienvenido = new System.Windows.Forms.Label();
            this.lbnombre = new System.Windows.Forms.Label();
            this.lbEquipo = new System.Windows.Forms.Label();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_salir
            // 
            this.bt_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_salir.Image = ((System.Drawing.Image)(resources.GetObject("bt_salir.Image")));
            this.bt_salir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_salir.Location = new System.Drawing.Point(578, 281);
            this.bt_salir.Margin = new System.Windows.Forms.Padding(4);
            this.bt_salir.Name = "bt_salir";
            this.bt_salir.Size = new System.Drawing.Size(100, 26);
            this.bt_salir.TabIndex = 0;
            this.bt_salir.Text = "&Salir";
            this.bt_salir.UseVisualStyleBackColor = true;
            this.bt_salir.Click += new System.EventHandler(this.bt_salir_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 313);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(689, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.deudoresToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.prendasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(689, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuariosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuariosToolStripMenuItem.Image")));
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // deudoresToolStripMenuItem
            // 
            this.deudoresToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deudoresToolStripMenuItem.Name = "deudoresToolStripMenuItem";
            this.deudoresToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.deudoresToolStripMenuItem.Text = "Deudores";
            this.deudoresToolStripMenuItem.Click += new System.EventHandler(this.deudoresToolStripMenuItem_Click);
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prestamosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("prestamosToolStripMenuItem.Image")));
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            this.prestamosToolStripMenuItem.Click += new System.EventHandler(this.prestamosToolStripMenuItem_Click);
            // 
            // prendasToolStripMenuItem
            // 
            this.prendasToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prendasToolStripMenuItem.Name = "prendasToolStripMenuItem";
            this.prendasToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.prendasToolStripMenuItem.Text = "Prendas";
            this.prendasToolStripMenuItem.Click += new System.EventHandler(this.prendasToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaDelSistemaToolStripMenuItem,
            this.acercaDelSisremaToolStripMenuItem});
            this.ayudaToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // ayudaDelSistemaToolStripMenuItem
            // 
            this.ayudaDelSistemaToolStripMenuItem.Name = "ayudaDelSistemaToolStripMenuItem";
            this.ayudaDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ayudaDelSistemaToolStripMenuItem.Text = "Ayuda del sistema";
            // 
            // acercaDelSisremaToolStripMenuItem
            // 
            this.acercaDelSisremaToolStripMenuItem.Name = "acercaDelSisremaToolStripMenuItem";
            this.acercaDelSisremaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.acercaDelSisremaToolStripMenuItem.Text = "Acerca del sistema";
            this.acercaDelSisremaToolStripMenuItem.Click += new System.EventHandler(this.acercaDelSisremaToolStripMenuItem_Click);
            // 
            // lbbienvenido
            // 
            this.lbbienvenido.AutoSize = true;
            this.lbbienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbienvenido.Location = new System.Drawing.Point(18, 47);
            this.lbbienvenido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbbienvenido.Name = "lbbienvenido";
            this.lbbienvenido.Size = new System.Drawing.Size(82, 15);
            this.lbbienvenido.TabIndex = 3;
            this.lbbienvenido.Text = "Bienvenido:";
            // 
            // lbnombre
            // 
            this.lbnombre.AutoSize = true;
            this.lbnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnombre.Location = new System.Drawing.Point(190, 47);
            this.lbnombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbnombre.Name = "lbnombre";
            this.lbnombre.Size = new System.Drawing.Size(169, 15);
            this.lbnombre.TabIndex = 4;
            this.lbnombre.Text = "Error al cargar el nombre";
            // 
            // lbEquipo
            // 
            this.lbEquipo.AutoSize = true;
            this.lbEquipo.Location = new System.Drawing.Point(13, 281);
            this.lbEquipo.Name = "lbEquipo";
            this.lbEquipo.Size = new System.Drawing.Size(241, 15);
            this.lbEquipo.TabIndex = 5;
            this.lbEquipo.Text = "Equipo: Error obtieniendo el nombre";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 335);
            this.Controls.Add(this.lbEquipo);
            this.Controls.Add(this.lbnombre);
            this.Controls.Add(this.lbbienvenido);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.bt_salir);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_salir;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deudoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDelSisremaToolStripMenuItem;
        private System.Windows.Forms.Label lbbienvenido;
        private System.Windows.Forms.Label lbnombre;
        private System.Windows.Forms.Label lbEquipo;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
    }
}