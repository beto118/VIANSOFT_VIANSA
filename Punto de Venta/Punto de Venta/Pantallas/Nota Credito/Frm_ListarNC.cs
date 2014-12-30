using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.Nota_Credito
{
    public partial class Frm_ListarNC : Form
    {
        public Frm_ListarNC()
        {
            InitializeComponent();
            CargarListado();
        }
        private void CargarListado()
        {

            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioNotaCredito elServicio = new ServicioNotaCredito())
                dgvListado.DataSource = elServicio.ListarNC(txbFiltro.Text, estado);

        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_IngresarNC elIngresar = new Frm_IngresarNC(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            dgvListado_CellDoubleClick(null, null);
        }

        
    }
}
