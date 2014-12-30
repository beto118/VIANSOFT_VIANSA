using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Logica_de_Negocio;
using System.Collections;

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_MantProveedor : Form
    {
        string modo = "";
        private float cantidad;
        public Frm_MantProveedor(int Proveedor_id,string accion)
        {
            
            InitializeComponent();
            CargarDatosProveedor(Proveedor_id);

            if (accion.Equals("EDITPRO")) tcPRoveedor.TabPages.Remove(tpFacturas);
            
            else if (accion.Equals("NUEVAFACT")) tcPRoveedor.TabPages.Remove(tpDetalle);
        }
        
        public void CargarDatosProveedor(int codigo)
        {
            txbCodigo.Enabled = false;
            modo = "MOD";
            DataRow drProveedor;
            using (ServicioProveedor elServicio = new ServicioProveedor())
                drProveedor = elServicio.ConsultarProveedor(codigo);
            txbCodigo.Text = codigo.ToString();
            txbNombre.Text = drProveedor["Proveedor_nombre"].ToString();
            txbRepresentante.Text = drProveedor["Proveedor_Representante"].ToString();
            txbTel1.Text = drProveedor["Proveedor_tel1"].ToString();
            txbTel2.Text = drProveedor["Proveedor_tel2"].ToString();
            txbLugar.Text = drProveedor["Proveedor_lugar"].ToString();
            txbDetalle.Text = drProveedor["Proveedor_detalle"].ToString();
            cmbDia.SelectedIndex = int.Parse(drProveedor["Proveedor_diaPasa"].ToString());
            CargarFacturas();

        }

        private void CargarFacturas()
        {

            using (ServicioFactProveedor elServicio = new ServicioFactProveedor())
                dgvListado.DataSource = elServicio.ListarFactProveedor(txbFiltro.Text, int.Parse(txbCodigo.Text), ckSaldo.Checked ? 1 : 0);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        public Frm_MantProveedor()
        {
            InitializeComponent();
            nuevo();
        }


        private bool Validar()
        {
            int NumeroMalas = 0;
            elErrorProvider.Clear();
            using (Validacion laValidacion = new Validacion())
            {
                if (!modo.Equals("INS"))
                    if (!laValidacion.ValidaVacio(txbCodigo, elErrorProvider, "Codigo del Proveedor"))
                        NumeroMalas++;
                if (!laValidacion.ValidaVacio(txbNombre, elErrorProvider, "Nombre del Proveedor"))
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
            //if (!ckEstado.Checked) estado = "INA";
            using (ServicioProveedor elServicio = new ServicioProveedor())
            {
                if (this.modo.Equals("INS"))
                {
                    respuesta = elServicio.InsertarProveedor(txbNombre.Text, txbRepresentante.Text, txbTel1.Text, txbTel2.Text, txbLugar.Text, cmbDia.SelectedIndex.ToString(), txbDetalle.Text);
                }
                else
                {

                    respuesta = elServicio.ModificarProveedor(int.Parse(txbCodigo.Text), txbNombre.Text, txbRepresentante.Text, txbTel1.Text, txbTel2.Text, txbLugar.Text, cmbDia.SelectedIndex.ToString(), txbDetalle.Text);
                }
            }
            MessageBox.Show(respuesta, "Procesado...");
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                this.Close();
        }

       
        private void nuevo()
        {
            //txbCodigo.Enabled = true;
            cantidad = 0;

            this.txbCodigo.Text = txbNombre.Text = txbTel1.Text = txbTel2.Text = "";
            txbLugar.Text = txbDetalle.Text = "";
            cmbDia.SelectedIndex = 0;
            this.modo = "INS";
            tcPRoveedor.TabPages.Remove(tpFacturas);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {
                Frm_MantFactProveedor elMantenimiento =
                    new Frm_MantFactProveedor(int.Parse(this.dgvListado.SelectedCells[0].Value.ToString()));
                elMantenimiento.ShowDialog();
                CargarFacturas();
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_MantFactProveedor elMantenimiento = new Frm_MantFactProveedor(txbCodigo.Text, txbNombre.Text);
            elMantenimiento.ShowDialog();
            CargarFacturas();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void ckSaldo_CheckedChanged(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            laLista.Add(txbFiltro.Text);
            laLista.Add(txbCodigo.Text);
            laLista.Add(ckSaldo.Checked ? "1" : "0");
            elReporte.cargarDocumento("rpt_PV_FactProveedor.rpt", laLista);
            
        }
                   
        
    }
}
