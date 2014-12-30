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

namespace Punto_de_Venta.Pantallas.Cierre_de_Cajas
{
    public partial class Frm_ListaCierres : Form
    {
        public Frm_ListaCierres()
        {
            InitializeComponent();
            dtpFecha.Value = DateTime.Now;
            CargarListado();
        }

        private void CargarListado()
        {
            string fecha = "";
            if (ckFiltro.Checked) fecha = dtpFecha.Value.ToShortDateString();
            else fecha = "01/01/1980";
            using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                dgvListado.DataSource = elServicio.ListarCierres(fecha);
            Validacion laValidacion = new Validacion();
            laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void btnVerReport_Click(object sender, EventArgs e)
        {
            Frm_ConsultaReportXFecha elReporte = new Frm_ConsultaReportXFecha(2);
            elReporte.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void btnReportProducts_Click(object sender, EventArgs e)
        {
            Frm_ConsultaReportXFecha elReporte = new Frm_ConsultaReportXFecha(1);
            elReporte.ShowDialog();
        }

        private void ckFiltro_CheckedChanged(object sender, EventArgs e)
        {
            dtpFecha.Enabled = ckFiltro.Checked;
            CargarListado();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                Frm_ConsultCierreCaja elfrmConsultar = new Frm_ConsultCierreCaja(int.Parse(dgvListado.SelectedRows[0].Cells["ID"].Value.ToString()),1);
                elfrmConsultar.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarListado();
        }
    }
}