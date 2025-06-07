[![](https://img.shields.io/nuget/v/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.utils.autobogus/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.utils.autobogus/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.utils.autobogus.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.utils.autobogus/)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Utils.AutoBogus
### .NET オートジェネレーター

このプロジェクトは、フェイクデータジェネレーター [Bogus](https://github.com/bchavez/Bogus) のための自動作成・自動入力ツールです。廃止された [AutoBogus](https://github.com/nickdodd79/AutoBogus) ライブラリの代替です。

目標:
- *高速*であること
- .NETの最新の型をサポートすること

最速の .NET Reflection キャッシュ [soenneker.reflection.cache](https://github.com/soenneker/soenneker.reflection.cache) を使用しています。Bogusのアップデートも自動的に統合されます。

.NET 8+ に対応しています。

## インストール

```
dotnet add package Soenneker.Utils.AutoBogus
```

## 使い方

- `AutoFaker` インスタンスを作成します:
```csharp
var optionalConfig = new AutoFakerConfig();
var autoFaker = new AutoFaker(optionalConfig);
```

- 任意の型に対して `Generate<>()` を呼び出します:

```csharp
var randomWord = autoFaker.Generate<string>();
var dictionary = autoFaker.Generate<Dictionary<int, string>>();
var order = autoFaker.Generate<Order>();
```

- 引数で型を指定して生成することもできます:

```csharp
var randomWord = autoFaker.Generate(typeof(string));
```

- faker や設定、ルールなどを設定できます:

```csharp
autoFaker.Config.Faker = new Faker("de");
autoFaker.Config.RepeatCount = 3;
...
```

## `AutoFakerOverride`

型カスタマイズを制御する推奨方法です:

```csharp
public class OrderOverride : AutoFakerOverride<Order>
{
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as Order)!;
        target.Id = 123;
        
        // Fakerが利用可能
        target.Name = context.Faker.Random.Word();

        // AutoFakerも利用可能
        target.Customer = context.AutoFaker.Generate<Customer>();
     }
}
```

その後、`AutoFakerOverride` を `AutoFaker.Config` インスタンスに追加します:

```csharp
autoFaker.Config.Overrides = new List<AutoFakerGeneratorOverride>();
autoFaker.Config.Overrides.Add(new OrderOverride());
```

## `AutoFaker<T>`

これは `Bogus.Faker` から継承されており、`AutoFaker` インスタンス固有のルールを指定するために使用できます。

```csharp
var autoFaker = new AutoFaker<Order>();
autoFaker.RuleFor(x => x.Id, f => f.Random.Number());
var order = autoFaker.Generate();
```

## インターフェース／抽象クラス

基本ライブラリではインターフェースや抽象オブジェクトは生成されませんが、以下を利用することでモックの生成が可能です:

- [soenneker.utils.autobogus.moq](https://github.com/soenneker/soenneker.utils.autobogus.moq)
- [soenneker.utils.autobogus.nsubstitute](https://github.com/soenneker/soenneker.utils.autobogus.nsubstitute)
- [soenneker.utils.autobogus.fakeiteasy](https://github.com/soenneker/soenneker.utils.autobogus.fakeiteasy)

## ヒント
- ⚠️ `AutoFaker` のインスタンス化は、Bogusの `Faker` 初期化のために無視できない時間（ほぼ1ms）がかかります。可能であれば単一インスタンスの利用を推奨します。
- `AutoFaker.GenerateStatic<T>()` も利用可能ですが、呼び出しごとに新たな `AutoFaker`/`Faker` が作成されるため、避けてください。

## 注意事項
- AutoBogus に存在した一部のパターンは、複雑さやパフォーマンスへの影響により削除されています。
- 現在進行形のプロジェクトです。コントリビューションを歓迎します。

## ベンチマーク

### Soenneker.Utils.AutoBogus - `AutoFaker`

| メソッド           | 平均値         | 誤差      | 標準偏差     |
|-------------------|---------------:|----------:|-------------:|
| Generate_int      |    79.40 ns    |  0.635 ns |   0.563 ns   |
| Generate_string   |   241.35 ns    |  3.553 ns |   3.324 ns   |
| Generate_complex  | 6,782.34 ns    | 43.811 ns |  38.837 ns   |

### Soenneker.Utils.AutoBogus - `AutoFaker<T>`

| メソッド           | 平均値      | 誤差     | 標準偏差   |
|-------------------|------------:|---------:|-----------:|
| Generate_string   |   283.6 ns  |  3.28 ns |   3.07 ns  |
| Generate_complex  | 8,504.0 ns  | 76.58 ns |  67.89 ns  |

### AutoBogus

| メソッド           | 平均値     | 誤差     | 標準偏差   |
|-------------------|-----------:|---------:|-----------:|
| Generate_int      |   1.17 ms  | 0.033 ms |  0.026 ms  |
| Generate_complex  |  10.91 ms  | 0.181 ms |  0.236 ms  |

### Bogus

| メソッド         | 平均値          | 誤差         | 標準偏差       |
|------------------|----------------:|-------------:|---------------:|
| Bogus_int        |      19.70 ns   |    0.176 ns  |    0.165 ns    |
| Bogus_string     |     171.75 ns   |    2.763 ns  |    2.585 ns    |
| Bogus_ctor       | 730,669.06 ns   | 8,246.622 ns | 7,310.416 ns   |


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---