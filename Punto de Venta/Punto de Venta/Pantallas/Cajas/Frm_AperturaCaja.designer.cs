namespace Punto_de_Venta.Pantallas.Cajas
{
    partial class Frm_AperturaCaja
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txbTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txb500 = new System.Windows.Forms.TextBox();
            this.txb100 = new System.Windows.Forms.TextBox();
            this.txb50 = new System.Windows.Forms.TextBox();
            this.txb25 = new System.Windows.Forms.TextBox();
            this.txb10 = new System.Windows.Forms.TextBox();
            this.txb5 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txb50000 = new System.Windows.Forms.TextBox();
            this.txb20000 = new System.Windows.Forms.TextBox();
            this.txb10000 = new System.Windows.Forms.TextBox();
            this.txb5000 = new System.Windows.Forms.TextBox();
            this.txb2000 = new System.Windows.Forms.TextBox();
            this.txb1000 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txbTotalAperturaCaja = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnRegistrarApertura = new System.Windows.Forms.Button();
            this.elErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(524, 366);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txbTotal);
            this.tabPage1.Controls.Add(this.btnCalcularTotal);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(516, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Por unidades";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txbTotal
            // 
            this.txbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotal.Location = new System.Drawing.Point(309, 284);
            this.txbTotal.Name = "txbTotal";
            this.txbTotal.ReadOnly = true;
            this.txbTotal.Size = new System.Drawing.Size(171, 31);
            this.txbTotal.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(225, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 25);
            this.label13.TabIndex = 16;
            this.label13.Text = "Total=";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txb500);
            this.groupBox1.Controls.Add(this.txb100);
            this.groupBox1.Controls.Add(this.txb50);
            this.groupBox1.Controls.Add(this.txb25);
            this.groupBox1.Controls.Add(this.txb10);
            this.groupBox1.Controls.Add(this.txb5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 262);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total de Monedas";
            // 
            // txb500
            // 
            this.txb500.Location = new System.Drawing.Point(67, 226);
            this.txb500.Name = "txb500";
            this.txb500.Size = new System.Drawing.Size(100, 20);
            this.txb500.TabIndex = 18;
            this.txb500.Text = "0";
            // 
            // txb100
            // 
            this.txb100.Location = new System.Drawing.Point(67, 186);
            this.txb100.Name = "txb100";
            this.txb100.Size = new System.Drawing.Size(100, 20);
            this.txb100.TabIndex = 17;
            this.txb100.Text = "0";
            // 
            // txb50
            // 
            this.txb50.Location = new System.Drawing.Point(67, 149);
            this.txb50.Name = "txb50";
            this.txb50.Size = new System.Drawing.Size(100, 20);
            this.txb50.TabIndex = 16;
            this.txb50.Text = "0";
            // 
            // txb25
            // 
            this.txb25.Location = new System.Drawing.Point(67, 106);
            this.txb25.Name = "txb25";
            this.txb25.Size = new System.Drawing.Size(100, 20);
            this.txb25.TabIndex = 15;
            this.txb25.Text = "0";
            // 
            // txb10
            // 
            this.txb10.Location = new System.Drawing.Point(67, 69);
            this.txb10.Name = "txb10";
            this.txb10.Size = new System.Drawing.Size(100, 20);
            this.txb10.TabIndex = 14;
            this.txb10.Text = "0";
            // 
            // txb5
            // 
            this.txb5.Location = new System.Drawing.Point(67, 29);
            this.txb5.Name = "txb5";
            this.txb5.Size = new System.Drawing.Size(100, 20);
            this.txb5.TabIndex = 13;
            this.txb5.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "5=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "10=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "25=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "50=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "100=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "500=";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txb50000);
            this.groupBox2.Controls.Add(this.txb20000);
            this.groupBox2.Controls.Add(this.txb10000);
            this.groupBox2.Controls.Add(this.txb5000);
            this.groupBox2.Controls.Add(this.txb2000);
            this.groupBox2.Controls.Add(this.txb1000);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(284, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 262);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Total de Billetes";
            // 
            // txb50000
            // 
            this.txb50000.Location = new System.Drawing.Point(76, 226);
            this.txb50000.Name = "txb50000";
            this.txb50000.Size = new System.Drawing.Size(100, 20);
            this.txb50000.TabIndex = 18;
            this.txb50000.Text = "0";
            // 
            // txb20000
            // 
            this.txb20000.Location = new System.Drawing.Point(76, 186);
            this.txb20000.Name = "txb20000";
            this.txb20000.Size = new System.Drawing.Size(100, 20);
            this.txb20000.TabIndex = 17;
            this.txb20000.Text = "0";
            // 
            // txb10000
            // 
            this.txb10000.Location = new System.Drawing.Point(76, 149);
            this.txb10000.Name = "txb10000";
            this.txb10000.Size = new System.Drawing.Size(100, 20);
            this.txb10000.TabIndex = 16;
            this.txb10000.Text = "0";
            // 
            // txb5000
            // 
            this.txb5000.Location = new System.Drawing.Point(76, 106);
            this.txb5000.Name = "txb5000";
            this.txb5000.Size = new System.Drawing.Size(100, 20);
            this.txb5000.TabIndex = 15;
            this.txb5000.Text = "0";
            // 
            // txb2000
            // 
            this.txb2000.Location = new System.Drawing.Point(76, 69);
            this.txb2000.Name = "txb2000";
            this.txb2000.Size = new System.Drawing.Size(100, 20);
            this.txb2000.TabIndex = 14;
            this.txb2000.Text = "0";
            // 
            // txb1000
            // 
            this.txb1000.Location = new System.Drawing.Point(76, 29);
            this.txb1000.Name = "txb1000";
            this.txb1000.Size = new System.Drawing.Size(100, 20);
            this.txb1000.TabIndex = 13;
            this.txb1000.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "1000=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "2000=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "5000=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "10.000=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "20.000=";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "50.000=";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txbTotalAperturaCaja);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(516, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Total";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txbTotalAperturaCaja
            // 
            this.txbTotalAperturaCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTotalAperturaCaja.Location = new System.Drawing.Point(233, 153);
            this.txbTotalAperturaCaja.Name = "txbTotalAperturaCaja";
            this.txbTotalAperturaCaja.Size = new System.Drawing.Size(225, 35);
            this.txbTotalAperturaCaja.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(211, 48);
            this.label14.TabIndex = 0;
            this.label14.Text = "Digite el Total de \r\nla apertura de la caja:";
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.BackColor = System.Drawing.Color.White;
            this.btnCalcularTotal.Image = global::Punto_de_Venta.Properties.Resources.why18;
            this.btnCalcularTotal.Location = new System.Drawing.Point(6, 281);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(196, 41);
            this.btnCalcularTotal.TabIndex = 18;
            this.btnCalcularTotal.Text = "Calcular Total";
            this.btnCalcularTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcularTotal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcularTotal.UseVisualStyleBackColor = false;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.White;
            this.btnSalir.Image = global::Punto_de_Venta.Properties.Resources.fmaic_printorganizer_delete;
            this.btnSalir.Location = new System.Drawing.Point(445, 384);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(91, 41);
            this.btnSalir.TabIndex = 25;
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnRegistrarApertura
            // 
            this.btnRegistrarApertura.BackColor = System.Drawing.Color.White;
            this.btnRegistrarApertura.Image = global::Punto_de_Venta.Properties.Resources.thumb_nx_5400;
            this.btnRegistrarApertura.Location = new System.Drawing.Point(12, 384);
            this.btnRegistrarApertura.Name = "btnRegistrarApertura";
            this.btnRegistrarApertura.Size = new System.Drawing.Size(141, 41);
            this.btnRegistrarApertura.TabIndex = 24;
            this.btnRegistrarApertura.Text = "Registrar Apertura";
            this.btnRegistrarApertura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrarApertura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarApertura.UseVisualStyleBackColor = false;
            this.btnRegistrarApertura.Click += new System.EventHandler(this.btnRegistrarApertura_Click);
            // 
            // elErrorProvider
            // 
            this.elErrorProvider.ContainerControl = this;
            // 
            // Frm_AperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 437);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegistrarApertura);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "Frm_AperturaCaja";
            this.Text = "Frm_AperturaCaja";
            this.Load += new System.EventHandler(this.Frm_AperturaCaja_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_AperturaCaja_KeyDown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.elErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txbTotal;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txb500;
        private System.Windows.Forms.TextBox txb100;
        private System.Windows.Forms.TextBox txb50;
        private System.Windows.Forms.TextBox txb25;
        private System.Windows.Forms.TextBox txb10;
        private System.Windows.Forms.TextBox txb5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txb50000;
        private System.Windows.Forms.TextBox txb20000;
        private System.Windows.Forms.TextBox txb10000;
        private System.Windows.Forms.TextBox txb5000;
        private System.Windows.Forms.TextBox txb2000;
        private System.Windows.Forms.TextBox txb1000;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txbTotalAperturaCaja;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrarApertura;
        private System.Windows.Forms.ErrorProvider elErrorProvider;
    }
}