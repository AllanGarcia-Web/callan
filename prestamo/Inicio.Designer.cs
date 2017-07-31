namespace prestamo
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.BtnAcceso = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.tBusuario = new System.Windows.Forms.TextBox();
            this.tBpass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LinkLabelAyuda = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbVer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAcceso
            // 
            this.BtnAcceso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceso.Image = ((System.Drawing.Image)(resources.GetObject("BtnAcceso.Image")));
            this.BtnAcceso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAcceso.Location = new System.Drawing.Point(149, 297);
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
            this.BtnSalir.Location = new System.Drawing.Point(278, 297);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(77, 23);
            this.BtnSalir.TabIndex = 3;
            this.BtnSalir.Text = "Salir";
            this.BtnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // tBusuario
            // 
            this.tBusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBusuario.Location = new System.Drawing.Point(241, 186);
            this.tBusuario.Name = "tBusuario";
            this.tBusuario.Size = new System.Drawing.Size(114, 22);
            this.tBusuario.TabIndex = 0;
            // 
            // tBpass
            // 
            this.tBpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBpass.Location = new System.Drawing.Point(241, 212);
            this.tBpass.Name = "tBpass";
            this.tBpass.PasswordChar = '-';
            this.tBpass.Size = new System.Drawing.Size(114, 22);
            this.tBpass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al Sistema\r\nPERLOAN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(146, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(146, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Contraseña";
            // 
            // LinkLabelAyuda
            // 
            this.LinkLabelAyuda.AutoSize = true;
            this.LinkLabelAyuda.Location = new System.Drawing.Point(150, 249);
            this.LinkLabelAyuda.Name = "LinkLabelAyuda";
            this.LinkLabelAyuda.Size = new System.Drawing.Size(191, 26);
            this.LinkLabelAyuda.TabIndex = 7;
            this.LinkLabelAyuda.TabStop = true;
            this.LinkLabelAyuda.Text = "No puedes acceder, consulta la Ayuda\r\nDando click Aqui";
            this.LinkLabelAyuda.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelAyuda_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 189);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 131);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // lbVer
            // 
            this.lbVer.AutoSize = true;
            this.lbVer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVer.Location = new System.Drawing.Point(119, 52);
            this.lbVer.Name = "lbVer";
            this.lbVer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbVer.Size = new System.Drawing.Size(132, 16);
            this.lbVer.TabIndex = 13;
            this.lbVer.Text = "Ver. Desconocida";
            this.lbVer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(355, 96);
            this.label4.TabIndex = 12;
            this.label4.Text = "SISTEMA EN DESARROLLO\r\nNO USAR EN PRODUCCIÖN\r\nPUEDE PRESENTAR FALLAS DURANTE SU U" +
    "SO\r\n\r\nALGUNAS CARACTERISTICAS O FUNCIONES\r\nPUEDEN O NO ESTAR EN LA VERSIÓN FINAL" +
    "";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(362, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 325);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // Inicio
            // 
            this.AcceptButton = this.BtnAcceso;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(562, 328);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbVer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.LinkLabelAyuda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBpass);
            this.Controls.Add(this.tBusuario);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.BtnAcceso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso al Sistema";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAcceso;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.TextBox tBusuario;
        private System.Windows.Forms.TextBox tBpass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel LinkLabelAyuda;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbVer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}