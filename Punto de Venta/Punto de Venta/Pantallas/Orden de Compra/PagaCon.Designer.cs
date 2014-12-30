namespace Punto_de_Venta.Pantallas.Orden_de_Compra
{
    partial class PagaCon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEfectivo = new System.Windows.Forms.TabPage();
            this.pnl_Efectivo = new System.Windows.Forms.Panel();
            this.lbl_Vuelto_Efectivo = new System.Windows.Forms.Label();
            this.lbl_Total_Efectivo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDolar1 = new System.Windows.Forms.TextBox();
            this.txbPagaCon1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnListo = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabEfectivo.SuspendLayout();
            this.pnl_Efectivo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEfectivo);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 22);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 249);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 147;
            // 
            // tabEfectivo
            // 
            this.tabEfectivo.Controls.Add(this.pnl_Efectivo);
            this.tabEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEfectivo.ForeColor = System.Drawing.Color.Maroon;
            this.tabEfectivo.Location = new System.Drawing.Point(4, 29);
            this.tabEfectivo.Name = "tabEfectivo";
            this.tabEfectivo.Padding = new System.Windows.Forms.Padding(3);
            this.tabEfectivo.Size = new System.Drawing.Size(799, 216);
            this.tabEfectivo.TabIndex = 0;
            this.tabEfectivo.Text = "EFECTIVO";
            this.tabEfectivo.UseVisualStyleBackColor = true;
            // 
            // pnl_Efectivo
            // 
            this.pnl_Efectivo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl_Efectivo.Controls.Add(this.lbl_Vuelto_Efectivo);
            this.pnl_Efectivo.Controls.Add(this.lbl_Total_Efectivo);
            this.pnl_Efectivo.Controls.Add(this.label3);
            this.pnl_Efectivo.Controls.Add(this.btnConvertir);
            this.pnl_Efectivo.Controls.Add(this.label1);
            this.pnl_Efectivo.Controls.Add(this.txbDolar1);
            this.pnl_Efectivo.Controls.Add(this.txbPagaCon1);
            this.pnl_Efectivo.Controls.Add(this.label2);
            this.pnl_Efectivo.Controls.Add(this.lblTotal);
            this.pnl_Efectivo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Efectivo.Name = "pnl_Efectivo";
            this.pnl_Efectivo.Size = new System.Drawing.Size(796, 216);
            this.pnl_Efectivo.TabIndex = 0;
            // 
            // lbl_Vuelto_Efectivo
            // 
            this.lbl_Vuelto_Efectivo.AutoSize = true;
            this.lbl_Vuelto_Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Vuelto_Efectivo.ForeColor = System.Drawing.Color.Magenta;
            this.lbl_Vuelto_Efectivo.Location = new System.Drawing.Point(268, 147);
            this.lbl_Vuelto_Efectivo.Name = "lbl_Vuelto_Efectivo";
            this.lbl_Vuelto_Efectivo.Size = new System.Drawing.Size(94, 55);
            this.lbl_Vuelto_Efectivo.TabIndex = 13;
            this.lbl_Vuelto_Efectivo.Text = "0.0";
            // 
            // lbl_Total_Efectivo
            // 
            this.lbl_Total_Efectivo.AutoSize = true;
            this.lbl_Total_Efectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total_Efectivo.ForeColor = System.Drawing.Color.Red;
            this.lbl_Total_Efectivo.Location = new System.Drawing.Point(268, 10);
            this.lbl_Total_Efectivo.Name = "lbl_Total_Efectivo";
            this.lbl_Total_Efectivo.Size = new System.Drawing.Size(94, 55);
            this.lbl_Total_Efectivo.TabIndex = 12;
            this.lbl_Total_Efectivo.Text = "0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Magenta;
            this.label3.Location = new System.Drawing.Point(11, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(251, 55);
            this.label3.TabIndex = 10;
            this.label3.Text = "VUELTO=";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(595, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "$ =";
            // 
            // txbDolar1
            // 
            this.txbDolar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDolar1.ForeColor = System.Drawing.Color.DarkGreen;
            this.txbDolar1.Location = new System.Drawing.Point(669, 79);
            this.txbDolar1.Name = "txbDolar1";
            this.txbDolar1.Size = new System.Drawing.Size(123, 47);
            this.txbDolar1.TabIndex = 7;
            this.txbDolar1.TextChanged += new System.EventHandler(this.txbDolar1_TextChanged);
            this.txbDolar1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDolar1_KeyPress);
            // 
            // txbPagaCon1
            // 
            this.txbPagaCon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPagaCon1.ForeColor = System.Drawing.Color.DarkBlue;
            this.txbPagaCon1.Location = new System.Drawing.Point(233, 79);
            this.txbPagaCon1.Name = "txbPagaCon1";
            this.txbPagaCon1.Size = new System.Drawing.Size(239, 47);
            this.txbPagaCon1.TabIndex = 4;
            this.txbPagaCon1.TextChanged += new System.EventHandler(this.txbPagaCon1_TextChanged);
            this.txbPagaCon1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbPagaCon1_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(4, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "PAGA CON=";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(50, 10);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(212, 55);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "TOTAL=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnListo);
            this.groupBox1.Location = new System.Drawing.Point(244, 277);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 85);
            this.groupBox1.TabIndex = 146;
            this.groupBox1.TabStop = false;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Enabled = false;
            this.btnConvertir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertir.Image = global::Punto_de_Venta.Properties.Resources.dollar_currency_sign1;
            this.btnConvertir.Location = new System.Drawing.Point(478, 79);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(113, 47);
            this.btnConvertir.TabIndex = 9;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnCancelar.Location = new System.Drawing.Point(37, 14);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(111, 63);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnListo
            // 
            this.btnListo.BackColor = System.Drawing.Color.White;
            this.btnListo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListo.Image = global::Punto_de_Venta.Properties.Resources.check24;
            this.btnListo.Location = new System.Drawing.Point(195, 14);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(111, 63);
            this.btnListo.TabIndex = 0;
            this.btnListo.Text = "Listo";
            this.btnListo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListo.UseVisualStyleBackColor = false;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // PagaCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 376);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "PagaCon";
            this.Text = "PagaCon";
            this.tabControl1.ResumeLayout(false);
            this.tabEfectivo.ResumeLayout(false);
            this.pnl_Efectivo.ResumeLayout(false);
            this.pnl_Efectivo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEfectivo;
        private System.Windows.Forms.Panel pnl_Efectivo;
        private System.Windows.Forms.Label lbl_Vuelto_Efectivo;
        private System.Windows.Forms.Label lbl_Total_Efectivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDolar1;
        private System.Windows.Forms.TextBox txbPagaCon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}