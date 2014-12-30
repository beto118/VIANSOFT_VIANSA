using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_de_Venta.Clases
{
    public class Cajas
    {
        //Variables
        string numero;
        string detalle;
        string estado;
        public Cajas()
        {
            //Inicializar variables
            numero = "";
            detalle = "";
            estado = "";
        }
        // Constructor 
        public Cajas(string numeroIn, string detalleIn,string estadoIn)
        {
            numero = numeroIn;
            detalle = detalleIn;
            estado = estadoIn;
        }
        public string Numero
        {
            set { numero = value; }
            get { return numero; }
        }
        public string Detalle
        {
            set { detalle = value; }
            get { return detalle; }
        }
        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }
        internal void ShowDialog()
        {
            throw new Exception("The method or operation is not implemented.");
        }
    }
}
