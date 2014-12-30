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
using System.Collections;

namespace Punto_de_Venta.Pantallas.Horas_de_Trabajo
{
    public partial class Frm_MantenimientoHoras : Form
    {
        int ConceptoPago_id= 0;
        public Frm_MantenimientoHoras()
        {
            InitializeComponent();
        }
        public Frm_MantenimientoHoras(int Usuario_codigo)
        {
            InitializeComponent();
            CargarDatos(Usuario_codigo);
            CargarHorasLab(Usuario_codigo);
            //modo = "MOD";
        }
        private void CargarDatos(int Usuario_codigo)
        {
            DataRow drUsuario = null;
            using (ServicioUsuario elServicio = new ServicioUsuario())
                drUsuario = elServicio.ConsultarUsuarios(Usuario_codigo);
            if (drUsuario != null)
            {
                txbCodigo.Text = Usuario_codigo.ToString();
                txbNombre.Text = drUsuario["Usuario_nombre"].ToString();
                txbApellido1.Text = drUsuario["Usuario_apellido1"].ToString();
                txbApellido2.Text = drUsuario["Usuario_apellido2"].ToString();
                txbCodigoBarra.Text = drUsuario["Usuario_CodigoBarra"].ToString();
                txbGanaXhora.Text = drUsuario["Usuario_GanaXhora"].ToString();
                txbGanaHora.Text = txbGanaXhora.Text;
            }
        }
        private void CargarHorasLab(int Usuario_codigo)
        {
            DataRow drUsuario = null;
            using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                drUsuario = elServicio.ConsultarTotalHorasVendedor(Usuario_codigo);
            if (drUsuario != null)
            {
                txbTotalHoras.Text = drUsuario["Horas"].ToString();
                txbTotalMinutos.Text = drUsuario["Minutos"].ToString();
              
            }
        }
        private void Frm_MantenimientoHoras_Load(object sender, EventArgs e)
        {
            CargarListado();
            CargarComboMovPagos();
            CargarListaConceptoPago();
            CargarListaPagosVendedor();
        }
        private void CargarListado()
        {

            using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                dgvListadoDiaTrabajo.DataSource = elServicio.ListarDiaTrabajoDeVendedor(txbCodigo.Text);
            using (ServicioDiaTrabajo elServicio1 = new ServicioDiaTrabajo())
                dgvListaDiasTrabajados.DataSource = elServicio1.ListarDiaTrabajoDeVendedor(txbCodigo.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListadoDiaTrabajo);
        }
        

