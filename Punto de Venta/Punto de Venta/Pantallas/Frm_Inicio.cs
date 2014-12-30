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
using Punto_de_Venta.Pantallas.Varias;
using Punto_de_Venta.Pantallas.Cierre_de_Cajas;
using System.Collections;
using Punto_de_Venta.Pantallas.Usuarios;
using Punto_de_Venta.Pantallas.Horas_de_Trabajo;
using Punto_de_Venta.Pantallas.Egresos;
using Punto_de_Venta.Pantallas.Facturas;
using Punto_de_Venta.Pantallas.Producto;
using Punto_de_Venta.Pantallas.CategoriaProducto;
using Punto_de_Venta.Pantallas.Proveedor;
using Punto_de_Venta.Pantallas.Clientes;
using Punto_de_Venta.Pantallas.Credito;
using Punto_de_Venta.Pantallas.Reportes;
using Punto_de_Venta.Pantallas.Cantidad_Inv;
using Punto_de_Venta.Pantallas.Proforma;
using Punto_de_Venta.Pantallas.Orden_de_Compra;
using Punto_de_Venta.Pantallas.Nota_Credito;
using Punto_de_Venta.Pantallas.FacturasDirecta;
using Punto_de_Venta.Pantallas.Agenda;
using Punto_de_Venta.Pantallas.Cajas;

namespace Punto_de_Venta.Pantallas
{
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void Frm_Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion.laConexion.Usuario = "sa";
                Conexion.laConexion.Contrasena = "sasa";
                Conexion.laConexion.LeerXML();
                Principal.laCaja.Numero = Conexion.laConexion.LeerCampoXML("numCaja");
                realizarCierreDeCajaToolStripMenuItem1.Text = "Realizar Cierre de Caja " + Principal.laCaja.Numero;

