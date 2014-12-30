namespace Punto_de_Venta.Pantallas.Varias
{
    partial class Frm_Login
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
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnLicencia = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(171, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "REGISTRO DE USUARIO";
            // 
            // Cancelar
            // 
            this.Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancelar.Location = new System.Drawing.Point(360, 206);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(92, 43);
            this.Cancelar.TabIndex = 5;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(242, 206);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(92, 43);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txbNombre);
            this.panel1.Controls.Add(this.txbCodigo);
            this.panel1.Controls.Add(this.txbClave);
            this.panel1.Controls.Add(this.lblClave);
            this.panel1.Controls.Add(this.lblNombre);
            this.panel1.Location = new System.Drawing.Point(63, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(568, 129);
            this.panel1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(57, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Codigo:";
            // 
            // txbNombre
            // 
            this.txbNombre.BackColor = System.Drawing.Color.White;
            this.txbNombre.Enabled = false;
            this.txbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txbNombre.Location = new System.Drawing.Point(284, 23);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.ReadOnly = true;
            this.txbNombre.Size = new System.Drawing.Size(266, 26);
            this.txbNombre.TabIndex = 2;
            // 
            // txbCodigo
            // 
            this.txbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigo.Location = new System.Drawing.Point(133, 23);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(50, 26);
            this.txbCodigo.TabIndex = 1;
            this.txbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodigo_KeyPress);
            // 
            // txbClave
            // 
            this.txbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbClave.Location = new System.Drawing.Point(170, 76);
            this.txbClave.Name = "txbClave";
            this.txbClave.Size = new System.Drawing.Size(252, 26);
            this.txbClave.TabIndex = 3;
            this.txbClave.UseSystemPasswordChar = true;
            this.txbClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbClave_KeyPress);
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblClave.Location = new System.Drawing.Point(57, 79);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(107, 20);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Contraseña:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lblNombre.Location = new System.Drawing.Point(202, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // btnLicencia
            // 
            this.btnLicencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLicencia.Location = new System.Drawing.Point(581, 223);
            this.btnLicencia.Name = "btnLicencia";
            this.btnLicencia.Size = new System.Drawing.Size(92, 27);
            this.btnLicencia.TabIndex = 12;
            this.btnLicencia.Text = "Licencia";
            this.btnLicencia.UseVisualStyleBackColor = true;
            this.btnLicencia.Click += new System.EventHandler(this.btnLicencia_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancelar;
            this.ClientSize = new System.Drawing.Size(695, 262);
            this.Controls.Add(this.btnLicencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Usuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLicencia;
    }
}