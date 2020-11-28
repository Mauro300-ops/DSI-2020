using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
    partial class Program
    {
        public class Cliente
        {
            public string nombre { get; set; }
            public string apellido { get; set; }
            public string mail { get; set; }
            public string nombreUsuario { get; set; }
            public string contraseña { get; set; }
            public long dni { get; set; }
            public List<Tarjeta> Tarjeta { get; set; }

            public Cliente(string nombre, string apellido, string mail, string nombreUsuario, 
                            string contraseña, long dni, List<Tarjeta> Tarjeta)
            {
               this.nombre = nombre;
               this.apellido = apellido;
               this.mail = mail;
               this.nombreUsuario = nombreUsuario;
               this.contraseña = contraseña;
               this.dni = dni;
               this.Tarjeta = Tarjeta;
            }
        }
    }
}
