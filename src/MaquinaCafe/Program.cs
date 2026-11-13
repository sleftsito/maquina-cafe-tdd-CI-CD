using MaquinaCafe;

// En este caso seria: pequeño = 3 oz, mediano = 5 oz y grande = 7 oz.
var maquina = new MaquinaDeCafe(
    new Cafetera(50),
    new Vaso(5, 3),
    new Vaso(5, 5),
    new Vaso(5, 7),
    new Azucarero(20)
);

Console.WriteLine("=== Máquina de café ===");

while (true)
{
    Console.WriteLine("\n1. Pequeño (3 oz)\n2. Mediano (5 oz)\n3. Grande (7 oz)\n4. Salir");
    Console.Write("Seleccione una opción: ");

    string? tipo = Console.ReadLine() switch
    {
        "1" => "pequeno",
        "2" => "mediano",
        "3" => "grande",
        "4" => null,
        _ => "invalido",
    };

    if (tipo is null)
        break;
    if (tipo == "invalido")
    {
        Console.WriteLine("Opción no válida.");
        continue;
    }

    Console.Write("¿Cuántas cucharadas de azúcar desea? ");
    if (!int.TryParse(Console.ReadLine(), out int azucar) || azucar < 0)
    {
        Console.WriteLine("Debe introducir un número entero mayor o igual a cero.");
        continue;
    }

    Vaso vaso = maquina.GetTipoDeVaso(tipo);
    Console.WriteLine(maquina.GetVasoDeCafe(vaso, 1, azucar));
}
