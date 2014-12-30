
/****************************************************************************
**
** Compania:    GRUPO CODESOFT SA
** Sistema:     Sistema de Control de Facturas de Bajo Caliente
** Autor:       Luis Angulo
** Fecha:       11/20/09
** Componente:  
** Descripcion: Servicio de PagoProveedor. 
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
    public class ServicioPagoProveedor : Servicio, IDisposable
    {
        
        public ServicioPagoProveedor()
        {
            
        }
        public void Dispose()
        { }

		//Inserta  PagoProveedor
        public String InsertarPagoProveedor(int Proveedor_id, string PagoProveedor_fecha, double PagoProveedor_Monto, string PagoProveedor_detalle, int usuario_codigo)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_insertar";

            
			miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = Proveedor_id;

            miComando.Parameters.Add("@PagoProveedor_fecha", SqlDbType.DateTime);
            miComando.Parameters["@PagoProveedor_fecha"].Value = PagoProveedor_fecha;

            
			miComando.Parameters.Add("@PagoProveedor_Monto", SqlDbType.Money);
            miComando.Parameters["@PagoProveedor_Monto"].Value = PagoProveedor_Monto;

            miComando.Parameters.Add("@PagoProveedor_detalle", SqlDbType.VarChar);
            miComando.Parameters["@PagoProveedor_detalle"].Value = PagoProveedor_detalle;
            //usuario_codigo
            miComando.Parameters.Add("@usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@usuario_codigo"].Value = usuario_codigo;
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Modificar  PagoProveedor
        public String ModificarPagoProveedor(int PagoProveedor_id,string PagoProveedor_fecha,int Proveedor_id,double PagoProveedor_Monto,string PagoProveedor_detalle,string PagoProveedor_Estado)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_modificar";

            
			miComando.Parameters.Add("@PagoProveedor_id", SqlDbType.Int);
            miComando.Parameters["@PagoProveedor_id"].Value = PagoProveedor_id;
            
			miComando.Parameters.Add("@PagoProveedor_fecha", SqlDbType.DateTime);
            miComando.Parameters["@PagoProveedor_fecha"].Value = PagoProveedor_fecha;
            
			miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = Proveedor_id;
            
			miComando.Parameters.Add("@PagoProveedor_Monto", SqlDbType.Money);
            miComando.Parameters["@PagoProveedor_Monto"].Value = PagoProveedor_Monto;
            
			miComando.Parameters.Add("@PagoProveedor_detalle", SqlDbType.VarChar);
            miComando.Parameters["@PagoProveedor_detalle"].Value = PagoProveedor_detalle;
            
			miComando.Parameters.Add("@PagoProveedor_Estado", SqlDbType.VarChar);
            miComando.Parameters["@PagoProveedor_Estado"].Value = PagoProveedor_Estado;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }


        //Eliminar PagoProveedor
        public String EliminarPagoProveedor(int PagoProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_eliminar";


            miComando.Parameters.Add("@PagoProveedor_id", SqlDbType.Int);
            miComando.Parameters["@PagoProveedor_id"].Value = PagoProveedor_id;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        
        //Consultar  PagoProveedor
        public DataRow ConsultarPagoProveedor(int PagoProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_Consultar";

            
			miComando.Parameters.Add("@PagoProveedor_id", SqlDbType.Int);
            miComando.Parameters["@PagoProveedor_id"].Value = PagoProveedor_id;
            

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
		//Listar  PagoProveedor
        public DataTable ListarPagoProveedor(string filtro, int soloFecha, string PagoProveedor_fecha)
        {
            miComando.CommandText = "SPR_tbl_PagoProveedor_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@soloFecha", SqlDbType.Int);
            miComando.Parameters["@soloFecha"].Value = soloFecha;

            miComando.Parameters.Add("@PagoProveedor_fecha", SqlDbType.DateTime);
            miComando.Parameters["@PagoProveedor_fecha"].Value = PagoProveedor_fecha;
            

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch(Exception e)
            {
                string error = e.Message;
                return null;
            }

        }
    }
}
