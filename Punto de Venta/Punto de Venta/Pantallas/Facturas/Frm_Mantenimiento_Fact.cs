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

namespace Punto_de_Venta.Pantallas.Facturas
{
    public partial class Frm_Mantenimiento_Fact : Form
    {
        int Prueba = 0;
        bool cargandoGrid = false;
        DataTable dtLineas = null;
        double CantidadProducto = 0;
        public static int enviar = 0;
        public Frm_Mantenimiento_Fact(int FactNum)
        {
            InitializeComponent();
            CargarDatos(FactNum);
            CargarComboPrincipal();
            ListarProductos();
            
            if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
            {//desactivar los accesos a los usuarios
                btnActivar.Visible = false;
                btnAnular.Visible = false;
            }
        }
        private void CargarLineas()
        {
            cargandoGrid = true;
            dgvDetalle.AutoGenerateColumns = false;
            using (ServicioFactura elServicio = new ServicioFactura())
                dtLineas = elServicio.ConsultarLinea(int.Parse(txbId_Factura.Text));
            dgvDetalle.DataSource = dtLineas;
            if (dgvDetalle.Columns.Count > 0)
            {
                col_ValorUni.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                col_ValorUni.DefaultCellStyle.Format = "N4";

                col_total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                col_total.DefaultCellStyle.Format = "N1";


            }
            cargandoGrid = false;


          //  txbUtilidad.Text = "";
            txbProducto_codigo.Text =
                txbProducto_nombre.Text = "";
            txbProducto_ValorUni.Text =
                txbTotalLinea.Text = "0";
            txbCantidad.Text = "1";
            txbProducto_codigo.Select();
        }
        private void CargarDatos(int FactNum)
        {
            DataRow drFactura = null;
            using (ServicioFactura elServicio = new ServicioFactura())
                drFactura = elServicio.ConsultarFactura(FactNum);
            if(drFactura!=null)
            {
                txbId_Factura.Text = FactNum.ToString();
                txbCaja.Text = drFactura["Caja_numero"].ToString();
                txbCodVendedor.Text = drFactura["Usuario_codigo"].ToString();
                txbVendedor.Text = drFactura["Usuario_nombre"].ToString();
                txbCliente.Text = drFactura["Cliente"].ToString();
                txbTelefono.Text = drFactura["Tel"].ToString();
                txbDireccion.Text = drFactura["Direccion"].ToString();
                if (drFactura["Fact_Enviar"].ToString().Equals("1")) chkEnviar.Checked =true;
                else chkEnviar.Checked = false;
                txbFecha.Text = drFactura["Fact_fecha"].ToString();
                dtpFecha.Text = drFactura["Fact_FechaLimite"].ToString();
                txbHora.Text = drFactura["Fact_hora"].ToString();
                txbEstado.Text = drFactura["Fact_estado"].ToString();
                if (!txbEstado.Text.Equals("ANULADA")) btnAnular.Visible = true;
                else btnActivar.Visible = true;
                txbSubTotal.Text = string.Format("{0:n1}", double.Parse(drFactura["Fact_subtotal"].ToString()));
                txbIV.Text = string.Format("{0:n1}", double.Parse(drFactura["Fact_impuesto"].ToString()));
                txbDescTotal.Text = string.Format("{0:n1}", double.Parse(drFactura["Fact_totalDescuento"].ToString()));
                txbDesc.Value = (int)double.Parse(drFactura["Fact_descuento"].ToString()) * 1;
           
                txbTotalFact.Text = string.Format("{0:n1}", double.Parse(drFactura["Fact_total"].ToString()));
                txbDetalle.Text = drFactura["Fact_TarjetaDetalle"].ToString();
                txbTipo.Text = drFactura["TipoPago_Descripcion"].ToString();

                CargarLineas();

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
                    elImprimir.ImprimirFactura(int.Parse(txbId_Factura.Text), Conexion.laConexion.ImpresoraFactura);
            }
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Activar la factura?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), 1);
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
                    MessageBox.Show("Debe realizar el pago de la factura para activarla", "Activar");
                
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea ANULAR la factura?", "Activar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.ModificarEstado(int.Parse(txbId_Factura.Text), "ANULADA");
                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    MessageBox.Show(respuesta);
                else
                    this.Close();
            }
        }
        //private void CargarLineas()
        //{
        //    DataTable dtLineas = null;
        //    using (ServicioFactura elServicio = new ServicioFactura())
        //        dtLineas = elServicio.ConsultarLinea(int.Parse(txbId_Factura.Text));
        //    dgvDetalle.AutoGenerateColumns = false;
        //    dgvDetalle.DataSource = dtLineas;
        //    foreach (DataRow laLinea in dtLineas.Rows)
        //    {
        //        //if (laLinea["DetalleFactProveedor_estado"].ToString().Equals("ACT"))
        //        //{
        //        //    btnAplicInv.Enabled = true;
        //        //    break;
        //        //}
        //    }
        //    //dar formato a la tabla
        //    if (dgvDetalle.Columns["col_Codigo"] != null)
        //    {
        //        dgvDetalle.Columns["col_NomProducto"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
        //        dgvDetalle.Columns["col_NomProducto"].DefaultCellStyle.Format = "N1";

        //        //dgvDetalle.Columns["col_PrecioNuevo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
        //        //dgvDetalle.Columns["col_PrecioNuevo"].DefaultCellStyle.Format = "N1";

        //        //dgvDetalle.Columns["col_total"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
        //        //dgvDetalle.Columns["col_total"].DefaultCellStyle.Format = "N1";
        //    }


        //    txbProducto_codigo.Text =
        //        txbProducto_nombre.Text = "";
        //    txbPrecioNuevo.Text =
        //        txbTotalLinea.Text = "0";
            
        //    txbProducto_codigo.Select();
        //}

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
          //  CargarLineas();
        }

        private void dtgListarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbProducto_codigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
            BuscarProducto();
            txbCantidad.Focus();
        }
        private void BuscarProducto()
        {
            try
            {
                elErrorProvider.Clear();
                using (Validacion elValidar = new Validacion())
                    if (!elValidar.ValidaDoubleMayorCero(txbProducto_codigo, elErrorProvider, "Codigo Producto"))
                        return;
                DataRow elProducto = null;
                if (txbProducto_codigo.Text.Length < 5)
                {//buscar por codigo de producto

                    using (ServicioProductos elServicio = new ServicioProductos())
                        elProducto = elServicio.ConsultarProductos(int.Parse(txbProducto_codigo.Text));
                    if (elProducto != null)
                    {
                        txbProducto_codigoSistema.Text = txbProducto_codigo.Text;
                        CantidadProducto = double.Parse(elProducto["Cantidad"].ToString());

                        //if ((double.Parse(elProducto["Cantidad"].ToString())) <= 0)//(double.Parse(elProducto["producto_cantidadMinima"].ToString())
                        //{//01
                            Prueba = 0;
                            if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                            { //02
                                Prueba = 1;
                                if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                                {//if 03
                                    Precio forma1 = new Precio();
                                    forma1.ShowDialog();
                                    if (forma1.GetPrecio == 0)
                                        return;
                                    txbProducto_ValorUni.Text = string.Format("{0:n1}", forma1.GetPrecio);
                                } //fin if 03
                                else
                                    txbProducto_ValorUni.Text = string.Format("{0:n4}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                                
                                if (elProducto["Producto_gravado"].ToString().Equals("S"))
                                    txbProducto_nombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                                else
                                    txbProducto_nombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                                txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                                txbGravado.Text = elProducto["Producto_gravado"].ToString();
                                //txbUtilidad.Text = elProducto["Producto_Utilidad"].ToString();
                                txbCantidad.Text = "1";
                                txbTotalLinea.Text = txbProducto_ValorUni.Text;
                                txbCantidad.Select();

                            }//fin if 02
                            //else if (double.Parse(elProducto["Cantidad"].ToString()) == -1)
                            //{ //else if 02
                                Prueba = 1;
                                if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                                {

                                    Precio forma1 = new Precio();
                                    forma1.ShowDialog();
                                    if (forma1.GetPrecio == 0)
                                        return;
                                    txbProducto_ValorUni.Text = string.Format("{0:n1}", forma1.GetPrecio);
                                }
                                else
                                    txbProducto_ValorUni.Text = string.Format("{0:n4}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                                if (elProducto["Producto_gravado"].ToString().Equals("S"))
                                    txbProducto_nombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " (" + elProducto["Producto_detalle"].ToString() + ")";
                                else
                                    txbProducto_nombre.Text = elProducto["Producto_nombre"].ToString() + " (" + elProducto["Producto_detalle"].ToString() + ")";
                                //txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                                //txbGravado.Text = elProducto["Producto_gravado"].ToString();
                                //txbUtilidad.Text = elProducto["Utilidad"].ToString();
                                txbCantidad.Text = "";
                                txbCantidad.Select();
                            //}//fin else if 02

                            //else MessageBox.Show("PRODUCTO AGOTADO, NO PUEDE FACTURAR ESTE PRODUCTO", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                      //  }//fin if 01
                        //else
                        //{ //else 01


                        //    if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                        //    {

                        //        Precio forma1 = new Precio();
                        //        forma1.ShowDialog();
                        //        if (forma1.GetPrecio == 0)
                        //            return;
                        //        txbProducto_ValorUni.Text = string.Format("{0:n1}", forma1.GetPrecio);
                        //    }
                        //    else
                        //        txbProducto_ValorUni.Text = string.Format("{0:n1}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                        //    if (elProducto["Producto_gravado"].ToString().Equals("S"))
                        //        txbProducto_nombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " (" + elProducto["Producto_detalle"].ToString() + ")";
                        //    else
                        //        txbProducto_nombre.Text = elProducto["Producto_nombre"].ToString() + " (" + elProducto["Producto_detalle"].ToString() + ")";
                        //    //txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                        //    //txbGravado.Text = elProducto["Producto_gravado"].ToString();
                        //    //txbUtilidad.Text = elProducto["Utilidad"].ToString();
                        //    txbCantidad.Text = "";
                        //    txbCantidad.Select();

                        //}//fin else 01
                        //else MessageBox.Show("PRODUCTO AGOTADO, NO PUEDE FACTURAR ESTE PRODUCTO", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {//buscar por codigo de barra
                    using (ServicioProductos elServicio = new ServicioProductos())
                        elProducto = elServicio.ConsultarProductosXCodBarra(txbProducto_codigo.Text);
                    if (elProducto != null)
                    {

                        if ((double.Parse(elProducto["Tbl_Cantidad_Inventario.Producto_cantidad"].ToString())) <= (double.Parse(elProducto["producto_cantidadMinima"].ToString())))
                        {
                            MessageBox.Show("Quedan pocos productos en el inventario, Comuníquese con el administrador ", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                        {
                            Precio forma1 = new Precio();
                            forma1.ShowDialog();
                            if (forma1.GetPrecio == 0)
                                return;
                            txbProducto_ValorUni.Text = string.Format("{0:n1}", forma1.GetPrecio);
                        }
                        else
                            txbProducto_ValorUni.Text = string.Format("{0:n1}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                        if (elProducto["Producto_gravado"].ToString().Equals("S"))
                            txbProducto_nombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                        else
                            txbProducto_nombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                        txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                        txbGravado.Text = elProducto["Producto_gravado"].ToString();
                       // txbUtilidad.Text = elProducto["Producto_Utilidad"].ToString();
                        txbProducto_codigoSistema.Text = elProducto["Producto_codigo"].ToString();
                        txbCantidad.Text = "1";
                        txbTotalLinea.Text = txbProducto_ValorUni.Text;
                        txbCantidad.Select();
                    }

                    else
                    {
                        MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al buscar un producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void txbCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {
                txbTotalLinea.Text = string.Format("{0:n1}", double.Parse(txbProducto_ValorUni.Text) * double.Parse(txbCantidad.Text.ToString()));
            }
            catch { txbTotalLinea.Text = ""; }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string respuesta = "";

            int enviar=0;

            if(chkEnviar.Checked)enviar=1;

            //actualizar la factura
            using (ServicioFactura elServicio = new ServicioFactura())
                respuesta = elServicio.EDITARFactura(int.Parse(txbId_Factura.Text), int.Parse(txbCodigoCliente.Text), int.Parse(Principal.elUsuario.Codigo), txbCliente.Text, txbTelefono.Text, txbDireccion.Text, DateTime.Parse(dtpFecha.Text), txbEstado.Text, double.Parse(txbSubTotal.Text),double.Parse(txbDesc.Text),double.Parse(txbDescTotal.Text), double.Parse(txbIV.Text), double.Parse(txbTotalFact.Text),enviar);

            if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
            {
                MessageBox.Show(respuesta, "Error al actualizar la Proforma");
                return;
            }


            //eliminar todas las lineas viejas
            using (ServicioFactura elServicio = new ServicioFactura())
                respuesta = elServicio.EliminarLineasFactura(int.Parse(txbId_Factura.Text));
            if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
            {
                MessageBox.Show(respuesta, "Error al eliminar las lineas");
                return;
            }
            foreach (DataRow laFila in dtLineas.Rows)
            {
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.RegistarLineaFactura_UPDATE_FACT(int.Parse(txbId_Factura.Text),
                        int.Parse(laFila["LinFact_prod_codigo"].ToString()),
                        laFila["LinFact_prod_nombre"].ToString(),
                        double.Parse(laFila["LinFact_prod_cantidad"].ToString()),
                        double.Parse(laFila["LinFact_prod_valorUnitario"].ToString()));
                        //double.Parse(laFila["LinFact_Utilidad"].ToString())
                //double.Parse(laFila["LinFact_prod_total"].ToString()),
                //double.Parse(laFila["LinFact_subtotal"].ToString()),
                //double.Parse(laFila["LinFact_impuesto"].ToString()),
                //double.Parse(laFila["LinFact_descuento"].ToString()));
                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al insertar la linea:" + laFila["LinFact_prod_nombre"].ToString());
                    return;
                }
            }
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
            {
                MessageBox.Show(respuesta, "ACTUALIZACION");
                return;
            }
            if (MessageBox.Show("¿Desea imprimir la factura?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //imprimir factura
                using (ImprimirTicket elImprimir = new ImprimirTicket())
                    elImprimir.ImprimirFactura(int.Parse(txbId_Factura.Text), Conexion.laConexion.ImpresoraFactura);
            }
            //this.Close();
        }

        
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        public void CalcularTotal()
        {
            if (dtLineas == null)//no ha iniciado
                return;
            double montoIV = 0;
            double subtotal = 0 ;//utilidadtotal = 0

            foreach (DataRow lafila in dtLineas.Rows)
            {
                subtotal += double.Parse(lafila["LinFact_prod_total"].ToString());
                montoIV += double.Parse(lafila["LinFact_impuesto"].ToString());
               // utilidadtotal += double.Parse(lafila["LinFact_Utilidad"].ToString());
            }
            double Desc = 0; double DescTotal = 0;
            Desc = Convert.ToDouble(txbDesc.Value);
            Desc = Desc / 100;
            DescTotal = Desc;

            //Calcular el subtotal


            txbSubTotal.Text = string.Format("{0:n1}", subtotal);

            //DESCUENTO
            DescTotal = subtotal * DescTotal;
            txbDescTotal.Text = string.Format("{0:n1}", DescTotal);

            //Impuesto de Venta

            txbIV.Text = string.Format("{0:n1}", montoIV - (montoIV * Desc)); //- montoIV * Desc);
            montoIV = double.Parse(txbIV.Text);
            //TOTAL
            double Total = 0;

            Total = subtotal + montoIV;
            Total -= DescTotal;
            txbTotalFact.Text = string.Format("{0:n1}", Total);

           // txbTotalUtilidad.Text = string.Format("{0:n1}", utilidadtotal);
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
        private void CargarLineas(int FactNumero)
        {
            cargandoGrid = true;
            dgvDetalle.AutoGenerateColumns = false;
            using (ServicioFactura elServicio = new ServicioFactura())
                dtLineas = elServicio.ConsultarLinea(FactNumero);
            dgvDetalle.DataSource = dtLineas;
            if (dgvDetalle.Columns.Count > 0)
            {
                col_total.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                col_total.DefaultCellStyle.Format = "N1";


            }
            cargandoGrid = false;


        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (txbCantidad.Text.Length < 4)
            {
                if (txbProducto_codigo.Text.Length == 0)
                {
                    txbProducto_codigo.Focus();
                }
                else
                {
                    if (txbCantidad.Text.Length == 0) txbCantidad.Text = "1";
                    elErrorProvider.Clear();
                    if (double.Parse(txbCantidad.Text) <= CantidadProducto)
                    {
                        using (Validacion elValidar = new Validacion())
                            if (!elValidar.ValidaDoubleMayorCero(txbCantidad, elErrorProvider, "Cantidad"))
                                return;
                        GuardarFactura(1);
                        string respuestas = "";
                        using (ServicioFactura elServicio = new ServicioFactura())
                            respuestas = elServicio.RegistarLineaFactura(int.Parse(txbId_Factura.Text), int.Parse(txbProducto_codigo.Text), txbProducto_nombre.Text, double.Parse(txbCantidad.Text), double.Parse(txbProducto_ValorUni.Text));   //, double.Parse(txbUtilidad.Text)

                        actualizarTotales(int.Parse(txbId_Factura.Text));

                        CargarDatos(int.Parse(txbId_Factura.Text));
                      //  CargarLineas(int.Parse(txbId_Factura.Text));

                       // txbUtilidad.Clear();
                        txbProducto_codigo.Clear();
                        txbProducto_nombre.Clear();
                        txbProducto_ValorUni.Clear();
                        txbCantidad.Clear();
                        txbProducto_codigo.Focus();
                        CantidadProducto = 0;

                        dgvDetalle.FirstDisplayedScrollingRowIndex = dgvDetalle.RowCount - 1;

                        //ListarProductos(NumeroFiltrar);
                    }
                    else if (Prueba == 1)
                    {
                        using (Validacion elValidar = new Validacion())
                            if (!elValidar.ValidaDoubleMayorCero(txbCantidad, elErrorProvider, "Cantidad"))
                                return;
                        GuardarFactura(1);
                        string respuestas = "";
                        using (ServicioFactura elServicio = new ServicioFactura())
                            respuestas = elServicio.RegistarLineaFactura_UPDATE_FACT(int.Parse(txbId_Factura.Text), int.Parse(txbProducto_codigo.Text), txbProducto_nombre.Text, double.Parse(txbCantidad.Text), double.Parse(txbProducto_ValorUni.Text));   //

                        actualizarTotales(int.Parse(txbId_Factura.Text));

                        CargarDatos(int.Parse(txbId_Factura.Text));
                        CargarLineas(int.Parse(txbId_Factura.Text));

                        //txbUtilidad.Clear();
                        txbProducto_codigo.Clear();
                        txbProducto_nombre.Clear();
                        txbProducto_ValorUni.Clear();
                        txbCantidad.Clear();
                        txbProducto_codigo.Focus();
                        CantidadProducto = 0;
                    }
                    else
                    {
                        MessageBox.Show("CANTIDAD EXISTENTE = " + CantidadProducto + "\n CANTIDAD A VENDER= " + txbCantidad.Text + "\n NO SE PUEDE VENDER ESTA CANTIDAD", "EROOR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else txbCantidad.SelectAll();
            
        }
        private void actualizarTotales(int NumFact)
        {
            try
            {
                string respuesta = "";
                using (ServicioFactura elServ = new ServicioFactura())
                    respuesta = elServ.ActualizarTotales(NumFact);
            }
            catch
            {

            }
        }
        private void GuardarFactura(int tipoPago)
        {
            if (txbId_Factura.Text.Length == 0)
            {
                //insertar factura nueva
                int NumFactura = 0;
                string respuesta = "";

                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.RegistarFactura(out NumFactura, int.Parse(Principal.laCaja.Numero), int.Parse(Principal.elUsuario.Codigo),
                        int.Parse(txbCodigoCliente.Text),
                        txbCliente.Text,
                        txbTelefono.Text,
                        txbDireccion.Text,
                        double.Parse(txbDesc.Value.ToString()),
                        0,
                        0,
                        0,
                        0,
                        tipoPago,
                        0, 0);
                //int.Parse(cmbEmpresa.SelectedValue.ToString()));

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al insertar la factura");
                    return;
                }
                txbId_Factura.Text = NumFactura.ToString();



            }
            else
            {
                //Modificar factura
                int NumFactura = 0;
                string respuesta = "";
                NumFactura = int.Parse(txbId_Factura.Text);

                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.EDITARFactura(NumFactura, int.Parse(txbCodigoCliente.Text), int.Parse(txbCodVendedor.Text),
                        txbCliente.Text,txbTelefono.Text,txbDireccion.Text, DateTime.Parse(dtpFecha.Text), txbEstado.Text, double.Parse(txbSubTotal.Text),double.Parse(txbDesc.Text),
                        double.Parse(txbDescTotal.Text), double.Parse(txbIV.Text), double.Parse(txbTotalFact.Text), enviar);

                //txbTelefono.Text,

                //int.Parse(cmbEmpresa.SelectedValue.ToString()));

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al insertar la factura");
                    return;
                }



            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDetalle.SelectedRows.Count > 0)
            {
                dtLineas.Rows.RemoveAt(dgvDetalle.SelectedRows[0].Index);
                dgvDetalle.DataSource = dtLineas;

                //eliminar todas las lineas viejas
                string respuesta = "";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.EliminarLineasFactura(int.Parse(txbId_Factura.Text));
                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al eliminar las lineas");
                    return;
                }
                //if (dgvDetalle.SelectedRows.Count > 0)
                //{
                int HayLineas = 0;
                foreach (DataRow laFila in dtLineas.Rows)
                {
                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuesta = elServicio.RegistarLineaFactura(int.Parse(txbId_Factura.Text),
                            int.Parse(laFila["LinFact_prod_codigo"].ToString()),
                            laFila["LinFact_prod_nombre"].ToString(),
                            double.Parse(laFila["LinFact_prod_cantidad"].ToString()),
                            double.Parse(laFila["LinFact_prod_valorUnitario"].ToString())
                            );//double.Parse(laFila["LinFact_Utilidad"].ToString())
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta, "Error al insertar la linea:" + laFila["LinFact_prod_nombre"].ToString());
                        return;
                    }
                    HayLineas = 1;
                }
                if (HayLineas == 0)
                {
                    //Modificar factura
                    int NumFactura = 0;
                    string respuestas = "";
                    NumFactura = int.Parse(txbId_Factura.Text);

                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuestas = elServicio.EDITARFactura(NumFactura, int.Parse(txbCodigoCliente.Text), int.Parse(txbCodVendedor.Text),
                            txbCliente.Text, "", "", DateTime.Parse(dtpFecha.Text), txbEstado.Text, 0, 0,
                            0, 0, 0, enviar);

                    //txbTelefono.Text,

                    //int.Parse(cmbEmpresa.SelectedValue.ToString()));

                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta, "Error al insertar la factura");
                        return;
                    }
                    txbSubTotal.Text = "0.0";
                    txbIV.Text = "0.0";
                    txbTotalFact.Text = "0.0";
                    //txbTotalUtilidad.Text = "0.0";
                }

                GuardarFactura(1);
                actualizarTotales(int.Parse(txbId_Factura.Text));

                CargarDatos(int.Parse(txbId_Factura.Text));

                txbProducto_codigo.Focus();

                //ListarProductos(NumeroFiltrar);
            }
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ListarProductos();
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void dtgListarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbProducto_codigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
            BuscarProducto();
            txbCantidad.Focus();
        }

        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                
                btnAgregar_Click(null, null);
                txbFiltro.Clear();
                txbFiltro.Focus();
            }
        }

        private void txbCantidad_TextChanged_1(object sender, EventArgs e)
        {
            if (txbCantidad.Text.Length > 0)
            {
                double preciototal = 0, precio = 0, cantidad = 0, IMP = 0;
                precio = double.Parse(txbProducto_ValorUni.Text);
                cantidad = double.Parse(txbCantidad.Text);

                preciototal = precio * cantidad;
                IMP = preciototal * 0.13;
                txbTotalLinea.Text = Math.Round(preciototal + IMP).ToString();
            }
            else txbTotalLinea.Text = "0";
        }
       
        
    }
}
