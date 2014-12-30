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

namespace Punto_de_Venta.Pantallas.Clientes
{
    public partial class Frm_RegistrarCliente : Form
    {
        string modo = "";
        public Frm_RegistrarCliente()
        {
            InitializeComponent();
            
            LimpiarCampos();
        }
        public Frm_RegistrarCliente(int Cliente_ID)
        {
            InitializeComponent();
            CargarDatos(Cliente_ID);
            modo = "MOD";
        }

        private void Frm_RegistrarCliente_Load(object sender, EventArgs e)
        {
            txbFechaReg.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void CargarDatos(int Cliente_ID)
        {
            
            DataRow drCliente = null;
            using (ServicioClientes elServicio = new ServicioClientes())
                drCliente = elServicio.ConsultarClientesXCodigo(Cliente_ID);
            if (drCliente != null)
            {
                txbCodigo.Text = Cliente_ID.ToString();
                txbCedula.Text = drCliente["Clie_Cedula"].ToString();
                txbNombre.Text = drCliente["Clie_Nombre"].ToString();
                txbApellido1.Text = drCliente["Clie_Apellido1"].ToString();
                txbApellido2.Text = drCliente["Clie_Apellido2"].ToString();
                txbTelefono.Text = drCliente["Clie_Telefono"].ToString();
                txbDireccion.Text = drCliente["Clie_Direccion"].ToString();
                cmbTipoClie.Text = drCliente["Clie_TipoCliente"].ToString();
                chkComision.Checked = drCliente["Clie_Comisionista"].ToString().Equals("SI");

                numUDcomision.Text = (double.Parse(drCliente["Clie_PorcentComision"].ToString())*100).ToString();
               
                chkEstado.Checked = drCliente["Clie_Estado"].ToString().Equals("ACT");
                txbFechaReg.Text = drCliente["Clie_FechaRegistro"].ToString();
                txbCredMaximo.Text = drCliente["Clie_CreditoMaximo"].ToString();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el Cliente?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "", estado = "INA", comision = "NO";
                int codigoGenerado = 0;

                double porcentaje = 0;

                porcentaje = (int.Parse(numUDcomision.Text)) / 100;

                if (chkEstado.Checked) estado = "ACT";
                if (chkComision.Checked) comision = "SI";
                if (modo.Equals("INS"))
                    using (ServicioClientes elServicio = new ServicioClientes())
                        respuesta = elServicio.InsertarClientes(out codigoGenerado, txbCedula.Text, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, txbTelefono.Text, txbDireccion.Text, cmbTipoClie.Text, comision, porcentaje, "ACT", DateTime.Parse(txbFechaReg.Text), double.Parse(txbCredMaximo.Text));
                else
                    using (ServicioClientes elServicio = new ServicioClientes())
                        respuesta = elServicio.ModificarClientes(int.Parse(txbCodigo.Text), txbCedula.Text, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, txbTelefono.Text, txbDireccion.Text, cmbTipoClie.Text, comision, porcentaje, estado, double.Parse(txbCredMaximo.Text));

                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    this.Close();


            }
        }
        private bool Validar()
        {
            int malas=0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                //if (!elValidar.ValidaVacio(txbCedula, elErrorProvider, "Cedula de Cliente"))
                    //malas++;
                if (!elValidar.ValidaVacio(txbNombre, elErrorProvider, "Nombre de Cliente"))
                    malas++;
                //if (!elValidar.ValidaVacio(txbApellido1, elErrorProvider, "apellido1 del Cliente"))
                //    malas++;
                //if (!elValidar.ValidaVacio(txbApellido2, elErrorProvider, "apellido2 del Cliente"))
                 //   malas++;
            }
            if (malas == 0)
                return true;
            else
                return false;
        }
        private void CargarCombo()
        {
            using (ServicioTipoClientes elServicio = new ServicioTipoClientes())
                cmbTipoClie.DataSource = elServicio.ListarTipoClientes("", "ACT");
            cmbTipoClie.DisplayMember = "Nombre";
            cmbTipoClie.ValueMember = "ID";
            cmbTipoClie.SelectedIndex = -1;
        }
        private void LimpiarCampos()
        {
            txbCedula.Clear();
            txbCodigo.Clear();
            txbNombre.Clear();
            txbApellido1.Clear();
            txbApellido2.Clear();
            txbTelefono.Clear();
            numUDcomision.Value = 0;
            txbDireccion.Clear();
            txbFechaReg.Text = DateTime.Now.ToString("dd/MM/yyyy");
            modo = "INS";
            chkEstado.Checked = true;
            cmbTipoClie.SelectedIndex = 0;
            txbCedula.Focus();
        }

        private void chkComision_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComision.Checked == true) numUDcomision.Enabled = true;
            else numUDcomision.Enabled = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chkComision_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkComision.Checked == true) numUDcomision.Enabled = true;
            else
            {
                numUDcomision.Enabled = false;
                numUDcomision.Value = 0;
            }
        }

        private void cmbTipoClie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbTipoClie.SelectedIndex == 0) txbCredMaximo.Text = "0.0";
            if (cmbTipoClie.SelectedIndex == 1) txbCredMaximo.Text = "20000";
            if (cmbTipoClie.SelectedIndex == 2) txbCredMaximo.Text = "50000";
            if (cmbTipoClie.SelectedIndex == 3) txbCredMaximo.Text = "100000";
            if (cmbTipoClie.SelectedIndex == 4) txbCredMaximo.Text = "5000000";
            if (cmbTipoClie.SelectedIndex == 5) txbCredMaximo.Text = "0.0";
        }

   

        
    }
}
