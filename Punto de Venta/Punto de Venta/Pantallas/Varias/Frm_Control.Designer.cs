namespace Punto_de_Venta.Pantallas.Varias
{
    partial class Frm_Control
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
            this.pnlTipoCambio = new System.Windows.Forms.GroupBox();
            this.txbDolar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlEncadezado = new System.Windows.Forms.GroupBox();
            this.txbMsjFinal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDireccion = new System.Windows.Forms.TextBox();
            this.txbTelefono = new System.Windows.Forms.TextBox();
            this.txbCedula = new System.Windows.Forms.TextBox();
            this.txbEmpresa = new System.Windows.Forms.TextBox();
            this.txbPropietario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlTipoCambio.SuspendLayout();
            this.pnlEncadezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTipoCambio
            // 
            this.pnlTipoCambio.Controls.Add(this.txbDolar);
            this.pnlTipoCambio.Controls.Add(this.label6);
            this.pnlTipoCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlTipoCambio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.pnlTipoCambio.Location = new System.Drawing.Point(12, 297);
            this.pnlTipoCambio.Name = "pnlTipoCambio";
            this.pnlTipoCambio.Size = new System.Drawing.Size(344, 100);
            this.pnlTipoCambio.TabIndex = 0;
            this.pnlTipoCambio.TabStop = false;
            this.pnlTipoCambio.Text = "Tipo Cambio";
            // 
            // txbDolar
            // 
            this.txbDolar.Enabled = false;
            this.txbDolar.Location = new System.Drawing.Point(198, 42);
            this.txbDolar.Name = "txbDolar";
            this.txbDolar.Size = new System.Drawing.Size(116, 31);
            this.txbDolar.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tipo Cambio $ :";
            // 
            // pnlEncadezado
            // 
            this.pnlEncadezado.Controls.Add(this.txbMsjFinal);
            this.pnlEncadezado.Controls.Add(this.label7);
            this.pnlEncadezado.Controls.Add(this.txbDireccion);
            this.pnlEncadezado.Controls.Add(this.txbTelefono);
            this.pnlEncadezado.Controls.Add(this.txbCedula);
            this.pnlEncadezado.Controls.Add(this.txbEmpresa);
            this.pnlEncadezado.Controls.Add(this.txbPropietario);
            this.pnlEncadezado.Controls.Add(this.label5);
            this.pnlEncadezado.Controls.Add(this.label4);
            this.pnlEncadezado.Controls.Add(this.label3);
            this.pnlEncadezado.Controls.Add(this.label2);
            this.pnlEncadezado.Controls.Add(this.label1);
            this.pnlEncadezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlEncadezado.ForeColor = System.Drawing.Color.Navy;
            this.pnlEncadezado.Location = new System.Drawing.Point(12, 12);
            this.pnlEncadezado.Name = "pnlEncadezado";
            this.pnlEncadezado.Size = new System.Drawing.Size(900, 279);
            this.pnlEncadezado.TabIndex = 1;
            this.pnlEncadezado.TabStop = false;
            this.pnlEncadezado.Text = "Encabezado Factura";
            // 
            // txbMsjFinal
            // 
            this.txbMsjFinal.Enabled = false;
            this.txbMsjFinal.Location = new System.Drawing.Point(232, 228);
            this.txbMsjFinal.Name = "txbMsjFinal";
            this.txbMsjFinal.Size = new System.Drawing.Size(662, 26);
            this.txbMsjFinal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mensaje Final:";
            // 
            // txbDireccion
            // 
            this.txbDireccion.Enabled = false;
            this.txbDireccion.Location = new System.Drawing.Point(232, 190);
            this.txbDireccion.Name = "txbDireccion";
            this.txbDireccion.Size = new System.Drawing.Size(662, 26);
            this.txbDireccion.TabIndex = 9;
            // 
            // txbTelefono
            // 
            this.txbTelefono.Enabled = false;
            this.txbTelefono.Location = new System.Drawing.Point(232, 152);
            this.txbTelefono.Name = "txbTelefono";
            this.txbTelefono.Size = new System.Drawing.Size(662, 26);
            this.txbTelefono.TabIndex = 8;
            // 
            // txbCedula
            // 
            this.txbCedula.Enabled = false;
            this.txbCedula.Location = new System.Drawing.Point(232, 114);
            this.txbCedula.Name = "txbCedula";
            this.txbCedula.Size = new System.Drawing.Size(662, 26);
            this.txbCedula.TabIndex = 7;
            // 
            // txbEmpresa
            // 
            this.txbEmpresa.Enabled = false;
            this.txbEmpresa.Location = new System.Drawing.Point(232, 38);
            this.txbEmpresa.Name = "txbEmpresa";
            this.txbEmpresa.Size = new System.Drawing.Size(662, 26);
            this.txbEmpresa.TabIndex = 6;
            // 
            // txbPropietario
            // 
            this.txbPropietario.Enabled = false;
            this.txbPropietario.Location = new System.Drawing.Point(232, 76);
            this.txbPropietario.Name = "txbPropietario";
            this.txbPropietario.Size = new System.Drawing.Size(662, 26);
            this.txbPropietario.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(137, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dirección:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cedula Juridica:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Propietario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la Empresa:";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnSalir.Location = new System.Drawing.Point(785, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(127, 55);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.White;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Image = global::Punto_de_Venta.Properties.Resources.j0433851;
            this.btnGuardar.Location = new System.Drawing.Point(604, 342);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(135, 55);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::Punto_de_Venta.Properties.Resources.j0432573;
            this.btnEditar.Location = new System.Drawing.Point(432, 342);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(135, 55);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 429);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlEncadezado);
            this.Controls.Add(this.pnlTipoCambio);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control";
            this.Load += new System.EventHandler(this.Frm_Control_Load);
            this.pnlTipoCambio.ResumeLayout(false);
            this.pnlTipoCambio.PerformLayout();
            this.pnlEncadezado.ResumeLayout(false);
            this.pnlEncadezado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pnlTipoCambio;
        private System.Windows.Forms.TextBox txbDolar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox pnlEncadezado;
        private System.Windows.Forms.TextBox txbMsjFinal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDireccion;
        private System.Windows.Forms.TextBox txbTelefono;
        private System.Windows.Forms.TextBox txbCedula;
        private System.Windows.Forms.TextBox txbEmpresa;
        private System.Windows.Forms.TextBox txbPropietario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}