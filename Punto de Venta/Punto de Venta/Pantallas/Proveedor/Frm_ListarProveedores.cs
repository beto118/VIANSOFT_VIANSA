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

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_ListarProveedores : Form
    {
        public Frm_ListarProveedores()
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
            using (ServicioProveedor elServicio = new ServicioProveedor())
                dgvListado.DataSource = elServicio.ListarProveedor(txbFiltro.Text);
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                Frm_MantProveedor elMant = new Frm_MantProveedor(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()), "EDITPRO");
                elMant.ShowDialog();
                CargarListado();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_MantProveedor elMant = new Frm_MantProveedor();

            elMant.ShowDialog();
            CargarListado();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            elReporte.cargarDocumento("rpt_PV_FactProveedor_saldo.rpt", laLista);
        }

        private void btnAgregarFact_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                Frm_MantProveedor elMant = new Frm_MantProveedor(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()), "NUEVAFACT");
                elMant.ShowDialog();
                CargarListado();
            }
        }
    }
}
