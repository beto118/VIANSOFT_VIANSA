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

namespace Punto_de_Venta.Pantallas.Credito
{
    public partial class Frm_ListarFactCred_x_Cliente : Form
    {
        int Cliente = 0;
        public Frm_ListarFactCred_x_Cliente(int ClienteID)
        {
            
            InitializeComponent();
            Cliente = ClienteID;
            CargarFacturasHoy();
            CargarFacturasHistorial();
            
       }
        private void CargarFacturasHoy()
        {

            using (ServicioFactura elServicio = new ServicioFactura())
                dgvListadoHoy.DataSource = elServicio.ListarFactCliente(txbFiltro.Text, Cliente, ckSaldo.Checked ? 1 : 0);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListadoHoy);
        }
        private void CargarFacturasHistorial()
        {

            using (ServicioFactura elServicio = new ServicioFactura())
                dgvListadoHistorial.DataSource = elServicio.ListarFactClienteHistorial(txbFiltro.Text, Cliente, ckSaldo.Checked ? 1 : 0);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListadoHistorial);

            sumarFactHistorial();
        }
        private void sumarFactHistorial()
        {
            double total = 0;
            for (int index = 0; index <= dgvListadoHistorial.Rows.Count -1 ; index ++) 
            {
                total += double.Parse(dgvListadoHistorial.Rows[index].Cells[5].Value.ToString());
	           

            }
            txbTotal.Text = string.Format("{0:n1}", (total.ToString()));
            
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvListadoHoy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoHoy.SelectedRows.Count != 0)
            {
                Frm_AgregarAbono elMantenimiento = new Frm_AgregarAbono(int.Parse(this.dgvListadoHoy.SelectedCells[0].Value.ToString()),1);
                elMantenimiento.ShowDialog();
                CargarFacturasHoy();
            }
        }

        

        private void btnCancelarFacts_Click(object sender, EventArgs e)
        {
            //Frm_CancelarFacturas forma = new Frm_CancelarFacturas(int.Parse(this.dgvListadoHistorial.SelectedCells[0].Value.ToString()), 2);
            //forma.ShowDialog();
        }

        private void btnRealizarAbono_Click(object sender, EventArgs e)
        {
            if (dgvListadoHistorial.SelectedRows.Count != 0)
            {
                Frm_AgregarAbono elMantenimiento = new Frm_AgregarAbono(int.Parse(this.dgvListadoHistorial.SelectedCells[0].Value.ToString()), 2);
                elMantenimiento.ShowDialog();
                CargarFacturasHistorial();
            }
        }

        private void dgvListadoHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListadoHistorial.SelectedRows.Count != 0)
            {
                Frm_AgregarAbono elMantenimiento = new Frm_AgregarAbono(int.Parse(this.dgvListadoHistorial.SelectedCells[0].Value.ToString()), 2);
                elMantenimiento.ShowDialog();
                CargarFacturasHistorial();
            }
        }

        

        
       
    }
}
