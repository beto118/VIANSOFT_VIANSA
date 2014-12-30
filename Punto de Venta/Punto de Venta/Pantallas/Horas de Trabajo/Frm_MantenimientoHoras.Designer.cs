namespace Punto_de_Venta.Pantallas.Horas_de_Trabajo
{
    partial class Frm_MantenimientoHoras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDetalleEmpleado = new System.Windows.Forms.TabPage();
            this.txbGanaXhora = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCodigoBarra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbApellido2 = new System.Windows.Forms.TextBox();
            this.txbApellido1 = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDiaTrabajo = new System.Windows.Forms.TabPage();
            this.dgvListadoDiaTrabajo = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txbTotalHoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbTotalMinutos = new System.Windows.Forms.TextBox();
            this.tabConceptoPagos = new System.Windows.Forms.TabPage();
            this.btnEditarConcepto = new System.Windows.Forms.Button();
            this.btnAgregarConcPago = new System.Windows.Forms.Button();
            this.rtxbDetalle = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbxTipoMov = new System.Windows.Forms.ComboBox();
            this.dtgConceptoPago = new System.Windows.Forms.DataGridView();
            this.tabPagosEmpleado = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReporte = new System.Windows.Forms.Button();
            this.dtgPagosVendedor = new System.Windows.Forms.DataGridView();
            this.btnRealizarPago = new System.Windows.Forms.Button();
            this.tabManualmente = new System.Windows.Forms.TabPage();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReporte2 = new System.Windows.Forms.Button();
            this.btnPagar = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.txbSalarioTotal = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txbGanaHora = new System.Windows.Forms.TextBox();
            this.dgvListaDiasTrabajados = new System.Windows.Forms.DataGridView();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txbTotalHor = new System.Windows.Forms.TextBox();
            this.txbTotalMin = new System.Windows.Forms.TextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpFechaEntrada = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txbHoraEntrada = new System.Windows.Forms.TextBox();
            this.txbMinEntrada = new System.Windows.Forms.TextBox();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txbMinSalida = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txbHoraSalida = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabDetalleEmpleado.SuspendLayout();
            this.tabDiaTrabajo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDiaTrabajo)).BeginInit();
            this.tabConceptoPagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConceptoPago)).BeginInit();
            this.tabPagosEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagosVendedor)).BeginInit();
            this.tabManualmente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiasTrabajados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDetalleEmpleado);
            this.tabControl1.Controls.Add(this.tabDiaTrabajo);
            this.tabControl1.Controls.Add(this.tabConceptoPagos);
            this.tabControl1.Controls.Add(this.tabManualmente);
            this.tabControl1.Controls.Add(this.tabPagosEmpleado);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(918, 341);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabDetalleEmpleado
            // 
            this.tabDetalleEmpleado.Controls.Add(this.txbGanaXhora);
            this.tabDetalleEmpleado.Controls.Add(this.label11);
            this.tabDetalleEmpleado.Controls.Add(this.txbCodigoBarra);
            this.tabDetalleEmpleado.Controls.Add(this.label10);
            this.tabDetalleEmpleado.Controls.Add(this.txbApellido2);
            this.tabDetalleEmpleado.Controls.Add(this.txbApellido1);
            this.tabDetalleEmpleado.Controls.Add(this.txbNombre);
            this.tabDetalleEmpleado.Controls.Add(this.txbCodigo);
            this.tabDetalleEmpleado.Controls.Add(this.label4);
            this.tabDetalleEmpleado.Controls.Add(this.label3);
            this.tabDetalleEmpleado.Controls.Add(this.label2);
            this.tabDetalleEmpleado.Controls.Add(this.label1);
            this.tabDetalleEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tabDetalleEmpleado.Name = "tabDetalleEmpleado";
            this.tabDetalleEmpleado.Padding = new System.Windows.Forms.Padding(3);
            this.tabDetalleEmpleado.Size = new System.Drawing.Size(910, 312);
            this.tabDetalleEmpleado.TabIndex = 0;
            this.tabDetalleEmpleado.Text = "Detalle Empleado";
            this.tabDetalleEmpleado.UseVisualStyleBackColor = true;
            // 
            // txbGanaXhora
            // 
            this.txbGanaXhora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbGanaXhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGanaXhora.Location = new System.Drawing.Point(401, 214);
            this.txbGanaXhora.Name = "txbGanaXhora";
            this.txbGanaXhora.Size = new System.Drawing.Size(127, 26);
            this.txbGanaXhora.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Maroon;
            this.label11.Location = new System.Drawing.Point(223, 220);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(163, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Monto gana x hora:";
            // 
            // txbCodigoBarra
            // 
            this.txbCodigoBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigoBarra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoBarra.Location = new System.Drawing.Point(401, 86);
            this.txbCodigoBarra.Name = "txbCodigoBarra";
            this.txbCodigoBarra.Size = new System.Drawing.Size(241, 26);
            this.txbCodigoBarra.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(267, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 20);
            this.label10.TabIndex = 42;
            this.label10.Text = "Codigo Barra:";
            // 
            // txbApellido2
            // 
            this.txbApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido2.Location = new System.Drawing.Point(401, 182);
            this.txbApellido2.Name = "txbApellido2";
            this.txbApellido2.Size = new System.Drawing.Size(241, 26);
            this.txbApellido2.TabIndex = 35;
            // 
            // txbApellido1
            // 
            this.txbApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido1.Location = new System.Drawing.Point(401, 150);
            this.txbApellido1.Name = "txbApellido1";
            this.txbApellido1.Size = new System.Drawing.Size(241, 26);
            this.txbApellido1.TabIndex = 34;
            // 
            // txbNombre
            // 
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(401, 118);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(241, 26);
            this.txbNombre.TabIndex = 33;
            // 
            // txbCodigo
            // 
            this.txbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(401, 54);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 26);
            this.txbCodigo.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(273, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "2do Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(277, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "1er Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(310, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(316, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Codigo:";
            // 
            // tabDiaTrabajo
            // 
            this.tabDiaTrabajo.Controls.Add(this.dgvListadoDiaTrabajo);
            this.tabDiaTrabajo.Controls.Add(this.label5);
            this.tabDiaTrabajo.Controls.Add(this.txbTotalHoras);
            this.tabDiaTrabajo.Controls.Add(this.label6);
            this.tabDiaTrabajo.Controls.Add(this.txbTotalMinutos);
            this.tabDiaTrabajo.Location = new System.Drawing.Point(4, 25);
            this.tabDiaTrabajo.Name = "tabDiaTrabajo";
            this.tabDiaTrabajo.Padding = new System.Windows.Forms.Padding(3);
            this.tabDiaTrabajo.Size = new System.Drawing.Size(910, 312);
            this.tabDiaTrabajo.TabIndex = 1;
            this.tabDiaTrabajo.Text = "Dias Trabajados";
            this.tabDiaTrabajo.UseVisualStyleBackColor = true;
            // 
            // dgvListadoDiaTrabajo
            // 
            this.dgvListadoDiaTrabajo.AllowUserToAddRows = false;
            this.dgvListadoDiaTrabajo.AllowUserToDeleteRows = false;
            this.dgvListadoDiaTrabajo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dgvListadoDiaTrabajo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoDiaTrabajo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListadoDiaTrabajo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoDiaTrabajo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListadoDiaTrabajo.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoDiaTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListadoDiaTrabajo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoDiaTrabajo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoDiaTrabajo.Location = new System.Drawing.Point(4, 3);
            this.dgvListadoDiaTrabajo.Name = "dgvListadoDiaTrabajo";
            this.dgvListadoDiaTrabajo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoDiaTrabajo.Size = new System.Drawing.Size(902, 255);
            this.dgvListadoDiaTrabajo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(105, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Total horas laboradas:";
            // 
            // txbTotalHoras
            // 
            this.txbTotalHoras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotalHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalHoras.Location = new System.Drawing.Point(299, 270);
            this.txbTotalHoras.Name = "txbTotalHoras";
            this.txbTotalHoras.Size = new System.Drawing.Size(127, 26);
            this.txbTotalHoras.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Maroon;
            this.label6.Location = new System.Drawing.Point(467, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 20);
            this.label6.TabIndex = 48;
            this.label6.Text = "Total Minutos laborados:";
            // 
            // txbTotalMinutos
            // 
            this.txbTotalMinutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbTotalMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalMinutos.Location = new System.Drawing.Point(679, 270);
            this.txbTotalMinutos.Name = "txbTotalMinutos";
            this.txbTotalMinutos.Size = new System.Drawing.Size(127, 26);
            this.txbTotalMinutos.TabIndex = 49;
            // 
            // tabConceptoPagos
            // 
            this.tabConceptoPagos.Controls.Add(this.btnEditarConcepto);
            this.tabConceptoPagos.Controls.Add(this.btnAgregarConcPago);
            this.tabConceptoPagos.Controls.Add(this.rtxbDetalle);
            this.tabConceptoPagos.Controls.Add(this.label9);
            this.tabConceptoPagos.Controls.Add(this.txbMonto);
            this.tabConceptoPagos.Controls.Add(this.label8);
            this.tabConceptoPagos.Controls.Add(this.label7);
            this.tabConceptoPagos.Controls.Add(this.cmbxTipoMov);
            this.tabConceptoPagos.Controls.Add(this.dtgConceptoPago);
            this.tabConceptoPagos.Location = new System.Drawing.Point(4, 25);
            this.tabConceptoPagos.Name = "tabConceptoPagos";
            this.tabConceptoPagos.Size = new System.Drawing.Size(910, 312);
            this.tabConceptoPagos.TabIndex = 2;
            this.tabConceptoPagos.Text = "Concepto Pagos";
            this.tabConceptoPagos.UseVisualStyleBackColor = true;
            // 
            // btnEditarConcepto
            // 
            this.btnEditarConcepto.BackColor = System.Drawing.Color.White;
            this.btnEditarConcepto.Image = global::Punto_de_Venta.Properties.Resources.j0432573;
            this.btnEditarConcepto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarConcepto.Location = new System.Drawing.Point(57, 249);
            this.btnEditarConcepto.Name = "btnEditarConcepto";
            this.btnEditarConcepto.Size = new System.Drawing.Size(219, 52);
            this.btnEditarConcepto.TabIndex = 17;
            this.btnEditarConcepto.Text = "Editar Concepto pago";
            this.btnEditarConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarConcepto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditarConcepto.UseVisualStyleBackColor = false;
            this.btnEditarConcepto.Visible = false;
            this.btnEditarConcepto.Click += new System.EventHandler(this.btnEditarConcepto_Click);
            // 
            // btnAgregarConcPago
            // 
            this.btnAgregarConcPago.BackColor = System.Drawing.Color.White;
            this.btnAgregarConcPago.Image = global::Punto_de_Venta.Properties.Resources.mas3;
            this.btnAgregarConcPago.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarConcPago.Location = new System.Drawing.Point(299, 249);
            this.btnAgregarConcPago.Name = "btnAgregarConcPago";
            this.btnAgregarConcPago.Size = new System.Drawing.Size(248, 52);
            this.btnAgregarConcPago.TabIndex = 16;
            this.btnAgregarConcPago.Text = "Agregar concepto de Pago";
            this.btnAgregarConcPago.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarConcPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregarConcPago.UseVisualStyleBackColor = false;
            this.btnAgregarConcPago.Click += new System.EventHandler(this.btnAgregarConcPago_Click);
            // 
            // rtxbDetalle
            // 
            this.rtxbDetalle.Location = new System.Drawing.Point(566, 200);
            this.rtxbDetalle.Name = "rtxbDetalle";
            this.rtxbDetalle.Size = new System.Drawing.Size(328, 92);
            this.rtxbDetalle.TabIndex = 13;
            this.rtxbDetalle.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(498, 203);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Detalle:";
            // 
            // txbMonto
            // 
            this.txbMonto.Location = new System.Drawing.Point(376, 202);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(100, 22);
            this.txbMonto.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 10;
            this.label8.Text = "Tipo Movimiento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Monto:";
            // 
            // cmbxTipoMov
            // 
            this.cmbxTipoMov.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTipoMov.FormattingEnabled = true;
            this.cmbxTipoMov.Location = new System.Drawing.Point(148, 200);
            this.cmbxTipoMov.Name = "cmbxTipoMov";
            this.cmbxTipoMov.Size = new System.Drawing.Size(141, 24);
            this.cmbxTipoMov.TabIndex = 8;
            // 
            // dtgConceptoPago
            // 
            this.dtgConceptoPago.AllowUserToAddRows = false;
            this.dtgConceptoPago.AllowUserToDeleteRows = false;
            this.dtgConceptoPago.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dtgConceptoPago.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgConceptoPago.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgConceptoPago.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgConceptoPago.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgConceptoPago.BackgroundColor = System.Drawing.Color.White;
            this.dtgConceptoPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConceptoPago.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgConceptoPago.Location = new System.Drawing.Point(5, 3);
            this.dtgConceptoPago.Name = "dtgConceptoPago";
            this.dtgConceptoPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgConceptoPago.Size = new System.Drawing.Size(902, 175);
            this.dtgConceptoPago.TabIndex = 7;
            this.dtgConceptoPago.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgConceptoPago_CellDoubleClick);
            // 
            // tabPagosEmpleado
            // 
            this.tabPagosEmpleado.Controls.Add(this.button1);
            this.tabPagosEmpleado.Controls.Add(this.btnReporte);
            this.tabPagosEmpleado.Controls.Add(this.dtgPagosVendedor);
            this.tabPagosEmpleado.Controls.Add(this.btnRealizarPago);
            this.tabPagosEmpleado.Location = new System.Drawing.Point(4, 25);
            this.tabPagosEmpleado.Name = "tabPagosEmpleado";
            this.tabPagosEmpleado.Size = new System.Drawing.Size(910, 312);
            this.tabPagosEmpleado.TabIndex = 3;
            this.tabPagosEmpleado.Text = "Pagos Empleado";
            this.tabPagosEmpleado.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.button1.Location = new System.Drawing.Point(559, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 59);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reporte      (Hoja pequeña)";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReporte
            // 
            this.btnReporte.BackColor = System.Drawing.Color.White;
            this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.btnReporte.Location = new System.Drawing.Point(739, 236);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(166, 59);
            this.btnReporte.TabIndex = 12;
            this.btnReporte.Text = "Reporte         (Hoja grande)";
            this.btnReporte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte.UseVisualStyleBackColor = false;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // dtgPagosVendedor
            // 
            this.dtgPagosVendedor.AllowUserToAddRows = false;
            this.dtgPagosVendedor.AllowUserToDeleteRows = false;
            this.dtgPagosVendedor.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dtgPagosVendedor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgPagosVendedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgPagosVendedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgPagosVendedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPagosVendedor.BackgroundColor = System.Drawing.Color.White;
            this.dtgPagosVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPagosVendedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgPagosVendedor.Location = new System.Drawing.Point(3, 3);
            this.dtgPagosVendedor.Name = "dtgPagosVendedor";
            this.dtgPagosVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgPagosVendedor.Size = new System.Drawing.Size(902, 218);
            this.dtgPagosVendedor.TabIndex = 8;
            // 
            // btnRealizarPago
            // 
            this.btnRealizarPago.BackColor = System.Drawing.Color.White;
            this.btnRealizarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarPago.Image = global::Punto_de_Venta.Properties.Resources.efectivo;
            this.btnRealizarPago.Location = new System.Drawing.Point(3, 236);
            this.btnRealizarPago.Name = "btnRealizarPago";
            this.btnRealizarPago.Size = new System.Drawing.Size(168, 59);
            this.btnRealizarPago.TabIndex = 4;
            this.btnRealizarPago.Text = "Realizar pago a este empleado";
            this.btnRealizarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarPago.UseVisualStyleBackColor = false;
            this.btnRealizarPago.Click += new System.EventHandler(this.btnRealizarPago_Click);
            // 
            // tabManualmente
            // 
            this.tabManualmente.Controls.Add(this.btnEliminar);
            this.tabManualmente.Controls.Add(this.btnReporte2);
            this.tabManualmente.Controls.Add(this.btnPagar);
            this.tabManualmente.Controls.Add(this.label21);
            this.tabManualmente.Controls.Add(this.txbSalarioTotal);
            this.tabManualmente.Controls.Add(this.label20);
            this.tabManualmente.Controls.Add(this.txbGanaHora);
            this.tabManualmente.Controls.Add(this.dgvListaDiasTrabajados);
            this.tabManualmente.Controls.Add(this.label19);
            this.tabManualmente.Controls.Add(this.label18);
            this.tabManualmente.Controls.Add(this.txbTotalHor);
            this.tabManualmente.Controls.Add(this.txbTotalMin);
            this.tabManualmente.Controls.Add(this.splitContainer1);
            this.tabManualmente.Location = new System.Drawing.Point(4, 25);
            this.tabManualmente.Name = "tabManualmente";
            this.tabManualmente.Size = new System.Drawing.Size(910, 312);
            this.tabManualmente.TabIndex = 4;
            this.tabManualmente.Text = "Ingresar Horas Manualmente";
            this.tabManualmente.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnEliminar.Location = new System.Drawing.Point(29, 173);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 42);
            this.btnEliminar.TabIndex = 168;
            this.btnEliminar.Text = "Eliminar dia";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReporte2
            // 
            this.btnReporte2.BackColor = System.Drawing.Color.White;
            this.btnReporte2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporte2.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.btnReporte2.Location = new System.Drawing.Point(727, 121);
            this.btnReporte2.Name = "btnReporte2";
            this.btnReporte2.Size = new System.Drawing.Size(154, 59);
            this.btnReporte2.TabIndex = 167;
            this.btnReporte2.Text = "Reporte";
            this.btnReporte2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporte2.UseVisualStyleBackColor = false;
            this.btnReporte2.Visible = false;
            this.btnReporte2.Click += new System.EventHandler(this.btnReporte2_Click);
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.Color.White;
            this.btnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagar.Image = global::Punto_de_Venta.Properties.Resources.efectivo;
            this.btnPagar.Location = new System.Drawing.Point(727, 186);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(154, 59);
            this.btnPagar.TabIndex = 166;
            this.btnPagar.Text = "Realizar pago a este empleado";
            this.btnPagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Visible = false;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.Red;
            this.label21.Location = new System.Drawing.Point(622, 289);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(110, 16);
            this.label21.TabIndex = 165;
            this.label21.Text = "Salario Total =";
            // 
            // txbSalarioTotal
            // 
            this.txbSalarioTotal.ForeColor = System.Drawing.Color.Red;
            this.txbSalarioTotal.Location = new System.Drawing.Point(738, 286);
            this.txbSalarioTotal.Name = "txbSalarioTotal";
            this.txbSalarioTotal.ReadOnly = true;
            this.txbSalarioTotal.Size = new System.Drawing.Size(93, 22);
            this.txbSalarioTotal.TabIndex = 164;
            this.txbSalarioTotal.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Blue;
            this.label20.Location = new System.Drawing.Point(438, 289);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(95, 16);
            this.label20.TabIndex = 163;
            this.label20.Text = "Gana x hora:";
            // 
            // txbGanaHora
            // 
            this.txbGanaHora.ForeColor = System.Drawing.Color.Blue;
            this.txbGanaHora.Location = new System.Drawing.Point(539, 286);
            this.txbGanaHora.Name = "txbGanaHora";
            this.txbGanaHora.ReadOnly = true;
            this.txbGanaHora.Size = new System.Drawing.Size(69, 22);
            this.txbGanaHora.TabIndex = 162;
            // 
            // dgvListaDiasTrabajados
            // 
            this.dgvListaDiasTrabajados.AllowUserToAddRows = false;
            this.dgvListaDiasTrabajados.AllowUserToDeleteRows = false;
            this.dgvListaDiasTrabajados.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkTurquoise;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaDiasTrabajados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListaDiasTrabajados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListaDiasTrabajados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaDiasTrabajados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaDiasTrabajados.BackgroundColor = System.Drawing.Color.White;
            this.dgvListaDiasTrabajados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListaDiasTrabajados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDiasTrabajados.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaDiasTrabajados.Location = new System.Drawing.Point(150, 95);
            this.dgvListaDiasTrabajados.Name = "dgvListaDiasTrabajados";
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvListaDiasTrabajados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListaDiasTrabajados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaDiasTrabajados.Size = new System.Drawing.Size(564, 185);
            this.dgvListaDiasTrabajados.TabIndex = 161;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Fuchsia;
            this.label19.Location = new System.Drawing.Point(220, 289);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(105, 16);
            this.label19.TabIndex = 160;
            this.label19.Text = "Total Minutos:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(33, 289);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 16);
            this.label18.TabIndex = 159;
            this.label18.Text = "Total horas:";
            // 
            // txbTotalHor
            // 
            this.txbTotalHor.Location = new System.Drawing.Point(130, 286);
            this.txbTotalHor.Name = "txbTotalHor";
            this.txbTotalHor.ReadOnly = true;
            this.txbTotalHor.Size = new System.Drawing.Size(69, 22);
            this.txbTotalHor.TabIndex = 158;
            this.txbTotalHor.Text = "0";
            // 
            // txbTotalMin
            // 
            this.txbTotalMin.ForeColor = System.Drawing.Color.Fuchsia;
            this.txbTotalMin.Location = new System.Drawing.Point(332, 286);
            this.txbTotalMin.Name = "txbTotalMin";
            this.txbTotalMin.ReadOnly = true;
            this.txbTotalMin.Size = new System.Drawing.Size(81, 22);
            this.txbTotalMin.TabIndex = 157;
            this.txbTotalMin.Text = "0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(36, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dtpFechaEntrada);
            this.splitContainer1.Panel1.Controls.Add(this.label16);
            this.splitContainer1.Panel1.Controls.Add(this.label12);
            this.splitContainer1.Panel1.Controls.Add(this.label13);
            this.splitContainer1.Panel1.Controls.Add(this.txbHoraEntrada);
            this.splitContainer1.Panel1.Controls.Add(this.txbMinEntrada);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dtpFechaSalida);
            this.splitContainer1.Panel2.Controls.Add(this.label17);
            this.splitContainer1.Panel2.Controls.Add(this.label15);
            this.splitContainer1.Panel2.Controls.Add(this.txbMinSalida);
            this.splitContainer1.Panel2.Controls.Add(this.label14);
            this.splitContainer1.Panel2.Controls.Add(this.txbHoraSalida);
            this.splitContainer1.Size = new System.Drawing.Size(829, 84);
            this.splitContainer1.SplitterDistance = 414;
            this.splitContainer1.TabIndex = 156;
            // 
            // dtpFechaEntrada
            // 
            this.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEntrada.Location = new System.Drawing.Point(46, 45);
            this.dtpFechaEntrada.Name = "dtpFechaEntrada";
            this.dtpFechaEntrada.Size = new System.Drawing.Size(111, 22);
            this.dtpFechaEntrada.TabIndex = 9;
            this.dtpFechaEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaEntrada_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(161, -2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 37);
            this.label16.TabIndex = 8;
            this.label16.Text = "Entrada";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(182, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Hora:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(301, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "Minutos:";
            // 
            // txbHoraEntrada
            // 
            this.txbHoraEntrada.Location = new System.Drawing.Point(234, 45);
            this.txbHoraEntrada.Name = "txbHoraEntrada";
            this.txbHoraEntrada.Size = new System.Drawing.Size(36, 22);
            this.txbHoraEntrada.TabIndex = 4;
            this.txbHoraEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHoraEntrada_KeyPress);
            // 
            // txbMinEntrada
            // 
            this.txbMinEntrada.Location = new System.Drawing.Point(372, 45);
            this.txbMinEntrada.Name = "txbMinEntrada";
            this.txbMinEntrada.Size = new System.Drawing.Size(35, 22);
            this.txbMinEntrada.TabIndex = 5;
            this.txbMinEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMinEntrada_KeyPress);
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaSalida.Location = new System.Drawing.Point(17, 45);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(111, 22);
            this.dtpFechaSalida.TabIndex = 10;
            this.dtpFechaSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtpFechaSalida_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(178, -2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 37);
            this.label17.TabIndex = 9;
            this.label17.Text = "Salida";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(159, 48);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Hora:";
            // 
            // txbMinSalida
            // 
            this.txbMinSalida.Location = new System.Drawing.Point(340, 45);
            this.txbMinSalida.Name = "txbMinSalida";
            this.txbMinSalida.Size = new System.Drawing.Size(40, 22);
            this.txbMinSalida.TabIndex = 7;
            this.txbMinSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbMinSalida_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(269, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 3;
            this.label14.Text = "Minutos:";
            // 
            // txbHoraSalida
            // 
            this.txbHoraSalida.Location = new System.Drawing.Point(219, 45);
            this.txbHoraSalida.Name = "txbHoraSalida";
            this.txbHoraSalida.Size = new System.Drawing.Size(36, 22);
            this.txbHoraSalida.TabIndex = 6;
            this.txbHoraSalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbHoraSalida_KeyPress);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnSalir.Location = new System.Drawing.Point(804, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 51);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_MantenimientoHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 422);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_MantenimientoHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de horas laboradas";
            this.Load += new System.EventHandler(this.Frm_MantenimientoHoras_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabDetalleEmpleado.ResumeLayout(false);
            this.tabDetalleEmpleado.PerformLayout();
            this.tabDiaTrabajo.ResumeLayout(false);
            this.tabDiaTrabajo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoDiaTrabajo)).EndInit();
            this.tabConceptoPagos.ResumeLayout(false);
            this.tabConceptoPagos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConceptoPago)).EndInit();
            this.tabPagosEmpleado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPagosVendedor)).EndInit();
            this.tabManualmente.ResumeLayout(false);
            this.tabManualmente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDiasTrabajados)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDetalleEmpleado;
        private System.Windows.Forms.TabPage tabDiaTrabajo;
        private System.Windows.Forms.TabPage tabConceptoPagos;
        private System.Windows.Forms.TabPage tabPagosEmpleado;
        private System.Windows.Forms.TextBox txbGanaXhora;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbCodigoBarra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbApellido2;
        private System.Windows.Forms.TextBox txbApellido1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListadoDiaTrabajo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRealizarPago;
        private System.Windows.Forms.DataGridView dtgConceptoPago;
        private System.Windows.Forms.Button btnAgregarConcPago;
        private System.Windows.Forms.RichTextBox rtxbDetalle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbxTipoMov;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.DataGridView dtgPagosVendedor;
        private System.Windows.Forms.TextBox txbTotalMinutos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbTotalHoras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEditarConcepto;
        private System.Windows.Forms.TabPage tabManualmente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReporte2;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txbSalarioTotal;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txbGanaHora;
        private System.Windows.Forms.DataGridView dgvListaDiasTrabajados;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txbTotalHor;
        private System.Windows.Forms.TextBox txbTotalMin;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbHoraEntrada;
        private System.Windows.Forms.TextBox txbMinEntrada;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txbMinSalida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbHoraSalida;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnReporte;
    }
}