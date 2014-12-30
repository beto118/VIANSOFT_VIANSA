
/****************************************************************************
**
** Compania:    Desarrollo Personal
** Sistema:     Sistema de Control de Facturas de Bajo Caliente
** Autor:       Luis Angulo
** Fecha:       03/09/2011
** Componente:  
** Descripcion: Servicio de FactProveedor. 
*****************************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
//using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioFactProveedor : Servicio, IDisposable
    {
        
        public ServicioFactProveedor()
        {
            
        }
        public void Dispose()
        { }

		//Inserta  FactProveedor
        public String InsertarFactProveedor(out int FactProveedor_id,string FactProveedor_numero,string FactProveedor_fecha,string FactProveedor_fechaLimite,double FactProveedor_monto,string FactProveedor_detalle,double FactProveedor_IV,double FactProveedor_descuento,int Proveedor_id)
        {
            miComando.CommandText = "SPR_tbl_FactProveedor_insertar";
            FactProveedor_id = 0;
            
			miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int);
            miComando.Parameters["@FactProveedor_id"].Direction = ParameterDirection.Output;
            
			miComando.Parameters.Add("@FactProveedor_numero", SqlDbType.VarChar).Value = FactProveedor_numero;
            
			miComando.Parameters.Add("@FactProveedor_fecha", SqlDbType.DateTime).Value = FactProveedor_fecha;
            
			miComando.Parameters.Add("@FactProveedor_fechaLimite", SqlDbType.DateTime).Value = FactProveedor_fechaLimite;
            
			miComando.Parameters.Add("@FactProveedor_monto", SqlDbType.Money).Value = FactProveedor_monto;
            
			//miComando.Parameters.Add("@FactProveedor_Saldo", SqlDbType.Money).Value = FactProveedor_Saldo;
            
			miComando.Parameters.Add("@FactProveedor_detalle", SqlDbType.VarChar).Value = FactProveedor_detalle;
            
			miComando.Parameters.Add("@FactProveedor_IV", SqlDbType.Money).Value = FactProveedor_IV;
            
			miComando.Parameters.Add("@FactProveedor_descuento", SqlDbType.Money).Value = FactProveedor_descuento;
            
			miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int).Value = Proveedor_id;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
                FactProveedor_id = int.Parse(miComando.Parameters["@FactProveedor_id"].Value.ToString());
				
            }
            return respuesta;

        }
		//Modificar  FactProveedor
        public String ModificarFactProveedor(int FactProveedor_id, string FactProveedor_numero, string FactProveedor_fecha, string FactProveedor_fechaLimite, double FactProveedor_monto, double FactProveedor_Saldo, string FactProveedor_detalle, double FactProveedor_IV, double FactProveedor_descuento, int Proveedor_id)
        {
            miComando.CommandText = "SPR_tbl_FactProveedor_modificar";

            
			miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;
            
			miComando.Parameters.Add("@FactProveedor_numero", SqlDbType.VarChar).Value = FactProveedor_numero;
            
			miComando.Parameters.Add("@FactProveedor_fecha", SqlDbType.DateTime).Value = FactProveedor_fecha;
            
			miComando.Parameters.Add("@FactProveedor_fechaLimite", SqlDbType.DateTime).Value = FactProveedor_fechaLimite;
            
			miComando.Parameters.Add("@FactProveedor_monto", SqlDbType.Money).Value = FactProveedor_monto;
            
			miComando.Parameters.Add("@FactProveedor_Saldo", SqlDbType.Money).Value = FactProveedor_Saldo;
            
			miComando.Parameters.Add("@FactProveedor_detalle", SqlDbType.VarChar).Value = FactProveedor_detalle;
            
			miComando.Parameters.Add("@FactProveedor_IV", SqlDbType.Money).Value = FactProveedor_IV;
            
			miComando.Parameters.Add("@FactProveedor_descuento", SqlDbType.Money).Value = FactProveedor_descuento;
            
			miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int).Value = Proveedor_id;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Consultar  FactProveedor
        public DataRow ConsultarFactProveedor(int FactProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_FactProveedor_Consultar";

            
			miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;
            
			

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
		//Listar  FactProveedor
        public DataTable ListarFactProveedor(string filtro, int Proveedor_id,int conSaldo)
        {
            miComando.CommandText = "SPR_tbl_FactProveedor_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

            miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int).Value = Proveedor_id;
            
            miComando.Parameters.Add("@consaldo", SqlDbType.Int).Value = conSaldo;
            

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

        //Listar  FactProveedor vencidas
        public DataTable ListarFactProveedorVencidas(string filtro)
        {
            miComando.CommandText = "SPR_tbl_FactProveedor_ListarVencidas";

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

        //PROCESOS DE RELACION PAGO-FACTURA Y REALIZAR PAGO DE FACTURA
        //Realizar pago de Factura
        public String RealizarPagoDeFactura(int FactProveedor_id, Double PagoProveedor_Monto, string PagoProveedor_fecha, string PagoProveedor_detalle, int usuario_codigo)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_Fact_RealizarPago";
          

            miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value= FactProveedor_id;

            miComando.Parameters.Add("@PagoProveedor_Monto", SqlDbType.VarChar).Value = PagoProveedor_Monto;

            miComando.Parameters.Add("@PagoProveedor_fecha", SqlDbType.DateTime).Value = PagoProveedor_fecha;

            miComando.Parameters.Add("@PagoProveedor_detalle", SqlDbType.VarChar).Value = PagoProveedor_detalle;

            miComando.Parameters.Add("@usuario_codigo", SqlDbType.Int).Value = usuario_codigo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;
             
            return respuesta;

        }

        //Listar  Pagos de Factura
        public DataTable ListarPagosDeFactura(int FactProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_Fact_ListarDeFactura";


            miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;


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

        //Listar Factura dwe pago
        public DataTable ListarFacturaDePago(int PagoProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_Fact_ListarDePago";


            miComando.Parameters.Add("@PagoProveedor_id", SqlDbType.Int).Value = PagoProveedor_id;


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
