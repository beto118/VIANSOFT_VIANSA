namespace Punto_de_Venta.Pantallas.Facturas
{
    partial class Frm_EditarFactura
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.txbHora = new System.Windows.Forms.TextBox();
            this.txbFecha = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkEnviar = new System.Windows.Forms.CheckBox();
            this.txbTipo = new System.Windows.Forms.TextBox();
            this.lblTipFact = new System.Windows.Forms.Label();
            this.txbCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.txbId_Factura = new System.Windows.Forms.TextBox();
            this.lblNumFact = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.txbDireccion = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReimprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(450, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 20);
            this.label7.TabIndex = 178;
            this.label7.Text = "Estado:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Cyan;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListado.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(20, 193);
            this.dgvListado.MultiSelect = false;
            this.dgvListado.Name = "dgvListado";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(896, 263);
            this.dgvListado.TabIndex = 177;
            // 
            // txbHora
            // 
            this.txbHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHora.Location = new System.Drawing.Point(301, 21);
            this.txbHora.Name = "txbHora";
            this.txbHora.Size = new System.Drawing.Size(137, 26);
            this.txbHora.TabIndex = 176;
            // 
            // txbFecha
            // 
            this.txbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFecha.Location = new System.Drawing.Point(88, 21);
            this.txbFecha.Name = "txbFecha";
            this.txbFecha.Size = new System.Drawing.Size(137, 26);
            this.txbFecha.TabIndex = 175;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(240, 24);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(53, 20);
            this.lblHora.TabIndex = 174;
            this.lblHora.Text = "Hora:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.chkEnviar);
            this.panel1.Controls.Add(this.txbTipo);
            this.panel1.Controls.Add(this.lblTipFact);
            this.panel1.Controls.Add(this.txbCliente);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnBuscarCliente);
            this.panel1.Controls.Add(this.txbTelefono);
            this.panel1.Controls.Add(this.lblCliente);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbCodigoCliente);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(20, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 134);
            this.panel1.TabIndex = 173;
            // 
            // chkEnviar
            // 
            this.chkEnviar.AutoSize = true;
            this.chkEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEnviar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkEnviar.Location = new System.Drawing.Point(250, 75);
            this.chkEnviar.Name = "chkEnviar";
            this.chkEnviar.Size = new System.Drawing.Size(71, 20);
            this.chkEnviar.TabIndex = 31;
            this.chkEnviar.Text = "Enviar";
            this.chkEnviar.UseVisualStyleBackColor = true;
            // 
            // txbTipo
            // 
            this.txbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTipo.Location = new System.Drawing.Point(109, 45);
            this.txbTipo.Name = "txbTipo";
            this.txbTipo.Size = new System.Drawing.Size(123, 22);
            this.txbTipo.TabIndex = 16;
            // 
            // lblTipFact
            // 
            this.lblTipFact.AutoSize = true;
            this.lblTipFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipFact.Location = new System.Drawing.Point(3, 48);
            this.lblTipFact.Name = "lblTipFact";
            this.lblTipFact.Size = new System.Drawing.Size(100, 16);
            this.lblTipFact.TabIndex = 10;
            this.lblTipFact.Text = "Tipo Factura:";
            // 
            // txbCliente
            // 
            this.txbCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCliente.Location = new System.Drawing.Point(69, 10);
            this.txbCliente.Name = "txbCliente";
            this.txbCliente.Size = new System.Drawing.Size(409, 22);
            this.txbCliente.TabIndex = 7;
            this.txbCliente.Text = "CLIENTE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(247, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 29;
            this.label4.Text = "Direccion:";
            // 
            // txbTelefono
            // 
            this.txbTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTelefono.ForeColor = System.Drawing.Color.Black;
            this.txbTelefono.Location = new System.Drawing.Point(679, 7);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(210, 22);
            this.txbTelefono.TabIndex = 28;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(3, 13);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(60, 16);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(606, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Telefono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(484, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Codigo:";
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.BackColor = System.Drawing.Color.White;
            this.txbCodigoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoCliente.ForeColor = System.Drawing.Color.Black;
            this.txbCodigoCliente.Location = new System.Drawing.Point(552, 7);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(48, 22);
            this.txbCodigoCliente.TabIndex = 25;
            this.txbCodigoCliente.Text = "1";
            // 
            // txbId_Factura
            // 
            this.txbId_Factura.Enabled = false;
            this.txbId_Factura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbId_Factura.Location = new System.Drawing.Point(776, 21);
            this.txbId_Factura.Name = "txbId_Factura";
            this.txbId_Factura.Size = new System.Drawing.Size(137, 26);
            this.txbId_Factura.TabIndex = 172;
            // 
            // lblNumFact
            // 
            this.lblNumFact.AutoSize = true;
            this.lblNumFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumFact.Location = new System.Drawing.Point(674, 24);
            this.lblNumFact.Name = "lblNumFact";
            this.lblNumFact.Size = new System.Drawing.Size(96, 20);
            this.lblNumFact.TabIndex = 170;
            this.lblNumFact.Text = "Factura # :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(16, 24);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(64, 20);
            this.lblFecha.TabIndex = 171;
            this.lblFecha.Text = "Fecha:";
            // 
            // txbEstado
            // 
            this.txbEstado.Enabled = false;
            this.txbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbEstado.Location = new System.Drawing.Point(527, 21);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(137, 26);
            this.txbEstado.TabIndex = 179;
            // 
            // txbDireccion
            // 
            this.txbDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDireccion.ForeColor = System.Drawing.Color.Blue;
            this.txbDireccion.Location = new System.Drawing.Point(351, 100);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(560, 82);
            this.txbDireccion.TabIndex = 30;
            this.txbDireccion.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Punto_de_Venta.Properties.Resources.url1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(20, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 41);
            this.button1.TabIndex = 180;
            this.button1.Text = "Editar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.White;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Image = global::Punto_de_Venta.Properties.Resources.url;
            this.btnBuscarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscarCliente.Location = new System.Drawing.Point(6, 82);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(180, 41);
            this.btnBuscarCliente.TabIndex = 26;
            this.btnBuscarCliente.Text = "Lista de Clientes";
            this.btnBuscarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnSalir.Location = new System.Drawing.Point(821, 490);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 41);
            this.btnSalir.TabIndex = 181;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnReimprimir
            // 
            this.btnReimprimir.BackColor = System.Drawing.Color.White;
            this.btnReimprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReimprimir.Image = global::Punto_de_Venta.Properties.Resources.imprimir;
            this.btnReimprimir.Location = new System.Drawing.Point(388, 490);
            this.btnReimprimir.Name = "btnReimprimir";
            this.btnReimprimir.Size = new System.Drawing.Size(180, 46);
            this.btnReimprimir.TabIndex = 182;
            this.btnReimprimir.Text = "RE-IMPRIMIR ";
            this.btnReimprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReimprimir.UseVisualStyleBackColor = false;
            // 
            // Frm_EditarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 543);
            this.Controls.Add(this.btnReimprimir);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.txbDireccion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.txbHora);
            this.Controls.Add(this.txbFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txbId_Factura);
            this.Controls.Add(this.lblNumFact);
            this.Controls.Add(this.lblFecha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EditarFactura";
            this.Text = "Editar Factura";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TextBox txbHora;
        private System.Windows.Forms.TextBox txbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTipo;
        private System.Windows.Forms.Label lblTipFact;
        private System.Windows.Forms.TextBox txbCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox txbId_Factura;
        private System.Windows.Forms.Label lblNumFact;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.CheckBox chkEnviar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private System.Windows.Forms.RichTextBox txbDireccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReimprimir;
    }
}