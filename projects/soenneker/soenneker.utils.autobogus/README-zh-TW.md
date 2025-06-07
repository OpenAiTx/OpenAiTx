[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET 自動產生器

本專案是一個用於假資料產生器 [Bogus](https://github.com/bchavez/Bogus) 的自動建立及填充工具，是已停止維護的 [AutoBogus](https://github.com/nickdodd79/AutoBogus) 函式庫的替代品。

目標：
- 要*快速*
- 支援 .NET 最新型別

它使用最快的 .NET Reflection 快取：[soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache)。Bogus 的更新會自動整合。

支援 .NET 8+。

## 安裝

```
dotnet add package Soenneker.Utils.AutoBogus
```

## 使用方式

- 建立一個 `AutoFaker` 實例：
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- 在任何型別上呼叫 `Generate<>()`：

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- 也可以透過參數產生型別：

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- 設定 faker、組態、規則等：

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

這是建議用於控制型別自訂的方式：

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

接著只要將 `AutoFakerOverride` 加入 `AutoFaker.Config` 實例：

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

此類別繼承自 `Bogus.Faker`，可用於指定該 `AutoFaker` 實例專屬的規則。

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## 介面/抽象類別

基礎函式庫不會產生介面或抽象物件，但可透過以下工具產生其模擬物件：

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## 小提示
- ⚠️ 實例化一個 `AutoFaker` 會耗費不少時間，因為需要初始化 Bogus 的 `Faker`（約 1 毫秒）。建議盡可能共用單一實例。
- 亦提供 `AutoFaker.GenerateStatic<T>()`，但應避免使用（每次呼叫都會建立新的 `AutoFaker`/`Faker`）。

## 備註
- 某些在 AutoBogus 中存在的模式已被移除，以避免複雜度與效能問題。
- 本專案仍在持續開發中，歡迎貢獻。

## 效能基準

### Soenneker.Utils.AutoBogus - `AutoFaker`

| 方法             | 平均值      | 誤差      | 標準差      |
|----------------- |------------:|----------:|------------:|
| Generate_int     |    79.40 ns |  0.635 ns |   0.563 ns  |
| Generate_string  |   241.35 ns |  3.553 ns |   3.324 ns  |
| Generate_complex | 6,782.34 ns | 43.811 ns |  38.837 ns  |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| 方法             | 平均值     | 誤差     | 標準差     |
|----------------- |-----------:|---------:|-----------:|
| Generate_string  |   283.6 ns |  3.28 ns |   3.07 ns  |
| Generate_complex | 8,504.0 ns | 76.58 ns |  67.89 ns  |

### AutoBogus

| 方法             | 平均值    | 誤差     | 標準差     |
|----------------- |----------:|---------:|-----------:|
| Generate_int     |   1.17 ms | 0.033 ms |  0.026 ms  |
| Generate_complex |  10.91 ms | 0.181 ms |  0.236 ms  |

### Bogus

| 方法         | 平均值        | 誤差         | 標準差        |
|------------- |--------------:|-------------:|--------------:|
| Bogus_int    |      19.70 ns |     0.176 ns |     0.165 ns  |
| Bogus_string |     171.75 ns |     2.763 ns |     2.585 ns  |
| Bogus_ctor   | 730,669.06 ns | 8,246.622 ns | 7,310.416 ns  |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---