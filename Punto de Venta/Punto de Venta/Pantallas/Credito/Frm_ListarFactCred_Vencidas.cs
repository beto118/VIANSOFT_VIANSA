﻿using System;
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
    public partial class Frm_ListarFactCred_Vencidas : Form
    {
        public Frm_ListarFactCred_Vencidas()
        {
            InitializeComponent();
            CargarListado();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargarListado();
        }
        private void CargarListado()
        {
            using (ServicioFactura elGestor = new ServicioFactura())
                dgvListado.DataSource = elGestor.ListarFactCredVencidas(txbFiltro.Text);
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dgvListado);
        }

        private void txbFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                CargarListado();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //if (dgvListado.SelectedRows.Count != 0)
            //{

            //    Frm_MantFactProveedor elMant = new Frm_MantFactProveedor(int.Parse(dgvListado.SelectedRows[0].Cells[0].Value.ToString()));
            //    elMant.ShowDialog();
            //}
        }

    }
}
