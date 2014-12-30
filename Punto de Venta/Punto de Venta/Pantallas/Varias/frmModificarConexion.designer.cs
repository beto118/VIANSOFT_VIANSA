namespace Punto_de_Venta
{
    partial class frmModificarConexion
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.txbServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbReportes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbCaja = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbImpFactura = new System.Windows.Forms.TextBox();
            this.fbd_reportes = new System.Windows.Forms.FolderBrowserDialog();
            this.ofd_Imagen = new System.Windows.Forms.OpenFileDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.txbPuerto = new System.Windows.Forms.TextBox();
            this.txbLicencia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.sbpUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // stbStatusBar
            // 
            this.stbStatusBar.Location = new System.Drawing.Point(0, 298);
            this.stbStatusBar.Size = new System.Drawing.Size(508, 27);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Server";
            // 
            // txbServer
            // 
            this.txbServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServer.Location = new System.Drawing.Point(156, 73);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(338, 24);
            this.txbServer.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dase Datos";
            // 
            // txbDB
            // 
            this.txbDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDB.Location = new System.Drawing.Point(156, 99);
            this.txbDB.Name = "txbDB";
            this.txbDB.Size = new System.Drawing.Size(338, 24);
            this.txbDB.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Reportes";
            // 
            // txbReportes
            // 
            this.txbReportes.BackColor = System.Drawing.SystemColors.Window;
            this.txbReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbReportes.Location = new System.Drawing.Point(156, 125);
            this.txbReportes.Name = "txbReportes";
            this.txbReportes.Size = new System.Drawing.Size(338, 24);
            this.txbReportes.TabIndex = 14;
            this.txbReportes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txbReportes_MouseDoubleClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Licencia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 17;
            this.label5.Text = "Caja";
            // 
            // txbCaja
            // 
            this.txbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCaja.Location = new System.Drawing.Point(156, 176);
            this.txbCaja.Name = "txbCaja";
            this.txbCaja.Size = new System.Drawing.Size(338, 24);
            this.txbCaja.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "Impresora Factura";
            // 
            // txbImpFactura
            // 
            this.txbImpFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbImpFactura.Location = new System.Drawing.Point(156, 151);
            this.txbImpFactura.Name = "txbImpFactura";
            this.txbImpFactura.Size = new System.Drawing.Size(338, 24);
            this.txbImpFactura.TabIndex = 16;
            // 
            // ofd_Imagen
            // 
            this.ofd_Imagen.Filter = "Imagen JPG (*.JPG)|*.JPG|Todos Los Archivos (*.*)|*.*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 18);
            this.label7.TabIndex = 21;
            this.label7.Text = "Puerto Bascula";
            // 
            // txbPuerto
            // 
            this.txbPuerto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPuerto.Location = new System.Drawing.Point(156, 202);
            this.txbPuerto.Name = "txbPuerto";
            this.txbPuerto.Size = new System.Drawing.Size(338, 24);
            this.txbPuerto.TabIndex = 22;
            // 
            // txbLicencia
            // 
            this.txbLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbLicencia.Location = new System.Drawing.Point(156, 232);
            this.txbLicencia.Name = "txbLicencia";
            this.txbLicencia.Size = new System.Drawing.Size(338, 24);
            this.txbLicencia.TabIndex = 23;
            // 
            // frmModificarConexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 325);
            this.Controls.Add(this.txbLicencia);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbPuerto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbCaja);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbImpFactura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbReportes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbServer);
            this.Name = "frmModificarConexion";
            this.Text = "Modificar Conexion";
            this.Load += new System.EventHandler(this.frmModificarConexion_Load);
            this.Controls.SetChildIndex(this.txbServer, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.stbStatusBar, 0);
            this.Controls.SetChildIndex(this.txbDB, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txbReportes, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txbImpFactura, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txbCaja, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txbPuerto, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.txbLicencia, 0);
            ((System.ComponentModel.ISupportInitialize)(this.sbpUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sbpFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbReportes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbCaja;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbImpFactura;
        private System.Windows.Forms.FolderBrowserDialog fbd_reportes;
        private System.Windows.Forms.OpenFileDialog ofd_Imagen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbPuerto;
        private System.Windows.Forms.TextBox txbLicencia;
    }
}