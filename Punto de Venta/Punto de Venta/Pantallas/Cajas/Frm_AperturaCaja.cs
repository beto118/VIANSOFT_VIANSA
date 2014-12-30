using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Cajas
{
    public partial class Frm_AperturaCaja : Form
    {
        public Frm_AperturaCaja()
        {
            InitializeComponent();
        }

        private void Frm_AperturaCaja_Load(object sender, EventArgs e)
        {
            txb5.Focus();
        }
        private void total()
        {
            try
            {
                double total = 0;

                total = double.Parse(txb5.Text) * 5 + double.Parse(txb10.Text) * 10 + double.Parse(txb25.Text) * 25 + double.Parse(txb50.Text) * 50 + double.Parse(txb100.Text) * 100 + double.Parse(txb500.Text) * 500 + double.Parse(txb1000.Text) * 1000 + double.Parse(txb2000.Text) * 2000 + double.Parse(txb5000.Text) * 5000 + double.Parse(txb10000.Text) * 10000 + double.Parse(txb20000.Text) * 20000 + double.Parse(txb50000.Text) * 50000;

                txbTotal.Text = total.ToString();
            }
            catch
            {
                MessageBox.Show("Error al calcular el total");
            }
        }

        private void btnCalcularTotal_Click(object sender, EventArgs e)
        {
            total();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrarApertura_Click(object sender, EventArgs e)
        {
            if (!Validar())
                return;
            DataRow laCaja = null;
            using (ServicioCajas elServicio = new ServicioCajas())

                laCaja = elServicio.ConsultarCajas(int.Parse(Principal.laCaja.Numero));
            if (laCaja != null)
            {

                string respuesta = "";
                using (ServicioCajas elServicioCaja = new ServicioCajas())

                    if (tabControl1.SelectedIndex == 0)
                        respuesta = elServicioCaja.ModificarMontosCajas(int.Parse(Principal.laCaja.Numero), double.Parse(txbTotal.Text), 0);
                    else
                        respuesta = elServicioCaja.ModificarMontosCajas(int.Parse(Principal.laCaja.Numero), double.Parse(txbTotalAperturaCaja.Text), 0);
                MessageBox.Show("SE REGISTRO CORRECTAMENTE EL MONTO DE LA CAJA");
                this.Close();
            }
        }
        private bool Validar()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaIntMayorIgualCero(txb5, elErrorProvider, "5"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb10, elErrorProvider, "10"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb25, elErrorProvider, "25"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb50, elErrorProvider, "50"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb100, elErrorProvider, "100"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb500, elErrorProvider, "500"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb1000, elErrorProvider, "1000"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb2000, elErrorProvider, "2000"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb5000, elErrorProvider, "5000"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txb10000, elErrorProvider, "10.000"))
                    malas++;
                if (!elValidar.ValidaIntMayorIgualCero(txbTotal, elErrorProvider, "TOTAL"))
                    malas++;
            }
            if (malas == 0)
                return true;
            else
                return false;

        }

        private void Frm_AperturaCaja_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnRegistrarApertura_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                btnCalcularTotal_Click(null, null);
            }//hola
        }

    }
}
