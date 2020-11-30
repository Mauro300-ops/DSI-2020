using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShopFinal
{
    class GestorProducto
    {
        public static List<Productos> ListaProductos = new List<Productos>();

        public static Productos TelevisorLg = new Productos();
        public static Productos CelularIphone = new Productos();
        public static Productos FutbolPelota = new Productos();
        public static Productos TenisRaqueta = new Productos();
        public static Productos CalzadoNike = new Productos();
    
        public static void AgregarProducto()
        {
            TelevisorLg.IdProducto = 0;
            TelevisorLg.Nombre = "LG0254DF";
            TelevisorLg.Marca = "LG";
            TelevisorLg.Precio = 99.999m;
            TelevisorLg.Rubro = "Electrodomesticos";
            TelevisorLg.Cantidad = 15;
           

            CelularIphone.IdProducto = 1;
            CelularIphone.Nombre = "7 Plus";
            CelularIphone.Marca = " Iphone";
            CelularIphone.Precio = 55000m;
            CelularIphone.Rubro = "Electrodomesticos";
            CelularIphone.Cantidad = 10;
            

            FutbolPelota.IdProducto = 2;
            FutbolPelota.Nombre = "ADF50";
            FutbolPelota.Marca = "Adidas";
            FutbolPelota.Precio = 5000m;
            FutbolPelota.Rubro = "Deporte";
            FutbolPelota.Cantidad = 60;
          

            TenisRaqueta.IdProducto = 3;
            TenisRaqueta.Nombre = "l20SS";
            TenisRaqueta.Marca = "Wilson";
            TenisRaqueta.Precio = 22000m;
            TenisRaqueta.Rubro = "Deporte";
            TenisRaqueta.Cantidad = 30;
      

            CalzadoNike.IdProducto = 4;
            CalzadoNike.Nombre = "Air Force";
            CalzadoNike.Marca = "Nike";
            CalzadoNike.Precio = 10000;
            CalzadoNike.Rubro = "Calzado";
            CalzadoNike.Cantidad = 120;
         

            ListaProductos.Add(new Productos(TelevisorLg.IdProducto, TelevisorLg.Nombre, TelevisorLg.Marca, TelevisorLg.Rubro, TelevisorLg.Cantidad, TelevisorLg.Precio));
            ListaProductos.Add(new Productos(CelularIphone.IdProducto, CelularIphone.Nombre, CelularIphone.Marca, CelularIphone.Rubro, CelularIphone.Cantidad, CelularIphone.Precio));
            ListaProductos.Add(new Productos(FutbolPelota.IdProducto, FutbolPelota.Nombre, FutbolPelota.Marca, FutbolPelota.Rubro, FutbolPelota.Cantidad, FutbolPelota.Precio));
            ListaProductos.Add(new Productos(TenisRaqueta.IdProducto, TenisRaqueta.Nombre, TenisRaqueta.Marca, TenisRaqueta.Rubro, TenisRaqueta.Cantidad, TenisRaqueta.Precio));
            ListaProductos.Add(new Productos(CalzadoNike.IdProducto, CalzadoNike.Nombre, CalzadoNike.Marca, CalzadoNike.Rubro, CalzadoNike.Cantidad, CalzadoNike.Precio));
        }

        public static void MostrarTodosProductos()
        {
            foreach (var productos in ListaProductos)
            {   
                Console.WriteLine("ID: " + productos.IdProducto + " Nombre: " + productos.Nombre + " Marca: " + productos.Marca + " Precio: " + productos.Precio + "$ Rubro: " + productos.Rubro + " Cantidad: " + productos.Cantidad);
                Console.WriteLine("\n");
            }
        }
    }
}
