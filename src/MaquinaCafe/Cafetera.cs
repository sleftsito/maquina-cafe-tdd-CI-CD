namespace MaquinaCafe;

/// <summary>Guarda el café disponible, medido en onzas.</summary>
public class Cafetera
{
    public int CantidadCafe { get; private set; }

    public Cafetera(int cantidadCafe)
    {
        ArgumentOutOfRangeException.ThrowIfNegative(cantidadCafe);
        CantidadCafe = cantidadCafe;
    }

    public bool TieneCafe(int cantidad) => cantidad >= 0 && CantidadCafe >= cantidad;

    public void EntregarCafe(int cantidad)
    {
        if (!TieneCafe(cantidad))
            throw new InvalidOperationException("No hay Cafe");

        CantidadCafe -= cantidad;
    }
}
