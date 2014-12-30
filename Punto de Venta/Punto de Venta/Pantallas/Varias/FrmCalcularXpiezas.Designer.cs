namespace Punto_de_Venta.Pantallas.Varias
{
    partial class Frm_CalcularXPiezas
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbCantiPiezas = new System.Windows.Forms.TextBox();
            this.txbLargo = new System.Windows.Forms.TextBox();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad Piezas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Largo varas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Varas";
            // 
            // txbCantiPiezas
            // 
            this.txbCantiPiezas.Location = new System.Drawing.Point(50, 94);
            this.txbCantiPiezas.Margin = new System.Windows.Forms.Padding(4);
            this.txbCantiPiezas.Name = "txbCantiPiezas";
            this.txbCantiPiezas.Size = new System.Drawing.Size(135, 31);
            this.txbCantiPiezas.TabIndex = 3;
            this.txbCantiPiezas.TextChanged += new System.EventHandler(this.txbCantiPiezas_TextChanged);
            this.txbCantiPiezas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbCantiPiezas_KeyPress);
            // 
            // txbLargo
            // 
            this.txbLargo.Location = new System.Drawing.Point(241, 91);
            this.txbLargo.Margin = new System.Windows.Forms.Padding(4);
            this.txbLargo.Name = "txbLargo";
            this.txbLargo.Size = new System.Drawing.Size(135, 31);
            this.txbLargo.TabIndex = 4;
            this.txbLargo.TextChanged += new System.EventHandler(this.txbLargo_TextChanged);
            this.txbLargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbLargo_KeyPress);
            // 
            // txbTotal
            // 
            this.txbTotal.BackColor = System.Drawing.Color.White;
            this.txbTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txbTotal.Location = new System.Drawing.Point(443, 91);
            this.txbTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(135, 31);
            this.txbTotal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(204, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(398, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "=";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Image = global::Punto_de_Venta.Properties.Resources.check24;
            this.btnAceptar.Location = new System.Drawing.Point(313, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(146, 43);
            this.btnAceptar.TabIndex = 8;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            this.btnAceptar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnAceptar_KeyPress);
            // 
            // button1
            // 
            this.button1.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.button1.Location = new System.Drawing.Point(136, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cancelar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_CalcularXPiezas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 218);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTotal);
            this.Controls.Add(this.txbLargo);
            this.Controls.Add(this.txbCantiPiezas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Frm_CalcularXPiezas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular por Piezas";
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbCantiPiezas;
        private System.Windows.Forms.TextBox txbLargo;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}