[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### El Autogenerador .NET

Este proyecto es un creador y poblador automático para el generador de datos falsos [Bogus](https://github.com/bchavez/Bogus). Es un reemplazo para la biblioteca abandonada [AutoBogus](https://github.com/nickdodd79/AutoBogus).

Los objetivos:
- Ser *rápido*
- Soportar los últimos tipos en .NET

Utiliza la caché de reflexión .NET más rápida: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Las actualizaciones de Bogus se integran automáticamente.

Se soporta .NET 8+.

## Instalación

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Uso

- Crear una instancia de `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Llamar a `Generate<>()` en cualquier tipo que desees:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- También es posible generar tipos mediante un argumento:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Configurar un faker, configuración, reglas, etc:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Esta es la forma recomendada para controlar la personalización de tipos:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker está disponible
        target.Name = context.Faker.Random.Word();

        // AutoFaker también está disponible
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Luego solo añade `AutoFakerOverride` a la instancia de `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Esto hereda de `Bogus.Faker`, y puede usarse para designar reglas específicas para la instancia de `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfaces/Abstractos

La biblioteca base no genera interfaces u objetos abstractos, pero estas permiten generar mocks de ellos:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Consejos
- ⚠️ Instanciar un `AutoFaker` toma una cantidad de tiempo no trivial debido a la inicialización de `Faker` de Bogus (casi 1 ms). Se recomienda usar una sola instancia si es posible.
- `AutoFaker.GenerateStatic<T>()` también está disponible, pero debe evitarse (ya que crea un nuevo `AutoFaker`/`Faker` en cada llamada).

## Notas
- Algunos patrones que existían en AutoBogus han sido eliminados debido a su complejidad e impacto en el rendimiento.
- Este es un proyecto en desarrollo. Se aceptan contribuciones.

## Benchmarks

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Método          | Media       | Error     | StdDev    |
|-----------------|------------:|----------:|----------:|
| Generate_int    |    79.40 ns |  0.635 ns |  0.563 ns |
| Generate_string |   241.35 ns |  3.553 ns |  3.324 ns |
| Generate_complex| 6,782.34 ns | 43.811 ns | 38.837 ns |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Método          | Media      | Error    | StdDev   |
|-----------------|-----------:|---------:|---------:|
| Generate_string |   283.6 ns |  3.28 ns |  3.07 ns |
| Generate_complex| 8,504.0 ns | 76.58 ns | 67.89 ns |

### AutoBogus

| Método          | Media     | Error    | StdDev   |
|-----------------|----------:|---------:|---------:|
| Generate_int    |   1.17 ms | 0.033 ms | 0.026 ms |
| Generate_complex|  10.91 ms | 0.181 ms | 0.236 ms |

### Bogus

| Método      | Media         | Error        | StdDev       |
|-------------|--------------:|-------------:|-------------:|
| Bogus_int   |      19.70 ns |     0.176 ns |     0.165 ns |
| Bogus_string|     171.75 ns |     2.763 ns |     2.585 ns |
| Bogus_ctor  | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---