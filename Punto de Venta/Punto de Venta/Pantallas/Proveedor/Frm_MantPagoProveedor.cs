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

namespace Punto_de_Venta.Pantallas.Proveedor
{
    public partial class Frm_MantPagoProveedor : Form
    {
       
        int FactProveedor_id = 0;
        public Frm_MantPagoProveedor(string Saldo, int fact)
        {
            InitializeComponent();
            txbSaldo.Text = Saldo;
            FactProveedor_id = fact;
            
        
            dpFecha.Value = DateTime.Now;
            txbAbono.Select();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        
        

       
        private void guardar()
        {
            using (Validacion laValidacion = new Validacion())
            {
                if (!laValidacion.ValidaDoubleEntre(1, double.Parse(txbSaldo.Text), txbAbono, elErrorProvider, "Abono"))
                    return;
            }
            string respuesta = "";
            using (ServicioFactProveedor elGestor = new ServicioFactProveedor())
                respuesta = elGestor.RealizarPagoDeFactura(FactProveedor_id, double.Parse(txbAbono.Text), dpFecha.Value.ToShortDateString(), txbDetalle.Text, int.Parse(Principal.elUsuario.Codigo));
            if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                MessageBox.Show(respuesta, "Error...");
            else
                this.Close();
        }

        private void txbAbono_TextChanged(object sender, EventArgs e)
        {
            txbAbono.BackColor = Color.White;
            try {
                txbSaldoNuevo.Text = string.Format("{0:N1}", double.Parse(txbSaldo.Text) - double.Parse(txbAbono.Text));
            }
            catch { txbAbono.BackColor = Color.Red;
            txbSaldoNuevo.Text = "0";
            }
        }

        private void txbAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbDetalle.Select();
        }
    }
}
