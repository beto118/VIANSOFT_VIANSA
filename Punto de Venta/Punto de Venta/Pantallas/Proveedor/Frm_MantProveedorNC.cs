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

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_MantProveedorNC : Form
    {

        string modo = "INS";
        int FactProveedor = 0;
        public Frm_MantProveedorNC(int FactIn,string none)
        {
            InitializeComponent();
            FactProveedor = FactIn;
            nuevo();
        }
        public Frm_MantProveedorNC(int codigo)
        {
            InitializeComponent();
            cargarDatos(codigo);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        

        private void cargarDatos(int codigo)
        {
            DataRow drNC = null;
            using (ServicioProveedorNC elGEstor = new ServicioProveedorNC())
                drNC = elGEstor.ConsultarProveedorNC(codigo);
            if (drNC != null)
            {
                modo = "MOD";
                txbID.Text = codigo.ToString();
                txbMonto.Text=string.Format("{0:n1}",double.Parse( drNC["ProveedorNC_monto"].ToString()));
                dpFecha.Value = new DateTime(int.Parse(drNC["ProveedorNC_fecha"].ToString().Substring(0, 4)),
                                                        int.Parse(drNC["ProveedorNC_fecha"].ToString().Substring(4, 2)),
                                                        int.Parse(drNC["ProveedorNC_fecha"].ToString().Substring(6, 2)));
                txbEstado.Text = drNC["ProveedorNC_estado"].ToString();
                txbDetalle.Text = drNC["ProveedorNC_detalle"].ToString();
                txbUsuario.Text = drNC["usuario_codigo"].ToString();
                DataRow drUsuario = null;
                using (ServicioUsuario elServicio = new ServicioUsuario())
                    drUsuario= elServicio.ConsultarUsuarios(int.Parse(txbUsuario.Text));
                txbUsuario_Nombre.Text = drUsuario["usuario_nombre"].ToString() + " " + drUsuario["usuario_apellido1"].ToString();
            }
        }

        private void dpFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbMonto.Focus();
        }

        private void txbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbDetalle.Focus();
        }

        private void txbDetalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                guardar();
        }

        private void guardar()
        {
            elErrorProvider.Clear();
            using (Validacion laValidacion = new Validacion())
            {
                if (!laValidacion.ValidaDoubleMayorCero(txbMonto, elErrorProvider, "Monto"))
                    return;
            }
            string respuesta = "";
            using (ServicioProveedorNC elGestor = new ServicioProveedorNC())
            {
                if (modo.Equals("INS"))
                    respuesta = elGestor.InsertarProveedorNC(FactProveedor, dpFecha.Value.ToShortDateString(), double.Parse(txbMonto.Text), txbDetalle.Text, int.Parse(Principal.elUsuario.Codigo));
                else
                    respuesta = elGestor.ModificarProveedorNC(int.Parse(txbID.Text), dpFecha.Value.ToShortDateString(), double.Parse(txbMonto.Text), txbDetalle.Text);
            }
            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                this.Close();
            else
                MessageBox.Show(respuesta);
        }
        private void eliminar()
        {
            if (MessageBox.Show("Desea Elimnar la Nota de Credito?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioProveedorNC elGestor = new ServicioProveedorNC())
                    respuesta = elGestor.EliminarProveedorNC(int.Parse(txbID.Text));
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    this.Close();
                else
                    MessageBox.Show(respuesta);

            }
        }
        private void nuevo()
        {
            txbMonto.Text = "";
            txbDetalle.Text = "";
            modo = "INS";
            dpFecha.Value=DateTime.Now;
            txbUsuario.Text = Principal.elUsuario.Codigo;
            txbUsuario_Nombre.Text = Principal.elUsuario.Nombre + " " + Principal.elUsuario.Apellido1;
        }
    }
}
