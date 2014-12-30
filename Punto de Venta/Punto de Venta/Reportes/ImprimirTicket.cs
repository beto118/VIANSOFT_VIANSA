using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;
using Punto_de_Venta.Logica_de_Negocio;
using System.Threading;
using System.Windows.Forms;
using Punto_de_Venta.Pantallas.Orden_de_Compra;

namespace Punto_de_Venta.Reportes
{
    public class ImprimirTicket:IDisposable
    {
        string mensajeEmpresa = "";
        private int FacturaID = 0;
        private int OrdenID = 0;
        private int NOTAcredito = 0;
        private string impresora = "";
        private Thread elHilo;

        public ImprimirTicket()
        { }
        public void Dispose()
        { }
        public Ticket EncabezadoTicket(Ticket ticket)
        {
            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;
            ticket.EncabezadoArticulo = "CANT     DESCRIPCION       TOTAL";
            //ticket.FontSize = 8;
            //ticket.FontName = "System";
            DataRow drControl;
            using (ServicioGeneral elGestorGeneral = new ServicioGeneral())
                drControl = elGestorGeneral.ConsultarDatosEmpresa();
            ticket.AddHeaderLine(drControl["Control_NombreEmpresa"].ToString().ToUpper());
            try
            {
                if (drControl["Control_Propietario"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Propietario"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_Cedula"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Cedula"].ToString().ToUpper());
            }
            catch { }
           
            try
            {
                if (drControl["Control_telefono"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_telefono"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_Direccion"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Direccion"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_mensaje"].ToString().Length != 0)
                    mensajeEmpresa = drControl["Control_mensaje"].ToString().ToUpper();
            }
            catch { }
            return ticket;
        }
        //Imprimir la factura
        public void ImprimirFactura(int idFactura, string PrinterName)
        {
            impresora = PrinterName;
            FacturaID = idFactura;
            elHilo = new Thread(ImprimirFactura2);
            elHilo.Start();
        }
        //Imprimir la ORDEN DE COMPRA
        public void ImprimirOrdenCOMPRA(int OrdenID_IN, string PrinterName)
        {
            impresora = PrinterName;
            OrdenID = OrdenID_IN;
            elHilo = new Thread(ImprimirOrdenCompra2);
            elHilo.Start();
        }
        //Imprimir la NOTA CREDITO
        public void ImprimirNotaCredito(int NCid_IN, string PrinterName)
        {
            impresora = PrinterName;
            NOTAcredito = NCid_IN;
            elHilo = new Thread(ImprimirNotaCredito);
            elHilo.Start();
        }
        private void ImprimirFactura2()
        {
            
            //Si la impresora no esta definida, agarra la default
            if (impresora.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                impresora = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            DataRow drFactura;
            using (ServicioFactura elGestorFactura = new ServicioFactura())
                drFactura = elGestorFactura.ConsultarFactura(FacturaID);
            string fecha;
            using (ServicioGeneral elGestorGEN = new ServicioGeneral())
                fecha = elGestorGEN.FechaSistema();

            ticket = EncabezadoTicket(ticket);
            ticket.AddSubHeaderLine("");
            ticket.AddSubHeaderLine("FACTURA #: " + FacturaID);
            ticket.AddSubHeaderLine("FECHA: " + fecha);
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
                ticket.AddSubHeaderLine("FECHA VENC: " + drFactura["Fact_FechaLimite"].ToString());
            }
            //ticket.AddSubHeaderLine("NUM CAJA: " + drFactura["Caja_numero"].ToString());
            ticket.AddSubHeaderLine("VENDEDOR: " + drFactura["Usuario_nombre"].ToString());
            
            ticket.AddSubHeaderLine("ESTADO: " + drFactura["TipoPago_Descripcion"].ToString());
            //se ingresa el nombre sin cortarlo
            string NombreCliente1 = "";
            string NombreCliente2 = "";
            string NombreCliente3 = "";
            if (drFactura["Cliente"].ToString().Length < 23)
            {
                NombreCliente1 = drFactura["Cliente"].ToString();
            }
            else
            {
                int indexEspacio = drFactura["Cliente"].ToString().Substring(0, 23).LastIndexOf(" ");
                NombreCliente1 = drFactura["Cliente"].ToString().Substring(0, indexEspacio);
                NombreCliente2 = drFactura["Cliente"].ToString().Substring(indexEspacio, drFactura["Cliente"].ToString().Length - indexEspacio);

                if (NombreCliente2.Length > 23)
                {
                    //    return;
                    //}
                    //else
                    //{
                    string Nombre2 = "";
                    Nombre2 = NombreCliente2;
                    int indexEspacio1 = Nombre2.Substring(0, 23).LastIndexOf(" ");
                    NombreCliente2 = Nombre2.Substring(0, indexEspacio1);
                    NombreCliente3 = Nombre2.Substring(indexEspacio1, Nombre2.Length - indexEspacio1);
                }

            }
            ticket.AddSubHeaderLine("CLIENTE: " + NombreCliente1);
            if (NombreCliente2.Length > 0)
                ticket.AddSubHeaderLine(NombreCliente2);
            if (NombreCliente3.Length > 0)
                ticket.AddSubHeaderLine(NombreCliente3);
            //se ingresa  el num de telefono del cliente
            ticket.AddSubHeaderLine("TELEFONO: " + drFactura["Tel"].ToString());

            if (drFactura["Fact_Enviar"].ToString() == "1")
            {
                ticket.AddSubHeaderLine("DIRECCION: " + drFactura["Direccion"].ToString());
            }         
                
            DataTable dtDetalle;
            using (ServicioFactura elDetalle = new ServicioFactura())
                dtDetalle = elDetalle.ConsultarLinea(FacturaID);
            string productoNombre = "";
            //MessageBox.Show("antes de imprimir");
            if (dtDetalle.Rows.Count < 100)
            {
                foreach (DataRow lafila in dtDetalle.Rows)
                {

                    if (lafila["LinFact_prod_nombre"].ToString().Length < 18)
                        productoNombre = lafila["LinFact_prod_nombre"].ToString().PadRight(18, ' ');// + " " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString()));//+lafila["Producto_detalle"].ToString()
                    else
                        productoNombre = lafila["LinFact_prod_nombre"].ToString().Substring(0, 18);// +" " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString())); //+ lafila["Producto_detalle"].ToString()

                    ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["LinFact_prod_cantidad"].ToString())).ToString().Replace(",", ""), productoNombre, string.Format("{0:n1}", double.Parse(lafila["LinFact_subtotal"].ToString())));
                    
                }
            }
            else
            {
                //ticket.AddHeaderLine("");
                ticket.AddHeaderLine("PARTE 1");
                ticket.AddHeaderLine("");
                DataRow lafila;
                int limite = 100, i = 0, parte = 1;
                bool detener = false;
                while (!detener)
                {
                    if (limite == i)
                    {
                        ticket.PrintTicket(impresora);
                        Thread.Sleep(TimeSpan.FromSeconds(17));
                        limite += 100;
                        parte++;
                        ticket = new Ticket();
                        ticket.MaxChar -= 3;
                        ticket.MaxCharDescription -= 2;
                        ticket.AddHeaderLine("PARTE " + parte.ToString());
                        ticket.AddHeaderLine("");
                        ticket.AddSubHeaderLine("FACTURA #: " + FacturaID);
                        ticket.AddSubHeaderLine("CLIENTE: " + drFactura["Cliente"].ToString());
                    }
                    else
                    {
                        if (dtDetalle.Rows.Count - 1 == i)
                            detener = true;
                        lafila = dtDetalle.Rows[i];
                        if (lafila["LinFact_prod_nombre"].ToString().Length < 17)
                            productoNombre = lafila["LinFact_prod_nombre"].ToString().PadRight(18, ' ');// + " " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString())); //+ lafila["Producto_detalle"].ToString() 
                        else
                            productoNombre = lafila["LinFact_prod_nombre"].ToString().Substring(0, 18);// +" " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString())); // + lafila["Producto_detalle"].ToString()

                        ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["LinFact_prod_cantidad"].ToString())).ToString().Replace(",", ""), productoNombre, string.Format("{0:n1}", double.Parse(lafila["LinFact_subtotal"].ToString())));
                    
