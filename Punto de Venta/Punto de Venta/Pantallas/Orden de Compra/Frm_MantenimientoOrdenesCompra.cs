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
using Punto_de_Venta.Reportes;

namespace Punto_de_Venta.Pantallas.Orden_de_Compra
{
    public partial class Frm_MantenimientoOrdenesCompra : Form
    {
        public Frm_MantenimientoOrdenesCompra(int OrdenNumero)
        {
            InitializeComponent();
            CargarDatos(OrdenNumero);
            CargarComboPrincipal();
            ListarProductos();

            if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
            {//desactivar los accesos a los usuarios
                btnActivar.Visible = false;
                btnAnular.Visible = false;
            }
        }
        private void CargarDatos(int OrdenNumero)
        {
            DataRow drFactura = null;
            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                drFactura = elServicio.ConsultarOrdenCompra(OrdenNumero);
            if (drFactura != null)
            {
                txbId_Factura.Text = OrdenNumero.ToString();
                txbCaja.Text = drFactura["Caja_numero"].ToString();
                txbCodVendedor.Text = drFactura["Usuario_codigo"].ToString();
                txbVendedor.Text = drFactura["Usuario_nombre"].ToString();
                txbCliente.Text = drFactura["Cliente"].ToString();
                txbTelefono.Text = drFactura["Tel"].ToString();
                txbDireccion.Text = drFactura["Direccion"].ToString();
                if (drFactura["Orden_Enviar"].ToString().Equals("1")) chkEnviar.Checked = true;
                else chkEnviar.Checked = false;
                txbFecha.Text = drFactura["Fact_fecha"].ToString();
    
                txbHora.Text = drFactura["Fact_hora"].ToString();
                txbEstado.Text = drFactura["Orden_estado"].ToString();
                if (!txbEstado.Text.Equals("ANULADA")) btnAnular.Visible = true;
                else btnActivar.Visible = true;
                txbSubTotal.Text = string.Format("{0:n1}", double.Parse(drFactura["Orden_subtotal"].ToString()));
                txbIV.Text = string.Format("{0:n1}", double.Parse(drFactura["Orden_impuesto"].ToString()));
                txbDesc.Text = string.Format("{0:n1}", double.Parse(drFactura["Orden_TotalDescuento"].ToString()));
                lblDescuento.Text = string.Format("{0:n0}", double.Parse(drFactura["Orden_descuento"].ToString())) + "%";
                txbTotalFact.Text = string.Format("{0:n1}", double.Parse(drFactura["Orden_total"].ToString()));
                txbDetalle.Text = drFactura["Orden_TarjetaDetalle"].ToString();
                txbTipo.Text = drFactura["TipoPago_Descripcion"].ToString();

                using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                    dgvListado.DataSource = elServicio.ConsultarLineaDGV(OrdenNumero);
                using (Validacion laValidacion = new Validacion())
                    laValidacion.DarFormatoDecimalGrid(dgvListado);

            }
        }
        private void CargarComboPrincipal()
        {
            DataTable dtCategoria = null;
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                dtCategoria = elServicio.ListarCategoria("", "ACT");
            cbxCategoria.DisplayMember = "Nombre";
            cbxCategoria.ValueMember = "ID";
            DataRow drCat = dtCategoria.NewRow();
            drCat["ID"] = "0";
            drCat["Nombre"] = "Todos";
            dtCategoria.Rows.InsertAt(drCat, 0);
            cbxCategoria.DataSource = dtCategoria;
            cbxCategoria.SelectedIndex = 0;
        }
        private void ListarProductos()
        {
            string estado = "";
            estado = "ACT";
            using (ServicioProductos elServicio = new ServicioProductos())
                dtgListarProductos.DataSource = elServicio.ListarProductos(txbFiltro.Text, estado, int.Parse(cbxCategoria.SelectedValue.ToString()));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgListarProductos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnReimprimir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea imprimir la factura?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //imprimir factura
                using (ImprimirTicket elImprimir = new ImprimirTicket())
                    elImprimir.ImprimirOrdenCOMPRA(int.Parse(txbId_Factura.Text), Conexion.laConexion.ImpresoraFactura);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Activar la factura?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                PagaCon forma1 = new PagaCon(int.Parse(txbId_Factura.Text));
                forma1.ShowDialog();
                if (forma1.FacturoCorrecto)
                {
                    //La actualizacion del estado se hace en el pago, entonces no se ocupa lo siguiente
                    /*
                    string respuesta = "";
                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuesta = elServicio.ModificarEstado(int.Parse(txbId_Factura.Text), "PAGA");
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        MessageBox.Show(respuesta);
                    else*/
                    this.Close();
                }
                else
                    MessageBox.Show("Debe realizar el pago de la orden para activarla", "Activar");

            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ANULAR la Orden?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                    respuesta = elServicio.ModificarEstado(int.Parse(txbId_Factura.Text), "ANULADA");
                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    MessageBox.Show(respuesta);
                else
                    this.Close();
            }
        }

