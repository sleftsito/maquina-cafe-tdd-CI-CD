using Xunit;
using Xunit.Abstractions;

namespace MaquinaCafe.Tests;

public class VasoTests
{
    private readonly ITestOutputHelper _salida;

    public VasoTests(ITestOutputHelper salida)
    {
        _salida = salida;
    }

    [Fact]
    public void TieneVasos_DevuelveVerdadero_SiHaySuficientes()
    {
        var vasos = new Vaso(2, 10);

        Assert.True(vasos.TieneVasos(1));
        _salida.WriteLine("[OK] TieneVasos devuelve verdadero cuando hay suficientes vasos.");
    }

    [Fact]
    public void TieneVasos_DevuelveFalso_SiNoHaySuficientes()
    {
        var vasos = new Vaso(1, 10);

        Assert.False(vasos.TieneVasos(2));
        _salida.WriteLine("[OK] TieneVasos devuelve falso cuando no hay suficientes vasos.");
    }

    [Fact]
    public void EntregarVasos_DescuentaLaCantidad()
    {
        var vasos = new Vaso(5, 10);

        vasos.EntregarVasos(1);

        Assert.Equal(4, vasos.CantidadVasos);
        _salida.WriteLine("[OK] EntregarVasos descuenta correctamente la cantidad entregada.");
    }
}
