namespace Punto_de_Venta.Pantallas.Proforma
{
    partial class Frm_RegistarProforma
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistarProforma));
            this.PanelLista = new System.Windows.Forms.Panel();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.dtgListarProductos = new System.Windows.Forms.DataGridView();
            this.txbFiltroPrincipal = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblValorUnt = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbValorUnt = new System.Windows.Forms.TextBox();
            this.txbCanti = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txbTotalProforma = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbIV = new System.Windows.Forms.TextBox();
            this.txbSubTotal = new System.Windows.Forms.TextBox();
            this.btnRegistarProducto = new System.Windows.Forms.Button();
            this.btnRealizarProforma = new System.Windows.Forms.Button();
            this.lvItems = new System.Windows.Forms.ListView();
            this.CodProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NombreProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ValorUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalProd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbGravado = new System.Windows.Forms.TextBox();
            this.txbInsNuevo = new System.Windows.Forms.TextBox();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbDirecion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txnTelefono = new System.Windows.Forms.TextBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNumProforma = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnVerDescuento = new System.Windows.Forms.Button();
            this.NumDesc = new System.Windows.Forms.NumericUpDown();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txbDesc = new System.Windows.Forms.TextBox();
            this.lbl_Descuento = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PanelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarProductos)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDesc)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelLista
            // 
            this.PanelLista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelLista.Controls.Add(this.cbxCategoria);
            this.PanelLista.Controls.Add(this.label4);
            this.PanelLista.Controls.Add(this.ckEstado);
            this.PanelLista.Controls.Add(this.dtgListarProductos);
            this.PanelLista.Controls.Add(this.txbFiltroPrincipal);
            this.PanelLista.Controls.Add(this.lblFiltro);
            this.PanelLista.Location = new System.Drawing.Point(15, 148);
            this.PanelLista.Name = "PanelLista";
            this.PanelLista.Size = new System.Drawing.Size(993, 196);
            this.PanelLista.TabIndex = 1;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategoria.ForeColor = System.Drawing.Color.Purple;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "NINGUNO",
            "FRUTAS",
            "LEGUMBRES",
            "VERDURAS",
            "VARIOS"});
            this.cbxCategoria.Location = new System.Drawing.Point(478, 4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(168, 24);
            this.cbxCategoria.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.Location = new System.Drawing.Point(392, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "Categoria:";
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Checked = true;
            this.ckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckEstado.ForeColor = System.Drawing.Color.Purple;
            this.ckEstado.Location = new System.Drawing.Point(292, 7);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(78, 20);
            this.ckEstado.TabIndex = 24;
            this.ckEstado.Text = "Activos";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // dtgListarProductos
            // 
            this.dtgListarProductos.AllowUserToAddRows = false;
            this.dtgListarProductos.AllowUserToDeleteRows = false;
            this.dtgListarProductos.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Thistle;
            this.dtgListarProductos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgListarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgListarProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgListarProductos.BackgroundColor = System.Drawing.Color.White;
            this.dtgListarProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListarProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dtgListarProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgListarProductos.DefaultCellStyle = dataGridViewCellStyle18;
            this.dtgListarProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtgListarProductos.Location = new System.Drawing.Point(10, 34);
            this.dtgListarProductos.Name = "dtgListarProductos";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.NullValue = null;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgListarProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.NullValue = null;
            this.dtgListarProductos.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dtgListarProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgListarProductos.Size = new System.Drawing.Size(966, 147);
            this.dtgListarProductos.TabIndex = 6;
            this.dtgListarProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgListarProductos_CellClick);
            // 
            // txbFiltroPrincipal
            // 
            this.txbFiltroPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltroPrincipal.ForeColor = System.Drawing.Color.Purple;
            this.txbFiltroPrincipal.Location = new System.Drawing.Point(68, 4);
            this.txbFiltroPrincipal.Name = "txbFiltroPrincipal";
            this.txbFiltroPrincipal.Size = new System.Drawing.Size(206, 22);
            this.txbFiltroPrincipal.TabIndex = 5;
            this.txbFiltroPrincipal.TextChanged += new System.EventHandler(this.txbFiltroPrincipal_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.ForeColor = System.Drawing.Color.Purple;
            this.lblFiltro.Location = new System.Drawing.Point(7, 7);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(47, 16);
            this.lblFiltro.TabIndex = 4;
            this.lblFiltro.Text = "Filtro:";
            // 
            // txbNombre
            // 
            this.txbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNombre.BackColor = System.Drawing.Color.White;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.ForeColor = System.Drawing.Color.Purple;
            this.txbNombre.Location = new System.Drawing.Point(257, 372);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.ReadOnly = true;
            this.txbNombre.Size = new System.Drawing.Size(371, 26);
            this.txbNombre.TabIndex = 145;
            // 
            // lblCodigo
            // 
            this.lblCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.Purple;
            this.lblCodigo.Location = new System.Drawing.Point(182, 349);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(65, 20);
            this.lblCodigo.TabIndex = 141;
            this.lblCodigo.Text = "Codigo";
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.Purple;
            this.lblNombre.Location = new System.Drawing.Point(347, 349);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(71, 20);
            this.lblNombre.TabIndex = 142;
            this.lblNombre.Text = "Nombre";
            // 
            // lblValorUnt
            // 
            this.lblValorUnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorUnt.AutoSize = true;
            this.lblValorUnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorUnt.ForeColor = System.Drawing.Color.Purple;
            this.lblValorUnt.Location = new System.Drawing.Point(652, 349);
            this.lblValorUnt.Name = "lblValorUnt";
            this.lblValorUnt.Size = new System.Drawing.Size(79, 20);
            this.lblValorUnt.TabIndex = 143;
            this.lblValorUnt.Text = "Valor Un";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.txbCodigo.BackColor = System.Drawing.Color.White;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.ForeColor = System.Drawing.Color.Purple;
            this.txbCodigo.Location = new System.Drawing.Point(186, 372);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(61, 26);
            this.txbCodigo.TabIndex = 144;
            this.txbCodigo.Enter += new System.EventHandler(this.txbCodigo_Enter);
            this.txbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodigo_KeyPress);
            // 
            // txbValorUnt
            // 
            this.txbValorUnt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbValorUnt.BackColor = System.Drawing.Color.White;
            this.txbValorUnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbValorUnt.ForeColor = System.Drawing.Color.Purple;
            this.txbValorUnt.Location = new System.Drawing.Point(634, 372);
            this.txbValorUnt.Name = "txbValorUnt";
            this.txbValorUnt.ReadOnly = true;
            this.txbValorUnt.Size = new System.Drawing.Size(112, 26);
            this.txbValorUnt.TabIndex = 146;
            this.txbValorUnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbCanti
            // 
            this.txbCanti.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbCanti.BackColor = System.Drawing.Color.White;
            this.txbCanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCanti.ForeColor = System.Drawing.Color.Purple;
            this.txbCanti.Location = new System.Drawing.Point(752, 372);
            this.txbCanti.Name = "txbCanti";
            this.txbCanti.Size = new System.Drawing.Size(83, 26);
            this.txbCanti.TabIndex = 147;
            this.txbCanti.Text = "1";
            this.txbCanti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txbCanti.Enter += new System.EventHandler(this.txbCanti_Enter);
            this.txbCanti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCanti_KeyPress);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.ForeColor = System.Drawing.Color.Purple;
            this.lblCantidad.Location = new System.Drawing.Point(754, 349);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(81, 20);
            this.lblCantidad.TabIndex = 148;
            this.lblCantidad.Text = "Cantidad";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txbTotalProforma);
            this.panel3.Controls.Add(this.lblTotal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txbIV);
            this.panel3.Controls.Add(this.txbSubTotal);
            this.panel3.Location = new System.Drawing.Point(186, 664);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(649, 46);
            this.panel3.TabIndex = 160;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(127, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 159;
            this.label10.Text = "Sub-Total =";
            // 
            // txbTotalProforma
            // 
            this.txbTotalProforma.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbTotalProforma.BackColor = System.Drawing.Color.White;
            this.txbTotalProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalProforma.ForeColor = System.Drawing.Color.Fuchsia;
            this.txbTotalProforma.Location = new System.Drawing.Point(449, 6);
            this.txbTotalProforma.Name = "txbTotalProforma";
            this.txbTotalProforma.ReadOnly = true;
            this.txbTotalProforma.Size = new System.Drawing.Size(191, 35);
            this.txbTotalProforma.TabIndex = 14;
            this.txbTotalProforma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblTotal.Location = new System.Drawing.Point(348, 9);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(95, 29);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total =";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(1, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 156;
            this.label1.Text = "IV =";
            // 
            // txbIV
            // 
            this.txbIV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbIV.BackColor = System.Drawing.Color.White;
            this.txbIV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIV.ForeColor = System.Drawing.Color.Blue;
            this.txbIV.Location = new System.Drawing.Point(41, 16);
            this.txbIV.Name = "txbIV";
            this.txbIV.ReadOnly = true;
            this.txbIV.Size = new System.Drawing.Size(76, 22);
            this.txbIV.TabIndex = 157;
            this.txbIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbSubTotal
            // 
            this.txbSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSubTotal.ForeColor = System.Drawing.Color.Blue;
            this.txbSubTotal.Location = new System.Drawing.Point(221, 16);
            this.txbSubTotal.Name = "txbSubTotal";
            this.txbSubTotal.Size = new System.Drawing.Size(109, 22);
            this.txbSubTotal.TabIndex = 158;
            // 
            // btnRegistarProducto
            // 
            this.btnRegistarProducto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnRegistarProducto.BackColor = System.Drawing.Color.White;
            this.btnRegistarProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarProducto.ForeColor = System.Drawing.Color.Purple;
            this.btnRegistarProducto.Image = global::Punto_de_Venta.Properties.Resources.NuevoProducto48;
            this.btnRegistarProducto.Location = new System.Drawing.Point(881, 503);
            this.btnRegistarProducto.Name = "btnRegistarProducto";
            this.btnRegistarProducto.Size = new System.Drawing.Size(127, 59);
            this.btnRegistarProducto.TabIndex = 149;
            this.btnRegistarProducto.Text = "Nuevo Producto";
            this.btnRegistarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistarProducto.UseVisualStyleBackColor = false;
            this.btnRegistarProducto.Click += new System.EventHandler(this.btnRegistarProducto_Click);
            // 
            // btnRealizarProforma
            // 
            this.btnRealizarProforma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRealizarProforma.BackColor = System.Drawing.Color.White;
            this.btnRealizarProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarProforma.ForeColor = System.Drawing.Color.Purple;
            this.btnRealizarProforma.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.btnRealizarProforma.Location = new System.Drawing.Point(881, 651);
            this.btnRealizarProforma.Name = "btnRealizarProforma";
            this.btnRealizarProforma.Size = new System.Drawing.Size(127, 59);
            this.btnRealizarProforma.TabIndex = 148;
            this.btnRealizarProforma.Text = "Realizar Proforma";
            this.btnRealizarProforma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarProforma.UseVisualStyleBackColor = false;
            this.btnRealizarProforma.Click += new System.EventHandler(this.btnRealizarProforma_Click);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.BackColor = System.Drawing.Color.White;
            this.lvItems.CheckBoxes = true;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CodProd,
            this.NombreProd,
            this.CantProd,
            this.ValorUnitario,
            this.TotalProd,
            this.IV});
            this.lvItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.ForeColor = System.Drawing.Color.Purple;
            this.lvItems.FullRowSelect = true;
            this.lvItems.GridLines = true;
            this.lvItems.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lvItems.Location = new System.Drawing.Point(186, 413);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(649, 245);
            this.lvItems.TabIndex = 155;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // CodProd
            // 
            this.CodProd.Text = "Codigo";
            this.CodProd.Width = 150;
            // 
            // NombreProd
            // 
            this.NombreProd.Text = "Nombre";
            this.NombreProd.Width = 300;
            // 
            // CantProd
            // 
            this.CantProd.Text = "Cantidad";
            this.CantProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantProd.Width = 141;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.Text = "Valor Unitario";
            this.ValorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ValorUnitario.Width = 200;
            // 
            // TotalProd
            // 
            this.TotalProd.Text = "Total";
            this.TotalProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TotalProd.Width = 200;
            // 
            // IV
            // 
            this.IV.Width = 0;
            // 
            // txbGravado
            // 
            this.txbGravado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGravado.Location = new System.Drawing.Point(27, 453);
            this.txbGravado.Name = "txbGravado";
            this.txbGravado.Size = new System.Drawing.Size(86, 26);
            this.txbGravado.TabIndex = 161;
            this.txbGravado.Visible = false;
            // 
            // txbInsNuevo
            // 
            this.txbInsNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInsNuevo.Location = new System.Drawing.Point(27, 485);
            this.txbInsNuevo.Name = "txbInsNuevo";
            this.txbInsNuevo.Size = new System.Drawing.Size(86, 26);
            this.txbInsNuevo.TabIndex = 162;
            this.txbInsNuevo.Visible = false;
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txbFecha);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txbNumProforma);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(993, 137);
            this.panel1.TabIndex = 163;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Fuchsia;
            this.label2.Location = new System.Drawing.Point(400, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 33);
            this.label2.TabIndex = 60;
            this.label2.Text = "PROFORMA";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txbDirecion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txbCodigoCliente);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txbNombreCliente);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txnTelefono);
            this.groupBox1.ForeColor = System.Drawing.Color.Indigo;
            this.groupBox1.Location = new System.Drawing.Point(8, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(979, 95);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Cliente";
            // 
            // txbDirecion
            // 
            this.txbDirecion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbDirecion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDirecion.ForeColor = System.Drawing.Color.Indigo;
            this.txbDirecion.Location = new System.Drawing.Point(96, 65);
            this.txbDirecion.Name = "txbDirecion";
            this.txbDirecion.Size = new System.Drawing.Size(872, 22);
            this.txbDirecion.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(12, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 55;
            this.label9.Text = "Dirección:";
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigoCliente.Enabled = false;
            this.txbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoCliente.ForeColor = System.Drawing.Color.Indigo;
            this.txbCodigoCliente.Location = new System.Drawing.Point(80, 31);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(43, 22);
            this.txbCodigoCliente.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Indigo;
            this.label6.Location = new System.Drawing.Point(12, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 43;
            this.label6.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(168, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nombre:";
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreCliente.ForeColor = System.Drawing.Color.Indigo;
            this.txbNombreCliente.Location = new System.Drawing.Point(240, 31);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(278, 22);
            this.txbNombreCliente.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Indigo;
            this.label5.Location = new System.Drawing.Point(689, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 53;
            this.label5.Text = "Telefono:";
            // 
            // txnTelefono
            // 
            this.txnTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txnTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txnTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txnTelefono.ForeColor = System.Drawing.Color.Indigo;
            this.txnTelefono.Location = new System.Drawing.Point(769, 31);
            this.txnTelefono.Name = "txnTelefono";
            this.txnTelefono.Size = new System.Drawing.Size(199, 22);
            this.txnTelefono.TabIndex = 54;
            // 
            // txbFecha
            // 
            this.txbFecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFecha.ForeColor = System.Drawing.Color.Indigo;
            this.txbFecha.Location = new System.Drawing.Point(72, 11);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(134, 22);
            this.txbFecha.TabIndex = 58;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Indigo;
            this.label8.Location = new System.Drawing.Point(11, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 57;
            this.label8.Text = "Fecha:";
            // 
            // txbNumProforma
            // 
            this.txbNumProforma.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbNumProforma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNumProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNumProforma.ForeColor = System.Drawing.Color.Indigo;
            this.txbNumProforma.Location = new System.Drawing.Point(904, 7);
            this.txbNumProforma.Name = "txbNumProforma";
            this.txbNumProforma.Size = new System.Drawing.Size(84, 22);
            this.txbNumProforma.TabIndex = 56;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Indigo;
            this.label7.Location = new System.Drawing.Point(811, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Proforma #:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEliminar.BackColor = System.Drawing.Color.White;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Purple;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(881, 445);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(127, 52);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Producto";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.Purple;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(881, 568);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(127, 54);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Limpiar la lista";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnVerDescuento
            // 
            this.btnVerDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerDescuento.Location = new System.Drawing.Point(41, 679);
            this.btnVerDescuento.Name = "btnVerDescuento";
            this.btnVerDescuento.Size = new System.Drawing.Size(76, 23);
            this.btnVerDescuento.TabIndex = 168;
            this.btnVerDescuento.Text = "Aplicar";
            this.btnVerDescuento.UseVisualStyleBackColor = true;
            // 
            // NumDesc
            // 
            this.NumDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumDesc.ForeColor = System.Drawing.Color.Navy;
            this.NumDesc.Location = new System.Drawing.Point(120, 605);
            this.NumDesc.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.NumDesc.Name = "NumDesc";
            this.NumDesc.Size = new System.Drawing.Size(45, 22);
            this.NumDesc.TabIndex = 167;
            this.NumDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NumDesc.ValueChanged += new System.EventHandler(this.NumDesc_ValueChanged);
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.Color.Navy;
            this.lblDescuento.Location = new System.Drawing.Point(10, 607);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(107, 16);
            this.lblDescuento.TabIndex = 165;
            this.lblDescuento.Text = "Descuento % :";
            // 
            // txbDesc
            // 
            this.txbDesc.BackColor = System.Drawing.Color.White;
            this.txbDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDesc.Location = new System.Drawing.Point(70, 645);
            this.txbDesc.Name = "txbDesc";
            this.txbDesc.ReadOnly = true;
            this.txbDesc.Size = new System.Drawing.Size(84, 22);
            this.txbDesc.TabIndex = 166;
            this.txbDesc.Text = "0.0";
            this.txbDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbDesc.Visible = false;
            // 
            // lbl_Descuento
            // 
            this.lbl_Descuento.AutoSize = true;
            this.lbl_Descuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Descuento.Location = new System.Drawing.Point(12, 648);
            this.lbl_Descuento.Name = "lbl_Descuento";
            this.lbl_Descuento.Size = new System.Drawing.Size(52, 16);
            this.lbl_Descuento.TabIndex = 164;
            this.lbl_Descuento.Text = "Desc=";
            this.lbl_Descuento.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(3, 578);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(177, 132);
            this.panel2.TabIndex = 160;
            // 
            // Frm_RegistarProforma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 717);
            this.Controls.Add(this.btnVerDescuento);
            this.Controls.Add(this.NumDesc);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.txbDesc);
            this.Controls.Add(this.lbl_Descuento);
            this.Controls.Add(this.btnRegistarProducto);
            this.Controls.Add(this.btnRealizarProforma);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbGravado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txbInsNuevo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblValorUnt);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.txbValorUnt);
            this.Controls.Add(this.txbCanti);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.PanelLista);
            this.Controls.Add(this.panel2);
            this.Name = "Frm_RegistarProforma";
            this.Text = "Proforma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_RegistarProforma_Load);
            this.PanelLista.ResumeLayout(false);
            this.PanelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListarProductos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumDesc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelLista;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.DataGridView dtgListarProductos;
        private System.Windows.Forms.TextBox txbFiltroPrincipal;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblValorUnt;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbValorUnt;
        private System.Windows.Forms.TextBox txbCanti;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRegistarProducto;
        private System.Windows.Forms.TextBox txbTotalProforma;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRealizarProforma;
        private System.Windows.Forms.TextBox txbSubTotal;
        private System.Windows.Forms.TextBox txbIV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader CodProd;
        private System.Windows.Forms.ColumnHeader NombreProd;
        private System.Windows.Forms.ColumnHeader CantProd;
        private System.Windows.Forms.ColumnHeader TotalProd;
        private System.Windows.Forms.ColumnHeader IV;
        private System.Windows.Forms.TextBox txbGravado;
        private System.Windows.Forms.TextBox txbInsNuevo;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txnTelefono;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNumProforma;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDirecion;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.ColumnHeader ValorUnitario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnVerDescuento;
        private System.Windows.Forms.NumericUpDown NumDesc;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox txbDesc;
        private System.Windows.Forms.Label lbl_Descuento;
        private System.Windows.Forms.Panel panel2;
    }
}