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
using System.Media;

namespace Punto_de_Venta.Pantallas.Credito
{
    public partial class Frm_CancelarFacturas : Form
    {
       // int noExitenFact = 0;
        int Cliente = 0;
        public Frm_CancelarFacturas(int ClienteID)
        {
            
            InitializeComponent();
            Cliente = ClienteID;
            CargarFacturasHistorial();
            
       }
        
       private void CargarFacturasHistorial()
       {
           
           using (ServicioFactura elServicio = new ServicioFactura())
               dgvListadoHistorial.DataSource = elServicio.ListarFacthistXcliente("", Cliente, 1);
           using (Validacion laValidacion = new Validacion())
               laValidacion.DarFormatoDecimalGrid(dgvListadoHistorial);

           if(dgvListadoHistorial.RowCount ==0)
           {
               MessageBox.Show("NO EXITEN FACTURAS DEL HISTORIAL PARA ESTE CLIENTE");
               this.Close();
           }
       }

       private void dgvListadoHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
       {
           PasarFactura();
       }

       private void btnPasarDtabla_Click(object sender, EventArgs e)
       {
           PasarFactura();
       }
       private void PasarFactura()
       {
           string codigo = "";
           codigo = this.dgvListadoHistorial.SelectedCells[0].Value.ToString();

           if (dgvListadoHistorial.SelectedRows.Count != 0)
           {
               int existe = 0;
               foreach (ListViewItem elItem in lvItems.Items)
               {
                   if (elItem.SubItems[0].Text.Equals(codigo))
                   {
                       existe = 1;                      

                   }
               }
               if (existe == 0)
               {
                   //factura
                   ListViewItem item = new ListViewItem(codigo);
                   item.SubItems.Add(this.dgvListadoHistorial.SelectedCells[1].Value.ToString());
                   item.SubItems.Add(this.dgvListadoHistorial.SelectedCells[4].Value.ToString());
                   //item.SubItems.Add(string.Format("{0:n1}", valorUni));
                   //item.SubItems.Add(string.Format("{0:n1}", cant * valorUni));
                   //if (gravado.Equals("S"))
                   //    item.SubItems.Add(string.Format("{0:n1}", (cant * valorUni * 0.13)));//(cant * valorUni - cant * valorUni / 1.13)));
                   //else
                   //    item.SubItems.Add("0");
                   lvItems.Items.Insert(0, item);
                   //Listo = 1;

                   SumarTotales();
               }
               else MessageBox.Show("Factura ya seleccionada");

           }
       
       }
       private void SumarTotales()
       {
           try
           {
               //Calcular el subtotal
               double total = 0;
               foreach (ListViewItem elItem in lvItems.Items)
               {
                   total += double.Parse(elItem.SubItems[2].Text);
               }
               textBox1.Text = string.Format("{0:n1}", total);

           }
           catch
           {
               MessageBox.Show("Error en el calculo del total, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void button1_Click(object sender, EventArgs e)
       {
           try
           {
               foreach (ListViewItem item in lvItems.Items)
               {
                   if (item.Checked)
                       lvItems.Items.Remove(item);
                   SystemSounds.Asterisk.Play();
               }
               SumarTotales();
           }
           catch
           {
               MessageBox.Show("Error al eliminar un Producto, Si el error persiste comuniquese con el Administrador", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void btnSalir_Click(object sender, EventArgs e)
       {
           this.Dispose();
           this.Hide();
       }

       private void btnCancelarFactura_Click(object sender, EventArgs e)
       {
           try
           {
               //cancelar facturas
               string respuesta = "";
               foreach (ListViewItem elitem in lvItems.Items)
               {

                   using (ServicioFactura elServicio = new ServicioFactura())
                       respuesta = elServicio.CancelarFacturas(int.Parse(elitem.SubItems[0].Text));

                   if (!respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                   {
                       MessageBox.Show(respuesta, "Error al Cancelar las facturas");
                       return;
                   }
               }
               if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
               {
                   MessageBox.Show(respuesta,"Correcto");
                   CargarFacturasHistorial();
                   lvItems.Items.Clear();
                   textBox1.Clear();
               }
           }
           catch
           {
               MessageBox.Show("Error al Cancelar las Facturas", "Error de Conexion", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
       }

       private void Frm_CancelarFacturas_Load(object sender, EventArgs e)
       {
           
       }

       

        
    }
}
