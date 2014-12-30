
/****************************************************************************
**
** Compania:    Desarrollo Personal
** Sistema:     Sistema de Control de Facturas de Bajo Caliente
** Autor:       Luis Angulo
** Fecha:       15/09/2011
** Componente:  
** Descripcion: Servicio de ProveedorNC. 
*****************************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Componentes.Sistemas.Clases;
//using System.Linq;
using System.Text;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioProveedorNC : Servicio, IDisposable
    {
        
        public ServicioProveedorNC()
        {
            
        }
        public void Dispose()
        { }

		//Inserta  ProveedorNC
        public String InsertarProveedorNC(int FactProveedor_id,string ProveedorNC_fecha,double ProveedorNC_monto,string ProveedorNC_detalle,int usuario_codigo)
        {
            miComando.CommandText = "SPR_tbl_ProveedorNC_insertar";

            
			miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;
            
			miComando.Parameters.Add("@ProveedorNC_fecha", SqlDbType.DateTime).Value = ProveedorNC_fecha;
            
			miComando.Parameters.Add("@ProveedorNC_monto", SqlDbType.Money).Value = ProveedorNC_monto;
            
			miComando.Parameters.Add("@ProveedorNC_detalle", SqlDbType.VarChar).Value = ProveedorNC_detalle;
            
			miComando.Parameters.Add("@usuario_codigo", SqlDbType.Int).Value = usuario_codigo;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Modificar  ProveedorNC
        public String ModificarProveedorNC(int ProveedorNC_id,string ProveedorNC_fecha,double ProveedorNC_monto,string ProveedorNC_detalle)
        {
            miComando.CommandText = "SPR_tbl_ProveedorNC_modificar";

            
			miComando.Parameters.Add("@ProveedorNC_id", SqlDbType.Int).Value = ProveedorNC_id;
            
			miComando.Parameters.Add("@ProveedorNC_fecha", SqlDbType.DateTime).Value = ProveedorNC_fecha;
            
			miComando.Parameters.Add("@ProveedorNC_monto", SqlDbType.Money).Value = ProveedorNC_monto;
            
			miComando.Parameters.Add("@ProveedorNC_detalle", SqlDbType.VarChar).Value = ProveedorNC_detalle;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Eliminar  ProveedorNC
        public String EliminarProveedorNC(int ProveedorNC_id)
        {
            miComando.CommandText = "SPR_tbl_ProveedorNC_Eliminar";

            
			miComando.Parameters.Add("@ProveedorNC_id", SqlDbType.Int).Value = ProveedorNC_id;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Consultar  ProveedorNC
        public DataRow ConsultarProveedorNC(int ProveedorNC_id)
        {
            miComando.CommandText = "SPR_tbl_ProveedorNC_Consultar";

            
			miComando.Parameters.Add("@ProveedorNC_id", SqlDbType.Int).Value = ProveedorNC_id;
            
			

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
		//Listar  ProveedorNC
        public DataTable ListarProveedorNC(int FactProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_ProveedorNC_Listar";

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
    }
}
