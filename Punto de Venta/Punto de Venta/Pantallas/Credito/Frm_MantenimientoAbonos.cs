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

namespace Punto_de_Venta.Pantallas.Credito
{
    public partial class Frm_MantenimientoAbonos : Form
    {
        int Abono_ID = 0;

        public Frm_MantenimientoAbonos(int Abono_IDIN)
        {
            InitializeComponent();
            Abono_ID = Abono_IDIN;
            CargarDatos(Abono_ID);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar()
        {
            if (!Validar())
                return;
            string respuesta = "";
            using (ServicioPagoProveedor elServicio = new ServicioPagoProveedor())
            {

                respuesta = elServicio.ModificarPagoProveedor(int.Parse(txbAbonoID.Text), dpFecha.Value.ToShortDateString(), int.Parse(txbCodCliente.Text), double.Parse(txbMonto.Text), txbDetalle.Text, txbEstado.Text);

            }
            MessageBox.Show(respuesta, "Procesado...");
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                this.Close();
        }

        private bool Validar()
        {
            int NumeroMalas = 0;
            elErrorProvider.Clear();
            using (Validacion laValidacion = new Validacion())
            {

                if (!laValidacion.ValidaVacio(txbCodCliente, elErrorProvider, "Movimiento Concepto Pago"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorCero(txbMonto, elErrorProvider, "Monto del Pago"))
                    NumeroMalas++;

            }
            if (NumeroMalas == 0)
                return true;//No hay malas
            else
                return false;//Hay malas



        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void CargarDatos(int Abono_ID)
        {
            DataRow drConcepto;
            using (ServicioAbono elServicioPagoProveedor = new ServicioAbono())
                drConcepto = elServicioPagoProveedor.ConsultarAbono(Abono_ID);
            txbAbonoID.Text = Abono_ID.ToString();
            dpFecha.Value = DateTime.Parse(drConcepto["abono_Fecha"].ToString());
            txbCodCliente.Text = drConcepto["Clie_ID"].ToString();
            DataRow drMov;
            using (ServicioClientes elServicioProveedor = new ServicioClientes())
                drMov = elServicioProveedor.ConsultarClientesXCodigo(int.Parse(drConcepto["Clie_ID"].ToString()));
            txbNomCliente.Text = drMov["Clie_Nombre"].ToString();

            txbMonto.Text = string.Format("{0:n1}", double.Parse(drConcepto["PagoProveedor_Monto"].ToString()));
            txbDetalle.Text = drConcepto["abono_Detalle"].ToString();
            txbEstado.Text = drConcepto["abono_Estado"].ToString();
            txbUsuario.Text = drConcepto["Usuario_ID"].ToString();



        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea eliminar el pago ID es " + txbAbonoID.Text + " con monto " + string.Format("{0:n1}", double.Parse(txbMonto.Text)) + "?", "Eliminar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioAbono elServicio = new ServicioAbono())
                    respuesta = elServicio.EliminarAbono(int.Parse(txbAbonoID.Text));
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    this.Close();
                else
                    MessageBox.Show(respuesta);


            }
        }


    }
}
