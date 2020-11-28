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
        public class Tarjeta
        {
            public long NumeroDeTarjeta { get; set; }
            public string NombreTitular { get; set; }
            public int CodigoDeSeguridad { get; set; }
            public string EntidadEmisora { get; set; }
            public string FechaDeVencimiento { get; set; }
            public long DniTitular { get; set; }
            public string TipoTarjeta { get; set; }

            //Para tarjeta de crédito
            public int CantidadDeCuotas { get; set; }

            //Para tarjeta de débito
            public decimal SaldoDisponible { get; set; }

            public Tarjeta() { }
            public Tarjeta(long NumeroDeTarjeta, string NombreTitular, int CodigoDeSeguridad,
                         string EntidadEmisora, string FechaDeVencimiento, long DniTitular, string TipoTarjeta)
            {
                this.NumeroDeTarjeta = NumeroDeTarjeta;
                this.NombreTitular = NombreTitular;
                this.CodigoDeSeguridad = CodigoDeSeguridad;
                this.EntidadEmisora = EntidadEmisora;
                this.FechaDeVencimiento = FechaDeVencimiento;
                this.DniTitular = DniTitular;
                this.TipoTarjeta = TipoTarjeta;
            }

            public Tarjeta(long NumeroDeTarjeta, string NombreTitular, int CodigoDeSeguridad,
                         string EntidadEmisora, decimal SaldoDisponible, string FechaDeVencimiento, long DniTitular, string TipoTarjeta)
            {
                this.NumeroDeTarjeta = NumeroDeTarjeta;
                this.NombreTitular = NombreTitular;
                this.CodigoDeSeguridad = CodigoDeSeguridad;
                this.EntidadEmisora = EntidadEmisora;
                this.SaldoDisponible = SaldoDisponible;
                this.FechaDeVencimiento = FechaDeVencimiento;
                this.DniTitular = DniTitular;
                this.TipoTarjeta = TipoTarjeta;
            }
        }
    }
}
