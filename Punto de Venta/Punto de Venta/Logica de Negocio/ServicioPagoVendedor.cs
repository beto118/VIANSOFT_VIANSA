using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioPagoVendedor : Servicio, IDisposable
    {
        public ServicioPagoVendedor()
        { }
        public void Dispose()
        { }
        //REGISTRAR UN PAGO A UN VENDEDOR
        public String RegistrarPagoVendedor(int Vendedor_id, string PagoVendedor_Detalle, out string Respuesta)
        {
            miComando.CommandText = "SPR_Tbl_PagoVendedor_RealizarPago";

            Respuesta = "";
            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;

            miComando.Parameters.Add("@PagoVendedor_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@PagoVendedor_Detalle"].Value = PagoVendedor_Detalle;

            miComando.Parameters.Add("@Respuesta", SqlDbType.VarChar, 5000);
            miComando.Parameters["@Respuesta"].Direction = ParameterDirection.Output;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Respuesta = miComando.Parameters["@Respuesta"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        public DataTable ListarPagosVendedor(int Vendedor_id)
        {
            miComando.CommandText = "SPR_Tbl_PagoVendedor_Listar";

            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;


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
        //Consultar  pago vendedor
        public DataRow ConsultarPagoVendedor(int PagoVendedor_id)
        {
            miComando.CommandText = "SPR_Tbl_PagoVendedor_Consultar";

            miComando.Parameters.Add("@PagoVendedor_id", SqlDbType.Int);
            miComando.Parameters["@PagoVendedor_id"].Value = PagoVendedor_id;
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
