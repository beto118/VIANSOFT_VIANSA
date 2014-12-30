using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Punto_de_Venta.Logica_de_Negocio;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class frm_ReportePagoProveedor : Form
    {
        public frm_ReportePagoProveedor()
        {
            InitializeComponent();
            dtpFechaDesde.Value = DateTime.Now.AddDays(-1);
            dtpFechaHasta.Value = DateTime.Now;
        }

        private void txbProveedor_codigo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Frm_SelecProveedor losMovs = new Frm_SelecProveedor();
            ArrayList elMov = losMovs.SeleccionarCodigo();
            if (elMov.Count != 0)
            {
                txbProveedor_codigo.Text = elMov[0].ToString();
                DataRow drMov;
                using (ServicioProveedor elServicioPagoProveedor = new ServicioProveedor())
                    drMov = elServicioPagoProveedor.ConsultarProveedor(int.Parse(elMov[0].ToString()));
                txbProveedor_nombre.Text = drMov["Proveedor_nombre"].ToString();

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            laLista.Add(dtpFechaDesde.Value.ToShortDateString());
            laLista.Add(dtpFechaHasta.Value.ToShortDateString());
            laLista.Add(txbProveedor_codigo.Text);
            elReporte.cargarDocumento("rpt_PV_PagoProveedorEntreFecha.rpt", laLista);
        }
    }
}
