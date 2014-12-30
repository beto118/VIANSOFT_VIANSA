using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.Agenda
{
    public partial class Frm_ListarAgenda : Form
    {
        public Frm_ListarAgenda()
        {
            InitializeComponent();
            CargarListado();
        }
        private void CargarListado()
        {
            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioAgenda elServicio = new ServicioAgenda())
                dgvListado.DataSource = elServicio.ListarAgenda(txbFiltro.Text, estado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_Agenda elIngresar = new Frm_Agenda(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            Frm_Agenda elIngresar = new Frm_Agenda();
            elIngresar.ShowDialog();
            txbFiltro.Text = "";
            CargarListado();
        }
    }
}
