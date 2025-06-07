[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### The .NET Autogenerator 

This project is an automatic creator and populator for the fake data generator [Bogus](https://github.com/bchavez/Bogus). It's a replacement for the abandoned [AutoBogus](https://github.com/nickdodd79/AutoBogus) library.

The goals:
- Be *fast*
- Support the latest types in .NET

It uses the fastest .NET Reflection cache: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Bogus updates are automatically integrated.

.NET 8+ is supported.

## Installation

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Usage

- Create an `AutoFaker` instance:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Call `Generate<>()` on any type you want:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- It's also possible to generate types via an argument:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Set a faker, configuration, rules, etc:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

This is the recommended way for controlling type customization:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker is available
        target.Name = context.Faker.Random.Word();

        // AutoFaker is also available
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Then just add `AutoFakerOverride` to the `AutoFaker.Config` instance:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

This inherits from `Bogus.Faker`, and can be used to designate rules specific to the `AutoFaker` instance.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfaces/Abstracts

The base library does not generate interfaces or abstract objects, but these enable you to generate mocks of them:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Tips
- ⚠️ Instantiating an `AutoFaker` takes a non-trivial amount of time because of Bogus `Faker` initialization (almost 1ms). It's recommended that a single instance be used if possible.
- `AutoFaker.GenerateStatic<T>()` is also available, but should be avoided (as it creates a new `AutoFaker`/`Faker` on each call).

## Notes
- Some patterns that existed in AutoBogus have been removed due to the complexity and performance impact.
- This is a work in progress. Contribution is welcomed.

## Benchmarks

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Method           | Mean        | Error     | StdDev    |
|----------------- |------------:|----------:|----------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Method           | Mean       | Error    | StdDev   |
|----------------- |-----------:|---------:|---------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns |

### AutoBogus

| Method           | Mean      | Error    | StdDev   |
|----------------- |----------:|---------:|---------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms |

### Bogus

| Method       | Mean          | Error        | StdDev       |
|------------- |--------------:|-------------:|-------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---