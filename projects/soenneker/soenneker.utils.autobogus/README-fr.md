[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### L’autogénérateur .NET

Ce projet est un créateur et un remplisseur automatique pour le générateur de données factices [Bogus](https://github.com/bchavez/Bogus). Il remplace la bibliothèque abandonnée [AutoBogus](https://github.com/nickdodd79/AutoBogus).

Objectifs :
- Être *rapide*
- Prendre en charge les derniers types de .NET

Il utilise le cache de réflexion .NET le plus rapide : [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Les mises à jour de Bogus sont intégrées automatiquement.

.NET 8+ est pris en charge.

## Installation

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Utilisation

- Créez une instance d’`AutoFaker` :
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Appelez `Generate<>()` sur n’importe quel type souhaité :

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Il est également possible de générer des types via un argument :

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Définissez un faker, une configuration, des règles, etc. :

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Il s’agit de la méthode recommandée pour contrôler la personnalisation des types :

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker est disponible
        target.Name = context.Faker.Random.Word();

        // AutoFaker est également disponible
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Ajoutez ensuite simplement `AutoFakerOverride` à l’instance `AutoFaker.Config` :

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Ceci hérite de `Bogus.Faker`, et peut être utilisé pour définir des règles spécifiques à l’instance d’`AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfaces/Abstracts

La bibliothèque de base ne génère pas d’interfaces ni d’objets abstraits, mais ces packages permettent de générer des mocks de ceux-ci :

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Conseils
- ⚠️ L’instanciation d’un `AutoFaker` prend un temps non négligeable à cause de l’initialisation de `Faker` (presque 1ms). Il est recommandé d’utiliser une seule instance si possible.
- `AutoFaker.GenerateStatic<T>()` est également disponible, mais doit être évité (car il crée un nouvel `AutoFaker`/`Faker` à chaque appel).

## Remarques
- Certains motifs présents dans AutoBogus ont été retirés en raison de leur complexité et de leur impact sur les performances.
- Ce projet est en cours de développement. Toute contribution est la bienvenue.

## Benchmarks

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Méthode         | Moyenne    | Erreur    | Écart-type |
|-----------------|------------|-----------|------------|
| Generate_int    |    79,40 ns |  0,635 ns |  0,563 ns  |
| Generate_string |   241,35 ns |  3,553 ns |  3,324 ns  |
| Generate_complex| 6 782,34 ns | 43,811 ns | 38,837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Méthode         | Moyenne    | Erreur    | Écart-type |
|-----------------|----------- |---------- |----------- |
| Generate_string |   283,6 ns |  3,28 ns  |  3,07 ns   |
| Generate_complex| 8 504,0 ns | 76,58 ns  | 67,89 ns   |

### AutoBogus

| Méthode         | Moyenne    | Erreur    | Écart-type |
|-----------------|----------- |---------- |----------- |
| Generate_int    |   1,17 ms  | 0,033 ms  | 0,026 ms   |
| Generate_complex|  10,91 ms  | 0,181 ms  | 0,236 ms   |

### Bogus

| Méthode         | Moyenne         | Erreur         | Écart-type     |
|-----------------|-----------------|--------------- |--------------- |
| Bogus_int       |      19,70 ns   |     0,176 ns   |     0,165 ns   |
| Bogus_string    |     171,75 ns   |     2,763 ns   |     2,585 ns   |
| Bogus_ctor      | 730 669,06 ns   | 8 246,622 ns   | 7 310,416 ns   |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---