[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET Автогенератор 

Этот проект является автоматическим создателем и наполняющим для генератора фейковых данных [Bogus](https://github.com/bchavez/Bogus). Это замена для заброшенной библиотеки [AutoBogus](https://github.com/nickdodd79/AutoBogus).

Цели:
- Быть *быстрым*
- Поддерживать новейшие типы в .NET

Использует самый быстрый .NET кеш отражений: [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache). Обновления Bogus интегрируются автоматически.

Поддерживается .NET 8+.

## Установка

```
dotnet add package Soenneker.Utils.AutoBogus
```

## Использование

- Создайте экземпляр `AutoFaker`:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- Вызовите `Generate<>()` для любого желаемого типа:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- Также возможно генерировать типы через аргумент:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- Задайте faker, конфигурацию, правила и т.д.:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

Рекомендуемый способ управления кастомизацией типа:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker доступен
        target.Name = context.Faker.Random.Word();

        // Также доступен AutoFaker
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

Затем просто добавьте `AutoFakerOverride` в экземпляр `AutoFaker.Config`:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

Наследует от `Bogus.Faker` и может использоваться для задания правил, специфичных для экземпляра `AutoFaker`.

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## Интерфейсы/Абстракции

Базовая библиотека не генерирует интерфейсы или абстрактные объекты, но эти пакеты позволяют создавать их моки:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## Советы
- ⚠️ Создание экземпляра `AutoFaker` занимает незначительное, но заметное время из-за инициализации Bogus `Faker` (почти 1 мс). Рекомендуется использовать один экземпляр, если возможно.
- Также доступен `AutoFaker.GenerateStatic<T>()`, но его следует избегать (так как он создает новый `AutoFaker`/`Faker` при каждом вызове).

## Примечания
- Некоторые шаблоны, существовавшие в AutoBogus, были удалены из-за сложности и влияния на производительность.
- Проект находится в разработке. Вклад приветствуется.

## Бенчмарки

### Soenneker.Utils.AutoBogus - `AutoFaker`

| Метод           | Среднее     | Ошибка    | StdDev    |
|-----------------|------------:|----------:|----------:|
| Generate_int    |    79.40 нс |  0.635 нс |  0.563 нс |
| Generate_string |   241.35 нс |  3.553 нс |  3.324 нс |
| Generate_complex| 6,782.34 нс | 43.811 нс | 38.837 нс |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| Метод           | Среднее    | Ошибка    | StdDev    |
|-----------------|-----------:|----------:|----------:|
| Generate_string |   283.6 нс |  3.28 нс  |  3.07 нс  |
| Generate_complex| 8,504.0 нс | 76.58 нс  | 67.89 нс  |

### AutoBogus

| Метод           | Среднее    | Ошибка    | StdDev    |
|-----------------|-----------:|----------:|----------:|
| Generate_int    |   1.17 мс  | 0.033 мс  | 0.026 мс  |
| Generate_complex|  10.91 мс  | 0.181 мс  | 0.236 мс  |

### Bogus

| Метод        | Среднее         | Ошибка        | StdDev        |
|--------------|----------------:|--------------:|--------------:|
| Bogus_int    |      19.70 нс   |     0.176 нс  |     0.165 нс  |
| Bogus_string |     171.75 нс   |     2.763 нс  |     2.585 нс  |
| Bogus_ctor   | 730,669.06 нс   | 8,246.622 нс  | 7,310.416 нс  |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---