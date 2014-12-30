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
using Punto_de_Venta.Pantallas.Clientes;
using Punto_de_Venta.Pantallas.Orden_de_Compra;

namespace Punto_de_Venta.Pantallas
{
    
    public partial class Frm_Factura : Form
    {
        public static int enviar = 0;
        public static string total="";
        bool facturoCorrecto = false;

        double utilidad = 0;
        public Frm_Factura()
        {
            InitializeComponent();
            NumDesc.Visible = false;
            lblDescuento.Visible = false;
            btnVerDescuento.Visible = true;
                        
        }
        public Frm_Factura(int Cliente_codigo)
        {
            InitializeComponent();
            CargarDatosCliente(Cliente_codigo);
        }
        public bool FacturoCorrecto { get { return facturoCorrecto; } }
        public void AgregarLineas(ListViewItem elItem)
        {
            lvItems.Items.Add((ListViewItem)elItem.Clone());
        }
        private void    GuardarFactura(int tipoPago)
        {
            if (txbId_Factura.Text.Length == 0)
            {
                //insertar factura
                int NumFactura = 0;
                string respuesta = "";
                
                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuesta = elServicio.RegistarFactura(out NumFactura, int.Parse(Principal.laCaja.Numero), int.Parse(Principal.elUsuario.Codigo),
                            int.Parse(txbCodigoCliente.Text),
                            txbCliente.Text,
                            txbTelefono.Text,
                            txbDireccion.Text,
                            double.Parse(NumDesc.Value.ToString()),
                            double.Parse(txbDesc.Text),
                            double.Parse(txbSubTotal.Text),
                            double.Parse(txbIV.Text),
                            double.Parse(txbTotalFact.Text),
                            tipoPago,
                            enviar, double.Parse(txbTotalFact.Text));

                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta, "Error al insertar la factura");
                        return;
                    }
                    txbId_Factura.Text = NumFactura.ToString();
                
                
                //insertar lineas
                foreach (ListViewItem elitem in lvItems.Items)
                {
                    
                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuesta = elServicio.RegistarLineaFactura(NumFactura,
                            int.Parse(elitem.SubItems[0].Text),
                            elitem.SubItems[1].Text,
                            double.Parse(elitem.SubItems[2].Text),
                            double.Parse(elitem.SubItems[3].Text),
                            double.Parse(elitem.SubItems[8].Text),
                            double.Parse(elitem.SubItems[4].Text),
                            double.Parse(elitem.SubItems[5].Text),
                            double.Parse(elitem.SubItems[7].Text),
                            double.Parse(elitem.SubItems[6].Text));
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta, "Error al insertar la linea");
                        return;
                    }
                }
                btnAtras.Enabled = false;

            }
            else { //Guardamos

                //vamos a eliminar todas las lineas viejas
                string respuesta1 = "";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta1 = elServicio.EliminarLineasFactura(int.Parse(txbId_Factura.Text));
                if (!respuesta1.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta1, "Error al eliminar las lineas");
                    return;
                }
                //insertar lineas de nuevo
                foreach (ListViewItem elitem in lvItems.Items)
                {
                    string respuesta2 = "";
                    using (ServicioFactura elServicio = new ServicioFactura())
                        respuesta2 = elServicio.RegistarLineaFactura(int.Parse(txbId_Factura.Text),
                            int.Parse(elitem.SubItems[0].Text),
                            elitem.SubItems[1].Text,
                            double.Parse(elitem.SubItems[2].Text),
                            double.Parse(elitem.SubItems[3].Text),
                            double.Parse(elitem.SubItems[8].Text),
                            double.Parse(elitem.SubItems[4].Text),
                            double.Parse(elitem.SubItems[5].Text),
                            double.Parse(elitem.SubItems[7].Text),
                            double.Parse(elitem.SubItems[6].Text));
                    if (!respuesta2.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta2, "Error al insertar la linea");
                        return;
                    }
                }
                string respuesta = "";
                using (ServicioFactura elServicio = new ServicioFactura())
                    respuesta = elServicio.ModificarFactura(int.Parse(txbId_Factura.Text),
                        int.Parse(txbCodigoCliente.Text),
                        txbCliente.Text,
                        txbTelefono.Text,
                        txbDireccion.Text,
                        double.Parse(NumDesc.Value.ToString()),
                        double.Parse(txbDesc.Text),
                        double.Parse(txbSubTotal.Text),
                        double.Parse(txbIV.Text),
                        double.Parse(txbTotalFact.Text),
                        enviar
                        );// ,double.Parse(txbUtilidad.Text)

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al guardar la factura");
                    return;
                }
            }
        }

        private void Factura_Load(object sender, EventArgs e)
        {

            
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblHora.Text= DateTime.Now.ToString("hh:mm:ss");
            txbVendedor.Text = Principal.elUsuario.Nombre + " " + Principal.elUsuario.Apellido1;
            txbCodVendedor.Text = Principal.elUsuario.Codigo;
            txbCaja.Text = Principal.laCaja.Numero;

            SumarTotales();

            txbCodigoCliente.Focus();
            
        }
        private void AplicarDescTodos()
        {
            ListViewItem elItemProducto = null;
            
            foreach (ListViewItem elItem in lvItems.Items)
            {
                //ya existe el producto
                //actualizamos los totales

                if (int.Parse(elItem.SubItems[0].Text) != 117)
                {
                    double Impuesto = 0, descuento = 0, subtotal = 0, total = 0, PorctDesc = 0;


                    //cantidad = (double.Parse(elItemProducto.SubItems[2].Text));
                    //valorUni = (double.Parse(elItemProducto.SubItems[3].Text));
                    //elItemProducto.SubItems[2].Text = cantidad.ToString();
                    subtotal = (double.Parse(elItem.SubItems[4].Text));
                    PorctDesc = double.Parse(NumDesc.Value.ToString());
                    descuento = subtotal * PorctDesc / 100;

                    if (double.Parse(elItem.SubItems[5].Text) > 0)
                        Impuesto = (subtotal - descuento) * 0.13;

                    total = (subtotal - descuento) + Impuesto;
                    elItem.SubItems[5].Text = string.Format("{0:n4}", Impuesto);
                    elItem.SubItems[6].Text = string.Format("{0:n4}", PorctDesc);
                    elItem.SubItems[7].Text = string.Format("{0:n4}", descuento);
                    elItem.SubItems[8].Text = string.Format("{0:n1}", total);
                }

            }
            //if (elItemProducto != null)
            //{
               
            //    //  string.Format("{0:n1}",((double.Parse(elItemProducto.SubItems[4].Text) - double.Parse(elItemProducto.SubItems[7].Text)) + double.Parse(elItemProducto.SubItems[5].Text)));
            //}
        }
        private void nudDescuento_ValueChanged(object sender, EventArgs e)
        {
            AplicarDescTodos();
            SumarTotales();
        }
        private void AplicarDescuento()
        {
            try
            {
                foreach (ListViewItem item in lvItems.Items)
                {
                    if (item.Checked)
                    {
 
                    }
                }
                SumarTotales();
            }
            catch
            {
                MessageBox.Show("Error al eliminar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void SumarTotales()
        //{
        //    double Desc = 0; double DescTotal = 0;
        //    Desc = Convert.ToDouble(NumDesc.Value);
        //    Desc = Desc / 100;
        //    DescTotal = Desc;

        //    //Calcular el subtotal
        //    double subtotal = 0;
        //    foreach (ListViewItem elItem in lvItems.Items)
        //    {
        //        subtotal += double.Parse(elItem.SubItems[4].Text);
        //    }
        //    txbSubTotal.Text = string.Format("{0:n1}", subtotal);

        //    //DESCUENTO
        //    DescTotal = subtotal * DescTotal;
        //    txbDesc.Text = string.Format("{0:n1}", DescTotal);

        //    //Impuesto de Venta
        //    double montoIV = 0;
        //    foreach (ListViewItem elItem in lvItems.Items)
        //    {
        //        montoIV += double.Parse(elItem.SubItems[5].Text);

        //    }
        //    txbIV.Text = string.Format("{0:n1}", montoIV - (montoIV * Desc)); //- montoIV * Desc);
        //    montoIV = double.Parse(txbIV.Text);
        //    //TOTAL
        //    double Total = 0;

        //    Total = subtotal + montoIV;
        //    txbTotalFact.Text = string.Format("{0:n1}", Total);


        //    Total -= DescTotal;
        //    txbTotalFact.Text = string.Format("{0:n1}", Total);
                         
        //}
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
                txbTotalFact.Text = string.Format("{0:n0}", Total);


            }
            catch
            {
                MessageBox.Show("Error en el calculo del total, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (txbId_Factura.Text.Length > 0 )
            {

                while (!facturoCorrecto)
                {
                    if (MessageBox.Show("La factura ya se ingreso, ¿Desea Anularla?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string respuesta = "";
                        using (ServicioFactura elServicio = new ServicioFactura())
                            respuesta = elServicio.ModificarEstado(int.Parse(txbId_Factura.Text), "ANULADA");
                        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                            MessageBox.Show(respuesta);
                        else
                        {
                            facturoCorrecto = true;
                            break;
                        }

                    }
                    else
                    {
                        int tipoPago = 3;
                        GuardarFactura(tipoPago);
                        total = txbTotalFact.Text;
                        
                        Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                        forma1.ShowDialog();
                        if (forma1.FacturoCorrecto)
                        {
                            facturoCorrecto = forma1.FacturoCorrecto;
                            break;
                        }
                    }
                }
            }
            else
                facturoCorrecto = true;
            this.Close();
        }
            

        private void Frm_Factura_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (txbId_Factura.Text.Length > 0 && !facturoCorrecto)
            {
                while (!facturoCorrecto)
                {
                    if (MessageBox.Show("La factura ya se ingreso, ¿Desea Anularla?", "Anular", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        string respuesta = "";
                        using (ServicioFactura elServicio = new ServicioFactura())
                            respuesta = elServicio.ModificarEstado(int.Parse(txbId_Factura.Text), "ANULADA");
                        if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                            MessageBox.Show(respuesta);
                        else
                        {
                            facturoCorrecto = true;
                            break;
                        }

                    }
                    else
                    {
                        int tipoPago = 3;
                        GuardarFactura(tipoPago);
                        total = txbTotalFact.Text;
                        
                        Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                        forma1.ShowDialog();
                        if (forma1.FacturoCorrecto)
                        {
                            facturoCorrecto = forma1.FacturoCorrecto;
                            break;
                        }
                    }
                   
                }
                    
            }
        }

        private void btnFacturarEfec_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoPago = 1;
                if (txbCodigoCliente.Text == "")
                {
                    MessageBox.Show("INGRESE UN CLIENTE", "ERROR DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnBuscarCliente_Click(null, null);
                }
                else
                {
                    GuardarFactura(tipoPago);
                    total = txbTotalFact.Text;
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
            catch
            {
                MessageBox.Show("ERROR AL GUARDAR FACT");
            }
        }

        private void btnFactuararTarj_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoPago = 2;
                if (txbCodigoCliente.Text == "")
                {
                    MessageBox.Show("INGRESE UN CLIENTE", "ERROR DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnBuscarCliente_Click(null, null);
                }
                else
                {
                    GuardarFactura(tipoPago);
                    total = txbTotalFact.Text;
                   // int tipoPago = 2;
                    Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                    forma1.ShowDialog();
                    if (forma1.FacturoCorrecto)
                    {
                        facturoCorrecto = forma1.FacturoCorrecto;
                        this.Close();
                    }
                }
            }
             catch
             {
                 MessageBox.Show("ERROR AL GUARDAR FACT");
             }
        }

        private void btnMixto_Click(object sender, EventArgs e)
        {
            int tipoPago = 1;
            RealizarOrdenCompra(tipoPago);
            total = txbTotalFact.Text;

            PagaCon forma1 = new PagaCon(int.Parse(txbId_Factura.Text));
            forma1.ShowDialog();
            if (forma1.FacturoCorrecto)
            {
                facturoCorrecto = forma1.FacturoCorrecto;
                this.Close();
            }

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
                    btnVerDescuento.Visible = false;
                }


            }
            else
            {
                NumDesc.Visible = true;
                lblDescuento.Visible = true;
            }
            
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Factura_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                btnFacturarEfec_Click(null, null);
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
                total = txbTotalFact.Text;

                Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                forma1.ShowDialog();
                if (forma1.FacturoCorrecto)
                {
                    facturoCorrecto = forma1.FacturoCorrecto;
                    this.Close();
                }
 
            }
        }

        private void chkEnviar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEnviar.Checked == true) enviar = 1;
                            
            else enviar = 0;
        }

        private void btnConsultarCliente_Click(object sender, EventArgs e)
        {
            ConsultarCliente();
        }
        private void ConsultarCliente()
        {
            DataRow drCliente = null;
            using (ServicioClientes elServicio = new ServicioClientes())
                drCliente = elServicio.ConsultarClientesXced(txbConsultarCliente.Text);
            if (drCliente != null)
            {
                txbCodigoCliente.Text = drCliente["Clie_Id"].ToString();
                txbCliente.Text = drCliente["Clie_Nombre"].ToString() + " " + drCliente["Clie_Apellido1"].ToString() + " " + drCliente["Clie_Apellido2"].ToString();
                txbTelefono.Text = drCliente["Clie_Telefono"].ToString();
                txbDireccion.Text = drCliente["Clie_Direccion"].ToString();
            }
            else
            {
                MessageBox.Show("Codigo invalido", "ERROR BUSCA DE CLIENTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbConsultarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(KeyPress )
        }
        private void RealizarOrdenCompra(int tipoPago)
        {
            if (txbId_Factura.Text.Length == 0)
            {
                //insertar factura
                int OrdenID = 0;
                string respuesta = "";

                using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                    respuesta = elServicio.RegistarOrdenCompra(out OrdenID, int.Parse(Principal.laCaja.Numero), int.Parse(Principal.elUsuario.Codigo),
                        int.Parse(txbCodigoCliente.Text),
                        txbCliente.Text,
                        txbTelefono.Text,
                        txbDireccion.Text,
                        double.Parse(NumDesc.Value.ToString()),
                        double.Parse(txbDesc.Text),
                        double.Parse(txbSubTotal.Text),
                        double.Parse(txbIV.Text),
                        double.Parse(txbTotalFact.Text),
                        tipoPago,
                        enviar);

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al insertar la Orden de Compra");
                    return;
                }
                txbId_Factura.Text = OrdenID.ToString();


                //insertar lineas de la orden
                foreach (ListViewItem elitem in lvItems.Items)
                {
                    //double descuento = 0, subtotal = 0;
                    //subtotal = double.Parse(elitem.SubItems[4].Text) - double.Parse(elitem.SubItems[5].Text);//el total menos el IV
                    //descuento = double.Parse(elitem.SubItems[4].Text) * double.Parse(NumDesc.Value.ToString()) / 100;
                    using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                        respuesta = elServicio.RegistarLineaOrdenCompra(OrdenID,
                            int.Parse(elitem.SubItems[0].Text),
                            elitem.SubItems[1].Text,
                            double.Parse(elitem.SubItems[2].Text),
                            double.Parse(elitem.SubItems[3].Text),
                            double.Parse(elitem.SubItems[8].Text),
                            double.Parse(elitem.SubItems[4].Text),
                            double.Parse(elitem.SubItems[5].Text),
                            double.Parse(elitem.SubItems[7].Text),
                            double.Parse(elitem.SubItems[6].Text));
                    if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta, "Error al insertar la linea");
                        return;
                    }
                }
                btnAtras.Enabled = false;

            }
            else
            { //Guardamos
                //vamos a eliminar todas las lineas viejas
                string respuesta1 = "";
                using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                    respuesta1 = elServicio.EliminarLineasOrden(int.Parse(txbId_Factura.Text));
                if (!respuesta1.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta1, "Error al eliminar las lineas");
                    return;
                }
                //insertar lineas de nuevo
                foreach (ListViewItem elitem in lvItems.Items)
                {
                    string respuesta2 = "";
                    using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                        respuesta2 = elServicio.RegistarLineaOrdenCompra(int.Parse(txbId_Factura.Text),
                            int.Parse(elitem.SubItems[0].Text),
                            elitem.SubItems[1].Text,
                            double.Parse(elitem.SubItems[2].Text),
                            double.Parse(elitem.SubItems[3].Text),
                            double.Parse(elitem.SubItems[8].Text),
                            double.Parse(elitem.SubItems[4].Text),
                            double.Parse(elitem.SubItems[5].Text),
                            double.Parse(elitem.SubItems[7].Text),
                            double.Parse(elitem.SubItems[6].Text));
                    if (!respuesta2.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        MessageBox.Show(respuesta2, "Error al insertar la linea");
                        return;
                    }
                }
                string respuesta = "";
                using (ServicioOrdenCompra elServicio = new ServicioOrdenCompra())
                    respuesta = elServicio.ModificarOrdenCompra(int.Parse(txbId_Factura.Text),
                        int.Parse(txbCodigoCliente.Text),
                        txbCliente.Text,
                        txbTelefono.Text,
                        txbDireccion.Text,
                        double.Parse(NumDesc.Value.ToString()),
                        double.Parse(txbDesc.Text),
                        double.Parse(txbSubTotal.Text),
                        double.Parse(txbIV.Text),
                        double.Parse(txbTotalFact.Text),
                        enviar
                        );

                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    MessageBox.Show(respuesta, "Error al guardar la orden de compra");
                    return;
                }
            }
        }

        private void btnPagarMixto_Click(object sender, EventArgs e)
        {
            try
            {
                int tipoPago = 3;
                if (txbCodigoCliente.Text == "")
                {
                    MessageBox.Show("INGRESE UN CLIENTE", "ERROR DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnBuscarCliente_Click(null, null);
                }
                else
                {
                    GuardarFactura(tipoPago);
                    total = txbTotalFact.Text;
                    // int tipoPago = 2;
                    Frm_Cambio forma1 = new Frm_Cambio(int.Parse(txbId_Factura.Text), tipoPago);
                    forma1.ShowDialog();
                    if (forma1.FacturoCorrecto)
                    {
                        facturoCorrecto = forma1.FacturoCorrecto;
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("ERROR AL GUARDAR FACT");
            }
        }

        
     }
}