using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    class ServicioControl : Servicio, IDisposable
    {
        public ServicioControl()
        { }
        public void Dispose()
        { }
        //Insertar Control
        public String InsertarControl(string Control_NombreEmpresa, string Control_Propietario, string Control_Cedula, string Control_telefono, string Control_Direccion, string Control_Mensaje, string Control_TipoCambio)
        {
            miComando.CommandText = "SPR_Tbl_Control_insertar";

            miComando.Parameters.Add("@Control_NombreEmpresa", SqlDbType.VarChar);
            miComando.Parameters["@Control_NombreEmpresa"].Value = Control_NombreEmpresa;

            miComando.Parameters.Add("@Control_Propietario", SqlDbType.VarChar);
            miComando.Parameters["@Control_Propietario"].Value = Control_Propietario;

            miComando.Parameters.Add("@Control_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Control_Cedula"].Value = Control_Cedula;

            miComando.Parameters.Add("@Control_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Control_telefono"].Value = Control_telefono;

            miComando.Parameters.Add("@Control_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Control_Direccion"].Value = Control_Direccion;

            miComando.Parameters.Add("@Control_Mensaje", SqlDbType.VarChar);
            miComando.Parameters["@Control_Mensaje"].Value = Control_Mensaje;

            miComando.Parameters.Add("@Control_TipoCambio", SqlDbType.VarChar);
            miComando.Parameters["@Control_TipoCambio"].Value = Control_TipoCambio;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Control_NombreEmpresa = miComando.Parameters["@Control_NombreEmpresa"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }
        //Modificar usuarios
        public String ModificarControl(string Control_NombreEmpresa, string Control_Propietario, string Control_Cedula, string Control_telefono, string Control_Direccion, string Control_Mensaje, double Control_TipoCambio)
        {
            miComando.CommandText = "SPR_Tbl_Control_modificar";

            miComando.Parameters.Add("@Control_NombreEmpresa", SqlDbType.VarChar);
            miComando.Parameters["@Control_NombreEmpresa"].Value = Control_NombreEmpresa;

            miComando.Parameters.Add("@Control_Propietario", SqlDbType.VarChar);
            miComando.Parameters["@Control_Propietario"].Value = Control_Propietario;

            miComando.Parameters.Add("@Control_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Control_Cedula"].Value = Control_Cedula;

            miComando.Parameters.Add("@Control_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Control_telefono"].Value = Control_telefono;

            miComando.Parameters.Add("@Control_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Control_Direccion"].Value = Control_Direccion;

            miComando.Parameters.Add("@Control_Mensaje", SqlDbType.VarChar);
            miComando.Parameters["@Control_Mensaje"].Value = Control_Mensaje;

            miComando.Parameters.Add("@Control_TipoCambio", SqlDbType.Money);
            miComando.Parameters["@Control_TipoCambio"].Value = Control_TipoCambio;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Control_NombreEmpresa = miComando.Parameters["@Control_NombreEmpresa"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }
        
        
        //Consultar  Control
        public DataRow ConsultarControl()
        {
            miComando.CommandText = "SPR_Tbl_Control_Consultar";

            //miComando.Parameters.Add("@Control_NombreEmpresa", SqlDbType.VarChar);
            //miComando.Parameters["@Control_NombreEmpresa"].Value = Control_NombreEmpresa;
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

    }
}
