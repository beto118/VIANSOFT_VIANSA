using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Componentes.Sistemas.Clases;
using System.Data;

namespace Punto_de_Venta.Logica_de_Negocio
{
    public class ServicioClientes: Servicio , IDisposable
    {
        public ServicioClientes()
        { }
        
        public void Dispose()
        { }

		//Insertar Usuarios
        public String InsertarClientes(out int Clie_Id, string Clie_Cedula, string Clie_Nombre, string Clie_Apellido1, string Clie_Apellido2, string Clie_Telefono, string Clie_Direccion, string Clie_TipoCliente, string Clie_Comisionista, double Clie_PorcentComision, string Clie_Estado, DateTime Clie_FechaRegistro,double Clie_CreditoMaximo)
        {
            miComando.CommandText = "SPR_Tbl_Clientes_Insertar";


            Clie_Id = 0;
            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int);
            miComando.Parameters["@Clie_Id"].Direction = ParameterDirection.Output;

            miComando.Parameters.Add("@Clie_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Cedula"].Value = Clie_Cedula;

            miComando.Parameters.Add("@Clie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Nombre"].Value = Clie_Nombre;

            miComando.Parameters.Add("@Clie_Apellido1", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Apellido1"].Value = Clie_Apellido1;

            miComando.Parameters.Add("@Clie_Apellido2", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Apellido2"].Value = Clie_Apellido2;

            miComando.Parameters.Add("@Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Telefono"].Value = Clie_Telefono;

            miComando.Parameters.Add("@Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Direccion"].Value = Clie_Direccion;

            miComando.Parameters.Add("@Clie_TipoCliente", SqlDbType.VarChar);
            miComando.Parameters["@Clie_TipoCliente"].Value = Clie_TipoCliente;

            miComando.Parameters.Add("@Clie_Comisionista", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Comisionista"].Value = Clie_Comisionista;

            miComando.Parameters.Add("@Clie_PorcentComision", SqlDbType.Money);
            miComando.Parameters["@Clie_PorcentComision"].Value = Clie_PorcentComision;

            miComando.Parameters.Add("@Clie_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Estado"].Value = Clie_Estado;

            miComando.Parameters.Add("@Clie_FechaRegistro", SqlDbType.DateTime);
            miComando.Parameters["@Clie_FechaRegistro"].Value = Clie_FechaRegistro;

            miComando.Parameters.Add("@Clie_CreditoMaximo", SqlDbType.Money);
            miComando.Parameters["@Clie_CreditoMaximo"].Value = Clie_CreditoMaximo;
     
            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "")
            {
                Clie_Id = int.Parse(miComando.Parameters["@Clie_Id"].Value.ToString());
                respuesta = respuestaCorrecta;
            }
            return respuesta;
        }
        //Modificar usuarios
        public String ModificarClientes(int Clie_Id, string Clie_Cedula, string Clie_Nombre, string Clie_Apellido1, string Clie_Apellido2, string Clie_Telefono, string Clie_Direccion, string Clie_TipoCliente, string Clie_Comisionista, double Clie_PorcentComision, string Clie_Estado, double Clie_CreditoMaximo)
        {
            miComando.CommandText = "SPR_Tbl_Clientes_Modificar";

            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int);
            miComando.Parameters["@Clie_Id"].Value = Clie_Id;

            miComando.Parameters.Add("@Clie_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Cedula"].Value = Clie_Cedula;

            miComando.Parameters.Add("@Clie_Nombre", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Nombre"].Value = Clie_Nombre;

            miComando.Parameters.Add("@Clie_Apellido1", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Apellido1"].Value = Clie_Apellido1;

            miComando.Parameters.Add("@Clie_Apellido2", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Apellido2"].Value = Clie_Apellido2;

            miComando.Parameters.Add("@Clie_Telefono", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Telefono"].Value = Clie_Telefono;

            miComando.Parameters.Add("@Clie_Direccion", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Direccion"].Value = Clie_Direccion;

            miComando.Parameters.Add("@Clie_TipoCliente", SqlDbType.VarChar);
            miComando.Parameters["@Clie_TipoCliente"].Value = Clie_TipoCliente;

            miComando.Parameters.Add("@Clie_Comisionista", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Comisionista"].Value = Clie_Comisionista;

            miComando.Parameters.Add("@Clie_PorcentComision", SqlDbType.Money);
            miComando.Parameters["@Clie_PorcentComision"].Value = Clie_PorcentComision;

            miComando.Parameters.Add("@Clie_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Estado"].Value = Clie_Estado;

            miComando.Parameters.Add("@Clie_CreditoMaximo", SqlDbType.Money);
            miComando.Parameters["@Clie_CreditoMaximo"].Value = Clie_CreditoMaximo;

            respuesta = this.ejecutaSentencia(miComando);
            if (respuesta == "") respuesta = respuestaCorrecta;
            return respuesta;

        }
        //Consultar  Clientes x codigo
        public DataRow ConsultarClientesXCodigo(int Cliente_Codigo)
        {
            miComando.CommandText = "SPR_Tbl_Clientes_ConsultarXcodigo";

            miComando.Parameters.Add("@Clie_Id", SqlDbType.Int);
            miComando.Parameters["@Clie_Id"].Value = Cliente_Codigo;
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
        //Consultar  Clientes por cedula
        public DataRow ConsultarClientesXced(string Cliente_Cedula)
        {
            miComando.CommandText = "SPR_Tbl_Clientes_ConsultarXCed";

            miComando.Parameters.Add("@Clie_Cedula", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Cedula"].Value = Cliente_Cedula;
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
        //Listar Clientes
        public DataTable ListarClientes(string filtro, string Cliente_estado)
        {
            miComando.CommandText = "SPR_Tbl_Clientes_Listar";


            miComando.Parameters.Add("@filtro", SqlDbType.VarChar);
            miComando.Parameters["@filtro"].Value = filtro;

            miComando.Parameters.Add("@Clie_Estado", SqlDbType.VarChar);
            miComando.Parameters["@Clie_Estado"].Value = Cliente_estado;
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
