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

namespace Punto_de_Venta.Pantallas.Proforma
{
    public partial class Frm_ListarProformas : Form
    {
        public Frm_ListarProformas()
        {
            InitializeComponent();
            CargarListado();
            txbFiltro.Select();
        }
        private void CargarListado()
        {
            using (ServicioProforma elServicio = new ServicioProforma())
                dgvListado.DataSource = elServicio.ListarProformas(txbFiltro.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnver_Click(object sender, EventArgs e)
        {

        }
    }
}