                #region Pantalla Login
                // pantalla de login
                Frm_Login elLogin = new Frm_Login();
                elLogin.ShowDialog();
                if (elLogin.LoginCorrecto)
                {
                    tsslUsuario.Text = "Usuario:" + Principal.elUsuario.Nombre + " " + Principal.elUsuario.Apellido1 + " " + Principal.elUsuario.Apellido2;


                    if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
                    {//desactivar los accesos a los usuarios
                        //menu
                        productosToolStripMenuItem.Enabled = false;
                        ingresarNuevoUsuarioToolStripMenuItem.Enabled = false;
                        verUsuariosToolStripMenuItem.Enabled = false;
                        editarUsuarioToolStripMenuItem.Enabled = false;
                        cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                        ControlToolStripMenuItem.Enabled = false;
                        cierreDeCajaToolStripMenuItem.Enabled = false;
                        reportesToolStripMenuItem.Enabled = false;

                        //botones
                        btnMarcarHora.Enabled = false;
                        btnTipoCambio.Enabled = false;
                        btnCierreCajaDia.Enabled = false;
                        btnCierreCajaFinal.Enabled = false;
                        btnListaProductos.Enabled = false;
                        btnMantenimientoHoras.Enabled = false;
                        btnMovPago.Enabled = false;

                    }

                }
                else
                {
                    MessageBox.Show("Tiene que entrar al sistema con usuario y clave respectiva!", "Usuario no confirmado", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                }
                #endregion
                //Principal.elUsuario.Codigo = "1";
                //string licencia = Conexion.laConexion.CrearLicencia("00215AE7040F");
                //Conexion.laConexion.VerificarLicencia(Conexion.laConexion.LeerCampoXML("licencia"), this);
                DataRow drcaja = null;
                double apertura = 0;
                using (ServicioCajas elServicio = new ServicioCajas())
                    drcaja = elServicio.ConsultarCajas(int.Parse(Principal.laCaja.Numero));
                if (drcaja != null)
                {
                    apertura = double.Parse(drcaja["Caja_Apertura"].ToString());

                }
                if (apertura == 0)
                {
                    MessageBox.Show("Ingresar Apertura caja", "Apertura caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Frm_AperturaCaja forma = new Frm_AperturaCaja();
                    forma.ShowDialog();
                }
                CargarListado();
            }

            catch
            {
                MessageBox.Show("Error al cargar el Load, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void CargarListado()
        {

            using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                dgvListado.DataSource = elServicio.ListarVendedoresDiaAbierto();
            //using (Validacion laValidacion = new Validacion())
            //    laValidacion.DarFormatoDecimalGrid(dgvListado);
        }
        private void BtnFacturar_Click(object sender, EventArgs e)
        {
            Principal forma = new Principal();
            forma.Show();
        }

        private void mantenimientoHorasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma = new Frm_ListarUsuarios("MANTHORAS");
            forma.Show();
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

        private void realizarCierreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RealizarCierreCajaFinal();

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

        private void realizarCierreDeCajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RealizarCierreCaja();
        }
        //cierre caja q se pueden hacer varios
        private void RealizarCierreCaja()
        {
            try
            {
                if (MessageBox.Show("¿Desea Realizar el cierre de cajas del dia?", "Cierre Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataRow drcaja = null;
                    double apertura = 0;
                    using (ServicioCajas elServicio = new ServicioCajas())
                        drcaja = elServicio.ConsultarCajas(int.Parse(Principal.laCaja.Numero));
                    if (drcaja != null)
                    {
                        apertura = double.Parse(drcaja["Caja_Apertura"].ToString());

                    }

                    string respuesta = "";
                    int respuestaInt = 0;
                    using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                        respuesta = elServicio.RealizarCierreDeUnaCaja(out respuestaInt, int.Parse(Principal.laCaja.Numero), apertura);
                    /*
                    Posibles resultados
                    @Vent_id=-1		no existen facturas
                    @Vent_id=0		sucedio algun error
                    @Vent_id > 0	El numero del ID, es decir todo esta correcto
                    */
                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {

                        switch (respuestaInt)
                        {
                            case -1: MessageBox.Show("No existen facturas para realizar el cierre", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 0: MessageBox.Show("Surgio algun error, contactese con el Administrador del Sistema", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                //verificamos si se va a realizar otra apertura de caja
                                Frm_ConsultaDetalleCierre elfrmConsultar = new Frm_ConsultaDetalleCierre(respuestaInt, 1);
                                elfrmConsultar.ShowDialog();

                                if (MessageBox.Show("SE REALIZO EL CIERRE, ¿DESEA REALIZAR UNA NUEVA APERTURA DE CAJA?", "APERTURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                                {
                                    Frm_AperturaCaja formulario = new Frm_AperturaCaja();
                                    formulario.ShowDialog();
                                }
                                else
                                {
                                    string respuestas = "";
                                    using (ServicioCajas elServicioCaja = new ServicioCajas())

                                        respuestas = elServicioCaja.ModificarMontosCajas(int.Parse(Principal.laCaja.Numero), 0, 0);

                                    //MessageBox.Show("SE REGISTRO CORRECTAMENTE EL MONTO DE LA CAJA");
                                    //this.Close();

                                }
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
            try
            {
                Frm_ListadoCierresPendientes elListado = new Frm_ListadoCierresPendientes();
                elListado.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar el listado del cierre, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void respaldarBaseDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarRespaldoBD();
        }
        private void RealizarRespaldoBD()
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

        private void cambiarDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnLogin_Click(null, null);
        }

        private void ingresarNuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IngresarProducto forma2 = new IngresarProducto();
            forma2.ShowDialog();

        }

        private void verProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarProductos elListado = new Frm_ListarProductos("MANTENIMIENTO");
            elListado.ShowDialog();
            //ListarProductos();
        }

        private void editarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarProductos elListado = new Frm_ListarProductos("MANTENIMIENTO");
            elListado.ShowDialog();
            ///ListarProductos();
        }

        private void verCategoriaProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarCategoriaProducto elListado = new Frm_ListarCategoriaProducto();
            elListado.ShowDialog();
            //CargarComboCategorias();
        }



        private void movimientosDePagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoMovConceptoPago forma = new Frm_MantenimientoMovConceptoPago();
            forma.ShowDialog();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnMarcarHora_Click(object sender, EventArgs e)
        {
            Frm_RegistroHoras forma0 = new Frm_RegistroHoras();
            forma0.ShowDialog();
            CargarListado();
        }

        private void btn_NuevoProducto_Click(object sender, EventArgs e)
        {
            IngresarProducto forma2 = new IngresarProducto();
            forma2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_Control forma12 = new Frm_Control();
            forma12.ShowDialog();
        }

        private void btnRespaldarBD_Click(object sender, EventArgs e)
        {
            RealizarRespaldoBD();
        }
        private void RealizarCierreCajaFinal()
        {
            try
            {
                if (MessageBox.Show("¿Desea Realizar el cierre de caja Final?", "Cierre Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
        private void btnCierreCajaDia_Click(object sender, EventArgs e)
        {
            RealizarCierreCaja();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealizarCierreCaja();

            RealizarCierreCajaFinal();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoMovConceptoPago forma = new Frm_MantenimientoMovConceptoPago();
            forma.ShowDialog();
        }

        private void btnListaFactDiaria_Click(object sender, EventArgs e)
        {
            Frm_ListadoFacturas elListado = new Frm_ListadoFacturas();
            elListado.ShowDialog();
        }

        private void btnListaHistFacturas_Click(object sender, EventArgs e)
        {
            Frm_ListadoHistFacturas elListado = new Frm_ListadoHistFacturas();
            elListado.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Frm_Login elLogin = new Frm_Login();
            elLogin.ShowDialog();
            if (elLogin.LoginCorrecto)
            {
                tsslUsuario.Text = "Usuario:" + Principal.elUsuario.Nombre + " " + Principal.elUsuario.Apellido1 + " " + Principal.elUsuario.Apellido2;


                if (!Principal.elUsuario.TipoUsuario.Equals("Administrador"))
                {//desactivar los accesos a los usuarios

                    //menu
                    productosToolStripMenuItem.Enabled = false;
                    ingresarNuevoUsuarioToolStripMenuItem.Enabled = false;
                    verUsuariosToolStripMenuItem.Enabled = false;
                    editarUsuarioToolStripMenuItem.Enabled = false;
                    cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                    ControlToolStripMenuItem.Enabled = false;
                    cierreDeCajaToolStripMenuItem.Enabled = false;
                    reportesToolStripMenuItem.Enabled = false;
                    horasToolStripMenuItem.Enabled = false;

                    //botones
                    btnMarcarHora.Enabled = false;
                    btnTipoCambio.Enabled = false;
                    btnCierreCajaDia.Enabled = false;
                    btnCierreCajaFinal.Enabled = false;
                    btnListaProductos.Enabled = false;
                    btnMantenimientoHoras.Enabled = false;
                    btnMovPago.Enabled = false;
                }
                else
                {
                    //menu
                    productosToolStripMenuItem.Enabled = true;
                    ingresarNuevoUsuarioToolStripMenuItem.Enabled = true;
                    verUsuariosToolStripMenuItem.Enabled = true;
                    editarUsuarioToolStripMenuItem.Enabled = true;
                    cambiarDeUsuarioToolStripMenuItem.Enabled = true;
                    ControlToolStripMenuItem.Enabled = true;
                    cierreDeCajaToolStripMenuItem.Enabled = true;
                    reportesToolStripMenuItem.Enabled = true;
                    horasToolStripMenuItem.Enabled = true;

                    //botones
                    btnMarcarHora.Enabled = true;
                    btnTipoCambio.Enabled = true;
                    btnCierreCajaDia.Enabled = true;
                    btnCierreCajaFinal.Enabled = true;
                    btnListaProductos.Enabled = true;
                    btnMantenimientoHoras.Enabled = true;
                    btnMovPago.Enabled = true;
                }
            }
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            Frm_ListarProductos elListado = new Frm_ListarProductos("MANTENIMIENTO");
            elListado.ShowDialog();
        }

        private void btnMantenimientoHoras_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma = new Frm_ListarUsuarios("MANTHORAS");
            forma.Show();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_RegistroHoras elIngresar = new Frm_RegistroHoras((dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();

                CargarListado();
            }

        }

        private void historialDeHorasLaboradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma = new Frm_ListarUsuarios("HISTORIAL_HORAS");
            forma.Show();
        }

        private void listadoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarProveedores elListado = new Frm_ListarProveedores();
            elListado.ShowDialog();
        }

        private void pagosDeProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarPagosProveedor elListado = new Frm_ListarPagosProveedor();
            elListado.ShowDialog();
        }

        private void facturasVencidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarFacturasProvVencidas elListado = new Frm_ListarFacturasProvVencidas();
            elListado.ShowDialog();
        }

        private void nuevoProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantProveedor elMant = new Frm_MantProveedor();
            elMant.ShowDialog();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistrarCliente elClie = new Frm_RegistrarCliente();
            elClie.ShowDialog();
        }

        private void verClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes elListar = new Frm_ListarClientes();
            elListar.ShowDialog();
        }

        private void facturasVencidasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ListarFactCred_Vencidas forma = new Frm_ListarFactCred_Vencidas();
            forma.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.lblDateTime.Text = String.Format(DateTime.Now.ToString(), "hh:mm:ss");
        }

        private void realizarUnAbonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRealizarAbono_Click(null, null);
        }

        private void totalDelInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList laLista = new ArrayList();
                reporte elReporte = new reporte();
                elReporte.cargarDocumento("rpt_PV_Total_Inventario.rpt", laLista);
            }
            catch
            {
                MessageBox.Show("Error al cargar reporte, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void totalDelInventarioXCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RPT_TotalInv_X_Categoria forma = new Frm_RPT_TotalInv_X_Categoria();
            forma.ShowDialog();
        }


        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Insertar_Cantidad_Inv elIngresar = new Frm_Insertar_Cantidad_Inv();
            elIngresar.ShowDialog();
        }

        private void listaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Listar_Cant_Inv elIngresar = new Frm_Listar_Cant_Inv();
            elIngresar.ShowDialog();
        }

