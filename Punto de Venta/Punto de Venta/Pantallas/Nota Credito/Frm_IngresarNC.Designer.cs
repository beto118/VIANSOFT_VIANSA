namespace Punto_de_Venta.Pantallas.Nota_Credito
{
    partial class Frm_IngresarNC
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.txbMonto = new System.Windows.Forms.TextBox();
            this.lblUsuarioID = new System.Windows.Forms.Label();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.txbDetalle = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbCodigoCliente = new System.Windows.Forms.TextBox();
            this.txbNombreCliente = new System.Windows.Forms.TextBox();
            this.BtnBuscarClientes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nota número:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 345);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Monto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Detalle:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(100, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Estado:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(180, 39);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(94, 26);
            this.txbID.TabIndex = 6;
            // 
            // txbMonto
            // 
            this.txbMonto.Location = new System.Drawing.Point(180, 150);
            this.txbMonto.Name = "txbMonto";
            this.txbMonto.Size = new System.Drawing.Size(127, 26);
            this.txbMonto.TabIndex = 8;
            // 
            // lblUsuarioID
            // 
            this.lblUsuarioID.AutoSize = true;
            this.lblUsuarioID.Location = new System.Drawing.Point(177, 345);
            this.lblUsuarioID.Name = "lblUsuarioID";
            this.lblUsuarioID.Size = new System.Drawing.Size(19, 20);
            this.lblUsuarioID.TabIndex = 9;
            this.lblUsuarioID.Text = "1";
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Checked = true;
            this.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEstado.Location = new System.Drawing.Point(180, 301);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(77, 24);
            this.chkEstado.TabIndex = 10;
            this.chkEstado.Text = "Activo";
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // txbDetalle
            // 
            this.txbDetalle.Location = new System.Drawing.Point(180, 191);
            this.txbDetalle.Name = "txbDetalle";
            this.txbDetalle.Size = new System.Drawing.Size(391, 92);
            this.txbDetalle.TabIndex = 11;
            this.txbDetalle.Text = "";
            // 
            // btnGuardar
            // 
            this.btnGuardar.ForeColor = System.Drawing.Color.Green;
            this.btnGuardar.Location = new System.Drawing.Point(324, 403);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 49);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(432, 403);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 49);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.ForeColor = System.Drawing.Color.Blue;
            this.btnImprimir.Location = new System.Drawing.Point(210, 403);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(91, 49);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.elErrorProvider.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Cliente Id:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nombre:";
            // 
            // txbCodigoCliente
            // 
            this.txbCodigoCliente.Location = new System.Drawing.Point(180, 89);
            this.txbCodigoCliente.Name = "txbCodigoCliente";
            this.txbCodigoCliente.Size = new System.Drawing.Size(51, 26);
            this.txbCodigoCliente.TabIndex = 17;
            // 
            // txbNombreCliente
            // 
            this.txbNombreCliente.Location = new System.Drawing.Point(322, 89);
            this.txbNombreCliente.Name = "txbNombreCliente";
            this.txbNombreCliente.Size = new System.Drawing.Size(312, 26);
            this.txbNombreCliente.TabIndex = 18;
            // 
            // BtnBuscarClientes
            // 
            this.BtnBuscarClientes.Location = new System.Drawing.Point(640, 89);
            this.BtnBuscarClientes.Name = "BtnBuscarClientes";
            this.BtnBuscarClientes.Size = new System.Drawing.Size(80, 26);
            this.BtnBuscarClientes.TabIndex = 19;
            this.BtnBuscarClientes.Text = "Buscar";
            this.BtnBuscarClientes.UseVisualStyleBackColor = true;
            this.BtnBuscarClientes.Click += new System.EventHandler(this.BtnBuscarClientes_Click);
            // 
            // Frm_IngresarNC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 466);
            this.Controls.Add(this.BtnBuscarClientes);
            this.Controls.Add(this.txbNombreCliente);
            this.Controls.Add(this.txbCodigoCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txbDetalle);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.lblUsuarioID);
            this.Controls.Add(this.txbMonto);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_IngresarNC";
            this.Text = "Frm_IngresarNC";
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.TextBox txbMonto;
        private System.Windows.Forms.Label lblUsuarioID;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.RichTextBox txbDetalle;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.Button BtnBuscarClientes;
        private System.Windows.Forms.TextBox txbNombreCliente;
        private System.Windows.Forms.TextBox txbCodigoCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
    }
}