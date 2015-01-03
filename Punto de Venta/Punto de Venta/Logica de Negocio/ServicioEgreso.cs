
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Componentes.Sistemas.Clases;
//using System.Linq;
using System.Text;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioEgreso : Servicio, IDisposable
    {
        
        public ServicioEgreso()
        {
            
        }
        public void Dispose()
        { }

		//Inserta  Egreso
        public String InsertarEgreso(out int Egreso_id, int EgresoTipo_id, double Egreso_monto, string Egreso_nota, int usuario_codigo)
        {
            miComando.CommandText = "SPR_Tbl_Egreso_insertar";

            Egreso_id = 0;
            miComando.Parameters.Add("@Egreso_id", SqlDbType.Int);
            miComando.Parameters["@Egreso_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@EgresoTipo_id", SqlDbType.Int).Value = EgresoTipo_id;
            
			miComando.Parameters.Add("@Egreso_monto", SqlDbType.Money).Value = Egreso_monto;
            
			miComando.Parameters.Add("@Egreso_nota", SqlDbType.VarChar).Value = Egreso_nota;
            
			miComando.Parameters.Add("@usuario_codigo", SqlDbType.Int).Value = usuario_codigo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Egreso_id = int.Parse(miComando.Parameters["@Egreso_id"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;


        }
		//Modificar  Egreso
        public String ModificarEgreso(int Egreso_id, int EgresoTipo_id, double Egreso_monto, string Egreso_nota, int usuario_codigo, string Egreso_estado)
        {
            miComando.CommandText = "SPR_Tbl_Egreso_modificar";

            
			miComando.Parameters.Add("@Egreso_id", SqlDbType.Int).Value = Egreso_id;

            miComando.Parameters.Add("@EgresoTipo_id", SqlDbType.Int).Value = EgresoTipo_id;
            
			miComando.Parameters.Add("@Egreso_monto", SqlDbType.Money).Value = Egreso_monto;
            
			miComando.Parameters.Add("@Egreso_nota", SqlDbType.VarChar).Value = Egreso_nota;
            
			miComando.Parameters.Add("@usuario_codigo", SqlDbType.Int).Value = usuario_codigo;
            
			miComando.Parameters.Add("@Egreso_estado", SqlDbType.VarChar).Value = Egreso_estado;
            
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Inserta  Egreso automatico
        public String InsertarEgresoAutomatico(int EgresoTipo_id, double Egreso_monto, string Egreso_nota, int usuario_codigo)
        {
            miComando.CommandText = "[SPR_Tbl_Egreso_insertar_AUTOMATICO]";

            //miComando.Parameters.Add("@Egreso_id", SqlDbType.Int);
            //miComando.Parameters["@Egreso_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@EgresoTipo_id", SqlDbType.Int).Value = EgresoTipo_id;

            miComando.Parameters.Add("@Egreso_monto", SqlDbType.Money).Value = Egreso_monto;

            miComando.Parameters.Add("@Egreso_nota", SqlDbType.VarChar).Value = Egreso_nota;

            miComando.Parameters.Add("@usuario_codigo", SqlDbType.Int).Value = usuario_codigo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
               // Egreso_id = int.Parse(miComando.Parameters["@Egreso_id"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;


        }
		//Consultar  Egreso
        public DataRow ConsultarEgreso(int Egreso_id)
        {
            miComando.CommandText = "SPR_Tbl_Egreso_Consultar";

            
			miComando.Parameters.Add("@Egreso_id", SqlDbType.Int).Value = Egreso_id;

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
		//Listar  Egreso
        public DataTable ListarEgreso(string filtro,int DelCierre)
        {
            miComando.CommandText = "SPR_Tbl_Egreso_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar).Value = filtro;

            miComando.Parameters.Add("@delCierre", SqlDbType.Int).Value = DelCierre;
            
            

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
        //Listar  Egreso
        public DataTable ListarEgresoDeCierre(int vent_id)
        {
            miComando.CommandText = "[SPR_Tbl_Egreso_Listar_deCierre]";

            miComando.Parameters.Add("@vent_id", SqlDbType.VarChar).Value = vent_id;

        
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

        //Listar  Egreso
        public DataTable CampoEmpresa()
        {
            miComando.CommandText = "SPR_Tbl_Egreso_ListarCampo_Empresa";

           

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
