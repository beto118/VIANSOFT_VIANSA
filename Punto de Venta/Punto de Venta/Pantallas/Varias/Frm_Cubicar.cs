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
    public partial class Frm_Cubicar : Form
    {
        double TotalPulgadas = 0;
        public Frm_Cubicar()
        {
            InitializeComponent();
        }
        public double GetTotalPulgadas
        { 
            get { return TotalPulgadas; } 
        }

        private void CALCULARTOTAL()
        {
            double grueso = 0, ancho = 0, largo = 0 ,total=0;

            grueso = double.Parse(txbGrueso.Text);
            ancho = double.Parse(txbAncho.Text);
            largo = double.Parse(txbLargo.Text);

            largo= (largo)*0.25;


            total = grueso * ancho * largo;

            txbTotal.Text = total.ToString();
        }

        private void txbGrueso_TextChanged(object sender, EventArgs e)
        {
            if (txbGrueso.Text.Length > 0 && txbAncho.Text.Length > 0 && txbLargo.Text.Length > 0) CALCULARTOTAL();
            else txbTotal.Text = "0";
        }

        private void txbAncho_TextChanged(object sender, EventArgs e)
        {
            if (txbGrueso.Text.Length > 0 && txbAncho.Text.Length > 0 && txbLargo.Text.Length > 0) CALCULARTOTAL();
            else txbTotal.Text = "0";
        }

        private void txbLargo_TextChanged(object sender, EventArgs e)
        {
            if (txbGrueso.Text.Length > 0 && txbAncho.Text.Length > 0 && txbLargo.Text.Length > 0) CALCULARTOTAL();
            else txbTotal.Text = "0";
        }

        private void txbGrueso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txbAncho.Focus();
            }
        }

        private void txbAncho_KeyPress(object sender, KeyPressEventArgs e)
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
                btnAceptar_Click(null, null);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
                if (!elValidar.ValidaDoubleMayorCero(txbTotal, elErrorProvider, "total"))
                    return;

            TotalPulgadas = double.Parse(txbTotal.Text);
            this.Close();
        }
    }
}
