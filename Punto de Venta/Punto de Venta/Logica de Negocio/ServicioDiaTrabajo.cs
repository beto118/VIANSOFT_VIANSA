using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioDiaTrabajo : Servicio, IDisposable 
    {
        public ServicioDiaTrabajo()
        { }
        public void Dispose()
        { }
        //Inserta  Dia Trabajo manualmente
        public String InsertarEntradaDiaTrabajoManual(int VendedorID, DateTime FechaHoraMin)
        {
            miComando.CommandText = "[SPR_Tbl_DiaTrabajo_RegistrarEntradaManual]";


            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int).Value = VendedorID;

            miComando.Parameters.Add("@DiaTrabajo_fechaHoraMin", SqlDbType.DateTime).Value = FechaHoraMin;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        // Registro de la hora de salida del trabajor manualmente
        public String RegistrarSalidaManual(int Vendedor_id, out string RespuestaSalida, DateTime FechaHoraMin)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_RegistrarSalidaManual";

            RespuestaSalida = "";
            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;

            miComando.Parameters.Add("@RespuestaSalida", SqlDbType.VarChar, 2000);
            miComando.Parameters["@RespuestaSalida"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@FechaHoraMin", SqlDbType.DateTime);
            miComando.Parameters["@FechaHoraMin"].Value = FechaHoraMin;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                RespuestaSalida = miComando.Parameters["@RespuestaSalida"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Eliminar  Dia Trabajo manualmente
        public String EliminarDiaTrabajo(int DiaTrabajo_Consecutivo)
        {
            miComando.CommandText = "[SPR_Tbl_DiaTrabajo_Eliminar]";


            miComando.Parameters.Add("@DiaTrabajo_Consecutivo", SqlDbType.Int).Value = DiaTrabajo_Consecutivo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Inserta  Dia Trabajo
        public String InsertarEntradaDiaTrabajo(int VendedorID)
        {
            miComando.CommandText = "[SPR_Tbl_DiaTrabajo_RegistrarEntrada]";


            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int).Value = VendedorID;

            
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        // Registro de la hora de salida del trabajor
        public String RegistrarSalida(int Vendedor_id, out string RespuestaSalida)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_RegistrarSalida";

            RespuestaSalida = "";
            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;

            miComando.Parameters.Add("@RespuestaSalida", SqlDbType.VarChar, 2000);
            miComando.Parameters["@RespuestaSalida"].Direction = ParameterDirection.Output;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                RespuestaSalida = miComando.Parameters["@RespuestaSalida"].Value.ToString();
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }

        //Consulta si existe una espera de registro de salida
        public DataRow ConsultarDiaEspera(int VendedorID)
        {
            miComando.CommandText = "[SPR_Tbl_DiaTrabajo_Tiene_EnEspera]";

            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = VendedorID;


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
        //Consultar Dia trabajo
        public DataRow ConsultarDiaTrabajo(string Vendedor_id)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_Consultar";

            miComando.Parameters.Add("@Vendedor_id", SqlDbType.VarChar);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;


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
		//Listar  DiaTrabajo de Vendedor
        public DataTable ListarDiaTrabajoDeVendedor(string Vendedor_id)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_ListarDeVendedor";

            miComando.Parameters.Add("@Vendedor_id", SqlDbType.VarChar);
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
        

        //Listar  DiaTrabajo de Pago
        public DataTable ListarDiaTrabajoDePago(int PagoVendedor_ID)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_ListarDePago";

            miComando.Parameters.Add("@PagoVendedor_ID", SqlDbType.Int);
            miComando.Parameters["@PagoVendedor_ID"].Value = PagoVendedor_ID;


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
        //Listar  Vendedores con Dia Abierto
        public DataTable ListarVendedoresDiaAbierto()
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_ListarVendedores_enEspera";


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

        
        //Total de horas  de Pago
        public DataRow TotalHorasDePago(int PagoVendedor_ID)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_TotalHorasDePago";

            miComando.Parameters.Add("@PagoVendedor_ID", SqlDbType.VarChar);
            miComando.Parameters["@PagoVendedor_ID"].Value = PagoVendedor_ID;


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
        //Consultar Total de Horas del vendedor
        public DataRow ConsultarTotalHorasVendedor(int Vendedor_id)
        {
            miComando.CommandText = "SPR_Tbl_DiaTrabajo_TotalHorasDeVendedor";

            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;


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
