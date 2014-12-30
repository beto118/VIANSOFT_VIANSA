namespace Punto_de_Venta.Pantallas.Proveedor
{
    partial class Frm_MantFactProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcFactura = new System.Windows.Forms.TabControl();
            this.tpDetalle = new System.Windows.Forms.TabPage();
            this.btnReporteFactura = new System.Windows.Forms.Button();
            this.txbID = new System.Windows.Forms.TextBox();
            this.pnlDetalle = new System.Windows.Forms.Panel();
            this.txbProducto_codigoSistema = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAplicInv = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txbTotalLinea = new System.Windows.Forms.TextBox();
            this.txbPrecioNuevo = new System.Windows.Forms.TextBox();
            this.txbProducto_nombre = new System.Windows.Forms.TextBox();
            this.txbProducto_codigo = new System.Windows.Forms.TextBox();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.col_cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_NomProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DetalleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioAnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_PrecioNuevo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbDescuento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txbFecha = new System.Windows.Forms.DateTimePicker();
            this.txbIV = new System.Windows.Forms.TextBox();
            this.txbFecLimite = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.txbProveedor_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbProveedor_nombre = new System.Windows.Forms.TextBox();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.tpPagos = new System.Windows.Forms.TabPage();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.btnAgregarPago = new System.Windows.Forms.Button();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.tpNC = new System.Windows.Forms.TabPage();
            this.btnNC = new System.Windows.Forms.Button();
            this.dgvNC = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tcFactura.SuspendLayout();
            this.tpDetalle.SuspendLayout();
            this.pnlDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.tpPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tpNC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNC)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tcFactura
            // 
            this.tcFactura.Controls.Add(this.tpDetalle);
            this.tcFactura.Controls.Add(this.tpPagos);
            this.tcFactura.Controls.Add(this.tpNC);
            this.tcFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcFactura.Location = new System.Drawing.Point(11, 14);
            this.tcFactura.Margin = new System.Windows.Forms.Padding(4);
            this.tcFactura.Name = "tcFactura";
            this.tcFactura.SelectedIndex = 0;
            this.tcFactura.Size = new System.Drawing.Size(812, 510);
            this.tcFactura.TabIndex = 32;
            // 
            // tpDetalle
            // 
            this.tpDetalle.Controls.Add(this.btnReporteFactura);
            this.tpDetalle.Controls.Add(this.txbID);
            this.tpDetalle.Controls.Add(this.pnlDetalle);
            this.tpDetalle.Controls.Add(this.txbNumero);
            this.tpDetalle.Controls.Add(this.txbDetalle);
            this.tpDetalle.Controls.Add(this.label1);
            this.tpDetalle.Controls.Add(this.label10);
            this.tpDetalle.Controls.Add(this.label2);
            this.tpDetalle.Controls.Add(this.label9);
            this.tpDetalle.Controls.Add(this.label3);
            this.tpDetalle.Controls.Add(this.txbDescuento);
            this.tpDetalle.Controls.Add(this.label4);
            this.tpDetalle.Controls.Add(this.label8);
            this.tpDetalle.Controls.Add(this.txbFecha);
            this.tpDetalle.Controls.Add(this.txbIV);
            this.tpDetalle.Controls.Add(this.txbFecLimite);
            this.tpDetalle.Controls.Add(this.label7);
            this.tpDetalle.Controls.Add(this.label5);
            this.tpDetalle.Controls.Add(this.txbSaldo);
            this.tpDetalle.Controls.Add(this.txbProveedor_id);
            this.tpDetalle.Controls.Add(this.label6);
            this.tpDetalle.Controls.Add(this.txbProveedor_nombre);
            this.tpDetalle.Controls.Add(this.txbMonto);
            this.tpDetalle.Location = new System.Drawing.Point(4, 24);
            this.tpDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.tpDetalle.Name = "tpDetalle";
            this.tpDetalle.Padding = new System.Windows.Forms.Padding(4);
            this.tpDetalle.Size = new System.Drawing.Size(804, 482);
            this.tpDetalle.TabIndex = 0;
            this.tpDetalle.Text = "Factura";
            this.tpDetalle.UseVisualStyleBackColor = true;
            // 
            // btnReporteFactura
            // 
            this.btnReporteFactura.Location = new System.Drawing.Point(304, 0);
            this.btnReporteFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btnReporteFactura.Name = "btnReporteFactura";
            this.btnReporteFactura.Size = new System.Drawing.Size(217, 28);
            this.btnReporteFactura.TabIndex = 37;
            this.btnReporteFactura.Text = "Reporte Factura";
            this.btnReporteFactura.UseVisualStyleBackColor = true;
            this.btnReporteFactura.Click += new System.EventHandler(this.btnReporteFactura_Click);
            // 
            // txbID
            // 
            this.txbID.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbID.Enabled = false;
            this.txbID.Location = new System.Drawing.Point(80, 34);
            this.txbID.Margin = new System.Windows.Forms.Padding(4);
            this.txbID.Name = "txbID";
            this.txbID.ReadOnly = true;
            this.txbID.Size = new System.Drawing.Size(132, 21);
            this.txbID.TabIndex = 9;
            // 
            // pnlDetalle
            // 
            this.pnlDetalle.Controls.Add(this.txbProducto_codigoSistema);
            this.pnlDetalle.Controls.Add(this.label15);
            this.pnlDetalle.Controls.Add(this.nudCantidad);
            this.pnlDetalle.Controls.Add(this.label14);
            this.pnlDetalle.Controls.Add(this.label13);
            this.pnlDetalle.Controls.Add(this.label12);
            this.pnlDetalle.Controls.Add(this.label11);
            this.pnlDetalle.Controls.Add(this.btnAplicInv);
            this.pnlDetalle.Controls.Add(this.btnEliminar);
            this.pnlDetalle.Controls.Add(this.btnAgregar);
            this.pnlDetalle.Controls.Add(this.txbTotalLinea);
            this.pnlDetalle.Controls.Add(this.txbPrecioNuevo);
            this.pnlDetalle.Controls.Add(this.txbProducto_nombre);
            this.pnlDetalle.Controls.Add(this.txbProducto_codigo);
            this.pnlDetalle.Controls.Add(this.dgvDetalle);
            this.pnlDetalle.Location = new System.Drawing.Point(24, 165);
            this.pnlDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDetalle.Name = "pnlDetalle";
            this.pnlDetalle.Size = new System.Drawing.Size(753, 310);
            this.pnlDetalle.TabIndex = 30;
            // 
            // txbProducto_codigoSistema
            // 
            this.txbProducto_codigoSistema.Location = new System.Drawing.Point(26, 26);
            this.txbProducto_codigoSistema.Margin = new System.Windows.Forms.Padding(4);
            this.txbProducto_codigoSistema.Name = "txbProducto_codigoSistema";
            this.txbProducto_codigoSistema.Size = new System.Drawing.Size(89, 21);
            this.txbProducto_codigoSistema.TabIndex = 37;
            this.txbProducto_codigoSistema.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(623, 10);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 15);
            this.label15.TabIndex = 36;
            this.label15.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(604, 31);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.nudCantidad.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudCantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(104, 21);
            this.nudCantidad.TabIndex = 35;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCantidad.Enter += new System.EventHandler(this.nudCantidad_Enter);
            this.nudCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nudCantidad_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(517, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 34;
            this.label14.Text = "Total";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 10);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 15);
            this.label13.TabIndex = 33;
            this.label13.Text = "Precio Uni";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "Nombre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 10);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 15);
            this.label11.TabIndex = 31;
            this.label11.Text = "Codigo";
            // 
            // btnAplicInv
            // 
            this.btnAplicInv.Enabled = false;
            this.btnAplicInv.Location = new System.Drawing.Point(379, 55);
            this.btnAplicInv.Margin = new System.Windows.Forms.Padding(4);
            this.btnAplicInv.Name = "btnAplicInv";
            this.btnAplicInv.Size = new System.Drawing.Size(217, 28);
            this.btnAplicInv.TabIndex = 19;
            this.btnAplicInv.Text = "Aplicar al Inventario";
            this.btnAplicInv.UseVisualStyleBackColor = true;
            this.btnAplicInv.Click += new System.EventHandler(this.btnAplicInv_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(123, 55);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(15, 55);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            this.btnAgregar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAgregar_KeyPress);
            // 
            // txbTotalLinea
            // 
            this.txbTotalLinea.Location = new System.Drawing.Point(476, 30);
            this.txbTotalLinea.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotalLinea.Name = "txbTotalLinea";
            this.txbTotalLinea.Size = new System.Drawing.Size(119, 21);
            this.txbTotalLinea.TabIndex = 16;
            this.txbTotalLinea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTotalLinea_KeyPress);
            // 
            // txbPrecioNuevo
            // 
            this.txbPrecioNuevo.Location = new System.Drawing.Point(348, 30);
            this.txbPrecioNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txbPrecioNuevo.Name = "txbPrecioNuevo";
            this.txbPrecioNuevo.Size = new System.Drawing.Size(119, 21);
            this.txbPrecioNuevo.TabIndex = 15;
            this.txbPrecioNuevo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPrecioNuevo_KeyPress);
            // 
            // txbProducto_nombre
            // 
            this.txbProducto_nombre.Location = new System.Drawing.Point(113, 30);
            this.txbProducto_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbProducto_nombre.Name = "txbProducto_nombre";
            this.txbProducto_nombre.Size = new System.Drawing.Size(225, 21);
            this.txbProducto_nombre.TabIndex = 14;
            // 
            // txbProducto_codigo
            // 
            this.txbProducto_codigo.Location = new System.Drawing.Point(15, 30);
            this.txbProducto_codigo.Margin = new System.Windows.Forms.Padding(4);
            this.txbProducto_codigo.Name = "txbProducto_codigo";
            this.txbProducto_codigo.Size = new System.Drawing.Size(89, 21);
            this.txbProducto_codigo.TabIndex = 13;
            this.txbProducto_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbProducto_codigo_KeyPress);
            this.txbProducto_codigo.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txbProducto_codigo_MouseDoubleClick);
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalle.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_cant,
            this.col_NomProducto,
            this.col_DetalleID,
            this.col_ID,
            this.col_PrecioAnt,
            this.col_PrecioNuevo,
            this.col_total,
            this.col_Estado});
            this.dgvDetalle.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvDetalle.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvDetalle.Location = new System.Drawing.Point(4, 86);
            this.dgvDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDetalle.MultiSelect = false;
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalle.Size = new System.Drawing.Size(713, 220);
            this.dgvDetalle.TabIndex = 12;
            this.dgvDetalle.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDetalle_CellMouseDoubleClick);
            // 
            // col_cant
            // 
            this.col_cant.DataPropertyName = "DetalleFactProveedor_cant";
            this.col_cant.HeaderText = "Cantidad";
            this.col_cant.Name = "col_cant";
            this.col_cant.ReadOnly = true;
            this.col_cant.Width = 70;
            // 
            // col_NomProducto
            // 
            this.col_NomProducto.DataPropertyName = "Producto_nombre";
            this.col_NomProducto.HeaderText = "Producto";
            this.col_NomProducto.Name = "col_NomProducto";
            this.col_NomProducto.ReadOnly = true;
            this.col_NomProducto.Width = 200;
            // 
            // col_DetalleID
            // 
            this.col_DetalleID.DataPropertyName = "DetalleFactProveedor_id";
            this.col_DetalleID.HeaderText = "Linea_id";
            this.col_DetalleID.MinimumWidth = 2;
            this.col_DetalleID.Name = "col_DetalleID";
            this.col_DetalleID.ReadOnly = true;
            this.col_DetalleID.Visible = false;
            this.col_DetalleID.Width = 2;
            // 
            // col_ID
            // 
            this.col_ID.DataPropertyName = "Producto_Id";
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 2;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            this.col_ID.Visible = false;
            this.col_ID.Width = 2;
            // 
            // col_PrecioAnt
            // 
            this.col_PrecioAnt.DataPropertyName = "DetalleFactProveedor_precioAnterior";
            this.col_PrecioAnt.HeaderText = "Anterior";
            this.col_PrecioAnt.MinimumWidth = 2;
            this.col_PrecioAnt.Name = "col_PrecioAnt";
            this.col_PrecioAnt.ReadOnly = true;
            this.col_PrecioAnt.Width = 2;
            // 
            // col_PrecioNuevo
            // 
            this.col_PrecioNuevo.DataPropertyName = "DetalleFactProveedor_precioNuevo";
            this.col_PrecioNuevo.HeaderText = "Prec Uni";
            this.col_PrecioNuevo.Name = "col_PrecioNuevo";
            this.col_PrecioNuevo.ReadOnly = true;
            // 
            // col_total
            // 
            this.col_total.DataPropertyName = "DetalleFactProveedor_total";
            this.col_total.HeaderText = "Total";
            this.col_total.Name = "col_total";
            // 
            // col_Estado
            // 
            this.col_Estado.DataPropertyName = "DetalleFactProveedor_estado";
            this.col_Estado.HeaderText = "Estado";
            this.col_Estado.Name = "col_Estado";
            this.col_Estado.Width = 50;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(80, 63);
            this.txbNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(132, 21);
            this.txbNumero.TabIndex = 10;
            this.txbNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbNumero_KeyPress);
            // 
            // txbDetalle
            // 
            this.txbDetalle.Location = new System.Drawing.Point(492, 100);
            this.txbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txbDetalle.Multiline = true;
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(195, 51);
            this.txbDetalle.TabIndex = 29;
            this.txbDetalle.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDetalle_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(425, 98);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = "Detalle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Numero";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(215, 133);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = "Descuento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(241, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Fecha";
            // 
            // txbDescuento
            // 
            this.txbDescuento.Location = new System.Drawing.Point(304, 127);
            this.txbDescuento.Margin = new System.Windows.Forms.Padding(4);
            this.txbDescuento.Name = "txbDescuento";
            this.txbDescuento.Size = new System.Drawing.Size(112, 21);
            this.txbDescuento.TabIndex = 26;
            this.txbDescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDescuento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Limite";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 103);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 25;
            this.label8.Text = "IV";
            // 
            // txbFecha
            // 
            this.txbFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbFecha.Location = new System.Drawing.Point(304, 63);
            this.txbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(141, 21);
            this.txbFecha.TabIndex = 15;
            // 
            // txbIV
            // 
            this.txbIV.Location = new System.Drawing.Point(304, 95);
            this.txbIV.Margin = new System.Windows.Forms.Padding(4);
            this.txbIV.Name = "txbIV";
            this.txbIV.Size = new System.Drawing.Size(112, 21);
            this.txbIV.TabIndex = 24;
            this.txbIV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIV_KeyPress);
            // 
            // txbFecLimite
            // 
            this.txbFecLimite.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txbFecLimite.Location = new System.Drawing.Point(521, 63);
            this.txbFecLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txbFecLimite.Name = "txbFecLimite";
            this.txbFecLimite.Size = new System.Drawing.Size(141, 21);
            this.txbFecLimite.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 135);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(217, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Proveedor";
            // 
            // txbSaldo
            // 
            this.txbSaldo.Location = new System.Drawing.Point(80, 127);
            this.txbSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.Size = new System.Drawing.Size(132, 21);
            this.txbSaldo.TabIndex = 22;
            this.txbSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSaldo_KeyPress);
            // 
            // txbProveedor_id
            // 
            this.txbProveedor_id.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbProveedor_id.Location = new System.Drawing.Point(304, 30);
            this.txbProveedor_id.Margin = new System.Windows.Forms.Padding(4);
            this.txbProveedor_id.Name = "txbProveedor_id";
            this.txbProveedor_id.ReadOnly = true;
            this.txbProveedor_id.Size = new System.Drawing.Size(71, 21);
            this.txbProveedor_id.TabIndex = 40;
            this.txbProveedor_id.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txbProveedor_id_MouseDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 103);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Monto";
            // 
            // txbProveedor_nombre
            // 
            this.txbProveedor_nombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbProveedor_nombre.Enabled = false;
            this.txbProveedor_nombre.Location = new System.Drawing.Point(384, 30);
            this.txbProveedor_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txbProveedor_nombre.Name = "txbProveedor_nombre";
            this.txbProveedor_nombre.ReadOnly = true;
            this.txbProveedor_nombre.Size = new System.Drawing.Size(323, 21);
            this.txbProveedor_nombre.TabIndex = 19;
            // 
            // txbMonto
            // 
            this.txbMonto.Location = new System.Drawing.Point(80, 95);
            this.txbMonto.Margin = new System.Windows.Forms.Padding(4);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(132, 21);
            this.txbMonto.TabIndex = 20;
            this.txbMonto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMonto_KeyPress);
            // 
            // tpPagos
            // 
            this.tpPagos.Controls.Add(this.btnEliminarPago);
            this.tpPagos.Controls.Add(this.btnAgregarPago);
            this.tpPagos.Controls.Add(this.dgvListado);
            this.tpPagos.Location = new System.Drawing.Point(4, 24);
            this.tpPagos.Margin = new System.Windows.Forms.Padding(4);
            this.tpPagos.Name = "tpPagos";
            this.tpPagos.Padding = new System.Windows.Forms.Padding(4);
            this.tpPagos.Size = new System.Drawing.Size(804, 482);
            this.tpPagos.TabIndex = 1;
            this.tpPagos.Text = "Pagos";
            this.tpPagos.UseVisualStyleBackColor = true;
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.Location = new System.Drawing.Point(152, 22);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(135, 33);
            this.btnEliminarPago.TabIndex = 26;
            this.btnEliminarPago.Text = "Eliminar Pago";
            this.btnEliminarPago.UseVisualStyleBackColor = true;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // btnAgregarPago
            // 
            this.btnAgregarPago.Location = new System.Drawing.Point(9, 22);
            this.btnAgregarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarPago.Name = "btnAgregarPago";
            this.btnAgregarPago.Size = new System.Drawing.Size(135, 33);
            this.btnAgregarPago.TabIndex = 25;
            this.btnAgregarPago.Text = "Agregar Pago";
            this.btnAgregarPago.UseVisualStyleBackColor = true;
            this.btnAgregarPago.Click += new System.EventHandler(this.btnAgregarPago_Click);
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(4, 74);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(796, 404);
            this.dgvListado.TabIndex = 24;
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            // 
            // tpNC
            // 
            this.tpNC.Controls.Add(this.btnNC);
            this.tpNC.Controls.Add(this.dgvNC);
            this.tpNC.Location = new System.Drawing.Point(4, 24);
            this.tpNC.Margin = new System.Windows.Forms.Padding(4);
            this.tpNC.Name = "tpNC";
            this.tpNC.Size = new System.Drawing.Size(804, 482);
            this.tpNC.TabIndex = 2;
            this.tpNC.Text = "Notas Credito";
            this.tpNC.UseVisualStyleBackColor = true;
            // 
            // btnNC
            // 
            this.btnNC.Location = new System.Drawing.Point(9, 23);
            this.btnNC.Margin = new System.Windows.Forms.Padding(4);
            this.btnNC.Name = "btnNC";
            this.btnNC.Size = new System.Drawing.Size(135, 33);
            this.btnNC.TabIndex = 26;
            this.btnNC.Text = "Agregar Nota Credito";
            this.btnNC.UseVisualStyleBackColor = true;
            this.btnNC.Click += new System.EventHandler(this.btnNC_Click);
            // 
            // dgvNC
            // 
            this.dgvNC.AllowUserToAddRows = false;
            this.dgvNC.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvNC.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNC.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvNC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNC.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvNC.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNC.Location = new System.Drawing.Point(0, 78);
            this.dgvNC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNC.MultiSelect = false;
            this.dgvNC.Name = "dgvNC";
            this.dgvNC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNC.Size = new System.Drawing.Size(804, 404);
            this.dgvNC.TabIndex = 25;
            this.dgvNC.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNC_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnLimpiar);
            this.groupBox1.Location = new System.Drawing.Point(9, 525);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(808, 116);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardar.Location = new System.Drawing.Point(16, 26);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 78);
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
            this.btnCancelar.Location = new System.Drawing.Point(543, 26);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(217, 78);
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
            this.btnLimpiar.Location = new System.Drawing.Point(287, 26);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(5);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(217, 78);
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
            // Frm_MantFactProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 649);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tcFactura);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MantFactProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura de Proveedor";
            this.tcFactura.ResumeLayout(false);
            this.tpDetalle.ResumeLayout(false);
            this.tpDetalle.PerformLayout();
            this.pnlDetalle.ResumeLayout(false);
            this.pnlDetalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.tpPagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tpNC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNC)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcFactura;
        private System.Windows.Forms.TabPage tpDetalle;
        private System.Windows.Forms.Button btnReporteFactura;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Panel pnlDetalle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAplicInv;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txbTotalLinea;
        private System.Windows.Forms.TextBox txbPrecioNuevo;
        private System.Windows.Forms.TextBox txbProducto_nombre;
        private System.Windows.Forms.TextBox txbProducto_codigo;
        private System.Windows.Forms.DataGridView dgvDetalle;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.TextBox txbDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbDescuento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txbFecha;
        private System.Windows.Forms.TextBox txbIV;
        private System.Windows.Forms.DateTimePicker txbFecLimite;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.TextBox txbProveedor_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbProveedor_nombre;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.TabPage tpPagos;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.Button btnAgregarPago;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TabPage tpNC;
        private System.Windows.Forms.Button btnNC;
        private System.Windows.Forms.DataGridView dgvNC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_NomProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DetalleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioAnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_PrecioNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Estado;
        private System.Windows.Forms.TextBox txbProducto_codigoSistema;
    }
}