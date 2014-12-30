using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using System.Collections;

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_SelecProveedor : Form
    {
        ArrayList codigoSelecc =new ArrayList();

        public Frm_SelecProveedor()
        {
            InitializeComponent();
            CargarListado();

        }

        public ArrayList SeleccionarCodigo()
        {
            this.ShowDialog();
            return codigoSelecc;
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

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void Seleccionar()
        {
            if(dgvListado.SelectedRows.Count==0)
            {
                MessageBox.Show("No ha seleccionado ningun registro");
                return;
            }
            codigoSelecc.Add(dgvListado.SelectedRows[0].Cells[0].Value.ToString());
            codigoSelecc.Add(dgvListado.SelectedRows[0].Cells[1].Value.ToString());

            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Seleccionar(); 
        }
    }
}
