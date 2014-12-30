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

namespace Punto_de_Venta.Pantallas.Cierre_de_Cajas
{
    public partial class Frm_ListadoCierresPendientes : Form
    {
        public Frm_ListadoCierresPendientes()
        {
            InitializeComponent();
            using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                dgvListado.DataSource = elServicio.ListarDetalleCierres(0);
            Validacion laValidacion = new Validacion();
            laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {

                Frm_ConsultaDetalleCierre elfrmConsultar = new Frm_ConsultaDetalleCierre(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()),1);
                elfrmConsultar.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
