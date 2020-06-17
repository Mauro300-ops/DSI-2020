using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Trabajo_Práctico_N_2
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }




    class cotizacion
    {
        public DateTime Fecha { get; set; }
        public material Material { get; set; }
        public double MetrosCuadrados { get; set; }
        public int CantBolsas { get; set; }
        public cliente Cliente { get; set; }
        public espesor Espesor { get; set; }
        public double Importe
        {
            get
            {
                double importe = 0;
                importe = MetrosCuadrados * Espesor.MetroCuadrado + (MetrosCuadrados / Espesor.RendimientoPorBolsa) * Material.precioBolsa;
                return importe;
            }

        }
        public cotizacion(DateTime fecha, material material, double metrosCuadrados, cliente cliente, espesor espesor)
        {
            Fecha = fecha;
            Material = material;
            MetrosCuadrados = metrosCuadrados;
            Cliente = cliente;
            Espesor = espesor;
        }

        public void MostrarCotizacion()
        {
            Console.WriteLine($"Cliente {Cliente.Nombre}, perteneciente a {Cliente.Empresa}");
            Console.WriteLine($"Su cotización es: Metros Cuadrados {MetrosCuadrados}. \n Material {Material.descripcion} de ${Material.precioBolsa} el precio de bolsa" +
                $" \n Espesor: {Espesor.descripcion}, de $ {Espesor.MetroCuadrado} cada metro cuadrado y un rendimiento {Espesor.RendimientoPorBolsa} bolsas. \n" +
                $" TOTAL: {Importe}");
        }
    }


    public class espesor
    {
        public string descripcion { get; set; }
        public double MetroCuadrado { get; set; }
        public double RendimientoPorBolsa { get; set; }

        public espesor(string Descripcion, double metroCuadrado, double rendimientoporBolsa)
        {
            descripcion = Descripcion;
            MetroCuadrado = metroCuadrado;
            RendimientoPorBolsa = rendimientoporBolsa;
        }

        class RegistroEspesor
        {
            public static List<espesor> Espesores = new List<espesor>();

            static RegistroEspesor()
            {
                Espesores.Add(new espesor("Aplicado en Pared 50 mm", 53.60, 2.25));
                Espesores.Add(new espesor("Aplicado en Pared 70 mm", 87.00, 3.15));
                Espesores.Add(new espesor("Aplicado en Pared 100 mm", 117.49, 4.5));
                Espesores.Add(new espesor("Aplicado en Pared 120 mm", 128.48, 5.4));
                Espesores.Add(new espesor("Aplicado en Pared 160 mm", 143.405, 7.2));
                Espesores.Add(new espesor("Aplicado en Pared 200 mm", 180.79, 9.00));
            }
        }

    }



    public class cliente
    {
        public string Nombre { get; set; }
        public string Empresa { get; set; }
        public string DireccionObra { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }

        public cliente(string nombre, string empresa, string direccionobra, string mail, string telefono)
        {
            Nombre = nombre;
            Empresa = empresa;
            DireccionObra = direccionobra;
            Mail = mail;
            Telefono = telefono;
        }
    }



    public class RegistroCliente
    {
        public static List<cliente> clientes = new List<cliente>();

        
    }


    public class material
    {
        public string descripcion { get; set; }
        public double precioBolsa { get; set; }

        public material(string Descripción, double PrecioBolsa)
        {
            descripcion = Descripción;
            precioBolsa = PrecioBolsa;
        }
    }



    class RegistroMaterial
    {
        public static List<material> Materiales = new List<material>();

        static RegistroMaterial()
        {
            Materiales.Add(new material("Aislante nn 356", 3400));
            Materiales.Add(new material("Aislante nn 123", 3500));
            Materiales.Add(new material("Aislante nn 566", 550));
        }
    }



    public static void MostrarMaterial()
    {
        Console.WriteLine("Cotizador: ");
        Console.WriteLine("Listado materiales: ");
        int pos = 1;

        foreach (var material in RegistroMaterial.Materiales)
        {
            Console.WriteLine();
            Console.WriteLine("$pos + { material.descripcion} $Precio por bolsa: {material.PrecioBolsa}");
            pos = pos + 1;
        }
    }




    public static void MostrarEspesor()
    {
        Console.WriteLine("Cotizador: ");
        Console.WriteLine("Listado espesores: ");
        int pos = 1;

        foreach (var espesor in RegistroEspesor.Espesores)
        {
            Console.WriteLine();
            Console.WriteLine("$ pos + { espesor.descripcion} $Precio por metro cuadrado: {espesor.MetroCuadrado}, Rendimiento por bolsa: {espesor.RendimientoPorBolsa");
            pos = pos + 1;
        }
    }



    public static void MostrarClientes()
    {

        Console.WriteLine("Listado clientes: ");
        int pos = 1;

        foreach (var cliente in RegistroCliente.clientes)
        {
            Console.WriteLine();
            Console.WriteLine("$ pos + Nombre: {cliente.Nombre}, de la empresa: {cliente.Empresa}");
            pos = pos + 1;
        }
    }

}