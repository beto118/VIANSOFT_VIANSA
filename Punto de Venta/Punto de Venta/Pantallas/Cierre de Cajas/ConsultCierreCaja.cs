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
using System.Collections;

namespace Punto_de_Venta.Pantallas
{
    public partial class Frm_ConsultCierreCaja : Form
    {
        int TipoCierre = 0;
        public Frm_ConsultCierreCaja(int Vend_Id,int Tipo)
        {
            InitializeComponent();
            TipoCierre = Tipo;
            CargarDatos(Vend_Id);
            
        }

        private void CargarDatos(int Vend_Id)
        {
            if (TipoCierre == 1)
            {
                double numFactContado = 0;
                DataRow drCierre = null;
                using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                    drCierre = elServicio.ConsultarCierre(Vend_Id);
                if (drCierre != null)
                {
                    txbId.Text = drCierre["Vent_id"].ToString();
                    txbFecha.Text = drCierre["Vent_fecha"].ToString();
                    txbNumFact.Text = drCierre["Vent_numeroFactura"].ToString();
                    txbFacturasNulas.Text = drCierre["Vent_numeroFacturaNulas"].ToString();
                    txbNumFactCred.Text = drCierre["Vent_numeroFactCredito"].ToString();
                    txbTotal.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_total"].ToString()));
                    txbTotalEfect.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_montoEfectivo"].ToString()));
                    txbtotalTarjeta.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_montoTarjeta"].ToString()));
                    txbTotalCredito.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_montoCredito"].ToString()));
                    txbImpuesto.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_impuesto"].ToString()));
                    txbEgresos.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_egresos"].ToString()));
                    txbUtilidad.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_Utilidad"].ToString()));
                    txbTotalCosto.Text = string.Format("{0:N1}", double.Parse(drCierre["Vent_TotalCosto"].ToString()));
                    numFactContado = double.Parse(txbNumFact.Text) - double.Parse(txbFacturasNulas.Text) - double.Parse(txbNumFactCred.Text);
                    txbNumFactContado.Text = numFactContado.ToString();
                    using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                        dgvListado.DataSource = elServicio.ListarDetalleCierres(Vend_Id);
                    Validacion laValidacion = new Validacion();
                    laValidacion.DarFormatoDecimalGrid(dgvListado);
                }
            }
            else
            {
                double numFactContado = 0;
                DataRow drCierre = null;
                using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                    drCierre = elServicio.ConsultarFinOrdenes(Vend_Id);
                if (drCierre != null)
                {
                    txbId.Text = drCierre["Ordenes_id"].ToString();
                    txbFecha.Text = drCierre["Orden_fecha"].ToString();
                    txbNumFact.Text = drCierre["Ordenes_numeroFactura"].ToString();
                    txbFacturasNulas.Text = drCierre["Ordenes_numeroFacturaNulas"].ToString();
                    txbTotal.Text = string.Format("{0:N1}", double.Parse(drCierre["Ordenes_total"].ToString()));
                    txbTotalEfect.Text = string.Format("{0:N1}", double.Parse(drCierre["Ordenes_montoEfectivo"].ToString()));
                    txbtotalTarjeta.Text = string.Format("{0:N1}", double.Parse(drCierre["Ordenes_montoTarjeta"].ToString()));
                   // txbImpuesto.Text = string.Format("{0:N1}", double.Parse(drCierre["Ordenes_impuesto"].ToString()));
                    numFactContado = double.Parse(txbNumFact.Text) - double.Parse(txbFacturasNulas.Text);
                    txbNumFactContado.Text = numFactContado.ToString();
                    using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                        dgvListado.DataSource = elServicio.ListarDetalleFinOrdenes(Vend_Id);
                    Validacion laValidacion = new Validacion();
                    laValidacion.DarFormatoDecimalGrid(dgvListado);
                }

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporteCierre_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            laLista.Add(txbId.Text);
            //laLista.Add(txbId.Text);
                elReporte.cargarDocumento("rpt_PV_Cierre.rpt", laLista);
        }
    }
}
