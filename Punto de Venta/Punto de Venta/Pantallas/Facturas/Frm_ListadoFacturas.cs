using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Pantallas.Varias;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Facturas
{
    public partial class Frm_ListadoFacturas : Form
    {
        public Frm_ListadoFacturas()
        {
            InitializeComponent();
            CargarListado();
            txbFiltro.Select();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void Frm_ListadoFacturas_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void CargarListado()
        {
            using (ServicioFactura elServicio = new ServicioFactura())
                dgvListado.DataSource = elServicio.ListarFacturas(txbFiltro.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                CargarListado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                Frm_Mantenimiento_Fact elMant = new Frm_Mantenimiento_Fact(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elMant.ShowDialog();
                txbFiltro.Select();
                CargarListado();
            }
        }

        private void btnver_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                Frm_Mantenimiento_Fact elMant = new Frm_Mantenimiento_Fact(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elMant.ShowDialog();
                txbFiltro.Select();
                CargarListado();
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }
    }
}