        private void dtgListarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
            BuscarProducto();
            txbCantidad.Focus();
        }
        private void BuscarProducto()
        {
            try
            {
                elErrorProvider.Clear();
                using (Validacion elValidar = new Validacion())
                    if (!elValidar.ValidaDoubleMayorCero(txbCodigo, elErrorProvider, "Codigo Producto"))
                        return;
                DataRow elProducto = null;
                if (txbCodigo.Text.Length < 5)
                {//buscar por codigo de producto
                    using (ServicioProductos elServicio = new ServicioProductos())
                        elProducto = elServicio.ConsultarProductos(int.Parse(txbCodigo.Text));
                    if (elProducto != null)
                    {
                        //if ((double.Parse(elProducto["Cantidad"].ToString())) <= (double.Parse(elProducto["producto_cantidadMinima"].ToString())))
                        //{
                        //    MessageBox.Show("Quedan pocos productos en el inventario, Comuníquese con el administrador ", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //}
                        if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                        {
                            Precio forma1 = new Precio();
                            forma1.ShowDialog();
                            if (forma1.GetPrecio == 0)
                                return;
                            txbPrecio.Text = string.Format("{0:n5}", forma1.GetPrecio);
                        }
                        else
                            txbPrecio.Text = string.Format("{0:n5}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                        if (elProducto["Producto_gravado"].ToString().Equals("S"))
                            txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString(); //" (" ++ ")"
                        else
                            txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();//+ " (" + ")"
                        txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                        txbGravado.Text = elProducto["Producto_gravado"].ToString();
                        txbCantidad.Text = "";
                        txbCantidad.Select();
                    }
                    else
                    {
                        MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //else
                //{//buscar por codigo de barra
                //    using (ServicioProductos elServicio = new ServicioProductos())
                //        elProducto = elServicio.ConsultarProductosXCodBarra(txbCodigo.Text);
                //    if (elProducto != null)
                //    {
                //        if ((double.Parse(elProducto["Tbl_Cantidad_Inventario.Producto_cantidad"].ToString())) <= (double.Parse(elProducto["producto_cantidadMinima"].ToString())))
                //        {
                //            MessageBox.Show("Quedan pocos productos en el inventario, Comuníquese con el administrador ", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        }
                //        if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                //        {
                //            Precio forma1 = new Precio();
                //            forma1.ShowDialog();
                //            if (forma1.GetPrecio == 0)
                //                return;
                //            txbValorUnt.Text = string.Format("{0:n1}", forma1.GetPrecio);
                //        }
                //        else
                //            txbValorUnt.Text = string.Format("{0:n5}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                //        if (elProducto["Producto_gravado"].ToString().Equals("S"))
                //            txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() +" " + elProducto["Producto_detalle"].ToString();
                //        else
                //            txbNombre.Text = elProducto["Producto_nombre"].ToString() +" " + elProducto["Producto_detalle"].ToString();
                //        txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                //        txbGravado.Text = elProducto["Producto_gravado"].ToString();
                //        txbCodigo.Text = elProducto["Producto_codigo"].ToString();
                //        txbCanti.Text = "";
                //        txbCanti.Select();
                //    }

                //    else
                //    {
                //        MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}

            }
            catch
            {
                MessageBox.Show("Error al buscar un producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            if (txbCantidad.Text.Length > 0)
            {
                double preciototal = 0, precio = 0, cantidad = 0, IMP = 0;
                precio = double.Parse(txbPrecio.Text);
                cantidad = double.Parse(txbCantidad.Text);

                preciototal = precio * cantidad;
                IMP = preciototal * 0.13;
                txbTotalLinea.Text = Math.Round(preciototal + IMP).ToString();
            }
            else txbTotalLinea.Text = "0";
        }
    }
}
