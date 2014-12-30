using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Punto_de_Venta.Pantallas.Orden_de_Compra;

namespace Punto_de_Venta.Pantallas.Varias
{
    public partial class Frm_Vuelto : Form
    {
        int tipoInterno = 0;
        public Frm_Vuelto(int tipo )
        {
            InitializeComponent();
            btnAceptar.Select();
            tipoInterno = tipo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Vuelto_Load(object sender, EventArgs e)
        {
            if(tipoInterno==1)
                label2.Text= Frm_Cambio.Cambio;
            else if (tipoInterno == 2)
                label2.Text = PagaCon.Cambio;
        }

        private void btnAceptar_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAceptar_Click(null, null);
        }
    }
}
