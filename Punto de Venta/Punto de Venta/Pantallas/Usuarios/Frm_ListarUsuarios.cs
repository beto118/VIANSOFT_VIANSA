using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Logica_de_Negocio;
using Punto_de_Venta.Pantallas.Horas_de_Trabajo;

namespace Punto_de_Venta.Pantallas.Usuarios
{
    public partial class Frm_ListarUsuarios : Form
    {
     
        string modo = "";
        public Frm_ListarUsuarios(string modoIn)
        {
            InitializeComponent();
            modo = modoIn;
        }

        private void ListarUsuarios_Load(object sender, EventArgs e)
        {
            CargarListado();
            if (modo.Equals("MANTHORAS"))
            {
                btnNuevoUsuario.Visible = false;
                btnEditar.Visible = false;
                btnEnviarHistorialHoras.Visible = false;
            }
            else if(modo.Equals("HISTORIAL_HORAS"))
            {
                btnNuevoUsuario.Visible = false;
                btnEditar.Visible = false;
                btnEnviarMantHoras.Visible = false;
            
            }
        }
        private void CargarListado()
        {
            string estado = "";
            if (ckEstado.Checked) estado = "ACT";
            using (ServicioUsuario elServicio = new ServicioUsuario())
                dgvListado.DataSource = elServicio.ListarUsuarios(txbFiltro.Text, estado);

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void btnNuevoUsuario_Click_1(object sender, EventArgs e)
        {
            RegistrarUsuario elIngresar = new RegistrarUsuario();
            elIngresar.ShowDialog();
            txbFiltro.Text = "";
            CargarListado();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                RegistrarUsuario elIngresar = new RegistrarUsuario(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void txbFiltro_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            CargarListado();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void ckEstado_CheckedChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_MantenimientoHoras elIngresar = new Frm_MantenimientoHoras(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void btnEnviarHistorialHoras_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count != 0)
            {

                Frm_MantenimientoHistorialHoras elIngresar = new Frm_MantenimientoHistorialHoras(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                elIngresar.ShowDialog();
                txbFiltro.Text = "";
                CargarListado();
            }
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (modo.Equals("MANTHORAS"))
            {
                if (dgvListado.SelectedRows.Count != 0)
                {

                    Frm_MantenimientoHoras elIngresar = new Frm_MantenimientoHoras(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
                    elIngresar.ShowDialog();
                    txbFiltro.Text = "";
                    CargarListado();
                }
            }
        }
    }
}
