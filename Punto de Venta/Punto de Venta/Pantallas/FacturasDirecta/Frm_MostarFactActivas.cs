using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.FacturasDirecta
{
    public partial class Frm_MostarFactActivas : Form
    {
        public Frm_MostarFactActivas()
        {
            InitializeComponent();
            CargarComboEmpleados();
            CargarFacturasActivas(txbFiltro.Text);
        }

        private void CargarComboEmpleados()
        {
            using (ServicioUsuario elServ = new ServicioUsuario())
                cbxVendedor.DataSource = elServ.ListarUsuarios("", "ACT");
            cbxVendedor.ValueMember = "Codigo";
            cbxVendedor.DisplayMember = "Nombre";
            cbxVendedor.SelectedValue = Principal.elUsuario.Codigo;

        }

        private void CargarFacturasActivas(string filtro)
        {
            try
            {
                DataTable dtFacturas = null;
                //tab1.Text = Categoria_nombre;
                using (ServicioFactura elServicio = new ServicioFactura())
                    dtFacturas = elServicio.ListarFacturasBotones(filtro);
                flp_tab1.Controls.Clear();
                Button elButon = new Button();
                foreach (DataRow laFila in dtFacturas.Rows)
                {
                    elButon = new Button();
                    elButon.Height = 60;
                    elButon.Width = 150;
                    elButon.Tag = laFila["Fact"].ToString();
                    elButon.Click += new System.EventHandler(this.EventoClick);
                    elButon.Text = laFila["Cliente"].ToString() + "\n" + string.Format("{0:n1}",laFila["Total"]) ;//+ "\n" + laFila["NombreUser"].ToString()
                    flp_tab1.Controls.Add(elButon);
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void EventoClick(object sender, EventArgs e)
        {
            try
            {
                string cod = ((Button)sender).Tag.ToString();
                FrmFacturaDirecta elIngresar = new FrmFacturaDirecta(int.Parse(cod));
                elIngresar.ShowDialog();
                //CargarCombo();
                CargarFacturasActivas(txbFiltro.Text);
            }
            catch
            {
                MessageBox.Show("Error al seleccionar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Frm_MostarFactActivas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnNuevaFactura_Click(null, null);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnNuevaFactura_Click(object sender, EventArgs e)
        {
            FrmFacturaDirecta forma = new FrmFacturaDirecta();
            forma.ShowDialog();
            CargarFacturasActivas(txbFiltro.Text);

        }

        
    }
}
