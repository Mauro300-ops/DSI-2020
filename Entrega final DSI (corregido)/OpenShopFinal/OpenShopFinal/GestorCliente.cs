using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShopFinal
{
    class GestorCliente
    {
        public static List<Cliente> Clientes = new List<Cliente>();

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

            var dni = Double.Parse(Console.ReadLine());
            

            Console.WriteLine("\nBienvenido " + nombreUsuario);

            Clientes.Add(new Cliente(nombre, apellido, mail, nombreUsuario, contraseña, dni));  
        }
    }
}
