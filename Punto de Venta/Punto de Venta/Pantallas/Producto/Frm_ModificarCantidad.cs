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

namespace Punto_de_Venta.Pantallas.Producto
{
    public partial class Frm_ModificarCantidad : Form
    {
        public Frm_ModificarCantidad(int Producto_Codigo)
        {
            InitializeComponent();
            CargarDatos(Producto_Codigo);
        }

        private void Frm_ModificarCantidad_Load(object sender, EventArgs e)
        {

        }
        private void CargarDatos(int Producto_Codigo)
        {
            DataRow drProducto = null;
            using (ServicioProductos elServicio = new ServicioProductos())
                drProducto = elServicio.ConsultarProductos(Producto_Codigo);
            if (drProducto != null)
            {
                txbCodigo.Text = Producto_Codigo.ToString();
                txbNombre.Text = drProducto["producto_nombre"].ToString() + " (" + drProducto["Producto_detalle"].ToString() + ")"; 
                txbCodBarra.Text = drProducto["producto_codigoBarra"].ToString();
                txbCantidadExistente.Text = drProducto["Cantidad"].ToString();
                txbCantidad_ID.Text = drProducto["Cant_Id"].ToString();
                txbNuevaCantidad.SelectAll();
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar la cantidad del Producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "";
                    using (ServicioProductos elServicio = new ServicioProductos())
                        respuesta = elServicio.ModificarCantidadProductos(int.Parse(txbCodigo.Text), double.Parse(txbNuevaCantidad.Text));
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
               //if (!elValidar.ValidaDoubleMayorIgualCero(txbNuevaCantidad, elErrorProvider, "Cantidad"))
               //     malas++;
                
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private void sumaCantidades()
        {
           
            double CantiExistente = 0;
            double NuevaCanti = 0;
            double total = 0;
            CantiExistente = double.Parse(txbCantidadExistente.Text);
            if (txbNuevaCantidad.Text.Equals(""))
            {
                NuevaCanti = 0;
            }
            else
            {
                NuevaCanti = double.Parse(txbNuevaCantidad.Text);
            }
                    
            total = CantiExistente + NuevaCanti;
            lblTotal.Text = string.Format("{0:n1}", total);
            
            
        }

        private void txbNuevaCantidad_TextChanged(object sender, EventArgs e)
        {
            try
            {              
                sumaCantidades();
            }
            catch
            {
                MessageBox.Show("Error en el calculo del total, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txbNuevaCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                btnAceptar.Focus();
        }

             
    }
}
