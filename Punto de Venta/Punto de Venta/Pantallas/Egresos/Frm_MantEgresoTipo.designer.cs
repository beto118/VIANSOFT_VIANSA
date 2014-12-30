namespace Punto_de_Venta.Pantallas.Egresos
{
    partial class Frm_MantEgresoTipo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabInsertar = new System.Windows.Forms.TabPage();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbxOperacionMat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.tabListar = new System.Windows.Forms.TabPage();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.tabModificar = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbxMasMenos = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbNombreMod = new System.Windows.Forms.TextBox();
            this.btnGuardarMod = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabInsertar.SuspendLayout();
            this.tabListar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tabModificar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabInsertar);
            this.tabControl1.Controls.Add(this.tabListar);
            this.tabControl1.Controls.Add(this.tabModificar);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(638, 303);
            this.tabControl1.TabIndex = 7;
            // 
            // tabInsertar
            // 
            this.tabInsertar.Controls.Add(this.btnGuardar);
            this.tabInsertar.Controls.Add(this.label3);
            this.tabInsertar.Controls.Add(this.cmbxOperacionMat);
            this.tabInsertar.Controls.Add(this.label2);
            this.tabInsertar.Controls.Add(this.txbNombre);
            this.tabInsertar.Location = new System.Drawing.Point(4, 24);
            this.tabInsertar.Name = "tabInsertar";
            this.tabInsertar.Padding = new System.Windows.Forms.Padding(3);
            this.tabInsertar.Size = new System.Drawing.Size(630, 275);
            this.tabInsertar.TabIndex = 0;
            this.tabInsertar.Text = "Insertar";
            this.tabInsertar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardar.Location = new System.Drawing.Point(246, 152);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(138, 79);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Operación Matematica:";
            // 
            // cmbxOperacionMat
            // 
            this.cmbxOperacionMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxOperacionMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxOperacionMat.FormattingEnabled = true;
            this.cmbxOperacionMat.Items.AddRange(new object[] {
            "Sumar ( +)",
            "Restar ( - )"});
            this.cmbxOperacionMat.Location = new System.Drawing.Point(334, 92);
            this.cmbxOperacionMat.Name = "cmbxOperacionMat";
            this.cmbxOperacionMat.Size = new System.Drawing.Size(163, 28);
            this.cmbxOperacionMat.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txbNombre
            // 
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.Location = new System.Drawing.Point(334, 48);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(163, 26);
            this.txbNombre.TabIndex = 4;
            // 
            // tabListar
            // 
            this.tabListar.Controls.Add(this.btnBuscar);
            this.tabListar.Controls.Add(this.btnModificar);
            this.tabListar.Controls.Add(this.txbFiltro);
            this.tabListar.Controls.Add(this.label1);
            this.tabListar.Controls.Add(this.dgvListado);
            this.tabListar.Location = new System.Drawing.Point(4, 24);
            this.tabListar.Name = "tabListar";
            this.tabListar.Size = new System.Drawing.Size(630, 275);
            this.tabListar.TabIndex = 2;
            this.tabListar.Text = "Listar";
            this.tabListar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.White;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Image = global::Punto_de_Venta.Properties.Resources.j0432573;
            this.btnModificar.Location = new System.Drawing.Point(4, 219);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(136, 51);
            this.btnModificar.TabIndex = 35;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // txbFiltro
            // 
            this.txbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbFiltro.Location = new System.Drawing.Point(53, 9);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(152, 22);
            this.txbFiltro.TabIndex = 32;
            this.txbFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbFiltro_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filtro:";
            // 
            // dgvListado
            // 
            this.dgvListado.AllowUserToAddRows = false;
            this.dgvListado.AllowUserToDeleteRows = false;
            this.dgvListado.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListado.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvListado.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListado.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListado.BackgroundColor = System.Drawing.Color.White;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListado.Location = new System.Drawing.Point(4, 37);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.Size = new System.Drawing.Size(622, 175);
            this.dgvListado.TabIndex = 30;
            this.dgvListado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellDoubleClick);
            // 
            // tabModificar
            // 
            this.tabModificar.Controls.Add(this.label6);
            this.tabModificar.Controls.Add(this.txbCodigo);
            this.tabModificar.Controls.Add(this.label4);
            this.tabModificar.Controls.Add(this.cmbxMasMenos);
            this.tabModificar.Controls.Add(this.label5);
            this.tabModificar.Controls.Add(this.txbNombreMod);
            this.tabModificar.Controls.Add(this.btnGuardarMod);
            this.tabModificar.Location = new System.Drawing.Point(4, 24);
            this.tabModificar.Name = "tabModificar";
            this.tabModificar.Size = new System.Drawing.Size(630, 275);
            this.tabModificar.TabIndex = 3;
            this.tabModificar.Text = "Modificar";
            this.tabModificar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(252, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Codigo:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Enabled = false;
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(334, 15);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(64, 26);
            this.txbCodigo.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Operación Matematica:";
            // 
            // cmbxMasMenos
            // 
            this.cmbxMasMenos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxMasMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxMasMenos.FormattingEnabled = true;
            this.cmbxMasMenos.Items.AddRange(new object[] {
            "Sumar ( +)",
            "Restar ( - )"});
            this.cmbxMasMenos.Location = new System.Drawing.Point(334, 101);
            this.cmbxMasMenos.Name = "cmbxMasMenos";
            this.cmbxMasMenos.Size = new System.Drawing.Size(163, 28);
            this.cmbxMasMenos.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(252, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre:";
            // 
            // txbNombreMod
            // 
            this.txbNombreMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreMod.Location = new System.Drawing.Point(334, 57);
            this.txbNombreMod.Name = "txbNombreMod";
            this.txbNombreMod.Size = new System.Drawing.Size(163, 26);
            this.txbNombreMod.TabIndex = 11;
            // 
            // btnGuardarMod
            // 
            this.btnGuardarMod.BackColor = System.Drawing.Color.White;
            this.btnGuardarMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarMod.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardarMod.Location = new System.Drawing.Point(254, 190);
            this.btnGuardarMod.Name = "btnGuardarMod";
            this.btnGuardarMod.Size = new System.Drawing.Size(122, 69);
            this.btnGuardarMod.TabIndex = 7;
            this.btnGuardarMod.Text = "Guardar";
            this.btnGuardarMod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarMod.UseVisualStyleBackColor = false;
            this.btnGuardarMod.Click += new System.EventHandler(this.btnGuardarMod_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnSalir.Location = new System.Drawing.Point(524, 308);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 51);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(260, 7);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 36;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Frm_MantEgresoTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 372);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.tabControl1);
            this.Name = "Frm_MantEgresoTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_MantEgresoTipo";
            this.tabControl1.ResumeLayout(false);
            this.tabInsertar.ResumeLayout(false);
            this.tabInsertar.PerformLayout();
            this.tabListar.ResumeLayout(false);
            this.tabListar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tabModificar.ResumeLayout(false);
            this.tabModificar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabInsertar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxOperacionMat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.TabPage tabListar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TabPage tabModificar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.Button btnGuardarMod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbxMasMenos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNombreMod;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.Button btnBuscar;
    }
}