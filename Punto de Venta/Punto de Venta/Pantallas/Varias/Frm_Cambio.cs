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
using Punto_de_Venta.Reportes;
using System.Media;
using Punto_de_Venta.Pantallas.Varias;

namespace Punto_de_Venta.Pantallas
{
    
    public partial class Frm_Cambio : Form
    {
        public static string Cambio = "";
        TextBox elTXBSeleccionado = new TextBox();
        double Total = 0;
        double PagaCon = 0;
        double Vuelto = 0;
        double Dolares = 0;
        double TipoCambio = 500;
        double TotalDolar = 0;
        int NumFactura = 0;
        int TipoPago = 0;
        bool facturoCorrecto=false;
        public Frm_Cambio(int NumFacturaIn,int TipoPagoIn)
        {
            InitializeComponent();
            txbPagaCon1.SelectAll();
            elTXBSeleccionado = txbPagaCon1;
            NumFactura = NumFacturaIn;
            TipoPago = TipoPagoIn;
            double totalFAct = 0;
            using(ServicioFactura elServicio=new ServicioFactura())
                totalFAct = double.Parse(elServicio.ConsultarFactura(NumFactura)["Fact_total"].ToString());
            lbl_Total_Efectivo.Text = string.Format("{0:N1}", totalFAct);
            lbl_Total_Tarjeta.Text = string.Format("{0:N1}", totalFAct);
            lbl_Total_Mixto.Text = string.Format("{0:N1}", totalFAct);
            lblTotalCredito.Text = string.Format("{0:N1}", totalFAct);
            lblSaldo.Text = string.Format("{0:N1}", totalFAct);
            txbPagaCon1.Text = string.Format("{0:N1}", totalFAct);
            if (TipoPago == 1)
            {
                tabControl1.SelectedIndex = 0;
                txbPagaCon1.Select();
                
            }
            if (TipoPago == 2)
            {
            tabControl1.SelectedIndex = 1;
            btnListo.Select();
            }
            if (TipoPago == 3)
            {
                tabControl1.SelectedIndex = 2;
                txbPagoTarjetaMixto.Select();
            }
            if (TipoPago == 4)
            {
                tabControl1.SelectedIndex = 3;
                btnListo.Select();
            }
            using (ServicioGeneral elServicio = new ServicioGeneral())
                TipoCambio = double.Parse(elServicio.ConsultarDatosEmpresa()["Control_tipocambio"].ToString());
            
        }
        public bool FacturoCorrecto { get { return facturoCorrecto; } }

