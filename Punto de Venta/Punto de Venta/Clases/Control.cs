using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_de_Venta.Clases
{
    public class Control
    {
        public class control
        {
        //Variables
        string empresa;
        string nombrePropietario;
        string cedJuridica;
        string telefono;
        string direccion;
        string msjPersonal;
        string tipoCambio;
        public control()
        {
            //Inicializar variables
            empresa = "";
            nombrePropietario = "";
            cedJuridica = "";
            telefono = "";
            direccion = "";
            msjPersonal = "";
            tipoCambio = "";
        }
        // Constructor 
        public control(string empresaIn, string nombrePropieIn, string cedJuridIn, string telefonoIn, string direccionIn,string msjPersonalIn,string tipoCambioIn)
        {
            empresa = empresaIn;
            nombrePropietario = nombrePropieIn;
            cedJuridica = cedJuridIn;
            telefono = telefonoIn;
            direccion = direccionIn;
            msjPersonal = msjPersonalIn;
            tipoCambio = tipoCambioIn;
        }
        public string Empresa
        {
            set { empresa = value; }
            get { return empresa; }
        }
        public string NombrePropietario
        {
            set { nombrePropietario = value; }
            get { return nombrePropietario; }
        }
        public string CedJuridica
        {
            set { cedJuridica = value; }
            get { return cedJuridica; }
        }
        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }
        public string MsjPersonal
        {
            set { msjPersonal = value; }
            get { return msjPersonal; }
        }
        public string TipoCambio
        {
            set { tipoCambio = value; }
            get { return tipoCambio; }
        }

    }
 }
}
