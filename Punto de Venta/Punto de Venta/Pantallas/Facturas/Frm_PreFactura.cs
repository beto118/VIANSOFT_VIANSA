using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Pantallas.Producto;
using Punto_de_Venta.Pantallas;
using Punto_de_Venta.Clases;
using Punto_de_Venta.Pantallas.Usuarios;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Pantallas.Cajas;
using Punto_de_Venta.Pantallas.Varias;
using System.IO.Ports;
using System.Threading;
using System.Media;
using Punto_de_Venta.Pantallas.Cierre_de_Cajas;
using Punto_de_Venta.Pantallas.Facturas;
using System.Collections;
using System.Net.NetworkInformation;
using Punto_de_Venta.Pantallas.CategoriaProducto;
using Punto_de_Venta.Pantallas.Egresos;
using Punto_de_Venta.Pantallas.Horas_de_Trabajo;
namespace Punto_de_Venta
{
    
    public partial class Principal : Form
    {
        TextBox elTXBSeleccionado = new TextBox();
        static public Cajas laCaja = new Cajas();
        static public Usuarios elUsuario = new Usuarios();
        static public int Listo=0;
        static public double montoTotal = 0;
        public Principal()
        {
            InitializeComponent();
            elTXBSeleccionado = txbFiltroPrincipal;
     
        }

        #region BOTONES DEL MENU PRINCIPAL