        private void btnListo_Click(object sender, EventArgs e)
        {
           // string estado = "";
            if (!Validar())
                return;
            string respuesta = "",detalle="";
            if (TipoPago == 1)
            {
                //estado = "PAGA";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.PagarFactura(NumFactura, double.Parse(txbPagaCon1.Text),0, detalle,0,0,0,TipoPago);
            }
            if(TipoPago==2){
                //detalle de tarjeta
               // estado="PAGA";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.PagarFactura(NumFactura, 0,double.Parse(lbl_Total_Tarjeta.Text), (txbNumTarjeta.Text + " / " + cbxTipoTarjeta.Text),0,0,0, TipoPago);
            
            }
            if(TipoPago==3){
            //detalle mixto
               // estado = "PAGA";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.PagarFactura(NumFactura, double.Parse(txbPagaConMixto.Text),double.Parse(txbPagoTarjetaMixto.Text), (txbNumTarjetaMixto.Text + " / " + cbxTipoTarjetaMixto.Text),0,0,0, TipoPago);
            }
            if (TipoPago == 4)
            {
                //detalle CREDITO
                if (txbAbono.Text == "") txbAbono.Text = "0.0";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.FacturarCredito(NumFactura, 0, 0, detalle, double.Parse(lblTotalCredito.Text), double.Parse(txbAbono.Text),double.Parse(lblSaldo.Text), TipoPago, DateTime.Parse(dtpFechaLimite.Text));
            }

            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
            {
                facturoCorrecto = true;
                if (MessageBox.Show("¿Desea imprimir la factura?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                //imprimir factura
                using (ImprimirTicket elImprimir = new ImprimirTicket())
                    elImprimir.ImprimirFactura(NumFactura, Conexion.laConexion.ImpresoraFactura);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show(respuesta, "Error al pagar");
            }
            if (TipoPago == 1)
            {
                Cambio = lbl_Vuelto_Efectivo.Text;
                Frm_Vuelto forma = new Frm_Vuelto(1);
                forma.ShowDialog();
            }
            if (TipoPago == 3)
            {
                Cambio = lbl_VueltoMixto.Text;
                if (Cambio.Equals("0.0")) { }
                else 
                {
                    Frm_Vuelto forma = new Frm_Vuelto(1);
                    forma.ShowDialog();
                }
            }
        }

        private bool Validar()
        {
            
            using (Validacion laValidacion = new Validacion())
            {
                if (TipoPago == 1)//Validacion de pago efectivo
                {
                    if (!laValidacion.ValidaDoubleMayorCero(txbPagaCon1, elErrorProvider, "Monto Efectivo"))
                        return false;
                    if (double.Parse(txbPagaCon1.Text) < double.Parse(lbl_Total_Efectivo.Text))
                    {
                        MessageBox.Show("El monto no es suficiente para pagar la factura", "Error..");
                        return false;
                    }

                }

                if (TipoPago == 3)//Validacion de pago mixto
                {
                    if (!laValidacion.ValidaDoubleMayorCero(txbPagaConMixto, elErrorProvider, "Monto Efectivo"))
                        return false;
                    if (!laValidacion.ValidaDoubleEntre(1, double.Parse(lbl_Total_Mixto.Text), txbPagoTarjetaMixto, elErrorProvider, "Monto Tarjeta"))
                        return false;
                    if (double.Parse(txbPagaConMixto.Text) + double.Parse(txbPagoTarjetaMixto.Text) < double.Parse(lbl_Total_Mixto.Text))
                    {
                        MessageBox.Show("El monto no es suficiente para pagar la factura", "Error..");
                        return false;
                    }
                }
            }
            //Todo correcto
            return true;
        }
        public void Calculo()
        {
            Total = double.Parse(lbl_Total_Efectivo.Text);
            PagaCon = double.Parse(txbPagaCon1.Text);
            if (Total < PagaCon)
            {
                Vuelto = PagaCon - Total;
                MessageBox.Show("SU VUELTO ES: " + Vuelto);
 
            }
            else
            {
                MessageBox.Show("NO SE PUEDE REALIZAR LA OPERACION");
            }
            Vuelto = PagaCon - Total;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbDolar_TextChanged(object sender, EventArgs e)
        {
            btnConvertir.Enabled=true;
        }

        private void txbPago_KeyPress(object sender, KeyPressEventArgs e)
       {
            if (e.KeyChar == 13)
            {
                btnListo_Click(null, null); 
            }
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            txbDolar1.BackColor = Color.White;
            try
            {
                txbPagaCon1.Clear();
                Dolares = double.Parse(txbDolar1.Text);
                TotalDolar = Dolares * TipoCambio;
                txbPagaCon1.Text = string.Format("{0:n1}", TotalDolar);
            }
            catch
            {
                txbDolar1.BackColor = Color.Red;
            }
        }

        private void txbPago_TextChanged(object sender, EventArgs e)
        {
            txbPagaCon1.BackColor = Color.White;
            try
            {
                double vuelto = double.Parse(txbPagaCon1.Text) - double.Parse(lbl_Total_Efectivo.Text);
                if (vuelto < 0)
                    lbl_Vuelto_Efectivo.Text = "0.0";
                else
                    lbl_Vuelto_Efectivo.Text = string.Format("{0:n1}", vuelto);
            }
            catch
            {
                txbPagaCon1.BackColor = Color.Red;
            }
        }

        private void txbDolar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConvertir_Click(null, null);
                btnListo.Select();
            }
        }

        #region TapNumerico
        private void btn7_Click(object sender, EventArgs e)
        {

            elTXBSeleccionado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "8";

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "5";
        }

        private void byn6_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "00";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += ".";
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text = "";
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (elTXBSeleccionado.Text.Length > 0)
                elTXBSeleccionado.Text = elTXBSeleccionado.Text.Substring(0, elTXBSeleccionado.Text.Length - 1);

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (elTXBSeleccionado.Equals("txbPago"))
            {
                btnConvertir.Focus();
            }
            else if (elTXBSeleccionado.Equals("txbDolar"))
            {
                txbPagaCon1.Focus();
            }


            SystemSounds.Beep.Play();

        }
        private void txb_Enter(object sender, EventArgs e)
        {
            elTXBSeleccionado = (TextBox)sender;
        }
        #endregion TapNumerico

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedTab.Equals("EFECTIVO"))
            {
                txbPagaCon1.SelectAll();
                TipoPago = 1;
            }
            else if(tabControl1.SelectedTab.Equals("TARJETA"))
            {
                btnListo.Focus();
                TipoPago = 2;
            }
            else if (tabControl1.SelectedTab.Equals("MIXTO"))
            {
                txbPagoTarjetaMixto.SelectAll();
                TipoPago = 3;
            }
            else if (tabControl1.SelectedTab.Equals("CREDITO"))
            {
                btnListo.Focus();
                TipoPago = 4;
            }
        }

        private void txbPago3_TextChanged(object sender, EventArgs e)
        {
            txbPagaConMixto.BackColor = Color.White;
            txbPagoTarjetaMixto.BackColor = Color.White;
            //Validar los textbox
            try { double.Parse(txbPagaConMixto.Text); }
            catch { txbPagaConMixto.BackColor = Color.Red; }
            try { double.Parse(txbPagoTarjetaMixto.Text); }
            catch { txbPagoTarjetaMixto.BackColor = Color.Red; }



            try
            {
                double vuelto = (double.Parse(txbPagaConMixto.Text) + double.Parse(txbPagoTarjetaMixto.Text)) - double.Parse(lbl_Total_Mixto.Text);
                if (vuelto < 0)
                    lbl_VueltoMixto.Text = "0.0";
                else
                    lbl_VueltoMixto.Text = string.Format("{0:n1}", vuelto);
            }
            catch
            {
                
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex==0)
            {
                txbPagaCon1.Select();
                TipoPago = 1;
            }
            else if (tabControl1.SelectedIndex == 1)
            {
                btnListo.Select();
                TipoPago = 2;
            }
            else if (tabControl1.SelectedIndex == 2)
            {
                txbPagoTarjetaMixto.Select();
                TipoPago = 3;
            }
            else if (tabControl1.SelectedIndex == 3)
            {
                btnListo.Select();
                TipoPago = 4;
            }
        }

        private void txbPagoTarjetaMixto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txbPagaConMixto.Focus();
            }
        }

        private void txbPagaConMixto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnListo.Select();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txbAbono.BackColor = Color.White;
            
            try
            {
                double abono = 0;
                double saldo = double.Parse(lblTotalCredito.Text) - double.Parse(txbAbono.Text);
                if (abono < 0)
                    lblSaldo.Text = "0.0";
                else
                    lblSaldo.Text = string.Format("{0:n1}", saldo);
            }
            catch
            {
                txbAbono.BackColor = Color.White;
                lblSaldo.Text = lblTotalCredito.Text;
               
            }

        }

        
    }
}
