
/****************************************************************************
**
** Compania:    GRUPO CODESOFT SA
** Sistema:     Sistema de Control de Facturas de Bajo Caliente
** Autor:       Luis Angulo
** Fecha:       11/20/09
** Componente:  
** Descripcion: Servicio de Proveedor. 
*****************************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
//using System.Linq;//
using System.Text;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioProveedor : Servicio, IDisposable
    {
        
        public ServicioProveedor()
        {
            
        }
        public void Dispose()
        { }

		//Inserta  Proveedor
        public String InsertarProveedor(string Proveedor_nombre,string Proveedor_representante,string Proveedor_tel1,string Proveedor_tel2,string Proveedor_Lugar,string Proveedor_diaPasa,string Proveedor_Detalle)
        {
            miComando.CommandText = "SPR_tbl_Proveedor_insertar";

            
			miComando.Parameters.Add("@Proveedor_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_nombre"].Value = Proveedor_nombre;
            
			miComando.Parameters.Add("@Proveedor_representante", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_representante"].Value = Proveedor_representante;
            
			miComando.Parameters.Add("@Proveedor_tel1", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_tel1"].Value = Proveedor_tel1;
            
			miComando.Parameters.Add("@Proveedor_tel2", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_tel2"].Value = Proveedor_tel2;
            
			miComando.Parameters.Add("@Proveedor_Lugar", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_Lugar"].Value = Proveedor_Lugar;
            
			miComando.Parameters.Add("@Proveedor_diaPasa", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_diaPasa"].Value = Proveedor_diaPasa;
            
			miComando.Parameters.Add("@Proveedor_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_Detalle"].Value = Proveedor_Detalle;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Modificar  Proveedor
        public String ModificarProveedor(int Proveedor_id,string Proveedor_nombre,string Proveedor_representante,string Proveedor_tel1,string Proveedor_tel2,string Proveedor_Lugar,string Proveedor_diaPasa,string Proveedor_Detalle)
        {
            miComando.CommandText = "SPR_tbl_Proveedor_modificar";

            
			miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = Proveedor_id;
            
			miComando.Parameters.Add("@Proveedor_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_nombre"].Value = Proveedor_nombre;
            
			miComando.Parameters.Add("@Proveedor_representante", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_representante"].Value = Proveedor_representante;
            
			miComando.Parameters.Add("@Proveedor_tel1", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_tel1"].Value = Proveedor_tel1;
            
			miComando.Parameters.Add("@Proveedor_tel2", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_tel2"].Value = Proveedor_tel2;
            
			miComando.Parameters.Add("@Proveedor_Lugar", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_Lugar"].Value = Proveedor_Lugar;
            
			miComando.Parameters.Add("@Proveedor_diaPasa", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_diaPasa"].Value = Proveedor_diaPasa;
            
			miComando.Parameters.Add("@Proveedor_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@Proveedor_Detalle"].Value = Proveedor_Detalle;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Consultar  Proveedor
        public DataRow ConsultarProveedor(int Proveedor_id)
        {
            miComando.CommandText = "SPR_tbl_Proveedor_Consultar";

            
			miComando.Parameters.Add("@Proveedor_id", SqlDbType.Int);
            miComando.Parameters["@Proveedor_id"].Value = Proveedor_id;
            

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
		//Listar  Proveedor
        public DataTable ListarProveedor(string filtro)
        {
            miComando.CommandText = "SPR_tbl_Proveedor_Listar";

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
    }
}
