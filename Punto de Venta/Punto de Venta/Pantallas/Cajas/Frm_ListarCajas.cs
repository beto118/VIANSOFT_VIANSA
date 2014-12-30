using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.Cajas
{
    public partial class Frm_ListarCajas : Form
    {
        string modo = "";
        public Frm_ListarCajas(string modoIn)
        {
            InitializeComponent();
            modo = modoIn;
        }
        private void CargarListado()
        {

            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioCajas elServicio = new ServicioCajas())
                dgvListado.DataSource = elServicio.ListarCajas(txbFiltro.Text, estado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }

        private void ListarCajas_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_RegistarCaja elIngresar = new Frm_RegistarCaja();
            elIngresar.ShowDialog();
            CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_RegistarCaja elIngresar = new Frm_RegistarCaja(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }
    }
}
