namespace Punto_de_Venta.Pantallas.Egresos
{
    partial class Frm_RegistrarEgresos
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombre_usuario = new System.Windows.Forms.TextBox();
            this.txbCod_usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNota = new System.Windows.Forms.TextBox();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.cmbEgresoTipo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(48, 369);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(555, 73);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(430, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(116, 52);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardar.Location = new System.Drawing.Point(9, 15);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(129, 52);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Punto_de_Venta.Properties.Resources.images;
            this.btnLimpiar.Location = new System.Drawing.Point(226, 15);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(116, 52);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ckEstado);
            this.panel1.Controls.Add(this.txbFecha);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txbNombre_usuario);
            this.panel1.Controls.Add(this.txbCod_usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbNota);
            this.panel1.Controls.Add(this.txbMonto);
            this.panel1.Controls.Add(this.cmbEgresoTipo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblEstado);
            this.panel1.Controls.Add(this.txbNumero);
            this.panel1.Controls.Add(this.lblDetalle);
            this.panel1.Controls.Add(this.lblnumero);
            this.panel1.Location = new System.Drawing.Point(48, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(555, 331);
            this.panel1.TabIndex = 9;
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Checked = true;
            this.ckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.ckEstado.Location = new System.Drawing.Point(182, 301);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(77, 24);
            this.ckEstado.TabIndex = 25;
            this.ckEstado.Text = "Activo";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // txbFecha
            // 
            this.txbFecha.Enabled = false;
            this.txbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFecha.Location = new System.Drawing.Point(182, 255);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(144, 26);
            this.txbFecha.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(99, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Estado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Fecha:";
            // 
            // txbNombre_usuario
            // 
            this.txbNombre_usuario.Enabled = false;
            this.txbNombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txbNombre_usuario.Location = new System.Drawing.Point(219, 217);
            this.txbNombre_usuario.Name = "txbNombre_usuario";
            this.txbNombre_usuario.Size = new System.Drawing.Size(269, 26);
            this.txbNombre_usuario.TabIndex = 21;
            // 
            // txbCod_usuario
            // 
            this.txbCod_usuario.Enabled = false;
            this.txbCod_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txbCod_usuario.Location = new System.Drawing.Point(182, 217);
            this.txbCod_usuario.Name = "txbCod_usuario";
            this.txbCod_usuario.Size = new System.Drawing.Size(31, 26);
            this.txbCod_usuario.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Usuario";
            // 
            // txbNota
            // 
            this.txbNota.BackColor = System.Drawing.Color.White;
            this.txbNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txbNota.Location = new System.Drawing.Point(182, 159);
            this.txbNota.Multiline = true;
            this.txbNota.Name = "txbNota";
            this.txbNota.Size = new System.Drawing.Size(306, 52);
            this.txbNota.TabIndex = 18;
            // 
            // txbMonto
            // 
            this.txbMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.txbMonto.Location = new System.Drawing.Point(182, 120);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(131, 26);
            this.txbMonto.TabIndex = 17;
            // 
            // cmbEgresoTipo
            // 
            this.cmbEgresoTipo.BackColor = System.Drawing.Color.White;
            this.cmbEgresoTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEgresoTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cmbEgresoTipo.FormattingEnabled = true;
            this.cmbEgresoTipo.Location = new System.Drawing.Point(182, 81);
            this.cmbEgresoTipo.Name = "cmbEgresoTipo";
            this.cmbEgresoTipo.Size = new System.Drawing.Size(306, 28);
            this.cmbEgresoTipo.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nota:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(92, 120);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(64, 20);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Monto:";
            // 
            // txbNumero
            // 
            this.txbNumero.Enabled = false;
            this.txbNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumero.Location = new System.Drawing.Point(182, 30);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(100, 26);
            this.txbNumero.TabIndex = 5;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(91, 82);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(48, 20);
            this.lblDetalle.TabIndex = 2;
            this.lblDetalle.Text = "Tipo:";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(92, 33);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(33, 20);
            this.lblnumero.TabIndex = 0;
            this.lblnumero.Text = "ID:";
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_RegistrarEgresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 454);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_RegistrarEgresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Egresos";
            this.Load += new System.EventHandler(this.Frm_RegistrarEgresos_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.ComboBox cmbEgresoTipo;
        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbNombre_usuario;
        private System.Windows.Forms.TextBox txbCod_usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNota;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}