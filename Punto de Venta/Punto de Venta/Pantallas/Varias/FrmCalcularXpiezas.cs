using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Varias
{
    public partial class Frm_CalcularXPiezas : Form
    {
        double TotalVaras = 0;
        public Frm_CalcularXPiezas()
        {
            InitializeComponent();
            txbCantiPiezas.Focus();
        }
        public double GetTotalVaras
        { get { return TotalVaras; } }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
                if (!elValidar.ValidaDoubleMayorCero(txbTotal, elErrorProvider, "total"))
                    return;
            
            TotalVaras = double.Parse(txbTotal.Text);
            this.Close();
        }
        private void CalcularTotal()
        {
            double cantidaPiezas = 0,largo=0,total=0;

            cantidaPiezas = double.Parse(txbCantiPiezas.Text);
            largo = double.Parse(txbLargo.Text);

            total= cantidaPiezas*largo;
            
            txbTotal.Text=total.ToString();
        }

        private void txbCantiPiezas_TextChanged(object sender, EventArgs e)
        {
            if (txbCantiPiezas.Text.Length > 0 && txbLargo.Text.Length > 0)
            {
                CalcularTotal();
            }
            else txbTotal.Text = "0";
        }

        private void txbLargo_TextChanged(object sender, EventArgs e)
        {
            if (txbCantiPiezas.Text.Length > 0 && txbLargo.Text.Length > 0)
            {
                CalcularTotal();
            }
            else txbTotal.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbCantiPiezas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txbLargo.Focus();
            }
        }

        private void txbLargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar.Focus();
            }
        }

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnAceptar_Click(null, null);
            }
        }

    }
}
