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
using Punto_de_Venta.Pantallas.Varias;
using Punto_de_Venta.Pantallas.Orden_de_Compra;

namespace Punto_de_Venta.Pantallas.FacturasDirecta
{
    
    public partial class FrmFacturaDirecta : Form
    {
        double CantidadProducto = 0;
        int Prueba = 0;

        int NumeroFiltrar = 1;
        bool cargandoGrid = false;
        TextBox elTXBSeleccionado = new TextBox();
        int NumFactura = 0, servicio = 0, enviar = 0, Pedir = 0;
        public static string total = "";
        bool facturoCorrecto = false;
       // static public Cajas laCaja = new Cajas();
        //static public Usuarios elUsuario = new Usuarios();

        DataTable dtLineas = null;
        public FrmFacturaDirecta()
        {
            InitializeComponent();
            CargarComboCategorias();
            ListarProductos(NumeroFiltrar);
            CargarComboEmpleados();
            txbCodigo.Select();
            //cbxServicio.SelectedIndex = 0;
            
            panel2.Visible = true;
        }
        public FrmFacturaDirecta(int NumFactura)
        {
            InitializeComponent();
            CargarComboCategorias();
            ListarProductos(NumeroFiltrar);
            CargarComboEmpleados();
            panel2.Visible = true;
            CargarFactura(NumFactura);
            txbCodigo.Focus();
            txbCodigo.Select();
        }
        private void CargarFactura(int NumFact)
        {
            DataRow drFactura = null;
            using (ServicioFactura elServicio = new ServicioFactura())
                drFactura = elServicio.ConsultarFactura(NumFact);

            if (drFactura != null)
            {
                txbId_Factura.Text = NumFact.ToString();
                txbCliente.Text = drFactura["Cliente"].ToString();
                txbCodigoCliente.Text = drFactura["Clie_Id"].ToString();
                txbTelefono.Text = drFactura["Tel"].ToString();
                txbDireccion.Text = drFactura["Direccion"].ToString();
                cbxVendedor.SelectedValue = drFactura["Usuario_codigo"].ToString();
                
                txbFecha.Text = drFactura["Fact_fecha"].ToString();
                txbEstado.Text = drFactura["Fact_estado"].ToString();
                txbSubtotal.Text = string.Format("{0:n1}", drFactura["Fact_subtotal"]);
                txbIV.Text = string.Format("{0:n1}", drFactura["Fact_impuesto"]);
                
                txbDesc.Text = string.Format("{0:n1}", drFactura["Fact_totalDescuento"]);
                txbTotal.Text = string.Format("{0:n0}", drFactura["Fact_total"]);
                
                txbTotalUtilidad.Text = string.Format("{0:n1}", drFactura["Fact_Utilidad"]);
                //if (int.Parse(drFactura["Fact_Servicio"].ToString()) == 1) chkEnviar.Checked = true;
                if (int.Parse(drFactura["Fact_Enviar"].ToString()) == 1) chkEnviar.Checked = true;

                NumDesc.Value = (int)double.Parse(drFactura["Fact_descuento"].ToString());
                if (NumDesc.Value > 0) btnVerDescuento_Click(null, null);
                CargarLineas(NumFact);
            }
 
        }
        private void CargarComboEmpleados()
        {
            using (ServicioUsuario elServ = new ServicioUsuario())
                cbxVendedor.DataSource = elServ.ListarUsuarios("", "ACT");
            cbxVendedor.ValueMember = "Codigo";
            cbxVendedor.DisplayMember = "Nombre";
            cbxVendedor.SelectedValue = Principal.elUsuario.Codigo;

        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
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
                    if (!elValidar.ValidaDoubleMayorCero(txbCodigo, elErrorProvider, "Codigo Producto"))
                        return;
                DataRow elProducto = null;
                if (txbCodigo.Text.Length < 5)
                {//buscar por codigo de producto
                    using (ServicioProductos elServicio = new ServicioProductos())
                        elProducto = elServicio.ConsultarProductos(int.Parse(txbCodigo.Text));
                    if (elProducto != null)
                    {
                        
                        CantidadProducto = double.Parse(elProducto["Cantidad"].ToString());
                       
                        
                                if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                                {

                                    Precio forma1 = new Precio();
                                    forma1.ShowDialog();
                                    if (forma1.GetPrecio == 0)
                                        return;
                                    txbValorUnt.Text = string.Format("{0:n1}", forma1.GetPrecio);
                                }
                                else
                                    txbValorUnt.Text = string.Format("{0:n4}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                                if (elProducto["Producto_gravado"].ToString().Equals("S"))
                                    txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() +" " +elProducto["Producto_detalle"].ToString();
                                else
                                    txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                                //txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                                //txbGravado.Text = elProducto["Producto_gravado"].ToString();
                                txbUtilidad.Text = elProducto["Producto_Utilidad"].ToString();
                                txbCanti.Text = "";
                                txbCanti.Select();
                            



                    }
                    else
                    {
                        MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                //else ///***************************************************************************************************************
                //{//buscar por codigo de barra
                //    using (ServicioProductos elServicio = new ServicioProductos())
                //        elProducto = elServicio.ConsultarProductosXCodBarra(txbCodigo.Text);
                //    if (elProducto != null)
                //    {
                //        //if ((double.Parse(elProducto["Producto_Cantidad"].ToString())) <= (double.Parse(elProducto["Producto_cantidadMinima"].ToString())))
                //        //{
                //        //    MessageBox.Show("Quedan pocos productos en el inventario, Comuníquese con el administrador ", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        //}
                //        CantidadProducto = double.Parse(elProducto["Cantidad"].ToString());
                //        if ((double.Parse(elProducto["Cantidad"].ToString())) <= 0)//(double.Parse(elProducto["producto_cantidadMinima"].ToString())
                //        {
                //            Prueba = 0;
                //            if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                //            {
                //                Prueba = 1;
                //                if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                //                {
                //                    Precio forma1 = new Precio();
                //                    forma1.ShowDialog();
                //                    if (forma1.GetPrecio == 0)
                //                        return;
                //                    txbValorUnt.Text = string.Format("{0:n1}", forma1.GetPrecio);
                //                }
                //                else
                //                    txbValorUnt.Text = string.Format("{0:n1}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                //                if (elProducto["Producto_gravado"].ToString().Equals("S"))
                //                    txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                //                else
                //                    txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                //                // txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                //                // txbGravado.Text = elProducto["Producto_gravado"].ToString();
                //                txbUtilidad.Text = elProducto["Utilidad"].ToString();
                //                txbCodigo.Text = elProducto["Producto_codigo"].ToString();
                //                txbCanti.Text = "";
                //                txbCanti.Select();

                //                //MessageBox.Show("PRODUCTO AGOTADO, NO PUEDE FACTURAR ESTE PRODUCTO", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            }
                //            else if (double.Parse(elProducto["Cantidad"].ToString()) == -1)
                //            {
                //                Prueba = 1;
                //                if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                //                {
                //                    Precio forma1 = new Precio();
                //                    forma1.ShowDialog();
                //                    if (forma1.GetPrecio == 0)
                //                        return;
                //                    txbValorUnt.Text = string.Format("{0:n1}", forma1.GetPrecio);
                //                }
                //                else
                //                    txbValorUnt.Text = string.Format("{0:n1}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                //                if (elProducto["Producto_gravado"].ToString().Equals("S"))
                //                    txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                //                else
                //                    txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                //                // txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                //                // txbGravado.Text = elProducto["Producto_gravado"].ToString();
                //                txbUtilidad.Text = elProducto["Utilidad"].ToString();
                //                txbCodigo.Text = elProducto["Producto_codigo"].ToString();
                //                txbCanti.Text = "";
                //                txbCanti.Select();

                //            }
                //            else MessageBox.Show("PRODUCTO AGOTADO, NO PUEDE FACTURAR ESTE PRODUCTO", "Inventario minimo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        }
                //        else
                //        {
                //            if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                //            {
                //                Precio forma1 = new Precio();
                //                forma1.ShowDialog();
                //                if (forma1.GetPrecio == 0)
                //                    return;
                //                txbValorUnt.Text = string.Format("{0:n1}", forma1.GetPrecio);
                //            }
                //            else
                //                txbValorUnt.Text = string.Format("{0:n1}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                //            if (elProducto["Producto_gravado"].ToString().Equals("S"))
                //                txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                //            else
                //                txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                //            // txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                //            // txbGravado.Text = elProducto["Producto_gravado"].ToString();
                //            txbUtilidad.Text = elProducto["Utilidad"].ToString();
                //            txbCodigo.Text = elProducto["Producto_codigo"].ToString();
                //            txbCanti.Text = "";
                //            txbCanti.Select();
                //        }
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


        private void txbCanti_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (e.KeyChar == 13)
                {
                    btnAgregar_Click(null, null);
                }
            
            

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

                using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                    respuesta = elServicio.RegistarFacturaDIRECTA(out NumFactura, int.Parse(Principal.laCaja.Numero), int.Parse(Principal.elUsuario.Codigo),
                        int.Parse(txbCodigoCliente.Text),
                        txbCliente.Text,
                        txbTelefono.Text,
                        txbDireccion.Text,
                        double.Parse(NumDesc.Value.ToString()),
                        0,
                        0,
                        0,
                        0,
                        tipoPago,enviar,0,0);
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
                if (chkEnviar.Checked == true) enviar = 1;
                using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                    respuesta = elServicio.ModificarFacturaDIRECTA(NumFactura, int.Parse(txbCodigoCliente.Text), int.Parse(cbxVendedor.SelectedValue.ToString()),
                        txbCliente.Text,txbTelefono.Text,txbDireccion.Text, DateTime.Parse(txbFecha.Text), txbEstado.Text, double.Parse(txbSubtotal.Text),double.Parse(NumDesc.Value.ToString())
                       ,double.Parse(txbDesc.Text), double.Parse(txbIV.Text), double.Parse(txbTotal.Text), enviar, double.Parse(txbTotalUtilidad.Text));

                        //txbTelefono.Text,
                       
                //int.Parse(cmbEmpresa.SelectedValue.ToString()));

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al insertar la factura");
                    return;
                }
                
                
 
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

                PorcentajeDesc.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
                PorcentajeDesc.DefaultCellStyle.Format = "N1";


            }
            cargandoGrid = false;


        }

        private void cbxServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxServicio.SelectedIndex == 0) servicio = 1;
            //else servicio = 0;

