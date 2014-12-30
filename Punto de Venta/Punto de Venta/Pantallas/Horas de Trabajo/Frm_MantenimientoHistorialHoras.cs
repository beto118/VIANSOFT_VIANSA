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
    public partial class Frm_MantenimientoHistorialHoras : Form
    {
        public Frm_MantenimientoHistorialHoras()
        {
            InitializeComponent();
        }
        public Frm_MantenimientoHistorialHoras(int Usuario_codigo)
        {
            InitializeComponent();
            CargarDatos(Usuario_codigo);
            CargarHorasLab(Usuario_codigo);
            //modo = "MOD";
        }
        private void CargarHorasLab(int Usuario_codigo)
        {
            DataRow drUsuario = null;
            using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                drUsuario = elServicio.TotalHorasDePago(Usuario_codigo);
            if (drUsuario != null)
            {
                txbTotalHoras.Text = drUsuario["Horas"].ToString();
                txbTotalMinutos.Text = drUsuario["Minutos"].ToString();
                
            }
        }
        private void CargarDatos(int Usuario_codigo)
        {
            DataRow drUsuario = null;
            using (ServicioUsuario elServicio = new ServicioUsuario())
                drUsuario = elServicio.ConsultarUsuarios(Usuario_codigo);
            if (drUsuario != null)
            {
                txbCodigo.Text = Usuario_codigo.ToString();
                txbNombre.Text = drUsuario["Usuario_nombre"].ToString();
                txbApellido1.Text = drUsuario["Usuario_apellido1"].ToString();
                txbApellido2.Text = drUsuario["Usuario_apellido2"].ToString();
                txbCodigoBarra.Text = drUsuario["Usuario_CodigoBarra"].ToString();
                txbGanaXhora.Text = drUsuario["Usuario_GanaXhora"].ToString();
            }
        }

        private void Frm_MantenimientoHistorialHoras_Load(object sender, EventArgs e)
        {
            CargarListado();
            CargarListaConceptoPagoHistorial();
            CargarListaHistorialPagosVendedor();
        }
        private void CargarListaHistorialPagosVendedor()
        {

            using (ServicioPagoVendedor elServicio = new ServicioPagoVendedor())
                dtgPagosVendedor.DataSource = elServicio.ListarPagosVendedor(int.Parse(txbCodigo.Text));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgPagosVendedor);
        }
        private void CargarListaConceptoPagoHistorial()
        {

            using (ServicioConceptoPago elServicio = new ServicioConceptoPago())
                dtgConceptoPago.DataSource = elServicio.ListarConceptoPagoHistorial(int.Parse(txbCodigo.Text));
            using (Validacion laValidacion = new Validacion())
                laValidacion.DarFormatoDecimalGrid(dtgConceptoPago);
        }
        private void CargarListado()
        {

            using (ServicioDiaTrabajo elServicio = new ServicioDiaTrabajo())
                dgvListadoDiaTrabajo.DataSource = elServicio.ListarDiaTrabajoDePago(int.Parse(txbCodigo.Text));
            //using (Validacion laValidacion = new Validacion())
            //    laValidacion.DarFormatoDecimalGrid(dgvListadoDiaTrabajo);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Dispose();
        }
    }
}
