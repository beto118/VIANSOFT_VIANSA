using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Pantallas.Facturas;

namespace Punto_de_Venta.Pantallas.Orden_de_Compra
{
    public partial class Frm_ListadoOrdenesCompra : Form
    {
        public Frm_ListadoOrdenesCompra()
        {
            InitializeComponent();
            CargarListado();
            txbFiltro.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {
            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                dgvListado.DataSource = elServicio.ListarOrdenCompra(txbFiltro.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CargarListado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            dgvListado_CellDoubleClick(null, null);
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                Frm_MantenimientoOrdenesCompra elMant = new Frm_MantenimientoOrdenesCompra(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elMant.ShowDialog();
                txbFiltro.Select();
                CargarListado();
            }
        }


    }
}
