using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Clases;
using System.IO;
using Componentes.Sistemas.Clases;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Pantallas.CategoriaProducto;
using Punto_de_Venta.Pantallas.Cantidad_Inv;
using Punto_de_Venta.Pantallas.Producto;

namespace Punto_de_Venta
{
    public partial class IngresarProducto : Form
    {
        string CodBarra = "";
        string modo = "";
        int Cargo = 0;
        public IngresarProducto()
        {
            InitializeComponent();
            CargarComboCategoria();
            //BuscarProductoLigado();
            LimpiarCampos();

        }
        public IngresarProducto(int Producto_Codigo)
        {
            InitializeComponent();
            CargarComboCategoria();
            
            CargarDatos(Producto_Codigo);
            //BuscarProductoLigado();
            modo = "MOD";
        }

        private void CargarComboCategoria()
        {
            using (ServicioCategoriaProducto elServicio = new ServicioCategoriaProducto())
                cmbCategoria.DataSource = elServicio.ListarCategoria("", "ACT");
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "ID";
            cmbCategoria.SelectedIndex = -1;
        }

        private void BuscarProductoLigado()
        {
            DataRow drProducto = null;
            using (ServicioProductos elServicio = new ServicioProductos())
                drProducto = elServicio.ConsultarProductos(int.Parse(txbIDProductoLigado.Text));
            if (drProducto != null)
            {

                txbNomProdLigado.Text = drProducto["Producto_nombre"].ToString() + " " + drProducto["Producto_detalle"].ToString();
                txbCantidad.Text = drProducto["Cantidad"].ToString();
                txbPrecioCosto.Text = String.Format("{0:N2}", double.Parse(drProducto["Producto_PrecioCosto"].ToString()));
            }
        }
        private void CargarDatos(int Producto_Codigo)
        {
            DataRow drProducto=null;
            using (ServicioProductos elServicio = new ServicioProductos())
                drProducto = elServicio.ConsultarProductos(Producto_Codigo);
            if (drProducto != null)
            {
                txbCodigo.Text = Producto_Codigo.ToString();
                txbNombre.Text = drProducto["producto_nombre"].ToString();
                txbDetalle.Text = drProducto["producto_detalle"].ToString();
                txbCodBarra.Text = drProducto["producto_codigoBarra"].ToString();

                if (double.Parse(drProducto["Producto_PrecioGravado"].ToString()) == -1)
                    ckPrecioIndefinido.Checked = true;
                //else

                
                //cmb_ID_ProdLigado.SelectedValue = drProducto["Cant_Id"].ToString();
                txbIDProductoLigado.Text = drProducto["Cant_Id"].ToString();
                txbCantidad.Text = drProducto["Cantidad"].ToString();

                txbCantidaMinima.Text = drProducto["producto_cantidadMinima"].ToString();
                cmbListado.Text = drProducto["producto_Listado"].ToString();
                ckEstado.Checked = drProducto["producto_estado"].ToString().Equals("ACT");
                ckGravado.Checked = drProducto["producto_gravado"].ToString().Equals("S");
                cmbCategoria.SelectedValue = drProducto["categoria_id"].ToString();
                if (int.Parse(drProducto["Producto_Ligado"].ToString()) == 1)
                {
                    txbIDProductoLigado.Text = drProducto["Cant_Id"].ToString();
                    chkLigar.Checked = true;
                    BuscarProductoLigado();
                }
                else  txbPrecioCosto.Text = String.Format("{0:N5}", double.Parse(drProducto["Producto_PrecioCosto"].ToString()));

                txbValorUtr.Text = String.Format("{0:N5}", double.Parse(drProducto["Producto_valorUnitario"].ToString()));
                txbPrecioGravado.Text = String.Format("{0:N5}", double.Parse(drProducto["Producto_PrecioGravado"].ToString()));
                CodBarra = txbCodBarra.Text;               
               // txbUtilidad.Text = String.Format("{0:N5}", double.Parse(drProducto["Producto_Utilidad"].ToString()));
               // txbUtilidadPorcent.Value = (int)double.Parse(drProducto["Producto_UtilidadPorcentaje"].ToString()) * 1; 
            }

        }
        private void txbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbDetalle.Focus();
            }
        }

        private void txbDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbCodBarra.Focus();
            }
        }
        private void txbCodBarra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txbValorUtr.Focus();
                               
            }
        }

        private void txbValorUtr_KeyPress(object sender, KeyPressEventArgs e)
       {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.txbCantidad.Focus();
            }
        }
        private void txbCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                this.btnAceptar.Focus();
            }
        }
        private void ValidarCodBarra()
        {
            DataRow elProducto = null;

            using (ServicioProductos elServicio = new ServicioProductos())
                elProducto = elServicio.ConsultarProductosXCodBarra(txbCodBarra.Text);
            string codBarra = txbCodBarra.Text;
            if (modo == "MOD")
            {
                

            }
            else
            {
                if (elProducto != null)
                {
                    if (MessageBox.Show("Ya existe un producto registrado con este codigo Barra, Desea Salir?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.Yes)
                    {
                        LimpiarCampos();
                        this.Close();
                    }
                    else
                    {
                        txbCodBarra.Focus();
                        txbCodBarra.Clear();
                    }
                }
                else
                    this.txbValorUtr.Focus();
            }

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if (MessageBox.Show("Desea guardar el Producto?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    // ValidarCodBarra();
                    if (!Validar())
                        return;
                    int Ligar = 0;

                    string respuesta = "", estado = "INA", gravado = "N";
                    int codigoGenerado = 0, ProductoPrecioDefinido = 0;
                    if (chkLigar.Checked) Ligar = 1;
                    if (ckEstado.Checked) estado = "ACT";
                    if (ckGravado.Checked) gravado = "S";

                    double valorUnitario = 0;
                    double PrecioGravado = 0;
                    if (ckPrecioIndefinido.Checked)
                    {
                        valorUnitario = 0;
                        PrecioGravado = 0;
                       ProductoPrecioDefinido=1;
                    }
                    else
                    {
                        valorUnitario = double.Parse(txbValorUtr.Text);
                        PrecioGravado = double.Parse(txbPrecioGravado.Text);
                        ProductoPrecioDefinido = 0;
                    }
                    if (modo.Equals("INS"))
                    {
                        
                        using (ServicioProductos elServicio = new ServicioProductos())
                            respuesta = elServicio.InsertarProductos(out codigoGenerado, txbNombre.Text, txbDetalle.Text, txbCodBarra.Text, valorUnitario, PrecioGravado, int.Parse(txbIDProductoLigado.Text), "ACT", cmbListado.Text, gravado, int.Parse(txbCantidaMinima.Text), int.Parse(cmbCategoria.SelectedValue.ToString()), Ligar, double.Parse(txbCantidad.Text),double.Parse(txbPrecioCosto.Text),double.Parse(txbUtilidad.Text),double.Parse(txbUtilidadPorcent.Value.ToString()),ProductoPrecioDefinido);

                        MessageBox.Show(respuesta + "\n" + "\n" + "El codigo del producto registrado es: " + codigoGenerado.ToString());

                        if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        {
                            this.Close();
                        }

                    }
                    else//se va modificar 
                    {
                            using (ServicioProductos elServicio = new ServicioProductos())
                                respuesta = elServicio.ModificarProductos(int.Parse(txbCodigo.Text), txbNombre.Text, txbDetalle.Text, txbCodBarra.Text, valorUnitario, PrecioGravado, int.Parse(txbIDProductoLigado.Text), estado, cmbListado.Text, gravado, int.Parse(txbCantidaMinima.Text), int.Parse(cmbCategoria.SelectedValue.ToString()), Ligar, double.Parse(txbCantidad.Text), double.Parse(txbPrecioCosto.Text), double.Parse(txbUtilidad.Text), double.Parse(txbUtilidadPorcent.Value.ToString()),ProductoPrecioDefinido);
                            MessageBox.Show(respuesta);

                            if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                            {
                                this.Close();
                            }
                        

                        
                     }


                    }
                }
            catch
            {
                MessageBox.Show("Error al igredar o modificar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            
        }
        
        private bool Validar()
        {
            int malas=0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbNombre, elErrorProvider, "Nombre de Producto"))
                    malas++;
                //if (!elValidar.ValidaVacio(txbDetalle, elErrorProvider, "Descripcion del Producto"))
                //    malas++;
                //if (!elValidar.ValidaVacio(cmbListado, elErrorProvider, "Listado del Producto"))
                //    malas++;
                if (!elValidar.ValidaVacio(cmbCategoria, elErrorProvider, "Categoria Producto"))
                    malas++;
                if (ckPrecioIndefinido.Checked == false)
                {
                    if (!elValidar.ValidaDoubleMayorCero(txbValorUtr, elErrorProvider, "Precio Unitario"))
                        malas++;
                }
                if (!elValidar.ValidaDoubleMayorIgualCero(txbCantidaMinima, elErrorProvider, "Cantidad Minima"))
                    malas++;

                if (!elValidar.ValidaVacio(txbCantidad, elErrorProvider, "Cantidad"))
                    malas++;

               if(!ckPrecioIndefinido.Checked)
                 if (!elValidar.ValidaVacio(txbValorUtr, elErrorProvider, "Valor unitario del Producto"))
                    malas++;

                if(!ckPrecioIndefinido.Checked)
                    if (!elValidar.ValidaDoubleMayorIgualCero(txbIDProductoLigado, elErrorProvider, "Codigo Producto Ligado"))
                        malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txbCodigo.Clear();
            txbNombre.Clear();
            txbDetalle.Clear();
            txbCodBarra.Clear();
            txbValorUtr.Clear();
            txbPrecioGravado.Clear();
            txbCantidad.Clear();
            modo = "INS";
            ckEstado.Checked = true;
            ckPrecioIndefinido.Checked = false;
            txbCantidad.Text = "0";
            txbCantidaMinima.Text = "0";
            cmbCategoria.SelectedIndex = -1;
            cmb_ID_ProdLigado.SelectedIndex = -1;
            cmbListado.Text = "NINGUNO";
            txbCodigo.Focus();
        }

        private void ckPrecioIndefinido_CheckedChanged(object sender, EventArgs e)
        {
            if (ckPrecioIndefinido.Checked)
            {
                txbPrecioCosto.Text = "0";
                txbValorUtr.Text = "0";
                txbPrecioGravado.Text = "0";
                txbValorUtr.Enabled = false;
                calcularUtilidad();
            }
            else
            {
                txbPrecioCosto.Text = "0";
                txbValorUtr.Text = "0";
                txbPrecioGravado.Text = "0";
                txbValorUtr.Enabled = true;
                txbPrecioCosto.Focus();
                calcularUtilidad();
            }
        }

       

        private void btnNuevaCategoria_Click(object sender, EventArgs e)
        {
            frm_RegistrarCategoria elIngresar = new frm_RegistrarCategoria();
            elIngresar.ShowDialog();
            CargarComboCategoria();
        }

        private void ckGravado_CheckedChanged(object sender, EventArgs e)
        {
            calcularPrecioGravado();
            calcularUtilidad();
        }

        private void calcularPrecioGravado()
        {
            if (ckPrecioIndefinido.Checked==false)
            {
                if (ckGravado.Checked == true)
                {
                    double precioUnitario = 0, precioGravado = 0;

                    if (txbValorUtr.Text == "") precioUnitario = 0;
                    else precioUnitario = double.Parse(txbValorUtr.Text);

                    


                    precioGravado = (precioUnitario / 1.13);

                    precioGravado = Math.Round(precioGravado, 5);
                    txbPrecioGravado.Text = precioGravado.ToString();


                }
                else
                {
                    txbPrecioGravado.Text = txbValorUtr.Text;
                }
            }
        }

        private void txbValorUtr_TextChanged(object sender, EventArgs e)
        {
            calcularPrecioGravado();
            calcularUtilidad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Frm_ListarProductos forma7 = new Frm_ListarProductos("SELECCIONAR");
                string codigo = forma7.SeleccionarCodigo();
                if (codigo.Length != 0)
                {
                    txbIDProductoLigado.Text = codigo;
                    BuscarProductoLigado();
                }
            }

            catch
            {
                MessageBox.Show("Error al seleccionar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void cmbCantidadInv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Cargo == 1)
            {
                int cantidad_Id = 0;
                cantidad_Id = int.Parse(cmb_ID_ProdLigado.SelectedValue.ToString());
                //
                DataRow drCantidad = null;
                using (ServicioCantidad_Inventario elServicio = new ServicioCantidad_Inventario())
                     drCantidad = elServicio.ConsultarCantidadInv(int.Parse(cmb_ID_ProdLigado.SelectedValue.ToString()));
                    if (drCantidad != null)
                    {
                        txbCantidad.Text = drCantidad["Cant_Cantidad"].ToString();
                    }
 
            }
            

        }

        private void chkLigar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkLigar.Checked == true)
            {
                cmb_ID_ProdLigado.Enabled = true;
                btnListarProd.Enabled = true;
                //txbIDProductoLigado.Text = "";
            }
            else
            {
                txbIDProductoLigado.Text = "0";
                txbNomProdLigado.Clear();
                btnListarProd.Enabled = false;

            }
            
        }
        private void calcularUtilidad()
        {
            try
            {

                double utilidad = 0, PrecioCosto = 0, PrecioGravado = 0;
                if (txbPrecioCosto.Text == "")
                {
                    PrecioCosto = 0;
                }
                else
                {
                    PrecioCosto = double.Parse(txbPrecioCosto.Text);
                }

                if (txbPrecioGravado.Text == "")
                {
                    PrecioGravado = 0;
                }
                else
                {
                    PrecioGravado = double.Parse(txbPrecioGravado.Text);
                }
                utilidad = PrecioGravado - PrecioCosto;

                txbUtilidad.Text = utilidad.ToString();
                if (utilidad <= 0) txbUtilidadPorcent.Text = "0";
                else txbUtilidadPorcent.Text = ((utilidad / PrecioCosto) * 100).ToString();
            }
            catch { txbValorUtr.Text = ""; }
        }

        private void txbPrecioCosto_TextChanged(object sender, EventArgs e)
        {
            calcularPrecioGravado();
            calcularUtilidad();
        }

        private void chkActivarPorcentaje_CheckedChanged(object sender, EventArgs e)
        {
            if (chkActivarPorcentaje.Checked == true)
            {
                txbUtilidadPorcent.Enabled = true;
                txbValorUtr.Enabled = false;
            }
            else
            {
                txbUtilidadPorcent.Enabled = false;
                txbValorUtr.Enabled = true;
            }
        }

        private void txbUtilidadPorcent_ValueChanged(object sender, EventArgs e)
        {
            if (chkActivarPorcentaje.Checked == true)
            {
                double PorcentUtilidad = 0, PrecioCosto = 0, Utilidad = 0;
                if (ckGravado.Checked == false)
                {

                    PorcentUtilidad = Convert.ToDouble(txbUtilidadPorcent.Value);
                    PrecioCosto = double.Parse(txbPrecioCosto.Text);
                    txbUtilidad.Text = (PrecioCosto * (PorcentUtilidad / 100)).ToString();
                    Utilidad = double.Parse(txbUtilidad.Text);
                    txbValorUtr.Text = String.Format("{0:N1}", (Utilidad + PrecioCosto).ToString());
                }
                else
                {
                    PorcentUtilidad = Convert.ToDouble(txbUtilidadPorcent.Value);
                    PrecioCosto = double.Parse(txbPrecioCosto.Text);
                    txbUtilidad.Text = (PrecioCosto * (PorcentUtilidad / 100)).ToString();
                    Utilidad = double.Parse(txbUtilidad.Text);
                    txbValorUtr.Text = String.Format("{0:N1}", ((Utilidad + PrecioCosto) + ((Utilidad + PrecioCosto) * 0.13)));
                }
            }
        }

        
       
       
    }
}
