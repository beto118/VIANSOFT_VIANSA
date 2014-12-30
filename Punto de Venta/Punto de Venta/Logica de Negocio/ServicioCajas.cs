using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioCajas : Servicio, IDisposable
    {
        public ServicioCajas()
        { }
        public void Dispose()
        { }

		//Insertar Cajas
        public String RegistarCajas(out int Caja_numero, string Caja_detalle, string Caja_estado)
        {
            miComando.CommandText = "SPR_Tbl_Cajas_insertar";
                        
            Caja_numero = 0;
            miComando.Parameters.Add("@Cajas_numero", SqlDbType.Int);
            miComando.Parameters["@Cajas_numero"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Cajas_detalle", SqlDbType.VarChar);
            miComando.Parameters["@Cajas_detalle"].Value = Caja_detalle;

            miComando.Parameters.Add("@Cajas_estado", SqlDbType.VarChar);
            miComando.Parameters["@Cajas_estado"].Value = Caja_estado;
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Caja_numero = int.Parse(miComando.Parameters["@Cajas_numero"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Modificar Cajas
        public String ModificarCajas(int Caja_numero, string Caja_detalle, string Caja_estado)
        {
            miComando.CommandText = "SPR_Tbl_Cajas_modificar";

            miComando.Parameters.Add("@Cajas_numero", SqlDbType.Int);
            miComando.Parameters["@Cajas_numero"].Value = Caja_numero;

            miComando.Parameters.Add("@Cajas_detalle", SqlDbType.VarChar);
            miComando.Parameters["@Cajas_detalle"].Value = Caja_detalle;

            miComando.Parameters.Add("@Cajas_estado", SqlDbType.VarChar);
            miComando.Parameters["@Cajas_estado"].Value = Caja_estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Modificar los montos de las Cajas
        public String ModificarMontosCajas(int Caja_numero, double Caja_MontoApertura, double Caja_MontoCierre)
        {
            miComando.CommandText = "SPR_Tbl_Cajas_modificarMontos";

            miComando.Parameters.Add("@Caja_numero", SqlDbType.Int);
            miComando.Parameters["@Caja_numero"].Value = Caja_numero;

            miComando.Parameters.Add("@Caja_MontoApertura", SqlDbType.Money);
            miComando.Parameters["@Caja_MontoApertura"].Value = Caja_MontoApertura;

            miComando.Parameters.Add("@Caja_MontoCierre", SqlDbType.Money);
            miComando.Parameters["@Caja_MontoCierre"].Value = Caja_MontoCierre;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  cajas
        public DataRow ConsultarCajas(int Caja_estado)
        {
            miComando.CommandText = "SPR_Tbl_Cajas_Consultar";

            miComando.Parameters.Add("@Cajas_numero", SqlDbType.Int);
            miComando.Parameters["@Cajas_numero"].Value = Caja_estado;
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
        public DataTable ListarCajas(string filtro, string Caja_estado)
        {
            miComando.CommandText = "SPR_Tbl_Cajas_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@Cajas_estado", SqlDbType.VarChar);
            miComando.Parameters["@Cajas_estado"].Value = Caja_estado;

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
