using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Pantallas.Orden_de_Compra
{
    class ServicioOrdenCompra : Servicio, IDisposable
    {
        public ServicioOrdenCompra()
        { }
        public void Dispose()
        { }

        //Insertar ordenCompra        
        public String RegistarOrdenCompra(out int Orden_ID, int Caja_numero, int Usuario_codigo, int Clie_ID, string Orden_Cliente, string Orden_Clie_Telefono, string Orden_Clie_Direccion, double Orden_descuento, double Orden_TotalDescuento, double Orden_subtotal, double Orden_impuesto, double Orden_total, int TipoPago_id, int Orden_Enviar)
        {
            miComando.CommandText = "SPR_Tbl_OrdenCompra_Insertar";

            Orden_ID = 0;
            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Caja_numero", SqlDbType.Int);
            miComando.Parameters["@Caja_numero"].Value = Caja_numero;

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuario_codigo;

            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@Orden_Cliente", SqlDbType.VarChar);
            miComando.Parameters["@Orden_Cliente"].Value = Orden_Cliente;

            miComando.Parameters.Add("@Orden_Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Orden_Clie_Telefono"].Value = Orden_Clie_Telefono;

            miComando.Parameters.Add("@Orden_Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Orden_Clie_Direccion"].Value = Orden_Clie_Direccion;

            miComando.Parameters.Add("@Orden_subtotal", SqlDbType.Money);
            miComando.Parameters["@Orden_subtotal"].Value = Orden_subtotal;

            miComando.Parameters.Add("@Orden_impuesto", SqlDbType.Money);
            miComando.Parameters["@Orden_impuesto"].Value = Orden_impuesto;

            miComando.Parameters.Add("@Orden_descuento", SqlDbType.Money);
            miComando.Parameters["@Orden_descuento"].Value = Orden_descuento;

            miComando.Parameters.Add("@Orden_TotalDescuento", SqlDbType.Money);
            miComando.Parameters["@Orden_TotalDescuento"].Value = Orden_TotalDescuento;

            miComando.Parameters.Add("@Orden_total", SqlDbType.Money);
            miComando.Parameters["@Orden_total"].Value = Orden_total;

            miComando.Parameters.Add("@TipoPago_id", SqlDbType.Money);
            miComando.Parameters["@TipoPago_id"].Value = TipoPago_id;

            miComando.Parameters.Add("@Orden_Enviar", SqlDbType.Int);
            miComando.Parameters["@Orden_Enviar"].Value = Orden_Enviar;

            
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Orden_ID = int.Parse(miComando.Parameters["@Orden_ID"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }


        //modificar Facturas        
        public String ModificarOrdenCompra(int Orden_ID, int Clie_ID, string Orden_Cliente, string Orden_Clie_Telefono, string Orden_Clie_Direccion, double Orden_descuento, double Orden_TotalDescuento, double Orden_subtotal, double Orden_impuesto, double Orden_total, int Orden_Enviar)
        {
            miComando.CommandText = "SPR_Tbl_OrdenCompra_ModificarTotales";

            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;


            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@Orden_Cliente", SqlDbType.VarChar);
            miComando.Parameters["@Orden_Cliente"].Value = Orden_Cliente;

            miComando.Parameters.Add("@Orden_Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Orden_Clie_Telefono"].Value = Orden_Clie_Telefono;

            miComando.Parameters.Add("@Orden_Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Orden_Clie_Direccion"].Value = Orden_Clie_Direccion;

            miComando.Parameters.Add("@Orden_subtotal", SqlDbType.Money);
            miComando.Parameters["@Orden_subtotal"].Value = Orden_subtotal;

            miComando.Parameters.Add("@Orden_impuesto", SqlDbType.Money);
            miComando.Parameters["@Orden_impuesto"].Value = Orden_impuesto;

            miComando.Parameters.Add("@Orden_descuento", SqlDbType.Money);
            miComando.Parameters["@Orden_descuento"].Value = Orden_descuento;

            miComando.Parameters.Add("@Orden_TotalDescuento", SqlDbType.Money);
            miComando.Parameters["@Orden_TotalDescuento"].Value = Orden_TotalDescuento;

            miComando.Parameters.Add("@Orden_total", SqlDbType.Money);
            miComando.Parameters["@Orden_total"].Value = Orden_total;

            miComando.Parameters.Add("@Orden_Enviar", SqlDbType.Int);
            miComando.Parameters["@Orden_Enviar"].Value = Orden_Enviar;



            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //elimina todas las lineas de una factura
        public String EliminarLineasOrden(int Orden_ID)
        {
            miComando.CommandText = "[SPR_Tbl_LineaOrden_EliminarDeOrden]";


            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }
        //Insertar Lineas                   //Orden_ID ,LinOrden_numero ,LinOrden_prod_codigo,LinOrden_prod_nombre,LinOrden_prod_valorUnitario,LinOrden_prod_cantidad,LinOrden_prod_total,LinOrden_subtotal,LinOrden_impuesto,LinOrden_descuento
        public String RegistarLineaOrdenCompra(int Orden_ID, int LinOrden_prod_codigo, string LinOrden_prod_nombre, double LinOrden_prod_cantidad, double LinOrden_prod_valorUnitario, double LinOrden_prod_total, double LinOrden_subtotal, double LinOrden_impuesto, double LinOrden_descuento,double LinOrden_DescPorcent)
        {
            miComando.CommandText = "SPR_Tbl_LineaOrden_insertar";


            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;

            miComando.Parameters.Add("@LinOrden_prod_codigo", SqlDbType.Int);
            miComando.Parameters["@LinOrden_prod_codigo"].Value = LinOrden_prod_codigo;

            miComando.Parameters.Add("@LinOrden_prod_nombre", SqlDbType.VarChar);
            miComando.Parameters["@LinOrden_prod_nombre"].Value = LinOrden_prod_nombre;

            miComando.Parameters.Add("@LinOrden_prod_cantidad", SqlDbType.Money);
            miComando.Parameters["@LinOrden_prod_cantidad"].Value = LinOrden_prod_cantidad;

            miComando.Parameters.Add("@LinOrden_prod_valorUnitario", SqlDbType.Money);
            miComando.Parameters["@LinOrden_prod_valorUnitario"].Value = LinOrden_prod_valorUnitario;

            miComando.Parameters.Add("@LinOrden_prod_total", SqlDbType.Money);
            miComando.Parameters["@LinOrden_prod_total"].Value = LinOrden_prod_total;

            miComando.Parameters.Add("@LinOrden_subtotal", SqlDbType.Money);
            miComando.Parameters["@LinOrden_subtotal"].Value = LinOrden_subtotal;

            miComando.Parameters.Add("@LinOrden_impuesto", SqlDbType.Money);
            miComando.Parameters["@LinOrden_impuesto"].Value = LinOrden_impuesto;

            miComando.Parameters.Add("@LinOrden_descuento", SqlDbType.Money);
            miComando.Parameters["@LinOrden_descuento"].Value = LinOrden_descuento;

            miComando.Parameters.Add("@LinOrden_DescPorcent", SqlDbType.Money);
            miComando.Parameters["@LinOrden_DescPorcent"].Value = LinOrden_DescPorcent;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;
            
            return respuesta;

        }


        //pagar orden
        public String PagaOrdenCompra(int Orden_ID, double Orden_montoCancela, double Orden_montoCancelaTarjeta, string Orden_TarjetaDetalle, int TipoPago_id)
        {
            miComando.CommandText = "SPR_Tbl_OrdenCompra_Alistar";

            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;

            miComando.Parameters.Add("@Orden_montoCancela", SqlDbType.Money);
            miComando.Parameters["@Orden_montoCancela"].Value = Orden_montoCancela;

            miComando.Parameters.Add("@Orden_montoCancelaTarjeta", SqlDbType.Money);
            miComando.Parameters["@Orden_montoCancelaTarjeta"].Value = Orden_montoCancelaTarjeta;

            miComando.Parameters.Add("@Orden_TarjetaDetalle", SqlDbType.VarChar);
            miComando.Parameters["@Orden_TarjetaDetalle"].Value = Orden_TarjetaDetalle;
            
            miComando.Parameters.Add("@TipoPago_id", SqlDbType.Int);
            miComando.Parameters["@TipoPago_id"].Value = TipoPago_id;

            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }
        
        
        //Consultar  orden compra
        public DataRow ConsultarOrdenCompra(int Orden_ID)
        {
            miComando.CommandText = "SPR_Tbl_OdenCompra_Consultar";

            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;

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


        //Consultar lineas de ORDEN
        public DataTable ConsultarLineaOrden(int Orden_ID)
        {
            miComando.CommandText = "SPR_Tbl_LineaOrden_ConsultarDeFactura";

            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;

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

        //Consultar lineas de ornden compra
        public DataTable ConsultarLineaDGV(int Orden_ID)
        {
            miComando.CommandText = "SPR_Tbl_LineaOrden_ConsultarDeOrdenDGV";

            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;

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
        public DataTable ListarOrdenCompra(string filtro)
        {
            miComando.CommandText = "SPR_OrdenCompra_Listar";

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

        //Modificar Estado de las ordenes actuales.
        public String ModificarEstado(int Orden_ID, string Orden_estado)
        {
            miComando.CommandText = "SPR_Tbl_OrdenCompra_ModificarEstado";


            miComando.Parameters.Add("@Orden_ID", SqlDbType.Int);
            miComando.Parameters["@Orden_ID"].Value = Orden_ID;

            miComando.Parameters.Add("@Orden_estado", SqlDbType.VarChar);
            miComando.Parameters["@Orden_estado"].Value = Orden_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }

        //Modificar Estado del historial de las  ordenes
        public String ModificarEstadoHistorial(int HisOrden_ID, string HisOrden_estado)
        {
            miComando.CommandText = "[SPR_Tbl_HistOrdenCompra_ModificarEstado]";


            miComando.Parameters.Add("@HisOrden_ID", SqlDbType.Int);
            miComando.Parameters["@HisOrden_ID"].Value = HisOrden_ID;

            miComando.Parameters.Add("@HisOrden_estado", SqlDbType.VarChar);
            miComando.Parameters["@HisOrden_estado"].Value = HisOrden_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }


        //Consultar  historial orden compra
        public DataRow ConsultarHistOrdenCompra(int HisOrden_ID)
        {
            miComando.CommandText = "SPR_Tbl_HistOrdenCompra_Consultar";

            miComando.Parameters.Add("@HisOrden_ID", SqlDbType.Int);
            miComando.Parameters["@HisOrden_ID"].Value = HisOrden_ID;

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


        //Consultar historial lineas de orden de compra
        public DataTable ConsultarHistLinea(int HistOrden_ID)
        {
            miComando.CommandText = "[SPR_Tbl_HistLineaOrdenCompra_ConsultarDeFactura]";

            miComando.Parameters.Add("@HistOrden_ID", SqlDbType.Int);
            miComando.Parameters["@HistOrden_ID"].Value = HistOrden_ID;

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
        public DataTable ConsultarHistLineaOrdenCompraDGV(int HistOrden_ID)
        {
            miComando.CommandText = "[SPR_Tbl_HistLineaOrdenCompra_ConsultarDeFacturaDGV]";

            miComando.Parameters.Add("@HistOrden_ID", SqlDbType.Int);
            miComando.Parameters["@HistOrden_ID"].Value = HistOrden_ID;

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
        public DataTable ListarHistOrdenCompra(string filtro, string HisOrden_fecha)
        {
            miComando.CommandText = "[SPR_Tbl_HistOrdenCompra_Listar]";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@HisOrden_fecha", SqlDbType.VarChar);
            miComando.Parameters["@HisOrden_fecha"].Value = HisOrden_fecha;

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

    }
}
