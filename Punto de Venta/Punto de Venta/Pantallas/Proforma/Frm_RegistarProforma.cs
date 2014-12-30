using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Clases;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Pantallas;
using Punto_de_Venta.Pantallas.Cajas;
using Punto_de_Venta.Pantallas.CategoriaProducto;
using Punto_de_Venta.Pantallas.Producto;
using Punto_de_Venta.Pantallas.Usuarios;
using Punto_de_Venta.Pantallas.Varias;


namespace Punto_de_Venta.Pantallas.Proforma
{
    public partial class Frm_RegistarProforma : Form
    {
        TextBox elTXBSeleccionado = new TextBox();
        
        static public int Listo=0;
        static public double montoTotal = 0;
        
        public Frm_RegistarProforma(int ClienteID)
        {
            InitializeComponent();
            elTXBSeleccionado = txbFiltroPrincipal;
            CargarCliente(ClienteID);

            
        }
        private void CargarCliente(int Cliente_codigo)
        {
            DataRow drCliente = null;
            using (ServicioClientes elServicio = new ServicioClientes())
                drCliente = elServicio.ConsultarClientesXCodigo(Cliente_codigo);
            if (drCliente != null)
            {
                txbCodigoCliente.Text = Cliente_codigo.ToString();
                txbNombreCliente.Text = drCliente["Clie_Nombre"].ToString() + " " + drCliente["Clie_Apellido1"].ToString() + " " + drCliente["Clie_Apellido2"].ToString();
                txnTelefono.Text = drCliente["Clie_Telefono"].ToString();
                txbDirecion.Text = drCliente["Clie_Direccion"].ToString();
            }
            else
            {
                MessageBox.Show("Codigo invalido", "ERROR BUSCA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void Frm_RegistarProforma_Load(object sender, EventArgs e)
        {
            try
            {
                txbFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txbFiltroPrincipal.Focus();
                txbFiltroPrincipal.Select();
                CargarComboCategorias();
                ListarProductos();
            }

            catch
            {
                MessageBox.Show("Error al cargar el Load, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarProductos()
        {
            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioProductos elServicio = new ServicioProductos())
                dtgListarProductos.DataSource = elServicio.ListarProductos(txbFiltroPrincipal.Text, estado, int.Parse(cbxCategoria.SelectedValue.ToString()));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgListarProductos);
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

        private void txbFiltroPrincipal_TextChanged(object sender, EventArgs e)
        {
            ListarProductos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in lvItems.Items)
                {
                    if (item.Checked)
                        lvItems.Items.Remove(item);
                    SystemSounds.Exclamation.Play();
                }
                SumarTotales();
            }
            catch
            {
                MessageBox.Show("Error al eliminar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    BuscarProducto();
                    txbCanti.Focus();
                }
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
                        if (double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1)
                        {
                            Precio forma1 = new Precio();
                            forma1.ShowDialog();
                            if (forma1.GetPrecio == 0)
                                return;
                            txbValorUnt.Text = string.Format("{0:n5}", forma1.GetPrecio);
                        }
                        else
                            txbValorUnt.Text = string.Format("{0:n5}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                        if (elProducto["Producto_gravado"].ToString().Equals("S"))
                            txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " (" + elProducto["Producto_detalle"].ToString() + ")";
                        else
                            txbNombre.Text = elProducto["Producto_nombre"].ToString() + " (" + elProducto["Producto_detalle"].ToString() + ")";
                        txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                        txbGravado.Text = elProducto["Producto_gravado"].ToString();
                        txbCanti.Text = "";
                        txbCanti.Select();
                    }
                    else
                    {
                        MessageBox.Show("El codigo digitado no pertenece a ningun Producto registrado", "Error de busqueda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {//buscar por codigo de barra
                    using (ServicioProductos elServicio = new ServicioProductos())
                        elProducto = elServicio.ConsultarProductosXCodBarra(txbCodigo.Text);
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
                            txbValorUnt.Text = string.Format("{0:n1}", forma1.GetPrecio);
                        }
                        else
                            txbValorUnt.Text = string.Format("{0:n5}", double.Parse(elProducto["Producto_PrecioGravado"].ToString()));
                        if (elProducto["Producto_gravado"].ToString().Equals("S"))
                            txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                        else
                            txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();
                        txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                        txbGravado.Text = elProducto["Producto_gravado"].ToString();
                        txbCodigo.Text = elProducto["Producto_codigo"].ToString();
                        txbCanti.Text = "";
                        txbCanti.Select();
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

        private void InsertarLinea(string codigo, string nombre, double valorUni, double cant, string gravado, bool nuevoProducto)
        {
            try
            {
                //Validar si esta activo
                string estado = "";
                using (ServicioProductos elServicio = new ServicioProductos())
                    estado = elServicio.ConsultarProductos(int.Parse(codigo))["Producto_estado"].ToString();
                if (!estado.Equals("ACT"))
                {
                    MessageBox.Show("Producto INACTIVO", "Error..");
                    txbCodigo.Focus();
                    return;
                }
                ListViewItem elItemProducto = null;
                if (!nuevoProducto)
                    foreach (ListViewItem elItem in lvItems.Items)
                    {
                        if (elItem.SubItems[0].Text.Equals(codigo))
                        {
                            elItemProducto = elItem;
                            break;

                        }
                    }

                if (elItemProducto != null)
                {
                    //ya existe el producto
                    //actualizamos los totales
                    elItemProducto.SubItems[2].Text = (double.Parse(elItemProducto.SubItems[2].Text) + cant).ToString();
                    elItemProducto.SubItems[4].Text = (double.Parse(elItemProducto.SubItems[2].Text) * valorUni).ToString();
                    if (gravado.Equals("S"))
                        elItemProducto.SubItems[5].Text = (double.Parse(elItemProducto.SubItems[4].Text) * 0.13).ToString();//(double.Parse(elItemProducto.SubItems[4].Text) - double.Parse(elItemProducto.SubItems[4].Text) / 1.13).ToString();

                }
                else
                {
                    //es nuevo el producto
                    ListViewItem item = new ListViewItem(codigo);
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(cant.ToString());
                    item.SubItems.Add(string.Format("{0:n1}", valorUni));
                    item.SubItems.Add(string.Format("{0:n1}", cant * valorUni));
                    if (gravado.Equals("S"))
                        item.SubItems.Add(string.Format("{0:n1}", (cant * valorUni * 0.13)));//(cant * valorUni - cant * valorUni / 1.13)));
                    else
                        item.SubItems.Add("0");
                    lvItems.Items.Insert(0, item);
                    Listo = 1;
                }

                //borrar casillas
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbValorUnt.Text = "";
                txbInsNuevo.Text = "";
                txbGravado.Text = "";
                txbCanti.Text = "";
                txbCodigo.Focus();

                SumarTotales();
            }
            catch
            {
                MessageBox.Show("Error al insertar un producto a la lista, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void SumarTotales()
        {
            double Desc = 0; double DescTotal = 0;
            Desc = Convert.ToDouble(NumDesc.Value);
            Desc = Desc / 100;
            DescTotal = Desc;

            //Calcular el subtotal
            double subtotal = 0;
            foreach (ListViewItem elItem in lvItems.Items)
            {
                subtotal += double.Parse(elItem.SubItems[4].Text);
            }
            txbSubTotal.Text = string.Format("{0:n1}", subtotal);

            //DESCUENTO
            DescTotal = subtotal * DescTotal;
            txbDesc.Text = string.Format("{0:n1}", DescTotal);

            //Impuesto de Venta
            double montoIV = 0;
            foreach (ListViewItem elItem in lvItems.Items)
            {
                montoIV += double.Parse(elItem.SubItems[5].Text);

            }
            txbIV.Text = string.Format("{0:n1}", montoIV - (montoIV * Desc)); //- montoIV * Desc);
            montoIV = double.Parse(txbIV.Text);
            //TOTAL
            double Total = 0;

            Total = subtotal + montoIV;
            txbTotalProforma.Text = string.Format("{0:n1}", Total);


            Total -= DescTotal;
            txbTotalProforma.Text = string.Format("{0:n1}", Total);

        }

        private void txbCodigo_Enter(object sender, EventArgs e)
        {
            elTXBSeleccionado = txbCodigo;
        }

        private void txbCanti_Enter(object sender, EventArgs e)
        {
            elTXBSeleccionado = txbCanti;
        }

        private void txbCanti_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txbCanti.Text.Length == 0) txbCanti.Text = "1";
                elErrorProvider.Clear();
                using (Validacion elValidar = new Validacion())
                    if (!elValidar.ValidaVacio(txbCanti, elErrorProvider, "Codigo Cantidad"))
                        return;
                InsertarLinea(txbCodigo.Text, txbNombre.Text, double.Parse(txbValorUnt.Text), double.Parse(txbCanti.Text), txbGravado.Text, txbInsNuevo.Text.Equals("1"));
                txbFiltroPrincipal.Clear();
                txbFiltroPrincipal.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                lvItems.Items.Clear();
                SumarTotales();
                SystemSounds.Exclamation.Play();
                Listo = 0;
                ListarProductos();
            }
            catch
            {
                MessageBox.Show("Error al cancelar la venta, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtgListarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
            BuscarProducto();
            txbCanti.Focus();
        }

        private void btnRealizarProforma_Click(object sender, EventArgs e)
        {
            if (txbNumProforma.Text.Length == 0)
            {
                //insertar factura
                int CotizacionNumero = 0;
                string respuesta = "";

                using (ServicioProforma elServicio = new ServicioProforma())
                    respuesta = elServicio.RegistarProforma(out CotizacionNumero, int.Parse(Principal.elUsuario.Codigo),
                        int.Parse(txbCodigoCliente.Text),
                        txbNombreCliente.Text,
                        txnTelefono.Text,
                        txbDirecion.Text,
                        double.Parse(txbSubTotal.Text),
                        double.Parse(txbIV.Text),
                        double.Parse(NumDesc.Value.ToString()),
                        double.Parse(txbDesc.Text),
                        double.Parse(txbTotalProforma.Text));

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al insertar la PROFORMA");
                    return;
                }
                txbNumProforma.Text = CotizacionNumero.ToString();


                //insertar lineas
                foreach (ListViewItem elitem in lvItems.Items)
                {
                    double descuento = 0, subtotal = 0;
                    subtotal = double.Parse(elitem.SubItems[4].Text) - double.Parse(elitem.SubItems[5].Text);//el total menos el IV
                    descuento = double.Parse(elitem.SubItems[4].Text) * double.Parse(NumDesc.Value.ToString()) / 100;
                    using (ServicioProforma elServicio = new ServicioProforma())
                        respuesta = elServicio.RegistarLineaProforma(CotizacionNumero,
                            int.Parse(elitem.SubItems[0].Text),
                            elitem.SubItems[1].Text,
                            double.Parse(elitem.SubItems[2].Text),
                            double.Parse(elitem.SubItems[3].Text),
                            double.Parse(elitem.SubItems[4].Text),
                            subtotal,
                            double.Parse(elitem.SubItems[5].Text),
                            descuento);
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta, "Error al insertar la linea");
                        return;
                    }
                }
                if (MessageBox.Show("La Proforma se realizó correctamente, Desea Imprimirla?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ArrayList laLista = new ArrayList();
                    reporte elReporte = new reporte();
                    laLista.Add(txbNumProforma.Text);
                    //laLista.Add(txbID.Text);
                    elReporte.cargarDocumento("rpt_FacturarProforma.rpt", laLista);

                }
                else this.Close();
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch
            {
                MessageBox.Show("Error al Editar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistarProducto_Click(object sender, EventArgs e)
        {
            IngresarProducto forma2 = new IngresarProducto();
            forma2.ShowDialog();
        }

        private void NumDesc_ValueChanged(object sender, EventArgs e)
        {
            lbl_Descuento.Visible = true;
            txbDesc.Visible = true;
            SumarTotales();
        }

        
                
    }
}
