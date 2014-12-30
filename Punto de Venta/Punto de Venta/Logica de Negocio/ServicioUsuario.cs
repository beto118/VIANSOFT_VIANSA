using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioUsuario : Servicio, IDisposable
    {
        public ServicioUsuario()
        { }
        public void Dispose()
        { }

		//Insertar Usuarios
        public String InsertarUsuarios(out int Usuarios_codigo, string Usuarios_nombre, string Usuarios_apellido1, string Usuarios_apellido2, string Usuarios_telefono, string Usuarios_direccion, string Usuarios_contraseña, string Usuarios_tipoUsuario,string Usuarios_estado,string Usuarios_CodigoBarra,double Usuarios_GanaXhora)
        {
            miComando.CommandText = "SPR_Tbl_Usuarios_insertar";


            Usuarios_codigo = 0;
            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_nombre"].Value = Usuarios_nombre;

            miComando.Parameters.Add("@Usuario_apellido1", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_apellido1"].Value = Usuarios_apellido1;

            miComando.Parameters.Add("@Usuario_apellido2", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_apellido2"].Value = Usuarios_apellido2;

            miComando.Parameters.Add("@Usuario_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_telefono"].Value = Usuarios_telefono;

            miComando.Parameters.Add("@Usuario_direccion", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_direccion"].Value = Usuarios_direccion;

            miComando.Parameters.Add("@Usuario_contraseña", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contraseña"].Value = Usuarios_contraseña;

            miComando.Parameters.Add("@Usuario_tipoUsuario", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_tipoUsuario"].Value = Usuarios_tipoUsuario;

            miComando.Parameters.Add("@Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_estado"].Value = Usuarios_estado;

            miComando.Parameters.Add("@Usuario_CodigoBarra", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_CodigoBarra"].Value = Usuarios_CodigoBarra;

            miComando.Parameters.Add("@Usuario_GanaXhora", SqlDbType.Money);
            miComando.Parameters["@Usuario_GanaXhora"].Value = Usuarios_GanaXhora;
     
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Usuarios_codigo = int.Parse(miComando.Parameters["@Usuario_codigo"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }

        //Modificar usuarios
        public String ModificarUsuarios(int Usuarios_codigo, string Usuarios_nombre, string Usuarios_apellido1, string Usuarios_apellido2, string Usuarios_telefono, string Usuarios_direccion, string Usuarios_contraseña, string Usuarios_tipoUsuario, string Usuarios_estado, string Usuarios_CodigoBarra, double Usuarios_GanaXhora)
        {
            miComando.CommandText = "SPR_Tbl_Usuarios_Modificar";

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuarios_codigo;

            miComando.Parameters.Add("@Usuario_nombre", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_nombre"].Value = Usuarios_nombre;

            miComando.Parameters.Add("@Usuario_apellido1", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_apellido1"].Value = Usuarios_apellido1;

            miComando.Parameters.Add("@Usuario_apellido2", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_apellido2"].Value = Usuarios_apellido2;

            miComando.Parameters.Add("@Usuario_telefono", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_telefono"].Value = Usuarios_telefono;

            miComando.Parameters.Add("@Usuario_direccion", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_direccion"].Value = Usuarios_direccion;

            miComando.Parameters.Add("@Usuario_contraseña", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contraseña"].Value = Usuarios_contraseña;

            miComando.Parameters.Add("@Usuario_tipoUsuario", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_tipoUsuario"].Value = Usuarios_tipoUsuario;

            miComando.Parameters.Add("@Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_estado"].Value = Usuarios_estado;

            miComando.Parameters.Add("@Usuario_CodigoBarra", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_CodigoBarra"].Value = Usuarios_CodigoBarra;

            miComando.Parameters.Add("@Usuario_GanaXhora", SqlDbType.Money);
            miComando.Parameters["@Usuario_GanaXhora"].Value = Usuarios_GanaXhora;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  Usuarios
        public DataRow ConsultarUsuarios(int Usuarios_codigo)
        {
            miComando.CommandText = "SPR_Tbl_Usuarios_Consultar";

            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuarios_codigo;
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
        //Listar Usuarios
        public DataTable ListarUsuarios(string filtro, string Usuarios_estado)
        {
            miComando.CommandText = "SPR_Tbl_Usuarios_Listar";


            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@Usuario_estado", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_estado"].Value = Usuarios_estado;
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

        //Revisar Login
        public String RevisarLogin(out int Resultado,int Usuarios_codigo, string Usuarios_contraseña)
        {
            miComando.CommandText = "SPR_Tbl_Usuarios_RevisarLogin";


            Resultado = -1;
            miComando.Parameters.Add("@Usuario_codigo", SqlDbType.Int);
            miComando.Parameters["@Usuario_codigo"].Value = Usuarios_codigo;

            
            miComando.Parameters.Add("@Usuario_contraseña", SqlDbType.VarChar);
            miComando.Parameters["@Usuario_contraseña"].Value = Usuarios_contraseña;


            miComando.Parameters.Add("@respuesta", SqlDbType.Int);
            miComando.Parameters["@respuesta"].Direction = ParameterDirection.Output;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Resultado = int.Parse(miComando.Parameters["@respuesta"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }

    }
}
