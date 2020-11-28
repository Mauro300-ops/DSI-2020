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
        public class OrdenPaga
        {

            public OrdenDeCompra ordenDeCompra { get; set; }
            public Pago Pago { get; set; }
     
            //Información a serializar que será necesaria para "Despacho"
            public OrdenPaga( OrdenDeCompra ordenDeCompra, bool estadoConfirmacion)
            {
                this.ordenDeCompra = ordenDeCompra;
                this.estadoConfirmacion = estadoConfirmacion;
            }

            //Aqui se realiza la serialización de la factura
            public OrdenPaga(OrdenDeCompra ordenDeCompra, Pago Pago)
            {
                this.ordenDeCompra = ordenDeCompra;
                this.Pago = Pago;
            }

            OrdenDeCompra OrdenJson = new OrdenDeCompra();

            public void generarOrdenCarrito()
            {
                const string RUTA_ARCHIVO_JSON = @"c:\datos\orden.json";

                OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();
                OrdenPaga ordenConfirmada = new OrdenPaga(OrdenJson, true);
                

                if (System.IO.File.Exists(RUTA_ARCHIVO_JSON))
                {
                    var ordenCompraEnJson = JsonConvert.SerializeObject(ordenConfirmada);
                    System.IO.File.WriteAllText("orden.json", ordenCompraEnJson);
                }
                else
                {
                    throw new Exception("No es posible exportar los datos debido a su inexistencia");
                }
            }
        }
    }
}

