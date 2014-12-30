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
using Punto_de_Venta.Reportes;

namespace Punto_de_Venta.Pantallas.Credito
{
    public partial class Frm_AgregarAbono : Form
    {
        int factura = 0,tipFact=0;
        public Frm_AgregarAbono()
        {
            InitializeComponent();
        }
        public Frm_AgregarAbono(int fact,int TipoFact)
        {
            InitializeComponent();
            ListarAbonos(fact);
            factura = fact;
            tipFact = TipoFact;
            if (TipoFact==1) consultarFact(fact);
            else consultarFactHist(fact);
        
            dpFecha.Value = DateTime.Now;
            txbAbono.Select();
        }
        private void consultarFact(int Fact)
        {
            DataRow drFact = null;
            using (ServicioFactura elServicio = new ServicioFactura())
                drFact = elServicio.ConsultarFactura(Fact);
          
            if (drFact != null)
            {
                txbFactNumero.Text = Fact.ToString();
                txbNombreCliente.Text = drFact["Cliente"].ToString();// + " " + drFact["Cliente_apellido1"].ToString() + " " + drFact["Cliente_apellido2"].ToString(); ;
                txbEstado.Text = drFact["Fact_estado"].ToString();
                txbNumCliente.Text = drFact["Clie_Id"].ToString();
                txbFecha.Text = drFact["Fact_fecha"].ToString();
                txbFechaVenc.Text = drFact["Fact_FechaLimite"].ToString();
                txbSaldo.Text = string.Format("{0:n1}", double.Parse(drFact["Fact_total"].ToString()));
                txbSaldoAnterior.Text = string.Format("{0:n1}", double.Parse(drFact["Fact_Saldo"].ToString()));
            }
            
            else
            {
                MessageBox.Show("Codigo invalido","ERROR BUSCA DE FACTURA", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        
        }
        private void consultarFactHist(int Fact)
        {
            DataRow drFactHist = null;
            
            using (ServicioFactura elServicioHist = new ServicioFactura())
                drFactHist = elServicioHist.ConsultarHistFactura(Fact);
           
            if (drFactHist != null)
            {
                txbFactNumero.Text = Fact.ToString();
                txbNombreCliente.Text = drFactHist["Cliente"].ToString();// + " " + drFact["Cliente_apellido1"].ToString() + " " + drFact["Cliente_apellido2"].ToString(); ;
                txbNumCliente.Text = drFactHist["Clie_Id"].ToString();
                txbFecha.Text = drFactHist["HistFact_fecha"].ToString();
                txbFechaVenc.Text = drFactHist["HistFact_FechaLimite"].ToString();
                txbEstado.Text = drFactHist["HistFact_estado"].ToString();
                txbSaldo.Text = string.Format("{0:n1}", double.Parse(drFactHist["HistFact_montoCredito"].ToString()));
                txbSaldoAnterior.Text = string.Format("{0:n1}", double.Parse(drFactHist["HistFact_Saldo"].ToString()));
            }
            else
            {
                MessageBox.Show("Codigo invalido", "ERROR BUSCA DE FACTURA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            guardar();
            //if (tipFact == 1) consultarFact(factura);
            //else consultarFactHist(factura);
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void guardar()
        {
            int seRealizo = 0;
            using (Validacion laValidacion = new Validacion())
            {
                if (!laValidacion.ValidaDoubleEntre(1, double.Parse(txbSaldoAnterior.Text), txbAbono, elErrorProvider, "Abono"))
                    return;
            }

            if (tipFact == 1)
            {
                string respuesta = "";
                using (ServicioFactura elGestor = new ServicioFactura())
                    respuesta = elGestor.RealizarAbonoDeFactura(int.Parse(txbFactNumero.Text), double.Parse(txbSaldoAnterior.Text), double.Parse(txbAbono.Text), double.Parse(txbSaldoNuevo.Text), dpFecha.Value.ToShortDateString(), txbDetalle.Text, int.Parse(Principal.elUsuario.Codigo));
                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    MessageBox.Show(respuesta, "Error...");
                else
                    //this.Close();
                    seRealizo=1;
            }
            else
            {
                string respuesta = "";
                using (ServicioFactura elGestor = new ServicioFactura())
                    respuesta = elGestor.RealizarAbonoDeHistFactura(int.Parse(txbFactNumero.Text),double.Parse(txbSaldoAnterior.Text) ,double.Parse(txbAbono.Text),double.Parse(txbSaldoNuevo.Text), dpFecha.Value.ToShortDateString(), txbDetalle.Text, int.Parse(Principal.elUsuario.Codigo));
                if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                    MessageBox.Show(respuesta, "Error...");
                else
                   // this.Close();
                    seRealizo=1;

            }
            if (seRealizo == 1)
            {
                
                    ListarAbonos(int.Parse(txbFactNumero.Text));
                    
                    tabControl1.SelectedIndex = 1;

                    int indiceUltimaFila = dgvListado.Rows.Count - 1; /*Aquí sacas el número de filas del DataGridView, y le restamos uno porque los indíces comienzan a contar en cero*/


                    dgvListado.Rows[indiceUltimaFila].Selected = true; /*Seleccionamos la fila con el último índice*/

                    btnImprimirResibo_Click(null, null);
            }
        }

        private void txbAbono_TextChanged(object sender, EventArgs e)
        {
            txbAbono.BackColor = Color.White;
            try
            {
                txbSaldoNuevo.Text = string.Format("{0:N1}", double.Parse(txbSaldoAnterior.Text) - double.Parse(txbAbono.Text));
            }
            catch
            {
                txbAbono.BackColor = Color.Red;
                txbSaldoNuevo.Text = "0";
            }
        }

        private void txbAbono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                txbDetalle.Select();
        }

        private void ListarAbonos(int FactNumero)
        {
            using (ServicioFactura elServicio = new ServicioFactura())
                dgvListado.DataSource = elServicio.ListarPagosDeFactura(FactNumero);
        
        }

        private void btnEliminarPago_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {
                if (MessageBox.Show("Desea eliminar el Abono ID es " + dgvListado.SelectedRows[0].Cells[0].Value.ToString() + " con monto " + string.Format("{0:n1}", double.Parse(dgvListado.SelectedRows[0].Cells[2].Value.ToString())) + "?", "Eliminar Pago", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string respuesta = "";
                    using (ServicioAbono elServicio = new ServicioAbono())
                        respuesta = elServicio.EliminarAbono(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                    if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                        ListarAbonos(factura);
                    else
                        MessageBox.Show(respuesta);

                }
            }
        }

        private void btnImprimirResibo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea imprimir el Resibo del Abono?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (tipFact == 1)
                {
                    //imprimir factura
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirResiboAbonoFactHoy(Conexion.laConexion.ImpresoraFactura, int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(txbFactNumero.Text));
                }
                if (tipFact == 2)
                {
                    //imprimir factura
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirResiboAbono(Conexion.laConexion.ImpresoraFactura, int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()), int.Parse(txbFactNumero.Text));
                }
            }
        }

    }
}
