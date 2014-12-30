namespace Punto_de_Venta.Pantallas.Credito
{
    partial class Frm_CancelarFacturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CancelarFacturas));
            this.dgvListadoHistorial = new System.Windows.Forms.DataGridView();
            this.lvItems = new System.Windows.Forms.ListView();
            this.NumFact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClieNom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Total = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPasarDtabla = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelarFactura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoHistorial)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListadoHistorial
            // 
            this.dgvListadoHistorial.AllowUserToAddRows = false;
            this.dgvListadoHistorial.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvListadoHistorial.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListadoHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvListadoHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoHistorial.BackgroundColor = System.Drawing.Color.White;
            this.dgvListadoHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoHistorial.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoHistorial.Location = new System.Drawing.Point(13, 52);
            this.dgvListadoHistorial.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListadoHistorial.MultiSelect = false;
            this.dgvListadoHistorial.Name = "dgvListadoHistorial";
            this.dgvListadoHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoHistorial.Size = new System.Drawing.Size(516, 392);
            this.dgvListadoHistorial.TabIndex = 26;
            this.dgvListadoHistorial.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListadoHistorial_CellDoubleClick);
            // 
            // lvItems
            // 
            this.lvItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lvItems.BackColor = System.Drawing.Color.White;
            this.lvItems.CheckBoxes = true;
            this.lvItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NumFact,
            this.ClieNom,
            this.Total});
            this.lvItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvItems.FullRowSelect = true;
            this.lvItems.Location = new System.Drawing.Point(632, 52);
            this.lvItems.Name = "lvItems";
            this.lvItems.Size = new System.Drawing.Size(514, 392);
            this.lvItems.TabIndex = 143;
            this.lvItems.UseCompatibleStateImageBehavior = false;
            this.lvItems.View = System.Windows.Forms.View.Details;
            // 
            // NumFact
            // 
            this.NumFact.Text = "FACT #";
            this.NumFact.Width = 75;
            // 
            // ClieNom
            // 
            this.ClieNom.Text = "Cliente";
            this.ClieNom.Width = 300;
            // 
            // Total
            // 
            this.Total.Text = "Total";
            this.Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Total.Width = 130;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(162, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 145;
            this.label1.Text = "Lista de Facturas a Credito";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(808, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 16);
            this.label2.TabIndex = 146;
            this.label2.Text = "Lista de Facturas a Cancelar";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(875, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 25);
            this.label3.TabIndex = 147;
            this.label3.Text = "Total:";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(953, 454);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(193, 31);
            this.textBox1.TabIndex = 148;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnPasarDtabla);
            this.panel1.Location = new System.Drawing.Point(536, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 392);
            this.panel1.TabIndex = 149;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.Image = global::Punto_de_Venta.Properties.Resources.flecha;
            this.button1.Location = new System.Drawing.Point(3, 222);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 43);
            this.button1.TabIndex = 145;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPasarDtabla
            // 
            this.btnPasarDtabla.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPasarDtabla.BackColor = System.Drawing.Color.White;
            this.btnPasarDtabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPasarDtabla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPasarDtabla.Image = global::Punto_de_Venta.Properties.Resources.flecha_derecha_abajo;
            this.btnPasarDtabla.Location = new System.Drawing.Point(3, 155);
            this.btnPasarDtabla.Name = "btnPasarDtabla";
            this.btnPasarDtabla.Size = new System.Drawing.Size(80, 49);
            this.btnPasarDtabla.TabIndex = 144;
            this.btnPasarDtabla.UseVisualStyleBackColor = false;
            this.btnPasarDtabla.Click += new System.EventHandler(this.btnPasarDtabla_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(632, 496);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(130, 51);
            this.btnSalir.TabIndex = 150;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelarFactura
            // 
            this.btnCancelarFactura.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancelarFactura.BackColor = System.Drawing.Color.White;
            this.btnCancelarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFactura.ForeColor = System.Drawing.Color.Black;
            this.btnCancelarFactura.Image = global::Punto_de_Venta.Properties.Resources.check241;
            this.btnCancelarFactura.Location = new System.Drawing.Point(399, 496);
            this.btnCancelarFactura.Name = "btnCancelarFactura";
            this.btnCancelarFactura.Size = new System.Drawing.Size(130, 51);
            this.btnCancelarFactura.TabIndex = 151;
            this.btnCancelarFactura.Text = "Realizar Cancelación";
            this.btnCancelarFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelarFactura.UseVisualStyleBackColor = false;
            this.btnCancelarFactura.Click += new System.EventHandler(this.btnCancelarFactura_Click);
            // 
            // Frm_CancelarFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 559);
            this.Controls.Add(this.btnCancelarFactura);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvItems);
            this.Controls.Add(this.dgvListadoHistorial);
            this.Name = "Frm_CancelarFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cancelar Facturas";
            this.Load += new System.EventHandler(this.Frm_CancelarFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoHistorial)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListadoHistorial;
        private System.Windows.Forms.ListView lvItems;
        private System.Windows.Forms.ColumnHeader NumFact;
        private System.Windows.Forms.ColumnHeader ClieNom;
        private System.Windows.Forms.ColumnHeader Total;
        private System.Windows.Forms.Button btnPasarDtabla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelarFactura;
    }
}