        private void btnRealizarAbono_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes forma = new Frm_ListarClientes("ABONO");
            forma.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            btn_NuevoProducto_Click(null, null);
        }

        private void toolStripMenuItem54_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            btnListaProductos_Click(null, null);
        }

        private void nuevaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frm_RegistrarCategoria forma = new frm_RegistrarCategoria();
            forma.ShowDialog();
        }

        private void listaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_ListarCategoriaProducto forma = new Frm_ListarCategoriaProducto();
            forma.ShowDialog();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            Frm_RegistrarCliente forma = new Frm_RegistrarCliente();
            forma.ShowDialog();
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes forma = new Frm_ListarClientes();
            forma.ShowDialog();
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            Frm_MantProveedor forma = new Frm_MantProveedor();
            forma.ShowDialog();
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            Frm_ListarProveedores forma = new Frm_ListarProveedores();
            forma.ShowDialog();
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            RegistrarUsuario forma = new RegistrarUsuario();
            forma.ShowDialog();
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma = new Frm_ListarUsuarios("MANTENIMIENTO");
            forma.ShowDialog();
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            btnLogin_Click(null, null);
        }

        private void toolStripMenuItem52_Click(object sender, EventArgs e)
        {
            Frm_About forma0 = new Frm_About();
            forma0.Show();
        }

        private void toolStripMenuItem35_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ConsultaReportXFecha forma14 = new Frm_ConsultaReportXFecha(2);
                forma14.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar el cierre, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem36_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem43_Click(object sender, EventArgs e)
        {
            btnMarcarHora_Click(null, null);
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            btnListaFactDiaria_Click(null, null);
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            btnListaHistFacturas_Click(null, null);
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            Frm_ListarFactCred_Vencidas forma = new Frm_ListarFactCred_Vencidas();
            forma.ShowDialog();
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            btnRealizarAbono_Click(null,null);
        }

        private void toolStripMenuItem30_Click(object sender, EventArgs e)
        {
            btnCierreCajaDia_Click(null, null);
        }

        private void toolStripMenuItem31_Click(object sender, EventArgs e)
        {
            Frm_ListadoCierresPendientes forma = new Frm_ListadoCierresPendientes();
            forma.ShowDialog();

        }

        private void toolStripMenuItem27_Click(object sender, EventArgs e)
        {
            button2_Click(null, null);
        }

        private void toolStripMenuItem28_Click(object sender, EventArgs e)
        {
            Frm_ListaCierres forma = new Frm_ListaCierres();
            forma.ShowDialog();
        }

        private void toolStripMenuItem40_Click(object sender, EventArgs e)
        {
            Frm_RegistrarEgresos forma = new Frm_RegistrarEgresos();
            forma.ShowDialog();
        }

        private void toolStripMenuItem41_Click(object sender, EventArgs e)
        {
            Frm_ListadoEgresos forma = new Frm_ListadoEgresos();
            forma.ShowDialog();
        }

        private void toolStripMenuItem44_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma = new Frm_ListarUsuarios("MANTHORAS");
            forma.Show();
        }

        private void toolStripMenuItem45_Click(object sender, EventArgs e)
        {
            Frm_MantenimientoMovConceptoPago forma = new Frm_MantenimientoMovConceptoPago();
            forma.ShowDialog();
        }

        private void toolStripMenuItem46_Click(object sender, EventArgs e)
        {
            Frm_ListarUsuarios forma = new Frm_ListarUsuarios("HISTORIAL_HORAS");
            forma.Show();
        }

        private void toolStripMenuItem38_Click(object sender, EventArgs e)
        {
            Frm_RPT_TotalInv_X_Categoria forma = new Frm_RPT_TotalInv_X_Categoria();
            forma.ShowDialog();
        }

        private void toolStripMenuItem37_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList laLista = new ArrayList();
                reporte elReporte = new reporte();
                elReporte.cargarDocumento("rpt_PV_Total_Inventario.rpt", laLista);
            }
            catch
            {
                MessageBox.Show("Error al cargar reporte, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem34_Click(object sender, EventArgs e)
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

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            Frm_ListarPagosProveedor elListado = new Frm_ListarPagosProveedor();
            elListado.ShowDialog();
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            Frm_ListarFacturasProvVencidas elListado = new Frm_ListarFacturasProvVencidas();
            elListado.ShowDialog();
        }

        private void toolStripMenuItem48_Click(object sender, EventArgs e)
        {
            Frm_Control forma12 = new Frm_Control();
            forma12.ShowDialog();
        }

        private void toolStripMenuItem50_Click(object sender, EventArgs e)
        {
            RealizarRespaldoBD();
        }

        private void btnCancelarFacturas_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes forma = new Frm_ListarClientes("CANCELAR_FACTURAS");
            forma.ShowDialog();
        }

        private void realizarProformaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarClientes forma = new Frm_ListarClientes("ENVIAR_PROFORMA");
            forma.ShowDialog();
        }

        private void listarProformasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListarProformas forma = new Frm_ListarProformas();
            forma.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RealizarFinCajaOrdenes();

            RealizarCierreFinalOrdenCompra();
        }
        //cierre caja de ordenes q se pueden hacer varios
        private void RealizarFinCajaOrdenes()
        {
            try
            {
                if (MessageBox.Show("¿Desea Realizar la finalización de ordenes de compra del dia?", "Fin Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    int respuestaInt = 0;
                    using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                        respuesta = elServicio.RealizarFinalizacionDeUnaCaja(out respuestaInt, int.Parse(Principal.laCaja.Numero));
                    /*
                    Posibles resultados
                    @Vent_id=-1		no existen ordenes
                    @Vent_id=0		sucedio algun error
                    @Vent_id > 0	El numero del ID, es decir todo esta correcto
                    */
                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {

                        switch (respuestaInt)
                        {
                            case -1: MessageBox.Show("No existen ordenes para realizar la finalizacion", "Fin Caja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 0: MessageBox.Show("Surgio algun error, contactese con el Administrador del Sistema", "Cierre Caja", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                            default:
                                Frm_ConsultaDetalleCierre elfrmConsultar = new Frm_ConsultaDetalleCierre(respuestaInt,2);
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
        private void RealizarCierreFinalOrdenCompra()
        {
            try
            {
                if (MessageBox.Show("¿Desea Realizar el cierre de caja Final?", "Cierre Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "", lasCajas = "";
                    int vent_id = 0;
                    using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                        respuesta = elServicio.RealizarFinalizacionOrdenes(out vent_id, out lasCajas);
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
                                Frm_ConsultCierreCaja elfrmConsultar = new Frm_ConsultCierreCaja(vent_id,2);
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
        private void listaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_ListadoOrdenesCompra forma = new Frm_ListadoOrdenesCompra();
            forma.Show();
        }

        private void cierreFinalOrdenesCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarCierreFinalOrdenCompra();
        }

        private void rEPORTESToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ConsultaReportXFecha forma14 = new Frm_ConsultaReportXFecha(3);
                forma14.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar el cierre, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaClientesConSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList laLista = new ArrayList();
                reporte elReporte = new reporte();
                laLista.Add("0");
                elReporte.cargarDocumento("rpt_CLIENTES_CON_SALDO.rpt", laLista);
            }
            catch
            {
                MessageBox.Show("Error al cargar reporte de productos, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNotaCredito_Click(object sender, EventArgs e)
        {
            Frm_IngresarNC form = new Frm_IngresarNC();
            form.Show();
        }

        private void btnListarNotasCredio_Click(object sender, EventArgs e)
        {
            Frm_ListarNC form = new Frm_ListarNC();
            form.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Frm_ListarClientes forma = new Frm_ListarClientes("CANCELAR_FACTURAS_HOY");
            forma.ShowDialog();
        }

        private void BtnFacturaDirecta_Click(object sender, EventArgs e)
        {
            Frm_MostarFactActivas forma = new Frm_MostarFactActivas();
            forma.Show();
        }

        private void totalVentasXClienteEntreFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ConsultaReportXFecha forma14 = new Frm_ConsultaReportXFecha(4);
                forma14.ShowDialog();
            }
            catch
            {
                MessageBox.Show("Error al cargar Formulario de cierres, Si el error persiste comuiniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listaTodasLasOrdenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_ListadoDelHistorialOrdenes forma = new Frm_ListadoDelHistorialOrdenes();
            forma.Show();
        }

        private void nuevoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_Agenda forma14 = new Frm_Agenda();
            forma14.ShowDialog();
        }

        private void listaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Frm_ListarAgenda forma14 = new Frm_ListarAgenda();
            forma14.ShowDialog();
        }

        private void arqueoCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RealizarFinCajaOrdenes();
        }

        private void tipoDeEgresoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_MantEgresoTipo elMant = new Frm_MantEgresoTipo();
            elMant.ShowDialog();
        }

       
    }
}