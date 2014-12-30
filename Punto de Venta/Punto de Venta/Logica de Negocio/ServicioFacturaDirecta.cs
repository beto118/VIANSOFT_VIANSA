using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    class ServicioFacturaDirecta: Servicio, IDisposable
    {
        public ServicioFacturaDirecta()
        { }
        public void Dispose()
        { }
        //Insertar Facturas DE LA FORMA DIRECTA
        public String RegistarFacturaDIRECTA(out int fact_numero, int Caja_numero, int Usuario_codigo, int Clie_ID, string Fact_Clie_Nombre, string Fact_Clie_Telefono, string Fact_Clie_Direccion, double Fact_descuento, double Fact_totalDescuento, double Fact_subtotal, double Fact_impuesto, double Fact_total, int TipoPago_id, int Fact_Enviar, double Fact_SaldoAnterior, double Fact_Utilidad)
        {
            miComando.CommandText = "[SPR_Tbl_Factura_InsertarDIRECTA]";

            fact_numero = 0;
            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Caja_numero", SqlDbType.Int);
            miComando.Parameters["@Caja_numero"].Value = Caja_numero;

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuario_codigo;

            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@Fact_Clie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Nombre"].Value = Fact_Clie_Nombre;

            miComando.Parameters.Add("@Fact_Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Telefono"].Value = Fact_Clie_Telefono;

            miComando.Parameters.Add("@Fact_Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Direccion"].Value = Fact_Clie_Direccion;

            miComando.Parameters.Add("@Fact_subtotal", SqlDbType.Money);
            miComando.Parameters["@Fact_subtotal"].Value = Fact_subtotal;

            miComando.Parameters.Add("@Fact_impuesto", SqlDbType.Money);
            miComando.Parameters["@Fact_impuesto"].Value = Fact_impuesto;

            miComando.Parameters.Add("@Fact_descuento", SqlDbType.Money);
            miComando.Parameters["@Fact_descuento"].Value = Fact_descuento;

            miComando.Parameters.Add("@Fact_totalDescuento", SqlDbType.Money);
            miComando.Parameters["@Fact_totalDescuento"].Value = Fact_totalDescuento;

            miComando.Parameters.Add("@Fact_total", SqlDbType.Money);
            miComando.Parameters["@Fact_total"].Value = Fact_total;

            miComando.Parameters.Add("@TipoPago_id", SqlDbType.Money);
            miComando.Parameters["@TipoPago_id"].Value = TipoPago_id;

            miComando.Parameters.Add("@Fact_Enviar", SqlDbType.Int);
            miComando.Parameters["@Fact_Enviar"].Value = Fact_Enviar;

            miComando.Parameters.Add("@Fact_SaldoAnterior", SqlDbType.Money);
            miComando.Parameters["@Fact_SaldoAnterior"].Value = Fact_SaldoAnterior;

            //miComando.Parameters.Add("@empresa_id", SqlDbType.Int).Value = empresa_id;

            //miComando.Parameters.Add("@Fact_Servicio", SqlDbType.Int);
            //miComando.Parameters["@Fact_Servicio"].Value = Fact_Servicio;

            miComando.Parameters.Add("@Fact_Utilidad", SqlDbType.Money);
            miComando.Parameters["@Fact_Utilidad"].Value = Fact_Utilidad;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                fact_numero = int.Parse(miComando.Parameters["@fact_numero"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }

        //Insertar Facturas
        public String RegistarFactura(out int fact_numero, int Caja_numero, int Usuario_codigo, int Clie_ID, string Fact_Clie_Nombre, string Fact_Clie_Telefono, string Fact_Clie_Direccion, double Fact_descuento, double Fact_totalDescuento, double Fact_subtotal, double Fact_impuesto, double Fact_total, int TipoPago_id, int Fact_Enviar, double Fact_SaldoAnterior, int empresa_id, int Fact_Servicio,double Fact_Utilidad)
        {
            miComando.CommandText = "SPR_Tbl_Factura_Insertar";

            fact_numero = 0;
            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Caja_numero", SqlDbType.Int);
            miComando.Parameters["@Caja_numero"].Value = Caja_numero;

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuario_codigo;

            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@Fact_Clie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Nombre"].Value = Fact_Clie_Nombre;

            miComando.Parameters.Add("@Fact_Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Telefono"].Value = Fact_Clie_Telefono;

            miComando.Parameters.Add("@Fact_Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Direccion"].Value = Fact_Clie_Direccion;
            
            miComando.Parameters.Add("@Fact_subtotal", SqlDbType.Money);
            miComando.Parameters["@Fact_subtotal"].Value = Fact_subtotal;

            miComando.Parameters.Add("@Fact_impuesto", SqlDbType.Money);
            miComando.Parameters["@Fact_impuesto"].Value = Fact_impuesto;

            miComando.Parameters.Add("@Fact_descuento", SqlDbType.Money);
            miComando.Parameters["@Fact_descuento"].Value = Fact_descuento;

            miComando.Parameters.Add("@Fact_totalDescuento", SqlDbType.Money);
            miComando.Parameters["@Fact_totalDescuento"].Value = Fact_totalDescuento;

            miComando.Parameters.Add("@Fact_total", SqlDbType.Money);
            miComando.Parameters["@Fact_total"].Value = Fact_total;

            miComando.Parameters.Add("@TipoPago_id", SqlDbType.Money);
            miComando.Parameters["@TipoPago_id"].Value = TipoPago_id;

            miComando.Parameters.Add("@Fact_Enviar", SqlDbType.Int);
            miComando.Parameters["@Fact_Enviar"].Value = Fact_Enviar;

            miComando.Parameters.Add("@Fact_SaldoAnterior", SqlDbType.Money);
            miComando.Parameters["@Fact_SaldoAnterior"].Value = Fact_SaldoAnterior;

            miComando.Parameters.Add("@empresa_id", SqlDbType.Int).Value = empresa_id;

            miComando.Parameters.Add("@Fact_Servicio", SqlDbType.Int);
            miComando.Parameters["@Fact_Servicio"].Value = Fact_Servicio;

            miComando.Parameters.Add("@Fact_Utilidad", SqlDbType.Money);
            miComando.Parameters["@Fact_Utilidad"].Value = Fact_Utilidad;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                fact_numero = int.Parse(miComando.Parameters["@fact_numero"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //modificar Facturas de madera directa
        public String ModificarFacturaDIRECTA(int fact_numero, int Clie_ID, int Usuario_codigo, string Fact_Clie_Nombre, string Fact_Clie_Telefono, string Fact_Clie_Direccion, DateTime Fact_fecha, string Fact_estado, double Fact_subtotal, double Fact_descuento, double Fact_totalDescuento, double Fact_impuesto, double Fact_total, int Fact_Enviar, double Fact_Utilidad)
        {
            miComando.CommandText = "SPR_Tbl_Factura_Modificar";

            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuario_codigo;

            miComando.Parameters.Add("@Fact_Clie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Nombre"].Value = Fact_Clie_Nombre;

            miComando.Parameters.Add("@Fact_Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Telefono"].Value = Fact_Clie_Telefono;

            miComando.Parameters.Add("@Fact_Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Direccion"].Value = Fact_Clie_Direccion;

            miComando.Parameters.Add("@Fact_fecha", SqlDbType.DateTime);
            miComando.Parameters["@Fact_fecha"].Value = Fact_fecha;

            miComando.Parameters.Add("@Fact_estado", SqlDbType.VarChar);
            miComando.Parameters["@Fact_estado"].Value = Fact_estado;

            miComando.Parameters.Add("@Fact_subtotal", SqlDbType.Money);
            miComando.Parameters["@Fact_subtotal"].Value = Fact_subtotal;

            miComando.Parameters.Add("@Fact_impuesto", SqlDbType.Money);
            miComando.Parameters["@Fact_impuesto"].Value = Fact_impuesto;

            miComando.Parameters.Add("@Fact_descuento", SqlDbType.Money);
            miComando.Parameters["@Fact_descuento"].Value = Fact_descuento;

            miComando.Parameters.Add("@Fact_totalDescuento", SqlDbType.Money);
            miComando.Parameters["@Fact_totalDescuento"].Value = Fact_totalDescuento;

            miComando.Parameters.Add("@Fact_total", SqlDbType.Money);
            miComando.Parameters["@Fact_total"].Value = Fact_total;

            miComando.Parameters.Add("@Fact_Enviar", SqlDbType.Int);
            miComando.Parameters["@Fact_Enviar"].Value = Fact_Enviar;

            miComando.Parameters.Add("@Fact_Utilidad", SqlDbType.Money);
            miComando.Parameters["@Fact_Utilidad"].Value = Fact_Utilidad;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }

        //modificar Facturasint 
        public String ModificarFactura(int fact_numero, int Clie_ID, int Usuario_codigo, string Fact_Clie_Nombre, string Fact_Clie_Telefono, string Fact_Clie_Direccion, DateTime Fact_fecha, string Fact_estado, double Fact_subtotal, double Fact_ServicioTotal, double Fact_descuento, double Fact_totalDescuento, double Fact_impuesto, double Fact_total, int Fact_Enviar, int Fact_Servicio, double Fact_Utilidad)
        {
            miComando.CommandText = "SPR_Tbl_Factura_Modificar";

            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuario_codigo;

            miComando.Parameters.Add("@Fact_Clie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Nombre"].Value = Fact_Clie_Nombre;

            miComando.Parameters.Add("@Fact_Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Telefono"].Value = Fact_Clie_Telefono;

            miComando.Parameters.Add("@Fact_Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Fact_Clie_Direccion"].Value = Fact_Clie_Direccion;

            miComando.Parameters.Add("@Fact_fecha", SqlDbType.DateTime);
            miComando.Parameters["@Fact_fecha"].Value = Fact_fecha;

            miComando.Parameters.Add("@Fact_estado", SqlDbType.VarChar);
            miComando.Parameters["@Fact_estado"].Value = Fact_estado;

            miComando.Parameters.Add("@Fact_ServicioTotal", SqlDbType.Money);
            miComando.Parameters["@Fact_ServicioTotal"].Value = Fact_ServicioTotal;

            miComando.Parameters.Add("@Fact_subtotal", SqlDbType.Money);
            miComando.Parameters["@Fact_subtotal"].Value = Fact_subtotal;

            miComando.Parameters.Add("@Fact_impuesto", SqlDbType.Money);
            miComando.Parameters["@Fact_impuesto"].Value = Fact_impuesto;

            miComando.Parameters.Add("@Fact_descuento", SqlDbType.Money);
            miComando.Parameters["@Fact_descuento"].Value = Fact_descuento;

            miComando.Parameters.Add("@Fact_totalDescuento", SqlDbType.Money);
            miComando.Parameters["@Fact_totalDescuento"].Value = Fact_totalDescuento;

            miComando.Parameters.Add("@Fact_total", SqlDbType.Money);
            miComando.Parameters["@Fact_total"].Value = Fact_total;

            miComando.Parameters.Add("@Fact_Enviar", SqlDbType.Int);
            miComando.Parameters["@Fact_Enviar"].Value = Fact_Enviar;

            miComando.Parameters.Add("@Fact_Servicio", SqlDbType.Int);
            miComando.Parameters["@Fact_Servicio"].Value = Fact_Servicio;

            miComando.Parameters.Add("@Fact_Utilidad", SqlDbType.Money);
            miComando.Parameters["@Fact_Utilidad"].Value = Fact_Utilidad;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }

        //Insertar Lineas
        public String RegistarLineaFactura(int fact_numero, int LinFact_prod_codigo, string LinFact_prod_nombre, double LinFact_prod_cantidad,double LinFact_prod_valorUnitario,double LinFact_Utilidad)//
        {
            miComando.CommandText = "SPR_Tbl_LineaFactura_insertar";

            
            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@LinFact_prod_codigo", SqlDbType.Int);
            miComando.Parameters["@LinFact_prod_codigo"].Value = LinFact_prod_codigo        ;

            miComando.Parameters.Add("@LinFact_prod_nombre", SqlDbType.VarChar);
            miComando.Parameters["@LinFact_prod_nombre"].Value = LinFact_prod_nombre;

            miComando.Parameters.Add("@LinFact_prod_cantidad", SqlDbType.Money);
            miComando.Parameters["@LinFact_prod_cantidad"].Value = LinFact_prod_cantidad;

            miComando.Parameters.Add("@LinFact_prod_valorUnitario", SqlDbType.Money);
            miComando.Parameters["@LinFact_prod_valorUnitario"].Value = LinFact_prod_valorUnitario;

            miComando.Parameters.Add("@LinFact_Utilidad", SqlDbType.Money);
            miComando.Parameters["@LinFact_Utilidad"].Value = LinFact_Utilidad;

            //miComando.Parameters.Add("@LinFact_subtotal", SqlDbType.Money);
            //miComando.Parameters["@LinFact_subtotal"].Value = LinFact_subtotal;

            //miComando.Parameters.Add("@LinFact_impuesto", SqlDbType.Money);
            //miComando.Parameters["@LinFact_impuesto"].Value = LinFact_impuesto;

            //miComando.Parameters.Add("@LinFact_descuento", SqlDbType.Money);
            //miComando.Parameters["@LinFact_descuento"].Value = LinFact_descuento;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;
            
            return respuesta;

        }
        //Insertar Lineas de la manera directa
        public String RegistarLineaFacturaDirecta(int fact_numero, int LinFact_prod_codigo, string LinFact_prod_nombre, double LinFact_prod_cantidad, double LinFact_prod_valorUnitario, double LinFact_Utilidad, double LinFact_DescPorcent)//
        {
            miComando.CommandText = "SPR_Tbl_LineaFactura_insertarDirecta";


            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@LinFact_prod_codigo", SqlDbType.Int);
            miComando.Parameters["@LinFact_prod_codigo"].Value = LinFact_prod_codigo;

            miComando.Parameters.Add("@LinFact_prod_nombre", SqlDbType.VarChar);
            miComando.Parameters["@LinFact_prod_nombre"].Value = LinFact_prod_nombre;

            miComando.Parameters.Add("@LinFact_prod_cantidad", SqlDbType.Money);
            miComando.Parameters["@LinFact_prod_cantidad"].Value = LinFact_prod_cantidad;

            miComando.Parameters.Add("@LinFact_prod_valorUnitario", SqlDbType.Money);
            miComando.Parameters["@LinFact_prod_valorUnitario"].Value = LinFact_prod_valorUnitario;

            miComando.Parameters.Add("@LinFact_Utilidad", SqlDbType.Money);
            miComando.Parameters["@LinFact_Utilidad"].Value = LinFact_Utilidad;

            //miComando.Parameters.Add("@LinFact_subtotal", SqlDbType.Money);
            //miComando.Parameters["@LinFact_subtotal"].Value = LinFact_subtotal;

            //miComando.Parameters.Add("@LinFact_impuesto", SqlDbType.Money);
            //miComando.Parameters["@LinFact_impuesto"].Value = LinFact_impuesto;

            miComando.Parameters.Add("@LinFact_DescPorcent", SqlDbType.Money);
            miComando.Parameters["@LinFact_DescPorcent"].Value = LinFact_DescPorcent;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }
        //elimina todas las lineas de una factura
        public String EliminarLineasFactura(int fact_numero)
        {
            miComando.CommandText = "SPR_Tbl_LineaFactura_EliminarDeFactura";


            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }


        //Insertar Lineas
        public String PagarFactura(int fact_numero, double Fact_montoCancela, double Fact_montoCancelaTarjeta, string Fact_TarjetaDetalle, double Fact_montoCredito,double Fact_Abono, double Fact_Saldo,int TipoPago_id)
        {
            miComando.CommandText = "SPR_Tbl_Factura_Pagar";


            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@Fact_montoCancela", SqlDbType.Money);
            miComando.Parameters["@Fact_montoCancela"].Value = Fact_montoCancela;

            miComando.Parameters.Add("@Fact_montoCancelaTarjeta", SqlDbType.Money);
            miComando.Parameters["@Fact_montoCancelaTarjeta"].Value = Fact_montoCancelaTarjeta;

            miComando.Parameters.Add("@Fact_TarjetaDetalle", SqlDbType.VarChar);
            miComando.Parameters["@Fact_TarjetaDetalle"].Value = Fact_TarjetaDetalle;

            miComando.Parameters.Add("@Fact_montoCredito", SqlDbType.Money);
            miComando.Parameters["@Fact_montoCredito"].Value = Fact_montoCredito;

            miComando.Parameters.Add("@Fact_Saldo", SqlDbType.Money);
            miComando.Parameters["@Fact_Saldo"].Value = Fact_Saldo;

            miComando.Parameters.Add("@Fact_Abono", SqlDbType.Money);
            miComando.Parameters["@Fact_Abono"].Value = Fact_Abono;


            
            miComando.Parameters.Add("@TipoPago_id", SqlDbType.Int);
            miComando.Parameters["@TipoPago_id"].Value = TipoPago_id;

            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }
        //Facturar a credito
        public String FacturarCredito(int fact_numero, double Fact_montoCancela, double Fact_montoCancelaTarjeta, string Fact_TarjetaDetalle, double Fact_montoCredito, double Fact_Abono, double Fact_Saldo, int TipoPago_id,DateTime Fact_FechaLimite)
        {
            miComando.CommandText = "SPR_Tbl_FacturarCredito";


            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@Fact_montoCancela", SqlDbType.Money);
            miComando.Parameters["@Fact_montoCancela"].Value = Fact_montoCancela;

            miComando.Parameters.Add("@Fact_montoCancelaTarjeta", SqlDbType.Money);
            miComando.Parameters["@Fact_montoCancelaTarjeta"].Value = Fact_montoCancelaTarjeta;

            miComando.Parameters.Add("@Fact_TarjetaDetalle", SqlDbType.VarChar);
            miComando.Parameters["@Fact_TarjetaDetalle"].Value = Fact_TarjetaDetalle;

            miComando.Parameters.Add("@Fact_montoCredito", SqlDbType.Money);
            miComando.Parameters["@Fact_montoCredito"].Value = Fact_montoCredito;

            miComando.Parameters.Add("@Fact_Abono", SqlDbType.Money);
            miComando.Parameters["@Fact_Abono"].Value = Fact_Abono;

            miComando.Parameters.Add("@Fact_Saldo", SqlDbType.Money);
            miComando.Parameters["@Fact_Saldo"].Value = Fact_Saldo;

            miComando.Parameters.Add("@TipoPago_id", SqlDbType.Int);
            miComando.Parameters["@TipoPago_id"].Value = TipoPago_id;

            miComando.Parameters.Add("@Fact_FechaLimite", SqlDbType.Date);
            miComando.Parameters["@Fact_FechaLimite"].Value = Fact_FechaLimite;
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }
        //Consultar  Factura
        public DataRow ConsultarFactura(int fact_numero)
        {
            miComando.CommandText = "SPR_Tbl_Factura_Consultar";

            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0].Rows[0];
            }
            catch
            {
                return null;
            }
        }


        //Consultar lineas de Factura
        public DataTable ConsultarLinea(int fact_numero)
        {
            miComando.CommandText = "SPR_Tbl_LineaFactura_ConsultarDeFactura";

            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        //Consultar lineas de Factura
        public DataTable ConsultarLineaDGV(int fact_numero)
        {
            miComando.CommandText = "SPR_Tbl_LineaFactura_ConsultarDeFacturaDGV";

            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }


        //Listar las Facturas
        public DataTable ListarFacturas(string filtro)
        {
            miComando.CommandText = "SPR_Tbl_Factura_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        public DataTable ListarFacturasBotones(string filtro)
        {
            miComando.CommandText = "SPR_Tbl_Factura_ListarEnBotones";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        //Modificar Estado de las facturas actuales.
        public String ModificarEstado(int fact_numero,string fact_estado)
        {
            miComando.CommandText = "SPR_Tbl_Factura_ModificarEstado";


            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            miComando.Parameters.Add("@fact_estado", SqlDbType.VarChar);
            miComando.Parameters["@fact_estado"].Value = fact_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }

        //Modificar Estado del historial de las  facturas
        public String ModificarEstadoHistorial(int @HistFact_numero, string @HistFact_estado)
        {
            miComando.CommandText = "SPR_Tbl_HistFact_ModificarEstado";


            miComando.Parameters.Add("@HistFact_numero", SqlDbType.Int);
            miComando.Parameters["@HistFact_numero"].Value = @HistFact_numero;

            miComando.Parameters.Add("@HistFact_estado", SqlDbType.VarChar);
            miComando.Parameters["@HistFact_estado"].Value = @HistFact_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }


        //Consultar  historial Factura
        public DataRow ConsultarHistFactura(int histfact_numero)
        {
            miComando.CommandText = "SPR_Tbl_HistFactura_Consultar";

            miComando.Parameters.Add("@histfact_numero", SqlDbType.Int);
            miComando.Parameters["@histfact_numero"].Value = histfact_numero;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0].Rows[0];
            }
            catch
            {
                return null;
            }
        }


        //Consultar historial lineas de Factura
        public DataTable ConsultarHistLinea(int HistFact_numero)
        {
            miComando.CommandText = "SPR_Tbl_HistLineaFactura_ConsultarDeFactura";

            miComando.Parameters.Add("@HistFact_numero", SqlDbType.Int);
            miComando.Parameters["@HistFact_numero"].Value = HistFact_numero;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        //Consultar historial lineas de Factura
        public DataTable ConsultarHistLineaDGV(int HistFact_numero)
        {
            miComando.CommandText = "SPR_Tbl_HistLineaFactura_ConsultarDeFacturaDGV";

            miComando.Parameters.Add("@HistFact_numero", SqlDbType.Int);
            miComando.Parameters["@HistFact_numero"].Value = HistFact_numero;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }


        //Listar el historial de Facturas
        public DataTable ListarHistFacturas(string filtro,string HistFact_fecha)
        {
            miComando.CommandText = "SPR_Tbl_histFactura_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@HistFact_fecha", SqlDbType.VarChar);
            miComando.Parameters["@HistFact_fecha"].Value = HistFact_fecha;

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }
        }

        //Listar  facturas a credito vencidas
        public DataTable ListarFactCredVencidas(string filtro)
        {
            miComando.CommandText = "SPR_tbl_FacturasCred_ListarVencidas";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;


            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }

        }

        //PROCESOS DE RELACION Abono-FACTURA Y REALIZAR PAGO DE FACTURA
        //Realizar Abono de Factura
        public String RealizarAbonoDeFactura(out int abono_ID,int Fact_numero,double SaldoAnterior, double abono_Monto, double SaldoActual, string abono_Fecha, string abono_Detalle, int Usuario_ID)
        {
            miComando.CommandText = "SPR_tbl_Abono_Fact_RealizarPago";
            abono_ID = 0;
            miComando.Parameters.Add("@abono_ID", SqlDbType.Int).Direction = ParameterDirection.Output;
            miComando.Parameters.Add("@Fact_numero", SqlDbType.Int).Value = Fact_numero;

            miComando.Parameters.Add("@SaldoAnterior", SqlDbType.VarChar).Value = SaldoAnterior;

            miComando.Parameters.Add("@abono_Monto", SqlDbType.VarChar).Value = abono_Monto;

            miComando.Parameters.Add("@SaldoActual", SqlDbType.VarChar).Value = SaldoActual;

            miComando.Parameters.Add("@abono_Fecha", SqlDbType.DateTime).Value = abono_Fecha;

            miComando.Parameters.Add("@abono_Detalle", SqlDbType.VarChar).Value = abono_Detalle;

            miComando.Parameters.Add("@Usuario_ID", SqlDbType.Int).Value = Usuario_ID;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
                abono_ID = int.Parse(miComando.Parameters["@abono_ID"].Value.ToString());
            }

            return respuesta;

        }

        //PROCESOS DE RELACION Abono-FACTURA Y REALIZAR PAGO DE FACTURA del historial
        //Realizar Abono de HistorialFactura
        public String RealizarAbonoDeHistFactura(out int abono_ID,int HistFact_numero, double SaldoAnterior, double abono_Monto, double SaldoActual, string abono_Fecha, string abono_Detalle, int Usuario_ID)
        {
            miComando.CommandText = "SPR_tbl_Abono_HistFact_RealizarPago";

            abono_ID = 0;
            miComando.Parameters.Add("@abono_ID", SqlDbType.Int).Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@HistFact_numero", SqlDbType.Int).Value = HistFact_numero;

            miComando.Parameters.Add("@SaldoAnterior", SqlDbType.Money).Value = SaldoAnterior;

            miComando.Parameters.Add("@abono_Monto", SqlDbType.Money).Value = abono_Monto;

            miComando.Parameters.Add("@SaldoActual", SqlDbType.Money).Value = SaldoActual;

            miComando.Parameters.Add("@abono_Fecha", SqlDbType.DateTime).Value = abono_Fecha;

            miComando.Parameters.Add("@abono_Detalle", SqlDbType.VarChar).Value = abono_Detalle;

            miComando.Parameters.Add("@Usuario_ID", SqlDbType.Int).Value = Usuario_ID;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
                abono_ID = int.Parse(miComando.Parameters["@abono_ID"].Value.ToString());
            }

            return respuesta;

        }

        //Listar  Factura cred por cliente de hoy 
        public DataTable ListarFactCliente(string filtro, int Clie_ID, int ConSaldo)
        {
            miComando.CommandText = "SPR_tbl_Facturas_ListarCredito";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int).Value = Clie_ID;

            miComando.Parameters.Add("@ConSaldo", SqlDbType.Int).Value = ConSaldo;


            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }

        }

        //Listar  Factura cred por cliente del historial 
        public DataTable ListarFactClienteHistorial(string filtro, int Clie_ID, int ConSaldo)
        {
            miComando.CommandText = "SPR_tbl_Facturas_ListarCreditoHistorial";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int).Value = Clie_ID;

            miComando.Parameters.Add("@ConSaldo", SqlDbType.Int).Value = ConSaldo;


            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }

        }
        //Listar  Factura cred por cliente del historial 
        public DataTable ListarFacthistXcliente(string filtro, int Clie_ID, int ConSaldo)
        {
            miComando.CommandText = "SPR_tbl_HistFact_ListarXCliente";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int).Value = Clie_ID;

            miComando.Parameters.Add("@ConSaldo", SqlDbType.Int).Value = ConSaldo;


            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }

        }

        //Listar  Pagos de Factura
        public DataTable ListarPagosDeFactura(int FactNumero)
        {
            miComando.CommandText = "SPR_tbl_Abono_Fact_ListarDeFactura";


            miComando.Parameters.Add("@Fact_numero", SqlDbType.Int).Value = FactNumero;


            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch
            {
                return null;
            }

        }
        //cancelar facturas
        public String CancelarFacturas(int fact_numero)
        {
            miComando.CommandText = "SPR_tbl_HistFactura_CancelarFacturas";

            miComando.Parameters.Add("@HistFact_numero", SqlDbType.Int);
            miComando.Parameters["@HistFact_numero"].Value = fact_numero;
                      
        
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //actualizar los totales de la factura/ suma las lineas 
        public String ActualizarTotales(int fact_numero)
        {
            miComando.CommandText = "SPR_Tbl_Factura_ActualizarTotales";

            miComando.Parameters.Add("@fact_numero", SqlDbType.Int);
            miComando.Parameters["@fact_numero"].Value = fact_numero;

            try
            {
                respuesta = this.ejecutaSentencia(miComando);
                if (respuesta == "")
                {
                    respuesta = respuestaCorrecta;
                }
                return respuesta;
            }
            catch
            {
                return null;
            }
        }

    }
}
