[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### De .NET Autogenerator

Dit project is een automatische maker en invuller voor de nepgegevensgenerator [Bogus](https://github.com/bchavez/Bogus). Het is een vervanging voor de verlaten [AutoBogus](https://github.com/nickdodd79/AutoBogus) bibliotheek.

De doelstellingen:
- *Snel* zijn
- Ondersteuning voor de nieuwste types in .NET

Het gebruikt de snelste .NET Reflection-cache: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Bogus-updates worden automatisch geïntegreerd.

.NET 8+ wordt ondersteund.

## Installatie

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Gebruik

- Maak een `AutoFaker`-instantie aan:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Roep `Generate<>()` aan op elk gewenst type:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Het is ook mogelijk om types te genereren via een argument:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Stel een faker, configuratie, regels, enz. in:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Dit is de aanbevolen manier om type-aanpassingen te beheren:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker is beschikbaar
        target.Name = context.Faker.Random.Word();

        // AutoFaker is ook beschikbaar
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Voeg vervolgens gewoon `AutoFakerOverride` toe aan de `AutoFaker.Config`-instantie:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Dit erft van `Bogus.Faker`, en kan gebruikt worden om regels toe te wijzen die specifiek zijn voor de `AutoFaker`-instantie.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfaces/Abstracties

De basismodule genereert geen interfaces of abstracte objecten, maar deze stellen je in staat om mocks hiervan te genereren:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Tips
- ⚠️ Het aanmaken van een `AutoFaker` kost een niet-triviale hoeveelheid tijd vanwege de initialisatie van Bogus `Faker` (bijna 1ms). Het is aanbevolen om, indien mogelijk, één enkele instantie te gebruiken.
- `AutoFaker.GenerateStatic<T>()` is ook beschikbaar, maar moet worden vermeden (omdat het bij elke aanroep een nieuwe `AutoFaker`/`Faker` maakt).

## Opmerkingen
- Sommige patronen die bestonden in AutoBogus zijn verwijderd vanwege de complexiteit en impact op de prestaties.
- Dit is een werk in uitvoering. Bijdragen zijn welkom.

## Benchmarks

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Methode          | Gemiddelde | Fout      | StdDev     |
|----------------- |-----------:|----------:|-----------:|
| Generate_int     |   79,40 ns |  0,635 ns |  0,563 ns  |
| Generate_string  |  241,35 ns |  3,553 ns |  3,324 ns  |
| Generate_complex | 6.782,34 ns| 43,811 ns | 38,837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Methode          | Gemiddelde | Fout     | StdDev    |
|----------------- |-----------:|---------:|----------:|
| Generate_string  |   283,6 ns |  3,28 ns |  3,07 ns  |
| Generate_complex | 8.504,0 ns | 76,58 ns | 67,89 ns  |

### AutoBogus

| Methode          | Gemiddelde | Fout      | StdDev    |
|----------------- |-----------:|----------:|----------:|
| Generate_int     |   1,17 ms  | 0,033 ms  | 0,026 ms  |
| Generate_complex |  10,91 ms  | 0,181 ms  | 0,236 ms  |

### Bogus

| Methode      | Gemiddelde     | Fout         | StdDev       |
|------------- |---------------:|-------------:|-------------:|
| Bogus_int    |      19,70 ns  |     0,176 ns |     0,165 ns |
| Bogus_string |     171,75 ns  |     2,763 ns |     2,585 ns |
| Bogus_ctor   | 730.669,06 ns  | 8.246,622 ns | 7.310,416 ns |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---