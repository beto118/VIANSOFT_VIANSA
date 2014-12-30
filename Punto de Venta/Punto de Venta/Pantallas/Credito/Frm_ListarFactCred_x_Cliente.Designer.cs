namespace Punto_de_Venta.Pantallas.Credito
{
    partial class Frm_ListarFactCred_x_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ckSaldo = new System.Windows.Forms.CheckBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabHistorial = new System.Windows.Forms.TabPage();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvListadoHistorial = new System.Windows.Forms.DataGridView();
            this.tabHoy = new System.Windows.Forms.TabPage();
            this.dgvListadoHoy = new System.Windows.Forms.DataGridView();
            this.btnCancelarFacts = new System.Windows.Forms.Button();
            this.btnRealizarAbono = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoHistorial)).BeginInit();
            this.tabHoy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoHoy)).BeginInit();
            this.SuspendLayout();
            // 
            // ckSaldo
            // 
            this.ckSaldo.AutoSize = true;
            this.ckSaldo.Checked = true;
            this.ckSaldo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckSaldo.Location = new System.Drawing.Point(447, 108);
            this.ckSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.ckSaldo.Name = "ckSaldo";
            this.ckSaldo.Size = new System.Drawing.Size(149, 24);
            this.ckSaldo.TabIndex = 31;
            this.ckSaldo.Text = "Solo con Saldo";
            this.ckSaldo.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(308, 101);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(116, 33);
            this.btnBuscar.TabIndex = 29;
            this.btnBuscar.Text = "...";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 109);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Filtro:";
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(76, 106);
            this.txbFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(207, 26);
            this.txbFiltro.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(249, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 45);
            this.label1.TabIndex = 35;
            this.label1.Text = "Lista de Facturas a credito";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabHistorial);
            this.tabControl1.Controls.Add(this.tabHoy);
            this.tabControl1.Location = new System.Drawing.Point(17, 149);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(848, 282);
            this.tabControl1.TabIndex = 37;
            // 
            // tabHistorial
            // 
            this.tabHistorial.Controls.Add(this.txbTotal);
            this.tabHistorial.Controls.Add(this.label2);
            this.tabHistorial.Controls.Add(this.dgvListadoHistorial);
            this.tabHistorial.Location = new System.Drawing.Point(4, 29);
            this.tabHistorial.Name = "tabHistorial";
            this.tabHistorial.Padding = new System.Windows.Forms.Padding(3);
            this.tabHistorial.Size = new System.Drawing.Size(840, 249);
            this.tabHistorial.TabIndex = 0;
            this.tabHistorial.Text = "Del historial";
            this.tabHistorial.UseVisualStyleBackColor = true;
            // 
            // txbTotal
            // 
            this.txbTotal.Location = new System.Drawing.Point(654, 217);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.Size = new System.Drawing.Size(179, 26);
            this.txbTotal.TabIndex = 27;
            this.txbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(594, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Total:";
            // 
            // dgvListadoHistorial
            // 
            this.dgvListadoHistorial.AllowUserToAddRows = false;
            this.dgvListadoHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListadoHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListadoHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoHistorial.Location = new System.Drawing.Point(7, 7);
            this.dgvListadoHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoHistorial.MultiSelect = false;
            this.dgvListadoHistorial.Name = "dgvListadoHistorial";
            this.dgvListadoHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoHistorial.Size = new System.Drawing.Size(826, 207);
            this.dgvListadoHistorial.TabIndex = 25;
            this.dgvListadoHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoHistorial_CellDoubleClick);
            // 
            // tabHoy
            // 
            this.tabHoy.Controls.Add(this.dgvListadoHoy);
            this.tabHoy.Location = new System.Drawing.Point(4, 29);
            this.tabHoy.Name = "tabHoy";
            this.tabHoy.Padding = new System.Windows.Forms.Padding(3);
            this.tabHoy.Size = new System.Drawing.Size(840, 249);
            this.tabHoy.TabIndex = 1;
            this.tabHoy.Text = "Hoy";
            this.tabHoy.UseVisualStyleBackColor = true;
            // 
            // dgvListadoHoy
            // 
            this.dgvListadoHoy.AllowUserToAddRows = false;
            this.dgvListadoHoy.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListadoHoy.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListadoHoy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvListadoHoy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoHoy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoHoy.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoHoy.Location = new System.Drawing.Point(7, 7);
            this.dgvListadoHoy.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoHoy.MultiSelect = false;
            this.dgvListadoHoy.Name = "dgvListadoHoy";
            this.dgvListadoHoy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoHoy.Size = new System.Drawing.Size(826, 235);
            this.dgvListadoHoy.TabIndex = 26;
            this.dgvListadoHoy.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoHoy_CellClick);
            // 
            // btnCancelarFacts
            // 
            this.btnCancelarFacts.BackColor = System.Drawing.Color.White;
            this.btnCancelarFacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFacts.Image = global::Punto_de_Venta.Properties.Resources.factura_icono;
            this.btnCancelarFacts.Location = new System.Drawing.Point(377, 438);
            this.btnCancelarFacts.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFacts.Name = "btnCancelarFacts";
            this.btnCancelarFacts.Size = new System.Drawing.Size(179, 63);
            this.btnCancelarFacts.TabIndex = 39;
            this.btnCancelarFacts.Text = "Generar Reporte";
            this.btnCancelarFacts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarFacts.UseVisualStyleBackColor = false;
            this.btnCancelarFacts.Click += new System.EventHandler(this.btnCancelarFacts_Click);
            // 
            // btnRealizarAbono
            // 
            this.btnRealizarAbono.BackColor = System.Drawing.Color.White;
            this.btnRealizarAbono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRealizarAbono.Image = global::Punto_de_Venta.Properties.Resources.recibo_icon;
            this.btnRealizarAbono.Location = new System.Drawing.Point(21, 438);
            this.btnRealizarAbono.Margin = new System.Windows.Forms.Padding(4);
            this.btnRealizarAbono.Name = "btnRealizarAbono";
            this.btnRealizarAbono.Size = new System.Drawing.Size(163, 63);
            this.btnRealizarAbono.TabIndex = 38;
            this.btnRealizarAbono.Text = "Realizar Abono";
            this.btnRealizarAbono.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRealizarAbono.UseVisualStyleBackColor = false;
            this.btnRealizarAbono.Click += new System.EventHandler(this.btnRealizarAbono_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(698, 438);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(163, 63);
            this.btnCancelar.TabIndex = 36;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Frm_ListarFactCred_x_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 514);
            this.Controls.Add(this.btnCancelarFacts);
            this.Controls.Add(this.btnRealizarAbono);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ckSaldo);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbFiltro);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_ListarFactCred_x_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de facturas a credito por cliente";
            this.tabControl1.ResumeLayout(false);
            this.tabHistorial.ResumeLayout(false);
            this.tabHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoHistorial)).EndInit();
            this.tabHoy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoHoy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ckSaldo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabHistorial;
        private System.Windows.Forms.DataGridView dgvListadoHistorial;
        private System.Windows.Forms.TabPage tabHoy;
        private System.Windows.Forms.DataGridView dgvListadoHoy;
        private System.Windows.Forms.Button btnRealizarAbono;
        private System.Windows.Forms.Button btnCancelarFacts;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label2;
    }
}