                        i++;

                    }
                }

            }
            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
            if (double.Parse(drFactura["Fact_subtotal"].ToString()) != double.Parse(drFactura["Fact_total"].ToString())) 
            ticket.AddTotal("SUBTOTAL", string.Format("{0:n1}", double.Parse(drFactura["Fact_subtotal"].ToString()) ));//,/ 1.13
            if (double.Parse(drFactura["Fact_totalDescuento"].ToString())!=0)
            ticket.AddTotal("DESCUENTO", string.Format("{0:n1}", double.Parse(drFactura["Fact_totalDescuento"].ToString())));
            if (double.Parse(drFactura["Fact_impuesto"].ToString())!=0)
            ticket.AddTotal("IV", string.Format("{0:n1}", double.Parse(drFactura["Fact_impuesto"].ToString())) );
            ticket.AddTotal("TOTAL", string.Format("{0:n1}", double.Parse(drFactura["Fact_total"].ToString())));
            ticket.AddTotal("","");
            if (drFactura["TipoPago_Descripcion"].ToString() != "CREDITO")
            {
                ticket.AddTotal("PAGA CON", string.Format("{0:n1}", (double.Parse(drFactura["Fact_montoCancela"].ToString()) + double.Parse(drFactura["Fact_montoCancelaTarjeta"].ToString()))));
                ticket.AddTotal("SU CAMBIO", string.Format("{0:n1}", (double.Parse(drFactura["Fact_montoCancela"].ToString()) + double.Parse(drFactura["Fact_montoCancelaTarjeta"].ToString())) - double.Parse(drFactura["Fact_total"].ToString())));
            }
            if (double.Parse(drFactura["Fact_Abono"].ToString()) != 0)
            {
                ticket.AddTotal("ABONO", string.Format("{0:n1}", double.Parse(drFactura["Fact_Abono"].ToString())));
                ticket.AddTotal("SALDO", string.Format("{0:n1}", double.Parse(drFactura["Fact_Saldo"].ToString())));
            }
            //si es credito le hacemos el campo para q firme
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
               
                ticket.AddFooterLine("RECIBIDO CONFORME:");
                ticket.AddFooterLine("");
                ticket.AddFooterLine("FIRMA:______________________");
                ticket.AddFooterLine("");
                ticket.AddFooterLine("");
                ticket.AddFooterLine("  CED:______________________");
                ticket.AddFooterLine("");
            }

            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            ticket.AddFooterLine("* = GRAVADO");
            ticket.AddFooterLine("****I.V.I****");
            ticket.AddFooterLine("GRACIAS POR SU VISITA");
            ticket.AddFooterLine("");
            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
                ticket.AddFooterLine("Esta Factura se rige por las    normas del artículo 460 del     Código de Comercio. Constituye  Título Ejecutivo. Después de 30 días devengará interes de Ley.");
            }
            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            ticket.AddFooterLine("Autorizado mediante Oficio # 4521000004315 de A.R.T de Alajuela de fecha 28/07/2009");

            ticket.AddMensajeFinal(mensajeEmpresa.ToUpper());
            
            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.

            ticket.PrintTicket(impresora);
            //MessageBox.Show("antes de imprimir");
        }

        //Imprimir la historial factura
        public void ImprimirHistFactura(int idFactura, string PrinterName)
        {
            impresora = PrinterName;
            FacturaID = idFactura;
            elHilo = new Thread(ImprimirHistFactura2);
            elHilo.Start();
        }
        private void ImprimirHistFactura2()
        {

            //Si la impresora no esta definida, agarra la default
            if (impresora.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                impresora = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            DataRow drFactura;
            using (ServicioFactura elGestorFactura = new ServicioFactura())
                drFactura = elGestorFactura.ConsultarHistFactura(FacturaID);
            string fecha;
            using (ServicioGeneral elGestorGEN = new ServicioGeneral())
                fecha = elGestorGEN.FechaSistema();

            ticket = EncabezadoTicket(ticket);
            ticket.AddSubHeaderLine("");
            ticket.AddSubHeaderLine("HISTORIAL DE FACTURA");
            ticket.AddSubHeaderLine("FACTURA #: " + FacturaID);
            ticket.AddSubHeaderLine("FECHA: " + fecha);
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
                ticket.AddSubHeaderLine("FECHA VENC: " + drFactura["HistFact_fechaLimite"].ToString());
            }
            //ticket.AddSubHeaderLine("NUM CAJA: " + drFactura["Caja_numero"].ToString());
            ticket.AddSubHeaderLine("VENDEDOR: " + drFactura["Usuario_nombre"].ToString());
            ticket.AddSubHeaderLine("ESTADO: " + drFactura["TipoPago_Descripcion"].ToString());
            ticket.AddSubHeaderLine("CLIENTE: " + drFactura["Cliente"].ToString());
            //ticket.AddSubHeaderLine("TELEFONO: " + drFactura["Tel"].ToString());

            //if (drFactura["Fact_Enviar"].ToString() == "1")
            //{
            //    ticket.AddSubHeaderLine("DIRECCION: " + drFactura["Direccion"].ToString());
            //}    
            

            DataTable dtDetalle;
            using (ServicioFactura elDetalle = new ServicioFactura())
                dtDetalle = elDetalle.ConsultarHistLinea(FacturaID);

            if (dtDetalle.Rows.Count < 100)
            {
                foreach (DataRow lafila in dtDetalle.Rows)
                {

                    ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["HistLinFact_prod_cantidad"].ToString())).ToString().Replace(",", ""), lafila["HistLinFact_prod_nombre"].ToString() + " V.U. " + string.Format("{0:n0}", double.Parse(lafila["HistLinFact_prod_valorUnitario"].ToString())), string.Format("{0:n0}", double.Parse(lafila["HistLinFact_prod_total"].ToString())));
                }
            }
            else
            {
                //ticket.AddHeaderLine("");
                ticket.AddHeaderLine("PARTE 1");
                ticket.AddHeaderLine("");
                DataRow lafila;
                int limite = 100, i = 0, parte = 1;
                bool detener = false;
                while (!detener)
                {
                    if (limite == i)
                    {
                        ticket.PrintTicket(impresora);
                        Thread.Sleep(TimeSpan.FromSeconds(17));
                        limite += 100;
                        parte++;
                        ticket = new Ticket();
                        ticket.MaxChar -= 3;
                        ticket.MaxCharDescription -= 2;
                        ticket.AddHeaderLine("PARTE " + parte.ToString());
                        ticket.AddHeaderLine("");
                        ticket.AddSubHeaderLine("FACTURA: " + FacturaID);
                        ticket.AddSubHeaderLine("CLIENTE: " + drFactura["fact_cliente"].ToString());
                    }
                    else
                    {
                        if (dtDetalle.Rows.Count - 1 == i)
                            detener = true;
                        lafila = dtDetalle.Rows[i];
                        ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["HistLinFact_prod_cantidad"].ToString())).ToString().Replace(",", ""), lafila["HistLinFact_prod_nombre"].ToString() ,string.Format("{0:n1}", double.Parse(lafila["HistLinFact_prod_total"].ToString())));//+ " V.U. " + string.Format("{0:n0}", double.Parse(lafila["HistLinFact_prod_valorUnitario"].ToString())), 
                        i++;

                    }
                }

            }


            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
            if (double.Parse(drFactura["HistFact_subtotal"].ToString()) != double.Parse(drFactura["HistFact_total"].ToString())) 
            ticket.AddTotal("SUBTOTAL", string.Format("{0:n1}", double.Parse(drFactura["HistFact_subtotal"].ToString())));
            if (double.Parse(drFactura["HistFact_totalDescuento"].ToString()) != 0)
            ticket.AddTotal("DESCUENTO", string.Format("{0:n1}", double.Parse(drFactura["HistFact_totalDescuento"].ToString())));
            if (double.Parse(drFactura["HistFact_impuesto"].ToString()) != 0)
            ticket.AddTotal("IV", string.Format("{0:n1}", double.Parse(drFactura["HistFact_impuesto"].ToString())));
            ticket.AddTotal("TOTAL", string.Format("{0:n1}", double.Parse(drFactura["HistFact_total"].ToString())));
            ticket.AddTotal("", "");
            if (drFactura["TipoPago_Descripcion"].ToString() != "CREDITO")
            {
                ticket.AddTotal("PAGA CON", string.Format("{0:n1}", (double.Parse(drFactura["HistFact_montoCancela"].ToString()) + double.Parse(drFactura["HistFact_montoCancelaTarjeta"].ToString()))));
                ticket.AddTotal("SU CAMBIO", string.Format("{0:n1}", (double.Parse(drFactura["HistFact_montoCancela"].ToString()) + double.Parse(drFactura["HistFact_montoCancelaTarjeta"].ToString())) - double.Parse(drFactura["HistFact_total"].ToString())));
            }
            //si es credito le hacemos el campo para q firme
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
                ticket.AddFooterLine("RECIBIDO CONFORME:");
                ticket.AddFooterLine("");
                ticket.AddFooterLine("FIRMA:______________________");
                ticket.AddFooterLine("");
                ticket.AddFooterLine("");
                ticket.AddFooterLine("  CED:______________________");
                ticket.AddFooterLine("");
            }

            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            ticket.AddFooterLine("* = GRAVADO");
            ticket.AddFooterLine("GRACIAS POR SU VISITA");
            ticket.AddFooterLine("****I.V.I****");
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
                ticket.AddFooterLine("Esta Factura se rige por las    normas del artículo 460 del     Código de Comercio. Constituye  Título Ejecutivo. Después de 30 días devengará interes de Ley.");
            }
         
            ticket.AddFooterLine("Autorizado mediante Oficio # 4521000004315 de A.R.T de Alajuela de fecha 28/07/2009");

            ticket.AddMensajeFinal(mensajeEmpresa.ToUpper());

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.

            ticket.PrintTicket(impresora);
        }

        //Imprimir la historial ordenes
        public void ImprimirHistOrden(int idFactura, string PrinterName)
        {
            impresora = PrinterName;
            FacturaID = idFactura;
            elHilo = new Thread(ImprimirHistOrden2);
            elHilo.Start();
        }
        private void ImprimirHistOrden2()
        {

            //Si la impresora no esta definida, agarra la default
            if (impresora.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                impresora = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            DataRow drFactura;
            using (ServicioOrdenCompra elGestorFactura = new ServicioOrdenCompra())
                drFactura = elGestorFactura.ConsultarHistOrdenCompra(FacturaID);
            //string fecha;
            //using (ServicioGeneral elGestorGEN = new ServicioGeneral())
            //    fecha = elGestorGEN.FechaSistema();

            ticket = EncabezadoTicket(ticket);
            ticket.AddSubHeaderLine("");
            ticket.AddSubHeaderLine("HISTORIAL DE ORDEN");
            ticket.AddSubHeaderLine("FACTURA  ID#: " + FacturaID);
            ticket.AddSubHeaderLine("FECHA: " + drFactura["HistFact_fecha"].ToString());
            
            //ticket.AddSubHeaderLine("NUM CAJA: " + drFactura["Caja_numero"].ToString());
            ticket.AddSubHeaderLine("VENDEDOR: " + drFactura["Usuario_nombre"].ToString());
            ticket.AddSubHeaderLine("ESTADO: " + drFactura["TipoPago_Descripcion"].ToString());
            ticket.AddSubHeaderLine("CLIENTE: " + drFactura["Cliente"].ToString());
            ticket.AddSubHeaderLine("TELEFONO: " + drFactura["Tel"].ToString());

            if (drFactura["HisOrden_Enviar"].ToString() == "1")
            {
                ticket.AddSubHeaderLine("DIRECCION: " + drFactura["Direccion"].ToString());
            }    


            DataTable dtDetalle;
            using (ServicioOrdenCompra elDetalle = new ServicioOrdenCompra())
                dtDetalle = elDetalle.ConsultarHistLinea(FacturaID);

            if (dtDetalle.Rows.Count < 100)
            {
                foreach (DataRow lafila in dtDetalle.Rows)
                {

                    ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["HistLinOrden_prod_cantidad"].ToString())).ToString().Replace(",", ""), lafila["HistLinOrden_prod_nombre"].ToString() + " V.U. " + string.Format("{0:n0}", double.Parse(lafila["HistLinOrden_prod_valorUnitario"].ToString())), string.Format("{0:n0}", double.Parse(lafila["HistLinOrden_prod_total"].ToString())));
                }
            }
            else
            {
                //ticket.AddHeaderLine("");
                ticket.AddHeaderLine("PARTE 1");
                ticket.AddHeaderLine("");
                DataRow lafila;
                int limite = 100, i = 0, parte = 1;
                bool detener = false;
                while (!detener)
                {
                    if (limite == i)
                    {
                        ticket.PrintTicket(impresora);
                        Thread.Sleep(TimeSpan.FromSeconds(17));
                        limite += 100;
                        parte++;
                        ticket = new Ticket();
                        ticket.MaxChar -= 3;
                        ticket.MaxCharDescription -= 2;
                        ticket.AddHeaderLine("PARTE " + parte.ToString());
                        ticket.AddHeaderLine("");
                        ticket.AddSubHeaderLine("FACTURA ID# " + FacturaID);
                        ticket.AddSubHeaderLine("CLIENTE: " + drFactura["Cliente"].ToString());
                    }
                    else
                    {
                        if (dtDetalle.Rows.Count - 1 == i)
                            detener = true;
                        lafila = dtDetalle.Rows[i];

                        ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["HistLinOrden_prod_cantidad"].ToString())).ToString().Replace(",", ""), lafila["HistLinOrden_prod_nombre"].ToString() + " V.U. " + string.Format("{0:n0}", double.Parse(lafila["HistLinOrden_prod_valorUnitario"].ToString())), string.Format("{0:n0}", double.Parse(lafila["HistLinOrden_prod_total"].ToString())));//+ " V.U. " + string.Format("{0:n0}", double.Parse(lafila["HistLinFact_prod_valorUnitario"].ToString())), 
                        i++;

                    }
                }

            }


            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
            //if (double.Parse(drFactura["HistFact_subtotal"].ToString()) != double.Parse(drFactura["HistFact_total"].ToString()))
            //    ticket.AddTotal("SUBTOTAL", string.Format("{0:n1}", double.Parse(drFactura["HistFact_subtotal"].ToString())));
            if (double.Parse(drFactura["HisOrden_TotalDescuento"].ToString()) != 0)
                ticket.AddTotal("DESCUENTO", string.Format("{0:n1}", double.Parse(drFactura["HisOrden_TotalDescuento"].ToString())));
            //if (double.Parse(drFactura["HistFact_impuesto"].ToString()) != 0)
            //    ticket.AddTotal("IV", string.Format("{0:n1}", double.Parse(drFactura["HistFact_impuesto"].ToString())));
            ticket.AddTotal("TOTAL", string.Format("{0:n1}", double.Parse(drFactura["HisOrden_total"].ToString())));
            ticket.AddTotal("", "");
            
            //si es credito le hacemos el campo para q firme
            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            ticket.AddFooterLine("* = GRAVADO");
            ticket.AddFooterLine("GRACIAS POR PREFERIRNOS");
            ticket.AddFooterLine("****I.V.I****");
            if (drFactura["TipoPago_Descripcion"].ToString() == "CREDITO")
            {
                ticket.AddFooterLine("Esta Factura se rige por las    normas del artículo 460 del     Código de Comercio. Constituye  Título Ejecutivo. Después de 30 días devengará interes de Ley.");
            }

            ticket.AddFooterLine("Autorizado mediante Oficio # 4521000004315 de A.R.T de Alajuela de fecha 28/07/2009");

            ticket.AddMensajeFinal(mensajeEmpresa.ToUpper());

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.

            ticket.PrintTicket(impresora);
        }


        //imprimir cierre de caja
        public void ImprimirCierreCaja(string PrinterName, int ventaXcaja_id)
        {
            Conexion.laConexion.LeerXML();
            //Si la impresora no esta definida, agarra la default
            if (PrinterName.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                PrinterName = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;

            DataRow drControl;
            using (ServicioGeneral elGestorGeneral = new ServicioGeneral())
                drControl = elGestorGeneral.ConsultarDatosEmpresa();
            ticket.AddHeaderLine(drControl["Control_NombreEmpresa"].ToString().ToUpper());

            ticket.AddSubHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("*** DETALLE CIERRE CAJA ***");

            DataRow drCierre = null;
            using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                drCierre = elServicio.ConsultaDetalleCierres(ventaXcaja_id);

            ticket.AddSubHeaderLine("CIERRE #: " + ventaXcaja_id.ToString());
            ticket.AddSubHeaderLine("   FECHA: " + drCierre["ventaXcaja_fecha"].ToString());
            ticket.AddSubHeaderLine("  CAJA #: " + drCierre["caja_numero"].ToString());
            ticket.AddSubHeaderLine(" FACT CONT: " + drCierre["ventaXcaja_numeroFactura"].ToString());
            ticket.AddSubHeaderLine(" FACT CRED: " + drCierre["ventaXcaja_numeroFactCredito"].ToString());
            ticket.AddSubHeaderLine("FACT NULAS:" + drCierre["ventaXcaja_numeroFacturaNulas"].ToString());
            ticket.AddSubHeaderLine("VENTA EFEC: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_montoEfectivo"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("VENTA TARJ: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_montoTarjeta"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("        IV: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_impuesto"].ToString())).PadLeft(10, ' '));

            ticket.AddSubHeaderLine("  EGRESO +: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_egresos_Suma"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("  EGRESO -: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_egresos_resta"].ToString())).PadLeft(10, ' '));

            ticket.AddSubHeaderLine("     TOTAL: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_total"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("  UTILIDAD: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_Utilidad"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("APERTURA CAJA: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_MontoAperturaCaja"].ToString())).PadLeft(10, ' '));

            ticket.PrintTicket(PrinterName);
        }
        //imprimir cierre de caja ORDENES
        public void ImprimirCierreORDENES(string PrinterName, int Ordenes_id)
        {
            Conexion.laConexion.LeerXML();
            //Si la impresora no esta definida, agarra la default
            if (PrinterName.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                PrinterName = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;

            DataRow drControl;
            using (ServicioGeneral elGestorGeneral = new ServicioGeneral())
                drControl = elGestorGeneral.ConsultarDatosEmpresa();
            ticket.AddHeaderLine(drControl["Control_NombreEmpresa"].ToString().ToUpper());

            ticket.AddSubHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("*** DETALLE CIERRE ORDENES ***");

            DataRow drCierre = null;
            using (ServicioCierreCaja elServicio = new ServicioCierreCaja())
                drCierre = elServicio.ConsultaDetalleFinalizacionOrden(Ordenes_id);


            ticket.AddSubHeaderLine("CIERRE #: " + Ordenes_id.ToString());
            ticket.AddSubHeaderLine("   FECHA: " + drCierre["Orden_fecha"].ToString());
            //ticket.AddSubHeaderLine("  CAJA #: " + drCierre["caja_numero"].ToString());
            ticket.AddSubHeaderLine("FACT CONT: " + string.Format("{0:n0}", double.Parse(drCierre["OrdenXcaja_numeroFactura"].ToString())).PadLeft(10, ' '));
            //  ticket.AddSubHeaderLine("FACT CRED: " + string.Format("{0:n0}", double.Parse(drCierre["ventaXcaja_numeroFactCredito"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("FACT NULAS:" + string.Format("{0:n0}", double.Parse(drCierre["OrdenXcaja_numeroFacturaNulas"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("VENTA EFEC: " + string.Format("{0:n1}", double.Parse(drCierre["OrdenXcaja_montoEfectivo"].ToString())).PadLeft(10, ' '));
            // ticket.AddSubHeaderLine("VENTA CRED: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_montoCredito"].ToString())).PadLeft(10, ' '));
            // ticket.AddSubHeaderLine("        IV: " + string.Format("{0:n1}", double.Parse(drCierre["ventaXcaja_impuesto"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("     TOTAL: " + string.Format("{0:n1}", double.Parse(drCierre["OrdenXcaja_total"].ToString())).PadLeft(10, ' '));


            ticket.PrintTicket(PrinterName);
        }
        //imprimir el Resibo de un abono de factura
        public void ImprimirResiboAbono(string PrinterName, int Abono_ID,int Fact_Numero)
        {
            Conexion.laConexion.LeerXML();
            //Si la impresora no esta definida, agarra la default
            if (PrinterName.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                PrinterName = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;

            DataRow drControl;
            using (ServicioGeneral elGestorGeneral = new ServicioGeneral())
                drControl = elGestorGeneral.ConsultarDatosEmpresa();
            ticket.AddHeaderLine(drControl["Control_NombreEmpresa"].ToString().ToUpper());
            try
            {
                if (drControl["Control_Propietario"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Propietario"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_Cedula"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Cedula"].ToString().ToUpper());
            }
            catch { }

            try
            {
                if (drControl["Control_telefono"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_telefono"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_Direccion"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Direccion"].ToString().ToUpper());
            }
            catch { }
            ticket.AddSubHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("** RECIBO DE ABONO A FACTURA **");

            DataRow drResibo = null;
            using (ServicioAbono elServicio = new ServicioAbono())
                drResibo = elServicio.ConsultarAbonoImprimir(Abono_ID, Fact_Numero);


            ticket.AddSubHeaderLine("RECIBO NUMERO : " + Abono_ID.ToString());
            ticket.AddSubHeaderLine("FACTURA NUMERO: " + Fact_Numero); //drResibo["NumeroFact"].ToString());
            ticket.AddSubHeaderLine("FACTURA ESTADO: " + drResibo["FactEstado"].ToString());
            ticket.AddSubHeaderLine("FECHA VENCIMIENTO: " + drResibo["FechaLimite"].ToString());
            ticket.AddSubHeaderLine("CLIENTE: " + drResibo["ClieNombre"].ToString());
            ticket.AddSubHeaderLine("USUARIO: " + drResibo["UsuarioNombre"].ToString());
            ticket.AddSubHeaderLine("FECHA RECIBO: " + drResibo["FechaRecibo"].ToString());
            
            ticket.AddSubHeaderLine("");
            //ticket.AddSubHeaderLine("SALDO TOTAL FACT " + string.Format("{0:n1}", double.Parse(drResibo["MontoFactura"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("SALDO ANTERIOR:  " + string.Format("{0:n1}", double.Parse(drResibo["SaldoAnterior"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("    ESTE ABONO:  " + string.Format("{0:n1}", double.Parse(drResibo["abono_Monto"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("                 ==============");
            ticket.AddSubHeaderLine("  SALDO ACTUAL:  " + string.Format("{0:n1}", double.Parse(drResibo["SaldoActual"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("");
            if (drResibo["abono_Detalle"].ToString()!="") ticket.AddSubHeaderLine("DETALLE: " + drResibo["abono_Detalle"].ToString());


            ticket.AddFooterLine("RECIBIDO POR:");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("FIRMA:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("  CED:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("** GRACIAS POR SU VISITA **");
            ticket.PrintTicket(PrinterName);
        }
        //del dia antes del cierre
        public void ImprimirResiboAbonoFactHoy(string PrinterName, int Abono_ID, int Fact_Numero)
        {
            Conexion.laConexion.LeerXML();
            //Si la impresora no esta definida, agarra la default
            if (PrinterName.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                PrinterName = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;

            DataRow drControl;
            using (ServicioGeneral elGestorGeneral = new ServicioGeneral())
                drControl = elGestorGeneral.ConsultarDatosEmpresa();
            ticket.AddHeaderLine(drControl["Control_NombreEmpresa"].ToString().ToUpper());
            try
            {
                if (drControl["Control_Propietario"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Propietario"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_Cedula"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Cedula"].ToString().ToUpper());
            }
            catch { }

            try
            {
                if (drControl["Control_telefono"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_telefono"].ToString().ToUpper());
            }
            catch { }
            try
            {
                if (drControl["Control_Direccion"].ToString().Length != 0)
                    ticket.AddHeaderLine(drControl["Control_Direccion"].ToString().ToUpper());
            }
            catch { }
            ticket.AddSubHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("** RECIBO DE ABONO A FACTURA **");

            DataRow drResibo = null;
            using (ServicioAbono elServicio = new ServicioAbono())
                drResibo = elServicio.ConsultarAbonoFactHOYimprimir(Abono_ID, Fact_Numero);


            ticket.AddSubHeaderLine("RECIBO NUMERO : " + Abono_ID.ToString());
            ticket.AddSubHeaderLine("FACTURA NUMERO: " + Fact_Numero); //drResibo["NumeroFact"].ToString());
            ticket.AddSubHeaderLine("FACTURA ESTADO: " + drResibo["FactEstado"].ToString());
            ticket.AddSubHeaderLine("FECHA VENCIMIENTO: " + drResibo["FechaLimite"].ToString());
            ticket.AddSubHeaderLine("CLIENTE: " + drResibo["ClieNombre"].ToString());
            ticket.AddSubHeaderLine("USUARIO: " + drResibo["UsuarioNombre"].ToString());
            ticket.AddSubHeaderLine("FECHA RECIBO: " + drResibo["FechaRecibo"].ToString());

            ticket.AddSubHeaderLine("");
            //ticket.AddSubHeaderLine("SALDO TOTAL FACT " + string.Format("{0:n1}", double.Parse(drResibo["MontoFactura"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("SALDO ANTERIOR:  " + string.Format("{0:n1}", double.Parse(drResibo["SaldoAnterior"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("    ESTE ABONO:  " + string.Format("{0:n1}", double.Parse(drResibo["abono_Monto"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("                 ==============");
            ticket.AddSubHeaderLine("  SALDO ACTUAL:  " + string.Format("{0:n1}", double.Parse(drResibo["SaldoActual"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("");
            if (drResibo["abono_Detalle"].ToString() != "") ticket.AddSubHeaderLine("DETALLE: " + drResibo["abono_Detalle"].ToString());


            ticket.AddFooterLine("RECIBIDO POR:");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("FIRMA:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("  CED:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("** GRACIAS POR SU VISITA **");
            ticket.PrintTicket(PrinterName);
        }
        //imprimir pago vendedor
        public void ImprimirPagoVendedor(string PrinterName, int pagoVendedor_id)
        {
            Conexion.laConexion.LeerXML();
            //Si la impresora no esta definida, agarra la default
            if (PrinterName.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                PrinterName = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;

            DataRow drControl;
            using (ServicioControl elGestorGeneral = new ServicioControl())
                drControl = elGestorGeneral.ConsultarControl();
            ticket.AddHeaderLine(drControl["Control_NombreEmpresa"].ToString().ToUpper());

            ticket.AddSubHeaderLine("");
            ticket.AddHeaderLine("");
            ticket.AddHeaderLine("*** COMPROBANTE DE PAGO ***");
            ticket.AddHeaderLine("");
            //consultar pago del empleado
            DataRow drPago = null;
            using (ServicioPagoVendedor elServicio = new ServicioPagoVendedor())
                drPago = elServicio.ConsultarPagoVendedor(pagoVendedor_id);
            
                      
            //consultar total de horas
            DataRow drPagoHoras = null;
            using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                drPagoHoras = elServicio.TotalHorasDePago(pagoVendedor_id);

            ticket.AddSubHeaderLine("id:   " + drPago["PagoVendedor_id"].ToString());
            ticket.AddSubHeaderLine("FECHA: " + drPago["PagoVendedor_fecha"].ToString());

            //vamos a cortar el nombre ********************************************************************************
            string NombreTrabajador1 = "";
            string NombreTrabajador2 = "";
            string NombreTrabajador3 = "";
            if (drPago["Usuario_nombre"].ToString().Length < 23)
            {
                NombreTrabajador1 = drPago["Usuario_nombre"].ToString();
            }
            else
            {
                int indexEspacio = drPago["Usuario_nombre"].ToString().Substring(0, 23).LastIndexOf(" ");
                NombreTrabajador1 = drPago["Usuario_nombre"].ToString().Substring(0, indexEspacio);
                NombreTrabajador2 = drPago["Usuario_nombre"].ToString().Substring(indexEspacio, drPago["Usuario_nombre"].ToString().Length - indexEspacio);

                if (NombreTrabajador2.Length > 23)
                {
                    //    return;
                    //}
                    //else
                    //{
                    string Nombre2 = "";
                    Nombre2 = NombreTrabajador2;
                    int indexEspacio1 = Nombre2.Substring(0, 23).LastIndexOf(" ");
                    NombreTrabajador2 = Nombre2.Substring(0, indexEspacio1);
                    NombreTrabajador3 = Nombre2.Substring(indexEspacio1, Nombre2.Length - indexEspacio1);
                }

            }
            ticket.AddSubHeaderLine("TRABAJADOR:" + NombreTrabajador1);
            if (NombreTrabajador2.Length > 0)
                ticket.AddSubHeaderLine(NombreTrabajador2);
            if (NombreTrabajador3.Length > 0)
                ticket.AddSubHeaderLine(NombreTrabajador3);
            //*************************************************************************************************************************************

            ticket.AddSubHeaderLine("CEDULA: " + drPago["usuario_cedula"].ToString());
            ticket.AddSubHeaderLine("PRECIO X HORA: " + string.Format("{0:n1}", double.Parse(drPago["Usuario_GanaXhora"].ToString())).PadLeft(11, ' '));
            ticket.AddSubHeaderLine("HORAS:    " + drPagoHoras["HORAS"].ToString().PadLeft(3, ' '));
            ticket.AddSubHeaderLine("MINUTOS:  " + drPagoHoras["MINUTOS"].ToString().PadLeft(3, ' '));
            ticket.AddSubHeaderLine("SALARIO:       " + string.Format("{0:n1}", double.Parse(drPago["PagoVendedor_salario"].ToString())).PadLeft(13, ' '));
            ticket.AddSubHeaderLine("CCSS 9.17%:    " + string.Format("{0:n1}", double.Parse(drPago["PagoVendedor_Rebajas"].ToString())).PadLeft(13, ' '));
            ticket.AddSubHeaderLine("            ===================");
            ticket.AddSubHeaderLine("TOTAL PAGAR:   " + string.Format("{0:n1}", double.Parse(drPago["PagoVendedor_TotalPagar"].ToString())).PadLeft(13, ' '));
            //if (double.Parse(drPago["Prestamo_saldo"].ToString()) != 0)
            //{
            //    ticket.AddSubHeaderLine("PRESTAMO");
            //    ticket.AddSubHeaderLine("SALDO ANT:  " + string.Format("{0:n1}", double.Parse(drPago["Prestamo_saldoAnterior"].ToString())).PadLeft(13, ' '));
            //    ticket.AddSubHeaderLine("ABONO:      " + string.Format("{0:n1}", double.Parse(drPago["Prestamo_abono"].ToString())).PadLeft(13, ' '));
            //    ticket.AddSubHeaderLine("SALDO:      " + string.Format("{0:n1}", double.Parse(drPago["Prestamo_saldo"].ToString())).PadLeft(13, ' '));
            //}
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("RECIBIDO POR:");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("FIRMA:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("  CED:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.PrintTicket(PrinterName);
        }
        ///*********imprimir orden de compra **********************************************************************************************
        private void ImprimirOrdenCompra2()
        {

            //Si la impresora no esta definida, agarra la default
            if (impresora.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                impresora = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            DataRow drOrdenCompra;
            using (ServicioOrdenCompra elGestorFactura = new ServicioOrdenCompra())
                drOrdenCompra = elGestorFactura.ConsultarOrdenCompra(OrdenID);
            string fecha;
            using (ServicioGeneral elGestorGEN = new ServicioGeneral())
                fecha = elGestorGEN.FechaSistema();

            ticket = EncabezadoTicket(ticket);
            ticket.AddSubHeaderLine("");
            ticket.AddSubHeaderLine("FACT ID#: " + OrdenID);
            ticket.AddSubHeaderLine("FECHA: " + fecha);

            ticket.AddSubHeaderLine("VENDEDOR: " + drOrdenCompra["Usuario_nombre"].ToString());

           // ticket.AddSubHeaderLine("ESTADO: " + drFactura["TipoPago_Descripcion"].ToString());
            //se ingresa el nombre sin cortarlo
            string NombreCliente1 = "";
            string NombreCliente2 = "";
            string NombreCliente3 = "";
            if (drOrdenCompra["Cliente"].ToString().Length < 23)
            {
                NombreCliente1 = drOrdenCompra["Cliente"].ToString();
            }
            else
            {
                int indexEspacio = drOrdenCompra["Cliente"].ToString().Substring(0, 23).LastIndexOf(" ");
                NombreCliente1 = drOrdenCompra["Cliente"].ToString().Substring(0, indexEspacio);
                NombreCliente2 = drOrdenCompra["Cliente"].ToString().Substring(indexEspacio, drOrdenCompra["Cliente"].ToString().Length - indexEspacio);

                if (NombreCliente2.Length > 23)
                {
                    //    return;
                    //}
                    //else
                    //{
                    string Nombre2 = "";
                    Nombre2 = NombreCliente2;
                    int indexEspacio1 = Nombre2.Substring(0, 23).LastIndexOf(" ");
                    NombreCliente2 = Nombre2.Substring(0, indexEspacio1);
                    NombreCliente3 = Nombre2.Substring(indexEspacio1, Nombre2.Length - indexEspacio1);
                }

            }
            ticket.AddSubHeaderLine("CLIENTE: " + NombreCliente1);
            if (NombreCliente2.Length > 0)
                ticket.AddSubHeaderLine(NombreCliente2);
            if (NombreCliente3.Length > 0)
                ticket.AddSubHeaderLine(NombreCliente3);
            //se ingresa  el num de telefono del cliente
            ticket.AddSubHeaderLine("TELEFONO: " + drOrdenCompra["Tel"].ToString());

            if (drOrdenCompra["Orden_Enviar"].ToString() == "1")
            {
                ticket.AddSubHeaderLine("DIRECCION: " + drOrdenCompra["Direccion"].ToString());
            }

            DataTable dtDetalle;
            using (ServicioOrdenCompra elDetalle = new ServicioOrdenCompra())
                dtDetalle = elDetalle.ConsultarLineaOrden(OrdenID);
            string productoNombre = "";
            //MessageBox.Show("antes de imprimir");
            if (dtDetalle.Rows.Count < 100)
            {
                foreach (DataRow lafila in dtDetalle.Rows)
                {

                    if (lafila["LinOrden_prod_nombre"].ToString().Length < 18)
                        productoNombre = lafila["LinOrden_prod_nombre"].ToString().PadRight(18, ' ');// + " " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString()));//+lafila["Producto_detalle"].ToString()
                    else
                        productoNombre = lafila["LinOrden_prod_nombre"].ToString().Substring(0, 18);// +" " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString())); //+ lafila["Producto_detalle"].ToString()

                    double totalLinea=0;
                    if (double.Parse(lafila["LinOrden_impuesto"].ToString()).Equals(0))
                    {
                        totalLinea = double.Parse(lafila["LinOrden_prod_total"].ToString()) ;
                    }
                    else
                    {
                        totalLinea = double.Parse(lafila["LinOrden_prod_total"].ToString());//+ (double.Parse(lafila["LinOrden_prod_total"].ToString()) * 0.13
                    }
                    ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["LinOrden_prod_cantidad"].ToString())).ToString().Replace(",", ""), productoNombre, string.Format("{0:n1}", totalLinea));

                }
            }
            else
            {
                //ticket.AddHeaderLine("");
                ticket.AddHeaderLine("PARTE 1");
                ticket.AddHeaderLine("");
                DataRow lafila;
                int limite = 100, i = 0, parte = 1;
                bool detener = false;
                while (!detener)
                {
                    if (limite == i)
                    {
                        ticket.PrintTicket(impresora);
                        Thread.Sleep(TimeSpan.FromSeconds(17));
                        limite += 100;
                        parte++;
                        ticket = new Ticket();
                        ticket.MaxChar -= 3;
                        ticket.MaxCharDescription -= 2;
                        ticket.AddHeaderLine("PARTE " + parte.ToString());
                        ticket.AddHeaderLine("");
                        ticket.AddSubHeaderLine("FACT ID#: " + FacturaID);
                        ticket.AddSubHeaderLine("CLIENTE: " + drOrdenCompra["Cliente"].ToString());
                    }
                    else
                    {
                        if (dtDetalle.Rows.Count - 1 == i)
                            detener = true;
                        lafila = dtDetalle.Rows[i];
                        if (lafila["LinOrden_prod_nombre"].ToString().Length < 17)
                            productoNombre = lafila["LinOrden_prod_nombre"].ToString().PadRight(18, ' ');// + " " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString())); //+ lafila["Producto_detalle"].ToString() 
                        else
                            productoNombre = lafila["LinOrden_prod_nombre"].ToString().Substring(0, 18);// +" " + string.Format("{0:n0}", double.Parse(lafila["LinFact_prod_valorUnitario"].ToString())); // + lafila["Producto_detalle"].ToString()

                        double totalLinea = double.Parse(lafila["LinOrden_prod_total"].ToString()) + (double.Parse(lafila["LinOrden_prod_total"].ToString()) * 0.13);
                        ticket.AddItem(string.Format("{0:n1}", double.Parse(lafila["LinOrden_prod_cantidad"].ToString())).ToString().Replace(",", ""), productoNombre, string.Format("{0:n1}", totalLinea));

                        i++;

                    }
                }

            }
            //El metodo AddTotal requiere 2 parametros, la descripcion del total, y el precio
            //if (double.Parse(drOrdenCompra["Orden_subtotal"].ToString()) != double.Parse(drOrdenCompra["Orden_total"].ToString()))
            //    ticket.AddTotal("SUBTOTAL", string.Format("{0:n1}", double.Parse(drOrdenCompra["Orden_subtotal"].ToString())));//,/ 1.13
            //if (double.Parse(drOrdenCompra["Orden_TotalDescuento"].ToString()) != 0)
            //{
            //    ticket.AddTotal("DESCUENTO ", string.Format("{0:n0}", double.Parse(drOrdenCompra["Orden_descuento"].ToString())) + "%");
            //}
            //if (double.Parse(drOrdenCompra["Orden_impuesto"].ToString()) != 0)
            //    ticket.AddTotal("IV", string.Format("{0:n1}", double.Parse(drOrdenCompra["Orden_impuesto"].ToString())));
            ticket.AddTotal("TOTAL", string.Format("{0:n1}", double.Parse(drOrdenCompra["Orden_total"].ToString())));
            ticket.AddTotal("", "");

            ticket.AddTotal("PAGA CON", string.Format("{0:n1}", (double.Parse(drOrdenCompra["Orden_montoCancela"].ToString()) + double.Parse(drOrdenCompra["Orden_montoCancelaTarjeta"].ToString()))));
            ticket.AddTotal("SU CAMBIO", string.Format("{0:n1}", (double.Parse(drOrdenCompra["Orden_montoCancela"].ToString()) + double.Parse(drOrdenCompra["Orden_montoCancelaTarjeta"].ToString())) - double.Parse(drOrdenCompra["Orden_total"].ToString())));
            
                  
            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
           // ticket.AddFooterLine("* = GRAVADO");
           // ticket.AddFooterLine("****I.V.I****");
            ticket.AddFooterLine("GRACIAS POR SU VISITA");
            ticket.AddFooterLine("");
          //  ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            
           // ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            //ticket.AddFooterLine("Autorizado mediante Oficio # 4521000004315 de A.R.T de Alajuela de fecha 28/07/2009");

            ticket.AddMensajeFinal(mensajeEmpresa.ToUpper());

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.

            ticket.PrintTicket(impresora);
            //MessageBox.Show("antes de imprimir");
        }

        ///*********imprimir NOTA DE CREDITO ***************************************************************************************************/////
        private void ImprimirNotaCredito()
        {

            //Si la impresora no esta definida, agarra la default
            if (impresora.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                impresora = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            DataRow drNC;
            using (ServicioNotaCredito elGestorFactura = new ServicioNotaCredito())
                drNC = elGestorFactura.ConsultarNC(NOTAcredito);
            string fecha;
            using (ServicioGeneral elGestorGEN = new ServicioGeneral())
                fecha = elGestorGEN.FechaSistema();

            ticket = EncabezadoTicket(ticket);
            ticket.AddSubHeaderLine("");
            ticket.AddSubHeaderLine("Nota ID #: " + NOTAcredito);
            ticket.AddSubHeaderLine("FECHA: " + fecha);

            ticket.AddSubHeaderLine("VENDEDOR: " + int.Parse(drNC["NC_UsuarioId"].ToString()));

            // ticket.AddSubHeaderLine("ESTADO: " + drFactura["TipoPago_Descripcion"].ToString());
            //se ingresa el nombre sin cortarlo
            string NombreCliente1 = "";
            string NombreCliente2 = "";
            string NombreCliente3 = "";
            if (drNC["Cliente"].ToString().Length < 23)
            {
                NombreCliente1 = drNC["Cliente"].ToString();
            }
            else
            {
                int indexEspacio = drNC["Cliente"].ToString().Substring(0, 23).LastIndexOf(" ");
                NombreCliente1 = drNC["Cliente"].ToString().Substring(0, indexEspacio);
                NombreCliente2 = drNC["Cliente"].ToString().Substring(indexEspacio, drNC["Cliente"].ToString().Length - indexEspacio);

                if (NombreCliente2.Length > 23)
                {
                    //    return;
                    //}
                    //else
                    //{
                    string Nombre2 = "";
                    Nombre2 = NombreCliente2;
                    int indexEspacio1 = Nombre2.Substring(0, 23).LastIndexOf(" ");
                    NombreCliente2 = Nombre2.Substring(0, indexEspacio1);
                    NombreCliente3 = Nombre2.Substring(indexEspacio1, Nombre2.Length - indexEspacio1);
                }

            }
            ticket.AddSubHeaderLine("CLIENTE: " + NombreCliente1);
            if (NombreCliente2.Length > 0)
                ticket.AddSubHeaderLine(NombreCliente2);
            if (NombreCliente3.Length > 0)
                ticket.AddSubHeaderLine(NombreCliente3);
            //se ingresa  el num de telefono del cliente
            ticket.AddSubHeaderLine("TELEFONO: " + drNC["telefono"].ToString());

            ticket.AddSubHeaderLine("DETALLE: " + drNC["NC_Detalle"].ToString());
            ticket.AddTotal("", "");
            ticket.AddTotal("================", "============");


            ticket.AddTotal("MONTO TOTAL:", string.Format("{0:n1}", double.Parse(drNC["NC_Monto"].ToString())));

            ticket.AddTotal("================", "============");
            
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("AUTORIZADO POR:");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("FIRMA:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            

            

            ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            // ticket.AddFooterLine("* = GRAVADO");
            // ticket.AddFooterLine("****I.V.I****");
            ticket.AddFooterLine("GRACIAS POR PREFERIRNOS");
            ticket.AddFooterLine("");
            //  ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio

            // ticket.AddTotal("", ""); //Ponemos un total en blanco que sirve de espacio
            //ticket.AddFooterLine("Autorizado mediante Oficio # 4521000004315 de A.R.T de Alajuela de fecha 28/07/2009");

            ticket.AddMensajeFinal(mensajeEmpresa.ToUpper());

            //Y por ultimo llamamos al metodo PrintTicket para imprimir el ticket, este metodo necesita un
            //parametro de tipo string que debe de ser el nombre de la impresora.

            ticket.PrintTicket(impresora);
            //MessageBox.Show("antes de imprimir");
        }
        //imprimir comandas
        public void ImprimirEgreso(string PrinterName, int Egreso_id)
        {
            Conexion.laConexion.LeerXML();
            //Si la impresora no esta definida, agarra la default
            if (PrinterName.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                PrinterName = laImpresora.PrinterName;
            }

            Ticket ticket = new Ticket();

            ticket.MaxChar -= 3;
            ticket.MaxCharDescription -= 2;


            ticket.AddHeaderLine("** EGRESO DE CAJA **");

            DataRow drResibo = null;
            using (ServicioEgreso elServicio = new ServicioEgreso())
                drResibo = elServicio.ConsultarEgreso(Egreso_id);


            // ticket.AddSubHeaderLine("COMANDA NUMERO : " + Abono_ID.ToString());
            ticket.AddSubHeaderLine("EGRESO NUMERO: " + Egreso_id); //drResibo["NumeroFact"].ToString());
            ticket.AddSubHeaderLine("USUARIO: " + drResibo["usuario_nombre"].ToString());
            ticket.AddSubHeaderLine("FECHA: " + drResibo["Egreso_fecha"].ToString());
            ticket.AddSubHeaderLine("TIPO: " + drResibo["tipo"].ToString());
            ticket.AddSubHeaderLine("DETALLE: " + drResibo["Egreso_nota"].ToString());

            ticket.AddSubHeaderLine("");
            //ticket.AddSubHeaderLine("SALDO TOTAL FACT " + string.Format("{0:n1}", double.Parse(drResibo["MontoFactura"].ToString())).PadLeft(10, ' '));
            ticket.AddSubHeaderLine("MONTO: " + string.Format("{0:n1}", double.Parse(drResibo["Egreso_monto"].ToString())).PadLeft(10, ' '));


            ticket.AddFooterLine("AUTORIZADO POR:");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("FIRMA:__________________________  ");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("  CED:__________________________  ");


            ticket.PrintTicket(PrinterName);
        }
    }
}
