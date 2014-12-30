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

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_ListarPagosProveedor : Form
    {
        public Frm_ListarPagosProveedor()
        {
            InitializeComponent();
            CargarListado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            int soloFecha = 0;
            if (ckFecha.Checked) soloFecha = 1;
            using (ServicioPagoProveedor elGestor = new ServicioPagoProveedor())
                this.dgvListado.DataSource = elGestor.ListarPagoProveedor(txbFiltro.Text, soloFecha, dpFecha.Value.ToShortDateString());
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CargarListado();
        }

        private void ckFecha_CheckedChanged(object sender, EventArgs e)
        {
            dpFecha.Enabled = ckFecha.Checked;
            CargarListado();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            frm_ReportePagoProveedor elReporte = new frm_ReportePagoProveedor();
            elReporte.ShowDialog();
        }
    }
}
