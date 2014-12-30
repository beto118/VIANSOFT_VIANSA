using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using Componentes.Sistemas.Clases;

namespace Punto_de_Venta
{
    public partial class RegistrarUsuario : Form
    {
        string modo = "";
        public RegistrarUsuario()
        {
            InitializeComponent();
            LimpiarCampos();
        }
        public RegistrarUsuario(int Usuario_codigo)
        {
            InitializeComponent();
            CargarDatos(Usuario_codigo);
            modo = "MOD";
        }
        private void CargarDatos(int Usuario_codigo)
        {
            DataRow drUsuario = null;
            using (ServicioUsuario elServicio = new ServicioUsuario())
                drUsuario = elServicio.ConsultarUsuarios(Usuario_codigo);
            if (drUsuario != null)
            {
                txbCodigo.Text = Usuario_codigo.ToString();
                txbNombre.Text = drUsuario["Usuario_nombre"].ToString();
                txbApellido1.Text = drUsuario["Usuario_apellido1"].ToString();
                txbApellido2.Text = drUsuario["Usuario_apellido2"].ToString();
                txbTelefono.Text = drUsuario["Usuario_telefono"].ToString();
                txbDireccion.Text = drUsuario["Usuario_direccion"].ToString();
                //txbGanaXhora.Text = drUsuario["Usuario_contraseña"].ToString();
                txbTelefono.Text = drUsuario["Usuario_telefono"].ToString();
                ckEstado.Checked = drUsuario["Usuario_estado"].ToString().Equals("ACT");
                
                if (drUsuario["Usuario_tipoUsuario"].ToString().Equals("Administrador"))
                    rbtnAdmin.Checked = true;
                else if (drUsuario["Usuario_tipoUsuario"].ToString().Equals("Autorizado"))
                    rbtnAutorizado.Checked = true;
                else if (drUsuario["Usuario_tipoUsuario"].ToString().Equals("Regular"))
                    rbtnRegular.Checked = true;

                txbCodigoBarra.Text = drUsuario["Usuario_CodigoBarra"].ToString();
                txbGanaXhora.Text = drUsuario["Usuario_GanaXhora"].ToString();

            }

        }
        #region KEY PRESS

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbNombre.Focus();
            }
        }

        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbApellido1.Focus();
            }
        }

        private void txbApellido1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbApellido2.Focus();
            }
        }

        private void txbApellido2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbTelefono.Focus();
            }
        }

        private void txbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbDireccion.Focus();
            }
        }

        private void txbDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbClave.Focus();
            }
        }

        private void maskTxbContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.rbtnRegular.Focus();
            }
        }
        #endregion 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el Usuario?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (ckEstado.Checked) estado = "ACT";
                string tipo = "";
                if (rbtnAdmin.Checked == true)
                    tipo = rbtnAdmin.Text;
                else if (rbtnAutorizado.Checked == true)
                    tipo = rbtnAutorizado.Text;
                else if (rbtnRegular.Checked == true)
                    tipo = rbtnRegular.Text;
                if (modo.Equals("INS"))
                using (ServicioUsuario elServicio = new ServicioUsuario())
                        respuesta = elServicio.InsertarUsuarios(out codigoGenerado, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, txbTelefono.Text, txbDireccion.Text, txbClave.Text, tipo, "ACT", txbCodigoBarra.Text, double.Parse(txbGanaXhora.Text));
                else
                     using (ServicioUsuario elServicio = new ServicioUsuario())
                         respuesta = elServicio.ModificarUsuarios(int.Parse(txbCodigo.Text), txbNombre.Text, txbApellido1.Text, txbApellido2.Text, txbTelefono.Text, txbDireccion.Text, txbClave.Text, tipo, estado, txbCodigoBarra.Text, double.Parse(txbGanaXhora.Text));
                            
                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    this.Close();
                
               
            }
        }
        private bool Validar()
        {
            int malas=0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbNombre, elErrorProvider, "Nombre de Usuario"))
                    malas++;
                 if (!elValidar.ValidaVacio(txbApellido1, elErrorProvider, "apellido1 del Usuario"))
                    malas++;
                if (!elValidar.ValidaVacio(txbApellido2, elErrorProvider, "apellido2 del Usuario"))
                    malas++;
                if (!elValidar.ValidaVacio(txbTelefono, elErrorProvider, "telefono del Usuario"))
                    malas++;
                if (!elValidar.ValidaVacio(txbDireccion, elErrorProvider, "direccion del Usuario"))
                    malas++;
                if (!elValidar.ValidaVacio(txbGanaXhora, elErrorProvider, "Monto que gana el Usuario"))
                    malas++;
                if (modo.Equals("INS"))
                    if (!elValidar.ValidaVacio(txbClave, elErrorProvider, "contraseña del Usuario"))
                        malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void LimpiarCampos()
        {
            txbCodigo.Clear();
            txbNombre.Clear();
            txbApellido1.Clear();
            txbApellido2.Clear();
            txbTelefono.Clear();
            txbDireccion.Clear();
            txbClave.Clear();
            txbCodigoBarra.Clear();
            txbGanaXhora.Text = "0.0";
            modo = "INS";
            ckEstado.Checked = true;
            rbtnRegular.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

              
    }
}
