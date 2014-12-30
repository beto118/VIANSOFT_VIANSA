using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioCierreCaja : Servicio, IDisposable
    {

        public ServicioCierreCaja()
        { }
        public void Dispose()
        { }

        //Realizar Cierre Caja
        public String RealizarCierre(out int Vent_id, out string LasCajas)
        {
            miComando.CommandText = "SPR_Tbl_TotalVentas_RealizarCierre";

            Vent_id = 0;
            LasCajas = "";
            miComando.Parameters.Add("@Vent_id", SqlDbType.Int);
            miComando.Parameters["@Vent_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@LasCajas", SqlDbType.VarChar, 200);
            miComando.Parameters["@LasCajas"].Direction = ParameterDirection.Output;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Vent_id = int.Parse(miComando.Parameters["@Vent_id"].Value.ToString());
                LasCajas = miComando.Parameters["@LasCajas"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Realizar finalizacion de ordenes
        public String RealizarFinalizacionOrdenes(out int Ordenes_id, out string LasCajas)
        {
            miComando.CommandText = "SPR_Tbl_TotalOrdenes_Finalizar";

            Ordenes_id = 0;
            LasCajas = "";
            miComando.Parameters.Add("@Ordenes_id", SqlDbType.Int);
            miComando.Parameters["@Ordenes_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@LasCajas", SqlDbType.VarChar, 200);
            miComando.Parameters["@LasCajas"].Direction = ParameterDirection.Output;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Ordenes_id = int.Parse(miComando.Parameters["@Ordenes_id"].Value.ToString());
                LasCajas = miComando.Parameters["@LasCajas"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }

        //Realizar Cierre de una Caja
        public String RealizarCierreDeUnaCaja(out int respuestaInt, int Caja_numero, double Caja_Apertura)
        {
            miComando.CommandText = "SPR_Tbl_TotalVentas_RealizarCierre_DeUnaCaja";

            respuestaInt = 0;
            miComando.Parameters.Add("@respuesta", SqlDbType.Int);
            miComando.Parameters["@respuesta"].Direction = ParameterDirection.Output;


            miComando.Parameters.Add("@Caja_numero", SqlDbType.Int);
            miComando.Parameters["@Caja_numero"].Value = Caja_numero;

            miComando.Parameters.Add("@Caja_Apertura", SqlDbType.Int);
            miComando.Parameters["@Caja_Apertura"].Value = Caja_Apertura;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuestaInt = int.Parse(miComando.Parameters["@respuesta"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }
        //Finalizaordenes de una Caja
        public String RealizarFinalizacionDeUnaCaja(out int respuestaInt, int Caja_numero)
        {
            miComando.CommandText = "SPR_Tbl_TotalOrdenes_Finalizar_UnaCaja";

            respuestaInt = 0;
            miComando.Parameters.Add("@respuesta", SqlDbType.Int);
            miComando.Parameters["@respuesta"].Direction = ParameterDirection.Output;


            miComando.Parameters.Add("@Caja_numero", SqlDbType.Int);
            miComando.Parameters["@Caja_numero"].Value = Caja_numero;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                respuestaInt = int.Parse(miComando.Parameters["@respuesta"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }

        //Consultar  Cierre
        public DataRow ConsultarCierre(int Vent_id)
        {
            miComando.CommandText = "SPR_Tbl_TotalVentas_Consultar";

            miComando.Parameters.Add("@Vent_id", SqlDbType.Int);
            miComando.Parameters["@Vent_id"].Value = Vent_id;
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
        //Consultar  finalizacion ordenes
        public DataRow ConsultarFinOrdenes(int Ordenes_id)
        {
            miComando.CommandText = "[SPR_Tbl_TotalOrdenes_Consultar]";

            miComando.Parameters.Add("@Ordenes_id", SqlDbType.Int);
            miComando.Parameters["@Ordenes_id"].Value = Ordenes_id;
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
        //Listar  Cierres
        public DataTable ListarCierres(string Vent_fecha)
        {
            miComando.CommandText = "SPR_Tbl_TotalVentas_Listar";

            miComando.Parameters.Add("@Vent_fecha", SqlDbType.DateTime);
            miComando.Parameters["@Vent_fecha"].Value = Vent_fecha;

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
        //Listar  finalizacion ordenes
        public DataTable ListarFinOrdenes(string Ordenes_fecha)
        {
            miComando.CommandText = "SPR_Tbl_TotalOrdenes_Listar";

            miComando.Parameters.Add("@Ordenes_fecha", SqlDbType.DateTime);
            miComando.Parameters["@Ordenes_fecha"].Value = Ordenes_fecha;

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
        //Listar  detalle de las cajas del Cierres
        public DataTable ListarDetalleCierres(int Vent_id)
        {
            miComando.CommandText = "SPR_Tbl_VentasXCaja_ListarDeTotalVenta";

            miComando.Parameters.Add("@Vent_id", SqlDbType.Int);
            miComando.Parameters["@Vent_id"].Value = Vent_id;

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
        //Listar  detalle de las cajas del fin de ordenes
        public DataTable ListarDetalleFinOrdenes(int Vent_id)
        {
            miComando.CommandText = "[SPR_Tbl_OrdenesXcaja_ListarDeTotalVenta]";
            miComando.Parameters.Add("@Vent_id", SqlDbType.Int);
            miComando.Parameters["@Vent_id"].Value = Vent_id;

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

        //Consulta detalle de las cajas del Cierres
        public DataRow ConsultaDetalleCierres(int ventaXcaja_id)
        {
            miComando.CommandText = "SPR_Tbl_VentasXCaja_Consultar";

            miComando.Parameters.Add("@ventaXcaja_id", SqlDbType.Int);
            miComando.Parameters["@ventaXcaja_id"].Value = ventaXcaja_id;

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
        //Consulta detalle de las cajas ddel final de las ordenes
        public DataRow ConsultaDetalleFinalizacionOrden(int OrdenXcaja_id)
        {
            miComando.CommandText = "[SPR_Tbl_OrdenesXcaja_Consultar]";

            miComando.Parameters.Add("@OrdenXcaja_id", SqlDbType.Int);
            miComando.Parameters["@OrdenXcaja_id"].Value = OrdenXcaja_id;

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
