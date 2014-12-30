using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    class ServicioProforma : Servicio, IDisposable
    {
        public ServicioProforma()
        { }
        public void Dispose()
        { }
        public String RegistarProforma(out int Cot_Numero, int Usuario_Codigo, int Clie_Id, string Cot_ClieNombre, string Cot_ClieTelefono, string Cot_ClieDireccion, double Cot_SubTotal, double Cot_impuesto, double Cot_Descuento, double Cot_TotalDescuento, double Cot_Total)
        {
            miComando.CommandText = "SPR_Tbl_Proforma_Insertar";

            Cot_Numero = 0;
            miComando.Parameters.Add("@Cot_Numero", SqlDbType.Int);
            miComando.Parameters["@Cot_Numero"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Usuario_Codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_Codigo"].Value = Usuario_Codigo;

            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int);
            miComando.Parameters["@Clie_Id"].Value = Clie_Id;

            miComando.Parameters.Add("@Cot_ClieNombre", SqlDbType.VarChar);
            miComando.Parameters["@Cot_ClieNombre"].Value = Cot_ClieNombre;

            miComando.Parameters.Add("@Cot_ClieTelefono", SqlDbType.VarChar);
            miComando.Parameters["@Cot_ClieTelefono"].Value = Cot_ClieTelefono;

            miComando.Parameters.Add("@Cot_ClieDireccion", SqlDbType.VarChar);
            miComando.Parameters["@Cot_ClieDireccion"].Value = Cot_ClieDireccion;

            miComando.Parameters.Add("@Cot_SubTotal", SqlDbType.Money);
            miComando.Parameters["@Cot_SubTotal"].Value = Cot_SubTotal;

            miComando.Parameters.Add("@Cot_impuesto", SqlDbType.Money);
            miComando.Parameters["@Cot_impuesto"].Value = Cot_impuesto;

            miComando.Parameters.Add("@Cot_Descuento", SqlDbType.Money);
            miComando.Parameters["@Cot_Descuento"].Value = Cot_Descuento;

            miComando.Parameters.Add("@Cot_TotalDescuento", SqlDbType.Money);
            miComando.Parameters["@Cot_TotalDescuento"].Value = Cot_TotalDescuento;

            miComando.Parameters.Add("@Cot_Total", SqlDbType.Money);
            miComando.Parameters["@Cot_Total"].Value = Cot_Total;

            


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Cot_Numero = int.Parse(miComando.Parameters["@Cot_Numero"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Insertar Lineas
        public String RegistarLineaProforma(int Cot_Numero, int LinCoti_Prod_Cod, string LinCoti_Prod_Nombre, double LinCoti_Prod_Cantidad, double LinCoti_Prod_ValorUnt, double LinCoti_Prod_Total, double LinCoti_SubTotal, double LinCoti_Impuesto, double LinCoti_Descuento)
        {
            miComando.CommandText = "SPR_Tbl_LineaProforma_Insertar";


            miComando.Parameters.Add("@Cot_Numero", SqlDbType.Int);
            miComando.Parameters["@Cot_Numero"].Value = Cot_Numero;

            miComando.Parameters.Add("@LinCoti_Prod_Cod", SqlDbType.Int);
            miComando.Parameters["@LinCoti_Prod_Cod"].Value = LinCoti_Prod_Cod;

            miComando.Parameters.Add("@LinCoti_Prod_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@LinCoti_Prod_Nombre"].Value = LinCoti_Prod_Nombre;

            miComando.Parameters.Add("@LinCoti_Prod_Cantidad", SqlDbType.Money);
            miComando.Parameters["@LinCoti_Prod_Cantidad"].Value = LinCoti_Prod_Cantidad;

            miComando.Parameters.Add("@LinCoti_Prod_ValorUnt", SqlDbType.Money);
            miComando.Parameters["@LinCoti_Prod_ValorUnt"].Value = LinCoti_Prod_ValorUnt;

            miComando.Parameters.Add("@LinCoti_Prod_Total", SqlDbType.Money);
            miComando.Parameters["@LinCoti_Prod_Total"].Value = LinCoti_Prod_Total;

            miComando.Parameters.Add("@LinCoti_SubTotal", SqlDbType.Money);
            miComando.Parameters["@LinCoti_SubTotal"].Value = LinCoti_SubTotal;

            miComando.Parameters.Add("@LinCoti_Impuesto", SqlDbType.Money);
            miComando.Parameters["@LinCoti_Impuesto"].Value = LinCoti_Impuesto;

            miComando.Parameters.Add("@LinCoti_Descuento", SqlDbType.Money);
            miComando.Parameters["@LinCoti_Descuento"].Value = LinCoti_Descuento;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
                respuesta = respuestaCorrecta;

            return respuesta;

        }
        //Listar las Proformas
        public DataTable ListarProformas(string filtro)
        {
            miComando.CommandText = "SPR_Tbl_Proforma_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

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
