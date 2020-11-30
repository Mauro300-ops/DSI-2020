using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
   public class Productos
   {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public string Rubro { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public Productos()
        {

        }
           
        public Productos(int idProducto, string nombre, string marca, string rubro, int cantidad, decimal precio)
        {
            this.IdProducto = idProducto;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Rubro = rubro;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
   }
}
