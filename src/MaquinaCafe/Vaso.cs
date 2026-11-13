namespace MaquinaCafe;

/// <summary>Controla las unidades disponibles de un tamaño de vaso.</summary>
public class Vaso
{
    public int CantidadVasos { get; private set; }
    public int Contenido { get; }

    public Vaso(int cantidadVasos, int contenido)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(cantidadVasos);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(contenido);

        CantidadVasos = cantidadVasos;
        Contenido = contenido;
    }

    public bool TieneVasos(int cantidad) => cantidad > 0 && CantidadVasos >= cantidad;

    public void EntregarVasos(int cantidad)
    {
        if (!TieneVasos(cantidad))
            throw new InvalidOperationException("No hay Vasos");

        CantidadVasos -= cantidad;
    }
}
