using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioCategoriaProducto : Servicio, IDisposable
    {
        public ServicioCategoriaProducto()
        { }
        public void Dispose()
        { }

		//Insertar Categoria
        public String RegistarCategoria(out int Categoria_id, string Categoria_detalle, string Categoria_estado,string Categoria_listado)
        {
            miComando.CommandText = "SPR_Tbl_CategoriaProducto_insertar";
                        
            Categoria_id = 0;
            miComando.Parameters.Add("@Categoria_id", SqlDbType.Int);
            miComando.Parameters["@Categoria_id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Categoria_detalle", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_detalle"].Value = Categoria_detalle;

            miComando.Parameters.Add("@Categoria_estado", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_estado"].Value = Categoria_estado;

            miComando.Parameters.Add("@Categoria_listado", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_listado"].Value = Categoria_listado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Categoria_id = int.Parse(miComando.Parameters["@Categoria_id"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Modificar Categoria
        public String ModificarCategoria(int Categoria_id, string Categoria_detalle, string Categoria_estado, string Categoria_listado)
        {
            miComando.CommandText = "SPR_Tbl_CategoriaProducto_modificar";

            miComando.Parameters.Add("@Categoria_id", SqlDbType.Int);
            miComando.Parameters["@Categoria_id"].Value = Categoria_id;

            miComando.Parameters.Add("@Categoria_detalle", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_detalle"].Value = Categoria_detalle;

            miComando.Parameters.Add("@Categoria_estado", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_estado"].Value = Categoria_estado;

            miComando.Parameters.Add("@Categoria_listado", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_listado"].Value = Categoria_listado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  Categoria
        public DataRow ConsultarCategoria(int Categoria_ID)
        {
            miComando.CommandText = "SPR_Tbl_CategoriaProducto_Consultar";

            miComando.Parameters.Add("@Categoria_id", SqlDbType.Int);
            miComando.Parameters["@Categoria_id"].Value = Categoria_ID;
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
        public DataTable ListarCategoria(string filtro, string Categoria_estado)
        {
            miComando.CommandText = "SPR_Tbl_CategoriaProducto_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@Categoria_estado", SqlDbType.VarChar);
            miComando.Parameters["@Categoria_estado"].Value = Categoria_estado;

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
