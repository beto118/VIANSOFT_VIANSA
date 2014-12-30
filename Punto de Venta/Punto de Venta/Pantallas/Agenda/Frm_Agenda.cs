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

namespace Punto_de_Venta.Pantallas.Agenda
{
    public partial class Frm_Agenda : Form
    {
        string modo = "";
        public Frm_Agenda()
        {
            InitializeComponent();
            LimpiarCampos();
        }
        public Frm_Agenda(int AgendaID)
        {
            InitializeComponent();
            CargarDatos(AgendaID);
            modo = "MOD";
        }
        private void LimpiarCampos()
        {
            txbCodigo.Clear();
            txbNombre.Clear();
            txbApellido1.Clear();
            txbApellido2.Clear();
            txbTel1.Clear();
            txbTel2.Clear();
            txbDireccion.Clear();
            txbCorreo.Clear();
            txbDetalle.Clear();
            txbCel1.Clear();
            txbCel2.Clear();
            modo = "INS";
            ckEstado.Checked = true;
            txbApodo.Clear();
        }
        private void CargarDatos(int Agenda_ID)
        {
            DataRow drAgenda = null;
            using (ServicioAgenda elServicio = new ServicioAgenda())
                drAgenda = elServicio.ConsultarAgenda(Agenda_ID);
            if (drAgenda != null)
            {
                txbCodigo.Text = Agenda_ID.ToString();
                txbNombre.Text = drAgenda["Agenda_Nombre"].ToString();
                txbApellido1.Text = drAgenda["Agenda_Apellido1"].ToString();
                txbApellido2.Text = drAgenda["Agenda_Apellido2"].ToString();
                txbApodo.Text = drAgenda["Agenda_Apodo"].ToString();
                txbTel1.Text = drAgenda["Agenda_Tel1"].ToString();
                txbTel2.Text = drAgenda["Agenda_Tel2"].ToString();
                txbCel1.Text = drAgenda["Agenda_Cel1"].ToString();
                txbCel2.Text = drAgenda["Agenda_Cel2"].ToString();
                txbDireccion.Text = drAgenda["Agenda_Direccion"].ToString();
                txbCorreo.Text = drAgenda["Agenda_Correo"].ToString();
                txbDetalle.Text = drAgenda["Agenda_Detalle"].ToString();
                ckEstado.Checked = drAgenda["Agenda_Estado"].ToString().Equals("ACT");

            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar LA PERSONA?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                //if (!Validar())
                //    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (ckEstado.Checked) estado = "ACT";
                string tipo = "";
                if (modo.Equals("INS"))
                    using (ServicioAgenda elServicio = new ServicioAgenda())
                        respuesta = elServicio.InsertarAgenda(out codigoGenerado, txbNombre.Text, txbApellido1.Text, txbApellido2.Text, txbApodo.Text, txbTel1.Text, txbTel2.Text, txbCel1.Text, txbCel2.Text, txbDireccion.Text, txbCorreo.Text, txbDetalle.Text, estado);
                else
                    using (ServicioAgenda elServicio = new ServicioAgenda())
                        respuesta = elServicio.ModificarAgenda(int.Parse(txbCodigo.Text), txbNombre.Text, txbApellido1.Text, txbApellido2.Text, txbApodo.Text, txbTel1.Text, txbTel2.Text, txbCel1.Text, txbCel2.Text, txbDireccion.Text, txbCorreo.Text, txbDetalle.Text, estado);

                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    this.Close();

            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
