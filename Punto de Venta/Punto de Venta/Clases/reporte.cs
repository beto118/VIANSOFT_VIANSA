/****************************************************************************
**
** Compañía:    
** Autor:       Marco Dalorzo Rojas
** Fecha:       16/07/2008
** Componente:  Capa de Presentación del Sistema Descuento de Facturas
** Descripción: Imprimir un reporte
*****************************************************************************/
using System;
using System.Collections;
using System.Text;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Componentes.Sistemas.Formularios;
using System.Data;
using System.Windows.Forms;



namespace Componentes.Sistemas.Clases
{
    public class reporte
    {
        ReportDocument miDocumentoReporte;
       // ManejoXML elarchivoConfiguracion = new ManejoXML();
        String ubicacionReportes = "";


        public reporte()
        {
            miDocumentoReporte = new ReportDocument();
            DataSet Valores = new DataSet();
            Valores.ReadXml(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + "\\Conexion.xml");
            try
            {
                ubicacionReportes = Valores.Tables[0].Rows[0]["reporte"].ToString(); ;
            }
            catch
            {
                ubicacionReportes = "";
            }
        }

        public void cargarDocumento(String NombreReporte,ArrayList laListaParametros)
        {
            //System.Windows.Forms.MessageBox.Show(ubicacionReportes + NombreReporte);
            //MessageBox.Show(ubicacionReportes + NombreReporte);
            miDocumentoReporte.Load(ubicacionReportes + NombreReporte);
            //MessageBox.Show("DEspues");
         /*   miDocumentoReporte.SetDatabaseLogon(Conexion.Valores.NombreDeUsuario,
                Conexion.Valores.PalabraClave,
                Conexion.Valores.Servidor,
                Conexion.Valores.BaseDeDatos);         
            */
            //reafirmamos el nombre de usuario y password
            miDocumentoReporte.DataSourceConnections[0].SetLogon(Conexion.laConexion.Usuario,
                Conexion.laConexion.Contrasena);

            
                     
            int i = 0;
       //     miDocumentoReporte.SetParameterValue(0, NombreReporte.Substring(9,NombreReporte.Length-13));

            foreach(String Parametro in laListaParametros)
                miDocumentoReporte.SetParameterValue(i++, Parametro);
           
            

            //establecemos la conexion para cada subreporte
            foreach (ReportDocument subReporte in miDocumentoReporte.Subreports)
                subReporte.DataSourceConnections[0].SetLogon(Conexion.laConexion.Usuario,
                Conexion.laConexion.Contrasena);
                /*subReporte.SetDatabaseLogon(Conexion.Valores.NombreDeUsuario,
                Conexion.Valores.PalabraClave,
                Conexion.Valores.Servidor,
                Conexion.Valores.BaseDeDatos);*/
            
            frmImpresionReporte laImpresion = new
                frmImpresionReporte(miDocumentoReporte);
            laImpresion.ShowDialog();
            miDocumentoReporte.Close();
        }

        public void ImprimirDocumento(String NombreReporte, ArrayList laListaParametros,string NombreImpresora)
        {
            //System.Windows.Forms.MessageBox.Show(ubicacionReportes + NombreReporte);
            miDocumentoReporte.Load(ubicacionReportes + NombreReporte);
            /*   miDocumentoReporte.SetDatabaseLogon(Conexion.Valores.NombreDeUsuario,
                   Conexion.Valores.PalabraClave,
                   Conexion.Valores.Servidor,
                   Conexion.Valores.BaseDeDatos);         
               */
            //reafirmamos el nombre de usuario y password
            miDocumentoReporte.DataSourceConnections[0].SetLogon(Conexion.laConexion.Usuario,
                Conexion.laConexion.Contrasena);



            int i = 0;
            //     miDocumentoReporte.SetParameterValue(0, NombreReporte.Substring(9,NombreReporte.Length-13));

            foreach (String Parametro in laListaParametros)
                miDocumentoReporte.SetParameterValue(i++, Parametro);



            //establecemos la conexion para cada subreporte
            foreach (ReportDocument subReporte in miDocumentoReporte.Subreports)
                subReporte.DataSourceConnections[0].SetLogon(Conexion.laConexion.Usuario,
                Conexion.laConexion.Contrasena);
            /*subReporte.SetDatabaseLogon(Conexion.Valores.NombreDeUsuario,
            Conexion.Valores.PalabraClave,
            Conexion.Valores.Servidor,
            Conexion.Valores.BaseDeDatos);*/
            if (NombreImpresora.Length == 0)
            {
                System.Drawing.Printing.PrinterSettings laImpresora = new System.Drawing.Printing.PrinterSettings();
                miDocumentoReporte.PrintOptions.PrinterName = laImpresora.PrinterName;
            }
            else
                miDocumentoReporte.PrintOptions.PrinterName = NombreImpresora;
            miDocumentoReporte.PrintToPrinter(1, false, 0, 0);
            miDocumentoReporte.Close();
        }

        public void cargarDocumento(String NombreReporte,String nombreParam, ArrayList laListaParametros)
        {
            miDocumentoReporte.Load(ubicacionReportes + NombreReporte);
            
/*
            miDocumentoReporte.SetDatabaseLogon(Conexion.Valores.NombreDeUsuario, 
                Conexion.Valores.PalabraClave,
                Conexion.Valores.Servidor,
                Conexion.Valores.BaseDeDatos);*/

            //reafirmamos el nombre de usuario y password
           /* miDocumentoReporte.DataSourceConnections[0].SetLogon(Conexion.Valores.NombreDeUsuario,
                Conexion.Valores.PalabraClave);*/
            
              miDocumentoReporte.SetParameterValue(0, NombreReporte.Substring(9, NombreReporte.Length - 13));


            ParameterValues misvalores = new ParameterValues();
            foreach (String Parametro in laListaParametros)
                misvalores.AddValue(Parametro);

            //Asignamos la lista de valores al parametros q admite multiples valores
            miDocumentoReporte.ParameterFields[nombreParam].CurrentValues = misvalores;


            //establecemos la conexion para cada subreporte
          /*  foreach (ReportDocument subReporte in miDocumentoReporte.Subreports)
                subReporte.SetDatabaseLogon(Conexion.Valores.NombreDeUsuario,
                Conexion.Valores.PalabraClave,
                Conexion.Valores.Servidor,
                Conexion.Valores.BaseDeDatos);
            

            frmImpresionReporte laImpresion = new
                frmImpresionReporte(miDocumentoReporte);
            laImpresion.ShowDialog();
            miDocumentoReporte.Close();*/
        }

     
    }
}

