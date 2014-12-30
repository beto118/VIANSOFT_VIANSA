using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Pantallas.Credito;
using Punto_de_Venta.Pantallas.Proforma;

namespace Punto_de_Venta.Pantallas.Clientes
{
    public partial class Frm_ListarClientes : Form
    {
        string codSeleccionado = "";
        string modo = "";
        public Frm_ListarClientes()
        {
            InitializeComponent();
            btnEnviarFact.Visible = false;
            btnEnviarProforma.Visible = false;
            btnVerFactCred.Visible = false;
            btnCancelarFact.Visible = false;
        }
        public Frm_ListarClientes(string modoIn)
        {
            InitializeComponent();
            modo = modoIn;

            if (modoIn.Equals("SELECT"))
            {
                btnVerFactCred.Visible = false;
                btnCancelarFact.Visible = false;
                btnEnviarProforma.Visible = false;
            }
            if (modoIn.Equals("ABONO"))
            {
                btnVerFactCred.Visible = true;
                btnCancelarFact.Visible = false;
                btnEnviarFact.Visible = false;
                btnEnviarProforma.Visible = false;
            }
            if (modoIn.Equals("ENVIAR_PROFORMA"))
            {
                btnVerFactCred.Visible = false;
                btnCancelarFact.Visible = false;
                btnEnviarFact.Visible = false;
                btnEnviarProforma.Visible = true;
            }
            if (modoIn.Equals("CANCELAR_FACTURAS"))
            {
                btnCancelaFactHoy.Visible = false;
                btnVerFactCred.Visible = false;
                btnCancelarFact.Visible = true;
                btnEnviarFact.Visible = false;
                btnEnviarProforma.Visible = false;
            }
            if (modoIn.Equals("CANCELAR_FACTURAS_HOY"))
            {
                btnCancelaFactHoy.Visible = true;
                btnVerFactCred.Visible = false;
                btnCancelarFact.Visible = false;
                btnEnviarFact.Visible = false;
                btnEnviarProforma.Visible = false;
            }
        }

        private void Frm_ListarClientes_Load(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {
            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioClientes elServicio = new ServicioClientes())
                dgvListado.DataSource = elServicio.ListarClientes(txbFiltro.Text, estado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
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

        private void btnNuevoCliente_Click(object sender, EventArgs e)
        {
            Frm_RegistrarCliente elIngresar = new Frm_RegistrarCliente();
            elIngresar.ShowDialog();
            txbFiltro.Text = "";
            CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_RegistrarCliente elIngresar = new Frm_RegistrarCliente(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void btnEnviarFact_Click(object sender, EventArgs e)
        {
            if (modo.Equals("SELECT"))
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

        private void btnVerFactCred_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_ListarFactCred_x_Cliente elIngresar = new Frm_ListarFactCred_x_Cliente(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_CancelarFacturas elIngresar = new Frm_CancelarFacturas(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();
               
            }
        }

        private void btnEnviarProforma_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_RegistarProforma elIngresar = new Frm_RegistarProforma(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void btnCancelaFactHoy_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_CancelarFacturas_Hoy elIngresar = new Frm_CancelarFacturas_Hoy(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();

            }
        }
    }
}
