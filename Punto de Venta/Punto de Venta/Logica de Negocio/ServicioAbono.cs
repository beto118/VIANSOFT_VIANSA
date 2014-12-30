using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioAbono : Servicio, IDisposable
    {
        public ServicioAbono()
        {  }
        public void Dispose()
        { }

		//Inserta  PagoProveedor
        public String InsertarAbono(out int Abono_ID,int  Clie_ID, string abono_Fecha, double abono_Monto, string abono_Detalle, int usuario_ID)
        {
            miComando.CommandText = "SPR_tbl_Abono_insertar";

            Abono_ID = 0;
            miComando.Parameters.Add("@Abono_ID", SqlDbType.Int);
            miComando.Parameters["@Abono_ID"].Direction = ParameterDirection.Output;


            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@abono_Fecha", SqlDbType.DateTime);
            miComando.Parameters["@abono_Fecha"].Value = abono_Fecha;


            miComando.Parameters.Add("@abono_Monto", SqlDbType.Money);
            miComando.Parameters["@abono_Monto"].Value = abono_Monto;

            miComando.Parameters.Add("@abono_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@abono_Detalle"].Value = abono_Detalle;
            //usuario_codigo
            miComando.Parameters.Add("@usuario_ID", SqlDbType.Int);
            miComando.Parameters["@usuario_ID"].Value = usuario_ID;
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Modificar  PagoProveedor
        public String ModificarAbono(int abono_ID,string abono_Fecha,int Clie_ID,double abono_Monto,string abono_Detalle,string abono_Estado)
        {
            miComando.CommandText = "SPR_tbl_Abono_modificar";


            miComando.Parameters.Add("@abono_ID", SqlDbType.Int);
            miComando.Parameters["@abono_ID"].Value = abono_ID;

            miComando.Parameters.Add("@abono_Fecha", SqlDbType.DateTime);
            miComando.Parameters["@abono_Fecha"].Value = abono_Fecha;

            miComando.Parameters.Add("@Clie_ID", SqlDbType.Int);
            miComando.Parameters["@Clie_ID"].Value = Clie_ID;

            miComando.Parameters.Add("@abono_Monto", SqlDbType.Money);
            miComando.Parameters["@abono_Monto"].Value = abono_Monto;

            miComando.Parameters.Add("@abono_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@abono_Detalle"].Value = abono_Detalle;

            miComando.Parameters.Add("@abono_Estado", SqlDbType.VarChar);
            miComando.Parameters["@abono_Estado"].Value = abono_Estado;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }


        //Eliminar PagoProveedor
        public String EliminarAbono(int abono_ID)
        {
            miComando.CommandText = "SPR_tbl_Abonos_eliminar";


            miComando.Parameters.Add("@abono_ID", SqlDbType.Int);
            miComando.Parameters["@abono_ID"].Value = abono_ID;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        
        //Consultar  PagoProveedor
        public DataRow ConsultarAbono(int abono_ID)
        {
            miComando.CommandText = "SPR_tbl_Abono_Consultar";


            miComando.Parameters.Add("@abono_ID", SqlDbType.Int);
            miComando.Parameters["@abono_ID"].Value = abono_ID;
            

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
        //Consultar  abono para imprimir
        public DataRow ConsultarAbonoImprimir(int abono_ID, int FactNumero)
        {
            miComando.CommandText = "SPR_tbl_Abono_Imprimir";


            miComando.Parameters.Add("@abono_ID", SqlDbType.Int);
            miComando.Parameters["@abono_ID"].Value = abono_ID;

            miComando.Parameters.Add("@FactNumero", SqlDbType.Int);
            miComando.Parameters["@FactNumero"].Value = FactNumero;


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
        //Consultar  abono para imprimir
        public DataRow ConsultarAbonoFactHOYimprimir(int abono_ID, int FactNumero)
        {
            miComando.CommandText = "SPR_tbl_Abono_FactHoy_Imprimir";


            miComando.Parameters.Add("@abono_ID", SqlDbType.Int);
            miComando.Parameters["@abono_ID"].Value = abono_ID;

            miComando.Parameters.Add("@FactNumero", SqlDbType.Int);
            miComando.Parameters["@FactNumero"].Value = FactNumero;


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
        
		//Listar  PagoProveedor
        public DataTable ListarAbono(string filtro, int soloFecha, string abono_Fecha)
        {
            miComando.CommandText = "SPR_tbl_Abono_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@soloFecha", SqlDbType.Int);
            miComando.Parameters["@soloFecha"].Value = soloFecha;

            miComando.Parameters.Add("@abono_Fecha", SqlDbType.DateTime);
            miComando.Parameters["@abono_Fecha"].Value = abono_Fecha;
            

            try
            {
                DataSet miDataSet = new DataSet();
                this.abrirConexion();
                miDataSet = this.seleccionarInformacion(miComando);
                this.cerrarConexion();
                return miDataSet.Tables[0];
            }
            catch(Exception e)
            {
                string error = e.Message;
                return null;
            }

        }
    }
}
