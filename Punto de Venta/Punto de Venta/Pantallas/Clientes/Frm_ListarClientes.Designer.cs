namespace Punto_de_Venta.Pantallas.Clientes
{
    partial class Frm_ListarClientes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ckEstado = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarProforma = new System.Windows.Forms.Button();
            this.btnCancelarFact = new System.Windows.Forms.Button();
            this.btnVerFactCred = new System.Windows.Forms.Button();
            this.btnEnviarFact = new System.Windows.Forms.Button();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelaFactHoy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ckEstado
            // 
            this.ckEstado.AutoSize = true;
            this.ckEstado.Checked = true;
            this.ckEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckEstado.Location = new System.Drawing.Point(452, 15);
            this.ckEstado.Name = "ckEstado";
            this.ckEstado.Size = new System.Drawing.Size(96, 28);
            this.ckEstado.TabIndex = 14;
            this.ckEstado.Text = "Activos";
            this.ckEstado.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(302, 15);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(106, 29);
            this.btnBuscar.TabIndex = 13;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Location = new System.Drawing.Point(81, 17);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(199, 29);
            this.txbFiltro.TabIndex = 12;
            this.txbFiltro.TextChanged += new System.EventHandler(this.txbFiltro_TextChanged);
            this.txbFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFiltro_KeyPress);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro.Location = new System.Drawing.Point(12, 20);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(63, 24);
            this.lblFiltro.TabIndex = 11;
            this.lblFiltro.Text = "Filtro:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.DarkTurquoise;
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(12, 64);
            this.dgvListado.Name = "dgvListado";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListado.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(892, 459);
            this.dgvListado.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnCancelaFactHoy);
            this.groupBox1.Controls.Add(this.btnEnviarProforma);
            this.groupBox1.Controls.Add(this.btnCancelarFact);
            this.groupBox1.Controls.Add(this.btnVerFactCred);
            this.groupBox1.Controls.Add(this.btnEnviarFact);
            this.groupBox1.Controls.Add(this.btnNuevoCliente);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Location = new System.Drawing.Point(12, 542);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(892, 74);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // btnEnviarProforma
            // 
            this.btnEnviarProforma.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnviarProforma.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarProforma.BackColor = System.Drawing.Color.White;
            this.btnEnviarProforma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnviarProforma.ForeColor = System.Drawing.Color.Purple;
            this.btnEnviarProforma.Image = global::Punto_de_Venta.Properties.Resources.flecha_derecha_abajo;
            this.btnEnviarProforma.Location = new System.Drawing.Point(251, 17);
            this.btnEnviarProforma.Name = "btnEnviarProforma";
            this.btnEnviarProforma.Size = new System.Drawing.Size(137, 49);
            this.btnEnviarProforma.TabIndex = 8;
            this.btnEnviarProforma.Text = "Enviar a Proforma";
            this.btnEnviarProforma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarProforma.UseVisualStyleBackColor = false;
            this.btnEnviarProforma.Click += new System.EventHandler(this.btnEnviarProforma_Click);
            // 
            // btnCancelarFact
            // 
            this.btnCancelarFact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelarFact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelarFact.BackColor = System.Drawing.Color.White;
            this.btnCancelarFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelarFact.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelarFact.Image = global::Punto_de_Venta.Properties.Resources.icon_factura;
            this.btnCancelarFact.Location = new System.Drawing.Point(537, 17);
            this.btnCancelarFact.Name = "btnCancelarFact";
            this.btnCancelarFact.Size = new System.Drawing.Size(115, 49);
            this.btnCancelarFact.TabIndex = 7;
            this.btnCancelarFact.Text = "Cancelar Facturas";
            this.btnCancelarFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarFact.UseVisualStyleBackColor = false;
            this.btnCancelarFact.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVerFactCred
            // 
            this.btnVerFactCred.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnVerFactCred.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerFactCred.BackColor = System.Drawing.Color.White;
            this.btnVerFactCred.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnVerFactCred.ForeColor = System.Drawing.Color.Green;
            this.btnVerFactCred.Image = global::Punto_de_Venta.Properties.Resources.icon_factura;
            this.btnVerFactCred.Location = new System.Drawing.Point(394, 17);
            this.btnVerFactCred.Name = "btnVerFactCred";
            this.btnVerFactCred.Size = new System.Drawing.Size(137, 49);
            this.btnVerFactCred.TabIndex = 6;
            this.btnVerFactCred.Text = "Ver Facturas a Credito";
            this.btnVerFactCred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVerFactCred.UseVisualStyleBackColor = false;
            this.btnVerFactCred.Click += new System.EventHandler(this.btnVerFactCred_Click);
            // 
            // btnEnviarFact
            // 
            this.btnEnviarFact.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEnviarFact.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarFact.BackColor = System.Drawing.Color.White;
            this.btnEnviarFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEnviarFact.Image = global::Punto_de_Venta.Properties.Resources.check241;
            this.btnEnviarFact.Location = new System.Drawing.Point(124, 17);
            this.btnEnviarFact.Name = "btnEnviarFact";
            this.btnEnviarFact.Size = new System.Drawing.Size(113, 49);
            this.btnEnviarFact.TabIndex = 5;
            this.btnEnviarFact.Text = "Enviar a la Factura";
            this.btnEnviarFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEnviarFact.UseVisualStyleBackColor = false;
            this.btnEnviarFact.Click += new System.EventHandler(this.btnEnviarFact_Click);
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnNuevoCliente.BackColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnNuevoCliente.Image = global::Punto_de_Venta.Properties.Resources.Nuevo_Usuario;
            this.btnNuevoCliente.Location = new System.Drawing.Point(6, 15);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(112, 53);
            this.btnNuevoCliente.TabIndex = 4;
            this.btnNuevoCliente.Text = "Nuevo Cliente";
            this.btnNuevoCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            this.btnNuevoCliente.Click += new System.EventHandler(this.btnNuevoCliente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(771, 17);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 49);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.Teal;
            this.btnEditar.Image = global::Punto_de_Venta.Properties.Resources.j0432573;
            this.btnEditar.Location = new System.Drawing.Point(658, 17);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(107, 49);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelaFactHoy
            // 
            this.btnCancelaFactHoy.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancelaFactHoy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelaFactHoy.BackColor = System.Drawing.Color.White;
            this.btnCancelaFactHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnCancelaFactHoy.ForeColor = System.Drawing.Color.Blue;
            this.btnCancelaFactHoy.Image = global::Punto_de_Venta.Properties.Resources.icon_factura;
            this.btnCancelaFactHoy.Location = new System.Drawing.Point(537, 0);
            this.btnCancelaFactHoy.Name = "btnCancelaFactHoy";
            this.btnCancelaFactHoy.Size = new System.Drawing.Size(115, 49);
            this.btnCancelaFactHoy.TabIndex = 9;
            this.btnCancelaFactHoy.Text = "Cancelar Facturas";
            this.btnCancelaFactHoy.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelaFactHoy.UseVisualStyleBackColor = false;
            this.btnCancelaFactHoy.Click += new System.EventHandler(this.btnCancelaFactHoy_Click);
            // 
            // Frm_ListarClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 628);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ckEstado);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txbFiltro);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.dgvListado);
            this.Name = "Frm_ListarClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ListarClientes";
            this.Load += new System.EventHandler(this.Frm_ListarClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckEstado;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEnviarFact;
        private System.Windows.Forms.Button btnVerFactCred;
        private System.Windows.Forms.Button btnCancelarFact;
        private System.Windows.Forms.Button btnEnviarProforma;
        private System.Windows.Forms.Button btnCancelaFactHoy;
    }
}