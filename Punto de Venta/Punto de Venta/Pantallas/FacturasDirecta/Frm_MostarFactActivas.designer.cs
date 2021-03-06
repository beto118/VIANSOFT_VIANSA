﻿namespace Punto_de_Venta.Pantallas.FacturasDirecta
{
    partial class Frm_MostarFactActivas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txbFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxVendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flp_tab1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnNuevaFactura = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txbFiltro);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(230, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 44);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // txbFiltro
            // 
            this.txbFiltro.Location = new System.Drawing.Point(66, 8);
            this.txbFiltro.Name = "txbFiltro";
            this.txbFiltro.Size = new System.Drawing.Size(296, 22);
            this.txbFiltro.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtro:";
            // 
            // cbxVendedor
            // 
            this.cbxVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVendedor.FormattingEnabled = true;
            this.cbxVendedor.Items.AddRange(new object[] {
            "NINGUNO",
            "FRUTAS",
            "LEGUMBRES",
            "VERDURAS",
            "VARIOS"});
            this.cbxVendedor.Location = new System.Drawing.Point(757, 22);
            this.cbxVendedor.Name = "cbxVendedor";
            this.cbxVendedor.Size = new System.Drawing.Size(241, 24);
            this.cbxVendedor.TabIndex = 159;
            this.cbxVendedor.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(671, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Vendedor:";
            this.label2.Visible = false;
            // 
            // flp_tab1
            // 
            this.flp_tab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_tab1.BackColor = System.Drawing.Color.White;
            this.flp_tab1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flp_tab1.Location = new System.Drawing.Point(8, 71);
            this.flp_tab1.Name = "flp_tab1";
            this.flp_tab1.Size = new System.Drawing.Size(988, 391);
            this.flp_tab1.TabIndex = 2;
            // 
            // btnNuevaFactura
            // 
            this.btnNuevaFactura.BackColor = System.Drawing.Color.White;
            this.btnNuevaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaFactura.Image = global::Punto_de_Venta.Properties.Resources.icon_factura;
            this.btnNuevaFactura.Location = new System.Drawing.Point(10, 11);
            this.btnNuevaFactura.Name = "btnNuevaFactura";
            this.btnNuevaFactura.Size = new System.Drawing.Size(186, 54);
            this.btnNuevaFactura.TabIndex = 3;
            this.btnNuevaFactura.Text = "Nueva Factura";
            this.btnNuevaFactura.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevaFactura.UseVisualStyleBackColor = false;
            this.btnNuevaFactura.Click += new System.EventHandler(this.btnNuevaFactura_Click);
            // 
            // Frm_MostarFactActivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 474);
            this.Controls.Add(this.cbxVendedor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNuevaFactura);
            this.Controls.Add(this.flp_tab1);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Frm_MostarFactActivas";
            this.Text = "Frm_MostarFactActivas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Frm_MostarFactActivas_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxVendedor;
        private System.Windows.Forms.FlowLayoutPanel flp_tab1;
        private System.Windows.Forms.Button btnNuevaFactura;
    }
}