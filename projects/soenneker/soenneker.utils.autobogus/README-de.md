[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### Der .NET Autogenerator

Dieses Projekt ist ein automatischer Ersteller und Befüller für den Fake-Daten-Generator [Bogus](https://github.com/bchavez/Bogus). Es ist ein Ersatz für die nicht mehr weiterentwickelte Bibliothek [AutoBogus](https://github.com/nickdodd79/AutoBogus).

Die Ziele:
- *Schnell* sein
- Unterstützung der neuesten Typen in .NET

Es verwendet den schnellsten .NET Reflection-Cache: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Bogus-Updates werden automatisch integriert.

.NET 8+ wird unterstützt.

## Installation

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Verwendung

- Erstellen Sie eine `AutoFaker`-Instanz:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Rufen Sie `Generate<>()` für jeden gewünschten Typ auf:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Es ist auch möglich, Typen über ein Argument zu generieren:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Faker, Konfiguration, Regeln usw. setzen:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Dies ist der empfohlene Weg zur Steuerung der Typanpassung:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker ist verfügbar
        target.Name = context.Faker.Random.Word();

        // AutoFaker ist ebenfalls verfügbar
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Dann einfach `AutoFakerOverride` zur `AutoFaker.Config`-Instanz hinzufügen:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Dies erbt von `Bogus.Faker` und kann verwendet werden, um Regeln spezifisch für die `AutoFaker`-Instanz festzulegen.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Schnittstellen/Abstrakte Klassen

Die Basisbibliothek generiert keine Schnittstellen oder abstrakten Objekte, aber diese ermöglichen es Ihnen, Mocks davon zu generieren:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Tipps
- ⚠️ Die Instanziierung eines `AutoFaker` benötigt eine nicht-triviale Zeit aufgrund der Initialisierung von Bogus `Faker` (fast 1 ms). Es wird empfohlen, wenn möglich eine einzige Instanz zu verwenden.
- `AutoFaker.GenerateStatic<T>()` ist ebenfalls verfügbar, sollte aber vermieden werden (da bei jedem Aufruf ein neuer `AutoFaker`/`Faker` erstellt wird).

## Hinweise
- Einige Muster, die in AutoBogus existierten, wurden aufgrund von Komplexität und Performance entfernt.
- Dies ist ein laufendes Projekt. Beiträge sind willkommen.

## Benchmarks

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Methode           | Mittelwert  | Fehler     | StdAbw     |
|-------------------|-------------|------------|------------|
| Generate_int      |    79,40 ns |  0,635 ns  |  0,563 ns  |
| Generate_string   |   241,35 ns |  3,553 ns  |  3,324 ns  |
| Generate_complex  | 6.782,34 ns | 43,811 ns  | 38,837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Methode           | Mittelwert  | Fehler     | StdAbw     |
|-------------------|-------------|------------|------------|
| Generate_string   |   283,6 ns  |  3,28 ns   |  3,07 ns   |
| Generate_complex  | 8.504,0 ns  | 76,58 ns   | 67,89 ns   |

### AutoBogus

| Methode           | Mittelwert  | Fehler     | StdAbw     |
|-------------------|-------------|------------|------------|
| Generate_int      |   1,17 ms   | 0,033 ms   | 0,026 ms   |
| Generate_complex  |  10,91 ms   | 0,181 ms   | 0,236 ms   |

### Bogus

| Methode       | Mittelwert      | Fehler         | StdAbw        |
|---------------|-----------------|---------------|---------------|
| Bogus_int     |      19,70 ns   |     0,176 ns  |     0,165 ns  |
| Bogus_string  |     171,75 ns   |     2,763 ns  |     2,585 ns  |
| Bogus_ctor    | 730.669,06 ns   | 8.246,622 ns  | 7.310,416 ns  |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---