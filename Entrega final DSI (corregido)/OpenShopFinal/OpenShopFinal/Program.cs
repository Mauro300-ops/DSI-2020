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
            
            int continuidad;
            do
            {

                Console.WriteLine("BIENVENIDO A OPENSHOP\n\n");
                Console.WriteLine("1- Ingresar cliente\n");
                Console.WriteLine("2- Cargar tarjeta\n");
                Console.WriteLine("3- Mostrar productos\n");
                Console.WriteLine("4- Generar Json\n");
                var opcion = Int32.Parse(Console.ReadLine());
                GestorProducto.AgregarProducto();
                Console.WriteLine(opcion);

                Console.Clear();

                switch (opcion)
                {
                    case 1:

                        GestorCliente.RegistrarCliente();
                        break;

                    case 2:

                        GestorTarjeta.RegistrarTarjeta();
                        break;

                    case 3:

                        GestorProducto.MostrarTodosProductos();
                        break;


                    case 4:

                        OrdenPaga.GenerarOrdenCarrito();
                        break;

                    default:
                        break;
                }
                Console.WriteLine("Desea realizar otra accion?");
                Console.WriteLine(" SI[1] - NO[0]");
                continuidad = Int32.Parse(Console.ReadLine());
                Console.Clear();
            } while (continuidad != 0);
        }
    }
}


