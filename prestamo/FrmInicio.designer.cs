namespace Perloan_Desktop
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.tBusuario = new System.Windows.Forms.TextBox();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.lbbienvenida = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkLabelAyuda = new System.Windows.Forms.LinkLabel();
            this.lblVer = new System.Windows.Forms.Label();
            this.lblDesarrollo = new System.Windows.Forms.Label();
            this.gBlogin = new System.Windows.Forms.GroupBox();
            this.btnVer = new System.Windows.Forms.Button();
            this.cBoxRecordar = new System.Windows.Forms.CheckBox();
            this.BtnAcceso = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.pBlogo = new System.Windows.Forms.PictureBox();
            this.pBlogim = new System.Windows.Forms.PictureBox();
            this.gBlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlogim)).BeginInit();
            this.SuspendLayout();
            // 
            // tBusuario
            // 
            this.tBusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBusuario.Location = new System.Drawing.Point(101, 19);
            this.tBusuario.Name = "tBusuario";
            this.tBusuario.Size = new System.Drawing.Size(114, 22);
            this.tBusuario.TabIndex = 0;
            // 
            // tBpass
            // 
            this.tBpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBpass.Location = new System.Drawing.Point(101, 45);
            this.tBpass.Name = "tBpass";
            this.tBpass.Size = new System.Drawing.Size(114, 22);
            this.tBpass.TabIndex = 1;
            this.tBpass.UseSystemPasswordChar = true;
            // 
            // lbbienvenida
            // 
            this.lbbienvenida.AutoSize = true;
            this.lbbienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbienvenida.Location = new System.Drawing.Point(127, 9);
            this.lbbienvenida.Name = "lbbienvenida";
            this.lbbienvenida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbbienvenida.Size = new System.Drawing.Size(163, 32);
            this.lbbienvenida.TabIndex = 4;
            this.lbbienvenida.Text = "Bienvenido al Sistema\r\nPERLOAN";
            this.lbbienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // LinkLabelAyuda
            // 
            this.LinkLabelAyuda.AutoSize = true;
            this.LinkLabelAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkLabelAyuda.Location = new System.Drawing.Point(7, 96);
            this.LinkLabelAyuda.Name = "LinkLabelAyuda";
            this.LinkLabelAyuda.Size = new System.Drawing.Size(173, 12);
            this.LinkLabelAyuda.TabIndex = 7;
            this.LinkLabelAyuda.TabStop = true;
            this.LinkLabelAyuda.Text = "No puedes acceder, da click Aqui";
            this.LinkLabelAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAyuda_LinkClicked);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.Location = new System.Drawing.Point(146, 51);
            this.lblVer.Name = "lblVer";
            this.lblVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblVer.Size = new System.Drawing.Size(132, 16);
            this.lblVer.TabIndex = 13;
            this.lblVer.Text = "Ver. Desconocida";
            this.lblVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDesarrollo
            // 
            this.lblDesarrollo.AutoSize = true;
            this.lblDesarrollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesarrollo.Location = new System.Drawing.Point(28, 79);
            this.lblDesarrollo.Name = "lblDesarrollo";
            this.lblDesarrollo.Size = new System.Drawing.Size(355, 96);
            this.lblDesarrollo.TabIndex = 12;
            this.lblDesarrollo.Text = "SISTEMA EN DESARROLLO\r\nNO USAR EN PRODUCCIÖN\r\nPUEDE PRESENTAR FALLAS DURANTE SU U" +
    "SO\r\n\r\nALGUNAS CARACTERISTICAS Y/O FUNCIONES\r\nPUEDEN O NO ESTAR EN LA VERSIÓN FIN" +
    "AL";
            this.lblDesarrollo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBlogin
            // 
            this.gBlogin.Controls.Add(this.btnVer);
            this.gBlogin.Controls.Add(this.cBoxRecordar);
            this.gBlogin.Controls.Add(this.label2);
            this.gBlogin.Controls.Add(this.tBusuario);
            this.gBlogin.Controls.Add(this.tBpass);
            this.gBlogin.Controls.Add(this.label3);
            this.gBlogin.Controls.Add(this.LinkLabelAyuda);
            this.gBlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBlogin.Location = new System.Drawing.Point(149, 178);
            this.gBlogin.Name = "gBlogin";
            this.gBlogin.Size = new System.Drawing.Size(257, 111);
            this.gBlogin.TabIndex = 15;
            this.gBlogin.TabStop = false;
            this.gBlogin.Text = "Datos de Acceso";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(218, 45);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(36, 23);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            this.btnVer.MouseLeave += new System.EventHandler(this.btnVer_MouseLeave);
            this.btnVer.MouseHover += new System.EventHandler(this.btnVer_MouseHover);
            // 
            // cBoxRecordar
            // 
            this.cBoxRecordar.AutoSize = true;
            this.cBoxRecordar.Location = new System.Drawing.Point(101, 73);
            this.cBoxRecordar.Name = "cBoxRecordar";
            this.cBoxRecordar.Size = new System.Drawing.Size(85, 19);
            this.cBoxRecordar.TabIndex = 8;
            this.cBoxRecordar.Text = "Recordar";
            this.cBoxRecordar.UseVisualStyleBackColor = true;
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceso.Image = ((System.Drawing.Image)(resources.GetObject("BtnAcceso.Image")));
            this.BtnAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcceso.Location = new System.Drawing.Point(149, 294);
            this.BtnAcceso.Name = "BtnAcceso";
            this.BtnAcceso.Size = new System.Drawing.Size(94, 23);
            this.BtnAcceso.TabIndex = 2;
            this.BtnAcceso.Text = "Acceder";
            this.BtnAcceso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAcceso.UseVisualStyleBackColor = true;
            this.BtnAcceso.Click += new System.EventHandler(this.BtnAcceso_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalir.Image")));
            this.BtnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSalir.Location = new System.Drawing.Point(329, 294);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 23);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // pBlogo
            // 
            this.pBlogo.Image = ((System.Drawing.Image)(resources.GetObject("pBlogo.Image")));
            this.pBlogo.Location = new System.Drawing.Point(412, 0);
            this.pBlogo.Name = "pBlogo";
            this.pBlogo.Size = new System.Drawing.Size(200, 325);
            this.pBlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pBlogo.TabIndex = 14;
            this.pBlogo.TabStop = false;
            // 
            // pBlogim
            // 
            this.pBlogim.Image = ((System.Drawing.Image)(resources.GetObject("pBlogim.Image")));
            this.pBlogim.InitialImage = ((System.Drawing.Image)(resources.GetObject("pBlogim.InitialImage")));
            this.pBlogim.Location = new System.Drawing.Point(4, 181);
            this.pBlogim.Name = "pBlogim";
            this.pBlogim.Size = new System.Drawing.Size(139, 136);
            this.pBlogim.TabIndex = 8;
            this.pBlogim.TabStop = false;
            // 
            // FrmInicio
            // 
            this.AcceptButton = this.BtnAcceso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(613, 325);
            this.Controls.Add(this.gBlogin);
            this.Controls.Add(this.pBlogo);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.lblDesarrollo);
            this.Controls.Add(this.pBlogim);
            this.Controls.Add(this.lbbienvenida);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAcceso);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.gBlogin.ResumeLayout(false);
            this.gBlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBlogim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcceso;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox tBusuario;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.Label lbbienvenida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LinkLabelAyuda;
        private System.Windows.Forms.PictureBox pBlogim;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lblDesarrollo;
        private System.Windows.Forms.PictureBox pBlogo;
        private System.Windows.Forms.GroupBox gBlogin;
        private System.Windows.Forms.CheckBox cBoxRecordar;
        private System.Windows.Forms.Button btnVer;
    }
}