        private void btnAgregarConcPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el concepto de Pago?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "";
                string tipo = "M";
                int TipoMov =  int.Parse(cmbxTipoMov.SelectedValue.ToString());
                using (ServicioConceptoPago elServicio = new ServicioConceptoPago())
                    respuesta = elServicio.RegistrarConceptoPago(int.Parse(txbCodigo.Text),TipoMov, double.Parse(txbMonto.Text), rtxbDetalle.Text, tipo);
                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    CargarListaConceptoPago();
                    Limpiar();
                }

            }
        }
        private bool Validar()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbMonto, elErrorProvider, "Monto"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void CargarComboMovPagos()
        {
            DataTable dtMovPago = null;
            using (ServicioMovConceptoPago elServicio = new ServicioMovConceptoPago())
                dtMovPago = elServicio.ListarMovConceptoPago("");
            cmbxTipoMov.DisplayMember = "Nombre";
            cmbxTipoMov.ValueMember = "ID";
            DataRow drCat = dtMovPago.NewRow();
            //drCat["ID"] = "0";
            //drCat["Nombre"] = "Todos";
            //dtMovPago.Rows.InsertAt(drCat,0);
            cmbxTipoMov.DataSource = dtMovPago;
            cmbxTipoMov.SelectedIndex = 0;
        }
        private void CargarListaConceptoPago()
        {

            using (ServicioConceptoPago elServicio = new ServicioConceptoPago())
                dtgConceptoPago.DataSource = elServicio.ListarConceptoPagoVendedor(txbCodigo.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgConceptoPago);
        }
        private void CargarListaPagosVendedor()
        {

            using (ServicioPagoVendedor elServicio = new ServicioPagoVendedor())
                dtgPagosVendedor.DataSource = elServicio.ListarPagosVendedor(int.Parse(txbCodigo.Text));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgPagosVendedor);
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRealizarPago_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Realizar el pago de este Empleado?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                if (!ValidarCodigo())
                    return;
                string respuesta = "";
                string DetallePago = "";
                string RespPago = "";
                using (ServicioPagoVendedor elServicio = new ServicioPagoVendedor())
                    respuesta = elServicio.RegistrarPagoVendedor(int.Parse(txbCodigo.Text), DetallePago, out RespPago);
                // MessageBox.Show(respuesta);

                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(RespPago);
                    CargarListaPagosVendedor();
                    CargarListado();
                    CargarComboMovPagos();
                    CargarListaConceptoPago();

                }
            }
            

        }
        private bool ValidarCodigo()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbCodigo, elErrorProvider, "Codigo"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void Limpiar()
        {
            cmbxTipoMov.Enabled = true;
            cmbxTipoMov.SelectedIndex = 0;
            txbMonto.Clear();
            rtxbDetalle.Clear();
        }

        private void dtgConceptoPago_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgConceptoPago.SelectedRows.Count != 0)
            {
                ConceptoPago_id = int.Parse(dtgConceptoPago.SelectedRows[0].Cells[0].Value.ToString());
                cmbxTipoMov.Text = dtgConceptoPago.SelectedRows[0].Cells[2].Value.ToString();
                txbMonto.Text = dtgConceptoPago.SelectedRows[0].Cells[3].Value.ToString();
                rtxbDetalle.Text = dtgConceptoPago.SelectedRows[0].Cells[4].Value.ToString();
                btnEditarConcepto.Visible = true;
                cmbxTipoMov.Enabled = false;
            }
        }

        private void btnEditarConcepto_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea editar el concepto de Pago?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "";
               
                using (ServicioConceptoPago elServicio = new ServicioConceptoPago())
                    respuesta = elServicio.ModificarConceptoPago(ConceptoPago_id, double.Parse(txbMonto.Text), rtxbDetalle.Text);
                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    CargarListaConceptoPago();
                    Limpiar();
                    btnEditarConcepto.Visible = false;
                }

            }
        }

        private void txbHoraEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbMinEntrada.Focus();
            }
        }
        private bool Validar1()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaIntEntre(0, 23, txbHoraEntrada, elErrorProvider, "HORA DE ENTRADA"))
                    malas++;
                if (!elValidar.ValidaIntEntre(0, 59, txbMinEntrada, elErrorProvider, "MINUTOS DE ENTRADA"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void txbMinEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (!Validar1())
                    return;
                string respuesta = "", Fecha = "";
                // int codigoGenerado = 0;

                Fecha = (dtpFechaEntrada.Text + ' ' + txbHoraEntrada.Text + ':' + txbMinEntrada.Text);

                using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                    respuesta = elServicio.InsertarEntradaDiaTrabajoManual(int.Parse(txbCodigo.Text), (Convert.ToDateTime(Fecha)));
                MessageBox.Show(respuesta);

                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    // this.Close();
                    this.dtpFechaSalida.Focus();
                }


            }
        }

        private void txbHoraSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbMinSalida.Focus();
            }
        }
        private bool Validar2()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaIntEntre(0, 23, txbHoraSalida, elErrorProvider, "HORA DE SALIDA"))
                    malas++;
                if (!elValidar.ValidaIntEntre(0, 59, txbMinSalida, elErrorProvider, "MINUTOS DE SALIDA"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void txbMinSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (!Validar2())
                    return;
                string respuesta = "", FechaHorMin = "";
                string respuestaInt = "";

                FechaHorMin = (dtpFechaSalida.Text + ' ' + txbHoraSalida.Text + ':' + txbMinSalida.Text);

                using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                    respuesta = elServicio.RegistrarSalidaManual(int.Parse(txbCodigo.Text), out respuestaInt, Convert.ToDateTime(FechaHorMin));
                MessageBox.Show(respuesta);

                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    CargarListado();
                    CargarHorasLab(int.Parse(txbCodigo.Text));
                    TotalSalario();
                    txbHoraEntrada.Clear();
                    txbHoraSalida.Clear();
                    txbMinEntrada.Clear();
                    txbMinSalida.Clear();
                    dtpFechaEntrada.Focus();
                }



            }
        }
        private void TotalSalario()
        {

            double TotalMinutos = 0, totalHoras = 0, GanaXhora = 0, SalarioTotal = 0;

            TotalMinutos = double.Parse(txbTotalMin.Text);
            totalHoras = double.Parse(txbTotalHor.Text);
            GanaXhora = double.Parse(txbGanaHora.Text);

            SalarioTotal = (totalHoras * GanaXhora) + ((TotalMinutos * GanaXhora) / 60);

            txbSalarioTotal.Text = string.Format("{0:N1}", SalarioTotal);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvListaDiasTrabajados.SelectedRows.Count > 0)
            {
                string respuesta = "";
                using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                    respuesta = elServicio.EliminarDiaTrabajo(int.Parse(dgvListaDiasTrabajados.SelectedRows[0].Cells[0].Value.ToString()));
                MessageBox.Show(respuesta);

                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    Frm_MantenimientoHoras_Load(sender, e);
                    CargarHorasLab(int.Parse(txbCodigo.Text));
                    // this.Close();
                    // this.dtpFechaSalida.Focus();
                }

            }
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            btnReporte_Click(null, null);
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            if (dtgPagosVendedor.SelectedRows.Count > 0)
            {
                ArrayList losParametros = new ArrayList();
                reporte elReporte = new reporte();

                losParametros.Add(dtgPagosVendedor.SelectedRows[0].Cells[0].Value.ToString());
                elReporte.cargarDocumento("rpt_PV_detallepago.rpt", losParametros);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirTicket elReporte = new ImprimirTicket();
            elReporte.ImprimirPagoVendedor(Conexion.laConexion.ImpresoraFactura, int.Parse(dtgPagosVendedor.SelectedRows[0].Cells[0].Value.ToString()));
        }

        private void dtpFechaEntrada_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                dtpFechaSalida.Text = dtpFechaEntrada.Text;
                txbHoraEntrada.Focus();
            }
        }

        private void dtpFechaSalida_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txbHoraSalida.Focus();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 4) dtpFechaEntrada.Focus();
        }


           

      }
}
