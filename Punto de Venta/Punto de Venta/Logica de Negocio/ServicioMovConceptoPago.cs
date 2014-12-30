using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioMovConceptoPago : Servicio, IDisposable
    {
        public ServicioMovConceptoPago()
        { }
        public void Dispose()
        { }
        //REGISTRAR UN MOVIMIENTO CONCEPTO DE PAGO
        public String RegistrarMovConceptoPago(string MovConceptoPago_nombre, string MovConceptoPago_RestaSuma)//int ConceptoPago_id
        {
            miComando.CommandText = "SPR_Tbl_MovConceptoPago_insertar";
            //ConceptoPago_id =0;
            //miComando.Parameters.Add("@ConceptoPago_id", SqlDbType.Int);
            //miComando.Parameters["@ConceptoPago_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@MovConceptoPago_nombre", SqlDbType.VarChar);
            miComando.Parameters["@MovConceptoPago_nombre"].Value = MovConceptoPago_nombre;

            miComando.Parameters.Add("@MovConceptoPago_RestaSuma", SqlDbType.VarChar);
            miComando.Parameters["@MovConceptoPago_RestaSuma"].Value = MovConceptoPago_RestaSuma;



            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Listar Movimientos de pago
        public DataTable ListarMovConceptoPago(string Filtro)
        {
            miComando.CommandText = "SPR_Tbl_MovConceptoPago_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = Filtro;


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
        //Consultar  Movimientos.
        public DataRow ConsultarMovimientos(int Codigo)
        {
            miComando.CommandText = "SPR_Tbl_MovConceptoPago_Consultar";

            miComando.Parameters.Add("@MovConceptoPago_id", SqlDbType.Int);
            miComando.Parameters["@MovConceptoPago_id"].Value = Codigo;
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
        public String ModificarMovimiento(int MovConceptoPago_id,string MovConceptoPago_nombre, string MovConceptoPago_RestaSuma, string MovConceptoPago_Estado)
        {
            miComando.CommandText = "SPR_Tbl_MovConceptoPago_modificar";

            miComando.Parameters.Add("@MovConceptoPago_id", SqlDbType.Int);
            miComando.Parameters["@MovConceptoPago_id"].Value = MovConceptoPago_id;

            miComando.Parameters.Add("@MovConceptoPago_nombre", SqlDbType.VarChar);
            miComando.Parameters["@MovConceptoPago_nombre"].Value = MovConceptoPago_nombre;

            miComando.Parameters.Add("@MovConceptoPago_RestaSuma", SqlDbType.VarChar);
            miComando.Parameters["@MovConceptoPago_RestaSuma"].Value = MovConceptoPago_RestaSuma;

            miComando.Parameters.Add("@MovConceptoPago_Estado", SqlDbType.VarChar);
            miComando.Parameters["@MovConceptoPago_Estado"].Value = MovConceptoPago_Estado;

            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
    }
}
