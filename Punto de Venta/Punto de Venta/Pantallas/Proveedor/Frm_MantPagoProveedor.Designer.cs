namespace Punto_de_Venta.Pantallas.Proveedor
{
    partial class Frm_MantPagoProveedor
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
            this.label5 = new System.Windows.Forms.Label();
            this.txbDetalle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpFecha = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSaldoNuevo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbAbono = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSaldo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 60);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Detalle";
            // 
            // txbDetalle
            // 
            this.txbDetalle.Location = new System.Drawing.Point(461, 44);
            this.txbDetalle.Margin = new System.Windows.Forms.Padding(4);
            this.txbDetalle.Multiline = true;
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(284, 63);
            this.txbDetalle.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fecha";
            // 
            // dpFecha
            // 
            this.dpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpFecha.Location = new System.Drawing.Point(461, 8);
            this.dpFecha.Margin = new System.Windows.Forms.Padding(4);
            this.dpFecha.Name = "dpFecha";
            this.dpFecha.Size = new System.Drawing.Size(145, 22);
            this.dpFecha.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Saldo Nuevo";
            // 
            // txbSaldoNuevo
            // 
            this.txbSaldoNuevo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSaldoNuevo.Location = new System.Drawing.Point(134, 87);
            this.txbSaldoNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaldoNuevo.Name = "txbSaldoNuevo";
            this.txbSaldoNuevo.ReadOnly = true;
            this.txbSaldoNuevo.Size = new System.Drawing.Size(153, 22);
            this.txbSaldoNuevo.TabIndex = 26;
            this.txbSaldoNuevo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "Abono";
            // 
            // txbAbono
            // 
            this.txbAbono.Location = new System.Drawing.Point(134, 50);
            this.txbAbono.Margin = new System.Windows.Forms.Padding(4);
            this.txbAbono.Name = "txbAbono";
            this.txbAbono.Size = new System.Drawing.Size(153, 22);
            this.txbAbono.TabIndex = 24;
            this.txbAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbAbono.TextChanged += new System.EventHandler(this.txbAbono_TextChanged);
            this.txbAbono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbAbono_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Saldo";
            // 
            // txbSaldo
            // 
            this.txbSaldo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txbSaldo.Location = new System.Drawing.Point(134, 13);
            this.txbSaldo.Margin = new System.Windows.Forms.Padding(4);
            this.txbSaldo.Name = "txbSaldo";
            this.txbSaldo.ReadOnly = true;
            this.txbSaldo.Size = new System.Drawing.Size(153, 22);
            this.txbSaldo.TabIndex = 22;
            this.txbSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Location = new System.Drawing.Point(29, 138);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(686, 116);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardar.Location = new System.Drawing.Point(16, 26);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(217, 78);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(432, 25);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(217, 78);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_MantPagoProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 274);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbDetalle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dpFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbSaldoNuevo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbAbono);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSaldo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_MantPagoProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pago Proveedor";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDetalle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpFecha;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbSaldoNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbAbono;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSaldo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}