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

namespace Punto_de_Venta.Pantallas.Usuarios
{
    public partial class Frm_RegistroHoras : Form
    {
       
        public Frm_RegistroHoras()
        {
            InitializeComponent();
        }
        public Frm_RegistroHoras(string Usuario_codigo)
        {
            InitializeComponent();
            //CargarDatos(Usuario_codigo);
            txbCodigo.Text = Usuario_codigo;
            consultarUsuario();
            
        }
        //private void timer1_Tick(object sender, EventArgs e)
        //{

        //    this.lblHoraActual.Text = String.Format(DateTime.Now.ToString(), "hh:mm:ss");
          
        //}

        private void txbCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                consultarUsuario();
            }
        }
        private void consultarUsuario()
        {
            
                int usuario_codigo;

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

                    //consultamos el estado del vendedor
                    int estado;
                    DataRow drVendedor = null;
                    using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                        drVendedor = elServicio.ConsultarDiaEspera(int.Parse(txbCodigo.Text));
                    if (drVendedor != null)
                    {
                        usuario_codigo = int.Parse(txbCodigo.Text);
                        estado = int.Parse(drVendedor["Tiene"].ToString());

                        if (estado == 1)
                        {
                            btnSalida.Visible = true;
                            btnEntrada.Visible = false;
                            btnSalida.Focus();
                        }
                        else
                        {
                            btnEntrada.Visible = true;
                            btnSalida.Visible = false;
                            btnEntrada.Focus();
                        }
                    }


                }

                else
                {
                    MessageBox.Show("El usuario no se encontro!", "Error de Usuario");
                    txbCodigo.Clear();
                    txbNombre.Clear();
                    btnEntrada.Visible = false;
                    btnSalida.Visible = false;
                    txbCodigo.Focus();
                }

            
        }
        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la hora de entrada?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "";
               // int codigoGenerado = 0;

                using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                       respuesta = elServicio.InsertarEntradaDiaTrabajo(int.Parse(txbCodigo.Text));
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }
                           
            }
        }
        private bool Validar()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaDoubleMayorCero(txbCodigo, elErrorProvider, "Codigo"))
                    malas++;
                if (!elValidar.ValidaVacio(txbNombre, elErrorProvider, "Nombre"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la hora de Salida?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "";
                string respuestaInt = "";
  
                using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                    respuesta = elServicio.RegistrarSalida(int.Parse(txbCodigo.Text), out respuestaInt);
                MessageBox.Show(respuesta);

                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    this.Close();
                }
                
            }
        }

    }
}
