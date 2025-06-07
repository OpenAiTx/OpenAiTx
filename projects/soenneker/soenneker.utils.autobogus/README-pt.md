[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### O Autogerador .NET

Este projeto é um criador e populador automático para o gerador de dados falsos [Bogus](https://github.com/bchavez/Bogus). É um substituto para a biblioteca abandonada [AutoBogus](https://github.com/nickdodd79/AutoBogus).

Os objetivos:
- Ser *rápido*
- Suportar os tipos mais recentes do .NET

Utiliza o cache de reflexão .NET mais rápido: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Atualizações do Bogus são integradas automaticamente.

.NET 8+ é suportado.

## Instalação

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Uso

- Crie uma instância de `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Chame `Generate<>()` em qualquer tipo desejado:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Também é possível gerar tipos via argumento:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Defina um faker, configuração, regras, etc:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Esta é a maneira recomendada para controlar a customização de tipos:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker está disponível
        target.Name = context.Faker.Random.Word();

        // AutoFaker também está disponível
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Depois, basta adicionar `AutoFakerOverride` à instância de `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Esta classe herda de `Bogus.Faker` e pode ser usada para definir regras específicas para a instância de `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Interfaces/Abstratos

A biblioteca base não gera interfaces ou objetos abstratos, mas estes pacotes permitem gerar mocks deles:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Dicas
- ⚠️ Instanciar um `AutoFaker` leva uma quantidade de tempo não trivial devido à inicialização do `Faker` do Bogus (quase 1ms). Recomenda-se que uma única instância seja usada, se possível.
- `AutoFaker.GenerateStatic<T>()` também está disponível, mas deve ser evitado (pois cria um novo `AutoFaker`/`Faker` a cada chamada).

## Observações
- Alguns padrões que existiam no AutoBogus foram removidos devido à complexidade e impacto na performance.
- Este projeto está em desenvolvimento. Contribuições são bem-vindas.

## Benchmarks

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Método           | Média       | Erro      | Desvio Padrão |
|----------------- |------------:|----------:|--------------:|
| Generate_int     |    79.40 ns |  0.635 ns |     0.563 ns  |
| Generate_string  |   241.35 ns |  3.553 ns |     3.324 ns  |
| Generate_complex | 6,782.34 ns | 43.811 ns |    38.837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Método           | Média      | Erro     | Desvio Padrão |
|----------------- |-----------:|---------:|--------------:|
| Generate_string  |   283.6 ns |  3.28 ns |     3.07 ns   |
| Generate_complex | 8,504.0 ns | 76.58 ns |    67.89 ns   |

### AutoBogus

| Método           | Média      | Erro     | Desvio Padrão |
|----------------- |----------:|---------:|--------------:|
| Generate_int     |   1.17 ms | 0.033 ms |    0.026 ms   |
| Generate_complex |  10.91 ms | 0.181 ms |    0.236 ms   |

### Bogus

| Método       | Média         | Erro         | Desvio Padrão |
|------------- |-------------:|-------------:|--------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns  |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns  |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns  |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---