            //if ( txbId_Factura.Text.Length != 0)
            //{
            //    GuardarFactura(1);
            //    actualizarTotales(int.Parse(txbId_Factura.Text));
            //    CargarFactura(int.Parse(txbId_Factura.Text));
            //}
            
        }

        private void txbCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                cbxVendedor.BackColor = Color.White;
                cbxVendedor.Select();
            }
            
        }

        private void cbxVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void cbxServicio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                panel2.Visible = true;
                txbCodigo.Focus();

            }
        }

        private void chkEnviar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnviar.Checked == true) enviar = 1;
            else enviar = 0;
        }

        
        private void btnAbrirFact_Click(object sender, EventArgs e)
        {
            if (txbId_Factura.Text == "")
            {
                MessageBox.Show("ERROR, factura no registrada", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                int TipoPago = 1;

                GuardarFactura(TipoPago);

                this.Close();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
                if (txbCodigo.Text.Length == 0)
                {
                    txbCodigo.Focus();
                }
                else
                {
                    if (txbCanti.Text.Length == 0) txbCanti.Text = "1";
                    elErrorProvider.Clear();
                    //if (double.Parse(txbCanti.Text) <= CantidadProducto)
                    //{
                        using (Validacion elValidar = new Validacion())
                            if (!elValidar.ValidaDoubleMayorCero(txbCanti, elErrorProvider, "Cantidad"))
                                return;
                        GuardarFactura(1);
                        string respuestas = "";
                        using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                            respuestas = elServicio.RegistarLineaFacturaDirecta(int.Parse(txbId_Factura.Text), int.Parse(txbCodigo.Text), txbNombre.Text, double.Parse(txbCanti.Text), double.Parse(txbValorUnt.Text), double.Parse(txbUtilidad.Text),double.Parse(NumDesc.Value.ToString()));   //

                        actualizarTotales(int.Parse(txbId_Factura.Text));

                        CargarFactura(int.Parse(txbId_Factura.Text));
                        CargarLineas(int.Parse(txbId_Factura.Text));

                        txbUtilidad.Clear();
                        txbCodigo.Clear();
                        txbNombre.Clear();
                        txbValorUnt.Clear();
                        txbCanti.Clear();
                        txbCodigo.Focus();
                        CantidadProducto = 0;

                        //dgvDetalle.FirstDisplayedScrollingRowIndex = dgvDetalle.RowCount - 1;

                        ListarProductos(NumeroFiltrar);
                    //}
                    //else if (Prueba == 1)
                    //{
                    //    using (Validacion elValidar = new Validacion())
                    //        if (!elValidar.ValidaDoubleMayorCero(txbCanti, elErrorProvider, "Cantidad"))
                    //            return;
                    //    GuardarFactura(1);
                    //    string respuestas = "";
                    //    using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                    //        respuestas = elServicio.RegistarLineaFactura(int.Parse(txbId_Factura.Text),int.Parse(txbCodigo.Text), txbNombre.Text, double.Parse(txbCanti.Text), double.Parse(txbValorUnt.Text), double.Parse(txbUtilidad.Text));   //

                    //    actualizarTotales(int.Parse(txbId_Factura.Text));

                    //    CargarFactura(int.Parse(txbId_Factura.Text));
                    //    CargarLineas(int.Parse(txbId_Factura.Text));

                    //    txbUtilidad.Clear();
                    //    txbCodigo.Clear();
                    //    txbNombre.Clear();
                    //    txbValorUnt.Clear();
                    //    txbCanti.Clear();
                    //    txbCodigo.Focus();
                    //    CantidadProducto = 0;
                    //}
                    //else
                    //{
                    //    MessageBox.Show("CANTIDAD EXISTENTE = " + CantidadProducto + "\n CANTIDAD A VENDER= " + txbCanti.Text + "\n NO SE PUEDE VENDER ESTA CANTIDAD", "EROOR AL FACTURAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
            
        }

        private void btnFacturarEfec_Click(object sender, EventArgs e)
        {
            if (txbId_Factura.Text =="")
            {
                MessageBox.Show("ERROR, factura no registrada", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tipoPago = 1;
                GuardarFactura(tipoPago);
                total = txbTotal.Text;
                // tipoPago = 1;
                Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                forma1.ShowDialog();
                if (forma1.FacturoCorrecto)
                {
                    facturoCorrecto = forma1.FacturoCorrecto;
                    this.Close();
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
                        using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                            respuesta = elServicio.RegistarLineaFacturaDirecta(int.Parse(txbId_Factura.Text),
                                int.Parse(laFila["LinFact_prod_codigo"].ToString()),
                                laFila["LinFact_prod_nombre"].ToString(),
                                double.Parse(laFila["LinFact_prod_cantidad"].ToString()),
                                double.Parse(laFila["LinFact_prod_valorUnitario"].ToString()),
                                double.Parse(laFila["LinFact_Utilidad"].ToString()),
                                double.Parse(laFila["LinFact_DescPorcent"].ToString()));
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

                        using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                            respuestas = elServicio.ModificarFacturaDIRECTA(NumFactura, int.Parse(txbCodigoCliente.Text), int.Parse(cbxVendedor.SelectedValue.ToString()),
                                txbCliente.Text, "", "", DateTime.Parse(txbFecha.Text), txbEstado.Text,0, 0,
                                0, 0,0, enviar,0);

                        //txbTelefono.Text,

                        //int.Parse(cmbEmpresa.SelectedValue.ToString()));

                        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        {
                            MessageBox.Show(respuesta, "Error al insertar la factura");
                            return;
                        }
                        txbSubtotal.Text = "0.0";
                        txbIV.Text = "0.0";
                        txbTotal.Text = "0.0";
                        txbTotalUtilidad.Text = "0.0";
                    }
                    
                GuardarFactura(1);
               actualizarTotales(int.Parse(txbId_Factura.Text));
                
                CargarFactura(int.Parse(txbId_Factura.Text));

                txbCodigo.Focus();

                ListarProductos(NumeroFiltrar);
            }
        }

        private void btnFacturaCredito_Click(object sender, EventArgs e)
        {
            if (txbCodigoCliente.Text == "")
            {
                MessageBox.Show("INGRESE UN CLIENTE", "ERROR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBuscarCliente_Click(null, null);
            }
            else if (txbCodigoCliente.Text == "1")
            {
                MessageBox.Show("PARA REALIZAR UNA FACTURA DE CREDITO TIENE QUE REGISTRAR EL CLIENTE", "ERROR FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBuscarCliente_Click(null, null);
            }
            else
            {
                int tipoPago = 4;
                GuardarFactura(tipoPago);
     

                Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                forma1.ShowDialog();
                if (forma1.FacturoCorrecto)
                {
                    facturoCorrecto = forma1.FacturoCorrecto;
                    this.Close();
                }

            }
                        
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
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
                txbCliente.Text = drCliente["Clie_Nombre"].ToString() + " " + drCliente["Clie_Apellido1"].ToString() + " " + drCliente["Clie_Apellido2"].ToString();
                txbTelefono.Text = drCliente["Clie_Telefono"].ToString();
                txbDireccion.Text = drCliente["Clie_Direccion"].ToString();
            }
            else
            {
                MessageBox.Show("Codigo invalido", "ERROR BUSCA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ListarProductos(int Numero)
        {

            string estado = "";
            if (ckEstado.Checked) estado = "ACT";

            if (Numero == 0 | Numero == 1 | Numero == 3)
            {
                using (ServicioProductos elServicio = new ServicioProductos())
                    dtgListarProductos.DataSource = elServicio.ListarProductosFACTURA(txbFiltro.Text, estado, int.Parse(cbxCategoria.SelectedValue.ToString()));
                using (Validacion laValidacion = new Validacion())
                    laValidacion.DarFormatoDecimalGrid(dtgListarProductos);

            }
            if ((Numero == 2))
            {
                //using (ServicioProductos elServicio = new ServicioProductos())
                //    dtgListarProductos.DataSource = elServicio.ListarProductos_X_CODIGO(txbFiltro.Text, estado, int.Parse(cbxCategoria.SelectedValue.ToString()));
                //using (Validacion laValidacion = new Validacion())
                //    laValidacion.DarFormatoDecimalGrid(dtgListarProductos);

            }
            
        }

        private void CargarComboCategorias()
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txbId_Factura.Text == "")
            {
                this.Close();
            }
            else
            {
                if (MessageBox.Show("¿Desea ANULAR la factura?", "ANULAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        }

        private void dtgListarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
            BuscarProducto();
            txbCanti.Focus();
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {

            ListarProductos(NumeroFiltrar);
        }

        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListarProductos(NumeroFiltrar);
        }

        private void btnFactuararTarj_Click(object sender, EventArgs e)
        {
            if (txbId_Factura.Text == "")
            {
                MessageBox.Show("ERROR, factura no registrada", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tipoPago = 2;
                GuardarFactura(tipoPago);
                total = txbTotal.Text;
                // tipoPago = 1;
                Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                forma1.ShowDialog();
                if (forma1.FacturoCorrecto)
                {
                    facturoCorrecto = forma1.FacturoCorrecto;
                    this.Close();
                }
            }
        }

        private void btnMixto_Click(object sender, EventArgs e)
        {
            if (txbId_Factura.Text == "")
            {
                MessageBox.Show("ERROR, factura no registrada", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int tipoPago = 3;
                GuardarFactura(tipoPago);
                total = txbTotal.Text;
                // tipoPago = 1;
                Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                forma1.ShowDialog();
                if (forma1.FacturoCorrecto)
                {
                    facturoCorrecto = forma1.FacturoCorrecto;
                    this.Close();
                }
            }
        }

        private void FrmFacturaDirecta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnAbrirFact_Click(null, null);
            }
            if (e.KeyCode == Keys.F1)
            {
                btnFacturarEfec_Click(null,null);
            }
            if (e.KeyCode == Keys.F2)
            {
                btnFactuararTarj_Click(null, null);
            }
            if (e.KeyCode == Keys.F3)
            {
                btnMixto_Click(null, null);
            }
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            //NumeroFiltrar = 0;
            if ((e.KeyChar >= 97) & (e.KeyChar <= 122))
            {
                NumeroFiltrar = 1; // a --> z
            }
            else if ((e.KeyChar >= 65) & (e.KeyChar <= 90))
            {
                NumeroFiltrar = 1;// A  --> Z
            }
            else if (((e.KeyChar >= 48) & (e.KeyChar <= 57)) & (txbFiltro.Text.Length < 5))
            {
                NumeroFiltrar = 1;  //Numeros
            }
            else if (((e.KeyChar >= 48) & (e.KeyChar <= 57)) & (txbFiltro.Text.Length > 5))
            {
                NumeroFiltrar = 3;  //Numeros
            }
            else if ((e.KeyChar == 8))
            {
                ListarProductos(NumeroFiltrar); ; // retroceso
            }
            else if ((e.KeyChar == 40))
            {
                dtgListarProductos.Focus();
                dtgListarProductos.Select();
            }
            ListarProductos(NumeroFiltrar);
        }

        private void dtgListarProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
               // txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
                DataGridViewRow row = dtgListarProductos.CurrentRow;
                txbCodigo.Text = row.Index.ToString();
                //txbCodigo.Text = (row.Cells[0].Value).ToString() ;
                BuscarProducto();
                txbCanti.Focus();
            }           
            

        }

        private void txbFiltro_KeyDown(object sender, KeyEventArgs e)
        {
           
            if (e.KeyData == Keys.Down)
            {
                dtgListarProductos.Focus();
                dtgListarProductos.Select();
            }
            if (e.KeyData == Keys.Up)
            {
                txbCliente.Focus();
                txbCliente.SelectAll();
            }
            
        }

        private void txbCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up)
            {
                txbFiltro.Focus();
                txbFiltro.Select();
            }
            if (e.KeyData == Keys.Down)
            {
                if (dgvDetalle.SelectedRows.Count > 0)
                {
                    dgvDetalle.Focus();
                    dgvDetalle.Select();
                }
            }
        }

        private void dtgListarProductos_KeyDown(object sender, KeyEventArgs e)
        {

            if ((dtgListarProductos.CurrentRow.Index.ToString() == "0"))
                {
                    if (e.KeyData == Keys.Up)
                    {
                        txbFiltro.Focus();
                        txbFiltro.Select();
                    }
                }
            
        }

        private void dgvDetalle_KeyDown(object sender, KeyEventArgs e)
        {
            if ((dgvDetalle.CurrentRow.Index.ToString() == "0"))
            {
                if (e.KeyData == Keys.Up)
                {
                    txbCodigo.Focus();
                    txbCodigo.Select();
                }
            }
            if (e.KeyData == Keys.F12)
            {
                btnEliminar_Click(null, null);
            }
        }

        private void txbCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down)
            {
                txbFiltro.Focus();
                txbFiltro.Select();
            }
        }

        private void txbMetros_TextChanged(object sender, EventArgs e)
        {
            if (txbMetros.Text.Length > 0)
            {
                double METROS = 0, VARAS = 0;

                METROS = double.Parse(txbMetros.Text);

                VARAS = (METROS) / 0.84;

                lblVaras.Text = Math.Round(VARAS, 1).ToString();
            }
            else txbMetros.Text = "0";
        }

        private void btnCubicar_Click(object sender, EventArgs e)
        {
            Frm_Cubicar forma = new Frm_Cubicar();
            forma.ShowDialog();
            if (forma.GetTotalPulgadas == 0)
                return;
            txbCanti.Text = string.Format("{0:n1}", forma.GetTotalPulgadas);
            txbCanti.Focus();
        }

        private void btnCalcularXPiezas_Click(object sender, EventArgs e)
        {
            Frm_CalcularXPiezas forma1 = new Frm_CalcularXPiezas();
            forma1.ShowDialog();
            if (forma1.GetTotalVaras == 0)
                return;
            txbCanti.Text = string.Format("{0:n1}", forma1.GetTotalVaras);
            txbCanti.Focus();
        }

        private void txbCanti_TextChanged(object sender, EventArgs e)
        {
            if (txbCanti.Text.Length > 0)
            {
                double preciototal = 0, precio = 0, cantidad = 0, IMP = 0;
                precio = double.Parse(txbValorUnt.Text);
                cantidad = double.Parse(txbCanti.Text);

                preciototal = precio * cantidad;
                IMP = preciototal * 0.13;
                txbTotalLinea.Text = Math.Round(preciototal + IMP).ToString();
            }
            else txbTotalLinea.Text = "0";
        }

        private void btnVerDescuento_Click(object sender, EventArgs e)
        {
            if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
            {//desactivar los accesos a los usuarios
                Frm_Login elLogin = new Frm_Login();
                elLogin.EstablecerUsuario = false;
                elLogin.ShowDialog();
                if (elLogin.LoginCorrecto)
                {
                    NumDesc.Visible = true;
                    lblDescuento.Visible = true;
                    NumDesc.Enabled = true;
                    btnVerDescuento.Visible = false;
                }


            }
            else
            {
                NumDesc.Visible = true;
                NumDesc.Enabled = true;
                lblDescuento.Visible = true;
                btnVerDescuento.Visible = false;
            }
        }
      
        private void btnOrdenCompra_Click(object sender, EventArgs e)
        {
            //int tipoPago = 1;
            //RealizarOrdenCompra(tipoPago);
            //total = txbTotalFact.Text;

            //PagaCon forma1 = new PagaCon(int.Parse(txbId_Factura.Text));
            //forma1.ShowDialog();
            //if (forma1.FacturoCorrecto)
            //{
            //    facturoCorrecto = forma1.FacturoCorrecto;
            //    this.Close();
            //}
        }

        private void NumDesc_ValueChanged(object sender, EventArgs e)
        {
            //GuardarFactura(1);

            //actualizarTotales(int.Parse(txbId_Factura.Text));

            //CargarFactura(int.Parse(txbId_Factura.Text));
            //CargarLineas(int.Parse(txbId_Factura.Text));

        }

        private void dgvDetalle_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!cargandoGrid && e.RowIndex != -1 && (e.ColumnIndex == 2 || e.ColumnIndex == 6))
            {
                

                string respuestas = "";
                using (ServicioFacturaDirecta elServicio = new ServicioFacturaDirecta())
                    respuestas = elServicio.RegistarLineaFacturaDirecta(int.Parse(txbId_Factura.Text), int.Parse(dgvDetalle.Rows[e.RowIndex].Cells["col_Codigo"].Value.ToString()), dgvDetalle.Rows[e.RowIndex].Cells["col_NomProducto"].Value.ToString(), double.Parse(dgvDetalle.Rows[e.RowIndex].Cells["col_Cantidad"].Value.ToString()), double.Parse(dgvDetalle.Rows[e.RowIndex].Cells["col_ValorUni"].Value.ToString()), double.Parse(dgvDetalle.Rows[e.RowIndex].Cells["Utilidad_dgv"].Value.ToString()), double.Parse(dgvDetalle.Rows[e.RowIndex].Cells["PorcentajeDesc"].Value.ToString()));   //

                actualizarTotales(int.Parse(txbId_Factura.Text));

                CargarFactura(int.Parse(txbId_Factura.Text));
                CargarLineas(int.Parse(txbId_Factura.Text));
          
            }
        }
        //private void RealizarOrdenCompra(int tipoPago)
        //{
        //    if (txbId_Factura.Text.Length == 0)
        //    {
        //        //insertar factura
        //        int OrdenID = 0;
        //        string respuesta = "";

        //        using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
        //            respuesta = elServicio.RegistarOrdenCompra(out OrdenID, int.Parse(Principal.laCaja.Numero), int.Parse(Principal.elUsuario.Codigo),
        //                int.Parse(txbCodigoCliente.Text),
        //                txbCliente.Text,
        //                txbTelefono.Text,
        //                txbDireccion.Text,
        //                double.Parse(NumDesc.Value.ToString()),
        //                double.Parse(txbDesc.Text),
        //                double.Parse(txbSubTotal.Text),
        //                double.Parse(txbIV.Text),
        //                double.Parse(txbTotalFact.Text),
        //                tipoPago,
        //                enviar);

        //        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
        //        {
        //            MessageBox.Show(respuesta, "Error al insertar la Orden de Compra");
        //            return;
        //        }
        //        txbId_Factura.Text = OrdenID.ToString();


        //        //insertar lineas de la orden
        //        foreach (ListViewItem elitem in lvItems.Items)
        //        {
        //            double descuento = 0, subtotal = 0;
        //            subtotal = double.Parse(elitem.SubItems[4].Text) - double.Parse(elitem.SubItems[5].Text);//el total menos el IV
        //            descuento = double.Parse(elitem.SubItems[4].Text) * double.Parse(NumDesc.Value.ToString()) / 100;
        //            using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
        //                respuesta = elServicio.RegistarLineaOrdenCompra(OrdenID,
        //                    int.Parse(elitem.SubItems[0].Text),
        //                    elitem.SubItems[1].Text,
        //                    double.Parse(elitem.SubItems[2].Text),
        //                    double.Parse(elitem.SubItems[3].Text),
        //                    double.Parse(elitem.SubItems[4].Text),
        //                    subtotal,
        //                    double.Parse(elitem.SubItems[5].Text),
        //                    descuento);
        //            if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
        //            {
        //                MessageBox.Show(respuesta, "Error al insertar la linea");
        //                return;
        //            }
        //        }
        //        btnAtras.Enabled = false;

        //    }
        //    else
        //    { //Guardamos
        //        string respuesta = "";
        //        using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
        //            respuesta = elServicio.ModificarOrdenCompra(int.Parse(txbId_Factura.Text),
        //                int.Parse(txbCodigoCliente.Text),
        //                double.Parse(NumDesc.Value.ToString()),
        //                double.Parse(txbDesc.Text),
        //                double.Parse(txbSubTotal.Text),
        //                double.Parse(txbIV.Text),
        //                double.Parse(txbTotalFact.Text)
        //                );

        //        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
        //        {
        //            MessageBox.Show(respuesta, "Error al guardar la orden de compra");
        //            return;
        //        }
        //    }
        //}

    }
}
