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

namespace Punto_de_Venta.Pantallas.Varias
{
    public partial class Frm_Control : Form
    {
        public Frm_Control()
        {
            InitializeComponent();
            CargarDatos();
        }
        //public Frm_Control(string Control_NombreEmpresa )
        //{
        //    InitializeComponent();
        //    CargarDatos(Control_NombreEmpresa);
        //}

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
                if (!elValidar.ValidaDoubleMayorCero(txbDolar, elErrorProvider, "Tipo Cambio"))
                    return;
            if (MessageBox.Show("Desea guardar el Control?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                string respuesta = "";
                using (ServicioControl elControl = new ServicioControl())

                    respuesta = elControl.ModificarControl(txbEmpresa.Text, txbPropietario.Text, txbCedula.Text, txbTelefono.Text, txbDireccion.Text, txbMsjFinal.Text,double.Parse( txbDolar.Text));

                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    this.Close();
                }
            }
            
        }
        private void CargarDatos()
        {
            DataRow drControl = null;
            using (ServicioControl elControl = new ServicioControl())
                drControl = elControl.ConsultarControl();
            //if (drControl != null)
            //{
            txbEmpresa.Text = drControl["Control_NombreEmpresa"].ToString();
            txbPropietario.Text = drControl["Control_Propietario"].ToString();
            txbCedula.Text = drControl["Control_Cedula"].ToString();
            txbTelefono.Text = drControl["Control_telefono"].ToString();
            txbDireccion.Text = drControl["Control_Direccion"].ToString();
            txbMsjFinal.Text = drControl["Control_Mensaje"].ToString();
            txbDolar.Text = string.Format("{0:n2}",double.Parse( drControl["Control_TipoCambio"].ToString()));
            //}
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Control_Load(object sender, EventArgs e)
        {
            //CargarDatos(txbEmpresa.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txbEmpresa.Enabled = true;
            txbPropietario.Enabled = true;
            txbCedula.Enabled = true;
            txbTelefono.Enabled = true;
            txbDireccion.Enabled = true;
            txbMsjFinal.Enabled = true;
            txbDolar.Enabled = true;


        }

    }
}
