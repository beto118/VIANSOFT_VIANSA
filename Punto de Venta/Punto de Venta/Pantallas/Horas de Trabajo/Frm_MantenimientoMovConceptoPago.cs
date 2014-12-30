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

namespace Punto_de_Venta.Pantallas.Horas_de_Trabajo
{
    public partial class Frm_MantenimientoMovConceptoPago : Form
    {
        //string Codigo = "";
        string SignoMat= "";
        string estado = "";
        public Frm_MantenimientoMovConceptoPago()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea guardar el concepto de Pago?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!Validar())
                      return;
                string respuesta = "";
               // int codigoGenerado = 0;

                using (ServicioMovConceptoPago elServicio = new ServicioMovConceptoPago())
                    respuesta = elServicio.RegistrarMovConceptoPago(txbNombre.Text, SignoMat);
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

        private void cmbxOperacionMat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxOperacionMat.SelectedIndex == 0)
            {
                SignoMat = "S";

            }
            else
            {
                SignoMat = "R";
            }
        }

        private void Frm_RegistrarMovConceptoPago_Load(object sender, EventArgs e)
        {
            tabModificar.Visible = false;
            Limpiar();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                CargarListado();
            }
        }
        private void Limpiar()
        {
            txbNombre.Clear();
            cmbxOperacionMat.SelectedIndex = 0;
        }
        private void CargarListado()
        {

            using (ServicioMovConceptoPago elServicio = new ServicioMovConceptoPago())
                dgvListado.DataSource = elServicio.ListarMovConceptoPago(txbFiltro.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void txbFiltro_TextChanged(object sender, EventArgs e)
        {
            CargarListado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            txbCodigo.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
            tabControl1.SelectedIndex = 2;
            CargarDatos();

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnGuardarMod_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Desea guardar el concepto de Pago?", "Guardar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                if (!ValidarModificacion())
                    return;
                string respuesta = "";
                // int codigoGenerado = 0;

                using (ServicioMovConceptoPago elServicio = new ServicioMovConceptoPago())
                    respuesta = elServicio.ModificarMovimiento(int.Parse(txbCodigo.Text),txbNombreMod.Text, SignoMat,estado);
                MessageBox.Show(respuesta);
                if (respuesta.Equals(Global.elGlobal.RespuestaCorrecta))
                {
                    this.Close();
                }

            }
        }

        private void CargarDatos()
        {
            DataRow drMovimiento = null;
            using (ServicioMovConceptoPago elServicio = new ServicioMovConceptoPago())
                drMovimiento = elServicio.ConsultarMovimientos(int.Parse(txbCodigo.Text));
            if (drMovimiento != null)
            {
                
                txbNombreMod.Text = drMovimiento["MovConceptoPago_nombre"].ToString();
                if (drMovimiento["MovConceptoPago_RestaSuma"].ToString().Equals("+"))
                    cmbxMasMenos.SelectedIndex = 0;
                else
                    cmbxMasMenos.SelectedIndex = 1;
                chkEstado.Checked = drMovimiento["MovConceptoPago_Estado"].ToString().Equals("ACT");

                

            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbxMasMenos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxMasMenos.SelectedIndex == 0)
            {
                SignoMat = "S";

            }
            else
            {
                SignoMat = "R";
            }
        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEstado.Checked == true)
            {
                estado = "ACT";

            }
            else
                estado = "NULL";
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txbCodigo.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
            tabControl1.SelectedIndex = 2;
            CargarDatos();
        }
    }
}
