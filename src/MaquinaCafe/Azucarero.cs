namespace MaquinaCafe;

/// <summary>Guarda el azúcar disponible, medido en cucharadas.</summary>
public class Azucarero
{
    public int CantidadAzucar { get; private set; }

    public Azucarero(int cantidadAzucar)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(cantidadAzucar);
        CantidadAzucar = cantidadAzucar;
    }

    public bool TieneAzucar(int cantidad) => cantidad >= 0 && CantidadAzucar >= cantidad;

    public void EntregarAzucar(int cantidad)
    {
        if (!TieneAzucar(cantidad))
            throw new InvalidOperationException("No hay Azucar");

        CantidadAzucar -= cantidad;
    }
}
