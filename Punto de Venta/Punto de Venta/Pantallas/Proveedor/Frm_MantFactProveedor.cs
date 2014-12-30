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
using Punto_de_Venta.Pantallas.Producto;

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_MantFactProveedor : Form
    {
        
        string modo = "";
        public Frm_MantFactProveedor(int codigo)
        {
            InitializeComponent();
            CargarDatos(codigo);
        }
        public Frm_MantFactProveedor(string proveedor_codigo, string proveedor_nombre)
        {
            InitializeComponent();
            txbProveedor_id.Text = proveedor_codigo;
            txbProveedor_nombre.Text = proveedor_nombre;
            nuevo();
        }

       
        private void nuevo()
        {
            modo = "INS";
            txbID.Text = "";
            tcFactura.TabPages.Remove(tpPagos);
            tcFactura.TabPages.Remove(tpNC);
            btnReporteFactura.Visible = false;
            txbFecha.Value = DateTime.Now;
            txbFecLimite.Value = DateTime.Now;
            txbMonto.Text =
            txbSaldo.Text =
            txbIV.Text =
            txbDescuento.Text = "0";
            txbDetalle.Text =
                txbNumero.Text="";
            dgvDetalle.DataSource = null;
            pnlDetalle.Visible = false;
            //this.Height = 250;
            using (ServicioFactProveedor elServicio = new ServicioFactProveedor())
                dgvListado.DataSource = elServicio.ListarPagosDeFactura(0);
            txbNumero.Select();
        }
        private void guardar()
        {
            if (!Validar())
                return;
            string respuesta="";
            using (ServicioFactProveedor elServicio = new ServicioFactProveedor())
            {
                if (modo.Equals("INS"))
                { 
                    int codigo=0;
                    respuesta = elServicio.InsertarFactProveedor(out codigo, txbNumero.Text, txbFecha.Value.ToShortDateString(), txbFecLimite.Value.ToShortDateString(), double.Parse(txbMonto.Text),
                        txbDetalle.Text, double.Parse(txbIV.Text), double.Parse(txbDescuento.Text), int.Parse(txbProveedor_id.Text));
                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        //this.Height = 530;
                        pnlDetalle.Visible = true;
                        modo = "MOD";
                        txbID.Text = codigo.ToString();
                        tcFactura.TabPages.Add(tpPagos);
                        tcFactura.TabPages.Add(tpNC);
                        CargarDatos(codigo);
                        txbProducto_codigo.Select();
                    }
                }
                else
                {
                    respuesta = elServicio.ModificarFactProveedor(int.Parse(txbID.Text), txbNumero.Text, txbFecha.Value.ToShortDateString(), txbFecLimite.Value.ToShortDateString(), double.Parse(txbMonto.Text),
                         double.Parse(txbSaldo.Text), txbDetalle.Text, double.Parse(txbIV.Text), double.Parse(txbDescuento.Text), int.Parse(txbProveedor_id.Text));
                }
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    MessageBox.Show(respuesta);
            }
            
        }

        private bool Validar()
        {
            int NumeroMalas = 0;
            elErrorProvider.Clear();
            using (Validacion laValidacion = new Validacion())
            {

                if (!laValidacion.ValidaDoubleMayorIgualCero(txbMonto, elErrorProvider, "Monto"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorIgualCero(txbSaldo, elErrorProvider, "Saldo"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorIgualCero(txbIV, elErrorProvider, "IV"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorIgualCero(txbDescuento, elErrorProvider, "Descuento"))
                    NumeroMalas++;

            }
            if (NumeroMalas == 0)
                return true;//No hay malas
            else
                return false;//Hay malas
        }
        private void CargarDatos(int codigo)
        {
            DataRow drFactura = null;
            using (ServicioFactProveedor elServicio = new ServicioFactProveedor())
                drFactura = elServicio.ConsultarFactProveedor(codigo);
            if (drFactura != null)
            {
                modo = "MOD";
                btnReporteFactura.Visible = true;
                txbID.Text = codigo.ToString();
                txbNumero.Text = drFactura["FactProveedor_numero"].ToString();
                txbFecha.Value = new DateTime(int.Parse(drFactura["FactProveedor_fecha"].ToString().Substring(0, 4)),
                                            int.Parse(drFactura["FactProveedor_fecha"].ToString().Substring(4, 2)),
                                            int.Parse(drFactura["FactProveedor_fecha"].ToString().Substring(6, 2)));

                txbFecLimite.Value = new DateTime(int.Parse(drFactura["FactProveedor_fechaLimite"].ToString().Substring(0, 4)),
                                            int.Parse(drFactura["FactProveedor_fechaLimite"].ToString().Substring(4, 2)),
                                            int.Parse(drFactura["FactProveedor_fechaLimite"].ToString().Substring(6, 2)));
                txbMonto.Text = string.Format("{0:n1}", double.Parse(drFactura["FactProveedor_monto"].ToString()));
                txbSaldo.Text = string.Format("{0:n1}", double.Parse(drFactura["FactProveedor_Saldo"].ToString()));
                txbIV.Text = string.Format("{0:n1}", double.Parse(drFactura["FactProveedor_IV"].ToString()));
                txbDescuento.Text = string.Format("{0:n1}", double.Parse(drFactura["FactProveedor_descuento"].ToString()));
                txbDetalle.Text = drFactura["FactProveedor_detalle"].ToString();
                txbProveedor_id.Text = drFactura["Proveedor_id"].ToString();
                using(ServicioProveedor elServicio=new ServicioProveedor())
                    txbProveedor_nombre.Text = elServicio.ConsultarProveedor(int.Parse(drFactura["Proveedor_id"].ToString()))["proveedor_nombre"].ToString();

              
                CargarLineas();
                using (ServicioFactProveedor elServicio = new ServicioFactProveedor())
                    dgvListado.DataSource = elServicio.ListarPagosDeFactura(codigo);
                CargarNC();
                using (Validacion laValidacion = new Validacion())
                    laValidacion.DarFormatoDecimalGrid(dgvListado);
            }
        }

        private void CargarNC()
        {
            using (ServicioProveedorNC elServicio = new ServicioProveedorNC())
                dgvNC.DataSource = elServicio.ListarProveedorNC(int.Parse(txbID.Text));

            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvNC);
        }
        private void CargarLineas()
        {
            DataTable dtLineas = null;
            using (ServicioDetalleFactProveedor elServicio = new ServicioDetalleFactProveedor())
                dtLineas = elServicio.ListarDetalleFactProveedor(int.Parse(txbID.Text));
            dgvDetalle.AutoGenerateColumns = false;
            dgvDetalle.DataSource =dtLineas;
            foreach (DataRow laLinea in dtLineas.Rows)
            {
                if (laLinea["DetalleFactProveedor_estado"].ToString().Equals("ACT"))
                {
                    btnAplicInv.Enabled = true;
                    break;
                }
            }
            //dar formato a la tabla
            if (dgvDetalle.Columns["col_PrecioNuevo"] != null)
            {
                dgvDetalle.Columns["col_PrecioAnt"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                dgvDetalle.Columns["col_PrecioAnt"].DefaultCellStyle.Format = "N1";

                dgvDetalle.Columns["col_PrecioNuevo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                dgvDetalle.Columns["col_PrecioNuevo"].DefaultCellStyle.Format = "N1";

                dgvDetalle.Columns["col_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                dgvDetalle.Columns["col_total"].DefaultCellStyle.Format = "N1";
            }


            txbProducto_codigo.Text =
                txbProducto_nombre.Text = "";
            txbPrecioNuevo.Text =
                txbTotalLinea.Text = "0";
            nudCantidad.Value = 1;
            txbProducto_codigo.Select();
        }

        private void txbProveedor_id_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Frm_SelecProveedor losMovs = new Frm_SelecProveedor();
            ArrayList elMov = losMovs.SeleccionarCodigo();
            if (elMov.Count != 0)
            {
                txbProveedor_id.Text = elMov[0].ToString();
                DataRow drMov;
                using (ServicioProveedor elServicioPagoProveedor = new ServicioProveedor())
                    drMov = elServicioPagoProveedor.ConsultarProveedor(int.Parse(elMov[0].ToString()));
                txbProveedor_nombre.Text = drMov["Proveedor_nombre"].ToString();

            }
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {
                Frm_MantPagoProveedor2 elMantenimiento =
                    new Frm_MantPagoProveedor2(int.Parse(this.dgvListado.SelectedCells[0].Value.ToString()));
                elMantenimiento.ShowDialog();
                using (ServicioFactProveedor elServicio = new ServicioFactProveedor())
                    dgvListado.DataSource = elServicio.ListarPagosDeFactura(int.Parse(txbID.Text));
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count != 0)
            {
                string leyenda = "";
                if (dgvDetalle.SelectedRows[0].Cells["col_estado"].Value.ToString().Equals("APL"))
                    leyenda = "El producto, ya fue agregardo al INVENTARIO.\r\nDebe rebajar la cantidad(Si son infinitos, omitir)";
                if (MessageBox.Show("Desea Eliminar \"" + dgvDetalle.SelectedRows[0].Cells["col_NomProducto"].Value.ToString() + "\"?\r\n"+leyenda, "Eliminar linea", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    using (ServicioDetalleFactProveedor elServicio = new ServicioDetalleFactProveedor())
                        respuesta = elServicio.EliminarDetalleFactProveedor(int.Parse(dgvDetalle.SelectedRows[0].Cells["col_DetalleID"].Value.ToString()));
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        MessageBox.Show(respuesta);
                    else
                        CargarLineas();
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            CargarLineas();
        }

        private void txbProducto_codigo_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Frm_ListarProductos LosProductos = new Frm_ListarProductos("SELECT");
            string elProducto = LosProductos.SeleccionarCodigo();
            if (elProducto.Length != 0)
            {
                txbProducto_codigo.Text = elProducto;
                BuscarProducto();
            }
        }

        private void txbProducto_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                    BuscarProducto();
            }
            catch
            {
                MessageBox.Show("Error al dar enter, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BuscarProducto()
        {
            try
            {
                elErrorProvider.Clear();
                using (Validacion elValidar = new Validacion())
                    if (!elValidar.ValidaVacio(txbProducto_codigo, elErrorProvider, "Codigo Producto"))
                        return;
                
                DataRow elProducto = null;
                //buscar por codigo de producto
                using (ServicioProductos elServicio = new ServicioProductos())
                    if (txbProducto_codigo.Text.Length < 5)
                    {
                        using (Validacion elValidar = new Validacion())
                            if (!elValidar.ValidaIntMayorCero(txbProducto_codigo, elErrorProvider, "Codigo Producto"))
                                return;
                        elProducto = elServicio.ConsultarProductos(int.Parse(txbProducto_codigo.Text));
                    }
                    else
                        elProducto = elServicio.ConsultarProductosXCodBarra(txbProducto_codigo.Text);
                if (elProducto != null)
                {

                    txbProducto_codigoSistema.Text = elProducto["Producto_codigo"].ToString();
                    if (elProducto["Producto_gravado"].ToString().Equals("S"))
                        txbProducto_nombre.Text = "*" + elProducto["Producto_nombre"].ToString();// +"(" + elProducto["Producto_detalle"].ToString() + ")";
                    else
                        txbProducto_nombre.Text = elProducto["Producto_nombre"].ToString();// +"(" + elProducto["Producto_detalle"].ToString() + ")";
                    txbPrecioNuevo.Focus();
                }
                else
                {
                    MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            { MessageBox.Show("Error al buscar: " + ex.Message); }
        }
        private void txbPrecioNuevo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbTotalLinea.Select();
        }

        private void txbTotalLinea_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                nudCantidad.Focus();
        }

        private void nudCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            btnAgregar_KeyPress(null, null);
        }

        private void btnAgregar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidarLinea())
                return;
            string respuesta = "";
            using (ServicioDetalleFactProveedor elServicio = new ServicioDetalleFactProveedor())
                respuesta = elServicio.InsertarDetalleFactProveedor(int.Parse(txbID.Text), int.Parse(txbProducto_codigoSistema.Text), int.Parse(nudCantidad.Value.ToString()), double.Parse(txbPrecioNuevo.Text), double.Parse(txbTotalLinea.Text));
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                CargarLineas();
            else
                MessageBox.Show(respuesta,"Error al Insertar Linea");
        }

        private bool ValidarLinea()
        {
            int NumeroMalas = 0;
            elErrorProvider.Clear();
            using (Validacion laValidacion = new Validacion())
            {

                if (!laValidacion.ValidaIntMayorCero(txbProducto_codigoSistema, elErrorProvider, "Producto"))
                    NumeroMalas++;
                if (!laValidacion.ValidaVacio(txbProducto_nombre, elErrorProvider, "Producto"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorIgualCero(txbPrecioNuevo, elErrorProvider, "Precio Nuevo"))
                    NumeroMalas++;
                if (!laValidacion.ValidaDoubleMayorIgualCero(txbTotalLinea, elErrorProvider, "Total de la Linea"))
                    NumeroMalas++;

            }
            if (NumeroMalas == 0)
                return true;//No hay malas
            else
                return false;//Hay malas
        }

        private void nudCantidad_Enter(object sender, EventArgs e)
        {
            nudCantidad.Select(0, nudCantidad.Value.ToString().Length);
        }

        private void btnAplicInv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea Aplicar al Inventario los productos?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioDetalleFactProveedor elServicio = new ServicioDetalleFactProveedor())
                    respuesta = elServicio.AplicarDetalleFactProveedor(int.Parse(txbID.Text));
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    CargarLineas();
                    MessageBox.Show(respuesta);
            }
        }

        private void dgvDetalle_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count != 0)
            {
                   IngresarProducto elIngresar = new IngresarProducto(int.Parse(this.dgvDetalle.SelectedRows[0].Cells["col_ID"].Value.ToString()));
                elIngresar.ShowDialog();
             
            }
        }

        private void btnAgregarPago_Click(object sender, EventArgs e)
        {
            Frm_MantPagoProveedor elPago = new Frm_MantPagoProveedor(txbSaldo.Text, int.Parse(txbID.Text));
            elPago.ShowDialog();
            CargarDatos(int.Parse(txbID.Text));
        }

        

        private void txbDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            guardar();
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Desea eliminar el pago ID es " + dgvListado.SelectedRows[0].Cells[0].Value.ToString() + " con monto " + string.Format("{0:n1}",double.Parse(dgvListado.SelectedRows[0].Cells[2].Value.ToString()))+"?","Eliminar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    using (ServicioPagoProveedor elServicio = new ServicioPagoProveedor())
                        respuesta = elServicio.EliminarPagoProveedor(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        CargarDatos(int.Parse(txbID.Text));
                    else
                        MessageBox.Show(respuesta);
                    
                }
            }
        }

        private void btnReporteFactura_Click(object sender, EventArgs e)
        {
            ArrayList laLista = new ArrayList();
            reporte elReporte = new reporte();
            laLista.Add(txbID.Text);
            //laLista.Add(txbID.Text);
            elReporte.cargarDocumento("rpt_PV_FactProveedor_detalle.rpt", laLista);
            
        }

        private void btnNC_Click(object sender, EventArgs e)
        {
            Frm_MantProveedorNC elMant = new Frm_MantProveedorNC(int.Parse(txbID.Text), "");
            elMant.ShowDialog();
            CargarDatos(int.Parse(txbID.Text));
        }

        private void dgvNC_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvNC.SelectedRows.Count != 0)
            {
                Frm_MantProveedorNC elMant = new Frm_MantProveedorNC(int.Parse(dgvNC.SelectedRows[0].Cells[0].Value.ToString()));
                elMant.ShowDialog();
                CargarDatos(int.Parse(txbID.Text));
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            btnAgregar_KeyPress(null, null);
        }

        private void txbNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbMonto.Focus();
        }

        private void txbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbSaldo.Focus();
        }

        private void txbSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbIV.Focus();
        }

        private void txbIV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbDescuento.Focus();
        }

        private void txbDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbDetalle.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

    }
}
