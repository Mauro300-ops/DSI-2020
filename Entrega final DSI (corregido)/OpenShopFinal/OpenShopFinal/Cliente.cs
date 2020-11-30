using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Mail { get; set; }
        public string NombreUsuario { get; set; }
        public string Contraseña { get; set; }
        public double Dni { get; set; }
            
        public Cliente()
        {

        }

        public Cliente(string nombre, string apellido, string mail, string nombreUsuario, 
                       string contraseña, double dni)
        {
               this.Nombre = nombre;
               this.Apellido = apellido;
               this.Mail = mail;
               this.NombreUsuario = nombreUsuario;
               this.Contraseña = contraseña;
               this.Dni = dni;
        }    
    }
}
