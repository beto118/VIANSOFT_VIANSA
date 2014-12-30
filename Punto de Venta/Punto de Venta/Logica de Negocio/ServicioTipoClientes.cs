using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioTipoClientes: Servicio, IDisposable
    {
        public ServicioTipoClientes()
        { }
        public void Dispose()
        { }

        //Insertar Categoria
        public String RegistarTipoCliente(out int TipClie_ID, string TipClie_Nombre, double TipClie_LimiteCredito, string TipClie_Estado)
        {
            miComando.CommandText = "SPR_Tbl_Tipo_Clientes_insertar";

            TipClie_ID = 0;
            miComando.Parameters.Add("@TipClie_ID", SqlDbType.Int);
            miComando.Parameters["@TipClie_ID"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@TipClie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@TipClie_Nombre"].Value = TipClie_Nombre;

            miComando.Parameters.Add("@TipClie_LimiteCredito", SqlDbType.Money);
            miComando.Parameters["@TipClie_LimiteCredito"].Value = TipClie_LimiteCredito;

            miComando.Parameters.Add("@TipClie_Estado", SqlDbType.VarChar);
            miComando.Parameters["@TipClie_Estado"].Value = TipClie_Estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                TipClie_ID = int.Parse(miComando.Parameters["@TipClie_ID"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Modificar Tipo
        public String ModificarTipoCLiente(int TipClie_ID, string TipClie_Nombre, double TipClie_LimiteCredito, string TipClie_Estado)
        {
            miComando.CommandText = "SPR_Tbl_CategoriaProducto_modificar";

            miComando.Parameters.Add("@TipClie_ID", SqlDbType.Int);
            miComando.Parameters["@TipClie_ID"].Value = TipClie_ID;

            miComando.Parameters.Add("@TipClie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@TipClie_Nombre"].Value = TipClie_Nombre;

            miComando.Parameters.Add("@TipClie_LimiteCredito", SqlDbType.Money);
            miComando.Parameters["@TipClie_LimiteCredito"].Value = TipClie_LimiteCredito;

            miComando.Parameters.Add("@TipClie_Estado", SqlDbType.VarChar);
            miComando.Parameters["@TipClie_Estado"].Value = TipClie_Estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  Categoria
        public DataRow ConsultarTipoCLientes(int TipClie_ID)
        {
            miComando.CommandText = "SPR_Tbl_Tipo_Cliente_Consultar";

            miComando.Parameters.Add("@TipClie_ID", SqlDbType.Int);
            miComando.Parameters["@TipClie_ID"].Value = TipClie_ID;
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
        //Listar  Categoria
        public DataTable ListarTipoClientes(string filtro, string TipClie_Estado)
        {
            miComando.CommandText = "SPR_Tbl_Tipo_Clientes_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@TipClie_Estado", SqlDbType.VarChar);
            miComando.Parameters["@TipClie_Estado"].Value = TipClie_Estado;

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

        //Listar  Categoria
        public DataTable ListarCategoria_ConListado()
        {
            miComando.CommandText = "SPR_Tbl_CategoriaProducto_Listar_ConListado";


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