        private void acerdaDeEsteSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_About forma0 = new Frm_About();
            forma0.Show();

        }
        private void ingresarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto forma2 = new IngresarProducto();
            forma2.ShowDialog();
            ListarProductos();
        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarProductos elListado = new Frm_ListarProductos("MANTENIMIENTO");
            elListado.ShowDialog();
            ListarProductos();

        }
        private void ingresarNuevoUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarUsuario forma4 = new RegistrarUsuario();
            forma4.ShowDialog();
        }

        private void verUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma5 = new Frm_ListarUsuarios("MANTENIMIENTO");
            forma5.Show();
        }

        private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma6 = new Frm_ListarUsuarios("MANTENIMIENTO");
            forma6.Show();
        }
        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarProductos elListado = new Frm_ListarProductos("MANTENIMIENTO");
            elListado.ShowDialog();
            ListarProductos();
        }

        private void registrarNuevaCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistarCaja forma9 = new Frm_RegistarCaja();
            forma9.ShowDialog();

        }

        private void verCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarCajas forma10 = new Frm_ListarCajas("MANTENIMIENTO");
            forma10.ShowDialog();
        }

        private void editarCajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarCajas forma11 = new Frm_ListarCajas("MANTENIMIENTO");
            forma11.ShowDialog();
        }
        private void delProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Login elLogin = new Frm_Login();
            elLogin.ShowDialog();
            if (elLogin.LoginCorrecto)
            {
                tsslUsuario.Text = "Usuario:" + Principal.elUsuario.Nombre + " " + Principal.elUsuario.Apellido1 + " " + Principal.elUsuario.Apellido2;
                CargarListadoProductos();

                if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
                {//desactivar los accesos a los usuarios
                    productosToolStripMenuItem.Enabled = false;
                    ingresarNuevoUsuarioToolStripMenuItem.Enabled = false;
                    verUsuariosToolStripMenuItem.Enabled = false;
                    editarUsuarioToolStripMenuItem.Enabled = false;
                    cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                    ControlToolStripMenuItem.Enabled = false;
                    cierreDeCajaToolStripMenuItem.Enabled = false;
                    reportesToolStripMenuItem.Enabled = false;
                }
                else
                {
                    productosToolStripMenuItem.Enabled = true;
                    ingresarNuevoUsuarioToolStripMenuItem.Enabled = true;
                    verUsuariosToolStripMenuItem.Enabled = true;
                    editarUsuarioToolStripMenuItem.Enabled = true;
                    cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                    ControlToolStripMenuItem.Enabled = true;
                    cierreDeCajaToolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;
                }
            }
        }

        private void anularFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadoFacturas elListado = new Frm_ListadoFacturas();
            elListado.ShowDialog();
        }
        private void reImprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadoHistFacturas elListado = new Frm_ListadoHistFacturas();
            elListado.ShowDialog();
        }
        private void editarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Control forma12 = new Frm_Control();
            forma12.ShowDialog();
        }

        private void tipoCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Control forma12 = new Frm_Control();
            forma12.ShowDialog();
        }
        private void verCierresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void porFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }
        #endregion 
       
       
        private void Principal_Load(object sender, EventArgs e)
        {
            try 
            {
                CargarComboPrincipal();
                CargarComboTabInv();
                txbFiltroPrincipal.Focus();
                txbFiltroPrincipal.Select();
                ListarProductos();
            }
            
            catch
            {
                MessageBox.Show("Error al cargar el Load, Si el error persiste comuniquese con el Administrador","Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ListarProductos()
        {
            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioProductos elServicio = new ServicioProductos())
                dtgListarProductos.DataSource = elServicio.ListarProductos(txbFiltro.Text, estado, int.Parse(cbxCategoria.SelectedValue.ToString()));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgListarProductos);
        }

        private void CargarComboCategorias()
        {

            DataTable dtCategoria = null;
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                dtCategoria = elServicio.ListarCategoria("", "ACT");
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
            DataRow drCat = dtCategoria.NewRow();
            drCat["ID"] = "0";
            drCat["Nombre"] = "Todos";
            dtCategoria.Rows.InsertAt(drCat, 0);
            cmbCategoria.DataSource = dtCategoria;
            cmbCategoria.SelectedIndex = 0;
        }

        private void CargarListadoProductos()
        {
            //try
            //{
            //    CargarProductosMasVendidos();
            //    DataTable dtCategorias = null;
            //    using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
            //        dtCategorias = elServicio.ListarCategoria_ConListado();
            //    if (dtCategorias.Rows.Count > 0)
            //        CargarProductosTab1(int.Parse(dtCategorias.Rows[0]["ID"].ToString()), dtCategorias.Rows[0]["Nombre"].ToString());
            //    else
            //        tabControl1.TabPages.Remove(tab1);
            //    if (dtCategorias.Rows.Count > 1)
            //        CargarProductosTab2(int.Parse(dtCategorias.Rows[1]["ID"].ToString()), dtCategorias.Rows[1]["Nombre"].ToString());
            //    else
            //        tabControl1.TabPages.Remove(tab2);
            //    if (dtCategorias.Rows.Count > 2)
            //        CargarProductosTab3(int.Parse(dtCategorias.Rows[2]["ID"].ToString()), dtCategorias.Rows[2]["Nombre"].ToString());
            //    else
            //        tabControl1.TabPages.Remove(tab3);
            //    if (dtCategorias.Rows.Count > 3)
            //        CargarProductosTab4(int.Parse(dtCategorias.Rows[3]["ID"].ToString()), dtCategorias.Rows[3]["Nombre"].ToString());
            //    else
            //        tabControl1.TabPages.Remove(tab4);
            //    CargarProductosBajoInventario();
            //}

            //catch
            //{
            //    MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void CargarProductosBajoInventario()
        {

            //using (ServicioProductos elServicio = new ServicioProductos())
            //    dgvListado.DataSource = elServicio.ListarProductosBajoInventario(int.Parse(cmbCategoria.SelectedValue.ToString()));
            //using (Validacion laValidacion = new Validacion())
            //    laValidacion.DarFormatoDecimalGrid(dgvListado);
        }
        private void CargarProductosMasVendidos()
        {
            //try
            //{
            //    DataTable dtProductos = null;
            //    using (ServicioProductos elServicio = new ServicioProductos())
            //        dtProductos = elServicio.ProductosMasVendedidos();
            //    flpProductos.Controls.Clear();
            //    Button elButon = new Button();
            //    foreach (DataRow laFila in dtProductos.Rows)
            //    {
            //        elButon = new Button();
            //        elButon.Height = 50;
            //        elButon.Width = 92;
            //        elButon.Tag = laFila["producto_codigo"].ToString();
            //        elButon.Click += new System.EventHandler(this.EventoClick);
            //        elButon.Text = laFila["Producto_nombre"].ToString();
            //        flpProductos.Controls.Add(elButon);
            //    }
            //}

            //catch
            //{
            //    MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void CargarProductosTab1(int Categoria_id, string Categoria_nombre)
        {
            //try
            //{
            //    DataTable dtProductos = null;
            //    tab1.Text = Categoria_nombre;
            //    using (ServicioProductos elServicio = new ServicioProductos())
            //        dtProductos = elServicio.ListarProductos("", "ACT", Categoria_id);
            //    flp_tab1.Controls.Clear();
            //    Button elButon = new Button();
            //    foreach (DataRow laFila in dtProductos.Rows)
            //    {
            //        elButon = new Button();
            //        elButon.Height = 50;
            //        elButon.Width = 92;
            //        elButon.Tag = laFila["codigo"].ToString();
            //        elButon.Click += new System.EventHandler(this.EventoClick);
            //        elButon.Text = laFila["nombre"].ToString();
            //        flp_tab1.Controls.Add(elButon);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }
        private void CargarProductosTab2(int Categoria_id, string Categoria_nombre)
        {
            //try
            //{
            //    DataTable dtProductos = null;
            //    using (ServicioProductos elServicio = new ServicioProductos())
            //        dtProductos = elServicio.ListarProductos("", "ACT", Categoria_id);
            //    flp_tab2.Controls.Clear();
            //    tab2.Text = Categoria_nombre;
            //    Button elButon = new Button();
            //    foreach (DataRow laFila in dtProductos.Rows)
            //    {
            //        elButon = new Button();
            //        elButon.Height = 50;
            //        elButon.Width = 92;
            //        elButon.Tag = laFila["codigo"].ToString();
            //        elButon.Click += new System.EventHandler(this.EventoClick);
            //        elButon.Text = laFila["nombre"].ToString();
            //        flp_tab2.Controls.Add(elButon);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

        }

        private void CargarProductosTab3(int Categoria_id, string Categoria_nombre)
        {
            //try
            //{
            //    DataTable dtProductos = null;
            //    using (ServicioProductos elServicio = new ServicioProductos())
            //        dtProductos = elServicio.ListarProductos("", "ACT", Categoria_id);
            //    flp_tab3.Controls.Clear();
            //    tab3.Text = Categoria_nombre;
            //    Button elButon = new Button();
            //    foreach (DataRow laFila in dtProductos.Rows)
            //    {
            //        elButon = new Button();
            //        elButon.Height = 50;
            //        elButon.Width = 92;
            //        elButon.Tag = laFila["codigo"].ToString();
            //        elButon.Click += new System.EventHandler(this.EventoClick);
            //        elButon.Text = laFila["nombre"].ToString();
            //        flp_tab3.Controls.Add(elButon);
            //    }
            //}
            //catch
            //{
            //    MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void CargarProductosTab4(int Categoria_id, string Categoria_nombre)
        {
            //try
            //{
            //    DataTable dtProductos = null;
            //    using (ServicioProductos elServicio = new ServicioProductos())
            //        dtProductos = elServicio.ListarProductos("", "ACT", Categoria_id);
            //    flp_tab4.Controls.Clear();
            //    tab4.Text = Categoria_nombre;
            //    Button elButon = new Button();
            //    foreach (DataRow laFila in dtProductos.Rows)
            //    {
            //        elButon = new Button();
            //        elButon.Height = 50;
            //        elButon.Width = 92;
            //        elButon.Tag = laFila["codigo"].ToString();
            //        elButon.Click += new System.EventHandler(this.EventoClick);
            //        elButon.Text = laFila["nombre"].ToString();
            //        flp_tab4.Controls.Add(elButon);
            //    }
            //}

            //catch
            //{
            //    MessageBox.Show("Error al cargar el Listado de productos, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void EventoClick(object sender, EventArgs e)
        {
            try
            {
                string cod = ((Button)sender).Tag.ToString();
                txbCodigo.Text = cod;
                BuscarProducto();
            }
            catch
            {
                MessageBox.Show("Error al seleccionar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ListarProductos forma7 = new Frm_ListarProductos("SELECCIONAR");
                string codigo = forma7.SeleccionarCodigo();
                if (codigo.Length != 0)
                {
                    txbCodigo.Text = codigo;
                    BuscarProducto();
                }
            }
            
            catch
            {
                MessageBox.Show("Error al seleccionar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        #region TapNumerico
        private void btn7_Click(object sender, EventArgs e)
        {
            
            elTXBSeleccionado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "8";
           
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "5";
        }

        private void byn6_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "0";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += "00";
        }
        private void btnPunto_Click(object sender, EventArgs e)
        {
            elTXBSeleccionado.Text += ".";
        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            txbCodigo.Text = "";
            txbNombre.Text = "";
            txbValorUnt.Text = "";
            txbCanti.Text = "";
            txbCodigo.Focus();
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (elTXBSeleccionado.Text.Length > 0)
                elTXBSeleccionado.Text = elTXBSeleccionado.Text.Substring(0, elTXBSeleccionado.Text.Length - 1);

        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (elTXBSeleccionado.Name.Equals("txbCodigo"))
            {
                BuscarProducto();
                txbCanti.Text = "";
            }
            else
            {
                

                    if (txbCanti.Text.Length == 0) txbCanti.Text = "1";
                    if (txbNombre.Text.Length == 0) { MessageBox.Show("Debe confirmar el producto, para que se ponga el nombre y precio", "Error de Producto"); return; }
                    elErrorProvider.Clear();
                    using (Validacion elValidar = new Validacion())
                        if (!elValidar.ValidaDoubleEntre(0,1000,txbCanti, elErrorProvider, "Codigo Cantidad"))
                            return;
                    InsertarLinea(txbCodigo.Text, txbNombre.Text, double.Parse(txbValorUnt.Text), double.Parse(txbCanti.Text), txbGravado.Text, txbInsNuevo.Text.Equals("1"),double.Parse(NumDesc.Value.ToString()));
                    SystemSounds.Asterisk.Play();
                
            }

            

        }
#endregion TapNumerico
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

                        if (double.Parse(elProducto["Producto_PrecioDefinido"].ToString()) == 1)
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
                            txbNombre.Text = "*" + elProducto["Producto_nombre"].ToString() +" "+  elProducto["Producto_detalle"].ToString(); //" (" ++ ")"
                        else
                            txbNombre.Text = elProducto["Producto_nombre"].ToString() + " " + elProducto["Producto_detalle"].ToString();//+ " (" + ")"
                        txbInsNuevo.Text = double.Parse(elProducto["Producto_valorUnitario"].ToString()) == -1 ? "1" : "0";
                        txbGravado.Text = elProducto["Producto_gravado"].ToString();
                        txbCanti.Text = "";
                        txbCanti.Select();
                        btnCalcularXPiezas.Enabled = true;
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

        private void InsertarLinea(string codigo,string nombre,double valorUni,double cant,string gravado,bool nuevoProducto,double PorcentDesc)
        {
            try
            {
                //Validar si esta activo
                string estado = "";
                using (ServicioProductos elServicio = new ServicioProductos())
                    estado = elServicio.ConsultarProductos(int.Parse(codigo))["Producto_estado"].ToString();
                if (!estado.Equals("ACT"))
                {
                    MessageBox.Show("Producto INACTIVO","Error..");
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
                    double cantidad = 0, Impuesto = 0, descuento = 0,subtotal=0,total=0,PorctDesc=0;


                    cantidad = (double.Parse(elItemProducto.SubItems[2].Text) + cant);
                    elItemProducto.SubItems[2].Text = cantidad.ToString();
                    subtotal = (double.Parse(elItemProducto.SubItems[2].Text) * valorUni);
                    PorctDesc= double.Parse(elItemProducto.SubItems[6].Text);
                    descuento = subtotal * PorctDesc / 100;
                   
                    
                    if (gravado.Equals("S"))
                        Impuesto = (subtotal - descuento) * 0.13;//(double.Parse(elItemProducto.SubItems[4].Text) - double.Parse(elItemProducto.SubItems[4].Text) / 1.13).ToString();

                    total = (subtotal- descuento) + Impuesto;
                    
                    elItemProducto.SubItems[4].Text = string.Format("{0:n4}",subtotal);
                    elItemProducto.SubItems[5].Text = string.Format("{0:n4}", Impuesto);
                    elItemProducto.SubItems[7].Text = string.Format("{0:n4}", descuento);
                    elItemProducto.SubItems[8].Text = string.Format("{0:n1}", total);
                  //  string.Format("{0:n1}",((double.Parse(elItemProducto.SubItems[4].Text) - double.Parse(elItemProducto.SubItems[7].Text)) + double.Parse(elItemProducto.SubItems[5].Text)));
                }
                else
                {
                    double SubTotal = 0,TotalDesc=0 , Total=0, ImpuestoVenta=0;

                    if (int.Parse(codigo) == 117) PorcentDesc = 0;
                    
                    TotalDesc = (cant * valorUni) * (PorcentDesc/100);
                    SubTotal = (cant * valorUni);
                    if (gravado.Equals("S")) ImpuestoVenta = (SubTotal - TotalDesc) * 0.13;
                    else ImpuestoVenta = 0;
                    Total = (SubTotal - TotalDesc) + ImpuestoVenta;

                    //es nuevo el producto
                    ListViewItem item = new ListViewItem(codigo);
                    item.SubItems.Add(nombre);
                    item.SubItems.Add(cant.ToString());
                    item.SubItems.Add(string.Format("{0:n4}", valorUni));
                    item.SubItems.Add(string.Format("{0:n4}", SubTotal));
                    if (gravado.Equals("S"))
                        item.SubItems.Add(string.Format("{0:n4}", ImpuestoVenta));//(cant * valorUni - cant * valorUni / 1.13)));
                    else
                        item.SubItems.Add("0");

                    item.SubItems.Add(string.Format("{0:n1}", PorcentDesc));
                    item.SubItems.Add(string.Format("{0:n2}", TotalDesc));
                    item.SubItems.Add(string.Format("{0:n1}", Total));
                    lvItems.Items.Add(item);
                    Listo = 1;
                }

                //borrar casillas
                txbCodigo.Text = "";
                txbNombre.Text = "";
                txbValorUnt.Text = "";
                txbInsNuevo.Text = "";
                txbGravado.Text = "";
                txbCanti.Text = "";
                if(chkAplicarDesc.Checked==false)
                    NumDesc.Value = 0;
                txbCodigo.Focus();

                SumarTotales();
                btnCalcularXPiezas.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error al insertar un producto a la lista, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SumarTotales()
        {
            try
            {
                //Calcular el subtotal
                double subtotal = 0;
                foreach (ListViewItem elItem in lvItems.Items)
                {
                    subtotal += double.Parse(elItem.SubItems[4].Text);
                }
                txbSubTotal.Text = string.Format("{0:n1}", subtotal);

                //Impuesto de Venta
                double montoIV = 0;
                foreach (ListViewItem elItem in lvItems.Items)
                {
                    montoIV += double.Parse(elItem.SubItems[5].Text);
                }
                txbIV.Text = string.Format("{0:n1}", montoIV);
                //DESCUENTO
                double Descuento = 0;
                foreach (ListViewItem elItem in lvItems.Items)
                {
                    Descuento += double.Parse(elItem.SubItems[7].Text);
                }
                if (Descuento > 0)
                {
                    lbl_Descuento.Visible = true;
                    txbDesc.Visible = true;
                }
                else
                {
                    lbl_Descuento.Visible = false;
                    txbDesc.Visible = false;
                }
                txbDesc.Text = string.Format("{0:n1}", Descuento);
                //TOTAL
                double Total = 0;
                foreach (ListViewItem elItem in lvItems.Items)
                {
                    Total += double.Parse(elItem.SubItems[8].Text);
                }
                txbTotalfactura.Text = string.Format("{0:n0}", Total);

           
            }
            catch
            {
                MessageBox.Show("Error en el calculo del total, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    if (!elValidar.ValidaDoubleMayorCero(txbCanti, elErrorProvider, "Codigo Cantidad"))
                        return;
                InsertarLinea(txbCodigo.Text, txbNombre.Text, double.Parse(txbValorUnt.Text), double.Parse(txbCanti.Text), txbGravado.Text, txbInsNuevo.Text.Equals("1"), double.Parse(NumDesc.Value.ToString()));
                txbFiltroPrincipal.Clear();
                txbFiltroPrincipal.Focus();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                NumDesc.Value = 0;
                
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

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                //int cliente = 0;
                if (Listo == 1)
                {
                    Frm_Factura forma8 = new Frm_Factura();
                    foreach (ListViewItem elItem in lvItems.Items)
                        forma8.AgregarLineas(elItem);
                    forma8.ShowDialog();
                    if (forma8.FacturoCorrecto)
                    {
                        btnCancelar_Click(null, null);
                    }
                }
                else
                {
                    MessageBox.Show("ERROR, NO HAY PRODUCTOS EN LA LISTA", "SALIR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txbFiltroPrincipal.Select();
            }
            catch
            {
                MessageBox.Show("Error al realizar la factura, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void listadoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList laLista = new ArrayList();
                reporte elReporte = new reporte();
                elReporte.cargarDocumento("rpt_PV_ListadoProductos.rpt", laLista);
            }
            catch
            {
                MessageBox.Show("Error al cargar reporte de productos, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
            Frm_ConsultaReportXFecha forma14 = new Frm_ConsultaReportXFecha(1);
            forma14.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar Formulario de cierres, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cierresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ConsultaReportXFecha forma14 = new Frm_ConsultaReportXFecha(2);
                forma14.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar Formulario de cierres, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void respaldarBaseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea respaldar la base de datos?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    using (ServicioGeneral elServicio = new ServicioGeneral())
                        respuesta = elServicio.RespaldarBaseDatos();
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        MessageBox.Show(respuesta);
                    else
                    {
                        if (MessageBox.Show("El Respaldo se guardo correstamente!\n\r¿Desea Abrir la carpeta del respaldo?", "Respaldo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //DataRow drControl = null;
                            using (ServicioGeneral elServicio = new ServicioGeneral())
                                System.Diagnostics.Process.Start(elServicio.ConsultarDatosEmpresa()["Control_Respaldo"].ToString());

                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error al realizar respaldo del a Base de datos, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void realizarCierreDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoCierreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ListaCierres forma13 = new Frm_ListaCierres();
                forma13.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar el listado del cierre, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void realizarCierreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Desea Realizar el cierre de cajas del dia?", "Cierre Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "", lasCajas = "";
                    int vent_id = 0;
                    using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                        respuesta = elServicio.RealizarCierre(out vent_id, out lasCajas);
                    /*
                    Posibles resultados
                    @Vent_id=-2		existen cajas sin realizar el cierre
                    @Vent_id=-1		no existen facturas
                    @Vent_id=0		sucedio algun error
                    @Vent_id > 0	El numero del ID, es decir todo esta correcto
                    */
                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {

                        switch (vent_id)
                        {
                            case -2: MessageBox.Show("Falta realizar el cierre de las Cajas " + lasCajas, "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case -1: MessageBox.Show("No existen facturas para realizar el cierre", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 0: MessageBox.Show("Surgio algun error, contactese con el Administrador del Sistema", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                Frm_ConsultCierreCaja elfrmConsultar = new Frm_ConsultCierreCaja(vent_id,1);
                                elfrmConsultar.ShowDialog();
                                break;
                        }
                    }
                    else
                        MessageBox.Show(respuesta);
                }
            }
            catch
            {
                MessageBox.Show("Error al realizar cierre caja, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listarCierresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadoCierresPendientes elListado = new Frm_ListadoCierresPendientes();
            elListado.ShowDialog();
        }

        private void realizarCierreDeCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void lvItems_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                lvItems.SelectedItems[0].Checked = !lvItems.SelectedItems[0].Checked;
            }
            catch
            {
               // MessageBox.Show("Error al seleccionar producto de la lista de venta, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void Principal_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.F1:
                    btnFacturar_Click(null, null);
                    break;
                //case Keys.F2:
                //    rb_peso_Click(null, null);
                //    break;
                case Keys.F11:
                    tabControl1.SelectedIndex = 5;
                    txbFiltro.Text = "";
                    txbFiltro.SelectAll();
                    break;
                case  Keys.F12:
                btnLista_Click(null, null);
                break;
            }
        }



        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            // if (e.KeyChar == 13)
            ListarProductosBusqueda();
        }

        private void ListarProductosBusqueda()
        {
            try
            {
                DataTable dtProductos = null;
                using (ServicioProductos elServicio = new ServicioProductos())
                    dtProductos = elServicio.ListarProductos(txbFiltro.Text, "ACT", 0);
                flBusqueda.Controls.Clear();
                Button elButon = new Button();
                int cont = 0;
                foreach (DataRow laFila in dtProductos.Rows)
                {
                    elButon = new Button();
                    elButon.Height = 50;
                    elButon.Width = 92;
                    elButon.Tag = laFila["codigo"].ToString();
                    elButon.Click += new System.EventHandler(this.EventoClick);
                    elButon.Text = laFila["nombre"].ToString();// +"(" + laFila["detalle"].ToString() + ")";
                    flBusqueda.Controls.Add(elButon);
                    if (cont == 39) break;
                    cont++;
                }
            }
            catch
            {
                MessageBox.Show("Error al cargar el Listado de Busqueda, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListarProductosBusqueda();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 5)
            {
                txbFiltro.Text = "";
                txbFiltro.Focus();
            }
        }

        private void verCategoriaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarCategoriaProducto elListado = new Frm_ListarCategoriaProducto();
            elListado.ShowDialog();
            CargarComboCategorias();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            CargarProductosBajoInventario();
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarProductosBajoInventario();
        }

        private void nuevoEgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistrarEgresos elIngresar = new Frm_RegistrarEgresos();
            elIngresar.ShowDialog();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadoEgresos elListado = new Frm_ListadoEgresos();
            elListado.ShowDialog();
        }

        private void dtgListarProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString(); 
            BuscarProducto();
            txbCanti.Focus();
        }

        private void dtgListarProductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString(); ;
            BuscarProducto();
            txbCanti.Focus();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {
            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioProductos elServicio = new ServicioProductos())
                dtgListarProductos.DataSource = elServicio.ListarProductos(txbFiltroPrincipal.Text, estado, int.Parse(cbxCategoria.SelectedValue.ToString()));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgListarProductos);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ListarProductos forma7 = new Frm_ListarProductos("SELECCIONAR");
                string codigo = forma7.SeleccionarCodigo();
                if (codigo.Length != 0)
                {
                    txbCodigo.Text = codigo;
                    BuscarProducto();
                }
            }

            catch
            {
                MessageBox.Show("Error al seleccionar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void CargarComboTabInv()
        {
            DataTable dtCategoria = null;
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                dtCategoria = elServicio.ListarCategoria("", "ACT");
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
            DataRow drCat = dtCategoria.NewRow();
            drCat["ID"] = "0";
            drCat["Nombre"] = "Todos";
            dtCategoria.Rows.InsertAt(drCat, 0);
            cmbCategoria.DataSource = dtCategoria;
            cmbCategoria.SelectedIndex = 0;
        }
        private void cbxCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void registrarHoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistroHoras forma0 = new Frm_RegistroHoras();
            forma0.Show();
        }

        private void mantenimientoHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoHoras forma = new Frm_MantenimientoHoras();
            forma.Show();
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inicio forma = new Frm_Inicio();
            forma.Show();
        }

        private void dtgListarProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dtgListarProductos.SelectedRows[0].Cells[0].Value.ToString();
            BuscarProducto();
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

        private void btnCalcularXPiezas_Click(object sender, EventArgs e)
        {
            Frm_CalcularXPiezas forma1 = new Frm_CalcularXPiezas();
            forma1.ShowDialog();
            if (forma1.GetTotalVaras == 0)
                return;
            txbCanti.Text = string.Format("{0:n1}", forma1.GetTotalVaras);
            txbCanti.Focus();
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
            else txbMetros.Text="0";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Cubicar forma = new Frm_Cubicar();
            forma.Show();
        }

              
     }

}
