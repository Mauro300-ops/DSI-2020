using NUnit.Framework;

namespace TestCobranza
{
    public class TestsRecepcionPedido
    {
        public OrdenCompra ordenJson = new OrdenCompra();
        public const decimal COSTO_DE_ENVIO = 400;

        [Fact]
        public void LaOrdenJsonNoEstaVacia()
        {
            Assert.NotNull(ordenJson);
        }

        [Fact]
        public void LaOrdenJsonTieneArticulos()
        {
            Assert.NotNull(ordenJson.ArticulosVendidos);
        }

        [Fact]
        public void MontoDeJsonCalculadoCorrectamente()
        {

            var ordenJson = new OrdenCompra().obtenerDatosOrdenDeCompra();

            double suma = 0;
            foreach (var i in ordenJson.ArticulosVendidos)
            {
                suma = i.Precio + suma;
            }

            suma += COSTO_DE_ENVIO;

            Assert.Equal(ordenJson.Monto, suma);
        }

        [Fact]
        public void LaFechaDeLaCompraEsAntiguaOActual()
        {
            bool esFechaMenorQueActual = false;
            if (ordenJson.FechaVenta <= DateTime.Now)
            {
                esFechaMenorQueActual = true;
            }
            Assert.True(esFechaMenorQueActual);
        }
    }

    public class TestsValidacionCampos
    {
        public OrdenCompra ordenJson = new OrdenCompra();


        [Fact]
        public void LaFechaDelJsonEsTipoValido()
        {
            Assert.IsType<DateTime>(ordenJson.FechaVenta);
        }

        [Fact]
        public void ElMontoDelJsonEsTipoValido()
        {
            Assert.IsType<decimal>(ordenJson.Monto);
        }

        [Fact]
        public void LaListaDelJsonEsTipoValido()
        {
            Assert.IsType<List<ArticulosVendidos>>(ordenJson.ArticulosVendidos);
        }
    }

    public class TestEnvioPedido
    {
        public static OrdenDeCompra ordenJson = new OrdenDeCompra();
        public OrdenPaga ordenParaCarrito = new OrdenPaga(ordenJson, true);

        [Fact]
        public void LaOrdenParaCarritoNoEstaVacia()
        {
            ordenParaCarrito.generarOrdenACarrito();
            Assert.NotNull(ordenParaCarrito);
        }

        [Fact]
        public void LaOrdenEsAceptada()
        {
            Assert.True(ordenParaCarrito.EstadoConfirmacion);
        }
    }
}