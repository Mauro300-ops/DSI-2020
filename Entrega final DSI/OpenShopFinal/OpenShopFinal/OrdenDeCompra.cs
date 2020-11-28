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
        class OrdenDeCompra
        {
            public List<Productos> Productos { get; set; } = new List<Productos>();
            public Cliente Cliente { get; set; }
            public DateTime fechaCreacion { get; set; }
            public double monto { get; set; }
            static public OrdenDeCompra OrdenJson { get; set; } = new OrdenDeCompra();


            public OrdenDeCompra ordenDeCompra (List<Productos> Productos, Cliente Cliente, 
                                                DateTime fechaCreacion, double monto)
            {
                this.Productos = Productos;
                this.Cliente = Cliente;
                this.fechaCreacion = fechaCreacion;
                this.monto = monto;
            }

            public OrdenDeCompra DetalleOrdenDeCompra()
            {
                const string RUTA_ARCHIVO_JSON = @"c:\datos\carrito.json";

                if (System.IO.File.Exists(RUTA_ARCHIVO_JSON))
                {
                    string ordenCarritoEnJson = System.IO.File.ReadAllText(RUTA_ARCHIVO_JSON);
                    return JsonConvert.DeserializeObject<OrdenDeCompra>(ordenCarritoEnJson);
                }
                else
                {
                    throw new Exception("No es posible exportar los datos debido a su inexistencia");
                }
            }
        }
    }
}
