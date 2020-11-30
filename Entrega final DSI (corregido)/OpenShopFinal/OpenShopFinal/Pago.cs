using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
   public class Pago
   {
      public bool Efectivo { get; set; }
      public Tarjeta Tarjeta { get; set; }
      public string TipoTarjeta { get; set; }
      public OrdenDeCompra OrdenJson { get; set; }


        public Pago(bool Efectivo)
        {
          this.Efectivo = Efectivo;
        }

        public Pago(Tarjeta Tarjeta, string TipoTarjeta)
        {
          this.Tarjeta = Tarjeta;
          this.TipoTarjeta = TipoTarjeta;
        }
        
        public Pago() 
        {
        
        }

        public void GenerarPago(bool metodoSeleccionado, OrdenDeCompra ordenJson, int tipoTarjeta)
        {
           //ordenJson = OrdenJson.obtenerDatosOrdenDeCompra();

           if (metodoSeleccionado)
           {
                Pago pagoRealizado = new Pago(true);
           }
           else
           {
                Pago pagoRealizado = new Pago(Tarjeta, Tarjeta.EntidadEmisora);
           }
        }
   }
    
}
