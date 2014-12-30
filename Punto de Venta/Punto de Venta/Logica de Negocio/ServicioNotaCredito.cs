using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioNotaCredito : Servicio, IDisposable
    {
        public ServicioNotaCredito()
        { }
        public void Dispose()
        { }

		//Insertar Nota de credito
        public String InsertarNC(out int NC_Id, int NC_ClienteID, int NC_UsuarioId, double NC_Monto, string NC_Detalle, string NC_Estado)
        {
            miComando.CommandText = "SPR_Tbl_NotaCredito_Insertar";
                        
            NC_Id = 0;
            miComando.Parameters.Add("@NC_Id", SqlDbType.Int);
            miComando.Parameters["@NC_Id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@NC_ClienteID", SqlDbType.Int);
            miComando.Parameters["@NC_ClienteID"].Value = NC_ClienteID;

            miComando.Parameters.Add("@NC_UsuarioId", SqlDbType.Int);
            miComando.Parameters["@NC_UsuarioId"].Value = NC_UsuarioId;

            miComando.Parameters.Add("@NC_Monto", SqlDbType.Money);
            miComando.Parameters["@NC_Monto"].Value = NC_Monto;

            miComando.Parameters.Add("@NC_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@NC_Detalle"].Value = NC_Detalle;

            miComando.Parameters.Add("@NC_Estado", SqlDbType.VarChar);
            miComando.Parameters["@NC_Estado"].Value = NC_Estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                NC_Id = int.Parse(miComando.Parameters["@NC_Id"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Modificar NC
        public String ModificarNC(int NC_Id, int NC_UsuarioId, double NC_Monto,string NC_Detalle,string NC_Estado)
        {
            miComando.CommandText = "SPR_Tbl_NotaCredito_modificar";

            miComando.Parameters.Add("@NC_Id", SqlDbType.Int);
            miComando.Parameters["@NC_Id"].Value = NC_Id;

            miComando.Parameters.Add("@NC_UsuarioId", SqlDbType.Int);
            miComando.Parameters["@NC_UsuarioId"].Value = NC_UsuarioId;

            miComando.Parameters.Add("@NC_Monto", SqlDbType.Money);
            miComando.Parameters["@NC_Monto"].Value = NC_Monto;

            miComando.Parameters.Add("@NC_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@NC_Detalle"].Value = NC_Detalle;

            miComando.Parameters.Add("@NC_Estado", SqlDbType.VarChar);
            miComando.Parameters["@NC_Estado"].Value = NC_Estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  NC
        public DataRow ConsultarNC(int NC_Id)
        {
            miComando.CommandText = "SPR_Tbl_NotaCredito_Consultar";

            miComando.Parameters.Add("@NC_Id", SqlDbType.Int);
            miComando.Parameters["@NC_Id"].Value = NC_Id;
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
        //Listar  cajas
        public DataTable ListarNC(string filtro, string NC_Estado)
        {
            miComando.CommandText = "SPR_Tbl_NotaCredito_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@NC_Estado", SqlDbType.VarChar);
            miComando.Parameters["@NC_Estado"].Value = NC_Estado;

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
