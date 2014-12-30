namespace Punto_de_Venta.Pantallas.Proveedor
{
    partial class frm_ReportePagoProveedor
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
            this.txbProveedor_nombre = new System.Windows.Forms.TextBox();
            this.txbProveedor_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbProveedor_nombre
            // 
            this.txbProveedor_nombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbProveedor_nombre.Location = new System.Drawing.Point(235, 69);
            this.txbProveedor_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbProveedor_nombre.Name = "txbProveedor_nombre";
            this.txbProveedor_nombre.ReadOnly = true;
            this.txbProveedor_nombre.Size = new System.Drawing.Size(396, 22);
            this.txbProveedor_nombre.TabIndex = 36;
            this.txbProveedor_nombre.Text = "TODOS";
            // 
            // txbProveedor_codigo
            // 
            this.txbProveedor_codigo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbProveedor_codigo.Location = new System.Drawing.Point(144, 69);
            this.txbProveedor_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbProveedor_codigo.Name = "txbProveedor_codigo";
            this.txbProveedor_codigo.ReadOnly = true;
            this.txbProveedor_codigo.Size = new System.Drawing.Size(76, 22);
            this.txbProveedor_codigo.TabIndex = 35;
            this.txbProveedor_codigo.Text = "0";
            this.txbProveedor_codigo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txbProveedor_codigo_MouseDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Proveedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Hasta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Desde";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Location = new System.Drawing.Point(365, 134);
            this.dtpFechaHasta.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaHasta.TabIndex = 31;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Location = new System.Drawing.Point(61, 134);
            this.dtpFechaDesde.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaDesde.TabIndex = 30;
            // 
            // btnReporte
            // 
            this.btnReporte.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnReporte.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnReporte.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.btnReporte.Location = new System.Drawing.Point(113, 215);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(200, 49);
            this.btnReporte.TabIndex = 38;
            this.btnReporte.Text = "Generar";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(413, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 49);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frm_ReportePagoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 361);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txbProveedor_nombre);
            this.Controls.Add(this.txbProveedor_codigo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaHasta);
            this.Controls.Add(this.dtpFechaDesde);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_ReportePagoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Pago Proveedor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbProveedor_nombre;
        private System.Windows.Forms.TextBox txbProveedor_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnCancelar;

    }
}