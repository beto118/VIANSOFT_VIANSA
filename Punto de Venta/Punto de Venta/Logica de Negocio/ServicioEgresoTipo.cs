using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioEgresoTipo:ServicioAbono,IDisposable
    {
        public ServicioEgresoTipo()

        { }

        public void Dispose()
        { }
        //REGISTRAR UN MOVIMIENTO CONCEPTO DE PAGO
        public String RegistrarEgresoTipo(string EgresoTipo_nombre, string EgresoTipo_RestaSuma)//int ConceptoPago_id
        {
            miComando.CommandText = "SPR_Tbl_EgresoTipo_insertar";
            //ConceptoPago_id =0;
            //miComando.Parameters.Add("@ConceptoPago_id", SqlDbType.Int);
            //miComando.Parameters["@ConceptoPago_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@EgresoTipo_nombre", SqlDbType.VarChar);
            miComando.Parameters["@EgresoTipo_nombre"].Value = EgresoTipo_nombre;

            miComando.Parameters.Add("@EgresoTipo_RestaSuma", SqlDbType.VarChar);
            miComando.Parameters["@EgresoTipo_RestaSuma"].Value = EgresoTipo_RestaSuma;



            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Listar Movimientos de pago
        public DataTable ListarEgresoTipo(string Filtro)
        {
            miComando.CommandText = "SPR_Tbl_EgresoTipo_Listar";

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
        public DataRow Consultar(int Codigo)
        {
            miComando.CommandText = "SPR_Tbl_EgresoTipo_Consultar";

            miComando.Parameters.Add("@EgresoTipo_id", SqlDbType.Int);
            miComando.Parameters["@EgresoTipo_id"].Value = Codigo;
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
        public String ModificarEgreso(int EgresoTipo_id, string EgresoTipo_nombre, string EgresoTipo_RestaSuma)
        {
            miComando.CommandText = "SPR_Tbl_EgresoTipo_modificar";

            miComando.Parameters.Add("@EgresoTipo_id", SqlDbType.Int);
            miComando.Parameters["@EgresoTipo_id"].Value = EgresoTipo_id;

            miComando.Parameters.Add("@EgresoTipo_nombre", SqlDbType.VarChar);
            miComando.Parameters["@EgresoTipo_nombre"].Value = EgresoTipo_nombre;

            miComando.Parameters.Add("@EgresoTipo_RestaSuma", SqlDbType.VarChar);
            miComando.Parameters["@EgresoTipo_RestaSuma"].Value = EgresoTipo_RestaSuma;




            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }

    }
}
