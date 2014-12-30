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
    public partial class Frm_ListadoEgresos : Form
    {
        
        public Frm_ListadoEgresos()
        {
            InitializeComponent();
        }
        private void CargarListado()
        {

            using (ServicioEgreso elServicio = new ServicioEgreso())
                dgvListado.DataSource = elServicio.ListarEgreso(txbFiltro.Text, ckEstado.Checked?1:0);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }

       

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Frm_RegistrarEgresos elIngresar = new Frm_RegistrarEgresos();
            elIngresar.ShowDialog();
            CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_RegistrarEgresos elIngresar = new Frm_RegistrarEgresos(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                CargarListado();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void Frm_ListarCategoriaProducto_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void Frm_ListadoEgresos_Load(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void btnImprimirEgreso_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                if (MessageBox.Show("¿Desea imprimir el EGRESO?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //imprimir egreso
                    using (ImprimirTicket elImprimir = new ImprimirTicket())
                        elImprimir.ImprimirEgreso(Conexion.laConexion.ImpresoraFactura, int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                }
            }
        }
    }
}
