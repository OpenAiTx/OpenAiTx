[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### L'Autogeneratore .NET

Questo progetto è un creatore e popolatore automatico per il generatore di dati fittizi [Bogus](https://github.com/bchavez/Bogus). È un sostituto della libreria [AutoBogus](https://github.com/nickdodd79/AutoBogus) ormai abbandonata.

Gli obiettivi:
- Essere *veloce*
- Supportare gli ultimi tipi in .NET

Utilizza la cache Reflection .NET più veloce: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Gli aggiornamenti di Bogus sono integrati automaticamente.

È supportato .NET 8+.

## Installazione

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Utilizzo

- Crea un'istanza di `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Chiama `Generate<>()` su qualsiasi tipo desiderato:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- È anche possibile generare tipi tramite un argomento:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Imposta un faker, configurazione, regole, ecc.:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Questo è il modo consigliato per controllare la personalizzazione dei tipi:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker è disponibile
        target.Name = context.Faker.Random.Word();

        // Anche AutoFaker è disponibile
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Poi basta aggiungere `AutoFakerOverride` all'istanza di `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Questa eredita da `Bogus.Faker` e può essere usata per designare regole specifiche per l'istanza di `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfacce/Astratti

La libreria base non genera interfacce o oggetti astratti, ma queste ti permettono di generare dei mock degli stessi:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Suggerimenti
- ⚠️ L'istanziazione di un `AutoFaker` richiede un tempo non trascurabile a causa dell'inizializzazione di `Faker` di Bogus (quasi 1ms). Si consiglia di utilizzare una singola istanza se possibile.
- `AutoFaker.GenerateStatic<T>()` è anch'esso disponibile, ma dovrebbe essere evitato (poiché crea un nuovo `AutoFaker`/`Faker` ad ogni chiamata).

## Note
- Alcuni pattern presenti in AutoBogus sono stati rimossi a causa della complessità e dell'impatto sulle prestazioni.
- Questo è un work in progress. I contributi sono benvenuti.

## Benchmark

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Metodo           | Media       | Errore    | Dev.Std    |
|----------------- |------------:|----------:|-----------:|
| Generate_int     |    79.40 ns |  0.635 ns |   0.563 ns |
| Generate_string  |   241.35 ns |  3.553 ns |   3.324 ns |
| Generate_complex | 6,782.34 ns | 43.811 ns |  38.837 ns |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Metodo           | Media      | Errore    | Dev.Std    |
|----------------- |-----------:|----------:|-----------:|
| Generate_string  |   283.6 ns |  3.28 ns  |   3.07 ns  |
| Generate_complex | 8,504.0 ns | 76.58 ns  |  67.89 ns  |

### AutoBogus

| Metodo           | Media     | Errore    | Dev.Std    |
|----------------- |----------:|----------:|-----------:|
| Generate_int     |   1.17 ms | 0.033 ms  |  0.026 ms  |
| Generate_complex |  10.91 ms | 0.181 ms  |  0.236 ms  |

### Bogus

| Metodo       | Media         | Errore        | Dev.Std       |
|--------------|--------------:|--------------:|--------------:|
| Bogus_int    |      19.70 ns |     0.176 ns  |     0.165 ns  |
| Bogus_string |     171.75 ns |     2.763 ns  |     2.585 ns  |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns  | 7,310.416 ns  |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---