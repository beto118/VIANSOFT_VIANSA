namespace Punto_de_Venta.Pantallas
{
    partial class Frm_Factura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Factura));
            this.lblNumFact = new System.Windows.Forms.Label();
            this.lblxx = new System.Windows.Forms.Label();
            this.txbId_Factura = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEnviar = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txbConsultarCliente = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.txbCaja = new System.Windows.Forms.TextBox();
            this.txbCodVendedor = new System.Windows.Forms.TextBox();
            this.txbVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblNumCaja = new System.Windows.Forms.Label();
            this.lblCodVendedor = new System.Windows.Forms.Label();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.lbl_Subtotal = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txbIV = new System.Windows.Forms.TextBox();
            this.lbl_Iv = new System.Windows.Forms.Label();
            this.txbSubTotal = new System.Windows.Forms.TextBox();
            this.txbTotalFact = new System.Windows.Forms.TextBox();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lbl54 = new System.Windows.Forms.Label();
            this.lvItems = new System.Windows.Forms.ListView();
            this.CodProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DesPorcent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DescTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalLinea = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumDesc = new System.Windows.Forms.NumericUpDown();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnVerDescuento = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.btnFacturaCredito = new System.Windows.Forms.Button();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnOrdenCompra = new System.Windows.Forms.Button();
            this.btnFactuararTarj = new System.Windows.Forms.Button();
            this.btnFacturarEfec = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPagarMixto = new System.Windows.Forms.Button();
            this.txbUtilidad = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDesc)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNumFact
            // 
            this.lblNumFact.AutoSize = true;
            this.lblNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFact.Location = new System.Drawing.Point(849, 10);
            this.lblNumFact.Name = "lblNumFact";
            this.lblNumFact.Size = new System.Drawing.Size(103, 24);
            this.lblNumFact.TabIndex = 1;
            this.lblNumFact.Text = "Factura # ";
            // 
            // lblxx
            // 
            this.lblxx.AutoSize = true;
            this.lblxx.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblxx.Location = new System.Drawing.Point(13, 12);
            this.lblxx.Name = "lblxx";
            this.lblxx.Size = new System.Drawing.Size(75, 24);
            this.lblxx.TabIndex = 2;
            this.lblxx.Text = "Fecha:";
            // 
            // txbId_Factura
            // 
            this.txbId_Factura.Enabled = false;
            this.txbId_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId_Factura.Location = new System.Drawing.Point(958, 7);
            this.txbId_Factura.Name = "txbId_Factura";
            this.txbId_Factura.Size = new System.Drawing.Size(141, 29);
            this.txbId_Factura.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkEnviar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnConsultarCliente);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txbConsultarCliente);
            this.panel1.Controls.Add(this.txbDireccion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txbTelefono);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txbCodigoCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbCliente);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Location = new System.Drawing.Point(12, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1090, 173);
            this.panel1.TabIndex = 6;
            // 
            // chkEnviar
            // 
            this.chkEnviar.AutoSize = true;
            this.chkEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkEnviar.Location = new System.Drawing.Point(977, 125);
            this.chkEnviar.Name = "chkEnviar";
            this.chkEnviar.Size = new System.Drawing.Size(88, 28);
            this.chkEnviar.TabIndex = 23;
            this.chkEnviar.Text = "Enviar";
            this.chkEnviar.UseVisualStyleBackColor = true;
            this.chkEnviar.CheckedChanged += new System.EventHandler(this.chkEnviar_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkGreen;
            this.label7.Location = new System.Drawing.Point(9, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 24);
            this.label7.TabIndex = 28;
            this.label7.Text = "Por cedula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkGreen;
            this.label6.Location = new System.Drawing.Point(441, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 27;
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackColor = System.Drawing.Color.White;
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnConsultarCliente.Image = global::Punto_de_Venta.Properties.Resources.lupa;
            this.btnConsultarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarCliente.Location = new System.Drawing.Point(305, 125);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(156, 38);
            this.btnConsultarCliente.TabIndex = 25;
            this.btnConsultarCliente.Text = "Consultar Cliente";
            this.btnConsultarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkGreen;
            this.label5.Location = new System.Drawing.Point(5, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Consultar Cliente:";
            // 
            // txbConsultarCliente
            // 
            this.txbConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbConsultarCliente.ForeColor = System.Drawing.Color.DarkGreen;
            this.txbConsultarCliente.Location = new System.Drawing.Point(132, 129);
            this.txbConsultarCliente.Name = "txbConsultarCliente";
            this.txbConsultarCliente.Size = new System.Drawing.Size(160, 29);
            this.txbConsultarCliente.TabIndex = 23;
            this.txbConsultarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbConsultarCliente_KeyPress);
            // 
            // txbDireccion
            // 
            this.txbDireccion.ForeColor = System.Drawing.Color.Blue;
            this.txbDireccion.Location = new System.Drawing.Point(571, 58);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(494, 61);
            this.txbDireccion.TabIndex = 22;
            this.txbDireccion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(455, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Direccion:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.ForeColor = System.Drawing.Color.Blue;
            this.txbTelefono.Location = new System.Drawing.Point(110, 58);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(292, 29);
            this.txbTelefono.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 24);
            this.label3.TabIndex = 19;
            this.label3.Text = "Telefono:";
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Image = global::Punto_de_Venta.Properties.Resources.adelante2;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(911, 6);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(156, 36);
            this.btnBuscarCliente.TabIndex = 18;
            this.btnBuscarCliente.Text = "Lista de Clientes";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoCliente.ForeColor = System.Drawing.Color.Blue;
            this.txbCodigoCliente.Location = new System.Drawing.Point(814, 10);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(69, 29);
            this.txbCodigoCliente.TabIndex = 17;
            this.txbCodigoCliente.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(725, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "Codigo:";
            // 
            // txbCliente
            // 
            this.txbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.ForeColor = System.Drawing.Color.Blue;
            this.txbCliente.Location = new System.Drawing.Point(111, 13);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txbCliente.Size = new System.Drawing.Size(508, 29);
            this.txbCliente.TabIndex = 7;
            this.txbCliente.Text = "CLIENTE";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.ForeColor = System.Drawing.Color.Blue;
            this.lblCliente.Location = new System.Drawing.Point(23, 18);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(81, 24);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // txbCaja
            // 
            this.txbCaja.BackColor = System.Drawing.Color.White;
            this.txbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCaja.Location = new System.Drawing.Point(597, 9);
            this.txbCaja.Name = "txbCaja";
            this.txbCaja.ReadOnly = true;
            this.txbCaja.Size = new System.Drawing.Size(69, 29);
            this.txbCaja.TabIndex = 15;
            this.txbCaja.Visible = false;
            // 
            // txbCodVendedor
            // 
            this.txbCodVendedor.BackColor = System.Drawing.Color.White;
            this.txbCodVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodVendedor.Location = new System.Drawing.Point(454, -8);
            this.txbCodVendedor.Name = "txbCodVendedor";
            this.txbCodVendedor.ReadOnly = true;
            this.txbCodVendedor.Size = new System.Drawing.Size(69, 26);
            this.txbCodVendedor.TabIndex = 9;
            this.txbCodVendedor.Visible = false;
            // 
            // txbVendedor
            // 
            this.txbVendedor.BackColor = System.Drawing.Color.White;
            this.txbVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbVendedor.Location = new System.Drawing.Point(618, -8);
            this.txbVendedor.Name = "txbVendedor";
            this.txbVendedor.ReadOnly = true;
            this.txbVendedor.Size = new System.Drawing.Size(319, 26);
            this.txbVendedor.TabIndex = 8;
            this.txbVendedor.Visible = false;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendedor.Location = new System.Drawing.Point(529, -8);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(83, 20);
            this.lblVendedor.TabIndex = 6;
            this.lblVendedor.Text = "Vendedor:";
            this.lblVendedor.Visible = false;
            // 
            // lblNumCaja
            // 
            this.lblNumCaja.AutoSize = true;
            this.lblNumCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumCaja.Location = new System.Drawing.Point(523, 14);
            this.lblNumCaja.Name = "lblNumCaja";
            this.lblNumCaja.Size = new System.Drawing.Size(68, 24);
            this.lblNumCaja.TabIndex = 0;
            this.lblNumCaja.Text = "Caja #";
            this.lblNumCaja.Visible = false;
            // 
            // lblCodVendedor
            // 
            this.lblCodVendedor.AutoSize = true;
            this.lblCodVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodVendedor.Location = new System.Drawing.Point(385, -8);
            this.lblCodVendedor.Name = "lblCodVendedor";
            this.lblCodVendedor.Size = new System.Drawing.Size(63, 20);
            this.lblCodVendedor.TabIndex = 2;
            this.lblCodVendedor.Text = "Codigo:";
            this.lblCodVendedor.Visible = false;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.Location = new System.Drawing.Point(286, 42);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(52, 16);
            this.lbl_Descuento.TabIndex = 5;
            this.lbl_Descuento.Text = "Desc=";
            this.lbl_Descuento.Visible = false;
            // 
            // lbl_Subtotal
            // 
            this.lbl_Subtotal.AutoSize = true;
            this.lbl_Subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Subtotal.ForeColor = System.Drawing.Color.Black;
            this.lbl_Subtotal.Location = new System.Drawing.Point(449, 13);
            this.lbl_Subtotal.Name = "lbl_Subtotal";
            this.lbl_Subtotal.Size = new System.Drawing.Size(84, 16);
            this.lbl_Subtotal.TabIndex = 4;
            this.lbl_Subtotal.Text = "Sub-Total=";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold);
            this.lbl.ForeColor = System.Drawing.Color.Red;
            this.lbl.Location = new System.Drawing.Point(666, 8);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(149, 51);
            this.lbl.TabIndex = 3;
            this.lbl.Text = "Total=";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.Navy;
            this.lblDescuento.Location = new System.Drawing.Point(6, 8);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(165, 25);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento % :";
            // 
            // txbIV
            // 
            this.txbIV.BackColor = System.Drawing.Color.White;
            this.txbIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIV.Location = new System.Drawing.Point(539, 37);
            this.txbIV.Name = "txbIV";
            this.txbIV.ReadOnly = true;
            this.txbIV.Size = new System.Drawing.Size(110, 22);
            this.txbIV.TabIndex = 20;
            this.txbIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_Iv
            // 
            this.lbl_Iv.AutoSize = true;
            this.lbl_Iv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Iv.Location = new System.Drawing.Point(503, 40);
            this.lbl_Iv.Name = "lbl_Iv";
            this.lbl_Iv.Size = new System.Drawing.Size(30, 16);
            this.lbl_Iv.TabIndex = 19;
            this.lbl_Iv.Text = "IV=";
            // 
            // txbSubTotal
            // 
            this.txbSubTotal.BackColor = System.Drawing.Color.White;
            this.txbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubTotal.ForeColor = System.Drawing.Color.Black;
            this.txbSubTotal.Location = new System.Drawing.Point(539, 10);
            this.txbSubTotal.Name = "txbSubTotal";
            this.txbSubTotal.ReadOnly = true;
            this.txbSubTotal.Size = new System.Drawing.Size(110, 22);
            this.txbSubTotal.TabIndex = 17;
            this.txbSubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbTotalFact
            // 
            this.txbTotalFact.BackColor = System.Drawing.Color.White;
            this.txbTotalFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold);
            this.txbTotalFact.ForeColor = System.Drawing.Color.Red;
            this.txbTotalFact.Location = new System.Drawing.Point(808, 5);
            this.txbTotalFact.Name = "txbTotalFact";
            this.txbTotalFact.ReadOnly = true;
            this.txbTotalFact.Size = new System.Drawing.Size(269, 56);
            this.txbTotalFact.TabIndex = 18;
            this.txbTotalFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbDesc
            // 
            this.txbDesc.BackColor = System.Drawing.Color.White;
            this.txbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesc.Location = new System.Drawing.Point(338, 39);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.ReadOnly = true;
            this.txbDesc.Size = new System.Drawing.Size(84, 22);
            this.txbDesc.TabIndex = 16;
            this.txbDesc.Text = "0.0";
            this.txbDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbDesc.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            // 
            // lbl54
            // 
            this.lbl54.AutoSize = true;
            this.lbl54.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl54.Location = new System.Drawing.Point(244, 12);
            this.lbl54.Name = "lbl54";
            this.lbl54.Size = new System.Drawing.Size(61, 24);
            this.lbl54.TabIndex = 18;
            this.lbl54.Text = "Hora:";
            // 
            // lvItems
            // 
            this.lvItems.CheckBoxes = true;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodProd,
            this.NombreProd,
            this.CantProd,
            this.ValorUnitario,
            this.SubTotal,
            this.IV,
            this.DesPorcent,
            this.DescTotal,
            this.TotalLinea});
            this.lvItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.Location = new System.Drawing.Point(14, 223);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(1088, 284);
            this.lvItems.TabIndex = 143;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // CodProd
            // 
            this.CodProd.Text = "Codigo";
            this.CodProd.Width = 65;
            // 
            // NombreProd
            // 
            this.NombreProd.Text = "Nombre";
            this.NombreProd.Width = 270;
            // 
            // CantProd
            // 
            this.CantProd.Text = "Cantidad";
            this.CantProd.Width = 80;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.Text = "Valor Uni.";
            this.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValorUnitario.Width = 120;
            // 
            // SubTotal
            // 
            this.SubTotal.Text = "Sub Total";
            this.SubTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SubTotal.Width = 150;
            // 
            // IV
            // 
            this.IV.Text = "IV";
            this.IV.Width = 100;
            // 
            // DesPorcent
            // 
            this.DesPorcent.Text = "Desc %";
            this.DesPorcent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DesPorcent.Width = 80;
            // 
            // DescTotal
            // 
            this.DescTotal.Text = "Desc Total";
            this.DescTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DescTotal.Width = 90;
            // 
            // TotalLinea
            // 
            this.TotalLinea.Text = "Total";
            this.TotalLinea.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalLinea.Width = 120;
            // 
            // NumDesc
            // 
            this.NumDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDesc.ForeColor = System.Drawing.Color.Navy;
            this.NumDesc.Location = new System.Drawing.Point(177, 4);
            this.NumDesc.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumDesc.Name = "NumDesc";
            this.NumDesc.Size = new System.Drawing.Size(57, 31);
            this.NumDesc.TabIndex = 144;
            this.NumDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumDesc.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.txbUtilidad);
            this.panel4.Controls.Add(this.btnVerDescuento);
            this.panel4.Controls.Add(this.NumDesc);
            this.panel4.Controls.Add(this.lblDescuento);
            this.panel4.Controls.Add(this.txbDesc);
            this.panel4.Controls.Add(this.txbTotalFact);
            this.panel4.Controls.Add(this.lbl_Subtotal);
            this.panel4.Controls.Add(this.lbl);
            this.panel4.Controls.Add(this.txbSubTotal);
            this.panel4.Controls.Add(this.lbl_Descuento);
            this.panel4.Controls.Add(this.txbIV);
            this.panel4.Controls.Add(this.lbl_Iv);
            this.panel4.Location = new System.Drawing.Point(14, 524);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1088, 71);
            this.panel4.TabIndex = 145;
            // 
            // btnVerDescuento
            // 
            this.btnVerDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDescuento.Location = new System.Drawing.Point(5, 34);
            this.btnVerDescuento.Name = "btnVerDescuento";
            this.btnVerDescuento.Size = new System.Drawing.Size(76, 31);
            this.btnVerDescuento.TabIndex = 145;
            this.btnVerDescuento.Text = "Aplicar";
            this.btnVerDescuento.UseVisualStyleBackColor = true;
            this.btnVerDescuento.Click += new System.EventHandler(this.btnVerDescuento_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 659);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 16);
            this.label1.TabIndex = 146;
            this.label1.Text = "F1: Facturar Contado        F2: Facturar Credito";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(94, 12);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(126, 26);
            this.lblFecha.TabIndex = 150;
            this.lblFecha.Text = "dd/mm/aaaa";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(311, 12);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(96, 26);
            this.lblHora.TabIndex = 151;
            this.lblHora.Text = "00:00:00 ";
            // 
            // btnFacturaCredito
            // 
            this.btnFacturaCredito.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturaCredito.BackColor = System.Drawing.Color.White;
            this.btnFacturaCredito.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturaCredito.Image = global::Punto_de_Venta.Properties.Resources.j0432573;
            this.btnFacturaCredito.Location = new System.Drawing.Point(965, 603);
            this.btnFacturaCredito.Name = "btnFacturaCredito";
            this.btnFacturaCredito.Size = new System.Drawing.Size(133, 47);
            this.btnFacturaCredito.TabIndex = 152;
            this.btnFacturaCredito.Text = "Factura Credito";
            this.btnFacturaCredito.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturaCredito.UseVisualStyleBackColor = false;
            this.btnFacturaCredito.Click += new System.EventHandler(this.btnFacturaCredito_Click);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.White;
            this.btnAtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Image = global::Punto_de_Venta.Properties.Resources.atras1;
            this.btnAtras.Location = new System.Drawing.Point(10, 603);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(130, 47);
            this.btnAtras.TabIndex = 149;
            this.btnAtras.Text = "Atras";
            this.btnAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnOrdenCompra
            // 
            this.btnOrdenCompra.BackColor = System.Drawing.Color.White;
            this.btnOrdenCompra.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenCompra.Image = global::Punto_de_Venta.Properties.Resources.cotizaciones;
            this.btnOrdenCompra.Location = new System.Drawing.Point(282, 603);
            this.btnOrdenCompra.Name = "btnOrdenCompra";
            this.btnOrdenCompra.Size = new System.Drawing.Size(120, 47);
            this.btnOrdenCompra.TabIndex = 148;
            this.btnOrdenCompra.Text = "Orden Compra";
            this.btnOrdenCompra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrdenCompra.UseVisualStyleBackColor = false;
            this.btnOrdenCompra.Click += new System.EventHandler(this.btnMixto_Click);
            // 
            // btnFactuararTarj
            // 
            this.btnFactuararTarj.BackColor = System.Drawing.Color.White;
            this.btnFactuararTarj.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFactuararTarj.Image = ((System.Drawing.Image)(resources.GetObject("btnFactuararTarj.Image")));
            this.btnFactuararTarj.Location = new System.Drawing.Point(585, 603);
            this.btnFactuararTarj.Name = "btnFactuararTarj";
            this.btnFactuararTarj.Size = new System.Drawing.Size(120, 47);
            this.btnFactuararTarj.TabIndex = 147;
            this.btnFactuararTarj.Text = "Facturar Tarjeta";
            this.btnFactuararTarj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFactuararTarj.UseVisualStyleBackColor = false;
            this.btnFactuararTarj.Click += new System.EventHandler(this.btnFactuararTarj_Click);
            // 
            // btnFacturarEfec
            // 
            this.btnFacturarEfec.BackColor = System.Drawing.Color.White;
            this.btnFacturarEfec.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturarEfec.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturarEfec.Image")));
            this.btnFacturarEfec.Location = new System.Drawing.Point(711, 603);
            this.btnFacturarEfec.Name = "btnFacturarEfec";
            this.btnFacturarEfec.Size = new System.Drawing.Size(120, 47);
            this.btnFacturarEfec.TabIndex = 146;
            this.btnFacturarEfec.Text = "Facturar Contado";
            this.btnFacturarEfec.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFacturarEfec.UseVisualStyleBackColor = false;
            this.btnFacturarEfec.Click += new System.EventHandler(this.btnFacturarEfec_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.cancelar;
            this.btnCancelar.Location = new System.Drawing.Point(146, 603);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 47);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar Factura";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnPagarMixto
            // 
            this.btnPagarMixto.BackColor = System.Drawing.Color.White;
            this.btnPagarMixto.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPagarMixto.Image = global::Punto_de_Venta.Properties.Resources.cobranzas;
            this.btnPagarMixto.Location = new System.Drawing.Point(437, 603);
            this.btnPagarMixto.Name = "btnPagarMixto";
            this.btnPagarMixto.Size = new System.Drawing.Size(137, 47);
            this.btnPagarMixto.TabIndex = 153;
            this.btnPagarMixto.Text = "Facturar Mixto";
            this.btnPagarMixto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPagarMixto.UseVisualStyleBackColor = false;
            this.btnPagarMixto.Click += new System.EventHandler(this.btnPagarMixto_Click);
            // 
            // txbUtilidad
            // 
            this.txbUtilidad.BackColor = System.Drawing.Color.White;
            this.txbUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUtilidad.Location = new System.Drawing.Point(338, 10);
            this.txbUtilidad.Name = "txbUtilidad";
            this.txbUtilidad.ReadOnly = true;
            this.txbUtilidad.Size = new System.Drawing.Size(84, 22);
            this.txbUtilidad.TabIndex = 146;
            this.txbUtilidad.Text = "0.0";
            this.txbUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbUtilidad.Visible = false;
            // 
            // Frm_Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 679);
            this.ControlBox = false;
            this.Controls.Add(this.btnPagarMixto);
            this.Controls.Add(this.btnFacturaCredito);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.txbCaja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNumCaja);
            this.Controls.Add(this.txbCodVendedor);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.txbVendedor);
            this.Controls.Add(this.btnOrdenCompra);
            this.Controls.Add(this.btnFactuararTarj);
            this.Controls.Add(this.lblVendedor);
            this.Controls.Add(this.btnFacturarEfec);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.lblCodVendedor);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.lbl54);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbId_Factura);
            this.Controls.Add(this.lblNumFact);
            this.Controls.Add(this.lblxx);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Factura";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Frm_Factura_FormClosed);
            this.Load += new System.EventHandler(this.Factura_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_Factura_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDesc)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumFact;
        private System.Windows.Forms.Label lblxx;
        private System.Windows.Forms.TextBox txbId_Factura;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Label lbl_Subtotal;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblCodVendedor;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblNumCaja;
        private System.Windows.Forms.TextBox txbCaja;
        private System.Windows.Forms.TextBox txbCodVendedor;
        private System.Windows.Forms.TextBox txbVendedor;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txbSubTotal;
        private System.Windows.Forms.TextBox txbTotalFact;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lbl54;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader CodProd;
        private System.Windows.Forms.ColumnHeader NombreProd;
        private System.Windows.Forms.ColumnHeader CantProd;
        private System.Windows.Forms.ColumnHeader ValorUnitario;
        private System.Windows.Forms.ColumnHeader SubTotal;
        private System.Windows.Forms.ColumnHeader IV;
        private System.Windows.Forms.NumericUpDown NumDesc;
        private System.Windows.Forms.TextBox txbIV;
        private System.Windows.Forms.Label lbl_Iv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFactuararTarj;
        private System.Windows.Forms.Button btnFacturarEfec;
        private System.Windows.Forms.Button btnOrdenCompra;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnVerDescuento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFacturaCredito;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox txbDireccion;
        private System.Windows.Forms.CheckBox chkEnviar;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbConsultarCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader DesPorcent;
        private System.Windows.Forms.Button btnPagarMixto;
        private System.Windows.Forms.ColumnHeader DescTotal;
        private System.Windows.Forms.ColumnHeader TotalLinea;
        private System.Windows.Forms.TextBox txbUtilidad;
    }
}