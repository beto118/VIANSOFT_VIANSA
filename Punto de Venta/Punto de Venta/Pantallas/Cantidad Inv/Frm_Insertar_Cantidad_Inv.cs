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

namespace Punto_de_Venta.Pantallas.Cantidad_Inv
{
    public partial class Frm_Insertar_Cantidad_Inv : Form
    {
        string modo = "";
        public Frm_Insertar_Cantidad_Inv()
        {
            InitializeComponent();
            modo = "INS";
        }
        public Frm_Insertar_Cantidad_Inv(int CantID)
        {
            InitializeComponent();
            CargarDatos(CantID);
            modo = "MOD";
        }

        private void CargarDatos(int CantID)
        {
            DataRow drCant = null;
            using (ServicioCantidad_Inventario elServicio = new ServicioCantidad_Inventario())
                drCant = elServicio.ConsultarCantidadInv(CantID);
            if (drCant != null)
            {
                txbNumero.Text = CantID.ToString();
                txbNombre.Text = drCant["Cant_Nombre"].ToString();
                txbDetalle.Text = drCant["Cant_Detalle"].ToString();
                txbCantidad.Text = drCant["Cant_Cantidad"].ToString();
                ckEstado.Checked = drCant["Cant_Estado"].ToString().Equals("ACT");
              
            }

        }
        private bool Validar()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbNombre, elErrorProvider, "Nombre"))
                    malas++;
                if (!elValidar.ValidaVacio(txbCantidad, elErrorProvider, "Cantidad"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la Cantidad?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "", estado = "INA";
                int codigoGenerado = 0;
                if (ckEstado.Checked) estado = "ACT";
                if (modo.Equals("INS"))
                {
                    using (ServicioCantidad_Inventario elServicio = new ServicioCantidad_Inventario())
                        respuesta = elServicio.RegistarCantidadInv(out codigoGenerado,txbNombre.Text, txbDetalle.Text, decimal.Parse(txbCantidad.Text) , "ACT");
                    //MessageBox.Show("El codigo generado es: " + codigoGenerado.ToString());
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }


                }
                else//se va modificar 
                {
                    using (ServicioCantidad_Inventario elServicio = new ServicioCantidad_Inventario())
                        respuesta = elServicio.ModificarCatidadInv(int.Parse(txbNumero.Text), txbNombre.Text, txbDetalle.Text, decimal.Parse(txbCantidad.Text),estado);
                    MessageBox.Show(respuesta);

                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    {
                        this.Close();
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
            Hide();
            
        }
        
    }
}
