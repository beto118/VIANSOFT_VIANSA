namespace Punto_de_Venta.Pantallas.Usuarios
{
    partial class Frm_RegistroHoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistroHoras));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbCodigo = new System.Windows.Forms.TextBox();
            this.txbNombre = new System.Windows.Forms.TextBox();
            this.lblHoraActual = new System.Windows.Forms.Label();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnSalida = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // txbCodigo
            // 
            this.txbCodigo.Location = new System.Drawing.Point(154, 106);
            this.txbCodigo.Name = "txbCodigo";
            this.txbCodigo.Size = new System.Drawing.Size(164, 26);
            this.txbCodigo.TabIndex = 3;
            this.txbCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCodigo_KeyPress);
            // 
            // txbNombre
            // 
            this.txbNombre.Location = new System.Drawing.Point(154, 155);
            this.txbNombre.Name = "txbNombre";
            this.txbNombre.Size = new System.Drawing.Size(304, 26);
            this.txbNombre.TabIndex = 4;
            // 
            // lblHoraActual
            // 
            this.lblHoraActual.AutoSize = true;
            this.lblHoraActual.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoraActual.ForeColor = System.Drawing.Color.Blue;
            this.lblHoraActual.Location = new System.Drawing.Point(94, 27);
            this.lblHoraActual.Name = "lblHoraActual";
            this.lblHoraActual.Size = new System.Drawing.Size(387, 58);
            this.lblHoraActual.TabIndex = 5;
            this.lblHoraActual.Text = "REGISTRO DE HORAS DE\r\n     ENTRADA Y SALIDA ";
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.White;
            this.btnEntrada.Image = ((System.Drawing.Image)(resources.GetObject("btnEntrada.Image")));
            this.btnEntrada.Location = new System.Drawing.Point(147, 202);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(280, 85);
            this.btnEntrada.TabIndex = 6;
            this.btnEntrada.Text = "Registrar la hora de entrada";
            this.btnEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Visible = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.White;
            this.btnSalida.Image = ((System.Drawing.Image)(resources.GetObject("btnSalida.Image")));
            this.btnSalida.Location = new System.Drawing.Point(147, 215);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(280, 81);
            this.btnSalida.TabIndex = 7;
            this.btnSalida.Text = "Registrar la hora de Salida";
            this.btnSalida.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Visible = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
          
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_RegistroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 318);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnEntrada);
            this.Controls.Add(this.lblHoraActual);
            this.Controls.Add(this.txbNombre);
            this.Controls.Add(this.txbCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Frm_RegistroHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de horas";
            
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbCodigo;
        private System.Windows.Forms.TextBox txbNombre;
        private System.Windows.Forms.Label lblHoraActual;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}