using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
    public class OrdenPaga
    {
        public OrdenDeCompra OrdenDeCompra { get; set; }
        public Pago Pago { get; set; }
        public OrdenDeCompra OrdenJson { get; set; }
        public bool EstadoConfirmacion { get; set; }

        public OrdenPaga()
        {

        }

        //Información a serializar que será necesaria para "Despacho"
        public OrdenPaga( OrdenDeCompra ordenDeCompra, bool estadoConfirmacion)
        {
            this.OrdenDeCompra = ordenDeCompra;
            this.EstadoConfirmacion = estadoConfirmacion;
        }

        //Aqui se realiza la serialización de la factura
        public OrdenPaga(OrdenDeCompra ordenDeCompra, Pago Pago)
        {
            this.OrdenDeCompra = ordenDeCompra;
            this.Pago = Pago;
        }

        public static void GenerarOrdenCarrito()
        {
            const string RUTA_ARCHIVO_JSON = @"c:\datos\orden.json";

            //OrdenJson = OrdenJson.obtenerDatosOrdenDeCompra();
                
            OrdenPaga ordenConfirmada = new OrdenPaga();
                
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

