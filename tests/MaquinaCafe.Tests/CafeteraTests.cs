using Xunit;
using Xunit.Abstractions;

namespace MaquinaCafe.Tests;

public class CafeteraTests
{
    private readonly ITestOutputHelper _salida;

    public CafeteraTests(ITestOutputHelper salida)
    {
        _salida = salida;
    }

    [Fact]
    public void TieneCafe_DevuelveVerdadero_SiHaySuficiente()
    {
        var cafetera = new Cafetera(10);

        Assert.True(cafetera.TieneCafe(5));
        _salida.WriteLine("[OK] TieneCafe devuelve verdadero cuando hay suficiente cafe.");
    }

    [Fact]
    public void TieneCafe_DevuelveFalso_SiNoHaySuficiente()
    {
        var cafetera = new Cafetera(10);

        Assert.False(cafetera.TieneCafe(11));
        _salida.WriteLine("[OK] TieneCafe devuelve falso cuando no hay suficiente cafe.");
    }

    [Fact]
    public void EntregarCafe_DescuentaLaCantidad()
    {
        var cafetera = new Cafetera(10);

        cafetera.EntregarCafe(7);

        Assert.Equal(3, cafetera.CantidadCafe);
        _salida.WriteLine("[OK] EntregarCafe descuenta correctamente la cantidad entregada.");
    }
}
