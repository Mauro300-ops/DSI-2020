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
        public class Productos
        {
            public int idProducto { get; set; }
            public string nombre { get; set; }
            public string marca { get; set; }
            public string rubro { get; set; }
            public int cantidad { get; set; }
            public double precio { get; set; }

           
            public Productos(int idProducto, string nombre, string marca, string rubro, int cantidad, 
                            double precio)
            {
                this.idProducto = idProducto;
                this.nombre = nombre;
                this.marca = marca;
                this.rubro = rubro;
                this.cantidad = cantidad;
                this.precio = precio;
            }
        }
    }
}
