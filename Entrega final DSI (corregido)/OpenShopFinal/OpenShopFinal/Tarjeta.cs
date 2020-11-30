using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OpenShopFinal
{
    public class Tarjeta
    {
        public long NumeroDeTarjeta { get; set; }
        public string NombreTitular { get; set; }
        public int CodigoDeSeguridad { get; set; }
        public string EntidadEmisora { get; set; }
        public string FechaDeVencimiento { get; set; }
        public double DniTitular { get; set; }
        public string TipoTarjeta { get; set; }
        public int CantidadDeCuotas { get; set; }


        public Tarjeta() 
        { 
        
        }
        
        public Tarjeta(long NumeroDeTarjeta, string NombreTitular, int CodigoDeSeguridad, 
                        string EntidadEmisora, string FechaDeVencimiento, double DniTitular, string TipoTarjeta, int CantidadDeCuotas)
        {
                this.NumeroDeTarjeta = NumeroDeTarjeta;
                this.NombreTitular = NombreTitular;
                this.CodigoDeSeguridad = CodigoDeSeguridad;
                this.EntidadEmisora = EntidadEmisora;
                this.FechaDeVencimiento = FechaDeVencimiento;
                this.DniTitular = DniTitular;
                this.TipoTarjeta = TipoTarjeta;
                this.CantidadDeCuotas = CantidadDeCuotas; 
        }
    }
    
}
