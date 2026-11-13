# Máquina de Café - Práctica de TDD (C#)

Proyecto sencillo para la asignatura **Introducción a la Ingeniería de Software**.
Basado en la guía «TDD Máquina Café».

## Autores

`Angel Gonzalez 2025-1122`
`Tomas Colon 2025-1195`
`Saul Rijo 2024-1706`

## Requisitos

- .NET SDK 8.0 o posterior con soporte para `net8.0`.
- Internet en la primera ejecución de pruebas para restaurar los paquetes xUnit de NuGet.

## Cómo ejecutar la aplicación

Desde la carpeta principal del proyecto:

```bash
dotnet run --project src/MaquinaCafe/MaquinaCafe.csproj
```

Selecciona un tamaño de vaso (pequeño, mediano o grande) y las cucharadas de azúcar.
La máquina comprueba las existencias, descuenta los recursos y muestra el resultado.
Puedes repetir pedidos hasta seleccionar **Salir**.

## Cómo ejecutar las pruebas TDD

```bash
dotnet test tests/MaquinaCafe.Tests/MaquinaCafe.Tests.csproj --logger "console;verbosity=detailed"
```

Con el nivel `detailed`, cada prueba muestra un mensaje `[OK]` en la consola
después de completar correctamente sus comprobaciones. Al final se muestra el
resumen de las 21 pruebas aprobadas.

Las pruebas están organizadas por componente:

| Archivo                 | Qué comprueba                              | Pruebas |
| ----------------------- | ------------------------------------------ | ------: |
| `VasoTests.cs`          | Disponibilidad y descuento de vasos        |       3 |
| `CafeteraTests.cs`      | Disponibilidad y descuento de café         |       3 |
| `AzucareroTests.cs`     | Disponibilidad y descuento de azúcar       |       3 |
| `MaquinaDeCafeTests.cs` | Tipos, falta de insumos, descuento y éxito |      12 |
| **Total**               | **19 casos de la guía + 2 adicionales**    |  **21** |

## Clases

- `Vaso`: cantidad disponible y volumen del vaso.
- `Cafetera`: cantidad disponible de café en onzas.
- `Azucarero`: cantidad disponible de azúcar en cucharadas.
- `MaquinaDeCafe`: comprueba los tres componentes y realiza el pedido.

## Criterios de aceptación

1. Permite seleccionar entre vaso pequeño, mediano y grande.
2. Permite elegir cucharadas de azúcar, incluyendo cero.
3. Comprueba y descuenta el vaso, el café y el azúcar en un pedido exitoso.
4. Muestra `No hay Vasos`, `No hay Cafe` o `No hay Azucar` si faltan insumos.
5. Muestra `Felicitaciones` cuando prepara correctamente el pedido.
6. No descuenta ningún insumo si el pedido no se puede preparar.

## Relación con TDD

Ciclo **Rojo → Verde → Refactorizar**:

1. **Rojo:** escribir una prueba que describa la conducta esperada y verla fallar.
2. **Verde:** escribir lo mínimo para que la prueba pase.
3. **Refactorizar:** mejorar el código manteniendo las pruebas en verde.

Los archivos de pruebas definen los casos de aceptación que guían la implementación.
El proyecto entregado incluye su versión funcional final; para demostrar el proceso
histórico de TDD durante la presentación, hay que ejecutar ese ciclo paso a paso.

## Organización

```text
maquina-cafe-tdd/
├── src/MaquinaCafe/
│   ├── MaquinaCafe.csproj
│   ├── Program.cs
│   ├── Vaso.cs
│   ├── Cafetera.cs
│   ├── Azucarero.cs
│   └── MaquinaDeCafe.cs
├── tests/MaquinaCafe.Tests/
│   ├── MaquinaCafe.Tests.csproj
│   ├── VasoTests.cs
│   ├── CafeteraTests.cs
│   ├── AzucareroTests.cs
│   └── MaquinaDeCafeTests.cs
└── README.md
```
