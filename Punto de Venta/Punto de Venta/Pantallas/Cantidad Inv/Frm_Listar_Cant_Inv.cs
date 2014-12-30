using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.Cantidad_Inv
{
    
    public partial class Frm_Listar_Cant_Inv : Form
    {
        string codSeleccionado = "";
        public Frm_Listar_Cant_Inv()
        {
            InitializeComponent();
        }

        private void CargarListado()
        {

            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioCantidad_Inventario elServicio = new ServicioCantidad_Inventario())
                dgvListado.DataSource = elServicio.ListarCantidadInv(txbFiltro.Text, estado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_Insertar_Cantidad_Inv elIngresar = new Frm_Insertar_Cantidad_Inv();
            elIngresar.ShowDialog();
            CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_Insertar_Cantidad_Inv elIngresar = new Frm_Insertar_Cantidad_Inv(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void Frm_Listar_Cant_Inv_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            codSeleccionado = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
            CargarListado();
            this.Close();
        }
        public string SeleccionarCodigo()
        {
            this.ShowDialog();
            return codSeleccionado;
        }
    }
}
