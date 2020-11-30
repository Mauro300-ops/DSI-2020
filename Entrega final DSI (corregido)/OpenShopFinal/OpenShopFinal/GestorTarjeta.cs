using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShopFinal
{
    class GestorTarjeta
    {
        public static List<Tarjeta> Tarjetas = new List<Tarjeta>();

        public static void RegistrarTarjeta()
        {
            Console.WriteLine("REGISTRO DE TARJETA");
            Console.WriteLine("\nIngrese el tipo de tarjeta: ");
            string TipoTarjeta = Console.ReadLine();

            Console.WriteLine("\nIngrese el nombre del titular de la tarjeta: ");
            string NombreTitular = Console.ReadLine();

            Console.WriteLine("\nIngrese el DNI del titular de la tarjeta: ");
            var DniTitular = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el numero de la tarjeta: ");
            var NumeroDeTarjeta = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese el código de seguridad de la tarjeta: ");
            var CodigoDeSeguridad = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nIngrese la entidad emisora de la tarjeta: ");
            string EntidadEmisora = Console.ReadLine();

            Console.WriteLine("\nIngrese la fecha de caducidad de la tarjeta:  ");
            string FechaDeVencimiento = Console.ReadLine();

            Console.WriteLine("\nIngrese cantidad de cuotas (3, 6, 12):  ");
            var CantidadDeCuotas = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tarjeta guardada con éxito.");

           Tarjetas.Add(new Tarjeta(NumeroDeTarjeta, NombreTitular, CodigoDeSeguridad,
                                    EntidadEmisora, FechaDeVencimiento, DniTitular, TipoTarjeta, CantidadDeCuotas));
        }
    }
}
