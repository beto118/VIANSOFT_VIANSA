using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Logica_de_Negocio;

namespace Punto_de_Venta.Pantallas.Varias
{
    public partial class Frm_Login : Form
    {
        bool loginCorrecto = false;
        bool establecerUsuario = true;
        int usuario_codigo = 0;
        public Frm_Login()
        {
            InitializeComponent();
        }
        public bool LoginCorrecto
        { get { return loginCorrecto; } }
        public bool EstablecerUsuario
        {
            set { establecerUsuario = value; }
            get { return establecerUsuario; }
        }


        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            elErrorProvider.Clear();
            using(Validacion laValidacion=new Validacion())
            {
                if (!laValidacion.ValidaVacio(txbCodigo, elErrorProvider, "Usuario"))
                    return;
                if (!laValidacion.ValidaVacio(txbNombre, elErrorProvider, "Usuario"))
                    return;
                if (!laValidacion.ValidaVacio(txbClave, elErrorProvider, "Contraseña"))
                    return;
            
            
            }
            int respuestaInt = -1;
            string respuesta = "";
            using (ServicioUsuario elServicio = new ServicioUsuario())
                respuesta = elServicio.RevisarLogin(out respuestaInt, usuario_codigo, txbClave.Text);
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
            {
                switch (respuestaInt)
                {
                    case -1: MessageBox.Show("Error de Conexion!", "Error...");
                        break;
                    case 0: MessageBox.Show("Error en la Clave!", "Error...");
                        txbClave.Text = "";
                        txbClave.SelectAll();
                        break;
                    case 1: //esta bien el login
                        loginCorrecto = true;
                        if (establecerUsuario)
                        {
                            Principal.elUsuario.Codigo = usuario_codigo.ToString();
                            DataRow drUsuario = null;
                            //Datos usuario
                            using (ServicioUsuario elServicio = new ServicioUsuario())
                                drUsuario = elServicio.ConsultarUsuarios(int.Parse(txbCodigo.Text));
                            if (drUsuario != null)
                            {
                                Principal.elUsuario.Codigo = txbCodigo.Text;
                                Principal.elUsuario.Nombre = drUsuario["usuario_nombre"].ToString();
                                Principal.elUsuario.Apellido1 = drUsuario["usuario_apellido1"].ToString();
                                Principal.elUsuario.Apellido2 = drUsuario["usuario_apellido2"].ToString();
                                Principal.elUsuario.TipoUsuario = drUsuario["usuario_tipoUsuario"].ToString();

                            }
                        }
                        else {
                            DataRow drUsuario = null;
                            //Datos usuario
                            using (ServicioUsuario elServicio = new ServicioUsuario())
                                drUsuario = elServicio.ConsultarUsuarios(int.Parse(txbCodigo.Text));
                            if (drUsuario != null)
                            {
                                loginCorrecto = drUsuario["usuario_tipoUsuario"].ToString().ToUpper().Equals("ADMINISTRADOR");

                            }
                        }
                        this.Close();
                        break;
                    case 2: MessageBox.Show("Usuario Inactivo!", "Error...");
                        break;
                }
            }
            else
                MessageBox.Show(respuesta);

        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            txbCodigo.SelectAll();
        }

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                 elErrorProvider.Clear();
                 using (Validacion laValidacion = new Validacion())
                 {
                     if (!laValidacion.ValidaIntMayorCero(txbCodigo, elErrorProvider, "Usuario"))
                         return;
                 }
                 DataRow drUsuario = null;
                 using (ServicioUsuario elServicio = new ServicioUsuario())
                     drUsuario = elServicio.ConsultarUsuarios(int.Parse(txbCodigo.Text));
                 if (drUsuario != null)
                 {
                     usuario_codigo = int.Parse(txbCodigo.Text);
                     txbNombre.Text = drUsuario["usuario_nombre"].ToString() + " " + drUsuario["usuario_apellido1"].ToString() + " " + drUsuario["usuario_apellido2"].ToString();
                     txbClave.Focus();
                 }
                 else
                 {
                     MessageBox.Show("El usuario no se encontro!","Error de Usuario");
                 }

            }
        }

        private void txbClave_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAceptar_Click(null, null);
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            frmModificarConexion elfrm = new frmModificarConexion();
            elfrm.ShowDialog();
        }
    }
}
