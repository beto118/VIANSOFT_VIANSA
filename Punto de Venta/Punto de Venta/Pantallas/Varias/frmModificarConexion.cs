/****************************************************************************
**
** Lugar:       Desarrollo Personal
** Autor:       Luis Angulo Jimenez
** Fecha:       11/08/2009
** Componente:  
** Descripción: Formulario de Mantenimiento de Conexion
*****************************************************************************/
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
////using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Formularios;
using Componentes.Sistemas.Clases;



namespace Punto_de_Venta
{
    public partial class frmModificarConexion : frmAgregarModificar
    {
        public frmModificarConexion()
        {
            InitializeComponent();
            CargarDatos();
        }

        public void CargarDatos()
        {
            try
            {
                DataSet Valores = new DataSet();
                Valores.ReadXml(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + "\\Conexion.xml");
                DataRow datos = Valores.Tables[0].Rows[0];

                try { txbServer.Text = datos["server"].ToString(); }
                catch
                {
                    txbServer.Text = "error";
                    MessageBox.Show("Error al Leer el Server");
                }

                try { txbDB.Text = datos["database"].ToString(); }
                catch
                {
                    txbDB.Text = "error";
                    MessageBox.Show("Error al Leer el DataBase");
                }
                try { txbLicencia.Text= datos["licencia"].ToString(); }
                catch
                {
                    //txbLicencia.Text = "error";
                    MessageBox.Show("Error al Leer la Licencia");
                }
                try { txbImpFactura.Text = datos["impresoraFactura"].ToString(); }
                catch
                {
                    txbImpFactura.Text = "error";
                    MessageBox.Show("Error al Leer el impresoraFactura");
                }
                try { txbCaja.Text = datos["numcaja"].ToString(); }
                catch
                {
                    txbCaja.Text = "error";
                    MessageBox.Show("Error al Leer el numcaja");
                }
                try { txbReportes.Text = datos["reporte"].ToString(); }
                catch
                {
                    txbReportes.Text = "error";
                    MessageBox.Show("Error al Leer el reporte");
                }
                try { txbPuerto.Text = datos["puerto"].ToString(); }
                catch
                {
                    txbPuerto.Text = "error";
                    MessageBox.Show("Error al Leer el puerto");
                }
                
            }
            catch
            {
                txbServer.Text = "error";
                txbDB.Text = "error";
                txbImpFactura.Text = "error";
                txbCaja.Text = "error";
            }
        }

        private void frmModificarConexion_Load(object sender, EventArgs e)
        {
            tsbEliminar.Visible = false;
            tsbHistorial.Visible = false;
            tsbAyuda.Visible = false;
            tsbImprimir.Visible = false;
            tsbNuevo.Visible = false;
            //Revisa el permiso de seguridad
            //using (GestorUsuario elGestorUsuario = new GestorUsuario())
            //    elGestorUsuario.RevisarSeguridad(Conexion.laConexion.UsuarioLogin, this);
        }

        protected override void guardar()
        {
            DataSet Valores = new DataSet();
            Valores.ReadXml(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + "\\Conexion.xml");

            Valores.Tables[0].Rows[0]["server"] = txbServer.Text;
            Valores.Tables[0].Rows[0]["database"] = txbDB.Text;
            //Valores.Tables[0].Rows[0]["direccionImagenFondo"] = txbImagen.Text;
            Valores.Tables[0].Rows[0]["impresoraFactura"] = txbImpFactura.Text;
            Valores.Tables[0].Rows[0]["numcaja"] = txbCaja.Text;
            Valores.Tables[0].Rows[0]["reporte"] = txbReportes.Text;
            Valores.Tables[0].Rows[0]["puerto"] = txbPuerto.Text;
            Valores.Tables[0].Rows[0]["licencia"] = txbLicencia.Text;

          
            Valores.WriteXml(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6) + "\\Conexion.xml");
            Conexion.laConexion.LeerXML();
            this.Close();
        }

        private void txbImagen_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //DialogResult dr=ofd_Imagen.ShowDialog();
            /*if (ofd_Imagen.ShowDialog() == DialogResult.OK)
            {
                txbImagen.Text = ofd_Imagen.FileName;
            }*/
        }

        

        private void txbReportes_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (fbd_reportes.ShowDialog() == DialogResult.OK)
            {
                txbReportes.Text = fbd_reportes.SelectedPath + "\\";
            }
        }
    }
}
