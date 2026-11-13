using Xunit;
using Xunit.Abstractions;

namespace MaquinaCafe.Tests;

public class AzucareroTests
{
    private readonly ITestOutputHelper _salida;

    public AzucareroTests(ITestOutputHelper salida)
    {
        _salida = salida;
    }

    [Fact]
    public void TieneAzucar_DevuelveVerdadero_SiHaySuficiente()
    {
        var azucarero = new Azucarero(10);

        Assert.True(azucarero.TieneAzucar(5));
        Assert.True(azucarero.TieneAzucar(10));
        _salida.WriteLine("[OK] TieneAzucar devuelve verdadero cuando hay suficiente azucar.");
    }

    [Fact]
    public void TieneAzucar_DevuelveFalso_SiNoHaySuficiente()
    {
        var azucarero = new Azucarero(10);

        Assert.False(azucarero.TieneAzucar(15));
        _salida.WriteLine("[OK] TieneAzucar devuelve falso cuando no hay suficiente azucar.");
    }

    [Fact]
    public void EntregarAzucar_DescuentaLaCantidad()
    {
        var azucarero = new Azucarero(10);

        azucarero.EntregarAzucar(5);
        Assert.Equal(5, azucarero.CantidadAzucar);

        azucarero.EntregarAzucar(2);
        Assert.Equal(3, azucarero.CantidadAzucar);
        _salida.WriteLine("[OK] EntregarAzucar descuenta correctamente la cantidad entregada.");
    }
}
