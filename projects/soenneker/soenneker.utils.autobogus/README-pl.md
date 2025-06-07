[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET Autogenerator

Ten projekt jest automatycznym kreatorem i wypełniaczem dla generatora fałszywych danych [Bogus](https://github.com/bchavez/Bogus). Jest to zamiennik porzuconej biblioteki [AutoBogus](https://github.com/nickdodd79/AutoBogus).

Cele:
- Być *szybkim*
- Obsługiwać najnowsze typy w .NET

Wykorzystuje najszybszy cache refleksji .NET: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Aktualizacje Bogus są automatycznie integrowane.

Obsługiwana jest wersja .NET 8+.

## Instalacja

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Użycie

- Utwórz instancję `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Wywołaj `Generate<>()` na dowolnym typie:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Możliwe jest również generowanie typów poprzez argument:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Ustaw faker, konfigurację, reguły itp.:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Jest to zalecany sposób kontrolowania dostosowania typów:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker jest dostępny
        target.Name = context.Faker.Random.Word();

        // AutoFaker również jest dostępny
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Następnie po prostu dodaj `AutoFakerOverride` do instancji `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Dziedziczy po `Bogus.Faker` i może być używany do określania reguł specyficznych dla instancji `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfejsy/Typy abstrakcyjne

Biblioteka bazowa nie generuje interfejsów ani obiektów abstrakcyjnych, ale poniższe rozszerzenia umożliwiają generowanie ich atrap:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Wskazówki
- ⚠️ Tworzenie instancji `AutoFaker` zajmuje niezerową ilość czasu z powodu inicjalizacji Bogus `Faker` (prawie 1 ms). Zaleca się, aby używać pojedynczej instancji, jeśli to możliwe.
- `AutoFaker.GenerateStatic<T>()` jest również dostępny, ale powinno się go unikać (ponieważ za każdym razem tworzy nowy `AutoFaker`/`Faker`).

## Uwagi
- Niektóre wzorce, które istniały w AutoBogus, zostały usunięte ze względu na złożoność i wpływ na wydajność.
- Projekt jest w fazie rozwoju. Wkład jest mile widziany.

## Benchmarki

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Metoda           | Średnia     | Błąd      | Odchylenie standardowe |
|----------------- |------------:|----------:|-----------------------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns             |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns             |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns             |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Metoda           | Średnia    | Błąd     | Odchylenie standardowe |
|----------------- |-----------:|---------:|-----------------------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns              |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns              |

### AutoBogus

| Metoda           | Średnia   | Błąd     | Odchylenie standardowe |
|----------------- |----------:|---------:|-----------------------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms              |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms              |

### Bogus

| Metoda       | Średnia         | Błąd         | Odchylenie standardowe |
|------------- |----------------:|-------------:|-----------------------:|
| Bogus_int    |      19.70 ns   |     0.176 ns |     0.165 ns           |
| Bogus_string |     171.75 ns   |     2.763 ns |     2.585 ns           |
| Bogus_ctor   | 730,669.06 ns   | 8,246.622 ns | 7,310.416 ns           |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---