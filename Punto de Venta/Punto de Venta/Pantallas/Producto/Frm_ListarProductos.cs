using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Clases;
using Punto_de_Venta.Logica_de_Negocio;
using Componentes.Sistemas.Clases;
using System.Collections;

namespace Punto_de_Venta.Pantallas.Producto
{
    public partial class Frm_ListarProductos : Form
    {
        string modo = "";
        string codSeleccionado = "";
        public Frm_ListarProductos(string modoIn)
        {
            InitializeComponent();
            modo = modoIn;
            CargarCombo();
            if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
            {//desactivar los accesos a los usuarios
                btnEditar.Visible = false;
                btnNuevo.Visible = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarCombo()
        {
            DataTable dtCategoria=null;
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                dtCategoria = elServicio.ListarCategoria("", "ACT");
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
            DataRow drCat=dtCategoria.NewRow();
            drCat["ID"]="0";
            drCat["Nombre"]="Todos";
            dtCategoria.Rows.InsertAt(drCat,0);
            cmbCategoria.DataSource = dtCategoria;
            cmbCategoria.SelectedIndex=0;
        }

        private void CargarListado()
        {
            string estado="";
            if(ckEstado.Checked)estado="ACT";
            using (ServicioProductos elServicio = new ServicioProductos())
                dgvListado.DataSource = elServicio.ListarProductos(txbFiltro.Text, estado,int.Parse(cmbCategoria.SelectedValue.ToString()));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void ListarProductos_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            IngresarProducto elIngresar = new IngresarProducto();
            elIngresar.ShowDialog();
            CargarCombo();
            CargarListado();
        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                IngresarProducto elIngresar = new IngresarProducto(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                //CargarCombo();
                CargarListado();
            }

        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
   
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (modo.Equals("SELECCIONAR"))
            {
                codSeleccionado = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                CargarListado();
                this.Close();
            }

        }
        public string SeleccionarCodigo()
        {
            this.ShowDialog();
            return codSeleccionado;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (modo.Equals("SELECCIONAR"))
            {
                codSeleccionado = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                CargarListado();
                this.Close();
            }
        }

        private void Frm_ListarProductos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F12)
            {
                btnCancelar_Click(null, null);
            }
            if (e.KeyCode == Keys.Down)
            {
                dgvListado.Select();
            } 

            if (e.KeyCode == Keys.ControlKey)
            {
                btnAgregar_Click(null, null);
                
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            laLista.Add(txbFiltro.Text);
            laLista.Add(ckEstado.Checked?"ACT":"");
            laLista.Add(cmbCategoria.SelectedValue.ToString());
            elReporte.cargarDocumento("rpt_PV_ListadoProductos_XCategoria.rpt", laLista);
        }

        private void btnRegistrarInvetario_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_ModificarCantidad elCambioCantidad = new Frm_ModificarCantidad(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elCambioCantidad.ShowDialog();
                CargarListado();
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
