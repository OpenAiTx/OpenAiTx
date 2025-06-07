[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET 自动生成器

本项目是伪数据生成器 [Bogus](https://github.com/bchavez/Bogus) 的自动创建和填充工具。它是已废弃库 [AutoBogus](https://github.com/nickdodd79/AutoBogus) 的替代品。

目标：
- *快速*
- 支持 .NET 中最新的数据类型

它使用最快的 .NET 反射缓存：[soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache)。Bogus 的更新会被自动集成。

支持 .NET 8 及以上版本。

## 安装

```
dotnet add package Soenneker.Utils.AutoBogus
```

## 用法

- 创建一个 `AutoFaker` 实例：
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- 在任意类型上调用 `Generate<>()`：

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- 也可以通过参数生成类型：

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- 设置 faker、配置、规则等：

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

这是推荐的类型自定义控制方式：

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Faker 可用
        target.Name = context.Faker.Random.Word();

        // AutoFaker 也可用
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

然后只需将 `AutoFakerOverride` 添加到 `AutoFaker.Config` 实例中：

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

它继承自 `Bogus.Faker`，可用于为 `AutoFaker` 实例指定特定规则。

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## 接口/抽象类

基础库不会生成接口或抽象对象，但以下库可以让你生成这些类型的模拟对象：

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## 提示
- ⚠️ 实例化一个 `AutoFaker` 会消耗一定时间，因为 Bogus 的 `Faker` 初始化（约 1ms）。建议尽可能只使用单个实例。
- 也可以使用 `AutoFaker.GenerateStatic<T>()`，但应避免使用（因其每次调用都会新建一个 `AutoFaker`/`Faker`）。

## 说明
- 一些在 AutoBogus 中存在的模式已因复杂性和性能影响被移除。
- 本项目仍在持续开发中，欢迎贡献。

## 基准测试

### Soenneker.Utils.AutoBogus - `AutoFaker`

| 方法             | 平均值      | 误差      | 标准差     |
|------------------|------------:|----------:|-----------:|
| Generate_int     |    79.40 ns |  0.635 ns |  0.563 ns  |
| Generate_string  |   241.35 ns |  3.553 ns |  3.324 ns  |
| Generate_complex | 6,782.34 ns | 43.811 ns | 38.837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| 方法             | 平均值     | 误差     | 标准差    |
|------------------|-----------:|---------:|----------:|
| Generate_string  |   283.6 ns |  3.28 ns |  3.07 ns  |
| Generate_complex | 8,504.0 ns | 76.58 ns | 67.89 ns  |

### AutoBogus

| 方法             | 平均值   | 误差     | 标准差    |
|------------------|---------:|---------:|----------:|
| Generate_int     |   1.17 ms | 0.033 ms | 0.026 ms  |
| Generate_complex |  10.91 ms | 0.181 ms | 0.236 ms  |

### Bogus

| 方法         | 平均值         | 误差         | 标准差       |
|--------------|---------------:|-------------:|-------------:|
| Bogus_int    |      19.70 ns  |     0.176 ns |     0.165 ns |
| Bogus_string |     171.75 ns  |     2.763 ns |     2.585 ns |
| Bogus_ctor   | 730,669.06 ns  | 8,246.622 ns | 7,310.416 ns |

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---