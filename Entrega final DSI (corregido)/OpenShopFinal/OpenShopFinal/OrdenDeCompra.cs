using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
   public class OrdenDeCompra
   {
        public List<Productos> Productos = new List<Productos>();

        public Cliente Cliente { get; set; }
        public DateTime fechaCreacion { get; set; }
        public decimal monto { get; set; }
        static public OrdenDeCompra OrdenJson { get; set; }

        public OrdenDeCompra ( Cliente Cliente, DateTime fechaCreacion, decimal monto)
        {
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
