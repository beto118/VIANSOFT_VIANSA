using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioAgenda: Servicio, IDisposable
    {
        public ServicioAgenda()
        { }
        public void Dispose()
        { }

        //Insertar AGENDA
        public String InsertarAgenda(out int Agenda_ID, string Agenda_Nombre, string Agenda_Apellido1, string Agenda_Apellido2, string Agenda_Apodo, string Agenda_Tel1, string Agenda_Tel2, string Agenda_Cel1, string Agenda_Cel2, string Agenda_Direccion, string Agenda_Correo, string Agenda_Detalle, string Agenda_Estado)
        {
            miComando.CommandText = "[SPR_Tbl_Agenda_insertar]";


            Agenda_ID = 0;
            miComando.Parameters.Add("@Agenda_ID", SqlDbType.Int);
            miComando.Parameters["@Agenda_ID"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Agenda_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Nombre"].Value = Agenda_Nombre;

            miComando.Parameters.Add("@Agenda_Apellido1", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Apellido1"].Value = Agenda_Apellido1;

            miComando.Parameters.Add("@Agenda_Apellido2", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Apellido2"].Value = Agenda_Apellido2;

            miComando.Parameters.Add("@Agenda_Apodo", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Apodo"].Value = Agenda_Apodo;

            miComando.Parameters.Add("@Agenda_Tel1", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Tel1"].Value = Agenda_Tel1;

            miComando.Parameters.Add("@Agenda_Tel2", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Tel2"].Value = Agenda_Tel2;

            miComando.Parameters.Add("@Agenda_Cel1", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Cel1"].Value = Agenda_Cel1;

            miComando.Parameters.Add("@Agenda_Cel2", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Cel2"].Value = Agenda_Cel2;

            miComando.Parameters.Add("@Agenda_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Direccion"].Value = Agenda_Direccion;

            miComando.Parameters.Add("@Agenda_Correo", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Correo"].Value = Agenda_Correo;

            miComando.Parameters.Add("@Agenda_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Detalle"].Value = Agenda_Detalle;

            miComando.Parameters.Add("@Agenda_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Estado"].Value = Agenda_Estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Agenda_ID = int.Parse(miComando.Parameters["@Agenda_ID"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }
        //Modificar agenda
        public String ModificarAgenda(int Agenda_ID, string Agenda_Nombre, string Agenda_Apellido1, string Agenda_Apellido2, string Agenda_Apodo, string Agenda_Tel1, string Agenda_Tel2, string Agenda_Cel1, string Agenda_Cel2, string Agenda_Direccion, string Agenda_Correo, string Agenda_Detalle, string Agenda_Estado)
        {
            miComando.CommandText = "[SPR_Tbl_Agenda_Modificar]";

            miComando.Parameters.Add("@Agenda_ID", SqlDbType.Int);
            miComando.Parameters["@Agenda_ID"].Value = Agenda_ID;

            miComando.Parameters.Add("@Agenda_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Nombre"].Value = Agenda_Nombre;

            miComando.Parameters.Add("@Agenda_Apellido1", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Apellido1"].Value = Agenda_Apellido1;

            miComando.Parameters.Add("@Agenda_Apellido2", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Apellido2"].Value = Agenda_Apellido2;

            miComando.Parameters.Add("@Agenda_Apodo", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Apodo"].Value = Agenda_Apodo;

            miComando.Parameters.Add("@Agenda_Tel1", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Tel1"].Value = Agenda_Tel1;

            miComando.Parameters.Add("@Agenda_Tel2", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Tel2"].Value = Agenda_Tel2;

            miComando.Parameters.Add("@Agenda_Cel1", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Cel1"].Value = Agenda_Cel1;

            miComando.Parameters.Add("@Agenda_Cel2", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Cel2"].Value = Agenda_Cel2;

            miComando.Parameters.Add("@Agenda_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Direccion"].Value = Agenda_Direccion;

            miComando.Parameters.Add("@Agenda_Correo", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Correo"].Value = Agenda_Correo;

            miComando.Parameters.Add("@Agenda_Detalle", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Detalle"].Value = Agenda_Detalle;

            miComando.Parameters.Add("@Agenda_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Estado"].Value = Agenda_Estado;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  agenda
        public DataRow ConsultarAgenda(int Agenda_ID)
        {
            miComando.CommandText = "SPR_Tbl_Agenda_Consultar";

            miComando.Parameters.Add("@Agenda_ID", SqlDbType.Int);
            miComando.Parameters["@Agenda_ID"].Value = Agenda_ID;
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
        //Listar agenda
        public DataTable ListarAgenda(string filtro, string Agenda_Estado)
        {
            miComando.CommandText = "[SPR_Tbl_Agenda_Listar]";


            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@Agenda_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Agenda_Estado"].Value = Agenda_Estado;
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
