using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Punto_de_Venta
{
    public class Usuarios
    {
        //Variables
        string codigo;
        string nombre;
        string apellido1;
        string apellido2;
        string telefono;
        string direccion;
        string contraseña;
        string tipoUsuario;
        string estado;
        public Usuarios()
        {
            //Inicializar variables
            codigo = "";
            nombre = "";
            apellido1 = "";
            apellido2 = "";
            telefono = "";
            direccion = "";
            contraseña = "";
            tipoUsuario = "";
            estado = "";
        }
        // Constructor 
        public Usuarios(string codigoIn, string nombreIn, string apellido1In, string apellido2In, string telefonoIn, string direccionIn,string contraseñaIn,string tipoUsuarioIn,string estadoIn)
        {
            codigo = codigoIn;
            nombre = nombreIn;
            apellido1 = apellido1In;
            apellido2 = apellido2In;
            telefono = telefonoIn;
            direccion = direccionIn;
            contraseña = contraseñaIn;
            tipoUsuario = tipoUsuarioIn;
            estado = estadoIn;
        }
       
        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Apellido1
        {
            set { apellido1 = value; }
            get { return apellido1; }
        }
        public string Apellido2
        {
            set { apellido2 = value; }
            get { return apellido2; }
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
        public string Contraseña
        {
            set { contraseña = value; }
            get { return contraseña; }
        }
        public string TipoUsuario
        {
            set { tipoUsuario = value; }
            get { return tipoUsuario; }
        }
        public string Estado
        {
            set { estado = value; }
            get { return estado; }
        }
        
    }
   
}
