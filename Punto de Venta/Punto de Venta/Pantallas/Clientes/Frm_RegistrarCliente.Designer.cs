namespace Punto_de_Venta.Pantallas.Clientes
{
    partial class Frm_RegistrarCliente
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.numUDcomision = new System.Windows.Forms.NumericUpDown();
            this.txbDireccion = new System.Windows.Forms.RichTextBox();
            this.txbTelefono = new System.Windows.Forms.RichTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbCredMaximo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.chkComision = new System.Windows.Forms.CheckBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbTipoClie = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txbFechaReg = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txbApellido2 = new System.Windows.Forms.TextBox();
            this.txbApellido1 = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUDcomision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Location = new System.Drawing.Point(20, 494);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(969, 73);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(824, 15);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 52);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Salir";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.White;
            this.btnAceptar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Image = global::Punto_de_Venta.Properties.Resources.guardar;
            this.btnAceptar.Location = new System.Drawing.Point(15, 15);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(155, 52);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Guardar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // numUDcomision
            // 
            this.numUDcomision.Enabled = false;
            this.numUDcomision.Location = new System.Drawing.Point(597, 356);
            this.numUDcomision.Name = "numUDcomision";
            this.numUDcomision.ReadOnly = true;
            this.numUDcomision.Size = new System.Drawing.Size(54, 26);
            this.numUDcomision.TabIndex = 53;
            this.numUDcomision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numUDcomision.Visible = false;
            // 
            // txbDireccion
            // 
            this.txbDireccion.BackColor = System.Drawing.Color.White;
            this.txbDireccion.Location = new System.Drawing.Point(476, 142);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(461, 73);
            this.txbDireccion.TabIndex = 52;
            this.txbDireccion.Text = "";
            // 
            // txbTelefono
            // 
            this.txbTelefono.BackColor = System.Drawing.Color.White;
            this.txbTelefono.Location = new System.Drawing.Point(118, 152);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(234, 63);
            this.txbTelefono.TabIndex = 51;
            this.txbTelefono.Text = "";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label14.Location = new System.Drawing.Point(354, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(294, 47);
            this.label14.TabIndex = 8;
            this.label14.Text = "Registro de clientes";
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txbCredMaximo);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.numUDcomision);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txbTelefono);
            this.panel1.Controls.Add(this.txbDireccion);
            this.panel1.Controls.Add(this.chkComision);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cmbTipoClie);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txbCedula);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txbFechaReg);
            this.panel1.Controls.Add(this.chkEstado);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txbApellido2);
            this.panel1.Controls.Add(this.txbApellido1);
            this.panel1.Controls.Add(this.txbNombre);
            this.panel1.Controls.Add(this.txbCodigo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(21, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 399);
            this.panel1.TabIndex = 53;
            // 
            // txbCredMaximo
            // 
            this.txbCredMaximo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCredMaximo.Enabled = false;
            this.txbCredMaximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCredMaximo.Location = new System.Drawing.Point(727, 314);
            this.txbCredMaximo.MaxLength = 20;
            this.txbCredMaximo.Name = "txbCredMaximo";
            this.txbCredMaximo.Size = new System.Drawing.Size(142, 26);
            this.txbCredMaximo.TabIndex = 55;
            this.txbCredMaximo.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(584, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 20);
            this.label15.TabIndex = 54;
            this.label15.Text = "Credito Maximo:";
            this.label15.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(484, 362);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 20);
            this.label12.TabIndex = 49;
            this.label12.Text = "% Comisión:";
            this.label12.Visible = false;
            // 
            // chkComision
            // 
            this.chkComision.AutoSize = true;
            this.chkComision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkComision.Location = new System.Drawing.Point(421, 361);
            this.chkComision.Name = "chkComision";
            this.chkComision.Size = new System.Drawing.Size(44, 24);
            this.chkComision.TabIndex = 48;
            this.chkComision.Text = "Si";
            this.chkComision.UseVisualStyleBackColor = true;
            this.chkComision.Visible = false;
            this.chkComision.CheckedChanged += new System.EventHandler(this.chkComision_CheckedChanged_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(299, 362);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(116, 20);
            this.label13.TabIndex = 47;
            this.label13.Text = "Comisionista:";
            this.label13.Visible = false;
            // 
            // cmbTipoClie
            // 
            this.cmbTipoClie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoClie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoClie.FormattingEnabled = true;
            this.cmbTipoClie.Items.AddRange(new object[] {
            "SIN CREDITO",
            "REGULAR ",
            "PLATIUM ",
            "GOLD",
            "ESTRELLA",
            "MOROSO"});
            this.cmbTipoClie.Location = new System.Drawing.Point(185, 312);
            this.cmbTipoClie.Name = "cmbTipoClie";
            this.cmbTipoClie.Size = new System.Drawing.Size(194, 28);
            this.cmbTipoClie.TabIndex = 45;
            this.cmbTipoClie.Visible = false;
            this.cmbTipoClie.SelectedIndexChanged += new System.EventHandler(this.cmbTipoClie_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(698, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Sin guiones y espacios";
            // 
            // txbCedula
            // 
            this.txbCedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedula.Location = new System.Drawing.Point(554, 18);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(138, 26);
            this.txbCedula.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(466, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 20);
            this.label10.TabIndex = 40;
            this.label10.Text = "Cedula:";
            // 
            // txbFechaReg
            // 
            this.txbFechaReg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbFechaReg.Enabled = false;
            this.txbFechaReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFechaReg.Location = new System.Drawing.Point(237, 249);
            this.txbFechaReg.MaxLength = 20;
            this.txbFechaReg.Name = "txbFechaReg";
            this.txbFechaReg.Size = new System.Drawing.Size(164, 26);
            this.txbFechaReg.TabIndex = 34;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEstado.Location = new System.Drawing.Point(644, 254);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(77, 24);
            this.chkEstado.TabIndex = 39;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(555, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 38;
            this.label9.Text = "Estado:";
            // 
            // txbApellido2
            // 
            this.txbApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido2.Location = new System.Drawing.Point(769, 72);
            this.txbApellido2.Name = "txbApellido2";
            this.txbApellido2.Size = new System.Drawing.Size(153, 26);
            this.txbApellido2.TabIndex = 31;
            // 
            // txbApellido1
            // 
            this.txbApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbApellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbApellido1.Location = new System.Drawing.Point(486, 72);
            this.txbApellido1.Name = "txbApellido1";
            this.txbApellido1.Size = new System.Drawing.Size(153, 26);
            this.txbApellido1.TabIndex = 30;
            // 
            // txbNombre
            // 
            this.txbNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(118, 72);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(234, 26);
            this.txbNombre.TabIndex = 29;
            // 
            // txbCodigo
            // 
            this.txbCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(279, 18);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(100, 26);
            this.txbCodigo.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(33, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Tipo de Cliente:";
            this.label8.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(81, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Fecha Registro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(381, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Direccion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(16, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Telefono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(650, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "2do Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(371, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "1er Apellido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(191, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Codigo:";
            // 
            // Frm_RegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_RegistrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Clientes";
            this.Load += new System.EventHandler(this.Frm_RegistrarCliente_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numUDcomision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numUDcomision;
        private System.Windows.Forms.RichTextBox txbDireccion;
        private System.Windows.Forms.RichTextBox txbTelefono;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkComision;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbTipoClie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbFechaReg;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbApellido2;
        private System.Windows.Forms.TextBox txbApellido1;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCredMaximo;
        private System.Windows.Forms.Label label15;
    }
}