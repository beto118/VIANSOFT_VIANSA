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
using Punto_de_Venta.Reportes;
using Punto_de_Venta.Pantallas.Orden_de_Compra;

namespace Punto_de_Venta.Pantallas.Varias
{
    public partial class Frm_Mantenimiento_HistFact : Form
    {
        public double Saldo = 0;
        int Modo = 0;
        public Frm_Mantenimiento_HistFact(int FactNum,int tipo)
        {
            InitializeComponent();
            Modo = tipo;
            if(Modo.Equals(0)) CargarDatos(FactNum);
            else CargarDatosOrden(FactNum);
        }

        private void CargarDatos(int FactNum)
        {
            DataRow drFactura = null;
            using (ServicioFactura elServicio = new ServicioFactura())
                drFactura = elServicio.ConsultarHistFactura(FactNum);
            if (drFactura != null)
            {
                txbId_Factura.Text = FactNum.ToString();
                txbCaja.Text = drFactura["Caja_numero"].ToString();
                txbCodVendedor.Text = drFactura["Usuario_codigo"].ToString();
                txbVendedor.Text = drFactura["Usuario_nombre"].ToString();
                txbCodCliente.Text = drFactura["Clie_Id"].ToString();
                txbCliente.Text = drFactura["Cliente"].ToString();
                txbFecha.Text = drFactura["HistFact_fecha"].ToString();
                txbFechaVence.Text = drFactura["HistFact_fechaLimite"].ToString();
                txbHora.Text = drFactura["HistFact_hora"].ToString();
                txbEstado.Text = drFactura["HistFact_estado"].ToString();
                if (!txbEstado.Text.Equals("ANULADA"))
                {
                    btnAnular.Visible = true;
                    btnActivar.Visible = false;
                }
                else
                {
                    btnActivar.Visible = true;
                    btnAnular.Visible = false;
                }
                txbSubTotal.Text = string.Format("{0:n1}", double.Parse(drFactura["HistFact_subtotal"].ToString()));
                txbIV.Text = string.Format("{0:n1}", double.Parse(drFactura["HistFact_impuesto"].ToString()));
                txbDesc.Text = string.Format("{0:n1}", double.Parse(drFactura["HistFact_totalDescuento"].ToString()));
                lblDescuento.Text = string.Format("{0:n0}", double.Parse(drFactura["HistFact_descuento"].ToString())) + "%";
                txbTotalFact.Text = string.Format("{0:n1}", double.Parse(drFactura["HistFact_total"].ToString()));
                txbSaldo.Text = string.Format("{0:n1}", double.Parse(drFactura["HistFact_Saldo"].ToString()));
                Saldo = double.Parse(drFactura["HistFact_Saldo"].ToString());
                txbDetalle.Text = drFactura["HistFact_TarjetaDetalle"].ToString();
                txbTipo.Text = drFactura["TipoPago_Descripcion"].ToString();

                using (ServicioFactura elServicio = new ServicioFactura())
                    dgvListado.DataSource = elServicio.ConsultarHistLineaDGV(FactNum);
                using (Validacion laValidacion = new Validacion())
                    laValidacion.DarFormatoDecimalGrid(dgvListado);

            }
        }
        private void CargarDatosOrden(int FactNum)
        {
            DataRow drFactura = null;
            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                drFactura = elServicio.ConsultarHistOrdenCompra(FactNum);
            if (drFactura != null)
            {
                txbId_Factura.Text = FactNum.ToString();
                txbCaja.Text = drFactura["Caja_numero"].ToString();
                txbCodVendedor.Text = drFactura["Usuario_codigo"].ToString();
                txbVendedor.Text = drFactura["Usuario_nombre"].ToString();
                txbCodCliente.Text = drFactura["Clie_Id"].ToString();
                txbCliente.Text = drFactura["Cliente"].ToString();
                txbFecha.Text = drFactura["HistFact_fecha"].ToString();
                //txbFechaVence.Text = drFactura["HistFact_fechaLimite"].ToString();
                txbHora.Text = drFactura["HistFact_hora"].ToString();
                txbEstado.Text = drFactura["HisOrden_estado"].ToString();
                if (!txbEstado.Text.Equals("ANULADA"))
                {
                    btnAnular.Visible = true;
                    btnActivar.Visible = false;
                }
                else
                {
                    btnActivar.Visible = true;
                    btnAnular.Visible = false;
                }
                txbSubTotal.Text = string.Format("{0:n1}", double.Parse(drFactura["HisOrden_subtotal"].ToString()));
                txbIV.Text = string.Format("{0:n1}", double.Parse(drFactura["HisOrden_impuesto"].ToString()));
                txbDesc.Text = string.Format("{0:n1}", double.Parse(drFactura["HisOrden_TotalDescuento"].ToString()));
                lblDescuento.Text = string.Format("{0:n0}", double.Parse(drFactura["HisOrden_descuento"].ToString())) + "%";
                txbTotalFact.Text = string.Format("{0:n1}", double.Parse(drFactura["HisOrden_total"].ToString()));
               // txbSaldo.Text = string.Format("{0:n1}", double.Parse(drFactura["HistFact_Saldo"].ToString()));
              //  Saldo = double.Parse(drFactura["HistFact_Saldo"].ToString());
                txbDetalle.Text = drFactura["HisOrden_TarjetaDetalle"].ToString();
                txbTipo.Text = drFactura["TipoPago_Descripcion"].ToString();

                txbSaldo.Visible = false;
                lblSaldo.Visible = false;

                using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                    dgvListado.DataSource = elServicio.ConsultarHistLineaOrdenCompraDGV(FactNum);
                using (Validacion laValidacion = new Validacion())
                    laValidacion.DarFormatoDecimalGrid(dgvListado);

            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (Modo.Equals(0))
            {
                if (MessageBox.Show("¿Desea imprimir la factura?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //imprimir factura
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirHistFactura(int.Parse(txbId_Factura.Text), Conexion.laConexion.ImpresoraFactura);
                }
            }
            else
            {
                if (MessageBox.Show("¿Desea imprimir la Orden?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //imprimir factura
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirHistOrden(int.Parse(txbId_Factura.Text), Conexion.laConexion.ImpresoraFactura);
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (Modo.Equals(0))
            {
                if (MessageBox.Show("¿Desea ANULAR la factura?", "ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuesta = elServicio.ModificarEstadoHistorial(int.Parse(txbId_Factura.Text), "ANULADA");
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        MessageBox.Show(respuesta);
                    else
                        this.Close();
                }
            }
            else
            {
                if (MessageBox.Show("¿Desea ANULAR la ORDEN?", "ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                        respuesta = elServicio.ModificarEstadoHistorial(int.Parse(txbId_Factura.Text), "ANULADA");
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        MessageBox.Show(respuesta);
                    else
                        this.Close();
                }
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (Modo.Equals(0))
            {
                if (MessageBox.Show("¿Desea Activar la factura?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (Saldo == 0)
                    {
                        string respuesta = "";
                        using (ServicioFactura elServicio = new ServicioFactura())
                            respuesta = elServicio.ModificarEstadoHistorial(int.Parse(txbId_Factura.Text), "CANCELADA");
                        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                            MessageBox.Show(respuesta);

                    }
                    else
                    {
                        string respuesta = "";
                        using (ServicioFactura elServicio = new ServicioFactura())
                            respuesta = elServicio.ModificarEstadoHistorial(int.Parse(txbId_Factura.Text), "CREDITO");
                        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                            MessageBox.Show(respuesta);
                    }
                    this.Close();

                }
            }
            else//ordenes de compra
            {
                if (MessageBox.Show("¿Desea Activar la Orden de compra?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                  
                    string respuesta = "";
                    using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                        respuesta = elServicio.ModificarEstadoHistorial(int.Parse(txbId_Factura.Text), "PAGA");
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        MessageBox.Show(respuesta);
                                                       
                    this.Close();

                }
 
            }
        }

    }
}
