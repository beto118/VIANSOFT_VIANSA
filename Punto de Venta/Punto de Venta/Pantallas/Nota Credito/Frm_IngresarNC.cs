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
using Punto_de_Venta.Pantallas.Clientes;
using Punto_de_Venta.Reportes;

namespace Punto_de_Venta.Pantallas.Nota_Credito
{
    public partial class Frm_IngresarNC : Form
    {
        string modo = "";
        public Frm_IngresarNC()
        {
            InitializeComponent();
            modo = "INS";
        }
        public Frm_IngresarNC(int NC_id)
        {
            InitializeComponent();
            CargarDatos(NC_id);
            modo = "MOD";
        }
        private void CargarDatos(int NC_id)
        {
            DataRow drNC = null;
            using (ServicioNotaCredito elServicio = new ServicioNotaCredito())
                drNC = elServicio.ConsultarNC(NC_id);
            if (drNC != null)
            {
                txbID.Text = NC_id.ToString();
                txbCodigoCliente.Text = drNC["NC_ClienteID"].ToString();
                txbMonto.Text = drNC["NC_Monto"].ToString();
                txbDetalle.Text = drNC["NC_Detalle"].ToString();
                chkEstado.Checked = drNC["NC_Estado"].ToString().Equals("ACT");
                lblUsuarioID.Text = drNC["NC_UsuarioId"].ToString();

                CargarDatosCliente(int.Parse(txbCodigoCliente.Text));
            }

        }
        private bool Validar()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaDoubleMayorIgualCero(txbMonto, elErrorProvider, "monto de la nota"))
                    malas++;
                if (!elValidar.ValidaEspaciosBlancos(txbCodigoCliente, elErrorProvider, "cliente de la nota"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la Nota de Credito?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (chkEstado.Checked) estado = "ACT";
                if (modo.Equals("INS"))
                {
                    using (ServicioNotaCredito elServicio = new ServicioNotaCredito())
                        respuesta = elServicio.InsertarNC(out codigoGenerado,int.Parse(txbCodigoCliente.Text),int.Parse(lblUsuarioID.Text),double.Parse(txbMonto.Text), txbDetalle.Text, "ACT");
                    MessageBox.Show("El codigo generado es: " + codigoGenerado.ToString());
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }


                }
                else//se va modificar 
                {
                    using (ServicioNotaCredito elServicio = new ServicioNotaCredito())
                        respuesta = elServicio.ModificarNC(int.Parse(txbID.Text), int.Parse(lblUsuarioID.Text),double.Parse(txbMonto.Text), txbDetalle.Text,estado);
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }
                }
            }
        }

        private void BtnBuscarClientes_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes elCliente = new Frm_ListarClientes("SELECT");
            string elProducto = elCliente.SeleccionarCodigo();
            if (elProducto.Length != 0)
            {
                txbCodigoCliente.Text = elProducto;
                CargarDatosCliente(int.Parse(elProducto));
            }
        }
        private void CargarDatosCliente(int Cliente_codigo)
        {
            DataRow drCliente = null;
            using (ServicioClientes elServicio = new ServicioClientes())
                drCliente = elServicio.ConsultarClientesXCodigo(Cliente_codigo);
            if (drCliente != null)
            {
                txbCodigoCliente.Text = Cliente_codigo.ToString();
                txbNombreCliente.Text = drCliente["Clie_Nombre"].ToString() + " " + drCliente["Clie_Apellido1"].ToString() + " " + drCliente["Clie_Apellido2"].ToString();
 
            }
            else
            {
                MessageBox.Show("Codigo invalido", "ERROR BUSCA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //imprimir ORDEN
            using (ImprimirTicket elImprimir = new ImprimirTicket())
                elImprimir.ImprimirNotaCredito(int.Parse(txbID.Text), Conexion.laConexion.ImpresoraFactura);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
    }
}
