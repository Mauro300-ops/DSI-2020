using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace OpenShopFinal
{
    partial class Program
    {
        static void Main()
        {
            Console.WriteLine("BIENVENIDO A OPENSHOP\n\n");
            RegistrarCliente();
            Console.Clear();

        }

        public static void RegistrarCliente()
        {
            Console.WriteLine("REGISTRO DE CLIENTE");
            Console.WriteLine("\nIngrese el nombre del cliente: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("\nIngrese el apellido del cliente: ");
            string apellido = Console.ReadLine();

            Console.WriteLine("\nIngrese el mail del cliente: ");
            string mail = Console.ReadLine();

            Console.WriteLine("\nIngrese el nombre de usuario del cliente: ");
            string nombreUsuario = Console.ReadLine();

            Console.WriteLine("\nIngrese la contraseña del cliente: ");
            string contraseña = Console.ReadLine();

            Console.WriteLine("\nIngrese el DNI del cliente: ");
            string dni = Console.ReadLine();

            Console.WriteLine("\nBienvenido " + nombreUsuario);

            Cliente cliente = new Cliente(nombre, apellido, mail, nombreUsuario, contraseña, dni);
        }
    }
}
