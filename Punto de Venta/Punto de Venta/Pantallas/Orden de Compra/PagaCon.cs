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
using Punto_de_Venta.Pantallas.Varias;

namespace Punto_de_Venta.Pantallas.Orden_de_Compra
{
    public partial class PagaCon : Form
    {
        public static string Cambio = "";

        double Total = 0;
        double PAGACON = 0;
        double Vuelto = 0;
        double Dolares = 0;
        double TipoCambio = 500;
        double TotalDolar = 0;
        int     OrdenID = 0;
        int TipoPago = 0;
        bool facturoCorrecto = false;

        public PagaCon(int OrdenID_In)
        {
            InitializeComponent();

            txbPagaCon1.SelectAll();
            OrdenID = OrdenID_In;
            double totalORDEN = 0;
            TipoPago = 1;
            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                totalORDEN = double.Parse(elServicio.ConsultarOrdenCompra(OrdenID)["Orden_total"].ToString());
            lbl_Total_Efectivo.Text = string.Format("{0:N1}", totalORDEN);
            txbPagaCon1.Text = string.Format("{0:N1}", totalORDEN);
           
            tabControl1.SelectedIndex = 0;
            txbPagaCon1.Select();
                               
            using (ServicioGeneral elServicio = new ServicioGeneral())
                TipoCambio = double.Parse(elServicio.ConsultarDatosEmpresa()["Control_tipocambio"].ToString());
        }
        public bool FacturoCorrecto { get { return facturoCorrecto; } }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnListo_Click(object sender, EventArgs e)
        {
            // string estado = "";
            if (!Validar())
                return;
            string respuesta = "", detalle = "";
            
                //estado = "PAGA";
            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                respuesta = elServicio.PagaOrdenCompra(OrdenID, double.Parse(txbPagaCon1.Text), 0, detalle, TipoPago);
            
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
            {
                facturoCorrecto = true;
                if (MessageBox.Show("¿Desea imprimir la ORDEN DE COMPRA?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    //imprimir ORDEN
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirOrdenCOMPRA(OrdenID, Conexion.laConexion.ImpresoraFactura);
                }
                this.Close();

            }
            else
            {
                MessageBox.Show(respuesta, "Error al pagar");
            }

            Cambio = lbl_Vuelto_Efectivo.Text;
            Frm_Vuelto forma = new Frm_Vuelto(2);
            forma.ShowDialog();
           
            

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
                        MessageBox.Show("El monto no es suficiente para REALIZAR LA ORDEN DE COMPRA", "Error..");
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
            PAGACON = double.Parse(txbPagaCon1.Text);
            if (Total < PAGACON)
            {
                Vuelto = PAGACON - Total;
                MessageBox.Show("SU VUELTO ES: " + Vuelto);

            }
            else
            {
                MessageBox.Show("NO SE PUEDE REALIZAR LA OPERACION");
            }
            Vuelto = PAGACON - Total;
        }

        private void txbDolar1_TextChanged(object sender, EventArgs e)
        {
            btnConvertir.Enabled = true;
        }

        private void txbPagaCon1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnListo_Click(null, null);
            }
        }

        private void txbPagaCon1_TextChanged(object sender, EventArgs e)
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

        private void txbDolar1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnConvertir_Click(null, null);
                btnListo.Select();
            }
        }
    }
}
