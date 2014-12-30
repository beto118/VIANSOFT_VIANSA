using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioConceptoPago : Servicio, IDisposable
    {
        public ServicioConceptoPago()
        { }
        public void Dispose()
        { }
        //REGISTRAR UN CONCEPTO DE PAGO
        public String RegistrarConceptoPago(int Vendedor_id, int MovConceptoPago_id, double ConceptoPago_Monto, string ConceptoPago_detalle, string ConceptoPago_Tipo)
        {
            miComando.CommandText = "SPR_Tbl_ConceptoPago_insertar";
            
            miComando.Parameters.Add("@Vendedor_id", SqlDbType.Int);
            miComando.Parameters["@Vendedor_id"].Value = Vendedor_id;

            miComando.Parameters.Add("@MovConceptoPago_id", SqlDbType.Int);
            miComando.Parameters["@MovConceptoPago_id"].Value = MovConceptoPago_id;

            miComando.Parameters.Add("@ConceptoPago_Monto", SqlDbType.Money);
            miComando.Parameters["@ConceptoPago_Monto"].Value = ConceptoPago_Monto;

            miComando.Parameters.Add("@ConceptoPago_detalle", SqlDbType.VarChar);
            miComando.Parameters["@ConceptoPago_detalle"].Value = ConceptoPago_detalle;

            miComando.Parameters.Add("@ConceptoPago_Tipo", SqlDbType.VarChar);
            miComando.Parameters["@ConceptoPago_Tipo"].Value = ConceptoPago_Tipo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        public String ModificarConceptoPago(int ConceptoPago_id, double ConceptoPago_Monto, string ConceptoPago_detalle)
        {
            miComando.CommandText = "SPR_Tbl_ConceptoPago_modificar";

            miComando.Parameters.Add("@ConceptoPago_id", SqlDbType.Int);
            miComando.Parameters["@ConceptoPago_id"].Value = ConceptoPago_id;

            miComando.Parameters.Add("@ConceptoPago_Monto", SqlDbType.Money);
            miComando.Parameters["@ConceptoPago_Monto"].Value = ConceptoPago_Monto;

            miComando.Parameters.Add("@ConceptoPago_detalle", SqlDbType.VarChar);
            miComando.Parameters["@ConceptoPago_detalle"].Value = ConceptoPago_detalle;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Listar  Concepto de pago de Vendedor
        public DataTable ListarConceptoPagoVendedor(string Vendedor_id)
        {
            miComando.CommandText = "SPR_Tbl_ConceptoPago_ListarDeVendedor";

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
        //Listar  Concepto de pago
        public DataTable ListarConceptoPagoHistorial(int Vendedor_ID)
        {
            miComando.CommandText = "SPR_Tbl_ConceptoPago_ListarDePago";

            miComando.Parameters.Add("@PagoVendedor_ID", SqlDbType.Int);
            miComando.Parameters["@PagoVendedor_ID"].Value = Vendedor_ID;


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
        //consultar concepto pago
        public DataRow ConsultarConceptoPagoParaImpPV(int PagoVendedor_ID)
        {
            miComando.CommandText = "SPR_Tbl_ConceptoPago_ConsultarParaImpPV";

            miComando.Parameters.Add("@PagoVendedor_ID", SqlDbType.Int);
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
    }
}
