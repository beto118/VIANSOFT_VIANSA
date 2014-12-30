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

namespace Punto_de_Venta.Pantallas.CategoriaProducto
{
    public partial class frm_RegistrarCategoria : Form
    {
        
         string modo = "";
        public frm_RegistrarCategoria()
        {
            InitializeComponent();
            LimpiarCampos();
        }
        public frm_RegistrarCategoria(int CategoriaId)
        {
            InitializeComponent();
            CargarDatos(CategoriaId);
            modo = "MOD";
        }

        private void CargarDatos(int Categoria_id)
        {
            DataRow drCaja = null;
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                drCaja = elServicio.ConsultarCategoria(Categoria_id);
            if (drCaja != null)
            {
                txbNumero.Text = Categoria_id.ToString();
                txbDetalle.Text = drCaja["categoria_nombre"].ToString();
                ckEstado.Checked = drCaja["Categoria_estado"].ToString().Equals("ACT");
                ckListado.Checked = drCaja["Categoria_listado"].ToString().Equals("S");
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
            if (MessageBox.Show("Desea guardar la Categoria?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (ckEstado.Checked) estado = "ACT";
                if (modo.Equals("INS"))
                {
                    using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                        respuesta = elServicio.RegistarCategoria(out codigoGenerado,txbDetalle.Text, "ACT",ckListado.Checked?"S":"N");
                    //MessageBox.Show("El codigo generado es: " + codigoGenerado.ToString());
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }


                }
                else//se va modificar 
                {
                    using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                        respuesta = elServicio.ModificarCategoria(int.Parse(txbNumero.Text), txbDetalle.Text, estado, ckListado.Checked ? "S" : "N");
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
