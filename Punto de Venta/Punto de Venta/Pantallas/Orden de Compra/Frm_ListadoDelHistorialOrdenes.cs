using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Pantallas.Varias;

namespace Punto_de_Venta.Pantallas.Orden_de_Compra
{
    public partial class Frm_ListadoDelHistorialOrdenes : Form
    {
        public Frm_ListadoDelHistorialOrdenes()
        {
            InitializeComponent();
            ckFiltro.Checked = false;
            dtpFecha.Value = DateTime.Now;
            CargarListado();
            txbFiltro.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {
            string fecha = "";
            if (ckFiltro.Checked) fecha = dtpFecha.Value.ToShortDateString();
            else fecha = "01/01/1980";
            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                dgvListado.DataSource = elServicio.ListarHistOrdenCompra(txbFiltro.Text, fecha);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);


        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                Frm_Mantenimiento_HistFact elMant = new Frm_Mantenimiento_HistFact(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()),1);
                elMant.ShowDialog();
                // txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            dgvListado_CellDoubleClick(null, null);
        }
    }
}
