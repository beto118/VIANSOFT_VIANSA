namespace Punto_de_Venta.Pantallas.Cierre_de_Cajas
{
    partial class Frm_ConsultaReportXFecha
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.gbOrdenado = new System.Windows.Forms.GroupBox();
            this.rbVenta = new System.Windows.Forms.RadioButton();
            this.rbNombre = new System.Windows.Forms.RadioButton();
            this.rbCodigo = new System.Windows.Forms.RadioButton();
            this.gbox2 = new System.Windows.Forms.GroupBox();
            this.rbtnFactHoy = new System.Windows.Forms.RadioButton();
            this.rbtnOrdenes = new System.Windows.Forms.RadioButton();
            this.rbtnFacturasHist = new System.Windows.Forms.RadioButton();
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.txbCodCliente = new System.Windows.Forms.TextBox();
            this.gbOrdenado.SuspendLayout();
            this.gbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha Final:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.White;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.btnImprimir.Location = new System.Drawing.Point(152, 178);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(124, 55);
            this.btnImprimir.TabIndex = 3;
            this.btnImprimir.Text = "Reporte";
            this.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Black;
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(316, 178);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 55);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaInicio.Location = new System.Drawing.Point(150, 24);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(136, 26);
            this.dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaFinal.Location = new System.Drawing.Point(424, 23);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(136, 26);
            this.dtpFechaFinal.TabIndex = 2;
            // 
            // gbOrdenado
            // 
            this.gbOrdenado.Controls.Add(this.rbVenta);
            this.gbOrdenado.Controls.Add(this.rbNombre);
            this.gbOrdenado.Controls.Add(this.rbCodigo);
            this.gbOrdenado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbOrdenado.Location = new System.Drawing.Point(20, 59);
            this.gbOrdenado.Name = "gbOrdenado";
            this.gbOrdenado.Size = new System.Drawing.Size(545, 52);
            this.gbOrdenado.TabIndex = 5;
            this.gbOrdenado.TabStop = false;
            this.gbOrdenado.Text = "Ordenado por:";
            // 
            // rbVenta
            // 
            this.rbVenta.AutoSize = true;
            this.rbVenta.Location = new System.Drawing.Point(375, 23);
            this.rbVenta.Name = "rbVenta";
            this.rbVenta.Size = new System.Drawing.Size(75, 24);
            this.rbVenta.TabIndex = 2;
            this.rbVenta.Text = "Venta";
            this.rbVenta.UseVisualStyleBackColor = true;
            // 
            // rbNombre
            // 
            this.rbNombre.AutoSize = true;
            this.rbNombre.Location = new System.Drawing.Point(252, 22);
            this.rbNombre.Name = "rbNombre";
            this.rbNombre.Size = new System.Drawing.Size(89, 24);
            this.rbNombre.TabIndex = 1;
            this.rbNombre.Text = "Nombre";
            this.rbNombre.UseVisualStyleBackColor = true;
            // 
            // rbCodigo
            // 
            this.rbCodigo.AutoSize = true;
            this.rbCodigo.Checked = true;
            this.rbCodigo.Location = new System.Drawing.Point(129, 22);
            this.rbCodigo.Name = "rbCodigo";
            this.rbCodigo.Size = new System.Drawing.Size(83, 24);
            this.rbCodigo.TabIndex = 0;
            this.rbCodigo.TabStop = true;
            this.rbCodigo.Text = "Codigo";
            this.rbCodigo.UseVisualStyleBackColor = true;
            // 
            // gbox2
            // 
            this.gbox2.Controls.Add(this.rbtnFactHoy);
            this.gbox2.Controls.Add(this.rbtnOrdenes);
            this.gbox2.Controls.Add(this.rbtnFacturasHist);
            this.gbox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.gbox2.Location = new System.Drawing.Point(20, 114);
            this.gbox2.Name = "gbox2";
            this.gbox2.Size = new System.Drawing.Size(545, 52);
            this.gbox2.TabIndex = 6;
            this.gbox2.TabStop = false;
            this.gbox2.Text = "De:";
            // 
            // rbtnFactHoy
            // 
            this.rbtnFactHoy.AutoSize = true;
            this.rbtnFactHoy.Location = new System.Drawing.Point(375, 23);
            this.rbtnFactHoy.Name = "rbtnFactHoy";
            this.rbtnFactHoy.Size = new System.Drawing.Size(58, 24);
            this.rbtnFactHoy.TabIndex = 2;
            this.rbtnFactHoy.Text = "Hoy";
            this.rbtnFactHoy.UseVisualStyleBackColor = true;
            // 
            // rbtnOrdenes
            // 
            this.rbtnOrdenes.AutoSize = true;
            this.rbtnOrdenes.Location = new System.Drawing.Point(252, 22);
            this.rbtnOrdenes.Name = "rbtnOrdenes";
            this.rbtnOrdenes.Size = new System.Drawing.Size(95, 24);
            this.rbtnOrdenes.TabIndex = 1;
            this.rbtnOrdenes.Text = "Ordenes";
            this.rbtnOrdenes.UseVisualStyleBackColor = true;
            // 
            // rbtnFacturasHist
            // 
            this.rbtnFacturasHist.AutoSize = true;
            this.rbtnFacturasHist.Checked = true;
            this.rbtnFacturasHist.Location = new System.Drawing.Point(129, 22);
            this.rbtnFacturasHist.Name = "rbtnFacturasHist";
            this.rbtnFacturasHist.Size = new System.Drawing.Size(98, 24);
            this.rbtnFacturasHist.TabIndex = 0;
            this.rbtnFacturasHist.TabStop = true;
            this.rbtnFacturasHist.Text = "Facturas";
            this.rbtnFacturasHist.UseVisualStyleBackColor = true;
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodCliente.Location = new System.Drawing.Point(169, 105);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(107, 20);
            this.lblCodCliente.TabIndex = 7;
            this.lblCodCliente.Text = "Cod Cliente:";
            // 
            // txbCodCliente
            // 
            this.txbCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodCliente.Location = new System.Drawing.Point(282, 102);
            this.txbCodCliente.Name = "txbCodCliente";
            this.txbCodCliente.Size = new System.Drawing.Size(100, 26);
            this.txbCodCliente.TabIndex = 8;
            // 
            // Frm_ConsultaReportXFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 241);
            this.Controls.Add(this.txbCodCliente);
            this.Controls.Add(this.lblCodCliente);
            this.Controls.Add(this.gbox2);
            this.Controls.Add(this.gbOrdenado);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.dtpFechaInicio);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_ConsultaReportXFecha";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Reportes por Fecha";
            this.Load += new System.EventHandler(this.Frm_ConsultaReportXFecha_Load);
            this.gbOrdenado.ResumeLayout(false);
            this.gbOrdenado.PerformLayout();
            this.gbox2.ResumeLayout(false);
            this.gbox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.GroupBox gbOrdenado;
        private System.Windows.Forms.RadioButton rbVenta;
        private System.Windows.Forms.RadioButton rbNombre;
        private System.Windows.Forms.RadioButton rbCodigo;
        private System.Windows.Forms.GroupBox gbox2;
        private System.Windows.Forms.RadioButton rbtnFactHoy;
        private System.Windows.Forms.RadioButton rbtnOrdenes;
        private System.Windows.Forms.RadioButton rbtnFacturasHist;
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox txbCodCliente;
    }
}