using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta
{
    public partial class Precio : Form
    {
        double precio = 0;
        public Precio()
        {
            InitializeComponent();
        }
        public double GetPrecio
        { get { return precio; } }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                 elErrorProvider.Clear();
                 using (Validacion elValidar = new Validacion())
                     if (!elValidar.ValidaDoubleMayorCero(txbPrecio, elErrorProvider, "Precio"))
                         return;
                precio = double.Parse(txbPrecio.Text);
                this.Close();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
                if (!elValidar.ValidaDoubleMayorCero(txbPrecio, elErrorProvider, "Precio"))
                    return;
            precio = double.Parse(txbPrecio.Text);
            this.Close();
        }

        private void Precio_Load(object sender, EventArgs e)
        {
            txbPrecio.Select();
        }
        #region TapNumerico
        private void btn7_Click(object sender, EventArgs e)
        {

            txbPrecio.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "8";

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "5";
        }

        private void byn6_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txbPrecio.Text += "00";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
           
           txbPrecio.Text += ".";
        }
      
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (txbPrecio.Text.Length > 0)
                txbPrecio.Text = txbPrecio.Text.Substring(0, txbPrecio.Text.Length - 1);

        }
     
        #endregion TapNumerico

    }
}
