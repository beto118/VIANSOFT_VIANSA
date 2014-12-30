using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_de_Venta.Clases
{
     public class Productos
     {
        //Variables
        string codigo;
        string nombre;
        string descripcion;
        string codigoBarra;
        string valorUnt;
        string cantidad;

        public Productos() 
        {
            //Inicializar variables
            codigo = "";
            nombre = "";
            descripcion = "";
            codigoBarra = "";
            ValorUnt = "";
            cantidad = "";
        
        }
        // Constructor 
        public Productos(string codigoIn, string nombreIn, string descripcionIn,string CodigoBarraIn, string valorUnitIn,string cantidadIn)
        {
            codigo = codigoIn;
            nombre = nombreIn;
            descripcion = descripcionIn;
            codigoBarra = CodigoBarraIn;
            ValorUnt = valorUnitIn;
            cantidad= cantidadIn;

        }
        

        public string Nombre 
        {
            set { nombre = value; }
            get { return  nombre; }
        }

        public string Codigo 
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string Descripcion 
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public string CodigoBarra
        {
            set { codigoBarra = value; }
            get { return codigoBarra; }
        }

        public string Cantidad 
        {
            set { cantidad = value; }
            get { return cantidad; }
        
        }

        public string ValorUnt 
        {
            set { valorUnt = value; }
            get { return valorUnt; }
        }

        internal void ShowDialog()
        {
            throw new Exception("The method or operation is not implemented.");
        }
     }
}
