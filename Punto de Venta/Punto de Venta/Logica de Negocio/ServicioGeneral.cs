using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioGeneral:Servicio,IDisposable
    {
        public ServicioGeneral()
        { }
        public void Dispose()
        { }
        //Consultar  datos de la empresa
        public DataRow ConsultarDatosEmpresa()
        {
            miComando.CommandText = "SPR_Tbl_Control_Consultar";

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

        //Fecha del sistema
        public string FechaSistema()
        {
            miComando.CommandText = "SPR_FechaSistema";

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0].Rows[0]["Fecha"].ToString() + " " + miDataSet.Tables[0].Rows[0]["hora"].ToString().Substring(0,5);
            }
            catch
            {
                return null;
            }
        }

        //Respaldar Base datos
        public String RespaldarBaseDatos()
        {
            miComando.CommandText = "SPR_GEN_RespaldoBD";

            miComando.Parameters.Add("@BaseDatos", SqlDbType.VarChar);
            miComando.Parameters["@BaseDatos"].Value = "VIANSA";


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }

    }
}
