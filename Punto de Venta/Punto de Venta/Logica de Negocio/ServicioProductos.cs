using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data.SqlClient;
using System.Data;
namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioProductos : Servicio, IDisposable
    {

        public ServicioProductos()
        {
            
        }
        public void Dispose()
        { }

		
        //Insertar Productos en la factura directa 
        public String InsertarProductos(out int Producto_codigo, string Productos_nombre, string Productos_detalle, string Productos_codigoBarra, double Productos_valorUNitario, double Productos_PrecioGravado, int Cant_Id, string Productos_estado, string Producto_Listado, string Producto_Gravado, int Producto_CantidadMinima, int Categoria_id, int Producto_Ligado, double Producto_Cantidad, double Producto_PrecioCosto, double Producto_Utilidad, double Producto_UtilidadPorcentaje, int Producto_PrecioDefinido)
        {
            miComando.CommandText = "SPR_Tbl_Productos_insertar";


            Producto_codigo = 0;
            miComando.Parameters.Add("@Producto_codigo", SqlDbType.Int);
            miComando.Parameters["@Producto_codigo"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Producto_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Producto_nombre"].Value = Productos_nombre;

            miComando.Parameters.Add("@Producto_detalle", SqlDbType.VarChar);
            miComando.Parameters["@Producto_detalle"].Value = Productos_detalle;

            miComando.Parameters.Add("@Producto_codigoBarra", SqlDbType.VarChar);
            miComando.Parameters["@Producto_codigoBarra"].Value = Productos_codigoBarra;

            miComando.Parameters.Add("@Producto_valorUnitario", SqlDbType.Money);
            miComando.Parameters["@Producto_valorUnitario"].Value = Productos_valorUNitario;

            miComando.Parameters.Add("@Producto_PrecioGravado", SqlDbType.Money);
            miComando.Parameters["@Producto_PrecioGravado"].Value = Productos_PrecioGravado;

            miComando.Parameters.Add("@Cant_Id", SqlDbType.Int);
            miComando.Parameters["@Cant_Id"].Value = Cant_Id;

            miComando.Parameters.Add("@Producto_estado", SqlDbType.VarChar);
            miComando.Parameters["@Producto_estado"].Value = Productos_estado;

            miComando.Parameters.Add("@Producto_Listado", SqlDbType.VarChar);
            miComando.Parameters["@Producto_Listado"].Value = Producto_Listado;

            miComando.Parameters.Add("@Producto_Gravado", SqlDbType.VarChar).Value = Producto_Gravado;

            miComando.Parameters.Add("@Producto_CantidadMinima", SqlDbType.Int).Value = Producto_CantidadMinima;

            miComando.Parameters.Add("@Categoria_id", SqlDbType.Int).Value = Categoria_id;

            miComando.Parameters.Add("@Producto_Ligado", SqlDbType.Int).Value = Producto_Ligado;
            miComando.Parameters["@Producto_Ligado"].Value = Producto_Ligado;

            miComando.Parameters.Add("@Producto_Cantidad", SqlDbType.Money).Value = Producto_Cantidad;
            miComando.Parameters["@Producto_Cantidad"].Value = Producto_Cantidad;

            miComando.Parameters.Add("@Producto_PrecioCosto", SqlDbType.Money).Value = Producto_PrecioCosto;
            miComando.Parameters["@Producto_PrecioCosto"].Value = Producto_PrecioCosto;

            miComando.Parameters.Add("@Producto_Utilidad", SqlDbType.Money).Value = Producto_Utilidad;
            miComando.Parameters["@Producto_Utilidad"].Value = Producto_Utilidad;

            miComando.Parameters.Add("@Producto_UtilidadPorcentaje", SqlDbType.Money).Value = Producto_UtilidadPorcentaje;
            miComando.Parameters["@Producto_UtilidadPorcentaje"].Value = Producto_UtilidadPorcentaje;

            miComando.Parameters.Add("@Producto_PrecioDefinido", SqlDbType.Int).Value = Producto_PrecioDefinido;
            miComando.Parameters["@Producto_PrecioDefinido"].Value = Producto_PrecioDefinido;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Producto_codigo = int.Parse(miComando.Parameters["@Producto_codigo"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Modificar Productos
        public String ModificarProductos(int Productos_codigo, string Productos_nombre, string Productos_detalle, string Productos_codigoBarra, double Productos_valorUNitario, double Productos_PrecioGravado, int Cant_Id, string Productos_estado, string Producto_Listado, string Producto_Gravado, int Producto_CantidadMinima, int Categoria_id, int Producto_Ligado, double Producto_Cantidad, double Producto_PrecioCosto, double Producto_Utilidad, double Producto_UtilidadPorcentaje,int Producto_PrecioDefinido)
        {
            miComando.CommandText = "SPR_Tbl_Productos_modificar";

            miComando.Parameters.Add("@Producto_codigo", SqlDbType.Int);
            miComando.Parameters["@Producto_codigo"].Value = Productos_codigo;

            miComando.Parameters.Add("@Producto_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Producto_nombre"].Value = Productos_nombre;

            miComando.Parameters.Add("@Producto_detalle", SqlDbType.VarChar);
            miComando.Parameters["@Producto_detalle"].Value = Productos_detalle;

            miComando.Parameters.Add("@Producto_codigoBarra", SqlDbType.VarChar);
            miComando.Parameters["@Producto_codigoBarra"].Value = Productos_codigoBarra;

            miComando.Parameters.Add("@Producto_valorUnitario", SqlDbType.Money);
            miComando.Parameters["@Producto_valorUnitario"].Value = Productos_valorUNitario;

            miComando.Parameters.Add("@Producto_PrecioGravado", SqlDbType.Money);
            miComando.Parameters["@Producto_PrecioGravado"].Value = Productos_PrecioGravado;

            miComando.Parameters.Add("@Cant_Id", SqlDbType.Int);
            miComando.Parameters["@Cant_Id"].Value = Cant_Id;

            miComando.Parameters.Add("@Producto_estado", SqlDbType.VarChar);
            miComando.Parameters["@Producto_estado"].Value = Productos_estado;

            miComando.Parameters.Add("@Producto_Listado", SqlDbType.VarChar);
            miComando.Parameters["@Producto_Listado"].Value = Producto_Listado;


            miComando.Parameters.Add("@Producto_Gravado", SqlDbType.VarChar);
            miComando.Parameters["@Producto_Gravado"].Value = Producto_Gravado;


            miComando.Parameters.Add("@Producto_CantidadMinima", SqlDbType.Int).Value = Producto_CantidadMinima;

            miComando.Parameters.Add("@Categoria_id", SqlDbType.Int).Value = Categoria_id;

            miComando.Parameters.Add("@Producto_Ligado", SqlDbType.Int).Value = Producto_Ligado;
            miComando.Parameters["@Producto_Ligado"].Value = Producto_Ligado;

            miComando.Parameters.Add("@Producto_Cantidad", SqlDbType.Money).Value = Producto_Cantidad;
            miComando.Parameters["@Producto_Cantidad"].Value = Producto_Cantidad;

            miComando.Parameters.Add("@Producto_PrecioCosto", SqlDbType.Money).Value = Producto_PrecioCosto;
            miComando.Parameters["@Producto_PrecioCosto"].Value = Producto_PrecioCosto;

            miComando.Parameters.Add("@Producto_Utilidad", SqlDbType.Money).Value = Producto_Utilidad;
            miComando.Parameters["@Producto_Utilidad"].Value = Producto_Utilidad;

            miComando.Parameters.Add("@Producto_UtilidadPorcentaje", SqlDbType.Money).Value = Producto_UtilidadPorcentaje;
            miComando.Parameters["@Producto_UtilidadPorcentaje"].Value = Producto_UtilidadPorcentaje;

            miComando.Parameters.Add("@Producto_PrecioDefinido", SqlDbType.Int).Value = Producto_PrecioDefinido;
            miComando.Parameters["@Producto_PrecioDefinido"].Value = Producto_PrecioDefinido;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }

        //Modificar Productos
        public String ModificarCantidadProductos(int Productos_codigo, double Cant_Cantidad)
        {
            miComando.CommandText = "SPR_Tbl_Productos_modificar_cantidad";

            miComando.Parameters.Add("@Producto_codigo", SqlDbType.Int);
            miComando.Parameters["@Producto_codigo"].Value = Productos_codigo;

            //miComando.Parameters.Add("@Cant_Id", SqlDbType.Int);
            //miComando.Parameters["@Cant_Id"].Value = Cant_Id;

            miComando.Parameters.Add("@Cant_Cantidad", SqlDbType.Money);
            miComando.Parameters["@Cant_Cantidad"].Value = Cant_Cantidad;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }

        //Consultar  Productos
        public DataRow ConsultarProductos(int Producto_codigo)
        {
            miComando.CommandText = "SPR_Tbl_Productos_Consultar";

            miComando.Parameters.Add("@Producto_codigo", SqlDbType.Int);
            miComando.Parameters["@Producto_codigo"].Value = Producto_codigo;
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

        //Consultar  Productos x codido barra
        public DataRow ConsultarProductosXCodBarra(string Producto_codigoBarra)
        {
            miComando.CommandText = "SPR_Tbl_Productos_ConsultarXCodBarra";


            miComando.Parameters.Add("@Producto_codigobarra", SqlDbType.VarChar);
            miComando.Parameters["@Producto_codigobarra"].Value = Producto_codigoBarra;

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

        //Listar  Productos [SPR_Tbl_Productos_ListarParaFactura]
        public DataTable ListarProductos(string filtro, string producto_estado, int Categoria_id)
        {
            miComando.CommandText = "SPR_Tbl_Productos_Listar";


            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;


            miComando.Parameters.Add("@producto_estado", SqlDbType.VarChar).Value = producto_estado;

            miComando.Parameters.Add("@categoria_id", SqlDbType.Int).Value = Categoria_id;

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
        //Listar  Productos PARA FACTURA
        public DataTable ListarProductosFACTURA(string filtro, string producto_estado, int Categoria_id)
        {
            miComando.CommandText = "SPR_Tbl_Productos_ListarParaFactura";


            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;


            miComando.Parameters.Add("@producto_estado", SqlDbType.VarChar).Value = producto_estado;

            miComando.Parameters.Add("@categoria_id", SqlDbType.Int).Value = Categoria_id;

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

        //Listar  Productos bajo de la cantidad minima
        public DataTable ListarProductosBajoInventario(int Categoria_id)
        {
            miComando.CommandText = "SPR_Tbl_Productos_Listar_BajoInventario";



            miComando.Parameters.Add("@categoria_id", SqlDbType.Int).Value = Categoria_id;

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

        //Listar  Productos mas vendidos
        public DataTable ProductosMasVendedidos()
        {
            miComando.CommandText = "SPR_Tbl_Productos_ListarMasVendedidos";

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

        //Listar  Productos por categoria
        public DataTable ProductosxCategoria(string producto_Listado)
        {
            miComando.CommandText = "SPR_Tbl_Productos_ListarXCategoria";

            miComando.Parameters.Add("@producto_Listado", SqlDbType.VarChar);
            miComando.Parameters["@producto_Listado"].Value = producto_Listado;


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

        public object Producto_cantidad { get; set; }
    }
}
