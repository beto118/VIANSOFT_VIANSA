namespace Punto_de_Venta.Pantallas.Credito
{
    partial class Frm_AgregarAbono
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSaldoNuevo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbAbono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbSaldoAnterior = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumCliente = new System.Windows.Forms.TextBox();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.txbFactNumero = new System.Windows.Forms.TextBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txbFechaVenc = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.btnImprimirResibo = new System.Windows.Forms.Button();
            this.btnEliminarPago = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(12, 502);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(802, 72);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.recibo_icon;
            this.btnGuardar.Location = new System.Drawing.Point(295, 13);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(213, 54);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Realizar Recibo";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(662, 13);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 54);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 85);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 20);
            this.label5.TabIndex = 61;
            this.label5.Text = "Detalle";
            // 
            // txbDetalle
            // 
            this.txbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDetalle.Location = new System.Drawing.Point(444, 82);
            this.txbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txbDetalle.Multiline = true;
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(323, 84);
            this.txbDetalle.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(377, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 59;
            this.label4.Text = "Fecha";
            // 
            // dpFecha
            // 
            this.dpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.Location = new System.Drawing.Point(444, 43);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(145, 26);
            this.dpFecha.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 56;
            this.label3.Text = "Saldo Actual:";
            // 
            // txbSaldoNuevo
            // 
            this.txbSaldoNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSaldoNuevo.Enabled = false;
            this.txbSaldoNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaldoNuevo.Location = new System.Drawing.Point(156, 113);
            this.txbSaldoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaldoNuevo.Name = "txbSaldoNuevo";
            this.txbSaldoNuevo.ReadOnly = true;
            this.txbSaldoNuevo.Size = new System.Drawing.Size(184, 26);
            this.txbSaldoNuevo.TabIndex = 57;
            this.txbSaldoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(82, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 54;
            this.label6.Text = "Abono:";
            // 
            // txbAbono
            // 
            this.txbAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAbono.Location = new System.Drawing.Point(156, 79);
            this.txbAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txbAbono.Name = "txbAbono";
            this.txbAbono.Size = new System.Drawing.Size(184, 26);
            this.txbAbono.TabIndex = 55;
            this.txbAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbAbono.TextChanged += new System.EventHandler(this.txbAbono_TextChanged);
            this.txbAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAbono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 46);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 52;
            this.label7.Text = "Saldo Anterior:";
            // 
            // txbSaldoAnterior
            // 
            this.txbSaldoAnterior.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSaldoAnterior.Enabled = false;
            this.txbSaldoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaldoAnterior.Location = new System.Drawing.Point(156, 43);
            this.txbSaldoAnterior.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaldoAnterior.Name = "txbSaldoAnterior";
            this.txbSaldoAnterior.ReadOnly = true;
            this.txbSaldoAnterior.Size = new System.Drawing.Size(184, 26);
            this.txbSaldoAnterior.TabIndex = 53;
            this.txbSaldoAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Factura #";
            // 
            // txbNumCliente
            // 
            this.txbNumCliente.BackColor = System.Drawing.Color.White;
            this.txbNumCliente.Enabled = false;
            this.txbNumCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumCliente.Location = new System.Drawing.Point(157, 64);
            this.txbNumCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txbNumCliente.Name = "txbNumCliente";
            this.txbNumCliente.ReadOnly = true;
            this.txbNumCliente.Size = new System.Drawing.Size(74, 26);
            this.txbNumCliente.TabIndex = 64;
            this.txbNumCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.BackColor = System.Drawing.Color.White;
            this.txbNombreCliente.Enabled = false;
            this.txbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreCliente.Location = new System.Drawing.Point(389, 64);
            this.txbNombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.ReadOnly = true;
            this.txbNombreCliente.Size = new System.Drawing.Size(359, 26);
            this.txbNombreCliente.TabIndex = 65;
            this.txbNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbFactNumero
            // 
            this.txbFactNumero.BackColor = System.Drawing.Color.White;
            this.txbFactNumero.Enabled = false;
            this.txbFactNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFactNumero.Location = new System.Drawing.Point(112, 28);
            this.txbFactNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txbFactNumero.Name = "txbFactNumero";
            this.txbFactNumero.ReadOnly = true;
            this.txbFactNumero.Size = new System.Drawing.Size(91, 26);
            this.txbFactNumero.TabIndex = 66;
            this.txbFactNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbFecha
            // 
            this.txbFecha.BackColor = System.Drawing.Color.White;
            this.txbFecha.Enabled = false;
            this.txbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFecha.Location = new System.Drawing.Point(348, 27);
            this.txbFecha.Margin = new System.Windows.Forms.Padding(4);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.ReadOnly = true;
            this.txbFecha.Size = new System.Drawing.Size(121, 26);
            this.txbFecha.TabIndex = 68;
            this.txbFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(210, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(131, 20);
            this.label9.TabIndex = 67;
            this.label9.Text = "Fecha Factura:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txbSaldoAnterior);
            this.groupBox2.Controls.Add(this.txbAbono);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txbSaldoNuevo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dpFecha);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txbDetalle);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(8, 209);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(774, 173);
            this.groupBox2.TabIndex = 69;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Abono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(254, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(351, 64);
            this.label10.TabIndex = 70;
            this.label10.Text = "Abonos a Facturas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txbSaldo);
            this.groupBox3.Controls.Add(this.txbEstado);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txbFechaVenc);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.txbFecha);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txbNumCliente);
            this.groupBox3.Controls.Add(this.txbFactNumero);
            this.groupBox3.Controls.Add(this.txbNombreCliente);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox3.Location = new System.Drawing.Point(6, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(774, 136);
            this.groupBox3.TabIndex = 71;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos de la Factura";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(385, 101);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(121, 20);
            this.label13.TabIndex = 73;
            this.label13.Text = "Total Factura:";
            // 
            // txbSaldo
            // 
            this.txbSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSaldo.Enabled = false;
            this.txbSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSaldo.Location = new System.Drawing.Point(514, 98);
            this.txbSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.ReadOnly = true;
            this.txbSaldo.Size = new System.Drawing.Size(184, 26);
            this.txbSaldo.TabIndex = 74;
            this.txbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbEstado
            // 
            this.txbEstado.BackColor = System.Drawing.Color.White;
            this.txbEstado.Enabled = false;
            this.txbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEstado.Location = new System.Drawing.Point(220, 101);
            this.txbEstado.Margin = new System.Windows.Forms.Padding(4);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.ReadOnly = true;
            this.txbEstado.Size = new System.Drawing.Size(121, 26);
            this.txbEstado.TabIndex = 72;
            this.txbEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(142, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 71;
            this.label12.Text = "Estado:";
            // 
            // txbFechaVenc
            // 
            this.txbFechaVenc.BackColor = System.Drawing.Color.White;
            this.txbFechaVenc.Enabled = false;
            this.txbFechaVenc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFechaVenc.Location = new System.Drawing.Point(606, 25);
            this.txbFechaVenc.Margin = new System.Windows.Forms.Padding(4);
            this.txbFechaVenc.Name = "txbFechaVenc";
            this.txbFechaVenc.ReadOnly = true;
            this.txbFechaVenc.Size = new System.Drawing.Size(120, 26);
            this.txbFechaVenc.TabIndex = 70;
            this.txbFechaVenc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(489, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 20);
            this.label11.TabIndex = 69;
            this.label11.Text = "Fecha Venc:";
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 67);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(806, 427);
            this.tabControl1.TabIndex = 72;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(798, 401);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevo Abono";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvListado);
            this.tabPage2.Controls.Add(this.btnImprimirResibo);
            this.tabPage2.Controls.Add(this.btnEliminarPago);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 401);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lista de Abonos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(4, 7);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(785, 322);
            this.dgvListado.TabIndex = 25;
            // 
            // btnImprimirResibo
            // 
            this.btnImprimirResibo.BackColor = System.Drawing.Color.White;
            this.btnImprimirResibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimirResibo.ForeColor = System.Drawing.Color.Blue;
            this.btnImprimirResibo.Image = global::Punto_de_Venta.Properties.Resources.tmu220;
            this.btnImprimirResibo.Location = new System.Drawing.Point(232, 348);
            this.btnImprimirResibo.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirResibo.Name = "btnImprimirResibo";
            this.btnImprimirResibo.Size = new System.Drawing.Size(160, 46);
            this.btnImprimirResibo.TabIndex = 28;
            this.btnImprimirResibo.Text = "Imprimir Recibo";
            this.btnImprimirResibo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnImprimirResibo.UseVisualStyleBackColor = false;
            this.btnImprimirResibo.Click += new System.EventHandler(this.btnImprimirResibo_Click);
            // 
            // btnEliminarPago
            // 
            this.btnEliminarPago.BackColor = System.Drawing.Color.White;
            this.btnEliminarPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarPago.ForeColor = System.Drawing.Color.Blue;
            this.btnEliminarPago.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnEliminarPago.Location = new System.Drawing.Point(400, 348);
            this.btnEliminarPago.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPago.Name = "btnEliminarPago";
            this.btnEliminarPago.Size = new System.Drawing.Size(160, 46);
            this.btnEliminarPago.TabIndex = 27;
            this.btnEliminarPago.Text = "Eliminar Pago";
            this.btnEliminarPago.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminarPago.UseVisualStyleBackColor = false;
            this.btnEliminarPago.Click += new System.EventHandler(this.btnEliminarPago_Click);
            // 
            // Frm_AgregarAbono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 587);
            this.ControlBox = false;
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_AgregarAbono";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AgregarAbono";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSaldoNuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbAbono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbSaldoAnterior;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNumCliente;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.TextBox txbFactNumero;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.TextBox txbFechaVenc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnEliminarPago;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.Button btnImprimirResibo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label12;
    }
}