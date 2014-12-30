using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Reportes;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Cierre_de_Cajas
{
    public partial class Frm_ConsultaDetalleCierre : Form
    {
        int tipocierre=0;
        public Frm_ConsultaDetalleCierre(int ventaXcaja_id, int Tipo)//,int Tipo
        {
            InitializeComponent();
            tipocierre = Tipo;
            CargarDatos(ventaXcaja_id);
            if(tipocierre ==1) CalcularTotalCaja();
        }

        private void CargarDatos(int ventaXcaja_id)
        {
            if (tipocierre == 1)
            {
                DataRow drDetalle = null;
                using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                    drDetalle = elServicio.ConsultaDetalleCierres(ventaXcaja_id);
                if (drDetalle != null)
                {
                    txbId.Text = ventaXcaja_id.ToString();
                    txbCaja.Text = drDetalle["caja_numero"].ToString();
                    txbFecha.Text = drDetalle["ventaXcaja_fecha"].ToString();
                    txbNumFact.Text = drDetalle["ventaXcaja_numeroFactura"].ToString();
                    txbFacturasNulas.Text = drDetalle["ventaXcaja_numeroFacturaNulas"].ToString();
                    txbNumFactCred.Text = drDetalle["ventaXcaja_numeroFactCredito"].ToString();
                    txbDescuento.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_descuento"].ToString()));
                    txbImpuesto.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_impuesto"].ToString()));
                              
                    txbTotal.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_total"].ToString()));
                    txbTotalEfect.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_montoEfectivo"].ToString()));
                    txbTotalEfectivo2.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_montoEfectivo"].ToString()));
                    txbtotalTarjeta.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_montoTarjeta"].ToString()));
                    txbTotalCredito.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_montoCredito"].ToString()));
                    txbEgresoResta.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_egresos_resta"].ToString()));
                    txbEgresoSuma.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_egresos_Suma"].ToString()));
                    txbUtilidad.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_Utilidad"].ToString()));
                    txbAperturaCaja.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_MontoAperturaCaja"].ToString()));
                    txbTotalCosto.Text = string.Format("{0:n1}", double.Parse(drDetalle["ventaXcaja_TotalCosto"].ToString()));
                    
                    txbEgresoResta2.Text = txbEgresoResta.Text;
                    txbEgresoSuma2.Text = txbEgresoSuma.Text;
                }
            }
            else
            {
                DataRow drDetalle = null;
                using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                    drDetalle = elServicio.ConsultaDetalleFinalizacionOrden(ventaXcaja_id);
                if (drDetalle != null)
                {
                    txbId.Text = ventaXcaja_id.ToString();
                    txbCaja.Text = drDetalle["caja_numero"].ToString();
                    txbFecha.Text = drDetalle["Orden_fecha"].ToString();
                    txbNumFact.Text = drDetalle["OrdenXcaja_numeroFactura"].ToString();
                    txbFacturasNulas.Text = drDetalle["OrdenXcaja_numeroFacturaNulas"].ToString();
                    txbDescuento.Text = string.Format("{0:n1}", double.Parse(drDetalle["OrdenXcaja_descuento"].ToString()));
                    txbImpuesto.Text = string.Format("{0:n1}", double.Parse(drDetalle["OrdenXcaja_impuesto"].ToString()));
                    txbTotal.Text = string.Format("{0:n1}", double.Parse(drDetalle["OrdenXcaja_total"].ToString()));
                    txbTotalEfect.Text = string.Format("{0:n1}", double.Parse(drDetalle["OrdenXcaja_montoEfectivo"].ToString()));
                    txbtotalTarjeta.Text = string.Format("{0:n1}", double.Parse(drDetalle["OrdenXcaja_montoTarjeta"].ToString()));
                }
            }
        }
        private void CalcularTotalCaja()
        {
            txbTotal_en_Caja.Text = (double.Parse(txbTotalEfectivo2.Text) + (double.Parse(txbAperturaCaja.Text)) + (double.Parse(txbEgresoSuma2.Text)) - (double.Parse(txbEgresoResta2.Text))).ToString();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea imprimir el detalle del cierre?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //imprimir factura
                if (tipocierre == 1)
                {
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirCierreCaja(Conexion.laConexion.ImpresoraFactura, int.Parse(txbId.Text));
                    this.Hide();
                    this.Dispose();
                }
                else
                {
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirCierreORDENES(Conexion.laConexion.ImpresoraFactura, int.Parse(txbId.Text));
                    this.Hide();
                    this.Dispose();
 
                }

            }
        }
    }
}
