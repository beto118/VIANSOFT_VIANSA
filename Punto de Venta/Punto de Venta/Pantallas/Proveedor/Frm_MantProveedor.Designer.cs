namespace Punto_de_Venta.Pantallas.Proveedor
{
    partial class Frm_MantProveedor
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcPRoveedor = new System.Windows.Forms.TabControl();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.txbTel1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbRepresentante = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTel1 = new System.Windows.Forms.Label();
            this.txbLugar = new System.Windows.Forms.TextBox();
            this.lblTel2 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txbTel2 = new System.Windows.Forms.TextBox();
            this.tpFacturas = new System.Windows.Forms.TabPage();
            this.btnReporte = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.ckSaldo = new System.Windows.Forms.CheckBox();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcPRoveedor.SuspendLayout();
            this.tpDetalle.SuspendLayout();
            this.tpFacturas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPRoveedor
            // 
            this.tcPRoveedor.Controls.Add(this.tpDetalle);
            this.tcPRoveedor.Controls.Add(this.tpFacturas);
            this.tcPRoveedor.Location = new System.Drawing.Point(8, 8);
            this.tcPRoveedor.Margin = new System.Windows.Forms.Padding(4);
            this.tcPRoveedor.Name = "tcPRoveedor";
            this.tcPRoveedor.SelectedIndex = 0;
            this.tcPRoveedor.Size = new System.Drawing.Size(768, 372);
            this.tcPRoveedor.TabIndex = 12;
            // 
            // tpDetalle
            // 
            this.tpDetalle.BackColor = System.Drawing.Color.White;
            this.tpDetalle.Controls.Add(this.cmbDia);
            this.tpDetalle.Controls.Add(this.txbTel1);
            this.tpDetalle.Controls.Add(this.label5);
            this.tpDetalle.Controls.Add(this.label1);
            this.tpDetalle.Controls.Add(this.txbRepresentante);
            this.tpDetalle.Controls.Add(this.txbCodigo);
            this.tpDetalle.Controls.Add(this.label4);
            this.tpDetalle.Controls.Add(this.label2);
            this.tpDetalle.Controls.Add(this.txbDetalle);
            this.tpDetalle.Controls.Add(this.txbNombre);
            this.tpDetalle.Controls.Add(this.label3);
            this.tpDetalle.Controls.Add(this.lblTel1);
            this.tpDetalle.Controls.Add(this.txbLugar);
            this.tpDetalle.Controls.Add(this.lblTel2);
            this.tpDetalle.Controls.Add(this.lblDireccion);
            this.tpDetalle.Controls.Add(this.txbTel2);
            this.tpDetalle.Location = new System.Drawing.Point(4, 25);
            this.tpDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.tpDetalle.Name = "tpDetalle";
            this.tpDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.tpDetalle.Size = new System.Drawing.Size(760, 343);
            this.tpDetalle.TabIndex = 0;
            this.tpDetalle.Text = "Detalle";
            // 
            // cmbDia
            // 
            this.cmbDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miercoles",
            "Jueves",
            "Viernes",
            "Sabado",
            "Domingo"});
            this.cmbDia.Location = new System.Drawing.Point(149, 223);
            this.cmbDia.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(287, 24);
            this.cmbDia.TabIndex = 18;
            // 
            // txbTel1
            // 
            this.txbTel1.Location = new System.Drawing.Point(149, 117);
            this.txbTel1.Margin = new System.Windows.Forms.Padding(4);
            this.txbTel1.Name = "txbTel1";
            this.txbTel1.Size = new System.Drawing.Size(153, 22);
            this.txbTel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dia Pasa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo";
            // 
            // txbRepresentante
            // 
            this.txbRepresentante.Location = new System.Drawing.Point(149, 80);
            this.txbRepresentante.Margin = new System.Windows.Forms.Padding(4);
            this.txbRepresentante.Name = "txbRepresentante";
            this.txbRepresentante.Size = new System.Drawing.Size(553, 22);
            this.txbRepresentante.TabIndex = 4;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Location = new System.Drawing.Point(149, 11);
            this.txbCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.ReadOnly = true;
            this.txbCodigo.Size = new System.Drawing.Size(153, 22);
            this.txbCodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Representante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txbDetalle
            // 
            this.txbDetalle.Location = new System.Drawing.Point(149, 261);
            this.txbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txbDetalle.Multiline = true;
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(553, 59);
            this.txbDetalle.TabIndex = 19;
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(149, 48);
            this.txbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(553, 22);
            this.txbNombre.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 261);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Detalle";
            // 
            // lblTel1
            // 
            this.lblTel1.AutoSize = true;
            this.lblTel1.Location = new System.Drawing.Point(25, 121);
            this.lblTel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel1.Name = "lblTel1";
            this.lblTel1.Size = new System.Drawing.Size(72, 16);
            this.lblTel1.TabIndex = 4;
            this.lblTel1.Text = "Telefono 1";
            // 
            // txbLugar
            // 
            this.txbLugar.Location = new System.Drawing.Point(149, 192);
            this.txbLugar.Margin = new System.Windows.Forms.Padding(4);
            this.txbLugar.Multiline = true;
            this.txbLugar.Name = "txbLugar";
            this.txbLugar.Size = new System.Drawing.Size(553, 29);
            this.txbLugar.TabIndex = 17;
            // 
            // lblTel2
            // 
            this.lblTel2.AutoSize = true;
            this.lblTel2.Location = new System.Drawing.Point(25, 158);
            this.lblTel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel2.Name = "lblTel2";
            this.lblTel2.Size = new System.Drawing.Size(72, 16);
            this.lblTel2.TabIndex = 6;
            this.lblTel2.Text = "Telefono 2";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(25, 192);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(42, 16);
            this.lblDireccion.TabIndex = 11;
            this.lblDireccion.Text = "Lugar";
            // 
            // txbTel2
            // 
            this.txbTel2.Location = new System.Drawing.Point(149, 154);
            this.txbTel2.Margin = new System.Windows.Forms.Padding(4);
            this.txbTel2.Name = "txbTel2";
            this.txbTel2.Size = new System.Drawing.Size(153, 22);
            this.txbTel2.TabIndex = 7;
            // 
            // tpFacturas
            // 
            this.tpFacturas.Controls.Add(this.btnReporte);
            this.tpFacturas.Controls.Add(this.btnNuevo);
            this.tpFacturas.Controls.Add(this.ckSaldo);
            this.tpFacturas.Controls.Add(this.dgvListado);
            this.tpFacturas.Controls.Add(this.btnBuscar);
            this.tpFacturas.Controls.Add(this.label6);
            this.tpFacturas.Controls.Add(this.txbFiltro);
            this.tpFacturas.Location = new System.Drawing.Point(4, 25);
            this.tpFacturas.Margin = new System.Windows.Forms.Padding(4);
            this.tpFacturas.Name = "tpFacturas";
            this.tpFacturas.Padding = new System.Windows.Forms.Padding(4);
            this.tpFacturas.Size = new System.Drawing.Size(760, 343);
            this.tpFacturas.TabIndex = 1;
            this.tpFacturas.Text = "Facturas";
            this.tpFacturas.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(169, 34);
            this.btnReporte.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(116, 33);
            this.btnReporte.TabIndex = 26;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(13, 36);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(116, 33);
            this.btnNuevo.TabIndex = 25;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // ckSaldo
            // 
            this.ckSaldo.AutoSize = true;
            this.ckSaldo.Checked = true;
            this.ckSaldo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSaldo.Location = new System.Drawing.Point(436, 16);
            this.ckSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.ckSaldo.Name = "ckSaldo";
            this.ckSaldo.Size = new System.Drawing.Size(119, 20);
            this.ckSaldo.TabIndex = 24;
            this.ckSaldo.Text = "Solo con Saldo";
            this.ckSaldo.UseVisualStyleBackColor = true;
            this.ckSaldo.CheckedChanged += new System.EventHandler(this.ckSaldo_CheckedChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(4, 79);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(752, 260);
            this.dgvListado.TabIndex = 23;
            this.dgvListado.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvListado_CellMouseDoubleClick);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(297, 9);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 33);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Filtro";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(79, 9);
            this.txbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(207, 22);
            this.txbFiltro.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(25, 388);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(695, 94);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardar.Location = new System.Drawing.Point(68, 20);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 63);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(463, 20);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 63);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Image = global::Punto_de_Venta.Properties.Resources.images;
            this.btnLimpiar.Location = new System.Drawing.Point(271, 20);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(163, 63);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_MantProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 495);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tcPRoveedor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MantProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedor";
            this.tcPRoveedor.ResumeLayout(false);
            this.tpDetalle.ResumeLayout(false);
            this.tpDetalle.PerformLayout();
            this.tpFacturas.ResumeLayout(false);
            this.tpFacturas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPRoveedor;
        private System.Windows.Forms.TabPage tpDetalle;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.TextBox txbTel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbRepresentante;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDetalle;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTel1;
        private System.Windows.Forms.TextBox txbLugar;
        private System.Windows.Forms.Label lblTel2;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txbTel2;
        private System.Windows.Forms.TabPage tpFacturas;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.CheckBox ckSaldo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}