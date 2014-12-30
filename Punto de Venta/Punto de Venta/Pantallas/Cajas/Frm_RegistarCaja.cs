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

namespace Punto_de_Venta.Pantallas.Cajas
{
    public partial class Frm_RegistarCaja : Form
    {
        string modo = "";
        public Frm_RegistarCaja()
        {
            InitializeComponent();
            LimpiarCampos();
        }
        public Frm_RegistarCaja(int Caja_numero)
        {
            InitializeComponent();
            CargarDatos(Caja_numero);
            modo = "MOD";
        }

        private void CargarDatos(int Caja_numero)
        {
            DataRow drCaja = null;
            using (ServicioCajas elServicio = new ServicioCajas())
                drCaja = elServicio.ConsultarCajas(Caja_numero);
            if (drCaja != null)
            {
                txbNumero.Text = Caja_numero.ToString();
                txbDetalle.Text = drCaja["Caja_detalle"].ToString();
                ckEstado.Checked = drCaja["Caja_estado"].ToString().Equals("ACT");
            }

        }

        private void txbDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.btnGuardar.Focus();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la Caja?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (ckEstado.Checked) estado = "ACT";
                if (modo.Equals("INS"))
                {
                    using (ServicioCajas elServicio = new ServicioCajas())
                        respuesta = elServicio.RegistarCajas(out codigoGenerado,txbDetalle.Text, "ACT");
                    MessageBox.Show("El codigo generado es: " + codigoGenerado.ToString());
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }


                }
                else//se va modificar 
                {
                    using (ServicioCajas elServicio = new ServicioCajas())
                        respuesta = elServicio.ModificarCajas(int.Parse(txbNumero.Text), txbDetalle.Text, estado);
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }
                }
            }
        }
        private bool Validar()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbDetalle, elErrorProvider, "Detalle de la caja"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void LimpiarCampos()
        {
            txbDetalle.Clear();
            modo = "INS";
            ckEstado.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
