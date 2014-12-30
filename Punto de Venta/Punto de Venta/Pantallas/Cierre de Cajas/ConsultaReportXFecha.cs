using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Cierre_de_Cajas
{
    public partial class Frm_ConsultaReportXFecha : Form
    {
        int tipo = 0;
        public Frm_ConsultaReportXFecha(int tipoIn)
        {
            InitializeComponent();
            tipo=tipoIn;
            switch (tipo)
            {
                case 1: this.Text = "Reporte de Productos Vendidos entre Fechas";
                    txbCodCliente.Visible = false;
                    lblCodCliente.Visible = false;
                    break;
                case 2: this.Text = "Reporte de Total de Cierres entre Fechas";
                    gbOrdenado.Visible = false;
                    gbox2.Visible = false;
                    txbCodCliente.Visible = false;
                    lblCodCliente.Visible = false;
                    break;
                case 3: this.Text = "Reporte de Total de Cierres entre Fechas de ordenes";
                    gbOrdenado.Visible = false;
                    txbCodCliente.Visible = false;
                    lblCodCliente.Visible = false;
                    break;
                case 4: this.Text = "Reporte de Total de facturas por cliente entre fechas";
                    gbOrdenado.Visible = false;
                    gbox2.Visible = false;

                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            laLista.Add(dtpFechaInicio.Value.Year.ToString() + dtpFechaInicio.Value.Month.ToString().PadLeft(2, '0') + dtpFechaInicio.Value.Day.ToString().PadLeft(2, '0'));
            laLista.Add(dtpFechaFinal.Value.Year.ToString() + dtpFechaFinal.Value.Month.ToString().PadLeft(2, '0') + dtpFechaFinal.Value.Day.ToString().PadLeft(2, '0'));

            if (tipo == 1)
            {
                if (rbtnFacturasHist.Checked)
                {
                    if (rbCodigo.Checked)
                        elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_cod.rpt", laLista);
                    else
                        if (rbNombre.Checked)
                            elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_nom.rpt", laLista);
                        else
                            if (rbVenta.Checked)
                                elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_venta.rpt", laLista);
                }
                else if (rbtnOrdenes.Checked)
                {
                    if (rbCodigo.Checked)
                        elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_cod.rpt", laLista);
                    else
                        if (rbNombre.Checked)
                            elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_nom.rpt", laLista);
                        else
                            if (rbVenta.Checked)
                                elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_ventaORDENES.rpt", laLista);

                }
                else if (rbtnFactHoy.Checked)
                {
                    if (rbCodigo.Checked)
                        elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_cod.rpt", laLista);
                    else
                        if (rbNombre.Checked)
                            elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_nom.rpt", laLista);
                        else
                            if (rbVenta.Checked)
                                elReporte.cargarDocumento("rpt_PV_ProductosVendidosEntreFechas_venta.rpt", laLista);

                }
            }
            else if (tipo == 2)
                    elReporte.cargarDocumento("rpt_PV_CierreXFecha.rpt", laLista);

            else if (tipo == 3)
                elReporte.cargarDocumento("rpt_PV_CierreXFecha_ORDENES.rpt", laLista);
            else if (tipo == 4)
            {
                
               // laLista.Add(dtpFechaInicio.Value.Year.ToString() + dtpFechaInicio.Value.Month.ToString().PadLeft(2, '0') + dtpFechaInicio.Value.Day.ToString().PadLeft(2, '0'));
               // laLista.Add(dtpFechaFinal.Value.Year.ToString() + dtpFechaFinal.Value.Month.ToString().PadLeft(2, '0') + dtpFechaFinal.Value.Day.ToString().PadLeft(2, '0'));
                laLista.Add(txbCodCliente.Text);
                elReporte.cargarDocumento("rpt_PV_TotalVentasXclienteEntreFechas.rpt", laLista);
            }
        }

        private void Frm_ConsultaReportXFecha_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dtpFechaFinal.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
        }
    }
}
