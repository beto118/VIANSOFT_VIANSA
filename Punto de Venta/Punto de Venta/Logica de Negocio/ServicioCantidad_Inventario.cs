using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioCantidad_Inventario : Servicio, IDisposable
    {
        public ServicioCantidad_Inventario()
        { }
        public void Dispose()
        { }

        //Insertar cantidad inventario
        public String RegistarCantidadInv(out int Cant_ID, string Cant_Nombre, string Cant_Detalle, decimal Cant_Cantidad, string Cant_Estado)
        {
            miComando.CommandText = "SPR_Tbl_Cantidad_Inventario_insertar";

            Cant_ID = 0;
            miComando.Parameters.Add("@Cant_Id", SqlDbType.Int);
            miComando.Parameters["@Cant_Id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Cant_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Nombre"].Value = Cant_Nombre;

            miComando.Parameters.Add("@Cant_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Detalle"].Value = Cant_Detalle;

            miComando.Parameters.Add("@Cant_Cantidad", SqlDbType.Decimal);
            miComando.Parameters["@Cant_Cantidad"].Value = Cant_Cantidad;

            miComando.Parameters.Add("@Cant_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Estado"].Value = Cant_Estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Cant_ID = int.Parse(miComando.Parameters["@Cant_Id"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;

        }
        //Modificar cantidad inventario
        public String ModificarCatidadInv(int Cant_Id, string Cant_Nombre, string Cant_Detalle, decimal Cant_Cantidad, string Cant_Estado)
        {
            miComando.CommandText = "SPR_Tbl_Cantidad_Inventario_modificar";

            miComando.Parameters.Add("@Cant_Id", SqlDbType.Int);
            miComando.Parameters["@Cant_Id"].Value = Cant_Id;

            miComando.Parameters.Add("@Cant_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Nombre"].Value = Cant_Nombre;

            miComando.Parameters.Add("@Cant_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Detalle"].Value = Cant_Detalle;

            miComando.Parameters.Add("@Cant_Cantidad", SqlDbType.Decimal);
            miComando.Parameters["@Cant_Cantidad"].Value = Cant_Cantidad;

            miComando.Parameters.Add("@Cant_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Estado"].Value = Cant_Estado;


            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  cantidad de inventario
        public DataRow ConsultarCantidadInv(int Cant_Id)
        {
            miComando.CommandText = "SPR_Tbl_Cantidad_Inventario_Consultar";

            miComando.Parameters.Add("@Cant_Id", SqlDbType.Int);
            miComando.Parameters["@Cant_Id"].Value = Cant_Id;
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
        //Listar  cantidad de inventario
        public DataTable ListarCantidadInv(string filtro, string Cant_Estado)
        {
            miComando.CommandText = "SPR_Tbl_Cantidad_Inventario_Listar";

            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@Cant_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Cant_Estado"].Value = Cant_Estado;

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
