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

namespace Punto_de_Venta.Pantallas.Egresos
{
    public partial class Frm_MantEgresoTipo : Form
    {
        public Frm_MantEgresoTipo()
        {
            InitializeComponent();
            CargarListado();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el tipo de egreso?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                    return;
                string respuesta = "";
                // int codigoGenerado = 0;

                using (ServicioEgresoTipo elServicio = new ServicioEgresoTipo())
                    respuesta = elServicio.RegistrarEgresoTipo(txbNombre.Text, cmbxOperacionMat.SelectedIndex==0?"S":"R");
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
                if (!elValidar.ValidaVacio(txbNombre, elErrorProvider, "Nombre"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }
        private bool ValidarModificacion()
        {
            int malas = 0;
            elErrorProvider.Clear();
            using (Validacion elValidar = new Validacion())
            {
                if (!elValidar.ValidaVacio(txbCodigo, elErrorProvider, "Codigo"))
                    malas++;
                if (!elValidar.ValidaVacio(txbNombreMod, elErrorProvider, "Nombre"))
                    malas++;
            }

            if (malas == 0)
                return true;
            else
                return false;

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {

            using (ServicioEgresoTipo elServicio = new ServicioEgresoTipo())
                dgvListado.DataSource = elServicio.ListarEgresoTipo(txbFiltro.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
                CargarListado();
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txbCodigo.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txbNombreMod.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                if (dgvListado.SelectedRows[0].Cells[2].Value.ToString().Equals("S"))
                    cmbxMasMenos.SelectedIndex = 0;
                else
                    cmbxMasMenos.SelectedIndex = 1;
                tabControl1.SelectedIndex = 2;
            }
        }

        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el tipo de Egreso?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!ValidarModificacion())
                    return;
                string respuesta = "";
                // int codigoGenerado = 0;

                using (ServicioEgresoTipo elServicio = new ServicioEgresoTipo())
                    respuesta = elServicio.ModificarEgreso(int.Parse(txbCodigo.Text), txbNombreMod.Text,cmbxMasMenos.SelectedIndex==0?"S":"R");
                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    this.Close();
                }

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txbCodigo.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txbNombreMod.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                if (dgvListado.SelectedRows[0].Cells[2].Value.ToString().Equals("S"))
                    cmbxMasMenos.SelectedIndex = 0;
                else
                    cmbxMasMenos.SelectedIndex = 1;
                tabControl1.SelectedIndex = 2;
            }
        }

    }
}
