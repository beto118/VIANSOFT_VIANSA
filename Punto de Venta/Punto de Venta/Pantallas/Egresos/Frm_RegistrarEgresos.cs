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
using Punto_de_Venta.Reportes;

namespace Punto_de_Venta.Pantallas.Egresos
{
    public partial class Frm_RegistrarEgresos : Form
    {

        string modo = "";
        public Frm_RegistrarEgresos()
        {
            InitializeComponent();
            LimpiarCampos();
            cmbEgresoTipo.Text = "";
            cargarCombo();
            
        }

        private void cargarCombo()
        {
            using (ServicioEgresoTipo elServicio = new ServicioEgresoTipo())
                cmbEgresoTipo.DataSource = elServicio.ListarEgresoTipo("");
            cmbEgresoTipo.DisplayMember = "Nombre";
            cmbEgresoTipo.ValueMember = "ID";
        }
        public Frm_RegistrarEgresos(int Caja_numero)
        {
            InitializeComponent();
            cargarCombo();
            CargarDatos(Caja_numero);
            modo = "MOD";
        }

        private void CargarDatos(int Egreso_id)
        {
            DataRow drEgreso = null;
            using (ServicioEgreso elServicio = new ServicioEgreso())
                drEgreso = elServicio.ConsultarEgreso(Egreso_id);
            if (drEgreso != null)
            {
                txbNumero.Text = Egreso_id.ToString();
                cmbEgresoTipo.SelectedValue = drEgreso["egresotipo_id"].ToString();
                txbMonto.Text =string.Format("{0:n1}",double.Parse( drEgreso["egreso_monto"].ToString()));
                txbNota.Text = drEgreso["Egreso_nota"].ToString();
                txbFecha.Text = drEgreso["egreso_fecha"].ToString();
                txbCod_usuario.Text=drEgreso["usuario_codigo"].ToString();
                txbNombre_usuario.Text = drEgreso["usuario_nombre"].ToString();
                ckEstado.Checked = drEgreso["egreso_estado"].ToString().Equals("ACT");
                if (drEgreso["egreso_estado"].ToString().Equals("AUTO"))
                {
                    btnGuardar.Enabled = false;//esto xq los AUTO son los que se generan automaticamente para cuando se agrega una factura de credito o cuando se hace un pago a una factura de credito
                    ckEstado.Checked = true;
                }
                if(!drEgreso["Vent_id"].ToString().Equals("0"))
                    btnGuardar.Enabled = false;//esto xq es un egreso que ya esta en cierre
            }

        }

        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el Egreso?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {

                if (!Validar())
                    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (ckEstado.Checked) estado = "ACT";
                if (modo.Equals("INS"))
                {
                    using (ServicioEgreso elServicio = new ServicioEgreso())
                        respuesta = elServicio.InsertarEgreso(out codigoGenerado,int.Parse(cmbEgresoTipo.SelectedValue.ToString()),double.Parse(txbMonto.Text),txbNota.Text,int.Parse(txbCod_usuario.Text));
                    //MessageBox.Show("El codigo generado es: " + codigoGenerado.ToString());
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        if (MessageBox.Show("¿Desea imprimir el EGRESO?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            //imprimir egreso
                            using (ImprimirTicket elImprimir = new ImprimirTicket())
                                elImprimir.ImprimirEgreso(Conexion.laConexion.ImpresoraFactura,codigoGenerado);
                        }
                        this.Close();
                    }


                }
                else//se va modificar 
                {
                    using (ServicioEgreso elServicio = new ServicioEgreso())
                        respuesta = elServicio.ModificarEgreso(int.Parse(txbNumero.Text), int.Parse(cmbEgresoTipo.SelectedValue.ToString()), double.Parse(txbMonto.Text), txbNota.Text, int.Parse(txbCod_usuario.Text), estado);
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
                if (!elValidar.ValidaVacio(cmbEgresoTipo, elErrorProvider, "Empresa"))
                    malas++;
                if (!elValidar.ValidaDoubleMayorCero(txbMonto, elErrorProvider, "Monto"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void LimpiarCampos()
        {
            txbMonto.Clear();
            txbNumero.Clear();
            txbNota.Clear();
            txbCod_usuario.Text = Principal.elUsuario.Codigo;
            txbNombre_usuario.Text = Principal.elUsuario.Nombre + " " + Principal.elUsuario.Apellido1 ;
            txbFecha.Text = DateTime.Now.ToShortDateString();
            modo = "INS";
            ckEstado.Checked = true;
            btnGuardar.Enabled=true;
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

        private void Frm_RegistrarEgresos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
