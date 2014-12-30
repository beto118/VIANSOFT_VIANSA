using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.CategoriaProducto
{
    public partial class Frm_ListarCategoriaProducto : Form
    {
        
         public Frm_ListarCategoriaProducto()
        {
            InitializeComponent();
        }
        private void CargarListado()
        {

            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                dgvListado.DataSource = elServicio.ListarCategoria(txbFiltro.Text, estado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }
            
        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frm_RegistrarCategoria elIngresar = new frm_RegistrarCategoria();
            elIngresar.ShowDialog();
            CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                frm_RegistrarCategoria elIngresar = new frm_RegistrarCategoria(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void Frm_ListarCategoriaProducto_Load(object sender, EventArgs e)
        {
            CargarListado();
        }
    }
}
