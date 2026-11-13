namespace MaquinaCafe;

/// <summary>Comprueba los ingredientes y prepara el café solicitado.</summary>
public class MaquinaDeCafe
{
    private readonly Cafetera _cafetera;
    private readonly Vaso _vasosPequenos;
    private readonly Vaso _vasosMedianos;
    private readonly Vaso _vasosGrandes;
    private readonly Azucarero _azucarero;

    public MaquinaDeCafe(
        Cafetera cafetera,
        Vaso vasosPequenos,
        Vaso vasosMedianos,
        Vaso vasosGrandes,
        Azucarero azucarero
    )
    {
        _cafetera = cafetera;
        _vasosPequenos = vasosPequenos;
        _vasosMedianos = vasosMedianos;
        _vasosGrandes = vasosGrandes;
        _azucarero = azucarero;
    }

    public Vaso GetTipoDeVaso(string tipo) =>
        tipo.ToLowerInvariant() switch
        {
            "pequeno" => _vasosPequenos,
            "mediano" => _vasosMedianos,
            "grande" => _vasosGrandes,
            _ => throw new ArgumentException("Tamaño de vaso no válido", nameof(tipo)),
        };

    public string GetVasoDeCafe(Vaso vaso, int cantidadDeVasos, int cucharadasDeAzucar)
    {
        ArgumentNullException.ThrowIfNull(vaso);
        ArgumentOutOfRangeException.ThrowIfNegativeOrZero(cantidadDeVasos);
        ArgumentOutOfRangeException.ThrowIfNegative(cucharadasDeAzucar);

        int cafeNecesario = checked(vaso.Contenido * cantidadDeVasos);
        int azucarNecesaria = checked(cucharadasDeAzucar * cantidadDeVasos);

        // Verificamos todo antes de descontar para evitar consumos incompletos.
        if (!vaso.TieneVasos(cantidadDeVasos))
            return "No hay Vasos";
        if (!_cafetera.TieneCafe(cafeNecesario))
            return "No hay Cafe";
        if (!_azucarero.TieneAzucar(azucarNecesaria))
            return "No hay Azucar";

        vaso.EntregarVasos(cantidadDeVasos);
        _cafetera.EntregarCafe(cafeNecesario);
        _azucarero.EntregarAzucar(azucarNecesaria);

        return "Felicitaciones";
    }
}
