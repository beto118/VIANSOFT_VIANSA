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
using System.Collections;

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_MantPagoProveedor2 : Form
    {
        
        int PagoProveedor_id = 0;
        public Frm_MantPagoProveedor2(int PagoProveedor_idIN)
        {
            InitializeComponent();
            PagoProveedor_id = PagoProveedor_idIN;
            CargarDatos(PagoProveedor_id);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        
        
        private void CargarDatos(int Codigo)
        {
            DataRow drConcepto;
            using (ServicioPagoProveedor elServicioPagoProveedor = new ServicioPagoProveedor())
                drConcepto = elServicioPagoProveedor.ConsultarPagoProveedor(Codigo);
            txbCodigoPagoProveedor.Text = Codigo.ToString();
            dpFecha.Value =DateTime.Parse(drConcepto["PagoProveedor_fecha"].ToString());
            txbCodProveedor.Text = drConcepto["Proveedor_id"].ToString();
            DataRow drMov;
            using (ServicioProveedor elServicioProveedor = new ServicioProveedor())
                drMov = elServicioProveedor.ConsultarProveedor(int.Parse(drConcepto["Proveedor_id"].ToString()));
            txbNomProveedor.Text = drMov["Proveedor_nombre"].ToString();
            
            txbMonto.Text = string.Format("{0:n1}", double.Parse(drConcepto["PagoProveedor_Monto"].ToString()));
            txbDetalle.Text = drConcepto["PagoProveedor_detalle"].ToString();
            txbEstado.Text = drConcepto["PagoProveedor_estado"].ToString();
            txbUsuario.Text = drConcepto["usuario_codigo"].ToString();
          

           
        }
        

        private void txbCodMov_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            Frm_SelecProveedor losMovs = new Frm_SelecProveedor();
            ArrayList elMov = losMovs.SeleccionarCodigo();
            if (elMov.Count != 0)
            {
                txbCodProveedor.Text = elMov[0].ToString();
                DataRow drMov;
                using (ServicioProveedor elServicioPagoProveedor = new ServicioProveedor())
                    drMov = elServicioPagoProveedor.ConsultarProveedor(int.Parse(elMov[0].ToString()));
                txbNomProveedor.Text = drMov["Proveedor_nombre"].ToString();
                
            }

        }

        private bool Validar()
        {
            int NumeroMalas = 0;
            elErrorProvider.Clear();
            using (Validacion laValidacion = new Validacion())
            {
            
                if (!laValidacion.ValidaVacio(txbCodProveedor, elErrorProvider, "Movimiento Concepto Pago"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorCero(txbMonto, elErrorProvider, "Monto del Pago"))
                    NumeroMalas++;
                
            }
            if (NumeroMalas == 0)
                return true;//No hay malas
            else
                return false;//Hay malas



        }
        private void guardar()
        {
            if (!Validar())
                return;
            string respuesta = "";
            using (ServicioPagoProveedor elServicio = new ServicioPagoProveedor())
            {
                
                        respuesta = elServicio.ModificarPagoProveedor(int.Parse(txbCodigoPagoProveedor.Text),dpFecha.Value.ToShortDateString(),int.Parse(txbCodProveedor.Text), double.Parse(txbMonto.Text), txbDetalle.Text,txbEstado.Text);
                    
            }
            MessageBox.Show(respuesta, "Procesado...");
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta) )
                this.Close();
        }

        private void btnNuevoProveedor_Click(object sender, EventArgs e)
        {
            Frm_MantProveedor elFormularioMantenimiento =
                new Frm_MantProveedor();
            elFormularioMantenimiento.ShowDialog();
        }

       

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea eliminar el pago ID es " + txbCodigoPagoProveedor.Text + " con monto " + string.Format("{0:n1}", double.Parse(txbMonto.Text)) + "?", "Eliminar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioPagoProveedor elServicio = new ServicioPagoProveedor())
                    respuesta = elServicio.EliminarPagoProveedor(int.Parse(txbCodigoPagoProveedor.Text));
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    this.Close();
                else
                    MessageBox.Show(respuesta);


            }
        }

    }
}
