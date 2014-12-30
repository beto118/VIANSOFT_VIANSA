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
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Pantallas.Reportes
{
    public partial class Frm_RPT_TotalInv_X_Categoria : Form
    {
        public Frm_RPT_TotalInv_X_Categoria()
        {
            InitializeComponent();
        }


        private void CargarCombo()
        {
            DataTable dtCategoria = null;
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                dtCategoria = elServicio.ListarCategoria("", "ACT");
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
            DataRow drCat = dtCategoria.NewRow();
            drCat["ID"] = "0";
            drCat["Nombre"] = "Todos";
            dtCategoria.Rows.InsertAt(drCat, 0);
            cmbCategoria.DataSource = dtCategoria;
            cmbCategoria.SelectedIndex = 0;
        }

        private void Frm_RPT_TotalInv_X_Categoria_Load(object sender, EventArgs e)
        {
            CargarCombo();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            //laLista.Add(txbFiltro.Text);
            //laLista.Add(ckEstado.Checked ? "ACT" : "");
            laLista.Add(cmbCategoria.SelectedValue.ToString());
            elReporte.cargarDocumento("rpt_TotalInventario_X_Categoria.rpt", laLista);
        }
    }
}
