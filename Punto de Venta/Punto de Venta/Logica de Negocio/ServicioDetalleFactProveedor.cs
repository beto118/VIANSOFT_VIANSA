
/****************************************************************************
**
** Compania:    Desarrollo Personal
** Sistema:     Sistema de Control de Facturas de Bajo Caliente
** Autor:       Luis Angulo
** Fecha:       03/09/2011
** Componente:  
** Descripcion: Servicio de DetalleFactProveedor. 
*****************************************************************************/
using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using Componentes.Sistemas.Clases;
//using System.Linq;
using System.Text;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioDetalleFactProveedor : Servicio, IDisposable
    {
        
        public ServicioDetalleFactProveedor()
        {
            
        }
        public void Dispose()
        { }

		//Inserta  DetalleFactProveedor
        public String InsertarDetalleFactProveedor(int FactProveedor_id, int Producto_codigo, int DetalleFactProveedor_cant, double DetalleFactProveedor_precioNuevo, double DetalleFactProveedor_total)
        {
            miComando.CommandText = "SPR_tbl_DetalleFactProveedor_insertar";

            
			miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;
            
			miComando.Parameters.Add("@Producto_codigo", SqlDbType.Int).Value = Producto_codigo;
            
			miComando.Parameters.Add("@DetalleFactProveedor_cant", SqlDbType.Int).Value = DetalleFactProveedor_cant;
            
			miComando.Parameters.Add("@DetalleFactProveedor_precioNuevo", SqlDbType.Money).Value = DetalleFactProveedor_precioNuevo;
            
			miComando.Parameters.Add("@DetalleFactProveedor_total", SqlDbType.Money).Value = DetalleFactProveedor_total;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Eliminar  DetalleFactProveedor
        public String EliminarDetalleFactProveedor(int DetalleFactProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_DetalleFactProveedor_Eliminar";

            
			miComando.Parameters.Add("@DetalleFactProveedor_id", SqlDbType.Int).Value = DetalleFactProveedor_id;
            
            

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
		//Listar  DetalleFactProveedor
        public DataTable ListarDetalleFactProveedor(int FactProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_DetalleFactProveedor_Listar";

            miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;
            
            

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

        //Aplicar la cantidad al inventario
        public String AplicarDetalleFactProveedor(int FactProveedor_id)
        {
            miComando.CommandText = "SPR_tbl_DetalleFactProveedor_AplicarInventario";


            miComando.Parameters.Add("@FactProveedor_id", SqlDbType.Int).Value = FactProveedor_id;



            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
    }
}
